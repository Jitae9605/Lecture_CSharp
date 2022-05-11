using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Task_3
{
	// Task<TResult>의 이용 3 - Parallel클래스
	// 인수로 입력받은 두수사이의 모든 소수의 목록을 반환
	// 단, 3번째 인수로 비동기로 생성해 작업을 동등분할로 진행할 쓰레드 갯수를 입력
	// 경과시간을 출력함으로써 비동기 테스크의 우수성을 확인 
	// 단, Parallel 클래스를 이용함
	class MainApp
	{
		// 소수인지 판단하는 함수
		static bool IsPrime(long number)
		{
			if (number < 2) return false;

			if (number % 2 == 0 && number != 2) return false;

			for(long i = 2; i <number; i++)
			{
				if (number % i == 0) return false;
			}

			return true;
		}

		static void Main(string[] args)
		{
			long from = Convert.ToInt64(args[0]);		// 소수판단 범위 시작
			long to = Convert.ToInt64(args[1]);         // 소수판단 범위 끝

			Console.WriteLine("Please press enter to start...");
			Console.ReadLine();										// ENTER를 입력하면 다음으로 진행
			Console.WriteLine("Started...");

			// 시작시간 기록
			DateTime startTime = DateTime.Now;

			// 각 태스크의 결과를 취합할 total List 생성
			List<long> total = new List<long>();

			// Parallel.For 을 이용한 소수찾기
			// Parallel은 몇개의 메소드를 이용할지 내부적으로 판단해 알아서 최적화 하고 실행함
			Parallel.For(from, to, (long i) =>
			{
				if (IsPrime(i))
					lock (total)
						total.Add(i);
			});

			// 종료시간기록
			DateTime endTime = DateTime.Now;

			// 경과시간 계산 = 종료시간 - 시작시간
			TimeSpan elapsed = endTime - startTime;

			// 소수의 갯수이므로 total의 값 갯수를 Count로 출력
			// total에는 소수의 값들도 들어있다
			Console.WriteLine("Prime number count between {0} and {1} : {2}", from, to, total.Count);
			Console.WriteLine("Elsapsed time : {0}", elapsed);
		}
	}
}
