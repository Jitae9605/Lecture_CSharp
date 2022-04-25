using System;
using System.Collections;

namespace Collection_Stack
{
    // 대표적인 콜렉션 소개
    // 3. Stack - Push(), Pop()
    // 큐는 LIFO이고 한번 출력하면 그 값은 사라진다.
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();  // Stack 선언

            // stack에 값 추가
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop()); // stack에서 값 출력(입력된 역순으로 출력된다 - 가장 최근에 삽입된게 가장 먼저나옴)   
        }
    }
}
