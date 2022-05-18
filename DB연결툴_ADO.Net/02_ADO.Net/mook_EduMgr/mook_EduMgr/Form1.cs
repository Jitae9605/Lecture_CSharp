using System;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace mook_EduMgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Constr = "Server=(local);database=ADOTest;" + "Integrated Security=true"; //SQL 연결문자열

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Comm = new SqlCommand("Select userpwd from t_login where userid = '" + this.txtId.Text + "'", Conn);	// 아이디입력
            SqlDataReader reader = Comm.ExecuteReader();	// 입력된걸 읽을 리더를 선언
            if (reader.Read())	// reader에 값이 저장되었으면(불러올 값이 있으면)
            {
                string strpwd = reader["userpwd"].ToString();   // reader가 불러온 값(userid 가 txtId인 행)의 userpwd열의 값을 문자열로 변환해 strpwd에 저장
				if (strpwd == this.txtPwd.Text)                 // strpwd의 값이 입력한 txtPwd와 일치하는 지 판단
				{
					// 일치 = 로그인 성공
                    reader.Close();
                    Conn.Close();
                    Form2 frm2 = new Form2();
                    frm2.UserId = this.txtId.Text;
                    frm2.Show();	// form2 팝업
                    this.Hide();	// form1 숨김
                }
                else
                {	// 비번틀림
                    this.lblResult.Text = "결과 : 로그인 실패";
                    txtClear();
                }
            }
            else
            {	// 그런아이디없음
                this.lblResult.Text = "결과 : 로그인 실패";
                txtClear();
            }
            reader.Close();
            Conn.Close();
        }

        private void txtClear()
        {
            this.txtId.Text = "";
            this.txtPwd.Text = "";
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
