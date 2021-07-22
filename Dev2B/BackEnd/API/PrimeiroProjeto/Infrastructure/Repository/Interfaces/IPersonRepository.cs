using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> Get();
        Person Get(int id);
        int GetNextId();
        void Post(Person person);
        void Post(List<Person> people);
        //void Patch(int idDad, int idSon);
        //void Patch(int idDad, List<int> idSons);
        void Put(Person person);
        void PatchEssential(Person person);
        void PatchStatus(int id);
        void Delete(int id);
    }
}
