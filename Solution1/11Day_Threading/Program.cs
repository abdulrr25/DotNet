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
            #region Custom Threads and ThreadStart Delegate 
            //Thread t1 = new Thread(method1) { Name = "th 01" };
            //Thread t2 = new Thread(method2) { Name = "th 02" };
            //Thread t3 = new Thread(method3) { Name = "th 03" };

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //ThreadStart ts = new ThreadStart(() =>
            //{
            //    Console.WriteLine("Method Call...");
            //});
            //Thread t4 = new Thread(ts);
            //t4.Start();
            #endregion

            #region isAlive and Join Method
            Console.WriteLine("Main method execution started");

            Thread t5 = new Thread(Program.F1);
            t5.Start();
            Thread t6 = new Thread(Program.F2);
            t6.Start();

            if (t5.Join(2000))
            {
                Console.WriteLine("F1 execution complete");
            }

            t6.Join();
            Console.WriteLine("F2 execution complete");

            if (t5.IsAlive)
            {
                Console.WriteLine("F1 execution is still going on");
            }
            else
            {
                Console.WriteLine("F1 execution is complete");
            }

            Console.WriteLine("Main method execution complete");
            #endregion


        }

        static void F1()
        {
            Console.WriteLine("F1 method execution started");
            Thread.Sleep(5000);
            Console.WriteLine("method F1 is awake");
            Console.WriteLine("F1 execution complete");
        }
        static void F2()
        {
            Console.WriteLine("F2 method execution started");
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
