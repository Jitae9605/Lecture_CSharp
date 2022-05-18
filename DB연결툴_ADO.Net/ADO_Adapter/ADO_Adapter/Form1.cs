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

namespace ADO_Adapter
{
	public partial class Form1 : Form
	{
		private SqlConnection Con;
		private SqlDataAdapter Adpt;
		DataTable tblPeople;
		DataSet DbADOTest;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security=true";
			Adpt = new SqlDataAdapter("SELECT * FROM tblPeople", Con);
			DbADOTest = new DataSet("ADOTest");
			Adpt.Fill(DbADOTest, "tblPeople");
			dataGridView1.DataSource = DbADOTest.Tables["tblPeople"];
			//Con.Open() 불필요
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			
			// adapter 선언
			Adpt = new SqlDataAdapter("SELECT * FROM tblPeople", Con);
			tblPeople = new DataTable("tblPeople");


			//*
			SqlCommand cmd;
			// 어뎁터로 가져온 테이블의 수정사항중 insert 사항을 저장
			cmd = new SqlCommand("INSERT INTO tblPeople VALUES (@Name, @Age, @Male)",Con);
			cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 10, "Name");
            cmd.Parameters.Add("@Age", SqlDbType.Int, 0, "Age");
            cmd.Parameters.Add("@Male", SqlDbType.Bit, 0, "Male");
            Adpt.InsertCommand = cmd;   // 여기

			// 어뎁터로 가져온 테이블의 수정사항중 Update 사항을 저장
			cmd = new SqlCommand("UPDATE tblPeople SET Name=@Name,Age=@Age," + "Male=@Male WHERE Name = @OldName", Con);
			cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 10, "Name");
            cmd.Parameters.Add("@Age", SqlDbType.Int, 0, "Age");
            cmd.Parameters.Add("@Male", SqlDbType.Bit, 0, "Male");
            cmd.Parameters.Add("@OldName", SqlDbType.NVarChar, 10, "Name");
            cmd.Parameters["@OldName"].SourceVersion = DataRowVersion.Original;
            Adpt.UpdateCommand = cmd;   // 여기

			// 어뎁터로 가져온 테이블의 수정사항중 Delete 사항을 저장
			cmd = new SqlCommand("DELETE FROM tblPeople WHERE Name = @Name", Con);
			cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 10, "Name");
            Adpt.DeleteCommand = cmd;	// 여기
            //*/

            //*
            //SqlCommandBuilder Builder = new SqlCommandBuilder(Adpt);
            //*

			// Adapt를 수정된 tblPeople로 다시 갱신한다.
            Adpt.Fill(tblPeople);
			
			// 화면상 데이터그리드와 tblPeople을 연결
			dataGridView1.DataSource = tblPeople;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// 어뎁터의 내용을 데이터베이스에 업데이트
			Adpt.Update(tblPeople);
		}

		private void btnGetChanges_Click(object sender, EventArgs e)
		{
			if (DbADOTest.HasChanges() == true)
			{
				DataSet Change = DbADOTest.GetChanges();
				DataTable tblPeople = Change.Tables["tblPeople"];
				string Record = "";
				listBox1.Items.Clear();
				foreach (DataRow R in tblPeople.Rows)
				{
					switch (R.RowState)
					{
						case DataRowState.Added:
							Record = string.Format("추가 : {0}", R["Name"]);
							break;
						case DataRowState.Deleted:
							Record = string.Format("삭제 : {0}", R["Name", DataRowVersion.Original]);
							break;
						case DataRowState.Modified:
							Record = string.Format("수정 : {0} -> {1}", R["Name", DataRowVersion.Original], R["Name"]);
							break;
					}
					listBox1.Items.Add(Record);
				}
			}
		}
	}
}
