namespace ADOFormv3_2139
{
    partial class Form2
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DownBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.NameList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(344, 190);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(142, 21);
            this.txtMail.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(344, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 21);
            this.txtPhone.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(344, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 13;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(344, 71);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(142, 21);
            this.txtid.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "id";
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(396, 234);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(73, 26);
            this.DownBtn.TabIndex = 23;
            this.DownBtn.Text = "아래로";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(294, 234);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(76, 26);
            this.UpBtn.TabIndex = 22;
            this.UpBtn.Text = "위로";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 12;
            this.NameList.Location = new System.Drawing.Point(25, 30);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(197, 220);
            this.NameList.TabIndex = 21;
            this.NameList.SelectedIndexChanged += new System.EventHandler(this.NameList_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.ListBox NameList;
    }
}