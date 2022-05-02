using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_From_LINQ
{	
	// 다중 from을 통한 데이터 추출

	class Class
	{
		public string Name { get; set; }
		public int[] Score { get; set; }
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Class[] arrClass =
			{
				new Class(){Name = "연두반", Score = new int[] {99, 80, 70, 24}},
				new Class(){Name = "분홍반", Score = new int[] {60, 45, 87, 72}},
				new Class(){Name = "파랑반", Score = new int[] {92, 30, 85, 94}},
				new Class(){Name = "노랑반", Score = new int[] {90, 88, 0, 17}}
			};

			var classes = from c in arrClass					// arrClass의 각 요소를 c로 뽑아내고
						  from s in c.Score						// c.Score의 각 요소를 s로 뽑아내서
						  where s < 60							// s의 값중 조건에 참인 데이터만을 뽑아낸다.
						  orderby s								// s의 값에따라 각자 정렬
						  select new { c.Name, Lowest = s };	// 뽑아낸 데이터를 가공해서 출력

			foreach (var c in classes)
				Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
		}
	}
}
