using System.Security.Cryptography;
using System.Xml.Linq;

namespace _06Day_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String FilePath = "C:\\Users\\IET\\Desktop\\.Net\\Solution1\\06Day_FileIO\\Data\\demo1.txt";




            #region FileWriter
            //Emp emp = new Emp();
            //emp.Id = 1;
            //emp.Name = "ABC";
            //emp.Address = "Karad";



            //FileStream fs = null;
            //if (File.Exists(FilePath))
            //{
            //    fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
            //}
            //StreamWriter writer = new StreamWriter(fs);
            //writer.WriteLine("Hello from File Input Output Operation");
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion

            #region WriteReader

            FileStream fs = null;
            if (File.Exists(FilePath))
            {
                fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Aakanksha Karale");
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("Done"); 
            #endregion


            #region FileReader
            //FileStream fs = null;
            //if (File.Exists(FilePath))
            //{
            //    fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            //StreamReader reader = new StreamReader(fs);
            //String Content = reader.ReadToEnd();
            //reader.Close();
            //fs.Close();
            //Console.WriteLine(Content); 
            #endregion

        }
    }
    

}
