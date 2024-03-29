﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceBackend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int IdIdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public int IdCustomerType { get; set; }
        public int IdExpeditionCountry { get; set; }
        public int IdExpeditionState { get; set; }
        public int IdExpeditionCity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MiddleLastName { get; set; }
        public int IdPrefix { get; set; }
        public int IdBirthCountry { get; set; }
        public int IdBirthState { get; set; }
        public int IdBirthCity { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdGender { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int IdEPS { get; set; }
        public int SocialClass { get; set; }
        public int IdMaritalStatus { get; set; }
        public string Phone { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public int IdOccupation { get; set; }
        public string Hobbie { get; set; }
        public string ResidenceAddress { get; set; }
        public int ResidenceCountry { get; set; }
        public int ResidenceState { get; set; }
        public int ResidenceCity { get; set; }
    }
}
