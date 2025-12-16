using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02day_inheritence2
{
    public class CMath
    {

        public void add(int a, int b)
        {
            Console.WriteLine( a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(b - a);
        }
        public virtual void Mul(int a, int c)
        {
            Console.WriteLine("Multiplication is: {0}", c * a);
        }
    }

    public class AdvanceMath : CMath
    {
        public override void Mul(int a, int b)
        {
            Console.WriteLine(a * b * 10);
            
        }
        public new  void Add(int a, int b)
        {
            Console.WriteLine(a + b+100);

        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(b - a);
        }

    }
}
