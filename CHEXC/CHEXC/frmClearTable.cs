using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHEXC
{
    public partial class frmClearTable : Form
    {
        public frmClearTable()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           

       
            MessageBox.Show("磁盘清理成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
