using Commom.Dto;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface IPersonAplicationService
    {
        List<PersonGetDto> Get();
        PersonGetDto Get(int id);
        int Post(int id, PersonPostDto personDto);
        int Post(PersonPostDto personDto);
        List<int> Post(int id, List<PersonPostDto> peopleDto);
        int Put(int id, PersonPostDto personDto);
        int PatchEssential(int id, PersonPatchDtoEssential personDto);
        int PatchStatus(int id, bool status);
        int Delete(int id);
    }
}
