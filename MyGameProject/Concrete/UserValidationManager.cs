using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamers gamer)
        {
            if (gamer.FirstName=="Serap" && gamer.LastName=="Cengiz" &&  gamer.IdentityNumber=="12345678" &&gamer.Id==1&& gamer.DateOfBirth==2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
