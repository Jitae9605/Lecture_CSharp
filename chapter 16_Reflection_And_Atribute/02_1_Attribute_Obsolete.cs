using System;

namespace Attribute_Obsolete
{
	class MainApp
	{
		class MyClass
		{
			[Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]	// 바로 밑에 있는 함수를 대상으로 한다.
			public void OldMethod()
			{
				Console.WriteLine("I'm old");
			}

			public void NewMethod()
			{
				Console.WriteLine("I'm new");
			}
		}
		static void Main(string[] args)
		{
			MyClass obj = new MyClass();

			obj.OldMethod();
			obj.NewMethod();
		}
	}
}
