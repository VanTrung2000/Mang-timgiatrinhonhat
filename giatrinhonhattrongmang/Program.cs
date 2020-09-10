using System;

namespace giatrinhonhattrongmang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 12, 7, 8, 10, 6, 9 };
            int index = minValue(arr);
            Console.WriteLine("Gia tri nho nhat la: " + arr[index]);
            Console.ReadLine();
            }

        private static int minValue(int[] arr)
        {
            int min = arr[0];
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            return index;
        }
    }

       
    }

