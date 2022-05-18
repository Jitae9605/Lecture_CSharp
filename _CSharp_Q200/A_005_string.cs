using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_5_string
{
	// 문자열 생성 및 문자열 만들고 조립하기
	class MainApp
	{
		static void Main(string[] args)
		{
			string a = "hello";
			string b = "h";

			b = b + "ello";
			Console.WriteLine(a == b);			// True
			Console.WriteLine("b = " + b);		// b = hello

			int x = 10;
			string c = b + '!' + " " + x;	// == c = 'hello' + '!' + ' ' + '10' 
			Console.WriteLine("c = " + c);		// c = hello! 10
		}
	}
}
