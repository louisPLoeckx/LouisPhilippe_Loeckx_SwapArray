using System;

namespace LouisPhilippe_Loeckx_SwapArray
{
    class Program
    {

        static void Main(string[] args)
        {            
            int[] firstArray = { 1,2,3,4,5,6 };
            int[] secondArray = { 6,5,4,3,2,1 };

            Console.WriteLine("First Array:");
            foreach (var ArrayOneNumber in firstArray)
            {
                Console.Write(ArrayOneNumber + " ");
            }

            Console.WriteLine("Second Array:");
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] ^= secondArray[i];
                secondArray[i] ^= firstArray[i];
                firstArray[i] ^= secondArray[i];

            }

            Console.WriteLine();

            Console.WriteLine("First Array:");
            foreach (var ArrayOneNumber in firstArray)
            {
                Console.Write(ArrayOneNumber + " ");
            }
            Console.WriteLine("Second Array:");
            foreach (var item in secondArray)
            {
                Console.Write(item + " ");
            }

        }

    }
}
