namespace _04Day_MulticastDelegator
{

    public delegate void del1();
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();    
        }
    }

    public class CollegeProgram {
        public void WelCome()
        {
            Console.WriteLine("Wel-come Everyone!!");
        }
        public void WelSpeech()
        {
            Console.WriteLine("Host: blah blah blah blah!!");
        }
        public void GuestSpeech()
        {
            Console.WriteLine("Guest: blah blah blah blah!!");
        }
        public void Dance()
        {
            Console.WriteLine("Oh GOD, we have have to go through this!!");
        }
        public void Dinner()
        {
            Console.WriteLine("We insist everyone , please enjoy dinner...!!");
        }
        public void GoodBye()
        {
            Console.WriteLine("Bye bye.. please ghar jao...!!");
        }
        public void EndEvent()
        {
            Console.WriteLine("Pack UP...!!");
        }
    }

}
