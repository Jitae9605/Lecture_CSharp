using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_8_Console_WriteLine_Format
{
	// 문자열출력의 두가지 포맷
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);

			string primse;
			primse = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
			Console.WriteLine(primse);
		}
	}
}
