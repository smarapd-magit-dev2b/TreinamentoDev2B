using Commom.Dto.Address;
using System;
using System.Collections.Generic;

namespace Commom.Dto.Teacher
{
    public class TeacherPutDto
    {
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? FluentEnglish { get; set; }
        public string Formation { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public decimal? Wage { get; set; }
        public int? IdAddress { get; set; }
        public AddressPostDto Address { get; set; }
        public IEnumerable<int> IdsDiscipline { get; set; }
        public string ProfessionalExperience { get; set; }
    }
}
