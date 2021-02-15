using MyGameProject.Concrete;
using MyGameProject.Entities;
using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Entities.Gamers
            {
                FirstName = "Serap",
                LastName = "Cengiz",
                DateOfBirth = 2001,
                Id = 1,
                IdentityNumber = "12345678"

            });
            Gamers gamer = new Gamers();
            gamer.FirstName = "Serap";
            gamer.LastName = "Cengiz";
            gamer.Id =1;
            gamer.IdentityNumber = "12345678";
            gamer.DateOfBirth = 2001;


            Games game = new Games();
            game.Name = "Okey";
            game.Id = 1;
            game.Price=14.99;

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Kişiye Özel";
            campaign.CampaignId = 1;
            campaign.CampaignPrice = 9.99;

            Console.WriteLine("Dear "+gamer.FirstName+" you got "+campaign.CampaignName+" , you have% "+campaign.CampaignPrice+"discount at this game "+game.Name);
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(game);
        }
    }
}
