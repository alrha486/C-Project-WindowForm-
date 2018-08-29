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
    public partial class Form5 : Form // 의사 추가
    {
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 위치
        }

        private void 등록_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {  // 하나라도 입력하지 않았다면
                MessageBox.Show("데이터를 입력해주세요"); 
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.; Database = Hospital; Integrated Security = True");
                //SqlConnection con = new SqlConnection("data source = 210.123.254.87; uid = cs2-27; pwd = 1234; database = 병원");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open(); // DB연결 
                cmd.CommandText = "insert into doctor(doc_name, doc_age, doc_add, doc_ph, doc_duty)" +
                                                  "values(" + "'" + textBox1.Text + "', " +
                                                              "'" + textBox2.Text + "', " +
                                                              "'" + textBox3.Text + "', " +
                                                              "'" + textBox4.Text + "', " +
                                                              "'" + textBox5.Text + "')"; // 입력 쿼리문
                MessageBox.Show("추가가 완료 되었습니다"); // DB에 추가


                cmd.ExecuteNonQuery();


                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                Application.OpenForms["Form5"].Close();

            }
        }
    }
}
