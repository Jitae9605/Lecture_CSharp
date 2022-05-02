using System;
using System.Linq;


namespace Join
{
	// 두 데이터원본의 특정 필드값을 비교후 일치하는 데이터끼리 연결하는 연산
	// 1. 내부조인
	// 두 데이터원본 사이에 일치하는 데이터들만 연결한후 반환(첫번째가 기준이된다)
	// 이떄, 첫번째에는 있는데 두번째에는 없다면 아예 출력X

	// 2. 외부조인
	// 기준이 되는 데이터원본이 모두 포함된다.
	// 즉, 첫번째에는 있는데 두번째에는 없다면 첫번째는 출력되데 두번째로 join되어 삽입/추가 되어야할 값은 빈칸(또는 지정한 값)이 들어간다.
	// 기준은 첫번쨰다
	class Profile
	{
		public string Name { get; set; }
		public int Height { get; set; }
	}

	class Product
	{
		public string Title { get; set; }
		public string Star { get; set; }
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

			Product[] arrProduct =
			{
				new Product(){Title="비트",			Star="정우성"},
				new Product(){Title="CF 다수",		Star="김태희"},
				new Product(){Title="아이리스",		Star = "김태희"},
				new Product(){Title="모래시계",		Star="고현정"},
				new Product(){Title="Solo 예찬",		Star="이문세"}
			};

			// 내부조인
			var listProfile =
				from profile in arrProfile
				join product in arrProduct on profile.Name equals product.Star  // profile.Name == product.Star 인것 내부조인
				select new
				{
					Name = profile.Name,
					Work = product.Title,
					Height = profile.Height
				};

			Console.WriteLine("---- 내부조인 결과 ----");
			foreach(var profile in listProfile)
			{
				Console.WriteLine("이름: {0}, 작품: {1}, 키: {2}cm", profile.Name, profile.Work, profile.Height);
			}
			// 하하없음 - product에 하하가 없기 때문에 join되지않은 것!
			// 하하를 포함해서 보려며 외부조인을 해야한다.

			// 외부조인
			listProfile =
				from profile in arrProfile
				join product in arrProduct on profile.Name equals product.Star into ps		// 임시컬렉션 ps에 결과를 저장
				from product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없음" })	// 임시컬렉션의 빈 곳(하하-Title)에 넣을 값 지정
				select new
				{
					Name = profile.Name,
					Work = product.Title,
					Height = profile.Height
				};
			Console.WriteLine();

			Console.WriteLine("---- 외부조인 결과 ----");
			foreach (var profile in listProfile)
			{
				Console.WriteLine("이름: {0}, 작품: {1}, 키: {2}cm", profile.Name, profile.Work, profile.Height);
			}
		}
	}		
}			
									 
