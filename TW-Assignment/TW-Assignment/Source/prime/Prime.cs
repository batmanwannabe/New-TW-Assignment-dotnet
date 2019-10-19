using System.Collections.Generic;

namespace TW_Assignment.Source.prime
{
    public class Prime
    {
        static bool isAPrimeNo(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        public List<int> FindPrimesUpto(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isAPrimeNo(i))
                    primes.Add(i);
            }

            return primes;
        }
    }
}
