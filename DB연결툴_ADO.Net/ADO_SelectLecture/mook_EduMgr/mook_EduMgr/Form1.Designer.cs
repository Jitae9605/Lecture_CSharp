namespace mook_EduMgr
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 33);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(19, 80);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(52, 21);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "PWD";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 32);
            this.txtId.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(88, 75);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(208, 32);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(181, 130);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(19, 180);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 21);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "결과 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 222);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblResult;
    }
}

