namespace _05Day_GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp1 = new Emp();
            emp1.Eid = 101;
            emp1.Ename = "Hugh Jackman";
            emp1.EAddress = "Sydney, Australia";

            Emp emp2 = new Emp();
            emp2.Eid = 102;
            emp2.Ename = "Tony Stark";
            emp2.EAddress = "Shivaji Nagar";

            Emp emp3 = new Emp();
            emp3.Eid = 103;
            emp3.Ename = "Tom Ellis";
            emp3.EAddress = "L.A";

            List<Emp> elist = new List<Emp>();
            elist.Add(emp1);
            elist.Add(emp2);
            elist.Add(emp3);
            foreach (Emp emp in elist)
            {
                Console.WriteLine($"Id: {emp.Eid}, Name: {emp.Ename}, Address : {emp.EAddress}");
            }

        }
    }

    public class Emp
    {
        private int _Eid;

        private String _Ename;

        private string _EAddress;

        public string EAddress
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public String Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }


        public int Eid
        {
            get { return _Eid; }
            set { Eid = value; }
        }


    }
}
