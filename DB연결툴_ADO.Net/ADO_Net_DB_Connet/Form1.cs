using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_Net_DB_Connet
{
	public partial class Form1 : Form
	{
		private SqlConnection Con;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true";
			Con.StateChange += new StateChangeEventHandler(Con_StateChange);	// state 퍼포퍼티값이 바뀔때 마다(=연결상태바뀔때마다) 전달
			Con.InfoMessage += new SqlInfoMessageEventHandler(Con_InfoMessage);	// sql서버로부터 경고, 정보메세지 리턴될때 발생		

		}

		void Con_InfoMessage(object sender, SqlInfoMessageEventArgs e)			// 이벤트발생사실을 리스트박스에 출력
		{
			listBox1.Items.Add(e.Message);			
		}

		void Con_StateChange(object sender, StateChangeEventArgs e)				// 연결상태의 변화를(이전과 현재) 리스트박스에 출력
		{
			string Mes;
			Mes = string.Format("원래 상태 : {0}, 현재 상태 : {1}", e.OriginalState, e.CurrentState);
			listBox1.Items.Add(Mes);
		}

		private void btnConnect_Click(object sender, EventArgs e)				// 연결버튼누르면 연결됨
		{
			try
			{
				Con.Open();     // SqlConnection을 연다
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if(Con.State == ConnectionState.Open)
			{
				Con.Close();        // SqlConnection을 닫는다
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) // 폼이 닫히면 
		{
			if (Con.State == ConnectionState.Open)
			{
				Con.Close(); // SqlConnection을 끝는다.
			}
		}
	}
}
