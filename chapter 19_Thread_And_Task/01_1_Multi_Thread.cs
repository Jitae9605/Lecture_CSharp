using System;
using System.Threading;

namespace Multi_Thread
{
	class MainApp
	{
		static void DoSomething()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine($"DoSomething : {i}");
				Thread.Sleep(10);			// sleep = 10밀리초 동안 CPU사용 멈춤
			}
		}


		static void Main(string[] args)
		{
			Thread t1 = new Thread(new ThreadStart(DoSomething));

			Console.WriteLine("Starting Thread...");
			t1.Start();

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine($"Main : {i}");
				Thread.Sleep(10);
			}

			Console.WriteLine("wating until thread stop...");
			t1.Join();

			Console.WriteLine("Finished");

		}
	}
}
