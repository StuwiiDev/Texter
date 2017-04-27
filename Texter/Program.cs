using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThis program removes tabbed spaces from text files and outputs to a new specified file\n");

            if (args.Length == 2)
            {

                Console.WriteLine("Input TXT: {0}", args[0]);
                Console.WriteLine("Output TXT: {0}", args[1]);
                Console.WriteLine("Program to remove tabbed spaces in txt files");
                var newFile = new NewStringText();
                newFile.ToTxt(args[0], args[1]);
                Console.WriteLine("First line: " + newFile.FirstLine);
                Console.WriteLine("Number of Lines: " + newFile.NumberOfLines);



            }
            else
            {

                Console.WriteLine("Correct way of entering. texter {input txt name inc .txt} {output txt name inc .txt}");
            }
        }
    }
}
