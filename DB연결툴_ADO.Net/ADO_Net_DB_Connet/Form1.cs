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
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
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

		private void PrintTable()
		{
			string Rec; 
			SqlCommand Com = new SqlCommand("SELECT * FROM tblPeople;" + "SELECT * FROM tblSale", Con);
			SqlDataReader R;
			R = Com.ExecuteReader();

			listBox2.Items.Clear();
			while (R.Read()) 
			{
				Rec = string.Format("이름 : {0}, 나이 : {1}, 성별 : {2}",
					R["Name"], R["Age"], (bool)R[2] ? "남자" : "여자");
				listBox2.Items.Add(Rec); 
			}

			R.NextResult(); 
			while (R.Read()) 
			{
				Rec = string.Format("번호 : {0}, 고객 : {1}, 상품 : {2}, 날짜 : {3}",
					R["OrderNo"], R["Customer"], R["Item"], R["ODate"]); 
				listBox2.Items.Add(Rec); 
			}
			R.Close();

		}


		private void btnSelect_Click(object sender, EventArgs e)
		{
			PrintTable();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string Sql = "UPDATE tblPeople SET Age = Age + 1 WHERE Name = '정우성'";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();
			PrintTable();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string Sql = "DELETE tblPeople WHERE Name = '배용준'";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();
			PrintTable();
		}

		private void btnSum_Click(object sender, EventArgs e)
		{
			string Sql = "SELECT SUM(Age) FROM tblPeople";
			SqlCommand Com = new SqlCommand(Sql, Con);
			int Sum = (int)Com.ExecuteScalar();				// sql의 집계합수 실행후 그 결과를 가져올때 사용
			MessageBox.Show("나이의 총 합은 " + Sum + "입니다.");
		}

		private void btnInsert1_Click(object sender, EventArgs e)
		{
			string Sql = string.Format("INSERT INTO tblPeople VALUES ('{0}',{1},{2})",
				textName.Text, textAge.Text, checkMale.Checked ? 1 : 0);
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();
			PrintTable();
		}

		private void btnInsert2_Click(object sender, EventArgs e)
		{
			string Sql = "INSERT INTO tblPeople VALUES (@Name,@Age,@Male)";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.Parameters.Add("@Name", SqlDbType.NVarChar, 10);
			Com.Parameters.Add("@Age", SqlDbType.Int);
			Com.Parameters.Add("@Male", SqlDbType.Bit);
			Com.Parameters["@Name"].Value = textName.Text;
			Com.Parameters["@Age"].Value = textAge.Text;
			Com.Parameters["@Male"].Value = checkMale.Checked ? 1 : 0;
			Com.ExecuteNonQuery();
			PrintTable();
		}
	}
}
