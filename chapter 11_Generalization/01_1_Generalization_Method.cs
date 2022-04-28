using System;


namespace Generalization_Method
{
	// 일반화란, 특수한 개념으로부터 공통된 개념을 찾아 묶는 것이다. 
	// 
	class MainApp
	{
		// 일반화 배열복사 메소드
		static void CopyArray<T>(T[] source, T[] target)
		{
			for (int i = 0; i < source.Length; i++)
			{
				target[i] = source[i];
			}
		}

		static void Main(string[] args)
		{
			// int형 배열 복사
			int[] source = { 1, 2, 3, 4, 5 };
			int[] target = new int[source.Length];

			CopyArray<int>(source, target);

			foreach (int element in target)
				Console.WriteLine(element);

			// string형 배열 복사
			string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
			string[] target2 = new string[source2.Length];

			CopyArray<string>(source2, target2);

			foreach (string element in target2)
				Console.WriteLine(element);
		}
	}
}
