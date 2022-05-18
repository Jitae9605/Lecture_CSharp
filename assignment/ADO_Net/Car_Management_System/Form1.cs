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

namespace Car_Management_System
{
	// listview를 이용해 db로부터 데이터를 가져와 입력/수정/삭제/조건검색 등을 구현해보자
	public partial class Form1 : Form
	{
		private SqlConnection Con;
		public Form1()
		{
			InitializeComponent();
		}

		private void PrintTable()
		{
			listView1.Items.Clear();
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			SqlCommand Com = new SqlCommand("SELECT * FROM TB_CAR_INFO;", Con);
			SqlDataReader R;
			Con.Open();
			R = Com.ExecuteReader();

			while (R.Read())
			{
				string id = (string)R["id"].ToString();
				string carName = (string)R["carName"];
				string carYear = R["carYear"].ToString();
				string carPrice = (string)R["carPrice"].ToString();
				string carDoor = (string)R["carDoor"].ToString();

				string[] strs = new string[] { id, carName, carYear, carPrice, carDoor };
				ListViewItem getItem = new ListViewItem(strs);
				listView1.Items.Add(getItem);
			}
			R.Close();
			Con.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PrintTable();
		}

		private void btnSerchAll_Click(object sender, EventArgs e)
		{
			PrintTable();
		}

		private void listView1_MouseClick(object sender, MouseEventArgs e)	// listview
		{
			if(e.Button.Equals(MouseButtons.Right))
			{
				//선택된 아이템의 Text를 저장해 놓습니다. 중요한 부분.
				ListViewItem selectedNickname = listView1.SelectedItems[0]; 

				//오른쪽 메뉴를 만듭니다
				ContextMenu m = new ContextMenu();

				//메뉴에 들어갈 아이템을 만듭니다
				MenuItem m1 = new MenuItem();
				
				// 메뉴에 들어가는 아이템의 이름(Text)입력
				m1.Text = "삭제하기";

				// 메뉴선택시 작동할 이벤트 핸들러 작성
				m1.Click += (senders, es) =>
				{
					// show의 반환값이 DialogResult 임을 기억!
					if (MessageBox.Show("데이터를 삭제할까요?", "알림", MessageBoxButtons.OKCancel) == DialogResult.OK)
						DeleteItem(selectedNickname); //외부 함수에 아까 선택했던 아이템의 정보를 넘겨줍니다.
				};

				// 오른쪽클릭시 팝업될 메뉴에 만들어둔 메뉴아이템 m1(= 삭제하기)를 넣는다
				m.MenuItems.Add(m1);

				// 마우스 오른클릭한 위치에 오른쪽 메뉴를 띄운다.
				m.Show(listView1, new Point(e.X, e.Y));
			}
		}

		private void DeleteItem(ListViewItem selectedNickname)
		{
			
			listView1.Items.Remove(selectedNickname);
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			Con.Open();
			string Sql = string.Format("delete TB_CAR_INFO where id = {0};", selectedNickname.Text);
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();

			MessageBox.Show("데이터가 삭제되었습니다.", "알림");

			Con.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			Con.Open();

			string Sql = "INSERT INTO TB_CAR_INFO VALUES (@carName,@carYear,@carPrice,@carDoor)";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
			Com.Parameters.Add("@carYear", SqlDbType.VarChar,4);
			Com.Parameters.Add("@carPrice", SqlDbType.Int);
			Com.Parameters.Add("@carDoor", SqlDbType.Int);
			Com.Parameters["@carName"].Value = textName.Text;
			Com.Parameters["@carYear"].Value = textYear.Text;
			Com.Parameters["@carPrice"].Value = textPrice.Text;
			Com.Parameters["@carDoor"].Value = textDoor.Text;
			Com.ExecuteNonQuery();

			MessageBox.Show("정상적으로 데이터를 저장했습니다.", "알림");
			Con.Close();

			PrintTable();
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			Con.Open();

			ListViewItem selectedNickname = listView1.SelectedItems[0];

			string Sql = string.Format("update TB_CAR_INFO set carName = @carName, carYear = @carYear, carPrice = @carPrice, carDoor = @carDoor where id = {0}", selectedNickname.Text);
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
			Com.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
			Com.Parameters.Add("@carPrice", SqlDbType.Int);
			Com.Parameters.Add("@carDoor", SqlDbType.Int);
			Com.Parameters["@carName"].Value = textName.Text;
			Com.Parameters["@carYear"].Value = textYear.Text;
			Com.Parameters["@carPrice"].Value = textPrice.Text;
			Com.Parameters["@carDoor"].Value = textDoor.Text;
			Com.ExecuteNonQuery();

			MessageBox.Show("정상적으로 데이터를 수정했습니다.", "알림");
			Con.Close();

			PrintTable();
		}

		private void btnSerchSome_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			SqlDataReader R;
			Con.Open();
			string MakeWhere = "";
			int checknum = 0;

			if(!(String.IsNullOrEmpty(textName.Text)))
			{
				MakeWhere += "carName = '";
				MakeWhere += textName.Text;
				MakeWhere += "'";
				checknum++;
			}

			if (!(String.IsNullOrEmpty(textYear.Text)))
			{
				if (checknum > 0) MakeWhere += " or ";
				MakeWhere += "carYear = ";
				MakeWhere += textYear.Text;
				checknum++;
			}

			if (!(String.IsNullOrEmpty(textPrice.Text)))
			{
				if (checknum > 0) MakeWhere += " or ";
				MakeWhere += "carPrice = ";
				MakeWhere +=  textPrice.Text;
				checknum++;
			}

			if (!(String.IsNullOrEmpty(textDoor.Text)))
			{
				if (checknum > 0) MakeWhere += " or ";
				MakeWhere += "carDoor = ";
				MakeWhere +=  textDoor.Text;
			}

			string Sql = string.Format("select * FROM TB_CAR_INFO where {0}", MakeWhere);
			SqlCommand Com = new SqlCommand(Sql, Con);
			R = Com.ExecuteReader();

			while (R.Read())
			{
				string id = (string)R["id"].ToString();
				string carName = (string)R["carName"].ToString();
				string carYear = R["carYear"].ToString();
				string carPrice = (string)R["carPrice"].ToString();
				string carDoor = (string)R["carDoor"].ToString();

				string[] strs = new string[] { id, carName, carYear, carPrice, carDoor };
				ListViewItem getItem = new ListViewItem(strs);
				listView1.Items.Add(getItem);
			}
			R.Close();
			Con.Close();
		}
	}
}
