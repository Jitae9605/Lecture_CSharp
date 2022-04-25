using System;

namespace PartialClass
{
    // 분할클래스
    // 클래스가 길어지거나 다른곳에서 필요한경우, 파일을 나눠야하는 경우에 클래스 자체를 분할정의할수 있다.
    partial class Myclass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    partial class Myclass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    class MainApp
    {
        static void Main(String[] args)
        {
            Myclass obj = new Myclass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
        }
    }
}
