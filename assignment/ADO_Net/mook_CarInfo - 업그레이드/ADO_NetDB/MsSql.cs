using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDB
{
	public class MsSql : IDatabase
	{


		public string ConnectionString { get; set; }
		public IDbConnection Connection { get; set; }

		// MsSql Class의 생성자
		public MsSql(string connection_string)
		{
			// 데이터베이스 접속 문자열
			ConnectionString = connection_string;

			// 접속문자열 을 사용하여 테이터베이스 접속 커넥션을 형성 => SqlConnection
			Connection = new SqlConnection(ConnectionString);
		}

	}
}
