using System;


namespace Slice_the_Array
{
    // 분할 배열
    class MainApp
    {
        static void PrintArray(Array array)
        {
            foreach (var e in array)
                Console.Write(e);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1]; // Z = 90, A = 65 ==> Z - A + 1 = 26
            for (int i = 0; i < array.Length; i++)  // array에 A ~ Z 까지 입력
                array[i] = (char)('A' + i);

            PrintArray(array[..]);              // 0번째 ~ 마지막까지 ( 0 ~ 25 )
            PrintArray(array[5..]);             // 5번째 ~ 마지막까지 ( 4 ~ 25 )

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]);      // 5번째 ~ 9(= 10 - 1)번째까지 ( 5 ~ 9 )

            Index last = ^0;                    // 뒤에서(^) 0번째 = 마지막  
            Range range_5_last = 5..last;       
            PrintArray(array[range_5_last]);    // 5번째 ~ 뒤에서 0번째 = 5번째 ~ 마지막까지 ( 5 ~ 25 )

            PrintArray(array[^4..^1]);          // 뒤에서 4번째 ~ 뒤에서 2번째까지 ( 21(= 25-4) ~ 23(= 25-2) )


        }
    }


}
