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
    public partial class Form10 : Form
    {
        public static string id_;
        public static string pw_;

        Form1 f1 = null;
        public Form10(Form1 m) // form1 의 정보를 가져오는 생성자
        {
            InitializeComponent();
            this.f1 = m;
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        public Form10()
        {
            InitializeComponent();

        }
       

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //로그인 버튼
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("데이터를 입력해주세요");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");//DB 연결 변수
                SqlCommand cmd = new SqlCommand(); // 쿼리문 저장 변수
                cmd.Connection = con;
                con.Open();  // DB 연결

                cmd.CommandText = "select * from member where m_id='" + textBox1.Text + "'"; // 그 값을 DB에서 검후 삭제
                cmd.ExecuteNonQuery(); // 실행

                SqlDataReader sdr = cmd.ExecuteReader(); // DB 읽어주는 변수
                while (sdr.Read())
                {
                    string dgv1 = sdr["m_id"].ToString();
                    string dgv2 = sdr["m_pw"].ToString();
                    Form10.id_ = dgv1;
                    Form10.pw_ = dgv2;

                }

                sdr.Close(); // 연결 닫기
                con.Close(); // 연결 닫기
                if(textBox2.Text != Form10.pw_) // PW 불일치
                {
                    MessageBox.Show("PW를 확인해주세요.");
                }
                else if (textBox1.Text == Form10.id_ && textBox2.Text == Form10.pw_) // 둘다 일치
                {
                    MessageBox.Show(Form10.id_ + "님 환영합니다!");
                   f1.log.Text = "로그아웃";
                   f1.join.Visible = false;
                   
                   

                }
                else // ID 불일치 
                {
                    MessageBox.Show("ID를 확인해주세요.");
                }

            }
            Application.OpenForms["Form10"].Close();

            Form2 form2 = new Form2(this);
            Form7 form7 = new Form7(this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



             


        


        
        


