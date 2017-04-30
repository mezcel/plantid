using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichotomousPlant
{
    public partial class frmCoverpage : Form
    {
        public frmCoverpage()
        {
            InitializeComponent();
        }

        private void coverpage_MouseClick(object sender, MouseEventArgs e)
        {
            frmDichotomy dicot = new frmDichotomy();
            dicot.StartPosition = FormStartPosition.Manual;
            dicot.Left = this.Left;
            dicot.Top = this.Top;

            dicot.Show();
            this.Visible = false;
        }
    }
}
