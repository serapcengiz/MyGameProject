using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Abstract
{
    public interface IGamerService
    {
        public void Add(Gamers gamer);
        public void Delete(Gamers gamer);
        public void UpDate(Gamers gamer);

    }
}
