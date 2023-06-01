using System;


namespace lab3
{
    class Matrixmul
    {
        static void Main(string[] args)
        {
            int r1, c1;
            Console.WriteLine("Enter the row and column of first matrix:");
            r1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[r1,c1];

            int r2, c2;
            Console.WriteLine("Enter the row and column of second matrix:");
            r2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());
            int[,] mat2 = new int[r2,c2];

            if(c1 != r2) {
                Console.WriteLine("Multiplication is not Possible");
            
            }
            else
            {

                Console.WriteLine("Enter the element of mat1");
                for(int i = 0; i < r1; i++)
                {
                   for(int j = 0; j < c1; j++)
                    {
                        mat1 [i,j] = int.Parse(Console.ReadLine());
                    }
                }


                Console.WriteLine("Enter the element of mat2");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        mat2 [i,j] = int.Parse(Console.ReadLine());
                    }
                }
                int[,] mul = new int[r1,c2];
                for(int i = 0; i < r1; i++)
                {
                    for( int j = 0; j < c2; j++)
                    {
                        for(int k = 0; k < c1; k++)
                        {
                            mul[i, j] = 0;
                            mul[i, j] += mat1[i, k] * mat2[k, j]; 
                        }
                    }
                }

                Console.WriteLine("The matrix multiplication is :");
                for( int i = 0; i < r1; i++)
                {
                    for(int j=0; j < c2; j++)
                    {
                        Console.Write(mul[i,j]+" ");
                    }
                    Console.WriteLine();
                }

            }





        }



    }
}
