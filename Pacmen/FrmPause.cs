using System;
using System.Windows.Forms;

namespace Pacmen
{
    public partial class FrmPause : Form
    {
        public FrmPause()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
