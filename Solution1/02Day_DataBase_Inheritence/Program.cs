using static _02Day_DataBase_Inheritence.DataFactory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02Day_DataBase_Inheritence
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Choice 1->MySqlServer 2->SqlServer");


            int ch =Convert.ToInt32(Console.ReadLine());
                

            DataFactory df = new DataFactory();


            IDatabase dbs= df.GetDatabase(ch);

            Console.WriteLine("Enter the Option You want to do : 1-> Insert 2->Delete 3-> Update");

            int choice =Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    dbs.Insert();
                    break;
                case 2:
                       dbs.Delete();
                    break;
                case 3:
                    dbs.Insert();
                    break;


                default:
                    Console.WriteLine("Enter Valid choice");
                    break;
            }

        }

        
    }

    public class DataFactory
    {
        public IDatabase GetDatabase(int db)
        {
            IDatabase dbase = null;

            switch (db)
            {
                case 1:
                    dbase = new MySqlServer();
                    break;
                case 2:
                    dbase = new SqlServer();
                    break;

                default:
                    Console.WriteLine("Enter Valid choice");
                    break;
            }
            return dbase;
        }

        public interface IDatabase
        {
            void Insert();
            void Update();
            void Delete();

        }
        public class SqlServer : IDatabase
        {
            public void Delete()
            {
                Console.WriteLine("Inside Delete Of SqlServer");
            }

            public void Insert()
            {
                Console.WriteLine("Inside Insert Of SqlServer");
            }

            public void Update()
            {
                Console.WriteLine("Inside Update Of SqlServer");
            }
        }

        public class MySqlServer : IDatabase
        {
            public void Delete()
            {
                Console.WriteLine("Inside Delete Of MySqlServer");
            }

            public void Insert()
            {
                Console.WriteLine("Inside Insert Of MySqlServer");
            }

            public void Update()
            {
                Console.WriteLine("Inside Update Of MySqlServer");
            }
        }
    }
}
