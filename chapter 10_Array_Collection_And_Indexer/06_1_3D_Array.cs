using System;

namespace _3D_Array
{
    // 3차원 배열
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[4, 3, 2]    // [i, j, k]
            {
//                j1       j2     j3
                {{1,2},  {3,4},  {5,6} },   // i1
                {{1,4},  {2,5},  {3,6} },   // i2
                {{6,3},  {4,3},  {2,1} },   // i3
                {{6,3},  {5,2},  {4,1} }    // i4
//              {k1,k2} {k1,k2} {k1,k2}  
            };

            for (int i = 0; i < array.GetLength(0); i++)            // 0번 차원의 길이 = 4 (a)
            {
                for (int j = 0; j < array.GetLength(1); j++)        // 1번 차원의 길이 = 3 (b)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < array.GetLength(2); k++)    // 2번 차원의 길이 = 2 (c)
                    {
                        Console.Write($"{array[i, j, k]} ");        
                    }
                    Console.Write("} ");
                }
                Console.WriteLine();

            }
        }
    }
}
