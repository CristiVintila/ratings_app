using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW.Entities
{
    [Serializable]
    public class Obiectiv
    {
        public Guid Id { get; set; }  
        public string Locatie { get; set; }
        public double Pret { get; set; }
        public double Review { get; set; }

        public void calcReview()
        {
            double rating = 0;
            double nr = 0;
            if (FakeDatabase.ratings.Where(x => x.NumeLocatie == this.Locatie).Count() != 0)
            {
                nr = FakeDatabase.ratings.Where(x => x.NumeLocatie == this.Locatie).Count();
                foreach (var rev in FakeDatabase.ratings.Where(x => x.NumeLocatie == this.Locatie))
                {
                    rating += rev.Nota;
                }
                rating = rating / nr;
                this.Review = rating;
            }
            else
            {
                this.Review = 1;
            }
        }
    }
}
