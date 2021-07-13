﻿using System;
using System.Collections.Generic;

namespace Commom.Dto
{
    public class PersonGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Race { get; set; }
        public bool Status { get; set; }
        public string Cpf { get; set; }
        public List<PersonGetDto> Sons { get; set; }
    }
}
