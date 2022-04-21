using System;


namespace ReadOnlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius;     // 현재온도(섭씨)
        public double target;               // 희망온도

        public readonly double GetFahrenheit()  // 화씨로 단위환산후 target에 저장
        {
            target = currentInCelsius * 1.8 + 32;           // readonly이므로 당연히 오류발생
            return target;
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
