namespace _11Day_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ByDefault threads are nameless
             Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            //Console.WriteLine(t.ManagedThreadId);
            //Console.WriteLine(t.Name);
            #endregion

            //method1();
            //method2();
            //method3();

            Thread t1 = new Thread(method1) { Name = "th 01" };
            Thread t2 = new Thread(method2) { Name = "th 02" };
            Thread t3 = new Thread(method3) { Name = "th 03" };

            t1.Start();
            t2.Start();
            t3.Start();

            ThreadStart ts = new ThreadStart(() =>
            {
                Console.WriteLine("Method Call...");
            });
            Thread t4 = new Thread(ts);
            t4.Start();


        }

        static void method1()
        {
            Console.WriteLine("Method1 Started using {0}", Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Method1 - Count: {0}", i);
                //Thread.Sleep(5000);
            
            }
            Console.WriteLine("Method1 Ended using {0}",Thread.CurrentThread.Name);


        }

        static void method2()
        {

            Console.WriteLine("Method2 Started using {0}", Thread.CurrentThread.Name);
            //Console.WriteLine("Method2 - Count: {0}", Thread.CurrentThread.Name);
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine("Method2 - Count: {0}", i);
                if (i == 2)
                {
                    Console.WriteLine("Execution code started");
                    Thread.Sleep(5000);
                    Console.WriteLine("Execution code Completed");

                }
            }
            //Console.WriteLine("Method2 - Count: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Method1 Ended using {0}", Thread.CurrentThread.Name);



        }

        static void method3()
        {
            Console.WriteLine("Method3 - Count: {0}", Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method3 - Count: {0}", i);
            }
            Console.WriteLine("Method3 - Count: {0}", Thread.CurrentThread.Name);


        }
    }
}
