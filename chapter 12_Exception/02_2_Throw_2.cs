using System;


namespace Throw_2
{
	class MainApp
	{
		static void Main(string[] args)
		{
			try
			{
				int? a = null;                                  // ( int? == Nullable<int> = null을 가질수있는 int형 변수) 
				int b = a ?? throw new ArgumentNullException();	// a 가 null 이면 오른쪽값을 아니면 a를 
			}
			catch (ArgumentNullException e)
			{
				Console.WriteLine(e);
			}


			try
			{
				int[] array = new[] { 1, 2, 3 };
				int index = 4;
				int value = array[ index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException() ];
				// a > b ? a : b 의 조건식임
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine(e);
			}
		}

	}
}
