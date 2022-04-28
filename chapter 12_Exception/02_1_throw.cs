using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
	// Throgh로 조건을 만족한 경우/ 예외가 발생한 경우 이를 던지고 try-catch로 이를 받는다.

	class MainApp
	{
		static void DoSomething(int arg)
		{
			if (arg < 10)
				Console.WriteLine($"arg : {arg}");
			else
				throw new Exception("arg가 10보다 큽니다.");	// arg가 10보다 크면 catch로 
		}

		static void Main(string[] args)
		{
			try
			{
				DoSomething(1);
				DoSomething(3);
				DoSomething(5);
				DoSomething(7);
				DoSomething(9);
				DoSomething(11);
				DoSomething(13);    // DoSomething(11); 에서 예외가 발생해 catch문으로 갔으므로 이 행은 실행X
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

	}
}
