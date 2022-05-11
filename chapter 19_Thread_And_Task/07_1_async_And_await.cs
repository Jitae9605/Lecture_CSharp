using System;
using System.Threading.Tasks;

namespace async_And_await
{
	class MainApp
	{
		async static private void MyMethod(int count)
		{
			Console.WriteLine("C");
			Console.WriteLine("D");

			await Task.Run(async () =>
			{
				for (int i = 1; i <= count; i++)
				{
					Console.WriteLine($"{i} / {count} ...");
					await Task.Delay(100);		//Thread.Sleep의 비동기 버전 
				}
			});

			Console.WriteLine("G");
			Console.WriteLine("H");
		}

		static void Caller()
		{
			Console.WriteLine("A");
			Console.WriteLine("B");

			MyMethod(3);

			Console.WriteLine("E");
			Console.WriteLine("F");
		}
		static void Main(string[] args)
		{
			Caller();

			Console.ReadLine(); // 프로그램 종료방지
		}
	}
}
