using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Error: Please enter a string argument");
                Console.WriteLine("Example: C:>GetStringLength.exe \"My String\"");
                return;
            }

            if (args.Length > 1)
            {
                Console.WriteLine("Error: Program accepts only 1 argument");
                Console.WriteLine("Suggestion: instead of C:>GetStringLength.exe My String try C:>GetStringLength.exe \"My String\"");
                return;
            }

            Console.WriteLine("String length: " + args[0].Length);
        }
    }
}
