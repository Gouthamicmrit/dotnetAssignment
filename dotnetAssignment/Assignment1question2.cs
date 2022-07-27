using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetAssignment
{
    internal class Assignment1question2
    {
        static void main(string[] args)
        {



            int[] arr1 = new int[10];
            int i, mx, mn, n = 10;
            int sum = 0, avg = 0;


            Console.Write("\n\n STUDENT MARKS :\n");
            Console.Write("--------------------------------------------------\n");

            Console.Write("enter the number of marks  :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];

                }

            }
            // averag0
            for (i = 0; i < n; i++)
            {
                sum = sum + arr1[i];
            }

            avg = sum / n;




            Console.Write("\n\nMaximum marks is : {0}\n", mx);
            Console.Write("Minimum marks is : {0}\n", mn);
            Console.Write("total marks is  : {0}\n", sum);
            Console.Write(" average marks : {0}\n\n", avg);

            Array.Sort(arr1);
            foreach (int value in arr1)
            {

                Console.WriteLine(" ascending  order is " + value);
            }

           
            Array.Reverse(arr1);

            foreach (int value in arr1)
            {


                Console.WriteLine("\n\n And the descending order is " + value);
            }


            Console.ReadLine();

        }
    }
}
