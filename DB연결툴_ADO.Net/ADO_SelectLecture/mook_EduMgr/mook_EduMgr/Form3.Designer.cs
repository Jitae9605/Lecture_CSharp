namespace mook_EduMgr
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEduNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblbirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEduNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEduNum
            // 
            this.lblEduNum.AutoSize = true;
            this.lblEduNum.Location = new System.Drawing.Point(36, 35);
            this.lblEduNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEduNum.Name = "lblEduNum";
            this.lblEduNum.Size = new System.Drawing.Size(52, 21);
            this.lblEduNum.TabIndex = 0;
            this.lblEduNum.Text = "학번";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Location = new System.Drawing.Point(36, 149);
            this.lblbirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(94, 21);
            this.lblbirth.TabIndex = 2;
            this.lblbirth.Text = "생년월일";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 210);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 21);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "이메일";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 275);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 21);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "핸드폰";
            // 
            // txtEduNum
            // 
            this.txtEduNum.Location = new System.Drawing.Point(137, 30);
            this.txtEduNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEduNum.Name = "txtEduNum";
            this.txtEduNum.ReadOnly = true;
            this.txtEduNum.Size = new System.Drawing.Size(155, 32);
            this.txtEduNum.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(155, 32);
            this.txtName.TabIndex = 6;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(137, 144);
            this.txtBirth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(155, 32);
            this.txtBirth.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 205);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 32);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 270);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 32);
            this.txtPhone.TabIndex = 9;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(286, 341);
            this.btnModify.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(118, 40);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 402);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEduNum);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEduNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "학생 정보 수정";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEduNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEduNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnModify;
    }
}