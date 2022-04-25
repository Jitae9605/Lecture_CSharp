using System;
using System.Collections;
using static System.Console;

namespace Collection_Initializing
{
    // 대표적 콜렉션들의 초기화(ArrayList, Queue, Stack)
    // 배열을 이용해 생성자로 생성될때 초기화가 가능
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };          // 초기화에 사용할 배열 선언 및 정의
            
            ArrayList list = new ArrayList(arr);    // ArrayList 선언 및 초기화
            foreach (object item in list)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack = new Stack(arr);           // Stack 선언 및 초기화
            foreach (object item in stack)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue queue = new Queue(arr);           // Queue 선언 및 초기화
            foreach (object item in queue)
                WriteLine($"Stack : {item}");
            WriteLine();


            // 또 다른 초기화 방법
            ArrayList list2 = new ArrayList() { 11, 22, 33 };    // ArrayList 선언 및 초기화
            foreach (object item in list2)
                WriteLine($"ArrayList : {item}");
            WriteLine();

        }

    }
}
