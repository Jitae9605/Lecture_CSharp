using System;
using System.Collections;


namespace Collection_ArrayList
{
    // 대표적인 콜렉션 소개
    // 1. ArrayList - Add(), RemoveAt(), Insert()
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();   // ArrayList 생성
            for (int i = 0; i < 5; i++)
                list.Add(i);                    // list에 값 추가

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.RemoveAt(2);                   // list에서 2번요소 값 제거 ( 2번요소 뒤의 값들은 앞으로 당겨진다  즉, 빈곳없이 채워져있다 )

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

            list.Insert(2, 2);                   // list의 요소번호 2번에 값 2를 삽입 ( 2번요소와 뒤의 값들은 뒤로 밀린다 즉, 빈곳없이 채워져있다 )

            foreach (object obj in list)
                Console.Write($"{obj}");
            Console.WriteLine();

        }

    }
}
