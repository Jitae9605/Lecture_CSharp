using System;

// 익명메소드
// delegate 키워드를 이용해 선언
namespace Anonymous_Method
{
	// 대리자 생성
	delegate int Compare(int a, int b);
	
	class MainApp
	{
		static void BubbleSort(int[] DataSet, Compare Comparer)	// 매개변수 입력 안해도된다(필요하면 당연히 해야됨)
		{
			int i = 0;
			int j = 0;
			int temp = 0;

			for (i = 0; i < DataSet.Length - 1; i++) 
			{
				for (j = 0; j < DataSet.Length - (i + 1); j++)
				{
					if(Comparer(DataSet[j], DataSet[j+1]) > 0)	// 매개변수가 호출때가아니라 작동중간에 삽입됨
					{
						temp = DataSet[j + 1];
						DataSet[j + 1] = DataSet[j];
						DataSet[j] = temp;
					}
				}
			}
		}

		static void Main(string[] args)
		{
			int[] array = { 3, 7, 4, 2, 10 };

			
			Console.WriteLine("Sorting ascending...");
			BubbleSort(array, delegate (int a, int b)			// delegate(int a, int b) == 익명메소드
			{
				// 익명 메소드의 정의(내용)
				// 오름차순 정렬
				if (a > b)
					return 1;

				else if (a == b)
					return 0;

				else
					return -1;
			});	// bubblesort가 여기까지 묶임

			for (int i = 0; i < array.Length; i++)
				Console.Write($"{array[i]} ");

			// 내림차순 정렬
			int[] array2 = { 7, 2, 8, 10, 11 };
			Console.WriteLine("\nSorting descending...");
			BubbleSort(array2, delegate (int a, int b)			// delegate(int a, int b) == 익명메소드
			{
				// 익명 메소드의 정의(내용)
				// 내림차순 정렬
				if (a < b)
					return 1;

				else if (a == b)
					return 0;

				else
					return -1;
			}); // bubblesort가 여기까지 묶임

			for (int i = 0; i < array2.Length; i++)
				Console.Write($"{array2[i]} ");

			Console.WriteLine();

		}
	}
}
