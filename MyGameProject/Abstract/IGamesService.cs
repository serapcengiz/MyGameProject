using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Abstract
{
    public interface IGamesService
    {
        public void Add(Games games);
        public void Delete(Games games);
    }
}
