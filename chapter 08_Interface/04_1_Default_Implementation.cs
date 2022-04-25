using System;

namespace Default_Implementation
    // 기본구현메소드
{
    interface ILogger
    {
        void WriteLog(string message);

        void WriteError(string error)
        {
            WriteLog($"Error: {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");


            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");          // OK
            // clogger.WriteError("System Fail");   // 컴파일 에러 : ConsoleLogger에 오보라이딩 안했으므로
        }
    }
}
