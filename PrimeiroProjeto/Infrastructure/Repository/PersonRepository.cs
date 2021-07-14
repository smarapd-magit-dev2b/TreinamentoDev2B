using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _people = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "José",
                    LastName = "Silva",
                    Cpf = "497.500.270-19",
                    Height = 1.9m,
                    BirthDate = new DateTime(1993, 12, 9),
                    Weight = 80.0m,
                    Race = "Branca",
                    Status = true
                },
                new Person
                {
                    Id = 2,
                    Name = "Willian",
                    LastName = "Andrade",
                    Cpf = "009.630.700-53",
                    Height = 1.7m,
                    BirthDate = new DateTime(1950, 10, 4),
                    Weight = 100.0m,
                    Race = "Negro",
                    Status = true
                },
                new Person
                {
                    Id = 3,
                    Name = "Silas",
                    LastName = "Almeida",
                    Cpf = "164.656.030-20",
                    Height = 1.78m,
                    BirthDate = new DateTime(1968, 2, 2),
                    Weight = 92.0m,
                    Race = "Branca",
                    Status = true,
                },
                new Person
                {
                    Id = 4,
                    Name = "Glenison",
                    LastName = "Honório",
                    Cpf = "916.876.230-58",
                    Height = 1.89m,
                    BirthDate = new DateTime(1991, 6, 28),
                    Weight = 75,
                    Race = "Branca",
                    Status = false
                },
                new Person
                {
                    Id = 5,
                    Name = "Gabriel",
                    LastName = "Domingos",
                    Cpf = "421.694.740-99",
                    Height = 1.89m,
                    BirthDate = new DateTime(1991, 6, 28),
                    Weight = 75,
                    Race = "Branca",
                    Status = true
                }
            };

        #region Get
        public List<Person> Get() => _people;

        public Person Get(int id) => _people.FirstOrDefault(p => p.Id == id);

        public int GetNextId() => _people.Max(p => p.Id) + 1;
        #endregion

        #region Post
        public void Post(Person person) => _people.Add(person);

        public void Post(List<Person> people)
        {
            _people.AddRange(people);
        }
        #endregion

        #region Put
        public void Put(Person person)
        {
            Person oldPerson = _people.First(p => p.Id == person.Id);

            int index = _people.IndexOf(oldPerson);

            _people[index] = person;
        }
        #endregion

        #region Patch
        public void PatchEssential(Person person)
        {
            Person oldPerson = _people.First(p => p.Id == person.Id);

            oldPerson.Name = person.Name;
            oldPerson.LastName = person.LastName;
            oldPerson.Cpf = person.Cpf;
        }

        public void PatchStatus(int id)
        {
            Person person = _people.First(p => p.Id == id);

            bool oldStatus = person.Status;

            person.Status = !oldStatus;
        }

        public void Patch(int idDad, int idSan)
        {
            Person dad = _people.First(p => p.Id == idDad);

            if (dad.Sons == null)
                dad.Sons = new List<Person>();

            dad.Sons.Add(_people.First(p => p.Id == idSan));
        }

        public void Patch(int idDad, List<int> idSons)
        {
            Person dad = _people.First(p => p.Id == idDad);

            if (dad.Sons == null)
                dad.Sons = new List<Person>();

            List<Person> sons = (from int id in idSons
                                 select _people.First(p => p.Id == id)).ToList();

            dad.Sons.AddRange(sons);
        }
        #endregion

        #region Delete
        public void Delete(int id) => _people.RemoveAll(p => p.Id == id);
        #endregion
    }
}
