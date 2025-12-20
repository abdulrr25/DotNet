namespace _05Day_ObserverPattern
{

    public delegate void notifyEventHandler(String message);
    internal class Program
    {
        static void Main(string[] args)
        {
           Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.Notify += subscriber.methodA;
            publisher.Notify += subscriber.methodB;

            publisher.NotifySubscriber("Rahman");

            publisher.Notify-= subscriber.methodA;
            publisher.NotifySubscriber("Abdul");
        }
    }

    public class Subscriber
    {
        public void methodA(String message)
        {
            Console.WriteLine($"Hello From {message}");
        }
        public void methodB(String message)
        {
            Console.WriteLine($"Hellooowwwww {message} from B ");
        }
    }

    public class Publisher
    {
        public event notifyEventHandler Notify;

        public void NotifySubscriber(String message)
        {
            Notify.Invoke(message);
        }
    }
}
