namespace ADOFormv1_2139
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DAOpenBtn = new System.Windows.Forms.Button();
            this.CCBtn = new System.Windows.Forms.Button();
            this.DRBtn = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(95, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(142, 21);
            this.txtid.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 98);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 21);
            this.txtPhone.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(95, 139);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(142, 21);
            this.txtMail.TabIndex = 7;
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(307, 95);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(82, 40);
            this.AppendBtn.TabIndex = 8;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.UseVisualStyleBackColor = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(399, 95);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(82, 40);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(487, 95);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(82, 40);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(211, 360);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(82, 40);
            this.DAOpenBtn.TabIndex = 13;
            this.DAOpenBtn.Text = "DAOpenBtn";
            this.DAOpenBtn.UseVisualStyleBackColor = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // CCBtn
            // 
            this.CCBtn.Location = new System.Drawing.Point(307, 360);
            this.CCBtn.Name = "CCBtn";
            this.CCBtn.Size = new System.Drawing.Size(82, 40);
            this.CCBtn.TabIndex = 12;
            this.CCBtn.Text = "CCBtn";
            this.CCBtn.UseVisualStyleBackColor = true;
            this.CCBtn.Click += new System.EventHandler(this.CCBtn_Click);
            // 
            // DRBtn
            // 
            this.DRBtn.Location = new System.Drawing.Point(405, 360);
            this.DRBtn.Name = "DRBtn";
            this.DRBtn.Size = new System.Drawing.Size(82, 40);
            this.DRBtn.TabIndex = 11;
            this.DRBtn.Text = "DRBtn";
            this.DRBtn.UseVisualStyleBackColor = true;
            this.DRBtn.Click += new System.EventHandler(this.DRBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(26, 179);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(577, 170);
            this.DBGrid.TabIndex = 14;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 415);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.CCBtn);
            this.Controls.Add(this.DRBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ADOFrormv1_2139";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button AppendBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button DAOpenBtn;
        private System.Windows.Forms.Button CCBtn;
        private System.Windows.Forms.Button DRBtn;
        private System.Windows.Forms.DataGridView DBGrid;
    }
}

