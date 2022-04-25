using System;
using System.Collections;

namespace Collection_Queue
{
    // 대표적인 콜렉션 소개
    // 2. Queue - Enqueue(), Dequeue()
    // 큐는 FIFO이고 한번 출력하면 그 값은 사라진다.
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();        // Queue 선언

            // que에 값 삽입
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());   // que에서 값 출력(입력된 순서대로 출력된다 - 먼저들어간게 가장 먼저나옴)   
        }
    }
}
