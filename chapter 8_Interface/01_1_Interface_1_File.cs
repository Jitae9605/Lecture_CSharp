using System;
using System.IO;

namespace Interface_1_File
{
    // 인터페이스의 정의와 사용_1 : 파일입출력
    interface ILogger                       // 인터페이스 선언
    {
        void WriteLog(string message);      
    }

    class ConsoleLoger : ILogger                // 콘솔 인터페이스조종 클래스
    {
        public void WriteLog(string message)    // 콘솔 인터페이스의 메소드 구현
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);  // {0} {1} = 출력된 배치모양
                                                                                // 즉, 출력형태가 'DateTime.Now.ToLocalTime() message'
        }
    }

    class FileLogger : ILogger                  // 파일 인터페이스조종 클래스
    {                                           // 파일출력은 파일을 생성하고 콘솔에 입력된 값을 읽어서 파일로 출력하는것이 필요

        private StreamWriter writer;            // 파일에 텍스트를 출력해주는 클래스

        public FileLogger(string path)          // 출력될 파일의 경로를 매개변수로 받음
        {
            writer = File.CreateText(path);     // 파일생성
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)    // 파일에 입력값을 출력(인터페이스에 맞게
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor                        
    {
        private ILogger logger;                 // 인터페이스 종류 저장
        public ClimateMonitor(ILogger logger)   // 클래스 생성자. 매개변수어 어떤 인터페이스를 사용할지 받음
        {
            this.logger = logger;
        }

        public void start()                     
        {
            while(true)
            {
                Console.Write("온도를 입력해주세여 : ");
                string temperature = Console.ReadLine();
                if (temperature == "")                           // 아무 입력값 없이 ENTER를 치면 종료
                    break;

                logger.WriteLog("현재 온도 : " + temperature);    // "현재 온도 : " + temperature == message
            }
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));   
            // 경로없이 '파일이름.확장자'만 입력하면 '~(현재 솔루션의 경로)~\bin\Debug\net5.0'폴더 내부에 생성

            monitor.start();
        }
    }

}
