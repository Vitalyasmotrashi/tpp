using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshCpp
{
    public partial class CshCppF : Form
    {
        CshCppGSA gsa = new CshCppGSA();
        public CshCppF()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            gsa.Gen(Int32.Parse(tbCI.Text));
        }

        private void btnCsh_Click(object sender, EventArgs e)
        {
            lblCsh.Text = gsa.SumCsh();
        }

        private void btnCpp_Click(object sender, EventArgs e)
        {
            lblCpp.Text = gsa.SumCppDLL();
        }

        private void btnXMM_Click(object sender, EventArgs e)
        {
            lblXMM.Text = gsa.SumCppDLLasm();
        }
    }
}
