using System;
using System.IO;


namespace Filestream_Position
{
	// Position == 현재 스트림의 읽는 위치 또는 쓰는 위치
	class MainApp
	{
		static void Main(string[] args)
		{
			Stream outstream = new FileStream("a.dat", FileMode.Create);
			Console.WriteLine($"Positio : {outstream.Position}");			// 0

			outstream.WriteByte(0x01);
			Console.WriteLine($"Positio : {outstream.Position}");			// 1

			outstream.WriteByte(0x02);
			Console.WriteLine($"Positio : {outstream.Position}");			// 2

			outstream.WriteByte(0x03);
			Console.WriteLine($"Positio : {outstream.Position}");			// 3

			outstream.Seek(5, SeekOrigin.Current);		// 현재를 기준으로 5번 이동하는 것 (즉, 3 + 5 -> 8)
			Console.WriteLine($"Positio : {outstream.Position}");			// 8

			outstream.WriteByte(0x04);
			Console.WriteLine($"Positio : {outstream.Position}");			// 9

			outstream.Close();

		}
	}
}
