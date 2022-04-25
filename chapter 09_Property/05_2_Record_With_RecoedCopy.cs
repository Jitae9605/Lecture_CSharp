using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_With_RecoedCopy
{
    // record형을 복사하려면 with을 사용해야한다.

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
            RTransaction tr2 = tr1 with {To = "Charlie"};                 // tr1을 복사한다음 tr2로 명명하고 To만 Charlie로 바꿈
            RTransaction tr3 = tr2 with { From = "Dave" , Amount = 30 };  // tr2를 복사한다음 tr3로 명명하고 Form을 Dave로, Amount를 30으로 바꿈


            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);

        }
    }
}
