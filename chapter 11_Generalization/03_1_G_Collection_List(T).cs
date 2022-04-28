using System;
using System.Collections.Generic;

namespace G_Collection_List_T_
{
	// 일반화컬렉션
	// 1. List<T>
	// 컬렉션의 ArrayList의 일반화버전이다.(단, 지정한 형식 외에는 담지 못한다.)

	class MainApp
	{
		static void Main(string[] args)
		{
			// List<int> 선언
			List<int> list = new List<int>();

			// list에 값 삽입
			for (int i = 0; i < 5; i++)
				list.Add(i);

			// list의 값 출력
			foreach (int element in list)
				Console.WriteLine($"{element}");
			Console.WriteLine();

			// list[2]값 삭제 - 뒤에 것들이 다 당겨져 온다(빈칸X) 
			list.RemoveAt(2);

			foreach (int element in list)
				Console.WriteLine($"{element}");
			Console.WriteLine();

			// list[2]에 값 삽입 - 본래의 값과 뒤의 값들을 한칸씩 뒤로 밀고 값이 삽입된다.
			list.Insert(2, 2);

			foreach (int element in list)
				Console.WriteLine($"{element}");
			Console.WriteLine();
		}
	}
}
