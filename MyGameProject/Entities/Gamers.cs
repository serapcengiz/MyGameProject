using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Entities
{
   public class Gamers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int DateOfBirth { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; internal set; }
        public double Price { get; internal set; }
    }
}
