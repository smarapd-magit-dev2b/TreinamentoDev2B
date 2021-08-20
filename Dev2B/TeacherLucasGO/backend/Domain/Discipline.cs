using System;

namespace Domain
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Cid { get; set; }
        public DateTime InclusionDate { get; set; }
        public int? IdTeacher { get; set; }
        public Teacher Teacher { get; set; }
    }
}
