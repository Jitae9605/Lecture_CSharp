using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Basic
{
	// From,Where,Orderby,Select
	// LINQ는 항상 from으로부터 시작한다고 보면된다.
	// from은 데이터를 뽑아낼 대상과 범위를 
	// where은 조건을 통해 조건에 맞는 데이터만을 걸러내는 필터의 역할을
	// orderby는 뽑아낸 데이터의 정렬을(오름차순 : ascending, 내림차순 : descending)
	// select는 선정된 데이터를 토대로 정제하고 추출한다.(01_2 참고)
	class MainApp
	{
		static void Main(string[] args)
		{
			int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

			var result = from n in numbers			// numbers로부터 n을 뽑아낸다(foreach와 같다)
						 where n % 2 == 0			// 각각의 n에 대해 'n % 2 == 0'을 만족하는 n을 찾는다.
						 orderby n					// 그렇게 찾은 n들을 n에대해 오름차순 정렬(= ascending)하고(내입차순 : orderby n descending)
						 select n;                  // n을 반환/추출한다.

			foreach (int n in result)
				Console.WriteLine($"짝수 : {n}");
		}
	}
}
