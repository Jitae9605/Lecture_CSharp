using System;
using System.IO;

namespace Create_File_And_Directory
{
	class MainApp
	{
		static void OnWrongPathType(string type)
		{
			Console.WriteLine($"{type} is wrong type");
			return;
		}

		static void Main(string[] args)
		{

			if(args.Length == 0)
			{
				Console.WriteLine("Usage : Lecture_CSharp.exe <Path> [Type:File/Directory]");	
				// path는 '생성위치경로\파일이름.확장자' 또는 '파일이름.확장자' 이다.
				// ex) Lecture_CSharp a.dat File		= Lecture_CSharp.exe가 있는 폴더에 a.dat 생성
				// ex) Lecture_CSharp a.dat				= 위와 같음
				// ex) Lecture_CSharp a Directory		= Lecture_CSharp.exe가 있는 폴더에 a 폴더(디렉토리) 생성
				// ex) Lecture_CSharp D:\lecture\Jitae9605\temp\a.dat File	= D:\lecture\Jitae9605\temp 경로에 a.dat생성
				return;
			}

			string path = args[0];
			string type = "File";
			if (args.Length > 1)
				type = args[1];

			if (File.Exists(path) || Directory.Exists(path))
			{
				if (type == "File")
					File.SetLastWriteTime(path, DateTime.Now);

				else if (type == "Directory")
					Directory.SetLastWriteTime(path, DateTime.Now);

				else
				{
					OnWrongPathType(path);
					return;
				}

				Console.WriteLine($"Update {path} {type}");
			}

			else
			{
				if (type == "File")
					File.Create(path).Close();
				else if (type == "Directory")
					Directory.CreateDirectory(path);
				else
				{
					OnWrongPathType(path);
					return;
				}

				Console.WriteLine($"Created {path} {type}");
			}
		}
	}
}
