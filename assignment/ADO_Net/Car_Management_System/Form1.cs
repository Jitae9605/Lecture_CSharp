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

		private void PrintTable()	// 데이터베이스 전체 출력 == 전체검색
		{
			listView1.Items.Clear();
			Con = new SqlConnection();	// 커넥터 선언
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;"; // 데이터베이스 연결
			SqlCommand Com = new SqlCommand("SELECT * FROM TB_CAR_INFO;", Con); // TB_CAR_INFO테이블에서 전부 선택
			SqlDataReader R;
			Con.Open();
			R = Com.ExecuteReader();	// Com에 저장된 sql명령어를 수행하고 결과를 SqlDataReader R로 보낸다.

			while (R.Read())	// R에 아직 읽을 행이 남아있는동안 무한반복(한행 읽고 다음행을 읽는다
			{
				string id = (string)R["id"].ToString();					// R.Read로 읽어온 행의 id열 값을 id에 저장
				string carName = (string)R["carName"];                  // R.Read로 읽어온 행의 carName열 값을 carName에 저장
				string carYear = R["carYear"].ToString();				// R.Read로 읽어온 행의 carYear열 값을 carYear에 저장
				string carPrice = (string)R["carPrice"].ToString();		// R.Read로 읽어온 행의 carPrice열 값을 carPrice에 저장
				string carDoor = (string)R["carDoor"].ToString();       // R.Read로 읽어온 행의 carDoor열 값을 carDoor에 저장

				// 이렇게 저장된 string 문자열들을 문자열배열을 선언해 삽입
				string[] strs = new string[] { id, carName, carYear, carPrice, carDoor };

				// ListView에 Item으로 삽입되려면 열수에 맞는 배열요소를 가진 문자열 배열이어야 하므로
				ListViewItem getItem = new ListViewItem(strs);
				listView1.Items.Add(getItem);
			}
			R.Close();
			Con.Close();
		}

		private void Form1_Load(object sender, EventArgs e)	// form로드됨과 동시에 수행할
		{
			PrintTable();
		}

		private void btnSerchAll_Click(object sender, EventArgs e)	// 전체검색 버튼 클릭시 수행
		{
			PrintTable();
		}

		private void listView1_MouseClick(object sender, MouseEventArgs e)	
		{
			// 한 행을 선택하고 우클릭시 삭제 메뉴가 팝업되게 하기

			if (e.Button.Equals(MouseButtons.Right))	// 마우스 우클릭이 listview1 영역내에서 감지될경우 실행됨
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
			// 우클릭후 삭제메뉴를 선택할 경우 선택된 대상의 index번호가 이 함수에게 전달됨
			listView1.Items.Remove(selectedNickname);	// list에서 먼저 삭제
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";// db연결
			Con.Open();

			// db에서 해당 인덱스번호의 행을 삭제하는 sql문 작성
			string Sql = string.Format("delete TB_CAR_INFO where id = {0};", selectedNickname.Text); 
			SqlCommand Com = new SqlCommand(Sql, Con);

			// sql문 실행
			Com.ExecuteNonQuery();

			MessageBox.Show("데이터가 삭제되었습니다.", "알림");

			Con.Close();
		}

		private void btnSave_Click(object sender, EventArgs e) // 저장버튼 클릭시 실행
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			Con.Open();

			// sql문장을 작성하되 파라미터로 텍스트박스의 값들으 각각 가져와 sql문장을 형성
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
			Com.ExecuteNonQuery();	// sql문장 실행

			// 삽입 후 텍스트박스 비우기
			textName.Clear();
			textYear.Clear();
			textDoor.Clear();
			textPrice.Clear();
			MessageBox.Show("정상적으로 데이터를 저장했습니다.", "알림");	// 저장완료 메세지박스 팝업
			Con.Close();

			PrintTable();
		}

		private void btnChange_Click(object sender, EventArgs e)	// 수정버튼 클릭스 수행
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			Con.Open();

			// 수정하고자하는 대상을 선택한후 값을 입력하고 수정버튼을 눌러 수정
			ListViewItem selectedNickname = listView1.SelectedItems[0];	// 선택한 대상의 인덱스값을 가져온다

			// 텍스트박스에서 값을 가져와 update sql문을 작성(대상을 가져온 선택된 대상의 인덱스 값을 where로 해서 수행)
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
			Com.ExecuteNonQuery();	// sql문 실행

			MessageBox.Show("정상적으로 데이터를 수정했습니다.", "알림");
			Con.Close();

			PrintTable();
		}

		private void btnSerchSome_Click(object sender, EventArgs e)	// 조건검색
		{
			listView1.Items.Clear();
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" + "Integrated Security = true;";
			SqlDataReader R;
			Con.Open();
			string MakeWhere = "";	// 조건을 조합하고 합칠때 사용할 빈 string
			int checknum = 0;       // 현재 합쳐진 string의 갯수

			// 텍스트박스가 비어있지 않으면 값을 가져와서 MakeWhere에 합친다(추가한다)
			if (!(String.IsNullOrEmpty(textName.Text)))
			{
				MakeWhere += "carName = '";
				MakeWhere += textName.Text;
				MakeWhere += "'";			// carName은 nvarchar형으로 select 할때 ''로 묶어줘야함을 까먹지 말것
				checknum++;	// 이를 통해 몇개의 조건인지와 그에따른 or의 추가를 판단.
			}

			if (!(String.IsNullOrEmpty(textYear.Text)))
			{
				// checknum이 0이 아니면 앞에서 하나가 추가되었다는것이므로 앞에 or을 먼저 붙인다음 조건을 추가한다.
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

			// 위에서 만든 MakeWhere을 통해 조건 select문을 만듬
			string Sql = string.Format("select * FROM TB_CAR_INFO where {0}", MakeWhere);
			SqlCommand Com = new SqlCommand(Sql, Con);
			R = Com.ExecuteReader();	// sql문실행

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
