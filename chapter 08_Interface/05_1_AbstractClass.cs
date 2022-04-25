using System;

namespace AbstractClass
{
    // 추상클래스와 추상메소드
    // 클래스와 인터페이스의 역할을 모두 수행가능
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA(); // 추상메소드
    }

    class Derived :AbstractBase     // 추상클래스 상속받음
    {
        public override void AbstractMethodA()  // 추상메소드에 오버라이드 실행
        {
            Console.WriteLine("Derrived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();   // AbstractBase형의 obj를 만드는데 Derived 생성자사용 == Derived의 함수등을 사용가능
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
