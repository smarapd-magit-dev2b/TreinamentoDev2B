using AutoMapper;
using Commom.Dto;
using Commom.Exceptions;
using Commom.Helpers;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class PersonAplicationService : IPersonAplicationService
    {
        private readonly IPersonUnitOfWork _uow;
        private static readonly MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Person, PersonPostDto>().ReverseMap();
            cfg.CreateMap<Person, PersonPatchDtoEssential>().ReverseMap();
            cfg.CreateMap<PersonGetDto, Person>().ReverseMap();
        });
        private readonly IMapper mapper = new Mapper(config);

        public PersonAplicationService(IPersonUnitOfWork uow) => _uow = uow;

        #region Get
        public List<PersonGetDto> Get()
        {
            List<Person> people = _uow.PersonRepository.Get();

            if (people == null)
                throw new DomainException("There are no people registered");

            List<PersonGetDto> peopleDto = people.Select(p => mapper.Map<PersonGetDto>(p)).ToList();

            return peopleDto;
        }

        public PersonGetDto Get(int id)
        {
            Person person = _uow.PersonRepository.GetById(id);

            if (person == null)
                throw new DomainException($"Person with Id {id} does not exist");

            PersonGetDto personDto = mapper.Map<PersonGetDto>(person);

            return personDto;
        }
        #endregion

        #region Post
        public int Post(PersonPostDto personDto)
        {
            PersonValidate(personDto);

            Person person = mapper.Map<Person>(personDto);

            person.Id = _uow.PersonRepository.GetNextId();
            person.Status = true;

            _uow.PersonRepository.Post(person);

            return person.Id;
        }

        public int Post(int id, PersonPostDto personDto)
        {
            Get(id);

            int idSon = Post(personDto);

            _uow.PersonRepository.Patch(id, idSon);

            return idSon;
        }

        public List<int> Post(int id, List<PersonPostDto> peopleDto)
        {
            Get(id);

            foreach (PersonPostDto personDto in peopleDto)
                PersonValidate(personDto);

            List<int> idSons = new List<int>();

            List<Person> people = new List<Person>();

            foreach (PersonPostDto personDto in peopleDto)
            {
                Person person = mapper.Map<Person>(personDto);

                if (idSons.Any())
                    idSons.Add(idSons.Max() + 1);
                else
                    idSons.Add(_uow.PersonRepository.GetNextId());

                person.Id = idSons.Max();
                person.Status = true;

                people.Add(person);
            }

            _uow.PersonRepository.Post(people);

            _uow.PersonRepository.Patch(id, idSons);

            return idSons;
        }
        #endregion

        #region Put
        public int Put(int id, PersonPostDto personDto)
        {
            PersonGetDto personGetDto = Get(id);

            PersonValidate(personDto);

            Person person = mapper.Map<Person>(personDto);

            person.Id = id;
            person.Status = personGetDto.Status;
            person.Sons = mapper.Map<Person>(personGetDto.Sons).Sons;

            _uow.PersonRepository.Put(person);

            return id;
        }
        #endregion

        #region Patch
        public int PatchEssential(int id, PersonPatchDtoEssential personDto)
        {
            Get(id);

            PersonValidateEssential(personDto);

            Person person = mapper.Map<Person>(personDto);

            person.Id = id;

            _uow.PersonRepository.PatchEssential(person);

            return id;
        }

        public int PatchStatus(int id, bool status)
        {
            PersonGetDto person = Get(id);

            if (status == person.Status)
                throw new DomainException($"Person with Id {id} {(status ? "is already active" : "is already disabled")}");

            _uow.PersonRepository.PatchStatus(id);

            return id;
        }
        #endregion

        #region Delete
        public int Delete(int id)
        {
            PersonGetDto person = Get(id);

            if (person.Status)
                throw new DomainException("Cannot delete Active users");

            _uow.PersonRepository.Delete(id);

            return id;
        }
        #endregion

        #region Validate
        private void PersonValidateEssential(PersonPatchDtoEssential personDto)
        {
            if (string.IsNullOrEmpty(personDto.Name))
                throw new DomainException("The Name field must be filled");

            if (personDto.Name.Length < 5)
                throw new DomainException("Name cannot be less than 5 letters");

            if (string.IsNullOrEmpty(personDto.LastName))
                throw new DomainException("The Last name field must be filled");

            if (string.IsNullOrEmpty(personDto.BirthDate))
                throw new DomainException("The CPF field must be filled");

            if (!CpfHelper.Valido(personDto.BirthDate))
                throw new DomainException("Invalid CPF");
        }
        private void PersonValidate(PersonPostDto personDto)
        {
            PersonValidateEssential(new PersonPatchDtoEssential()
            {
                Name = personDto.Name,
                LastName = personDto.LastName,
                BirthDate = personDto.Cpf
            });

            if (DateTimeHelper.Idade(personDto.BirthDate) < 18)
                throw new DomainException("Only adults of legal age are accepted.");
        }
        #endregion
    }
}
