using System;
using System.Collections.Generic;

namespace Expression_Bodied_Member
{
	class FriendList
	{
		private List<string> list = new List<string>();

		// 람다식을 이용해 List의 기본 함수를 좀더 편하게 불려보자
		public void Add(string name) => list.Add(name);
		public void Remove(string name) => list.Remove(name);

		public void PrintAll()
		{
			foreach (var s in list)
				Console.WriteLine(s);
		}

		// 생성자, 소멸자에 함수를 덧붙여보자
		public FriendList() => Console.WriteLine("FriendList()");
		~FriendList() => Console.WriteLine("~FriendList()");

		// public int Capacity => list.Capacity;			// 읽기전용 속성
		// public string this[int index] => list[index];	// 읽기전용 인덱스

		// 읽기/쓰기 가능한 속성
		public int Capacity // 속성
		{
			// List에 들어갈수 있는 요소의 갯수(=List의 용량)을 나타냄(= list.capacity)
			get => list.Capacity;
			set => list.Capacity = value;
		}

		// 읽기/쓰기 가능한 인덱스
		public string this[int index]
		{
			get => list[index];
			set => list[index] = value;
		}

	}
	// 식으로 이루어지는 멤버
	class MainApp
	{
		static void Main(string[] args)
		{
			FriendList obj = new FriendList();
			obj.Add("Eeny");
			obj.Add("Meeny");
			obj.Add("Miny");
			obj.Remove("Eeny");
			obj.PrintAll();
			Console.WriteLine();

			Console.WriteLine($"{obj.Capacity}");
			Console.WriteLine();

			obj.Capacity = 10;
			Console.WriteLine($"{obj.Capacity}");
			Console.WriteLine();


			Console.WriteLine($"obj[0] : {obj[0]}");
			Console.WriteLine();

			obj[0] = "Moe";
			obj.PrintAll();

		}
	}
}
