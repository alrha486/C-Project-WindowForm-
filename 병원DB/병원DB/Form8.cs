using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 병원DB
{
    public partial class Form8 : Form
    {
        Form7 form7 = null;
        public Form8(Form7 m) //폼7의 정보를 받아오는 생성자
        {
            InitializeComponent();
            this.form7 = m;
            this.StartPosition = FormStartPosition.CenterScreen; //중앙에 위치
        }

        public Form8()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //중앙에 위치
            richTextBox1.Text = 게시판.title;
            richTextBox2.Text = 게시판.writer;
            maskedTextBox1.Text = 게시판.day; // 폼7에서 받아온 정보를 textbox에 출력

            string a = richTextBox3.SelectionFont.Name.ToString(); //글꼴의 이름
            float b = richTextBox3.SelectionFont.Size; //글꼴의 사이즈
            string c = richTextBox3.SelectionFont.Style.ToString();
            string d = richTextBox3.SelectionColor.Name; // 글꼴의 컬러

            //   richTextBox3.SelectionFont = new Font("a", b, c);
           // richTextBox3.Font = a
            richTextBox3.Text = 게시판.text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //  폼 닫기
        }
    }
}
