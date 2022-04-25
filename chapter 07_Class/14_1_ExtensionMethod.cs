using System;
using MyExtension;

namespace MyExtension
{
    // 확장메소드
    // 메소드를 확장해서 쓸수 있다.
    // 첫번째 매개변수도 'this 매개변수자료형 매개변수명'을 적고 쉼표(,)이후의 다음 매개변수 부터가 메소드의 실제 매개변수임을 기억

    public static class IntegerExtension
    {
        public static int Square(this int Myint)
        {
            return Myint * Myint;
        }

        public static int Power(this int myint, int exponent)
        {
            int result = myint;
            for (int i = 1; i < exponent; i++)
                result = result * myint;
            return result;
        }
    }
}

namespace ExceptionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}
