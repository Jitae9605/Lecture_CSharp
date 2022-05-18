using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_3_Input
{
	// Console.ReadLine을 이용한 데이터입력
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.Write("Hello ");
			Console.WriteLine("World!");
			Console.Write("이름을 입력하세요 : ");

			string name = Console.ReadLine();
			Console.WriteLine("안녕하세요.");
			Console.Write($"{name}님!");
		}
	}
}
