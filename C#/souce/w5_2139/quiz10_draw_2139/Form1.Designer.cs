namespace quiz10_draw_2139
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_line = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_rec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_freepen = new System.Windows.Forms.ToolStripMenuItem();
            this.선색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_red = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_yellow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_blue = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_allclear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_eraser = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도형ToolStripMenuItem,
            this.선색ToolStripMenuItem,
            this.지우기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도형ToolStripMenuItem
            // 
            this.도형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_line,
            this.mnu_rec,
            this.mnu_freepen});
            this.도형ToolStripMenuItem.Name = "도형ToolStripMenuItem";
            this.도형ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도형ToolStripMenuItem.Text = "도형";
            // 
            // mnu_line
            // 
            this.mnu_line.Name = "mnu_line";
            this.mnu_line.Size = new System.Drawing.Size(180, 22);
            this.mnu_line.Text = "선";
            this.mnu_line.Click += new System.EventHandler(this.mnu_line_Click);
            // 
            // mnu_rec
            // 
            this.mnu_rec.Name = "mnu_rec";
            this.mnu_rec.Size = new System.Drawing.Size(180, 22);
            this.mnu_rec.Text = "사각형";
            this.mnu_rec.Click += new System.EventHandler(this.mnu_rec_Click);
            // 
            // mnu_freepen
            // 
            this.mnu_freepen.Name = "mnu_freepen";
            this.mnu_freepen.Size = new System.Drawing.Size(180, 22);
            this.mnu_freepen.Text = "자유선";
            this.mnu_freepen.Click += new System.EventHandler(this.mnu_freepen_Click);
            // 
            // 선색ToolStripMenuItem
            // 
            this.선색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_red,
            this.mnu_yellow,
            this.mnu_blue});
            this.선색ToolStripMenuItem.Name = "선색ToolStripMenuItem";
            this.선색ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.선색ToolStripMenuItem.Text = "선색";
            // 
            // mnu_red
            // 
            this.mnu_red.Name = "mnu_red";
            this.mnu_red.Size = new System.Drawing.Size(180, 22);
            this.mnu_red.Text = "빨강";
            this.mnu_red.Click += new System.EventHandler(this.mnu_red_Click);
            // 
            // mnu_yellow
            // 
            this.mnu_yellow.Name = "mnu_yellow";
            this.mnu_yellow.Size = new System.Drawing.Size(180, 22);
            this.mnu_yellow.Text = "노랑";
            this.mnu_yellow.Click += new System.EventHandler(this.mnu_yellow_Click);
            // 
            // mnu_blue
            // 
            this.mnu_blue.Name = "mnu_blue";
            this.mnu_blue.Size = new System.Drawing.Size(180, 22);
            this.mnu_blue.Text = "파랑";
            this.mnu_blue.Click += new System.EventHandler(this.mnu_blue_Click);
            // 
            // 지우기ToolStripMenuItem
            // 
            this.지우기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_allclear,
            this.mnu_eraser});
            this.지우기ToolStripMenuItem.Name = "지우기ToolStripMenuItem";
            this.지우기ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.지우기ToolStripMenuItem.Text = "지우기";
            // 
            // mnu_allclear
            // 
            this.mnu_allclear.Name = "mnu_allclear";
            this.mnu_allclear.Size = new System.Drawing.Size(180, 22);
            this.mnu_allclear.Text = "전체 지우기";
            this.mnu_allclear.Click += new System.EventHandler(this.mnu_allclear_Click);
            // 
            // mnu_eraser
            // 
            this.mnu_eraser.Name = "mnu_eraser";
            this.mnu_eraser.Size = new System.Drawing.Size(180, 22);
            this.mnu_eraser.Text = "지우개";
            this.mnu_eraser.Click += new System.EventHandler(this.mnu_eraser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "선 굵기(1~9)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "quiz10_draw_2139";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_line;
        private System.Windows.Forms.ToolStripMenuItem mnu_rec;
        private System.Windows.Forms.ToolStripMenuItem mnu_freepen;
        private System.Windows.Forms.ToolStripMenuItem 선색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_red;
        private System.Windows.Forms.ToolStripMenuItem mnu_yellow;
        private System.Windows.Forms.ToolStripMenuItem mnu_blue;
        private System.Windows.Forms.ToolStripMenuItem 지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_allclear;
        private System.Windows.Forms.ToolStripMenuItem mnu_eraser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

