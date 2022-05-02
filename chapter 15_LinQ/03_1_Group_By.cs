using System;
using System.Linq;


namespace Group_By
{
	// Group_By를 통한 추출데이터 그룹화

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

			var listProfile = from profile in arrProfile
							  orderby profile.Height
							  group profile by profile.Height < 175 into g      // profile을 'profile.Height < 175'조건에 참/거짓으로 각각 g에 컬렉션으로 저장됨
							  select new { GropKey = g.Key, Profiles = g };     // g.key는 group절의 조건의 True, False의 두가지를 의미
																				// 즉 g는 현재 Name, Height 2개를 가지고 있고, 조건의 만족여부를 나타내는 g.Key함수를 사용가능
																				// listProfile은 { GropKey = g.Key, Profiles = g } 인 것

			foreach (var Group in listProfile)
			{
				Console.WriteLine($"\n- 175cm 미만? : {Group.GropKey}\n");			// Group.GroupKey에는 True/False 뿐이다

				foreach (var profile in Group.Profiles)
				{
					Console.WriteLine($">>> {profile.Name}, {profile.Height}");
				}
			}
		}
	}
}
