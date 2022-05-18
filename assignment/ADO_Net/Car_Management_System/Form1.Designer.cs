
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnSerchSome = new System.Windows.Forms.Button();
			this.btnSerchAll = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(51, 246);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(51, 273);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 21);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(51, 300);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 21);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(51, 327);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 21);
			this.textBox4.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(247, 244);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "저 장";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(247, 271);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 3;
			this.btnChange.Text = "수 정";
			this.btnChange.UseVisualStyleBackColor = true;
			// 
			// btnSerchSome
			// 
			this.btnSerchSome.Location = new System.Drawing.Point(247, 298);
			this.btnSerchSome.Name = "btnSerchSome";
			this.btnSerchSome.Size = new System.Drawing.Size(75, 23);
			this.btnSerchSome.TabIndex = 3;
			this.btnSerchSome.Text = "조건검색";
			this.btnSerchSome.UseVisualStyleBackColor = true;
			// 
			// btnSerchAll
			// 
			this.btnSerchAll.Location = new System.Drawing.Point(247, 325);
			this.btnSerchAll.Name = "btnSerchAll";
			this.btnSerchAll.Size = new System.Drawing.Size(75, 23);
			this.btnSerchAll.TabIndex = 3;
			this.btnSerchAll.Text = "전체검색";
			this.btnSerchAll.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(310, 225);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 385);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnSerchAll);
			this.Controls.Add(this.btnSerchSome);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnSerchSome;
		private System.Windows.Forms.Button btnSerchAll;
		private System.Windows.Forms.ListView listView1;
	}
}

