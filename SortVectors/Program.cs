using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] array = new int[10];

            //metto numeri random
            Random r = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
            }

            ArrayAConsole(array);


            Console.ReadKey();
            BubbleSort(array);
            ArrayAConsole(array);

        }

        public static void BubbleSort(int[] array)
        {
            int scambio;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - i - 1; i++)
                {
                    if(array[j] > array[j + 1])
                    {
                        scambio = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = scambio;
                    }
                }
            }
        }

        public static void ArrayAConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
