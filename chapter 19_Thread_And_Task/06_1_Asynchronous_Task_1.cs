using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace Asynchronous_Task_1
{
	// Task<TResult>의 이용1

	// 비동기 태스크,쓰레드
	// 3개의 task를 이용해 파일을 복사
	// 앞의 두개는 비동기로 파일을 복사, 3번째 task는 동기로 파일을 복사
	class MainApp
	{
		static void Main(string[] args)
		{
			string srcFile = args[0];

			Action<object> FileCopyAction = (object state) =>
			{
				String[] paths = (String[])state;
				File.Copy(paths[0], paths[1]);

				Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
					Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
			};

			Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

			Task t2 = Task.Run(() =>
			{
				FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
			});

			t1.Start();

			Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });
			t3.RunSynchronously();

			t1.Wait();
			t2.Wait();
			t3.Wait();


		}
	}
}
