using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW.Entities
{
    [Serializable]
    public class Calator
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Parola { get; set; }

    }
}
