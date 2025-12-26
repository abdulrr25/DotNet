using System.Collections;

namespace _08Day_C_Demo
{    
    
    //public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int no = Convert.ToInt32(Console.ReadLine());

            #region Using normal calling
            //var res = Check(no);
            //if (res)
            //{
            //    Console.WriteLine($"{no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{no} is less than 10");
            //} 
            #endregion

            #region Using Delicates
            //MyDelegate del = new MyDelegate(Check);
            //var result = del(no);
            //if (result)
            //{
            //    Console.WriteLine($"No : {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"No : {no} is NOT greater than 10");
            //} 
            #endregion

            #region Annonymous Function
            //MyDelegate del = new MyDelegate(delegate (int num) {
            //    return num > 10;
            //});
            //if (del(no))
            //{
            //    Console.WriteLine($"{no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{no} is NOT greater than 10");
            //} 
            #endregion

            #region Lambda Function (=>)
            //MyDelegate del = (int num) =>
            //{
            //    return num > 10;
            //};
            //if (del(no))
            //{
            //    Console.WriteLine($"{no} is greater than 10");

            //}
            //else
            //{
            //    Console.WriteLine($"{no} is NOT greater than 10");
            //} 
            #endregion

            #region Predicate
            //Predicate<int> del = num => {  return no>10; };

            //if (del(no))
            //{
            //    Console.WriteLine($"{no} is greater than 10");

            //}
            //else
            //{
            //    Console.WriteLine($"{no} is NOT greater than 10");
            //} 
            #endregion

            #region Using ENUMERABLE 
            //double[] arr= { 1.56, 2.12, 3.58 };
            //var res = MySum(arr);
            //Console.WriteLine($"addition of teh array is {res}");

            //String[] names = { "John", "Mike", "Holland" };
            //var ress = MySum(names);
            //Console.WriteLine(ress); 
            #endregion

            #region Extension Method I
            //Console.WriteLine("Enter your email");
            //String? email = Console.ReadLine();

            //if (email != null)
            //{
            //    if (email.CheckForValidEmailID())            {
            //        Console.WriteLine("Valid Email");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Email");
            //    }
            //} 
            #endregion

            #region Extension Method II
            //int[] numbers = { 101, 102, 103, 104, 105 };
            //string[] days = { "Mon", "Tue", "Wed", "Sun" };

            //List<int> output1 = numbers.ConvertToList(1111);
            //foreach (var item in output1)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //List<string> output2 = days.ConvertToList(4789);
            //foreach (var item in output2)
            //{
            //    Console.WriteLine($"{item}");
            //} 
            #endregion

            #region Iterator Demo1
            //int[] arr = { 1, 2, 3, 4, 5 };
            ////arr[5] = 6;
            //foreach (int ele in arr)
            //{
            //    Console.WriteLine(ele);
            //}
            //List<int> lstArr = new List<int>();
            //lstArr.Add(11);
            #endregion

            #region MyCustomCollection
            //MyCustomCollection customCollectionobject = new MyCustomCollection();
            //customCollectionobject.AddElement(10);
            //customCollectionobject.AddElement(20);
            //customCollectionobject.AddElement(30);

            //var result = customCollectionobject.GetElemets;
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach( var item in customCollectionobject)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //MyCollection collection = new MyCollection();
            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion 


        }
        public static bool Check(int num)
        {
            return num > 10;
        }
        public static T MySum<T>(IEnumerable<T> arr) //IEnuerable is a collection class used to retreive data from the operation
        {
            dynamic sum = default(T);
            foreach (var ele in arr)
            {
                sum += ele;
            }
            return sum;
        }
    }

    public class MyCustomCollection : IEnumerable
    {
        private ArrayList arr = new ArrayList();
        public ArrayList GetElemets
        {
            //set
            //{
            //    arr.Add(value);
            //}
            get
            {
                return arr;
            }
        }
        public void AddElement(int element)
        {
            arr.Add(element);
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                yield return arr[i];
                // yield keyword forces CLR to remeber last element index, which we have returned from this for loop and next time returns next element by increasing index as per the for loop syntax condition.
            }
        }
    }

    public class MyCollection : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tuesday", "Wedensday", "Thrusday", "Firday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day; // yield keyword is used to return the value from the iterator method. And it maintains last index value.
            }
        }

        //public string[] Days
        //{
        //    get { return days; }
        //}
    }
    public static class MyClass //: String : not allowed. sesled class
    {
        public static bool CheckForValidEmailID(this string email)
        {
            return email.Contains("@b.com");
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int nonsenseParameter)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            Console.WriteLine($"Nonsense Parameter value = {nonsenseParameter}");
            return list;
        }
    }

}
