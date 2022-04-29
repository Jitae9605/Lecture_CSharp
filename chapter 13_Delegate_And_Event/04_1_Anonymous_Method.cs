using System;

// 대리자 활용
// 대리자를 활용한 정렬 메소드생성
namespace Delegate_Application
{
	// 대리자 생성
	delegate int Compare(int a, int b);
	
	class MainApp
	{
		static int AscendCompare(int a, int b)	// 오름차순
		{
			if (a > b)
				return 1;

			else if (a == b)
				return 0;

			else
				return -1;
		}

		static int DescendCompare(int a, int b)	// 내림차순
		{
			if (a < b)
				return 1;

			else if (a == b)
				return 0;

			else
				return -1;
		}

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

			// 오름차순 정렬
			Console.WriteLine("Sorting ascending...");
			BubbleSort(array, new Compare(AscendCompare));

			for (int i = 0; i < array.Length; i++)
				Console.Write($"{array[i]} ");

			// 내림차순 정렬
			int[] array2 = { 7, 2, 8, 10, 11 };
			Console.WriteLine("\nSorting descending...");
			BubbleSort(array2, new Compare(DescendCompare));

			for (int i = 0; i < array2.Length; i++)
				Console.Write($"{array2[i]} ");

			Console.WriteLine();

		}
	}
}
