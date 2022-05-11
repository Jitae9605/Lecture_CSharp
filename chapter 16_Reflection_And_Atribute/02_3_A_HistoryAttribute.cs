using System;

namespace A_HistoryAttribute
{
	// 나만의 커스텀 애트리뷰트를 만들고 정의해보자
	//  - 애트리뷰트를 이용하여 버전관리를 해보자
	[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]	// 애트리뷰트의 애트리뷰트
	class history : System.Attribute	// 이렇게 클래스에 상속만 시켜주면 이 클래스는 이제 애트리뷰트가 됨
	{
		private string programmer;
		public double version;
		public string changes;

		public history(string programmer)
		{
			this.programmer = programmer;
			version = 1.0;
			changes = "First release";
		}

		public string GetProgrammer()
		{
			return programmer;
		}
	}

	// 애트리뷰트 생성
	[history("Sen", version = 0.1, changes = "2017-11-01 Created class stub")]
	[history("Bob", version = 0.2, changes = "2020-12-03 Added Func() Method")]

	class MyClass
	{
		public void Func()
		{
			Console.WriteLine("Func()");
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Type type = typeof(MyClass);
			Attribute[] attributes = Attribute.GetCustomAttributes(type);

			Console.WriteLine("MyClass change history...");

			foreach(Attribute a in attributes)
			{
				history h = a as history;
				if (h != null)
					Console.WriteLine("Ver: {0}, Programmer: {1}, changes: {2}", h.version, h.GetProgrammer(), h.changes);
			}
		}
	}
}
