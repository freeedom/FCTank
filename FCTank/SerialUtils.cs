using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using FCTank.Objects;

namespace FCTank
{
    public class SerialUtils
    {
        public static void serial(Maps maps)
        {
            FileStream fs = new FileStream("maps.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, maps);
            fs.Dispose();
        }
        public static Maps reSerial()
        {
            if (!File.Exists("maps.bin")) return null;
            FileStream fs = new FileStream("maps.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Maps walls = bf.Deserialize(fs) as Maps;
            fs.Dispose();
            return walls;
        }
    }
}
