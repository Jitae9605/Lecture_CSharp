using System;


namespace DerivedInterface
    // 인터페이스를 상속하는 인터페이스
    // 기존 인터페이스에 새로운 기능을 추가한 인터페이스를 만들수 있다!
    // (이미만들어진 라이브러리 인터페이스/ 어셈블리 내부 인터페이스 등을 이용하는 경우
    //  또는 이미 해당 인터페이스를 다른 클래스들이 사용하고 있을때의 기능추가는 모든 클래스에 해당 내용을 써넣어줘야한다는 점에서 이게 백배이득)
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is niot flat.");
            logger.WriteLog("{0} {1} = {2}", 1, 1, 2);      // == printf("%? %? = %?", a,b,c)
        }
    }

}
