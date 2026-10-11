using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0]=new int[] {1,2,3,4, 5 };
            jaggedArray[1]=new int[] {6,7,8};
            jaggedArray[2]=new int[] {9,10,11,12};

            foreach (int[] row in jaggedArray)
            {
                foreach (int r in row)
                {
                    Console.WriteLine(r);
                }
            }

            Console.ReadKey();
        }
    }
}
