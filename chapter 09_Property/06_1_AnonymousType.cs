using System;

namespace AnonymousType
{
    //  무명형식
    // 한번 사용하고 다시는 사용하지 않을때 매우 유리
    // 단, 한번 값을 지정하면 이를 바꿀수 없다.
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");     // 무명형식

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };  // 무명형식

            Console.Write($"Subject: {b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}
