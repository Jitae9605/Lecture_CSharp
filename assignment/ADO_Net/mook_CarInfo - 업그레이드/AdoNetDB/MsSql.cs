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
			ConnectionString = connection_string;

			//Connection 할 때 ConnectionString을 사용함.
			Connection = new SqlConnection(ConnectionString);
		}

	}
}
