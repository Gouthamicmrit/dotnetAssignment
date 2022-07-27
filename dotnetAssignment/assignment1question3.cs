using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetAssignment
{
    internal class assignment1question3
    {
        static void main(string[] args)
        {
            string str;
            int l = 0;

            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("---------------------------------\n");
            Console.Write("Enter the word : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("The length of the word is : {0}\n\n", l);
            Console.ReadLine();


        }
    }
}
