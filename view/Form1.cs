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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClientADO cltAdo; 

        private void Form1_Load(object sender, EventArgs e)
        {
           cltAdo = new ClientADO();
           cltAdo.load();

            clientBindingSource.DataSource = cltAdo.clientADOList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.Nom = nomTextBox.Text.Trim();
            cl.Prenom = prenomTextBox.Text.Trim();
            cl.Telephone = telephoneTextBox.Text.Trim();
            cl.Code_postal = Int32.Parse(code_postalTextBox.Text);
            cl.Adresse = adresseTextBox.Text.Trim();

            cltAdo.insert(cl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client cl = (Client)clientBindingSource.Current;
            cltAdo.delete(cl);
            cltAdo.load();

            clientBindingSource.DataSource= cltAdo.clientADOList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client cl = (Client)clientBindingSource.Current;
            cltAdo.update(cl);

            cltAdo.load();

            clientBindingSource.DataSource = cltAdo.clientADOList;
        }
    }
}
