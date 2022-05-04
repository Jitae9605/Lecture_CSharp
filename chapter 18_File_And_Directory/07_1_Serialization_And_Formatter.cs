using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_And_Formatter
{
	// 직렬화를 이용한 파일 읽고 쓰기
	[Serializable]		// 직렬화
	class NameCard
	{
		public string Name;
		public string Phone;
		public int Age;
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			// 파일생성 및 쓰기
			using(Stream ws = new FileStream("a.dat", FileMode.Create))
			{
				BinaryFormatter serializer = new BinaryFormatter();

				NameCard nc = new NameCard();
				nc.Name = "박상현";
				nc.Phone = "010-123-4567";
				nc.Age = 33;

				serializer.Serialize(ws, nc);
			}

			// 파일읽기
			using Stream rs = new FileStream("a.dat", FileMode.Open);
			BinaryFormatter deserializer = new BinaryFormatter();

			NameCard nc2;
			nc2 = (NameCard)deserializer.Deserialize(rs);

			Console.WriteLine($"Name : {nc2.Name}");
			Console.WriteLine($"Phone : {nc2.Phone}");
			Console.WriteLine($"Age : {nc2.Age}");
		}
	}
}
