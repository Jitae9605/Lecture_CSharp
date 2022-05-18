
namespace ADO_Net_DB_Connet
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSum = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.textAge = new System.Windows.Forms.TextBox();
			this.btnInsert1 = new System.Windows.Forms.Button();
			this.checkMale = new System.Windows.Forms.CheckBox();
			this.btnInsert2 = new System.Windows.Forms.Button();
			this.btnIncAllAge = new System.Windows.Forms.Button();
			this.btnIncSomeAge = new System.Windows.Forms.Button();
			this.btnCommit = new System.Windows.Forms.Button();
			this.btnRollback = new System.Windows.Forms.Button();
			this.btnFindOverAgeSum = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(14, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(192, 172);
			this.listBox1.TabIndex = 0;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(14, 190);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(92, 38);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "연결";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(112, 190);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 38);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "연결해제";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(225, 12);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(308, 172);
			this.listBox2.TabIndex = 0;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(539, 12);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(61, 38);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(539, 56);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(61, 38);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(539, 100);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(61, 38);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSum
			// 
			this.btnSum.Location = new System.Drawing.Point(539, 146);
			this.btnSum.Name = "btnSum";
			this.btnSum.Size = new System.Drawing.Size(61, 38);
			this.btnSum.TabIndex = 2;
			this.btnSum.Text = "sum";
			this.btnSum.UseVisualStyleBackColor = true;
			this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(223, 203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "이름 :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(345, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "나이 :";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(266, 200);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(73, 21);
			this.textName.TabIndex = 5;
			// 
			// textAge
			// 
			this.textAge.Location = new System.Drawing.Point(388, 200);
			this.textAge.Name = "textAge";
			this.textAge.Size = new System.Drawing.Size(80, 21);
			this.textAge.TabIndex = 5;
			// 
			// btnInsert1
			// 
			this.btnInsert1.Location = new System.Drawing.Point(225, 227);
			this.btnInsert1.Name = "btnInsert1";
			this.btnInsert1.Size = new System.Drawing.Size(114, 29);
			this.btnInsert1.TabIndex = 6;
			this.btnInsert1.Text = "Insert 1";
			this.btnInsert1.UseVisualStyleBackColor = true;
			this.btnInsert1.Click += new System.EventHandler(this.btnInsert1_Click);
			// 
			// checkMale
			// 
			this.checkMale.AutoSize = true;
			this.checkMale.Location = new System.Drawing.Point(485, 202);
			this.checkMale.Name = "checkMale";
			this.checkMale.Size = new System.Drawing.Size(48, 16);
			this.checkMale.TabIndex = 8;
			this.checkMale.Text = "남자";
			this.checkMale.UseVisualStyleBackColor = true;
			// 
			// btnInsert2
			// 
			this.btnInsert2.Location = new System.Drawing.Point(354, 227);
			this.btnInsert2.Name = "btnInsert2";
			this.btnInsert2.Size = new System.Drawing.Size(114, 29);
			this.btnInsert2.TabIndex = 6;
			this.btnInsert2.Text = "Insert 2";
			this.btnInsert2.UseVisualStyleBackColor = true;
			this.btnInsert2.Click += new System.EventHandler(this.btnInsert2_Click);
			// 
			// btnIncAllAge
			// 
			this.btnIncAllAge.Location = new System.Drawing.Point(606, 12);
			this.btnIncAllAge.Name = "btnIncAllAge";
			this.btnIncAllAge.Size = new System.Drawing.Size(88, 38);
			this.btnIncAllAge.TabIndex = 9;
			this.btnIncAllAge.Text = "IncAllAge";
			this.btnIncAllAge.UseVisualStyleBackColor = true;
			this.btnIncAllAge.Click += new System.EventHandler(this.btnIncAllAge_Click);
			// 
			// btnIncSomeAge
			// 
			this.btnIncSomeAge.Location = new System.Drawing.Point(606, 56);
			this.btnIncSomeAge.Name = "btnIncSomeAge";
			this.btnIncSomeAge.Size = new System.Drawing.Size(88, 38);
			this.btnIncSomeAge.TabIndex = 10;
			this.btnIncSomeAge.Text = "IncSomeAge";
			this.btnIncSomeAge.UseVisualStyleBackColor = true;
			this.btnIncSomeAge.Click += new System.EventHandler(this.btnIncSomeAge_Click);
			// 
			// btnCommit
			// 
			this.btnCommit.Location = new System.Drawing.Point(606, 100);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(88, 38);
			this.btnCommit.TabIndex = 11;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = true;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// btnRollback
			// 
			this.btnRollback.Location = new System.Drawing.Point(606, 144);
			this.btnRollback.Name = "btnRollback";
			this.btnRollback.Size = new System.Drawing.Size(88, 38);
			this.btnRollback.TabIndex = 11;
			this.btnRollback.Text = "Rollback";
			this.btnRollback.UseVisualStyleBackColor = true;
			this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
			// 
			// btnFindOverAgeSum
			// 
			this.btnFindOverAgeSum.Location = new System.Drawing.Point(539, 190);
			this.btnFindOverAgeSum.Name = "btnFindOverAgeSum";
			this.btnFindOverAgeSum.Size = new System.Drawing.Size(155, 31);
			this.btnFindOverAgeSum.TabIndex = 12;
			this.btnFindOverAgeSum.Text = "FindOverAgeSum";
			this.btnFindOverAgeSum.UseVisualStyleBackColor = true;
			this.btnFindOverAgeSum.Click += new System.EventHandler(this.btnFindOverAgeSum_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 275);
			this.Controls.Add(this.btnFindOverAgeSum);
			this.Controls.Add(this.btnRollback);
			this.Controls.Add(this.btnCommit);
			this.Controls.Add(this.btnIncSomeAge);
			this.Controls.Add(this.btnIncAllAge);
			this.Controls.Add(this.checkMale);
			this.Controls.Add(this.btnInsert2);
			this.Controls.Add(this.btnInsert1);
			this.Controls.Add(this.textAge);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSum);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textAge;
		private System.Windows.Forms.Button btnInsert1;
		private System.Windows.Forms.CheckBox checkMale;
		private System.Windows.Forms.Button btnInsert2;
		private System.Windows.Forms.Button btnIncAllAge;
		private System.Windows.Forms.Button btnIncSomeAge;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.Button btnRollback;
		private System.Windows.Forms.Button btnFindOverAgeSum;
	}
}

