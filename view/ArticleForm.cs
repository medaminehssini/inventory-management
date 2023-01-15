using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using CONTROLLER;
namespace view
{
    public partial class ArticleForm : Form
    {
        public ArticleForm()
        {
            InitializeComponent();
        }

        ArticleADO artAdo;

        private void button1_Click(object sender, EventArgs e)
        {
            articleBindingSource.AddNew();
        }

        private void Article_Load(object sender, EventArgs e)
        {
            artAdo = new ArticleADO();
            artAdo.load();

            articleBindingSource.DataSource = artAdo.articleADOList;
        }



     


        private void button2_Click(object sender, EventArgs e)
        {
            Article art = new Article();
            art.Code = codeTextBox.Text.Trim();
            art.Designation = designationTextBox.Text.Trim();
            art.Prix_u = Decimal.Parse(prix_uTextBox.Text);
            art.Rayon = rayonTextBox.Text.Trim();
            art.Ss_rayon = ss_rayonTextBox.Text.Trim();

            artAdo.insert(art);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Article ar = (Article)articleBindingSource.Current;
            artAdo.update(ar);

            artAdo.load();

            articleBindingSource.DataSource = artAdo.articleADOList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Article ar = (Article)articleBindingSource.Current;
            artAdo.delete(ar);
            artAdo.load();

            articleBindingSource.DataSource = artAdo.articleADOList;
        }
    }
}
