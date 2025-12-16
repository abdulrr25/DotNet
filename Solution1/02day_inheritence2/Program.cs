namespace _02day_inheritence2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region BaseClas
            //DerivedClass obj = new DerivedClass(10);
            //obj.method1();
            //obj.method2();
        #endregion


        CMath cal = new AdvanceMath();
        cal.add(5,4);
            cal.Mul(5,4);
            cal.Sub(15,40);
        }


    }
}
