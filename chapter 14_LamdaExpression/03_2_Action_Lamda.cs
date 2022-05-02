using System;


namespace Action_Lamda
{
	// 매번 대리자를 선언하기 힘들기때문에 기본적으로 C#에는 대리자가 있다
	// 2. Action<>대리자 = 반환값이 없는 대리자. ( 매개변수는 최대 16개까지 입력가능)
	// (단순하게 Func에서 반환값이 없는 것)
	class MainApp
	{
		static void Main(string[] args)
		{
			Action act1 = () => Console.WriteLine("Action()"); // 매개변수없는 Action의 사용
			act1();

			int result = 0;         // Action2의 결과를 저장할 변수선언
			Action<int> act2 = (x) => result = x * x;       // 매개변수가 1개 있는 Action의 사용
															// 반환값이 없으므로 그 결과를 저장하려면 따로 변수가 선언되야한다.
			act2(3);
			Console.WriteLine($"result : {result}");

			// Statement Lamda(문 형식의 람다식) 의 Action대리자를 통한 활용, 응용
			Action<double, double> act3 = (x, y) =>
			 {
				 double pi = x / y;
				 Console.WriteLine($"Action<T1,T2>({x}, {y}) : {pi}");
			 };     //  콜론이 있어야함을 주의!

			act3(22.0, 7.0);
		

		}
	}
}
