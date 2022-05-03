using System;
using System.IO;

namespace FileStream_Make
{
	// 파일에 내용을 입력할때는 Write와 Writebyte를 사용하면 된다.
	// 하지만, 둘다 매개변수(입력값)은 byte형만 지원함
	//		=> byte[] wBytes = BitConverter.GetBytes(값) 을 통해 byte형으로의 컨버트가 필요 
	class MainApp
	{
		static void Main(string[] args)
		{
			long someValue = 0x123456789ABCDEF0;
			Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

			Stream outStream = new FileStream("a.dat", FileMode.Create);
			byte[] wBytes = BitConverter.GetBytes(someValue);           // someValue의 8바이트를 바이트배열에 나눠넣는다.

			Console.Write("{0,-13} : ", "Byte array");

			foreach (byte b in wBytes)
				Console.Write("{0:X2} ", b);	// Write와 Writebyte는 byte형식만 매개변수로 받는다(즉, byte단위로 컨버트해서 입력해야함)
			Console.WriteLine();

			outStream.Write(wBytes, 0, wBytes.Length);					// 파일에 기록
			outStream.Close();

			Stream inStream = new FileStream("a.dat", FileMode.Open);
			byte[] rbytes = new byte[8];

			int i = 0;
			while (inStream.Position < inStream.Length)
				rbytes[i++] = (byte)inStream.ReadByte();

			long readValue = BitConverter.ToInt64(rbytes, 0);

			Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
			inStream.Close();
		}
	}
}
