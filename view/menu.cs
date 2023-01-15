using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ArticleForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new commandeint().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new listCommande().ShowDialog();
        }
    }
}
