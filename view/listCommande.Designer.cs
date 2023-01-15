namespace view
{
    partial class listCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adresselivraiseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lignecmdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcmdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lignecmdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adresselivraiseDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.idclDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.commandeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // adresselivraiseDataGridViewTextBoxColumn
            // 
            this.adresselivraiseDataGridViewTextBoxColumn.DataPropertyName = "Adresse_livraise";
            this.adresselivraiseDataGridViewTextBoxColumn.HeaderText = "Adresse_livraise";
            this.adresselivraiseDataGridViewTextBoxColumn.Name = "adresselivraiseDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // idclDataGridViewTextBoxColumn
            // 
            this.idclDataGridViewTextBoxColumn.DataPropertyName = "Idcl";
            this.idclDataGridViewTextBoxColumn.HeaderText = "Idcl";
            this.idclDataGridViewTextBoxColumn.Name = "idclDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataSource = typeof(MODEL.Commande);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qteDataGridViewTextBoxColumn,
            this.idcmdeDataGridViewTextBoxColumn,
            this.idarteDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lignecmdBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // lignecmdBindingSource
            // 
            this.lignecmdBindingSource.DataSource = typeof(MODEL.Ligne_cmd);
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            // 
            // idcmdeDataGridViewTextBoxColumn
            // 
            this.idcmdeDataGridViewTextBoxColumn.DataPropertyName = "Id_cmde";
            this.idcmdeDataGridViewTextBoxColumn.HeaderText = "Id_cmde";
            this.idcmdeDataGridViewTextBoxColumn.Name = "idcmdeDataGridViewTextBoxColumn";
            // 
            // idarteDataGridViewTextBoxColumn
            // 
            this.idarteDataGridViewTextBoxColumn.DataPropertyName = "Id_arte";
            this.idarteDataGridViewTextBoxColumn.HeaderText = "Id_arte";
            this.idarteDataGridViewTextBoxColumn.Name = "idarteDataGridViewTextBoxColumn";
            // 
            // listCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listCommande";
            this.Text = "listCommande";
            this.Load += new System.EventHandler(this.listCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lignecmdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresselivraiseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcmdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lignecmdBindingSource;
    }
}