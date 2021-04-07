using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battaglia_Navale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            play pl = new play();
            pl.Show();
            this.Hide();
        }
    }
}
