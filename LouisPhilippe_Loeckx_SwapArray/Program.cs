using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouisPhilippe_Loeckx_SwapArray
{
    class Program
    {


        class ArrayValues
        {
            public int[] FirstArray;
            public int[] SecondArray;

            public void Show(int[] FirstArray, int[] SecondArray)
            {
                foreach (var ArrayOneNumber in FirstArray)
                {
                    Console.Write(ArrayOneNumber + " ");
                }
                foreach (var item in SecondArray)
                {
                    Console.Write(item + " ");
                }
            }

            public void Switch()
            {
                this.FirstArray = SecondArray;
                this.SecondArray = FirstArray;
            }
        }

        static void Main(string[] args)
        {
            ArrayValues Arrays = new ArrayValues();
            int[] firstArray = { 1,2,3,4,5,6 };
            int[] secondArray = { 6,5,4,3,2,1 };
            Arrays.FirstArray = firstArray;
            Arrays.SecondArray = secondArray;
            Arrays.Show(Arrays.FirstArray, Arrays.SecondArray);
            Arrays.Switch();
            Console.WriteLine();
            Arrays.Show(Arrays.FirstArray, Arrays.SecondArray);


        }

    }
}
