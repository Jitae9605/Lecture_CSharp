using System;
using System.IO;
using System.Threading.Tasks;

namespace async_And_await_API
{
	// .NET 이 제공하는 비동기 API를 이용한 파일복사
	class MainApp
	{
		// 파일복사후 복사한 파일 용량을 반환하는 함수
		static async Task<long> CopyAsync(string FromPath, string ToPath)
		{
			// 복사대상을 읽어서 버퍼에 저장하는 스트림
			using (var fromStream = new FileStream(FromPath, FileMode.Open))
			{
				long totalcopied = 0;

				// 버퍼에 저장된 내용을 불러와 파일을 생성하는 스트림
				using( var toStream = new FileStream(ToPath, FileMode.Create))
				{
					byte[] buffer = new byte[1024];
					int nRead = 0;

					// fromStream.ReadAsync로 파일을 읽어 buffer에 저장
					while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
					{
						// toStream.WriteAsync를 이용해 buffer에 저장된 데이터를 새로운 파일에 작성
						await toStream.WriteAsync(buffer, 0, nRead);
						totalcopied += nRead;	// 한 세트 끝날때마다의 용량을 누적합산
					}
				}

				return totalcopied;
			}
		}
		
		static async void DoCopy(string FromPath, string ToPath)
		{
			long totalCopied = await CopyAsync(FromPath, ToPath);
			Console.WriteLine($"Copied Total {totalCopied} Bytes");
		}
			
		
		static void Main(string[] args)
		{
			if(args.Length < 2)
			{
				Console.WriteLine("Usage : AsyncFileIO <Source> <Destination>");
				return;
			}

			DoCopy(args[0], args[1]);

			Console.ReadLine();
		}
	}
}
