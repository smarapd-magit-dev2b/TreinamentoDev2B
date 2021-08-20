using Commom.Dto.Address;
using Commom.Dto.Discipline;
using Commom.Dto.Teacher;
using Commom.Exceptions;
using Commom.Helpers;
using Domain;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.AplicationService
{
    public class TeacherAplicationService : ITeacherAplicationService
    {
        private readonly ITeacherUnitOfWork _uow;

        public TeacherAplicationService(ITeacherUnitOfWork uow) => _uow = uow;

        #region Get
        public IEnumerable<TeacherGetDto> GetAll()
        {
            IEnumerable<Teacher> teachers = _uow.TeacherRepository
                                                .GetUntracked()
                                                .Include(teacher => teacher.Address)
                                                .Include(teacher => teacher.Disciplines);

            IEnumerable<TeacherGetDto> dtos = Create(teachers);

            return dtos;
        }

        private async Task<Teacher> GetByIdTracked(int id) => await _uow.TeacherRepository
                                                            .GetTracked()
                                                            .FirstOrDefaultAsync(teacher => teacher.Id == id);

        private async Task<Teacher> GetByIdTrackedWithDisciplines(int id) => await _uow.TeacherRepository
                                                    .GetTracked()
                                                    .Include(teacher => teacher.Disciplines)
                                                    .FirstOrDefaultAsync(teacher => teacher.Id == id);

        private IEnumerable<Discipline> GetDisciplines(IEnumerable<int> idDisciplines)
        {
            if (idDisciplines == null)
                return null;
            List<Discipline> disciplines = new List<Discipline>();

            IdsDisciplinesValidate(idDisciplines);

            foreach (int id in idDisciplines)
            {
                Discipline discipline = _uow.DisciplineRepository
                                            .GetTracked()
                                            .FirstOrDefault(discipline => discipline.Id == id);

                disciplines.Add(discipline);
            }

            return disciplines;
        }
        #endregion

        #region Post
        public async Task<int> Post(TeacherPostDto dto)
        {
            Teacher teacher = Create(dto);

            PostValidate(teacher);

            await _uow.TeacherRepository.Post(teacher);

            await _uow.Commit();

            return teacher.Id;
        }
        #endregion

        #region Put
        public async Task Put(int id, TeacherPutDto dto)
        {
            IdValidate(id);

            Teacher teacher = await GetByIdTracked(id);

            Update(teacher, dto);

            await _uow.Commit();
        }
        #endregion

        #region Delete
        public async Task Delete (int id)
        {
            IdValidate(id);

            Teacher teacher = await GetByIdTrackedWithDisciplines(id);

            foreach (Discipline discipline in teacher.Disciplines)
                discipline.IdTeacher = null;

            _uow.TeacherRepository.Delete(teacher);

            await _uow.Commit();
        }
        #endregion

        #region Create
        private Teacher Create(TeacherPostDto dto)
        {
            Teacher teacher = new Teacher()
            {
                Email = dto.Email,
                AdmissionDate = dto.AdmissionDate,
                BirthDate = dto.BirthDate,
                Cpf = dto.Cpf,
                FluentEnglish = dto.FluentEnglish,
                Formation = dto.Formation,
                FullName = dto.FullName,
                Phone = dto.Phone,
                ProfessionalExperience = dto.ProfessionalExperience,
                Wage = dto.Wage,
                Disciplines = GetDisciplines(dto.IdDisciplines)
            };

            ChooseAddress(teacher, dto);

            return teacher;
        }

        private Address Create(AddressPostDto addressDto) =>
            new Address()
            {
                Cep = addressDto.Cep,
                City = addressDto.City,
                District = addressDto.District,
                Number = addressDto.Number,
                State = addressDto.State,
                Street = addressDto.Street
            };
        
        private IEnumerable<TeacherGetDto> Create(IEnumerable<Teacher> teachers) =>
            teachers.Select(teacher => new TeacherGetDto()
            {
                Address = Create(teacher.Address),
                Id = teacher.Id,
                AdmissionDate = teacher.AdmissionDate,
                BirthDate = teacher.BirthDate,
                Cpf = teacher.Cpf,
                Disciplines = Create(teacher.Disciplines),
                Email = teacher.Email,
                FluentEnglish = teacher.FluentEnglish,
                Formation = teacher.Formation,
                FullName = teacher.FullName,
                Phone = teacher.Phone,
                ProfessionalExperience = teacher.ProfessionalExperience,
                Wage = teacher.Wage
            });
        private IEnumerable<DisciplineGetDto> Create(IEnumerable<Discipline> disciplines) =>
            disciplines.Select(discipline => new DisciplineGetDto()
            {
                Cid = discipline.Cid,
                Description = discipline.Description,
                Id = discipline.Id,
                InclusionDate = discipline.InclusionDate
            });
        private AddressGetDto Create(Address address) =>
            new AddressGetDto
            {
                Cep = address.Cep,
                City = address.City,
                District = address.District,
                Id = address.Id,
                Number = address.Number,
                State = address.State,
                Street = address.Street
            };
        #endregion

        #region Update
        private void Update(Teacher teacher, TeacherPutDto dto)
        {
            AdmissionDateUpdate(teacher, dto.AdmissionDate);

            BirthDateUpdate(teacher, dto.BirthDate);

            EmailUpdate(teacher, dto.Email);

            FluentEnglishUpdate(teacher, dto.FluentEnglish);

            FormationUpdate(teacher, dto.Formation);

            IdsDisciplineUpdate(teacher, dto.IdsDiscipline);

            PhoneUpdate(teacher, dto.Phone);

            ProfessionalExperienceUpdate(teacher, dto.ProfessionalExperience);

            WageUpdate(teacher, dto.Wage);

            int? addressDto = dto.IdAddress;
            if (addressDto.HasValue)
                teacher.IdAddress = addressDto.Value;
            else Update(teacher, dto.Address);
        }

        private void Update(Teacher teacher, AddressPostDto dto)
        {
            Address address = teacher.Address;

            if(address != null)
            {
                CepUpdate(address, dto.Cep);

                CityUpdate(address, dto.City);

                DistrictUpdate(address, dto.District);

                NumberUpdate(address, dto.Number);

                StateUpdate(address, dto.State);

                StreetUpdate(address, dto.Street);
            }
        }

        #region Props Teacher
        private void BirthDateUpdate(Teacher teacher, DateTime? birthDate)
        {
            if (birthDate.HasValue)
            {
                teacher.BirthDate = birthDate.Value;

                BirthDateValidate(teacher.BirthDate);
            }
        }

        private void WageUpdate(Teacher teacher, decimal? wage)
        {
            if (wage.HasValue)
            {
                teacher.Wage = wage.Value;

                WageValidate(teacher.Wage);
            }
        }

        private void ProfessionalExperienceUpdate(Teacher teacher, string professionalExperience)
        {
            if (!string.IsNullOrEmpty(professionalExperience))
                teacher.ProfessionalExperience = professionalExperience;
        }

        private void PhoneUpdate(Teacher teacher, string phone)
        {
            if (!string.IsNullOrEmpty(phone))
                teacher.Phone = phone;
        }

        private void IdsDisciplineUpdate(Teacher teacher, IEnumerable<int> idsDiscipline)
        {
            if (idsDiscipline != null)
            {
                IdsDisciplinesValidate(idsDiscipline);

                teacher.Disciplines = GetDisciplines(idsDiscipline);
            }
        }

        private void FormationUpdate(Teacher teacher, string formation)
        {
            if (!string.IsNullOrEmpty(formation))
                teacher.Formation = formation;
        }

        private void FluentEnglishUpdate(Teacher teacher, bool? fluentEnglish)
        {
            if (fluentEnglish.HasValue)
                teacher.FluentEnglish = fluentEnglish.Value;
        }

        private void AdmissionDateUpdate(Teacher teacher, DateTime? admissionDate)
        {
            if (admissionDate.HasValue)
                teacher.AdmissionDate = admissionDate.Value;
        }

        private void EmailUpdate(Teacher teacher, string email)
        {
            if (!string.IsNullOrEmpty(email))
                teacher.Email = email;
        }
        #endregion

        #region Props Address
        private void CepUpdate(Address address, string cep)
        {
            if (!string.IsNullOrEmpty(cep))
                address.Cep = cep;
        }
        private void CityUpdate(Address address, string city)
        {
            if (!string.IsNullOrEmpty(city))
                address.City = city;
        }
        private void DistrictUpdate(Address address, string district)
        {
            if (!string.IsNullOrEmpty(district))
                address.District = district;
        }
        private void NumberUpdate(Address address, string number)
        {
            if (!string.IsNullOrEmpty(number))
                address.Number = number;
        }
        private void StateUpdate(Address address, string state)
        {
            if (!string.IsNullOrEmpty(state))
            {
                address.State = state;

                StateValidate(address.State);
            }
        }
        private void StreetUpdate(Address address, string street)
        {
            if (!string.IsNullOrEmpty(street))
                address.Street = street;
        }
        #endregion

        #endregion

        #region Choices
        private void ChooseAddress(Teacher teacher, TeacherPostDto dto)
        {
            int? idAddressDto = dto.IdAddress;

            if (idAddressDto.HasValue && idAddressDto != 0)
                teacher.IdAddress = idAddressDto.Value;
            else if (dto.Address != null)
            {
                AddressPostDto AddressDto = dto.Address;

                Address existAddres = _uow.AddressRepository
                                          .GetUntracked()
                                          .FirstOrDefault(address => address.Cep == AddressDto.Cep &&
                                          address.City == AddressDto.City &&
                                          address.District == AddressDto.District &&
                                          address.Number == AddressDto.Number &&
                                          address.State == AddressDto.State &&
                                          address.Street == AddressDto.Street);

                if (existAddres == null)
                    teacher.Address = Create(AddressDto);
                else teacher.IdAddress = existAddres.Id;
            }
            else throw new DomainException("enter either the address id or the address");
        }
        #endregion

        #region Validate
        private void PostValidate(Teacher teacher)
        {
            CpfValidate(teacher.Cpf);

            BirthDateValidate(teacher.BirthDate);

            WageValidate(teacher.Wage);

            AddressValidate(teacher.Address);
        }

        private void IdsDisciplinesValidate(IEnumerable<int> idDisciplines)
        {
            if(idDisciplines != null)
                foreach (int id in idDisciplines)
                    if(!_uow.DisciplineRepository.GetUntracked().Any(discipline => discipline.Id == id))
                        throw new DomainException($"there is no discipline with id {id}");
        }

        private void IdValidate(int id)
        {
            bool existId = _uow.TeacherRepository
                               .GetUntracked()
                               .Any(teacher => teacher.Id == id);

            if (!existId)
                throw new DomainException("invalid id");
        }

        #region Teacher Props
        private void CpfValidate(string cpf)
        {
            if (!CpfHelper.Validate(cpf))
                throw new DomainException("invalid CPF");

            if(_uow.TeacherRepository.GetUntracked().Any(teacher => teacher.Cpf == cpf))
                throw new DomainException("CPF aready exists");
        }
        private void BirthDateValidate(DateTime birthDate)
        {
            if (new DateTime((DateTime.Now - birthDate).Ticks).Year < 18)
                throw new DomainException("prohibited registration of minors");
        }

        private void WageValidate(decimal wage)
        {
            if (wage < 0)
                throw new DomainException("prohibited negative salary");
        }

        private void AddressValidate(Address address)
        {
            if(address != null)
                StateValidate(address.State);
        }
        #endregion

        #region Address Props
        private void StateValidate(string state)
        {
            if (state.Length > 2)
                throw new DomainException("Enter the acronym of the state");
        }
        #endregion

        #endregion
    }
}
