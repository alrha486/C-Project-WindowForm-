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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // 조회 버튼 누를 때 마다 비워주기

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from reservation"; //쿼리문
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader(); // DB 읽어주는 변수

            while (sdr.Read())
            {
                string dgv1 = sdr["section"].ToString();
                string dgv2 = sdr["name"].ToString();
                string dgv3 = sdr["p_num"].ToString();
                string dgv4 = sdr["p_add"].ToString();
                string dgv5 = sdr["ph"].ToString();
                string dgv6 = sdr["d_name"].ToString();
                string dgv7 = sdr["r_date"].ToString();
                string dgv8 = sdr["symptom"].ToString();
                dataGridView1.Rows.Add(dgv1, dgv2, dgv3, dgv4, dgv5, dgv6, dgv7, dgv8); // DB 저장 값 변수에 저장 후 리스트에 출력
            }
            sdr.Close(); // 연결 닫기
            con.Close(); // 연결 닫기
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");//DB 연결 변수
            SqlCommand cmd = new SqlCommand(); // 쿼리문 저장 변수
            cmd.Connection = con;
            con.Open();  // DB 연결
                         string s_delete = dataGridView1.CurrentCell.Value.ToString(); // dataGridView 리스트에서 선택 한 셀의 값
                         cmd.CommandText = "delete from reservation where name= " + "'" + s_delete + "'"; // 그 값을 DB에서 검색 후 삭제

             int i = dataGridView1.CurrentCell.RowIndex;  // 선택 한 셀이 몇번 째 행인지
              dataGridView1.Rows.Remove(dataGridView1.Rows[i]); // 행 삭제
            MessageBox.Show("예약이 취소되었습니다. 즐거운 하루 보내세요^^");
            cmd.ExecuteNonQuery(); // 실행
            con.Close(); // 연결 닫기
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1.CurrentCell.Value.ToString(); // 주민등록번호 선택

            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from reservation where (p_num =" + "'" + a + "')"; // 쿼리문
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                string db1 = sdr["section"].ToString();
                string db2 = sdr["name"].ToString();
                string db3 = sdr["P_num"].ToString();
                string db4 = sdr["p_add"].ToString();
                string db5 = sdr["ph"].ToString();
                string db6 = sdr["d_name"].ToString();
                string db7 = sdr["r_date"].ToString();
                string db8 = sdr["symptom"].ToString();

                textBox8.Text = db1; //
                textBox1.Text = db2;//
                textBox2.Text = db3;//
                textBox3.Text = db4;
                textBox4.Text = db5;   //읽어서 변수에 저장 후 리스트에 출력
                textBox5.Text = db6;
                textBox6.Text = db7;
                textBox7.Text = db8;
            }
            sdr.Close();
            con.Close();
        }
    }
}
