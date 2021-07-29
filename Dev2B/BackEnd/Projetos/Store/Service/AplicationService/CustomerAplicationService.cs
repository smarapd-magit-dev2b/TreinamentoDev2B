using AutoMapper;
using Commom.Dto.Customer;
using Commom.Exceptions;
using Commom.Helpers;
using Domain;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class CustomerAplicationService : ICustomerAplicationService
    {
        private static readonly MapperConfiguration _config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Customer, CustomerGetDto>();
            cfg.CreateMap<CustomerGetDto, Customer>();
            cfg.CreateMap<Customer, CustomerPostDto>();
            cfg.CreateMap<CustomerPostDto, Customer>();
        });
        private static readonly IMapper _mapper = new Mapper(_config);
        private readonly ICustomerUnitOfWork _uow;

        public CustomerAplicationService(ICustomerUnitOfWork uow) => _uow = uow;

        #region Get
        public IEnumerable<CustomerGetDto> Get()
        {
            IQueryable<Customer> custumers = _uow.CustomerRepository.Get();

            CustomersValidate(custumers);

            return CustomersToCustomerGetDtos(custumers);
        }

        public CustomerGetDto Get(int id)
        {
            Customer customer = _uow.CustomerRepository.Get(id);

            IdValidate(id, customer);

            return _mapper.Map<CustomerGetDto>(customer);
        }
        #endregion

        #region Post
        public int Post(CustomerPostDto dto)
        {
            ICustomerRepository customerRepository = _uow.CustomerRepository;

            PostValidate(customerRepository.Get(), dto);

            dto.Cpf = CpfHelper.NoDot(dto.Cpf);

            Customer customer = _mapper.Map<Customer>(dto);

            customerRepository.Post(customer);

            _uow.Commit();

            return customer.Id;
        }
        #endregion

        #region Put
        public void Put(int id, CustomerPostDto dto)
        {
            Customer oldCustomer = _uow.CustomerRepository.Get(id);

            PutValidate(_uow.CustomerRepository.Get(), oldCustomer, dto, id);

            Customer customer = _mapper.Map<Customer>(dto);

            customer.Id = id;

            _uow.CustomerRepository.Put(customer);

            _uow.Commit();
        }
        #endregion

        #region Delete
        public void Delete(int id)
        {
            Customer customer = _uow.CustomerRepository.Get(id);

            IdValidate(id, customer);

            _uow.CustomerRepository.Delete(customer);

            _uow.Commit();
        }
        #endregion

        #region Parses
        private IEnumerable<CustomerGetDto> CustomersToCustomerGetDtos(IQueryable<Customer> customers) =>
            from Customer c in customers
            let dto = new CustomerGetDto
            {
                Id = c.Id,
                Name = c.Name,
                BirthDate = c.BirthDate,
                Cpf = c.Cpf,
                Rg = c.Rg,
                Phone = c.Phone,
                Gender = c.Gender
            }
            select dto;
        #endregion

        #region Validate

        private void CustomersValidate(IQueryable<Customer> customers)
        {
            if (!customers.Any())
                throw new DomainException("There are no registered customers");
        }

        private void IdValidate(int id, Customer customer)
        {
            if (customer == null)
                throw new DomainException($"There is no customer with id {id}");
        }

        private void PostValidate(IQueryable<Customer> customers, CustomerPostDto dto)
        {
            Validate(dto);

            NameExists(customers, dto.Name);

            CpfExists(customers, dto.Cpf);
        }

        private void PutValidate(IQueryable<Customer> customers,
                                 Customer oldCustomer,
                                 CustomerPostDto dto,
                                 int id)
        {
            IdValidate(id, oldCustomer);

            Validate(dto);

            dto.Cpf = CpfHelper.NoDot(dto.Cpf);

            if (dto.Name.ToLower() != oldCustomer.Name.ToLower())
                NameExists(customers, dto.Name);

            if (dto.Cpf != oldCustomer.Cpf)
                CpfExists(customers, dto.Cpf);
        }

        private void Validate(CustomerPostDto dto)
        {
            NameValidate(dto.Name);

            BirthDateValidate(dto.BirthDate);

            CpfValidate(dto.Cpf);

            RgValidate(dto.Rg);

            GenderValidate(dto.Gender);
        }
        #endregion

        #region Properties
        private void NameValidate(string name)
        {
            bool HasAtLeast5characters = name.Length >= 5;

            if (string.IsNullOrEmpty(name))
                throw new DomainException("Name is mandatory");

            if (!HasAtLeast5characters)
                throw new DomainException("Name must be longer than 5 characters");
        }

        private void NameExists(IQueryable<Customer> customers, string name)
        {
            bool exist = customers.Any(c => c.Name == name);

            if (exist)
                throw new DomainException("Name already registered");
        }

        private void BirthDateValidate(DateTime birthDate)
        {
            bool HasValue = birthDate != null;

            if (!HasValue)
                throw new DomainException("Birth date is mandatory");
        }

        private void CpfValidate(string docCpf)
        {
            if (string.IsNullOrEmpty(docCpf))
                throw new DomainException("CPF date is mandatory");

            List<int> cpf = CpfHelper.ToListInt(docCpf);

            if (!CpfHelper.IsValid(cpf))
                throw new DomainException("Invalid CPF");
        }

        private void CpfExists(IQueryable<Customer> customers, string cpf)
        {
            bool exist = customers.Any(c => c.Cpf == cpf);

            if (exist)
                throw new DomainException("CPF already registered");
        }

        private void RgValidate(string rg)
        {
            if (string.IsNullOrEmpty(rg))
                throw new DomainException("RG date is mandatory");
        }

        private void GenderValidate(char? gender)
        {
            bool isMale = gender == 'M';

            bool isFemale = gender == 'F';

            if (gender.HasValue && !isMale && !isFemale)
                throw new DomainException($"{gender} is not a valid genre");
        }
        #endregion
    }
}
