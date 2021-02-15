using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class GamesManager
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.Name+"has added your basket");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.Name+"has deleted your basket");
        }
    }
}
