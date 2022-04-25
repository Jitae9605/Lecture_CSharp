using System;


namespace Record_Make_and_Init
{
    // record를 통해 불변객체에서의 복사/참조를 높은 효율로 가능하게 하자
    // 불변객체를 통한 복사와 비교는 많이 사용되지만 이를 복사할때는 깊은복사등이 필요하고 그에따라 불필요한 코드의 추가삽입/반복/노동이 필요
    // 이를 개선한것이 record형으로 record형은 처음 생성되고 나면 불변객체로서 작동을 하면서 복사는 자동으로 깊은복사가 이루어진다.
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
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Charlie", Amount = 100 };
            

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);

        }
    }
}