using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace mook_EduMgr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string UserId { get; set; }	// form1으로 부터 넘겨받음

        private string Constr = "Server=(local);database=ADOTest;" + "Integrated Security=true"; //SQL 연결문자열

        private int EduNum = 0;

        List<string> subtmp = new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {
            DataLoad();
            SubjectLoad();
        }

        private void DataLoad()
        {
			// db로 부터 데이터를 불러와 입력
            var Conn = new SqlConnection(Constr);
            Conn.Open();

			// 학생 인적사항 데이터 
			var Comm01 = new SqlCommand("Select name, edunum, birth, email, phone from t_userinfo where userid = '" + UserId + "'", Conn);
            var myRead01 = Comm01.ExecuteReader();	
            if (myRead01.Read())
            {
                this.lblName.Text = "이름 : " + myRead01[0].ToString();			// name
                this.lblEduNum.Text = "학번 : " + myRead01[1].ToString();		// edunum
				EduNum = Convert.ToInt32(myRead01[1].ToString());               // edunum을 int형으로 변환해서 EduNum에 저장(후에 활용)
				this.lblBirth.Text = "생년월일 : " + myRead01[2].ToString();     // birth
				this.lblEmail.Text = "이메일 : " + myRead01[3].ToString();		// email
				this.lblPhone.Text = "핸드폰 : " + myRead01[4].ToString();		// phone
			}
            myRead01.Close();

            subtmp.Clear();

			// 학생의 수강 데이터
            var Comm02 = new SqlCommand("Select subject from t_user_subject where edunum = " + EduNum + "", Conn);
            var myRead02 = Comm02.ExecuteReader();
            while (myRead02.Read())
            {
                subtmp.Add(myRead02[0].ToString());
            }
            myRead02.Close();
            Conn.Close();
        }

        private void SubjectLoad()
        {
			// 강의목록 데이터
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select subject from t_subject", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                if (!subtmp.Contains(myRead[0].ToString()))
                    this.lbSubject.Items.Add(myRead[0].ToString());
            }
            myRead.Close();
            Conn.Close();
            foreach (string s in subtmp)
                this.lbMySubject.Items.Add(s);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
			// 학생정보수정 버튼 클릭시
            Form3 frm3 = new Form3();
            frm3.EudNum = EduNum;       // form3에 EduNum을 넘김
			if (frm3.ShowDialog() == DialogResult.OK)	// 폼을 대화상자로 팝업
            {
                DataLoad();
                frm3.Close();
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
			// > 버튼
            subtmp.Clear();
            foreach (string s in lbSubject.SelectedItems)   // lbSubject의 선택된것들 각각에 대해 수행
			{
                this.lbMySubject.Items.Add(s);              // lbMySubject에 이를 추가
				subtmp.Add(s);                              // 그리고 이를 subtmp에 저장
			}
            foreach (string s in subtmp)
            {
                this.lbSubject.Items.Remove(s);             // subtmp에 저장된 목록을 lbSubject에서 제거
			}
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
			// < 버튼
            subtmp.Clear();
            foreach (string s in lbMySubject.SelectedItems) // lbMySubject의 선택된것들 각각에 대해 수행
			{
                this.lbSubject.Items.Add(s);                // lbSubject에 이를 추가
				subtmp.Add(s);								// 그리고 이를 subtmp에 저장
            }
            foreach (string s in subtmp)
            {
                this.lbMySubject.Items.Remove(s);           // subtmp에 저장된 목록을 lbMySubject에서 제거
			}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			// 수정된 사항(lbMySubject 과 lbSubject의 Add, Del 사항)을 실제 db에 반영
			try
			{
                var Conn = new SqlConnection(Constr);
                Conn.Open();

                var myCom01 = new SqlCommand("delete from t_user_subject where edunum = " + EduNum + "", Conn);
                myCom01.ExecuteNonQuery();

                foreach (string sub in this.lbMySubject.Items)
                {
                    var strSQL = "insert into t_user_subject(edunum, subject) values(" + EduNum + ", '" + sub + "')";
                    var myCom02 = new SqlCommand(strSQL, Conn);
                    myCom02.ExecuteNonQuery();
                }
                Conn.Close();

                MessageBox.Show("데이터가 저장 되었습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("데이터가 저장 되지 않았습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
