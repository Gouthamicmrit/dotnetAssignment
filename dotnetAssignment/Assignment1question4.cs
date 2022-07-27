using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetAssignment
{
    internal class Assignment1question4
    {
        static void main(string[] args)
        {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter a Word to be reversed : ");

            str = Console.ReadLine();

            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }

            Console.WriteLine("Reversed word is {0}", reverse);
            Console.ReadLine();
        }
    }
}
