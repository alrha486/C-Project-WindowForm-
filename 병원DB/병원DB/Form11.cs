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
    public partial class Form11 : Form
    {
        public Form11()
        {
            this.StartPosition = FormStartPosition.CenterScreen; // 중앙에 위치
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
