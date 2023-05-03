using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magaz
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butek1_Click(object sender, EventArgs e)
        {
            Form frm_cesit = new cesitler();
            bunifuTransition1.ShowSync(frm_cesit);
        }
    }
}
