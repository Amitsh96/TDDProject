using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public Label RuntimeLabel // Add this property
        {
            get { return lbl_runTime; }
            set { lbl_runTime = value; }
        }

        private void lbl_runTime_Click(object sender, EventArgs e)
        {

        }
    }
}
