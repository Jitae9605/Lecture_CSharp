using System;
using System.Collections;

namespace Indexer
{
    // 인덱서의 생성
    // 객체를 배열처럼 사용하게 해준다.
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]  // 인덱서 선언
        {
            get // 인덱스번호에 해당하는 값을 반환
            {
                return array[index];
            }

            set // 배열에 값을 삽입
            {
                if (index >= array.Length)  // 값의 수가 배열크기를 벗어날경우 (인덱스번호 > 배열크기)
                {
                    Array.Resize<int>(ref array, index + 1);            // Resize를 통해 배열 크기 조정
                    Console.WriteLine($"Array Resize : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // 인덱스를 통해 값 삽입 ( 배열과 같음 )
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            // 인덱스를 통해 값 얻어옴
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
