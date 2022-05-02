using System;

namespace Statement_Lamda
{
	// 문형식의 람다식
	// 여러줄의 식을 가지는 람다식
	class MainApp
	{

		// 명령줄인수 = 다시빌드후 bin폴더에서 cmd를 열어서 'Lecture_CSharp.exe 문장입력'을 입력하면 문장의 띄어쓰기를 모두 제거해주는 프로그램
		delegate string Concatenate(string[] args);

		static void Main(string[] args)
		{
			Concatenate Concat = 
				(arr) =>
				{
					string result = "";
					foreach (string s in arr)
						result += s;

					return result;

				};

			Console.WriteLine(Concat(args));
		}
	}
}
