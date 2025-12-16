namespace _02_DayOOP_inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Drink
            //Console.WriteLine("Enter your Choice Of Drink  : 1-> Cold Drink 2-> Hot Drink");
            //int ch = Convert.ToInt32(Console.ReadLine());

            //switch (ch)
            //{
            //    case 1:
            //        IDrink drink = new ColdDrink();
            //        drink.getDrink();
            //        break;

            //    case 2:
            //        HotDrink hotDrink = new HotDrink();
            //        hotDrink.getDrink();
            //        break;

            //    default:
            //        Console.WriteLine("Enter Valid INput");
            //        break;


            //} 
            #endregion
            
            
            MyMath myMath = new MyMath();
            myMath.Add(6, 3);
            myMath.Mult(6, 3);
            myMath.log("Hello");

            myMath.Div(6, 3);
        }
        #region Drink
        //public interface IDrink
        //{
        //    void getDrink();
        //}

        //public class ColdDrink : IDrink
        //{
        //    public void getDrink()
        //    {
        //        Console.WriteLine("Enjoy Your Cold Drink");
        //    }
        //}

        //public class HotDrink : IDrink
        //{
        //    public void getDrink()
        //    {
        //        Console.WriteLine("Enjoy Your Hot Drink");
        //    }
        //} 
        #endregion
        public interface IX
        {
            public void Add(int a, int b)
            {
                Console.WriteLine(a + ", " + b);
            }
            public void Sub(int a, int b)
            {
                Console.WriteLine(a - b);
            }
        }
        public interface IY
        {
            public void Add(int a, int b);
            public void Mult(int a, int b);
           
        }
        public interface IDemo {
            public void Div(int a, int b);
            
            public void log(String msg);
            
        }
        public class MyMath : IY,IDemo

        {
            public void Div(int a, int b)
            {
                Console.WriteLine(a / b);
            }
            public void log(String msg)
            {
                Console.WriteLine(msg);

            }

            public void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void Mult(int a, int b)
            {
                Console.WriteLine(a * b);
            }


        }

    }
}
