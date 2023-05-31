using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using proiectPAW.Entities;

namespace proiectPAW
{
    public static class Deserializare
    {
        public static List<Calator> DeserializareCalatori()
        {
            List<Calator> calatori = new List<Calator>();
            if (File.Exists("FakeDatabase\\Calatori.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("FakeDatabase\\Calatori.dat", FileMode.Open, FileAccess.Read);
                calatori = binaryFormatter.Deserialize(fs) as List<Calator>;
                fs.Close();
            }
            return calatori;
        }

        public static List<Obiectiv> DeserializareObiective()
        {
            List<Obiectiv> obiective = new List<Obiectiv>();
            if (File.Exists("FakeDatabase\\Obiective.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("FakeDatabase\\Obiective.dat", FileMode.Open, FileAccess.Read);
                obiective = binaryFormatter.Deserialize(fs) as List<Obiectiv>;
                fs.Close();
            }
            return obiective;
        }

        public static List<Rating> DeserializareRatings()
        {
            List<Rating> ratings = new List<Rating>();
            if (File.Exists("FakeDatabase\\Ratings.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("FakeDatabase\\Ratings.dat", FileMode.Open, FileAccess.Read);
                ratings = binaryFormatter.Deserialize(fs) as List<Rating>;
                fs.Close();
            }
            return ratings;
        }
    }
}
