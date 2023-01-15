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
    public partial class listCommande : Form
    {
        CommandeADO cmdAdo;
        public listCommande()
        {
            InitializeComponent();
        }

        private void listCommande_Load(object sender, EventArgs e)
        {
            cmdAdo = new CommandeADO();
            cmdAdo.load();

            commandeBindingSource.DataSource = cmdAdo.commandeADOList;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Commande commande = (Commande)commandeBindingSource.Current;
           lignecmdBindingSource.DataSource =  commande.Ligne;
        }
    }
}
