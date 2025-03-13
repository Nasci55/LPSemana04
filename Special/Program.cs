using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string input = Console.ReadLine();

            int num = int.Parse(input);

            System.Console.WriteLine(GetSpecial(num));
        }
        private static int GetSpecial(int n)
        {

            int amen = 0;

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                amen = GetSpecial(n - 1) + GetSpecial(n - 2) * 2;
            }

            return amen;
        }
    }
}
