using System;


namespace Initializing_Array
    // 배열을 초기화 하는 세가지 방법
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 1번 = 다 적어주기 - 협업때 좋음(다른 사람들이 파악하고 보기 편함)
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };

            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine($"{greeting}");

            // 2번 = 배열크기생략
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };

            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine($"{greeting}");

            // 3번 = 배열크기 + new 생략
            string[] array3 = new string[] { "안녕", "Hello", "Halo" };

            Console.WriteLine("\narray3...");
            foreach (string greeting in array3)
                Console.WriteLine($"{greeting}");
        }

    }
}
