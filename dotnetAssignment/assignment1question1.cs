using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetAssignment
{
    internal class assignment1question1
    {
        static void main(string[] args)
        {
            {
                int[] arr1 = new int[100];
                int i, mx, mn, n;
                int sum = 0, avg = 0;


                Console.Write("\n\nFind maximum and minimum element in an array :\n");
                Console.Write("--------------------------------------------------\n");

                Console.Write("Input the number of elements to be stored in the array :");
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


                Console.Write("Maximum element is : {0}\n", mx);
                Console.Write("Minimum element is : {0}\n", mn);
                Console.Write("sum is  : {0}\n", sum);
                Console.Write("average : {0}\n\n", avg);

                Console.ReadLine();
            }
        }
    }
}
