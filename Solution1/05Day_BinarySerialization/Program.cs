using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace _05Day_BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String FilePath = "C:\\Users\\IET\\Desktop\\.Net\\Solution1\\05Day_BinarySerialization\\Data\\Text.txt";
            Emp emp = new Emp();
            emp.Id = 1;
            emp.Name = "Aakanksha";
            emp.Address = "Karad";



            #region se
            FileStream fs = null;
            if (File.Exists(FilePath))
            {
                fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Done"); 
            #endregion



        }


    }
    public class Emp
    {

        private int _id;
        private string _name;

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }

}
