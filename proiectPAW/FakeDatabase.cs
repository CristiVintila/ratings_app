using proiectPAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW
{
    [Serializable]
    public static class FakeDatabase
    {
        public static List<Calator> calatori = new List<Calator>()
        {
            //new Calator()
            //{
            //    Id = Guid.NewGuid(),
            //    Nume = "admin",
            //    Parola = "admin"
            //},
            //new Calator()
            //{
            //    Id = Guid.NewGuid(),
            //    Nume = "Cristi",
            //    Parola = "1234"
            //},
            //new Calator()
            //{
            //    Id = Guid.NewGuid(),
            //    Nume = "Ioana",
            //    Parola = "1234"
            //},
            //new Calator()
            //{
            //    Id = Guid.NewGuid(),
            //    Nume = "Dani",
            //    Parola = "1234"
            //}
            
        };
        public static List<Obiectiv> obiective = new List<Obiectiv>()
        {
            //new Obiectiv()
            //{
            //    Id = Guid.NewGuid(),
            //    Locatie = "Castelul Bran",
            //    Pret = 250,
            //    Review = 1
            //},
            //new Obiectiv()
            //{
            //    Id = Guid.NewGuid(),
            //    Locatie = "Castelul Peles",
            //    Pret = 350,
            //    Review = 1
            //},
            //new Obiectiv()
            //{
            //    Id = Guid.NewGuid(),
            //    Locatie = "Salina Turda",
            //    Pret = 100,
            //    Review = 1
            //}
        };
        public static List<Rating> ratings = new List<Rating>();
    }
}
