namespace 병원DB
{
    partial class 게시판
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제목 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.글쓴이 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.날짜 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(642, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "글 쓰기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("한컴바탕확장", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(50, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "자유게시판";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.번호,
            this.제목,
            this.글쓴이,
            this.날짜});
            this.dataGridView1.Location = new System.Drawing.Point(46, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(769, 366);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // 번호
            // 
            this.번호.HeaderText = "      번호";
            this.번호.Name = "번호";
            // 
            // 제목
            // 
            this.제목.HeaderText = "                 제목";
            this.제목.Name = "제목";
            this.제목.Width = 220;
            // 
            // 글쓴이
            // 
            this.글쓴이.HeaderText = "              글쓴이";
            this.글쓴이.Name = "글쓴이";
            this.글쓴이.Width = 190;
            // 
            // 날짜
            // 
            this.날짜.HeaderText = "         날짜";
            this.날짜.Name = "날짜";
            this.날짜.Width = 160;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(736, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "나가기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 게시판
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "게시판";
            this.Text = "자유게시판";
            this.Load += new System.EventHandler(this.게시판_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제목;
        private System.Windows.Forms.DataGridViewTextBoxColumn 글쓴이;
        private System.Windows.Forms.DataGridViewTextBoxColumn 날짜;
        private System.Windows.Forms.Button button2;
    }
}