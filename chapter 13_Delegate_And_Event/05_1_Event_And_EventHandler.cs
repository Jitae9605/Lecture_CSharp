using System;

namespace Event_And_EventHandler
{
	// 대리자 선언
	delegate void EventHandler(string message);

	class MyNotifier
	{
		// 이벤트선언
		public event EventHandler SomethingHappend;

		public void DoSomething(int number)		// 이벤트가 발생조건명시
		{
			int temp = number % 10;
			if (temp != 0 && temp % 3 == 0)
			{
				SomethingHappend(String.Format("{0} : 짝", number));     // 이벤트발생시 호출되는 SomethingHappend에게 내용을 전달(매개변수, 포맷 등)
			}
		}
	}

	class MainApp
	{
		static public void MyHandler(string message)		// 이벤트 핸들러
		{
			Console.WriteLine(message);						// 이벤트 발생시 하는일 을 정의
		}

		static void Main(string[] args)
		{
			MyNotifier myNotifier = new MyNotifier();
			myNotifier.SomethingHappend += new EventHandler(MyHandler);	// 이벤트에 이벤트핸들러 추가

			for (int i = 1; i < 30; i++)
			{
				myNotifier.DoSomething(i);
			}
		}
	}
}
