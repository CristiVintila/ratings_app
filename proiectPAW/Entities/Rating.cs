using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW.Entities
{
    [Serializable]
    public class Rating
    {
        public Guid IdUtilizator { get; set; }
        public string NumeLocatie { get; set; }
        public string Descriere { get; set; }
        public double Nota { get; set; }
        public string Calator { get; set; }
    }
}
