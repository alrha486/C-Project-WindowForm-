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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 위치
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True"); // DB연결
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); // DB 연결

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("데이터를 입력해주세요"); // 하나라도 비어있다면 오류메시지
            }
            else
            { //다 입력했다면
                cmd.CommandText = "insert into member(m_name, m_num, m_add, m_age, m_ph, m_id, m_pw)" +
                                                  "values(" + "'" + textBox1.Text + "', " +
                                                              "'" + textBox2.Text + "', " +
                                                              "'" + textBox3.Text + "', " +
                                                              "'" + textBox4.Text + "', " +
                                                              "'" + textBox5.Text + "', " +
                                                              "'" + textBox6.Text + "', " +
                                                              "'" + textBox7.Text + "')"; // 회원가입 정보를 DB에 저장
                MessageBox.Show("회원가입이 완료 되었습니다");

                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();


                Application.OpenForms["Form9"].Close(); // 폼9를 닫아준다.

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }