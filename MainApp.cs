using System;
using static System.Console;

namespace Lecture_CSharp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>"); // <이름>은 매개변수다.
                return;
            }

            WriteLine("Hello, {0}!", args[0]);  // 사용법에서 입력받은 매개변수<이름>이 {0}에 들어가서 출력된다.
        }
    }
}
