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
			string[] reporter = null;

			// 피신고자
			string target = null;

			// 회원별 신고 누적수
			int[] reportNum = { 0, };

			// 신고기록
			for (int i = 0; i < report.Length; i++)
			{
				string[] temp = report[i].Split(' ');
				reporter[i] = temp[0];
				target = temp[1];

				for (int j = 0; j < id_list.Length; j++)
				{
					if (id_list[j] == target)
					{
						reportNum[j]++;
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
