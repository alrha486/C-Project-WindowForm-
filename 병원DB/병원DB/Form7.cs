using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // DB
namespace 병원DB

{
    public partial class Form7 : Form
    {
        Form10 form10_ = null;
        public Form7(Form10 m) //폼10의 정보를 받아오는 생성자
        {
            InitializeComponent();
            this.form10_ = m;
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 위치
        }

        게시판 a = null;
        public Form7(게시판 m) //폼10의 정보를 받아오는 생성자
        {
            InitializeComponent();
            this.a = m;
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 위치

            maskedTextBox1.Text = DateTime.Now.ToString("yyyy.MM.dd hh시mm분"); // 작성일자의 형식 지정 후 현재시각 자동입력

            string ID_ = Form10.id_; //  폼10에서 받아온 로그인 성공한 회원ID 

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;// DB연결
            cmd.CommandText = "select * from member where (m_id =" + "'" + ID_ + "')"; // form10에서 받아온 회원 UD를 DB에서 검색
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                string db1 = sdr["m_id"].ToString();

                textBox2.Text = db1;// 작성자를 입력 란에 회원 ID 자동입력
            }
            sdr.Close();
            con.Close();
        }


        public Form7()
        {
            this.StartPosition = FormStartPosition.CenterScreen; //중앙에 위치
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); // DB 연결

            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox3.Text == "")
            { //하나라도 입력을 안했다면
                MessageBox.Show("데이터를 입력해주세요");
            }
            else
            {   //다 입력했다면
                cmd.CommandText = "insert into board(title, writer, text_, day_)" +
                                                  "values(" + "'" + textBox1.Text + "', " +
                                                              "'" + textBox2.Text + "', " +
                                                              "'" + richTextBox3.Text + "', " +
                                                              "'" + maskedTextBox1.Text + "')"; // 게시판(board) 테이블에 입력
                MessageBox.Show("추가가 완료 되었습니다");

                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                richTextBox3.Clear();
                maskedTextBox1.Clear();

                Form8 form8 = new Form8(this);
                Application.OpenForms["Form7"].Close();




                a.dataGridView1.Rows.Clear();
                SqlConnection con2 = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con2; //DB 연결

                cmd1.CommandText = "select * from board order by day_ asc"; // 게시판 테이블 전체 검색

                con2.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                int i = 1;
                while (sdr1.Read())
                {
                    string db1 = sdr1["title"].ToString();
                    string db2 = sdr1["writer"].ToString();
                    string db3 = sdr1["day_"].ToString();
                    a.dataGridView1.Rows.Add(i, db1, db2, db3); // DB에서 읽어와 변수에 저장 후 리스트에 출력     
                    //a.dataGridView1.Rows.Add(new string[] {"1",db1,db2,db3 });
                    i++; // 행 순서대로 읽어오며, 행 앞에 번호 붙여주기
                }

                sdr1.Close(); //연결 닫기 
                con2.Close(); //연결 닫기

            }

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e) //글꼴 버튼
        {
            FontDialog fontDiolog1 = new FontDialog();
            fontDiolog1.ShowColor = true;
            if(fontDiolog1.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(richTextBox3.Text))  //폰트 선택 창 디스플레이
            {
                richTextBox3.SelectionFont = fontDiolog1.Font; //선택한 폰트 지정
                richTextBox3.SelectionColor = fontDiolog1.Color; // 선택한 폰트 색 지정

                string a = richTextBox3.SelectionFont.Name; //글꼴의 이름
                float b = richTextBox3.SelectionFont.Size; //글꼴의 사이즈
                string c = richTextBox3.SelectionFont.Style.ToString();
                string d = richTextBox3.SelectionColor.Name; // 글꼴의 컬러
            }
        }
    }
    }

