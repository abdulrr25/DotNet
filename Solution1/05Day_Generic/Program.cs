namespace _05Day_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Swap Method
            //int a = 12;
            //int b = 13;
            //CMath cmath = new CMath();
            //Console.WriteLine($"Before Swaping A={a}, B={b}");
            //cmath.Swap<int>(ref a, ref b);
            //Console.WriteLine($"After Swaping A={a}, B={b}");

            //string s1 = "Abdul";
            //string s2 = "Rahman";
            //Console.WriteLine($"Before Swapping S1={s1}, S2={s2}");
            //cmath.Swap<string>(ref s1, ref s2);
            //Console.WriteLine($"After Swapping S1={s1}, S2={s2}");

            #endregion


            #region Add Template
            //CMath cmath = new CMath();
            //Console.WriteLine(cmath.Add<int>(2, 4));
            //Console.WriteLine(cmath.Add<string>("2", "4"));
            //Console.WriteLine(cmath.Add<double>(22.22, 22.22)); 
            #endregion

            #region out Parameter
            double area, circumference = 0;
            double radius = 5;
            CMath cmath = new CMath();
            cmath.CalculateCircleArea(radius, out area, out circumference);
            Console.WriteLine($"Circle : Area = {area}, Circumference = {circumference}");
            #endregion


        }


    }
    public class CMath
    {
        #region SwpGeneric
        //public void Swap<T>(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;

        //} 
        #endregion

        #region Addtemp
        //public T Add<T>(T x, T y)
        //{
        //    dynamic para1 = x;
        //    dynamic para2 = y;
        //    dynamic sum = para1 + para2; // This line may cause a runtime exception handled by CLR
        //    return sum;
        //} 
        #endregion

        public void CalculateCircleArea(double radius, out double area, out double circumference)
        {
            area = 3.14 * radius * radius;
            circumference = 2 * 3.14 * radius;
        }

    }
}
