using System;


namespace LamdaExpression
{
	// 람다식의 사용
	class MainApp
	{
		delegate int Calculate(int a, int b);	// 람다식은 대리자를 통해 이용한다.

		static void Main(string[] args)
		{
			Calculate calc = (a, b) => a + b;	// 대리자로 호출 = (매개변수 목록) => 식
												// ' => ' == 좌측의 목록을 우측의 식에 매개변수로서 전달한다는 의미
			Console.WriteLine($"{3} + {4} : {calc(3, 4)}");
		}
	}
}
