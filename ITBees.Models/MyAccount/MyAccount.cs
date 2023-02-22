using System;
using System.Collections.Generic;
using ITBees.Models.Companies;

namespace ITBees.Models.MyAccount
{
    public class MyAccount
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Guid { get; set; }
        public List<Company> Companies { get; set; }
    }
}