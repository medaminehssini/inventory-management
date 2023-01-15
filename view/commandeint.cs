using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLLER;
using MODEL;

namespace view
{
    public partial class commandeint : Form
    {
        Commande cmd = new Commande();
        public commandeint()
        {
            InitializeComponent();
        }
      
        private void commandeint_Load(object sender, EventArgs e)
        {
            ClientADO c = new ClientADO();
            c.load();
            clientBindingSource3.DataSource = c.clientADOList;

            ArticleADO A = new ArticleADO();
            A.load();
            articleBindingSource1.DataSource = A.articleADOList;
        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void nomLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void clientComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Client cl = clientComboBox.SelectedItem as Client;
            nomLabel1.Text = cl.Nom;
            prenomLabel1.Text=cl.Prenom;
            idLabel1.Text = cl.Id.ToString();
        }


        private void articleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Article Ar = articleComboBox.SelectedItem as Article;
           // idLabel1.Text = Ar.Id.ToString();
           // designationLabel1.Text = Ar.Designation;
        }

        private void button1_Click(object sender, EventArgs e)
        {

             Ligne_cmd lc = new Ligne_cmd();
             Article ac  =(Article)articleBindingSource1.Current;

             lc.Qte     = Int32.Parse(qteBox.Text);
             lc.Id_article = ac;

            cmd.Ligne.Add(lc);
            ligneBindingSource.ResetBindings(true);
            ligneBindingSource.DataSource = cmd.Ligne;
            Console.WriteLine(cmd.Ligne.Count);
            
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Console.WriteLine(cmd.Ligne.Count);

            Client cl = (Client)clientBindingSource3.Current;
            cmd.Idcl = cl.Id;
            cmd.Adresse_livraise
                = adresse_livraiseTextBox.Text;
            cmd.Date = dateDateTimePicker.Value;
            cmd.Num = Int32.Parse( numTextBox.Text);
            CommandeADO cmdo = new CommandeADO();
            
            cmdo.insert(cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ligneBindingSource.RemoveCurrent();
        }

        private void numTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
