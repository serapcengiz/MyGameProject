using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamers gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Customer has added!");
            }
            else
            {
                Console.WriteLine("Gamer is not valid.");
            }
        }

        public void Delete(Gamers gamer)
        {
            Console.WriteLine("Customer has deleted!");
        }

        public void UpDate(Gamers gamer)
        {
            Console.WriteLine("Customer has updated!");
        }

       
    }
}
