﻿namespace Commom.Dto.Address
{
    public class AddressGetDto
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Number { get; set; }
    }
}
