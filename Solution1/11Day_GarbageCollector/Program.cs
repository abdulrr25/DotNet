using System.Security.Cryptography.X509Certificates;

namespace _11Day_GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.sayhi();
            obj.Dispose();


            using (MyClass obj2 = new MyClass())
            {
                obj2.sayhi();
            }

            GC.Collect(2);
            Console.WriteLine(GC.MaxGeneration);

            MyClass obj3 = new MyClass();
            Console.WriteLine(GC.GetGeneration(obj3));

            GC.WaitForPendingFinalizers();



        }
    }

    public class MyClass : IDisposable
    {
        public void sayhi()
        {
            Console.WriteLine("Hello from Garbage Collector");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose method gets called...");
            GC.SuppressFinalize(this);
        }

        
        
        //~MyClass()
        //{
        //    Console.WriteLine("Destructor Called");
        //}
    
    }

}
