using Domain.Entities;
using Infrastructure.Repository.Context;
using Infrastructure.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PP_DbContext _dbContext;

        public PersonRepository(PP_DbContext dbContext) => _dbContext = dbContext;

        #region Get
        public List<Person> Get() => _dbContext.People.ToList();

        public Person Get(int id) => _dbContext.People.FirstOrDefault(p => p.Id == id);

        public int GetNextId() => _dbContext.People.Max(p => p.Id) + 1;
        #endregion

        #region Post
        public void Post(Person person) => _dbContext.People.Add(person);

        public void Post(List<Person> people)
        {
            _dbContext.People.AddRange(people);
        }
        #endregion

        #region Put
        public void Put(Person person)
        {
            Person oldPerson = _dbContext.People.First(p => p.Id == person.Id);

            int index = _dbContext.People.ToList().IndexOf(oldPerson);

            _dbContext.People.ToList()[index] = person;
        }
        #endregion

        #region Patch
        public void PatchEssential(Person person)
        {
            Person oldPerson = _dbContext.People.First(p => p.Id == person.Id);

            oldPerson.Name = person.Name;
            oldPerson.LastName = person.LastName;
            oldPerson.Cpf = person.Cpf;
        }

        public void PatchStatus(int id)
        {
            Person person = _dbContext.People.First(p => p.Id == id);

            bool oldStatus = person.Status;

            person.Status = !oldStatus;
        }

        //public void Patch(int idDad, int idSan)
        //{
        //    Person dad = _dbContext.People.First(p => p.Id == idDad);

        //    if (dad.Sons == null)
        //        dad.Sons = new List<Person>();

        //    dad.Sons.Add(_people.First(p => p.Id == idSan));
        //}

        //public void Patch(int idDad, List<int> idSons)
        //{
        //    Person dad = _dbContext.People.First(p => p.Id == idDad);

        //    if (dad.Sons == null)
        //        dad.Sons = new List<Person>();

        //    List<Person> sons = (from int id in idSons
        //                         select _people.First(p => p.Id == id)).ToList();

        //    dad.Sons.AddRange(sons);
        //}
        #endregion

        #region Delete
        public void Delete(int id) => _dbContext.People.ToList().RemoveAll(p => p.Id == id);
        #endregion
    }
}
