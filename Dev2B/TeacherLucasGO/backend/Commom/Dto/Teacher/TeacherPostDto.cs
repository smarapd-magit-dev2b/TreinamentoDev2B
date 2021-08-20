using Commom.Dto.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Commom.Dto.Teacher
{
    public class TeacherPostDto
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool FluentEnglish { get; set; }
        public string Formation { get; set; }
        [Required]
        public DateTime AdmissionDate { get; set; }
        [Required]
        public decimal Wage { get; set; }
        public int? IdAddress { get; set; }
        public AddressPostDto Address { get; set; }
        public IEnumerable<int> IdDisciplines { get; set; }
        public string ProfessionalExperience { get; set; }
    }
}
