namespace 병원DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.환자목록 = new System.Windows.Forms.PictureBox();
            this.의사목록 = new System.Windows.Forms.PictureBox();
            this.진료예약 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.join = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.환자목록)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.의사목록)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.진료예약)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.환자목록);
            this.panel1.Controls.Add(this.의사목록);
            this.panel1.Controls.Add(this.진료예약);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 514);
            this.panel1.TabIndex = 0;
            // 
            // 환자목록
            // 
            this.환자목록.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("환자목록.BackgroundImage")));
            this.환자목록.Image = ((System.Drawing.Image)(resources.GetObject("환자목록.Image")));
            this.환자목록.Location = new System.Drawing.Point(411, 328);
            this.환자목록.Name = "환자목록";
            this.환자목록.Size = new System.Drawing.Size(203, 169);
            this.환자목록.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.환자목록.TabIndex = 1;
            this.환자목록.TabStop = false;
            this.환자목록.Click += new System.EventHandler(this.환자목록_Click);
            // 
            // 의사목록
            // 
            this.의사목록.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("의사목록.BackgroundImage")));
            this.의사목록.Image = ((System.Drawing.Image)(resources.GetObject("의사목록.Image")));
            this.의사목록.Location = new System.Drawing.Point(209, 328);
            this.의사목록.Name = "의사목록";
            this.의사목록.Size = new System.Drawing.Size(203, 169);
            this.의사목록.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.의사목록.TabIndex = 0;
            this.의사목록.TabStop = false;
            this.의사목록.Click += new System.EventHandler(this.의사목록_Click);
            // 
            // 진료예약
            // 
            this.진료예약.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("진료예약.BackgroundImage")));
            this.진료예약.Image = ((System.Drawing.Image)(resources.GetObject("진료예약.Image")));
            this.진료예약.Location = new System.Drawing.Point(7, 328);
            this.진료예약.Name = "진료예약";
            this.진료예약.Size = new System.Drawing.Size(203, 169);
            this.진료예약.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.진료예약.TabIndex = 0;
            this.진료예약.TabStop = false;
            this.진료예약.Click += new System.EventHandler(this.진료예약_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(7, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 329);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(612, 328);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(200, 170);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.Location = new System.Drawing.Point(11, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 21);
            this.textBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(65, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightPink;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(11, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 52);
            this.listBox1.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(89, 60);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(37, 60);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(65, 60);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(18, 19);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Pink;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(692, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 144);
            this.panel4.TabIndex = 14;
            this.panel4.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(739, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(646, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "게시판";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.Color.White;
            this.join.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join.Location = new System.Drawing.Point(467, 7);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(82, 23);
            this.join.TabIndex = 16;
            this.join.Text = "회원 가입";
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.button3_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.White;
            this.log.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.log.Location = new System.Drawing.Point(555, 8);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(82, 23);
            this.log.TabIndex = 17;
            this.log.Text = "로그인";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 543);
            this.Controls.Add(this.log);
            this.Controls.Add(this.join);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(30, 30);
            this.Name = "Form1";
            this.Text = "진웅 병원";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.환자목록)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.의사목록)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.진료예약)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox 의사목록;
        private System.Windows.Forms.PictureBox 진료예약;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox 환자목록;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button join;
        public System.Windows.Forms.Button log;
    }
}

