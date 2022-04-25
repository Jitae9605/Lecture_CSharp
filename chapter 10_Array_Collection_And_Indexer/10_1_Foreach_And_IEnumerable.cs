using System;
using System.Collections;

namespace Foreach_And_IEnumerable
{
    // foreach는 IEnumerable인터페이스를 상속하는 형식만을 지원한다.
    // 솔직히 별 필요없어보인다. 넘어감
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;                    // GetEnumerator() 메소드 종료시킴
            yield return numbers[3];        // 즉, 얘는 실행X
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);
        }
    }
}
