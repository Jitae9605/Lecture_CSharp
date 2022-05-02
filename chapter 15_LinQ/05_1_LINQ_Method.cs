using System;
using System.Linq;


namespace LINQ_Method
{
	// LinQ는 컴파일러가 그에맞는 메소드를 호출해 사용하는 것이다.
	// 즉, 바로 메소드를 호출해 사용하면 훨씬 빠르고 편할뿐 아니라 대응되지 않는 메소드가 훨씬많아
	// 더욱 다양하고 유용한 기능을 사용할수 있다.

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

			// 쿼리문은 실제로는 컴파일러가 이렇게 자동으로 인식해서 사용하는 것!
			// 이렇게 자동 대응되는 것의 가지수가 전체의 20%도 되지않는다 
			var profiles = arrProfile
						   .Where(profile => profile.Height < 175)
						   .OrderBy(profile => profile.Height)
						   .Select(profile =>
								new                               
								{
									Name = profile.Name,
									InchHeight = profile.Height * 0.393
								});

			foreach (var profile in profiles)
				Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
		}
	}
}
