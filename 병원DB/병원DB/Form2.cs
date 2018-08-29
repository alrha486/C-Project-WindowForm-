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
using System.Data.SqlClient; // DB


namespace 병원DB
{
    public partial class Form2 : Form
    {
        Form10 form10_ = null;
        public Form2(Form10 m) //폼10의 정보를 불러오는 생성자
        {
            InitializeComponent();
            this.form10_ = m;
        }


        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            string ID_ = Form10.id_; //  폼10에서 받아온 로그인 성공한 회원ID 

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from member where (m_id =" + "'" + ID_ + "')"; // 쿼리문
            con.Open(); // DB 연결
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                string db1 = sdr["m_name"].ToString();
                string db2 = sdr["m_num"].ToString();
                string db3 = sdr["m_add"].ToString();
                string db4 = sdr["m_ph"].ToString();



                textBox1.Text = db1;
                textBox2.Text = db2;
                textBox3.Text = db3;
                textBox4.Text = db4; //읽어서 변수에 저장 후 리스트에 출력

            }
            sdr.Close();
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // 예약 버튼
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""  // 하나라도 비어있다면
                || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("데이터를 입력해주세요");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open(); // DB 연결
                cmd.CommandText = "insert into reservation(section, name, p_num, p_add, ph, d_name, r_date, symptom)" +
                                  "values(" + "'" + comboBox1.Text + "', " +
                                              "'" + textBox1.Text + "', " +
                                              "'" + textBox2.Text + "', " +
                                              "'" + textBox3.Text + "', " +
                                              "'" + textBox4.Text + "', " +
                                              "'" + textBox5.Text + "', " +
                                              "'" + textBox6.Text + "', " +
                                              "'" + textBox7.Text + "')"; // 입력 쿼리문
                MessageBox.Show("접수가 완료 되었습니다");

                Application.OpenForms["Form2"].Close();
                cmd.ExecuteNonQuery(); // 실행

                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // 의사 리스트
            listBox1.Items.Add(this.comboBox1.SelectedItem.ToString()); // 콤보박스에서 선택한 아이템을 리스트박스에 추가

            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            switch (this.comboBox1.SelectedItem.ToString()) // 각 과 별 저장되어잇는 의사들을 출력
            {
                case "내과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='내과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {                    
                        string duty = sdr["doc_name"].ToString();

                        listBox1.Items.Add("내과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;

                case "외과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='외과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr2 = cmd.ExecuteReader();

                    while (sdr2.Read())
                    {
                        string duty = sdr2["doc_name"].ToString();

                        listBox1.Items.Add("외과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr2.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;

                case "정형외과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='정형외과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr3 = cmd.ExecuteReader();

                    while (sdr3.Read())
                    {
                        string duty = sdr3["doc_name"].ToString();
                        listBox1.Items.Add("정형외과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr3.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;

                case "이비인후과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='이비인후과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr4 = cmd.ExecuteReader();

                    while (sdr4.Read())
                    {
                        string duty = sdr4["doc_name"].ToString();
                        listBox1.Items.Add("이비인후과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr4.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;
                case "정신과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='정신과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr5 = cmd.ExecuteReader();

                    while (sdr5.Read())
                    {
                        string duty = sdr5["doc_name"].ToString();
                        listBox1.Items.Add("정신과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr5.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;
                case "안과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='안과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr6 = cmd.ExecuteReader();

                    while (sdr6.Read())
                    {
                        string duty = sdr6["doc_name"].ToString();
                        listBox1.Items.Add("안과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr6.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;

                case "피부과":
                    listBox1.Items.Clear();
                    cmd.CommandText = "select * from doctor where (doc_duty ='피부과')"; //쿼리문. 입력 값을 DB에서 검색
                    con.Open();
                    SqlDataReader sdr7 = cmd.ExecuteReader();

                    while (sdr7.Read())
                    {
                        string duty = sdr7["doc_name"].ToString();
                        listBox1.Items.Add("피부과 담당의사 " + duty); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                    }
                    sdr7.Close(); //연결 닫기 
                    con.Close(); //연결 닫기
                    break;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!listBox1.Text.Equals("")) //리스트 박스가 비어있지 않다면
            {
                string name = listBox1.Text;
                string[] a = name.Split(' ');
                textBox5.Text = a[2]; // 리스트 박스에서 이름만 가져오기
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.textBox6.Text = monthCalendar1.SelectionRange.Start.Date.ToShortDateString(); //Text에 선택 날짜 출력




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Close();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
