using System;
using System.Linq;
using System.IO;

namespace Print_File_And_Directory_Info
{
	// cmd창으로 '파일이름.exe'와 함께 호출하면서 "경로"를 입력해서 해당경로의 파일 및 디렉토리 목록을 조회
	class MainApp
	{
		static void Main(string[] args)
		{
			string directory;
			if (args.Length < 1)
				directory = ".";
			else
				directory = args[0];

			Console.WriteLine($"{directory} directory Info");
			Console.WriteLine("- Directories :");
			var directories = (from dir in Directory.GetDirectories(directory)  // GetDirectories = 하위 디렉토리 목록조회
							   let info = new DirectoryInfo(dir)
							   select new
							   {
								   Name = info.Name,
								   Attributes = info.Attributes
							   }).ToList();

			foreach (var d in directories)
				Console.WriteLine($"{d.Name} : {d.Attributes}");

			Console.WriteLine(" - Files :");
			var files = (from file in Directory.GetFiles(directory)             // GetFiles = 하위 파일 목록조회
						 let info = new FileInfo(file)							// let은 LINQ안에 변수를 만든다 (== LINQ판 var과 같다)
						 select new
						 {
							 Name = info.Name,
							 FileSize = info.Length,
							 Attribute = info.Attributes
						 }).ToList();

			foreach (var f in files)
				Console.WriteLine($"{f.Name} : {f.FileSize}, {f.Attribute}");
		}
	}
}
