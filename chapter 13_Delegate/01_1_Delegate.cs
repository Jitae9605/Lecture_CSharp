using System;


namespace Delegate
{
	// 대리자
	// 메소드를 대신 호출해주는 호출자임.
	class MainApp
	{
		delegate int MyDelegate(int a, int b);

		class Calculator
		{
			public int Plus(int a, int b) { return a + b; }
			public static int Minus(int a, int b) { return a - b; }
		}
		
		static void Main(string[] args)
		{
			Calculator Calc = new Calculator();
			MyDelegate Callback;

			Callback = new MyDelegate(Calc.Plus);
			Console.WriteLine(Callback(3, 4));

			Callback = new MyDelegate(Calculator.Minus);
			Console.WriteLine(Callback(7, 5));

		}
	}
}
