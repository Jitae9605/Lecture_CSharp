using System;
using System.IO;
using FS = System.IO.FileStream;	// using을 통한 별명지정

namespace Skip_Close_By_Using
{
	// using을 통해 파일을 열면 코드블록이 끝날때 자동으로 Dispos()를 호툴하는데 이게 Close()의 역할됨.
	// 이러한 특성을 이용해서 자원의 수명을 세부적으로 조정하고 싶을때 유용
	// 또한, using은 맨앞에서 생략할뿐 아니라 별명을 지정할수도 있따.

	// 02_1_FileStream.cs 에서 응용을 하고 둘을 비교해보자
	class MainApp
	{ 
		static void Main(string[] args)
		{
			long someValue = 0x123456789ABCDEF0;
			Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

			using (Stream outStream = new FS("a.dat", FileMode.Create))		// 별명사용(FS)
			{
				byte[] wBytes = BitConverter.GetBytes(someValue);           

				Console.Write("{0,-13} : ", "Byte array");

				foreach (byte b in wBytes)
					Console.Write("{0:X2} ", b);    
				Console.WriteLine();

				outStream.Write(wBytes, 0, wBytes.Length);
			}   // 여기서 자동으로 outStream.Dispose() 실행

			using Stream inStream = new FS("a.dat", FileMode.Open);         // 별명사용(FS)
			byte[] rbytes = new byte[8];

			int i = 0;
			while (inStream.Position < inStream.Length)
				rbytes[i++] = (byte)inStream.ReadByte();

			long readValue = BitConverter.ToInt64(rbytes, 0);

			Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
			inStream.Close();
		}   // 여기서 자동으로 inStream.Dispose() 실행
	}
}
