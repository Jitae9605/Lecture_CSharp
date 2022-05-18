
namespace Car_Management_System
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
			this.lbName = new System.Windows.Forms.Label();
			this.lbYear = new System.Windows.Forms.Label();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.textYear = new System.Windows.Forms.TextBox();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.textDoor = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnSerchSome = new System.Windows.Forms.Button();
			this.btnSerchAll = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.lvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvDoor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(12, 249);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(33, 12);
			this.lbName.TabIndex = 1;
			this.lbName.Text = "이 름";
			// 
			// lbYear
			// 
			this.lbYear.AutoSize = true;
			this.lbYear.Location = new System.Drawing.Point(12, 276);
			this.lbYear.Name = "lbYear";
			this.lbYear.Size = new System.Drawing.Size(33, 12);
			this.lbYear.TabIndex = 1;
			this.lbYear.Text = "년 식";
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Location = new System.Drawing.Point(12, 303);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(33, 12);
			this.lbPrice.TabIndex = 1;
			this.lbPrice.Text = "가 격";
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Location = new System.Drawing.Point(12, 330);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(33, 12);
			this.lbType.TabIndex = 1;
			this.lbType.Text = "도 어";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(51, 246);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(100, 21);
			this.textName.TabIndex = 2;
			// 
			// textYear
			// 
			this.textYear.Location = new System.Drawing.Point(51, 273);
			this.textYear.Name = "textYear";
			this.textYear.Size = new System.Drawing.Size(100, 21);
			this.textYear.TabIndex = 2;
			// 
			// textPrice
			// 
			this.textPrice.Location = new System.Drawing.Point(51, 300);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(100, 21);
			this.textPrice.TabIndex = 2;
			// 
			// textDoor
			// 
			this.textDoor.Location = new System.Drawing.Point(51, 327);
			this.textDoor.Name = "textDoor";
			this.textDoor.Size = new System.Drawing.Size(100, 21);
			this.textDoor.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(247, 244);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "저 장";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(247, 271);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 3;
			this.btnChange.Text = "수 정";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// btnSerchSome
			// 
			this.btnSerchSome.Location = new System.Drawing.Point(247, 298);
			this.btnSerchSome.Name = "btnSerchSome";
			this.btnSerchSome.Size = new System.Drawing.Size(75, 23);
			this.btnSerchSome.TabIndex = 3;
			this.btnSerchSome.Text = "조건검색";
			this.btnSerchSome.UseVisualStyleBackColor = true;
			this.btnSerchSome.Click += new System.EventHandler(this.btnSerchSome_Click);
			// 
			// btnSerchAll
			// 
			this.btnSerchAll.Location = new System.Drawing.Point(247, 325);
			this.btnSerchAll.Name = "btnSerchAll";
			this.btnSerchAll.Size = new System.Drawing.Size(75, 23);
			this.btnSerchAll.TabIndex = 3;
			this.btnSerchAll.Text = "전체검색";
			this.btnSerchAll.UseVisualStyleBackColor = true;
			this.btnSerchAll.Click += new System.EventHandler(this.btnSerchAll_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvID,
            this.lvName,
            this.lvYear,
            this.lvPrice,
            this.lvDoor});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(14, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(308, 215);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			// 
			// lvID
			// 
			this.lvID.Text = "번호";
			// 
			// lvName
			// 
			this.lvName.Text = "이 름";
			// 
			// lvYear
			// 
			this.lvYear.Text = "년식";
			// 
			// lvPrice
			// 
			this.lvPrice.Text = "가 격";
			// 
			// lvDoor
			// 
			this.lvDoor.Text = "도 어";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 365);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnSerchAll);
			this.Controls.Add(this.btnSerchSome);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.textDoor);
			this.Controls.Add(this.textPrice);
			this.Controls.Add(this.textYear);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.lbYear);
			this.Controls.Add(this.lbName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbYear;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textYear;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.TextBox textDoor;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnSerchSome;
		private System.Windows.Forms.Button btnSerchAll;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader lvID;
		private System.Windows.Forms.ColumnHeader lvName;
		private System.Windows.Forms.ColumnHeader lvYear;
		private System.Windows.Forms.ColumnHeader lvPrice;
		private System.Windows.Forms.ColumnHeader lvDoor;
	}
}

