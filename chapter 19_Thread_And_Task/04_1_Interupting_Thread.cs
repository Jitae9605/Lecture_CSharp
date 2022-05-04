using System;
using System.Security.Permissions;
using System.Threading;

namespace Interupting_Thread
{
	class SideTask
	{
		int count;
		public SideTask(int count)
		{
			this.count = count;
		}

		public void KeepAlive()
		{
			try
			{
				Console.WriteLine("Runing thread isn't gonna be interrupted");
				Thread.SpinWait(1000000000);

				while (count > 0)
				{
					Console.WriteLine($"{count--} left");

					Console.WriteLine("Entering into WaitJoinSleep State...");
					Thread.Sleep(10);
				}
				Console.WriteLine("Count : 0");

			}

			catch (ThreadInterruptedException e)
			{
				Console.WriteLine(e);
			}

			finally
			{
				Console.WriteLine("Clearing resource...");
			}
		}

	}
	class MainApp
	{
		static void Main(string[] args)
		{
			SideTask task = new SideTask(100);
			Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
			t1.IsBackground = false;

			Console.WriteLine("Starting thread...");
			t1.Start();

			Thread.Sleep(100);

			Console.WriteLine("Interrupting thread...");
			t1.Interrupt();                                 // 쓰레드 취소됨(catch문 실행)

			Console.WriteLine("Waiting until thread stops...");
			t1.Join();

			Console.WriteLine("Finished...");
		}
	}
}
