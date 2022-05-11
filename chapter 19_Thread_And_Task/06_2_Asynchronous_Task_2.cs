using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asynchronous_Task_2
{
	// Task<TResult>의 이용2
	// 인수로 입력받은 두수사이의 모든 소수의 목록을 반환
	// 단, 3번째 인수로 비동기로 생성해 작업을 동등분할로 진행할 쓰레드 갯수를 입력
	// 경과시간을 출력함으로써 비동기 테스크의 우수성을 확인 
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
			int taskCount = Convert.ToInt32(args[2]);   // 생성할 비동기 태스크의 갯수

			Func<object, List<long>> FindPrimeFunc =
				(objRange) =>
				{
					long[] range = (long[])objRange;
					List<long> found = new List<long>();

					for (long i = range[0]; i < range[1]; i++)
					{
						if (IsPrime(i)) found.Add(i);
					}

					return found;
				};

			// 테스크 생성 하고 작업영역을 균등하게 분할하기 위함
			Task<List<long>>[] tasks = new Task<List<long>>[taskCount];

			long currentFrom = from;
			long currentTo = to / tasks.Length;

			for (int i = 0; i < tasks.Length; i++)
			{
				Console.WriteLine("Task[{0}] : {1} ~ {2}", i, currentFrom, currentTo);

				tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentFrom, currentTo });
				currentFrom = currentTo + 1;

				if (i == tasks.Length - 2) currentTo = to;
				else currentTo = currentTo + (to / tasks.Length);
			}

			Console.WriteLine("Please press enter to start...");
			Console.ReadLine();										// ENTER를 입력하면 다음으로 진행
			Console.WriteLine("Started...");

			// 시작시간 기록
			DateTime startTime = DateTime.Now;

			// 각각의 태스크 모두 시작
			foreach (Task<List<long>> task in tasks)
				task.Start();

			// 각 태스크의 결과를 취합할 total List 생성
			List<long> total = new List<long>();

			// 각 테스크의 결과(List<long>형식)를 배열로 변환해서 List<long> total에 추가
			foreach (Task<List<long>> task in tasks)
			{
				task.Wait();
				total.AddRange(task.Result.ToArray());
			}

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
