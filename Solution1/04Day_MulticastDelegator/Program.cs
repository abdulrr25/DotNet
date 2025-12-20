using System;

namespace _04Day_MulticastDelegator
{

    public delegate void del1();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Guest arrived?");
            string isGuestArrived = Console.ReadLine();

               CollegeProgram obj = new CollegeProgram();
            // handler is our Muti-cast Delegate
            del1 handler = obj.WelCome;
            handler += obj.WelSpeech;
            if (isGuestArrived == "y")
            {
                handler += obj.GuestSpeech;
            }
            else
            {
                // -= del-coupling operator
                handler -= obj.GuestSpeech;
            }
            handler += obj.Dance;
            handler += obj.Dinner;
            handler += obj.GoodBye;
            handler += obj.EndEvent;

            handler();

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
