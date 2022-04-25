using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Equals
{
    // 클래스로 선언된것을 비교할때와 달리
    // 레코드 객체를 비교할때는 Equals()를 사용하면 오버라이딩이 필요없다. 

    class CTransaction                     // class 선언
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }


        // Equals() 함수 오버라이딩
        /*
        public override bool Equals(object obj)
        {
            CTransaction target = (CTransaction)obj;

            if (this.From == target.From && this.To == target.To && this.Amount == target.Amount)
                return true;
            else
                return false;
        }
        */

    }

    record RTransaction                     // record 선언
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // 클래스 복사
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}");    // Equals 함수로 확인
            // 클래스의 Equals의 기능은 내용이 아니라 참조를 비교하는것으로
            // 이를 내용 비교하고 싶으면 오버라이딩을 해줘야한다.(클래스 선언부의 주석처리된 오버라이딩 참고)

            // 레코드 복사
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}");    // Equals 함수로 확인
        }
    }
}
