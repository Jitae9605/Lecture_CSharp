using System;

namespace Finally
{
	// finally는 try-catch문 바로 뒤에 따라온다.
	// 어떠한 상황에서도 finally는 실행된다(예외처리,return,throw 등으로 아예 구문이동/건너뛰기 해도 finally는 실행되고 건너뛰어진다)
	class MainApp
	{
		static int Divide(int dividend, int divisor)
		{
			try
			{
				Console.WriteLine("Divide() 시작");
				return dividend / divisor;
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Divide() 예외발생");
				throw e;
			}
			finally
			{
				Console.WriteLine("Divide() 끝");
			}
		}

		static void Main(string[] args)
		{
			try
			{
				Console.Write("제수를 입력하세요 : ");
				string temp = Console.ReadLine();
				int dividend = Convert.ToInt32(temp);	// readline은 문자열을 입력받는다 그러므로 int로의 변환이 필요

				Console.Write("피제수를 입력하세요 : ");
				temp = Console.ReadLine();
				int divisor = Convert.ToInt32(temp);

				Console.WriteLine("{0} / {1} = {2}", dividend, divisor, Divide(dividend, divisor));
			}
			catch(FormatException e)
			{
				Console.WriteLine("에러 : " + e.Message);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("에러 : " + e.Message);
			}

			finally
			{
				Console.WriteLine("프로그램을 종료합니다.");
			}
		}
	}
}
