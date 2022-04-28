using System;

namespace Delegate_Chain
{
	// 대리자체인
	// 대리자로의 메소드호출을 체인처럼 연결하여 한번의 호출로 여러개의 메소드를 체인처럼 연결하여 차례대로 호출해올수있다

	// 대리자 선언
	delegate void Notify(string message);

	// Notify대리자의 인터스턴스 EventOccured를 가진 Notifier클래스 선언
	class Notifier
	{
		public Notify EventOccured; 
	}

	class EventListener
	{
		private string name;
		public EventListener(string name)
		{
			this.name = name;
		}

		public void SomthingHappend(string message)
		{
			Console.WriteLine($"{name}.SomthingHappend : {message}");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Notifier notifier = new Notifier();
			EventListener listener1 = new EventListener("Listener1");
			EventListener listener2 = new EventListener("Listener2");
			EventListener listener3 = new EventListener("Listener3");

			// 1. += 연산자를 이용한 체인만들기
			notifier.EventOccured += listener1.SomthingHappend;
			notifier.EventOccured += listener2.SomthingHappend;
			notifier.EventOccured += listener3.SomthingHappend;
			notifier.EventOccured("You've got mail.");

			Console.WriteLine();

			// -= 연산자를 이용한 체인 끊기
			notifier.EventOccured = new Notify(listener2.SomthingHappend)
									+ new Notify(listener3.SomthingHappend);
			notifier.EventOccured("Nuclear launch detected.");

			Console.WriteLine();

			// 2. +, = 연산자를 이용한 체인만들기
			Notify notify1 = new Notify(listener1.SomthingHappend);
			Notify notify2 = new Notify(listener2.SomthingHappend);

			// 3. Delegate.Combine()메소드를 이용한 체인만들기
			notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
			notifier.EventOccured("Fire!");

			Console.WriteLine();

			notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
			notifier.EventOccured("RPG!");
		}
	}
}
