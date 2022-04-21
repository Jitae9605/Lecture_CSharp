using System;

namespace Method_And_Properties_From_ArrayClass
// 배열은 System.Array클래스소속으로 이곳에는 다양한 기능의 메소드와 프로퍼티등이 이미 정의되어있다

// 정적메소드            : Array.메소드명<>() or Array.메소드명()
// 인스턴스 메소드        : 배열명.메소드명()
// 프로퍼티              : 배열명.프로퍼티명
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.Write($"  {value}");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"  {score}");
            Console.WriteLine();


            // Sort(배열명) : 배열정렬
            Console.WriteLine(" [Sort(배열명) : 배열정렬]");   
            Array.Sort(scores);     // scores = {34, 74, 80, 81, 90}
            Console.WriteLine();

            // ForEach<T>(배열명, 수행할 작업) : 모든 배열요소에 대해 같은 작업을 수행하게 함
            Console.WriteLine(" [ForEach<T>(배열명, 수행할 작업) : 모든 배열요소에 대해 같은 작업을 수행하게 함]");
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
            Console.WriteLine();

            // 배열명.Rank : 배열의 차원을 반환
            Console.WriteLine(" [배열명.Rank : 배열의 차원을 반환]");
            Console.WriteLine($"  Number of dimensions : {scores.Rank}");
            Console.WriteLine();


            // BinarySearch<T>(배열명, 찾는 값) : 이진탐색기법으로 특정 값이 어디에 있는지 찾아서 해당 요소번호를 반환함
            Console.WriteLine(" [BinarySearch<T>(배열명, 찾는 값) : 이진탐색기법으로 특정 값이 어디에 있는지 찾아서 해당 요소번호를 반환함]");
            Console.WriteLine($"  Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");
            Console.WriteLine();


            // IndexOf() : 선형검색기법으로 특정 값이 어디에 있는지 찾아서 해당 요소번호를 반환함
            Console.WriteLine(" [IndexOf() : 선형검색기법으로 특정 값이 어디에 있는지 찾아서 해당 요소번호를 반환함]");
            Console.WriteLine($"  Linear Search : 90 is at " + $"{Array.IndexOf(scores, 90)}");
            Console.WriteLine();


            // TrueForAll<T>(배열명, 조건) : 모든 배열요소들이 조건을 만족하는지 검사후 모두 참이면 True, 아니면 False
            Console.WriteLine(" [TrueForAll<T>(배열명, 조건) : 모든 배열요소들이 조건을 만족하는지 검사후 모두 참이면 True, 아니면 False]");
            Console.WriteLine($"  Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            Console.WriteLine();


            // FindIndex<T>(배열명, 조건) : 조건을 만족하는 첫 요소의 요소번호(인덱스)를 반환
            Console.WriteLine(" [FindIndex<T>(배열명, 조건) : 조건을 만족하는 첫 요소의 요소번호(인덱스)를 반환]");
            int index = Array.FindIndex<int>(scores, (score => score < 60));    // 람다식 아직 안배웠음

            scores[index] = 61;
            Console.WriteLine($"  Everyone passed ? :" + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            Console.WriteLine();


            // GetLength(차원) : 배열에서 지정한 차원의 배열길이를 반환함.
            Console.WriteLine(" [GetLength(차원) : 배열에서 지정한 차원의 배열길이를 반환함.]");
            Console.WriteLine("  Old length of score : " + $"{scores.GetLength(0)}");
            Console.WriteLine();


            // Resize<T>(ref 배열명, 배열크기) : 배열의 크기를 재조정
            Console.WriteLine(" [Resize<T>(ref 배열명, 배열크기) : 배열의 크기를 재조정]");
            Array.Resize<int>(ref scores, 10); // (배열크기 :5 -> 10)
            Console.WriteLine($"  New length of scores : {scores.Length}");
            Console.WriteLine();


            // 크기를 10으로 늘렸으니 배열이 늘어났는지 확인 겸 배열출력
            Console.WriteLine(" 크기를 10으로 늘렸으니 배열이 늘어났는지 확인 겸 배열출력");
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
            Console.WriteLine();

            // Clear(배열명, 시작 배열요소번호, 마지막 배열요소번호) : 배열의 지정한 번호 사이의 요소들을 모두 초기화(숫자:0, 논리:false, 참조:null)
            Console.WriteLine(" [Clear(배열명, 시작 배열요소번호, 마지막 배열요소번호) : 배열의 지정한 번호 사이의 요소들을 모두 초기화(숫자:0, 논리:false, 참조:null)]");
            Array.Clear(scores, 3, 7);  // score[3] ~ score[7] 은 모두 0으로 초기화됨
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();


            // Copy(배열명1, 시작번호1, 배열명2, 시작번호2, 복사할 요소수) : 배열명1의 시작번호1 값을 지정한 갯수(복사할 요소수)만큼 복사해 배열명2의 시작번호2 부터 붙여넣음 
            Console.WriteLine(" [Copy(배열명1, 시작번호1, 배열명2, 시작번호2, 복사할 요소수) : 배열명1의 시작번호1 값을 지정한 갯수(복사할 요소수)만큼 복사해 배열명2의 시작번호2 부터 붙여넣음]");
            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();

        }
    }
}
