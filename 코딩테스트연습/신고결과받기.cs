using System;
using System.Linq;

namespace a
{


	public class Solution
	{
		public int[] solution(string[] id_list, string[] report, int k)
		{

			// 중복 신고 제거
			string[] reportList = report.Distinct().ToArray();

			// 신고자
			string[] reporter = new string[10];

			// 피신고자
			string target = "0" ;

			// 회원별 신고 누적수
			int[] reportNum = new int[10];

			// 신고기록
			for (int i = 0; i < report.Length; i++)
			{
				string[] temp = reportList[i].Split(' ');
				reporter[i] = temp[0];
				target = temp[1];

				for (int j = 0; j < id_list.Length; j++)
				{
					if (id_list[j] == target)
					{
						reportNum[j]++;						// 신고당한횟수
					}

				}
			}
			return reportNum;
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();
			int[] sol = solution.solution(new string[] { "muzi", "frodo", "apeach", "neo" }, new string[] {"muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi"}, 2);
			foreach (int reports in sol)
				Console.WriteLine(reports);
		}
	}
}
