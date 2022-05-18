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

        private string Constr = "Server=(local);database=ADOTest;" +
                "Integrated Security=true"; //SQL 연결문자열

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Comm = new SqlCommand("Select userpwd from t_login where userid = '" + this.txtId.Text + "'", Conn);
            SqlDataReader reader = Comm.ExecuteReader();
            if (reader.Read())
            {
                string strpwd = reader["userpwd"].ToString();
                if (strpwd == this.txtPwd.Text)
                {
                    reader.Close();
                    Conn.Close();
                    Form2 frm2 = new Form2();
                    frm2.UserId = this.txtId.Text;
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    this.lblResult.Text = "결과 : 로그인 실패";
                    txtClear();
                }
            }
            else
            {
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
    }
}
