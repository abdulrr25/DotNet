using System.Collections;
using System.Xml.Linq;

namespace _05Day_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region bookData
            //Book book = new Book();
            //book.Publisher = "The Hobbit";
            //book.Author = "J.R.R. Tolkien";

            #endregion

            #region EMPLOYEE DATA
            Emp emp1 = new Emp();
            emp1.EId = 1;
            emp1.EName = "Abdul Rahman";
            emp1.EAddress = "Prayagraj";

            Emp emp2 = new Emp();
            emp2.EId = 102;
            emp2.EName = "Tony Stark";
            emp2.EAddress = "Shivaji Nagar";

            Emp emp3 = new Emp();
            emp3.EId = 103;
            emp3.EName = "Tom Ellis";
            emp3.EAddress = "L.A";


            Emp[] emp = new Emp[3];
            emp[0] = emp1;
            emp[1] = emp2;
            emp[2] = emp3;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Id: {emp[i].EId}, Name: {emp[i].EName}, Address: {emp[i].EAddress}");

            //}
            #endregion

            #region ARRAY
            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            #region ArrayList

            //ArrayList arr = new ArrayList();
            //arr.Add(1);
            //arr.Add("Hello");
            //arr.Add('e');
            //arr.Add(23.5);
            //arr.Add(emp1);
            //arr.Add(emp2);

            //for (int i = 0; i < arr.Count; i++)
            //{
            //    object element = arr[i];

            //    //value in object form
            //    if (element is int)
            //    {
            //        int j = Convert.ToInt32(element); // Unboxing
            //        Console.WriteLine($"Value = {j}, Type ={element.GetType().ToString()}");
            //    }
            //    if (element is string)
            //    {
            //        string str = element.ToString(); // Unboxing
            //        Console.WriteLine($"Value = {str}, Type ={element.GetType().ToString()}");
            //    }
            //    if (element is double)
            //    {
            //        double d = Convert.ToDouble(element); // Unboxing
            //        Console.WriteLine($"Value = {d}, Type ={element.GetType().ToString()}");
            //    }
            //    if (element is Emp)
            //    {
            //        Emp e = element as Emp;
            //        Console.WriteLine($"Value = {e.EId} {e.EName} {e.EAddress}, Type ={element.GetType().ToString()}");
            //    }
            //}



            #endregion

            #region HashTable
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 100);
            //ht.Add("A", "Apple");
            //ht.Add(2, 23.33);
            //ht.Add(3, emp1);

            ////for (int i = 0; i < ht.Count; i++)
            ////foreach (object key in ht.Keys)
            ////{
            ////    Console.WriteLine(key);
            ////}
            //foreach (object value in ht.Values)
            //{
            //    Console.WriteLine(value);
            //}
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine($"Key = {key}, Value = {ht[key]}");
            //} 
            #endregion

            #region List
            //List<int> lst = new List<int>();
            //lst.Add(220);
            //lst.Add(10);
            //lst.Add(135);
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tuples
            //var empDetails = Display(100, "Hugh Jackman", "NewYork");
            //Console.WriteLine($"Id={empDetails.Id}, Name={empDetails.Name}, Address={empDetails.Address}");
            #endregion
            

        }

        #region Tuples
        //static (int Id, string Name, string Address) Display(int id, string name, string address)
        //{

        //    int Id = id;
        //    string Name = name;
        //    string Address = address;
        //    return (Id, Name, Address);
        //} 
        #endregion

        #region Objects 
        //    Object[] objs = new Object[5];
        //    objs[0] = 100; // Boxing
        //    objs[1] = "Something";
        //    objs[2] = emp1;
        //    objs[3] = book;
        //    objs[4] = 12.34; // Boxing

        //    for(int i = 0; i < objs.Length; i++)
        //    {
        //        Object element = objs[i];

        //        if(element is int)
        //        {
        //            int j= Convert.ToInt32(element);
        //            Console.WriteLine($"Value is {j} and Type Is {element}");
        //        }
        //        if (element is string)
        //        {
        //            string str = element.ToString(); // Unboxing
        //            Console.WriteLine($"Value = {str}, Type ={element.GetType().ToString()}");
        //        }
        //        if (element is double)
        //        {
        //            double d = Convert.ToDouble(element); // Unboxing
        //            Console.WriteLine($"Value = {d}, Type ={element.GetType().ToString()}");
        //        }
        //        if (element is Emp)
        //        {
        //            Emp e = element as Emp;
        //            Console.WriteLine($"Value = {e.EId} {e.EName} {e.EAddress}, Type ={element.GetType().ToString()}");
        //        }
        //        if (element is Book)
        //        {
        //            Book book2 = element as Book;
        //            Console.WriteLine($"Value = {book2.Publisher} {book2.Author}, Type ={element.GetType().ToString()}");
        //        }
        //    }

        #endregion

        #region empClass

        public class Emp
        {
            private int _EId;
            private string _EName;
            private string _EAddress;

            public string EAddress
            {
                get { return _EAddress; }
                set { _EAddress = value; }
            }

            public string EName
            {
                get { return _EName; }
                set { _EName = value; }
            }
            public int EId
            {
                get { return _EId; }
                set { _EId = value; }
            }
        }
        #endregion

            #region BookClass
        //public class Book
        //{

        //    private String _Author;
        //    private String _Publisher;

        //    public String Publisher
        //    {
        //        get { return _Publisher; }
        //        set { _Publisher = value; }
        //    }

        //    public String Author
        //    {
        //        get { return _Author; }
        //        set { _Author = value; }
        //    }


        //}
        #endregion


    } 

        }


