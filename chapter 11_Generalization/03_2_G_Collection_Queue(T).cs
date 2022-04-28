using System;
using System.Collections.Generic;

namespace G_Collection_Queue_T_
{
	// 일반화컬렉션
	// 2. Queue<T>
	// 컬렉션의 Queue의 일반화버전이다.(단, 지정한 형식 외에는 담지 못한다.)
	// 큐는 FIFO이다(양방향의 통로와 같다.)
	class MainApp
	{
		static void Main(string[] args)
		{
			// queue<int> 선언
			Queue<int> queue = new Queue<int>();

			// 큐에 값 삽입
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);

			while (queue.Count > 0)	// 큐에 저장된 값의 갯수(= queue.Conunt)
				Console.WriteLine(queue.Dequeue());		// 큐의 값 출력
		}
	}
}
