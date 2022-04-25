using System;


namespace JaggedArray
{
    // 가변배열
    // 배열을 요소로 가지는 배열로 
    // 각기 다른 크기를 가지는 배열들로 다차원 배열을 형성
    class MainApp
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];       // 가변 배열 선언 ( 3개의 int형을 저장할 배열을 jagged에 보관하겠다 선언 )
            jagged[0] = new int[5] {1,2,3,4,5};  // 서로다른 크기의 배열을 배열 jagged에 넣을수 있다.
            jagged[1] = new int[] {10,20,30};
            jagged[2] = new int[] {100,200};

            foreach (int[] arr in  jagged)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach(int e in arr)
                {
                    Console.Write($"{e} ");

                }
                Console.WriteLine("");

            }
            Console.WriteLine("");

            int[][] jagged2 = new int[2][]
            {
                new int[] { 1000, 2000},
                new int[4] {6,7,8,9}
            };

            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");

                }
                Console.WriteLine("");

            }
            Console.WriteLine("");


        }
    }
}
