using System;
using System.Collections.Generic;
using System.Text;

namespace appservicedemo.Data.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Email { get; set; }
    }
}
