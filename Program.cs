using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            double[] array2 = new double[5];
            CopyArray(array1, array2);

            public void CopyArray(int[] arr1, double[] arr2)
            {
                for (int i = 0; i < 5; i++)
                {
                    arr2[i] = i + new Random().NextDouble();

                    Console.Write($"{arr2.GetValue(i)}, ");
                }

                for (int i = 0; i < 5; i++)
                {
                    arr1[i] = (int)array2[i];

                    Console.Write($"{arr1.GetValue(i)}, ");
                }
                Console.ReadLine();
            }
        }
    }
}
