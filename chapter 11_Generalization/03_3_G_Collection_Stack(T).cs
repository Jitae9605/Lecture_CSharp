using System;
using System.Collections.Generic;

namespace G_Collection_Stack_T_
{
	// 일반화컬렉션
	// 3. Stack<T>
	// 컬렉션의 Stack의 일반화버전이다.(단, 지정한 형식 외에는 담지 못한다.)
	// 큐는 LIFO이다(양방향의 통로와 같다.)
	class MainApp
	{
		static void Main(string[] args)
		{
			// Stack<int> 선언
			Stack<int> stack = new Stack<int>();

			// stack 값 삽입
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack.Push(4);
			stack.Push(5);

			while (stack.Count > 0)
				Console.WriteLine(stack.Pop());	// 스택의 값 출력
		}
	}
}
