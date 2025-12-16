using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02day_inheritence2
{
    public class BaseClass
    {
    int baseNum = 0;
        public BaseClass() { }

        public BaseClass(int baseNum)
        {
            this.baseNum = baseNum;
            Console.WriteLine("Value is {0}",baseNum);
        }
        public void method1()
        {
            Console.WriteLine("Method From Base class");
        }

    }
    public class DerivedClass : BaseClass
    {
        public DerivedClass(int no):base(no){
            
        }
        public void method2()
        {
            Console.WriteLine("From Method 2");
        }
    }
}
