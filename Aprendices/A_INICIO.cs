using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendices
{
    public partial class A_INICIO : Form
    {
        public A_INICIO()
        {
            InitializeComponent();
        }

        private void b_JOIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_MENÚ A_frm = new A_MENÚ();
            A_frm.Show();
        }

        private void b_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
