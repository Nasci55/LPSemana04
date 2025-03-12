using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence:");
            string input = Console.ReadLine();

            int num = int.Parse(input);

            System.Console.WriteLine(GetSpecial(num));
        }
        private static int GetSpecial(int n)
        {
            int firstnum = 0;
            int secNum = 1;

            for (int i = 0; i < n; i++)
            {

            }

            return secNum;
        }
    }
}
