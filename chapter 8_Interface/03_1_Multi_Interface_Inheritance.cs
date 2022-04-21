using System;


namespace Multi_Interface_Inheritance
    //  인터페이스 다중 상속
    // C#은 다중 상속을 허락하지 않지만, 인터페이스는 허락한다.
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            // 다중상속이므로 형변환이 양쪽으로 가능
            IRunnable runnable = car as IRunnable;  
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
