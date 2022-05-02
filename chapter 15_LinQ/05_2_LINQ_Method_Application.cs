using System;
using System.Linq;


namespace LINQ_Method_Application
{
	// LINQ_Method를 이용해 키를 175이상그룹, 175미만 그룹으로 나누고
	// 각 그룹별 가장 키가 큰 사람의 키와 작은 사람의 키를 뽑고 전체의 키의 평균을 구한다.

	class Profile
	{
		public string Name { get; set; }
		public int Height { get; set; }
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Profile[] arrProfile =
			{
				new Profile() { Name="정우성", Height=186},
				new Profile() { Name="김태희", Height=158},
				new Profile() { Name="고현정", Height=172},
				new Profile() { Name="이문세", Height=178},
				new Profile() { Name="하하", Height=171}
			};

			var heightStar = from profile in arrProfile
							 group profile by profile.Height < 175 into g
							 select new
							 {
								 Group	= g.Key == true ? "175미만" : "175이상",	  // g.Key가 true면 Group = "175미만"/ false면 Group = "175이상"
								 Count	= g.Count(),							  // g의 요소수 = 그룹내의 요소수
								 Max	= g.Max(profile => profile.Height),		  // 가장큰 키
								 Min	= g.Min(profile => profile.Height),		  // 가장작은 키
								 Avg	= g.Average(profile => profile.Height)	  // 평균 키
							 };
			foreach (var stat in heightStar)
			{
				Console.WriteLine("{0} - Count:{1}, Max:{2}, Min:{3}, AVG:{4}", stat.Group, stat.Count, stat.Max, stat.Min, stat.Avg);
			}
		}
	}
}
