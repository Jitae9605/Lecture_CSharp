using System;
using System.Threading;

namespace AbortingThread
{
	// Abort()는 스레드를 종료시키는 메소드이다.
	// 그런데 다른 스레드에서 쓰고 있는자원을 Abort하게되면 다른 스레드가 그 값을 접근할수 없게되어 프로그램에 이상이 발생함

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
				while (count > 0)
				{
					Console.WriteLine($"{count--} left");
					Thread.Sleep(10);
				}
				Console.WriteLine("Count : 0");
			}
			catch (ThreadAbortException e)
			{
				Console.WriteLine(e);
				Thread.ResetAbort();
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

			Console.WriteLine("Aborting thread...");
			t1.Abort();									// 쓰레드 취소됨(catch문 실행)

			Console.WriteLine("Waiting until thread stops...");
			t1.Join();

			Console.WriteLine("Finished...");
		}
	}
}
