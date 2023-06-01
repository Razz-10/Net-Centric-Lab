using System;

namespace lab3
{
    class Jagedarr
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 }
            };
           /* int[][] array = new int[2][];
            array[0]=new int[] {1,2,3,4};
            array[1]= new int[] {5,6,7,8};*/
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
