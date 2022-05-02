using System;


namespace Func_Lamda
{
	// 매번 대리자를 선언하기 힘들기때문에 기본적으로 C#에는 대리자가 있다
	// 1. Func<>대리자 = 반환값이 있는 대리자. (마지막 형식변환자가 반환값, 매개변수는 최대 16개까지 입력가능)
	class  MainApp
	{
		static void Main(string[] args)
		{
			Func<int> func1 = () => 10;     // 매개변수 없이 무조건 10을 반환하는 람다식
			Console.WriteLine($" func1() : {func1()}");

			Func<int,int> func2 = (x) => x*2;     // 매개변수로 int x를 받고 반환값으로 x*2를 반환
			Console.WriteLine($" func2(4) : {func2(4)}");

			Func<double, double, double> func3 = (x,y) => x / y;     // 매개변수로 int x, int y를 받고 반환값으로 x / y를 반환
			Console.WriteLine($" func3(22,7) : {func3(22,7)}");
		}
	}
}
