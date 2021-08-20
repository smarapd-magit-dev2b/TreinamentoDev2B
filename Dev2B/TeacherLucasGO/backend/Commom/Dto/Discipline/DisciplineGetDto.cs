using System;

namespace Commom.Dto.Discipline
{
    public class DisciplineGetDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Cid { get; set; }
        public DateTime InclusionDate { get; set; }
    }
}
