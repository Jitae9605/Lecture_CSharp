using System;


namespace PosisionalPattern
{   // 객체의 분해와 이를 활용한 switch문의 분기로서 이용

    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,   // 학생 & 18세 미만 => 0.2
                ("학생", _) => 0.1,                   // 학생 & 18세 이상 => 0.1
                ("일반", int n) when n < 18 => 0.1,   // 일반 & 18세 미만 => 0.1
                ("일반", _) => 0.05,                  // 일반 & 18세 이상 => 0.05
                _ => 0,                               // else = 0
            };
        }

        static void Main(string[] args)
        {
            var alice   = (job: "학생", age: 17);
            var bob     = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave    = (job: "일반", age: 21);

            Console.WriteLine("< 회원별 할인율 조회 >");
            Console.WriteLine($" alice   : {GetDiscountRate(alice)}%"); 
            Console.WriteLine($" bob     : {GetDiscountRate(bob)}%"); 
            Console.WriteLine($" charlie : {GetDiscountRate(charlie)}%"); 
            Console.WriteLine($" dave    : {GetDiscountRate(dave)}%"); 
        }
    }

}
