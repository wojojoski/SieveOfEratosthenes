namespace Algorytmy_SitoEratostenesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj przedział [m, n], aby znaleźć wszystkie liczby pierwsze w tym przedziale.");
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> primes = SieveOfEratosthenes(m, n);

            Console.WriteLine($"Liczby pierwsze w przedziale [{m}, {n}]:");
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
        }

        static List<int> SieveOfEratosthenes(int m, int n)
        {
            bool[] isPrime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = Math.Max(m, 2); i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
