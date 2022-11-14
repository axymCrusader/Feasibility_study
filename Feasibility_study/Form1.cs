using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feasibility_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            about a1 = new about();
            a1.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_about.Visible = false;
            btn_start.Visible = false;
            btn_spravka.Visible = false;

            tabControl1.Visible=true;
        }
        private void btn_spravka_Click(object sender, EventArgs e)
        {
            enquiry pdf = new enquiry();
            pdf.Show();
        }
    }
}
