using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace BetterDecorador
{
    /// <summary>
    /// This programs adds decorations behind and after the strings.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method takes 3 arguments and keeps the first one in string
        /// converts the second into char and the third in int
        /// then it prints what comes out of the Decor method
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {



            if (args.Length == 0)
            {
                System.Console.WriteLine(Decor());
            }
            else
            {
                char sym = char.Parse(args[1]);
                int num = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], sym, num));
            }
        }


        /// <summary>
        /// This method takes the arguments in main and converts the char to str
        /// then it adds the char the number of times equal to the int.
        /// then returns the chars multiplied before and after the string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int n)
        {

            string str = Convert.ToString(dec);

            for (int i = n - 1; i > 0; i--)
            {
                str += dec;
            }

            return $"{str} {s} {str}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {

            return Decor("User did not specify args!", '=', 3);

        }
    }
}
