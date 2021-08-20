using System;
using System.Collections.Generic;

namespace Domain
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool FluentEnglish { get; set; }
        public string Formation { get; set; }
        public DateTime AdmissionDate { get; set; }
        public decimal Wage { get; set; }
        public int IdAddress { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }
        public string ProfessionalExperience { get; set; }
    }
}
