using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDB
{
	public interface IDatabase
	{
		string ConnectionString { get; set; }

		// 여러가지 DB(Oracle, MsSql, MySql) 등을 묶어주는 역할을 함. 공통적인 정보를 가져와 쓸 수 있음.
		IDbConnection Connection { get; set; }
	}
}
