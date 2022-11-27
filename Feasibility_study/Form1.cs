using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private void Calc_KTC_Click(object sender, EventArgs e)
        {
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double incom1, incom2, incom3;
                double.TryParse((row.Cells[3].Value ?? "0").ToString().Replace(".", ","), out incom1);
                double.TryParse((row.Cells[5].Value ?? "0").ToString().Replace(".", ","), out incom2);
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom3);
                sum1 += incom1;
                sum2 += incom2;
                sum3 += incom3;
            }
            if (sum3 != 1)
            { 
                MessageBox.Show("Коэффициент весомости не равен 1"); 
            }
            else
            {
                outJetpro.Text = sum1.ToString();
                outJetana.Text = sum2.ToString();
                sum1 = sum1 / sum2;
                sum1 = Math.Round(sum1, 2);
                outak.Text = sum1.ToString();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double incom1, incom2, incom3;
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom2);
                double.TryParse((row.Cells[4].Value ?? "0").ToString().Replace(".", ","), out incom3);
                row.Cells[3].Value = incom1 * incom2;
                row.Cells[5].Value = incom1 * incom3;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].IsInEditMode ||
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].IsInEditMode) 
            {
                if ((e.KeyChar <= 48 || e.KeyChar >= 54) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }

            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }
    }
}
