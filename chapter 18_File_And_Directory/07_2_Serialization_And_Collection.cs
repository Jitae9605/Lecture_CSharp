using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization_And_Collection
{
	// 콜렉션의 직렬화
	// 콜렉션도 직렬화가 가능하고 그에따라 당연히 파일 입출력도 가능
	[Serializable]
	class NameCard
	{
		public string Name;
		public string Phone;
		public int Age;

		public NameCard(string Name, string Phone, int Age)
		{
			this.Name = Name;
			this.Phone = Phone;
			this.Age = Age;
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			// 콜렉션 직렬화 및 파일 생성/쓰기
			using (Stream ws = new FileStream("a.dat", FileMode.Create))
			{
				BinaryFormatter serializer = new BinaryFormatter();

				List<NameCard> list = new List<NameCard>();
				list.Add(new NameCard("박상현", "010-123-4567", 33));
				list.Add(new NameCard("김연아", "010-323-1111", 22));
				list.Add(new NameCard("장미란", "010-555-5555", 26));

				serializer.Serialize(ws, list);
			}

			using Stream rs = new FileStream("a.dat", FileMode.Open);
			BinaryFormatter deserializer = new BinaryFormatter();

			List<NameCard> list2;
			list2 = (List<NameCard>)deserializer.Deserialize(rs);

			foreach(NameCard nc in list2)
			{
				Console.WriteLine($"Name: {nc.Name}, Phone: {nc.Phone}, Age: {nc.Age}");
			}
		}
	}
}
