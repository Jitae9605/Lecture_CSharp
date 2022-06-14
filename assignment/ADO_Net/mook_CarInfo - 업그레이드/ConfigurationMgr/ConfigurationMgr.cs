using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AppConfigurationMgr
{
	public class ConfigurationMgr
	{
		private static ConfigurationMgr instance;


		public string ConnectionString { get; set; }

		IDbConnection connetion;

		public ConfigurationMgr()
		{
			if (LicenseManager.UsageMode ==
				LicenseUsageMode.Runtime)
			{
				
			}

			// App.config 파일을 읽어서 로딩
			LoadConfiguration();


			// connection 생성
			MakeConnetion();
		}

		private void LoadConfiguration()
		{
			// App.config의 내용을 전부 가져와서 config에 저장하는 문장
			Configuration config =
				ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			ConnectionString = 
				config.ConnectionStrings.ConnectionStrings["WinConnection"].ConnectionString;
		}

		public IDbConnection Connection
		{
			get
			{
				if (connetion == null)
					connetion = new SqlConnection(ConnectionString);	// 간단하게 만든 싱글톤 패턴

				// SqlConnetion 생성과 동시에 connetion open 처리를 추가해도 됨
				// connectio.open()
				return connetion;
			}
			private set { }
		}

		private void MakeConnetion()
		{
			Connection = new SqlConnection(ConnectionString);
		}

		public static ConfigurationMgr Instace()
		{
			if (instance == null)
				instance = new ConfigurationMgr();	// ConfigurationMgr 의 싱글톤
			return instance;
		}
	}

}
