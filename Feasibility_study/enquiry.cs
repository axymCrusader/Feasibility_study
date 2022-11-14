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
    public partial class enquiry : Form
    {
        public enquiry()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void enquiry_Load(object sender, EventArgs e)
        {
            var doc = PdfiumViewer.PdfDocument.Load("pdf24_merged.pdf");
            pdfViewer1.Document = doc;
        }
    }
}
