using System;


namespace StackTrace
{
	// try-catch를 통해 예외를 처리하고 stackTrace를 통해 예외가 어디서 발생했는지 추적
	class MainApp
	{
		static void Main(string[] args)
		{
			try
			{
				int a = 1;
				Console.WriteLine(3 / --a);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.StackTrace);
			}
		}
	}
}
