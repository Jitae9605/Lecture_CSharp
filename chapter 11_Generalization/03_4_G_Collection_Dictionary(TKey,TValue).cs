using System;
using System.Collections.Generic;

namespace G_Collection_Dictionary_TKey_TValue
{
	// 일반화컬렉션
	// 4. Dictionary<TKey,TValue>
	// 컬렉션의 Hashtable의 일반화버전이다.(형식매개변수를 2개 요구한다.)
	
	class MainApp
	{
		static void Main(string[] args)
		{
			//Dictionary<TKey, TValue> 선언
			Dictionary<string, string> dic = new Dictionary<string, string>();

			// Dictionary 값 삽입
			// dic[키] = 값
			dic["하나"] = "one";
			dic["둘"] = "two";
			dic["셋"] = "three";
			dic["넷"] = "four";
			dic["다섯"] = "five";

			Console.WriteLine(dic["하나"]);
			Console.WriteLine(dic["둘"]);
			Console.WriteLine(dic["셋"]);
			Console.WriteLine(dic["넷"]);
			Console.WriteLine(dic["다섯"]);
		}
	}
}
