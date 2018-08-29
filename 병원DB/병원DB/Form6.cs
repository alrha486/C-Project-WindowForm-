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
    public partial class 게시판 : Form
    {
        Form1 form1 = null;
        public 게시판(Form1 m) //폼1의 정보를 받아오는 생성자
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //중앙에 위치
            this.form1 = m;

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con; //DB 연결

            cmd.CommandText = "select * from board order by day_ asc "; // 게시판 테이블 전체 검색

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            int i = 1;
            while (sdr.Read())
            {

                string db1 = sdr["title"].ToString();
                string db2 = sdr["writer"].ToString();
                string db3 = sdr["day_"].ToString();
                dataGridView1.Rows.Add(i, db1, db2, db3); // DB에서 읽어와 변수에 저장 후 리스트에 출력     
                i++; // 행 순서대로 읽어오며, 행 앞에 번호 붙여주기
            }
            Form7 form7 = new Form7(this);
            //form7.ShowDialog();
            sdr.Close(); //연결 닫기 
            con.Close(); //연결 닫기
        }


        public static string title; 
        public static string writer;
        public static string text;
        public static string day; // 다른 폼에서 사용 할 변수들. public static으로 설정

        public 게시판()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.log.Text == "로그인") // form1의  log버튼의 text가 로그인이라면
            {
                MessageBox.Show("로그인 후 이용해주세요.");
            }
            else if(form1.log.Text == "로그아웃") // form1의 log버튼의 text가 로그아웃이라면
            {
                Form7 form7 = new Form7(this);
                form7.ShowDialog();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");//DB 연결 변수
            SqlCommand cmd = new SqlCommand(); // 쿼리문 저장 변수
            cmd.Connection = con;
            con.Open();  // DB 연결

            string s_title = dataGridView1.CurrentCell.Value.ToString(); // dataGridView 리스트에서 선택 한 셀의 값
            cmd.CommandText = "select * from board where title='"+s_title+"'"; // 그 값을 DB에서 검후 삭제
            cmd.ExecuteNonQuery(); // 실행

            SqlDataReader sdr = cmd.ExecuteReader(); // DB 읽어주는 변수
            while (sdr.Read())
            {
                string dgv1 = sdr["title"].ToString();
                string dgv2 = sdr["writer"].ToString();
                string dgv3 = sdr["text_"].ToString();
                string dgv4 = sdr["day_"].ToString();
                게시판.title = dgv1;
                게시판.writer = dgv2;
                게시판.text = dgv3;
                게시판.day = dgv4;
            }

            sdr.Close(); // 연결 닫기
            con.Close(); // 연결 닫기


            Form8 form8 = new Form8(); // 정보를 DB에서 읽은 후 해당 글을 띄워 줄 새로운 폼 생성
            form8.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 게시판_Load(object sender, EventArgs e)
        {

        }
    }
}
