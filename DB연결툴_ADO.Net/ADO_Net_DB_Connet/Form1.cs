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

		private void btnClose_Click(object sender, EventArgs e)					// 연결헤제버튼
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
			// Select버튼 누르면
			// 모든 행을 출력
			PrintTable();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Update버튼 누르면
			// Name = '정우성'인 인물의 나이에 1을 더한 값으로 업데이트
			string Sql = "UPDATE tblPeople SET Age = Age + 1 WHERE Name = '정우성'";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();
			PrintTable();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Delete버튼 누르면
			// Name = '배용준'인 행을 삭제
			// 그런데, 이 테이블이 외래키 등으로 묶여있어 삭제안됨
			string Sql = "DELETE tblPeople WHERE Name = '배용준'";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();
			PrintTable();
		}

		private void btnSum_Click(object sender, EventArgs e)
		{
			// Sum버튼 누르면
			string Sql = "SELECT SUM(Age) FROM tblPeople";
			SqlCommand Com = new SqlCommand(Sql, Con);
			int Sum = (int)Com.ExecuteScalar();				// sql의 집계합수 실행후 그 결과를 가져올때 사용
			MessageBox.Show("나이의 총 합은 " + Sum + "입니다.");
		}

		private void btnInsert1_Click(object sender, EventArgs e)
		{
			// Insert1버튼 누르면
			// Form에 입력한 이름, 나이, 성별(체크=남성 체크X=여성)이 tblPeople테이블에 입력됨
			string Sql = string.Format("INSERT INTO tblPeople VALUES ('{0}',{1},{2})",
				textName.Text, textAge.Text, checkMale.Checked ? 1 : 0);
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.ExecuteNonQuery();
			PrintTable();
		}

		private void btnInsert2_Click(object sender, EventArgs e)
		{
			// Insert2버튼 누르면
			// Form에 입력한 이름, 나이, 성별(체크=남성 체크X=여성)이 각각 파라미터로 임시저장됨
			// 이 파라미터로 SQL문을 실행함
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

		private void btnIncAllAge_Click(object sender, EventArgs e)
		{
			// IncAllAge버튼을 누르면
			// 프로시저 호출객체(= 명령 객체) 생성
			SqlCommand Com = new SqlCommand("IncAllAge", Con);
			Com.CommandType = CommandType.StoredProcedure;

			// 모든 이를 대상으로 나이를 증가시키니 모든 행의 수를 센다
			int nRow;
			nRow = Com.ExecuteNonQuery();
			PrintTable();
			MessageBox.Show("영향받은 행수 = " + nRow);
		}

		private void btnIncSomeAge_Click(object sender, EventArgs e)
		{
			// IncSomeAge버튼을 누르면
			// 프로시저 호출객체(= 명령 객체) 생성
			SqlCommand Com = new SqlCommand("IncSomeAge", Con);
			Com.CommandType = CommandType.StoredProcedure;

			// 파라미터 설정
			Com.Parameters.Add("@Name", SqlDbType.NVarChar, 10);    // IncSomeAge의 '@Name'에 파라미터 설정
			Com.Parameters.Add("@Age", SqlDbType.Int);              // IncSomeAge의 '@Age'에 파라미터 설정
			Com.Parameters["@Age"].Direction = ParameterDirection.Output;   // @Age를 아웃풋(=반환값)으로 설정

			// 호출
			Com.Parameters["@Name"].Value = "김태희";  // IncSomeAge의 @Name에 "김태희"를 파라미터로 전달
			Com.ExecuteNonQuery();

			// 결과 출력
			PrintTable();
			int Age = (int)Com.Parameters["@Age"].Value;
			MessageBox.Show("프로시저 호출 후 나이 = " + Age);
		}

		private void btnRollback_Click(object sender, EventArgs e)
		{
			// Rollback버튼을 누르면
			// 트랜잭션 시작 이후부터 Commit전 까지 DB는 임시로 바뀐다.
			// Commit이 발생하면  트랜잭션 시작후부터 지금까지의 변경내용을 DB에 정식 적용
			// Rollback이 발생하면 트랜잭션 시작후부터 지금까지의 변경내용을 삭제(이전으로 되돌린다)
			SqlTransaction Tr = Con.BeginTransaction();		// 트랜잭션 시작객체 생성
			SqlCommand Com = Con.CreateCommand();			// 명령객체 생성
			Com.Connection = Con;

			Com.Transaction = Tr;                           // Tr시작
			Com.CommandText = "UPDATE tblPeople SET Age = Age + 1 WHERE Name = '정우성'";
			Com.ExecuteNonQuery();
			Com.CommandText = "UPDATE tblPeople SET Age = Age - 1 WHERE Name = '배용준'";
			Com.ExecuteNonQuery();
			Tr.Rollback();									// Tr 반영안함 + DB상태 되돌림
			PrintTable();
		}

		private void btnCommit_Click(object sender, EventArgs e)
		{
			// Commit버튼을 누르면
			// 트랜잭션 시작 이후부터 Commit전 까지 DB는 임시로 바뀐다.
			// Commit이 발생하면  트랜잭션 시작후부터 지금까지의 변경내용을 DB에 정식 적용
			// Rollback이 발생하면 트랜잭션 시작후부터 지금까지의 변경내용을 삭제(이전으로 되돌린다)
			SqlTransaction Tr = Con.BeginTransaction();     // 트랜잭션 시작객체 생성
			SqlCommand Com = Con.CreateCommand();			// 명령객체 생성
			Com.Connection = Con;

			Com.Transaction = Tr;							// Tr시작
			Com.CommandText = "UPDATE tblPeople SET Age = Age + 1 WHERE Name = '정우성'";
			Com.ExecuteNonQuery();
			Com.CommandText = "UPDATE tblPeople SET Age = Age - 1 WHERE Name = '배용준'";
			Com.ExecuteNonQuery();
			Tr.Commit();                                    // Tr 반영함
			PrintTable();
		}

		private void btnFindOverAgeSum_Click(object sender, EventArgs e)
		{
			// FindOverAgeSum버튼 누르면
			string Sql = (string)string.Format("SELECT SUM(Age) FROM tblPeople WHERE Age > {0}", textAge.Text); //
			SqlCommand Com = new SqlCommand(Sql, Con);
			SqlDataReader R = Com.ExecuteReader();      // Com의 결과를 읽어오는 reader를 선언
			R.Read();									// 읽어와 저장(결과값은 한개 이므로 R[0]에 저장된다.

			if(R.IsDBNull(0) == true)                  // 첫번째열(= 0)에 저장된 값이 null인지 판단
			{
				MessageBox.Show("나이의 총합을 알 수 없습니다.");
				R.Close();
			}
			else
			{
				int Sum = (int)R[0];             // sql의 집계합수 실행후 그 결과를 가져올때 사용
				MessageBox.Show("나이의 총 합은 " + Sum + "입니다.");
				R.Close();
			}

			PrintTable();
		}
	}
}
