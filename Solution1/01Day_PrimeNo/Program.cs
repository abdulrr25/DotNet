namespace _01Day_PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if (isPrime(n))
                Console.WriteLine($"{n} Given no is Prime");
                else
                    Console.WriteLine($"{n} Given no is not a prime");
            
        }
        static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i *i                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }


    }
}



