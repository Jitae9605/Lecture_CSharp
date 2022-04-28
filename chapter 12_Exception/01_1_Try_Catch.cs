using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
	// try_catch문을 통한 예외처리 방법과 이유
	class MainApp
	{
		static void	Main(string[] args)
		{
			int[] arr = { 1, 2, 3 };

			try
			{
				for (int i = 0; i < 5; i++)
					Console.WriteLine(arr[i]);	// arr[3]은 없으므로 예외발생 -> try내에서 발생된예외이므로 catch로 간다.
			}

			catch (IndexOutOfRangeException e)  // 자동으로 'IndexOutOfRangeException e'에 try에서 발생된 예외가 들어감
 			{
				Console.WriteLine($"예외가 발생함 : {e.Message}");
			}

			// 이게 try - catch를 쓰는 이유
			// 예외처리가 없으면 예외발생시 그자리에서 프로그램이 종료되고 이는 신뢰성이 없으며 데이터손상을 야기함.
			Console.WriteLine("정상 종료");
		}
	}
}
