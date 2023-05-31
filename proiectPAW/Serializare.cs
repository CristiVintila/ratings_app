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
    public static class Serializare
    {
        public static void SerializareCalatori(List<Calator> calatori)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = new FileStream("FakeDatabase\\Calatori.dat", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs, calatori);
            fs.Close();
        }

        public static void SerializareObiective(List<Obiectiv> obiective)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = new FileStream("FakeDatabase\\Obiective.dat", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs, obiective);
            fs.Close();
        }

        public static void SerializareRatings(List<Rating> ratings)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fs = new FileStream("FakeDatabase\\Ratings.dat", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs, ratings);
            fs.Close();
        }

    }
}
