using Commom.Dto.Costummer;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface ICostummerAplicationService
    {
        List<CostummerGetDto> Get();
        CostummerGetDto Get(int id);
        int Post(CostummerPostDto dto);
        void Delete(int id);
        void Put(int id, CostummerPostDto dto);
    }
}
