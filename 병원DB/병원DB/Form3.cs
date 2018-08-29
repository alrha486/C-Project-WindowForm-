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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // 검색할 때 마다 리스트 비워주기
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || comboBox1.Text != "") //모든 정보입력했다면
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;
                string d = textBox4.Text;
                string f = comboBox1.Text;

                cmd.CommandText = "select * from doctor where (doc_name =" + "'" + a + "')or"
                    + "(doc_age =" + "'" + b + "')or"
                    + "(doc_add =" + "'" + c + "')or"
                    + "(doc_ph =" + "'" + d + "')or"
                    + "(doc_duty =" + "'" + f + "')"; // 쿼리문. 입력 값을 DB에서 검색
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5); // DB에서 읽어와 변수에 저장 후 리스트에 출력
                }
                sdr.Close(); //연결 닫기 
                con.Close(); //연결 닫기
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "") //직책 빼고 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;
                string d = textBox4.Text;

                cmd.CommandText = "select * from doctor where (doc_name =" + "'" + a + "')or"
                    + "(doc_age =" + "'" + b + "')or"
                    + "(doc_add =" + "'" + c + "')or"
                    + "(doc_ph =" + "'" + d + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") //핸드 폰번호, 직책 빼고 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;

                cmd.CommandText = "select * from doctor where (doc_name =" + "'" + a + "')or"
                    + "(doc_age =" + "'" + b + "')or"
                    + "(doc_add =" + "'" + c + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (textBox1.Text != "" && textBox2.Text != "") //주소, 핸드 폰번호, 직책 빼고 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox1.Text;
                string b = textBox2.Text;

                cmd.CommandText = "select * from doctor where (doc_name =" + "'" + a + "')or"
                    + "(doc_age =" + "'" + b + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (textBox1.Text != "") //이름만 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox1.Text;

                cmd.CommandText = "select * from doctor where (doc_name =" + "'" + a + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (textBox3.Text != "") //주소만 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox3.Text;

                cmd.CommandText = "select * from doctor where (doc_add =" + "'" + a + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (textBox2.Text != "") //나이만 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox2.Text;

                cmd.CommandText = "select * from doctor where (doc_age =" + "'" + a + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (textBox4.Text != "") //전화번호만 입력
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = textBox4.Text;

                cmd.CommandText = "select * from doctor where (doc_ph =" + "'" + a + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else if (comboBox1.Text != "") //직책만 입력
            {

                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                string a = comboBox1.Text;

                cmd.CommandText = "select * from doctor where (doc_duty =" + "'" + a + "')";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string db1 = sdr["doc_name"].ToString();
                    string db2 = sdr["doc_age"].ToString();
                    string db3 = sdr["doc_add"].ToString();
                    string db4 = sdr["doc_ph"].ToString();
                    string db5 = sdr["doc_duty"].ToString();

                    dataGridView1.Rows.Add(db1, db2, db3, db4, db5);
                }
                sdr.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("검색 할 정보를 입력해주세요.");
            }
        }

        private void allView_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // 리스트 비워주기

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from doctor"; // 쿼리문 
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                string db1 = sdr["doc_name"].ToString();
                string db2 = sdr["doc_age"].ToString();
                string db3 = sdr["doc_add"].ToString();
                string db4 = sdr["doc_ph"].ToString();
                string db5 = sdr["doc_duty"].ToString();

                dataGridView1.Rows.Add(db1, db2, db3, db4, db5); // DB 읽어서 변수에 저장 후 리스트에 출력
            }
            sdr.Close(); //연결 닫기
            con.Close(); //연결 닫기
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //새로운 폼 생성 : 의사 추가
            form5.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1.CurrentCell.Value.ToString(); // 이름 선택

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from doctor where (doc_name =" + "'" + a + "')"; // 쿼리문
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                string db1 = sdr["doc_name"].ToString();
                string db2 = sdr["doc_age"].ToString();
                string db3 = sdr["doc_add"].ToString();
                string db4 = sdr["doc_ph"].ToString();
                string db5 = sdr["doc_duty"].ToString();

                textBox10.Text = db1;
                textBox8.Text = db2;
                textBox6.Text = db3;
                textBox9.Text = db5;
                textBox7.Text = db4;   //읽어서 변수에 저장 후 리스트에 출력
                pictureBox1.ImageLocation = "C:/Users/diat/Desktop/의사/" + db1 + ".jpg"; // 의사 이름에 따른 사진 출력
            }
            sdr.Close();
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");//DB 연결 변수
            SqlCommand cmd = new SqlCommand(); // 쿼리문 저장 변수
            cmd.Connection = con;
            con.Open();  // DB 연결
            string s_delete = dataGridView1.CurrentCell.Value.ToString(); // dataGridView 리스트에서 선택 한 셀의 값
            cmd.CommandText = "delete from doctor where doc_name= " + "'" + s_delete + "'"; // 그 값을 DB에서 검색 후 삭제

            int i = dataGridView1.CurrentCell.RowIndex;  // 선택 한 셀이 몇번 째 행인지
            dataGridView1.Rows.Remove(dataGridView1.Rows[i]); // 행 삭제
            MessageBox.Show("삭제되었습니다.");

            cmd.ExecuteNonQuery(); // 실행
            con.Close(); // 연결 닫기
        }
    }
}
