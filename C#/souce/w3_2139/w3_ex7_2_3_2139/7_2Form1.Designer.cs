namespace w3_ex7_2_3_2139
{
    partial class ex7_2
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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn.Location = new System.Drawing.Point(0, 246);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(800, 204);
            this.btn.TabIndex = 0;
            this.btn.Text = "close";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ex7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Name = "ex7_2";
            this.Text = "w3_ex7_2_3_2139";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ex7_2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ex7_2_FormClosed);
            this.Load += new System.EventHandler(this.ex7_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
    }
}

