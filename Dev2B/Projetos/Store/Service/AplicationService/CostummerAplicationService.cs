using AutoMapper;
using Commom.Dto.Costummer;
using Commom.Exceptions;
using Commom.Helpers;
using Domain;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class CostummerAplicationService : ICostummerAplicationService
    {
        private static readonly MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Costummer, CostummerGetDto>().ReverseMap();
            cfg.CreateMap<CostummerGetDto, Costummer>().ReverseMap();
            cfg.CreateMap<Costummer, CostummerPostDto>().ReverseMap();
            cfg.CreateMap<CostummerPostDto, Costummer>().ReverseMap();
        });
        private readonly IMapper _mapper = new Mapper(_config);
        private readonly ICostummerUnitOfWork _uow;

        public CostummerAplicationService(ICostummerUnitOfWork uow)
        {
            _uow = uow;
        }

        #region Get
        public List<CostummerGetDto> Get()
        {
            IEnumerable<Costummer> costummers = _uow.CostummerRepository.Get();

            if (costummers == null || !costummers.Any())
                throw new DomainException("There are no registered costummer");

            List<CostummerGetDto> dtos = new List<CostummerGetDto>();

            foreach (Costummer costummer in costummers)
            {
                dtos.Add(_mapper.Map<CostummerGetDto>(costummer));
            }

            return dtos;
        }

        public CostummerGetDto Get(int id)
        {
            Costummer costummer = IdValidate(id);

            CostummerGetDto dto = _mapper.Map<CostummerGetDto>(costummer);

            return dto;
        }
        #endregion

        #region Post
        public int Post(CostummerPostDto dto)
        {
            DtoValidate(dto);

            if (dto.Cpf.Length > 11)
            {
                string oldCpf = dto.Cpf;

                dto.Cpf = CpfHelper.cpfNoPoint(oldCpf);
            }

            Costummer costummer = _mapper.Map<Costummer>(dto);

            _uow.CostummerRepository.Post(costummer);

            _uow.Commit();

            return costummer.Id;
        }
        #endregion

        #region Put
        public void Put(int id, CostummerPostDto dto)
        {
            _ = IdValidate(id);

            DtoValidate(dto);

            Costummer costummer = _mapper.Map<Costummer>(dto);

            costummer.Id = id;

            _uow.CostummerRepository.Put(costummer);

            _uow.Commit();
        }
        #endregion

        #region Delete
        public void Delete(int id)
        {
            Costummer costummer = _uow.CostummerRepository.Get(id);

            _uow.CostummerRepository.Delete(costummer);

            _uow.Commit();
        }
        #endregion

        #region Validate
        private Costummer IdValidate(int id)
        {
            Costummer costummer = _uow.CostummerRepository.Get(id);

            return costummer ?? throw new DomainException($"There is no costummer with id {id}");
        }

        private void DtoValidate(CostummerPostDto dto)
        {
            if (dto.Name == null)
                throw new DomainException("Name is mandatory");

            if (dto.Name.Length < 5)
                throw new DomainException("Name must be longer than 5 characters");

            if (!CpfHelper.Validate(dto.Cpf))
                throw new DomainException("Invalid CPF");
        }
        #endregion
    }
}
