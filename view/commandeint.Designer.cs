namespace view
{
    partial class commandeint
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
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label adresse_livraiseLabel;
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.nomLabel1 = new System.Windows.Forms.Label();
            this.prenomLabel1 = new System.Windows.Forms.Label();
            this.clientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adresse_livraiseTextBox = new System.Windows.Forms.TextBox();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.ligneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designationLabel1 = new System.Windows.Forms.Label();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.qteBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ligne_cmdDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            adresse_livraiseLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ligne_cmdDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new System.Drawing.Point(34, 23);
            numLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(32, 13);
            numLabel.TabIndex = 1;
            numLabel.Text = "Num:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(47, 142);
            nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 4;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(22, 128);
            prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 6;
            prenomLabel.Text = "Prenom:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(573, 27);
            dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Date:";
            // 
            // adresse_livraiseLabel
            // 
            adresse_livraiseLabel.AutoSize = true;
            adresse_livraiseLabel.Location = new System.Drawing.Point(277, 24);
            adresse_livraiseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adresse_livraiseLabel.Name = "adresse_livraiseLabel";
            adresse_livraiseLabel.Size = new System.Drawing.Size(83, 13);
            adresse_livraiseLabel.TabIndex = 9;
            adresse_livraiseLabel.Text = "Adresse livraise:";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.BackColor = System.Drawing.Color.Transparent;
            designationLabel.Location = new System.Drawing.Point(465, 189);
            designationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 12;
            designationLabel.Text = "Designation:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(465, 142);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(380, 262);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 13);
            label1.TabIndex = 20;
            label1.Text = "Qte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(465, 95);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 13);
            label2.TabIndex = 22;
            label2.Text = "Article :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 98);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 13);
            label3.TabIndex = 23;
            label3.Text = "Client :";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(81, 20);
            this.numTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(179, 20);
            this.numTextBox.TabIndex = 2;
            this.numTextBox.TextChanged += new System.EventHandler(this.numTextBox_TextChanged);
            // 
            // nomLabel1
            // 
            this.nomLabel1.Location = new System.Drawing.Point(102, 142);
            this.nomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomLabel1.Name = "nomLabel1";
            this.nomLabel1.Size = new System.Drawing.Size(75, 19);
            this.nomLabel1.TabIndex = 5;
            this.nomLabel1.Text = "label1";
            this.nomLabel1.Click += new System.EventHandler(this.nomLabel1_Click);
            // 
            // prenomLabel1
            // 
            this.prenomLabel1.Location = new System.Drawing.Point(77, 128);
            this.prenomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenomLabel1.Name = "prenomLabel1";
            this.prenomLabel1.Size = new System.Drawing.Size(75, 19);
            this.prenomLabel1.TabIndex = 7;
            this.prenomLabel1.Text = "label1";
            // 
            // clientBindingSource3
            // 
            this.clientBindingSource3.DataSource = typeof(MODEL.Client);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource3;
            this.clientComboBox.DisplayMember = "Prenom";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(105, 95);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(226, 21);
            this.clientComboBox.TabIndex = 7;
            this.clientComboBox.ValueMember = "Adresse";
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.clientComboBox_SelectedIndexChanged_1);
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataSource = typeof(MODEL.Commande);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.commandeBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(627, 21);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // adresse_livraiseTextBox
            // 
            this.adresse_livraiseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commandeBindingSource, "Adresse_livraise", true));
            this.adresse_livraiseTextBox.Location = new System.Drawing.Point(383, 21);
            this.adresse_livraiseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adresse_livraiseTextBox.Name = "adresse_livraiseTextBox";
            this.adresse_livraiseTextBox.Size = new System.Drawing.Size(175, 20);
            this.adresse_livraiseTextBox.TabIndex = 10;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MODEL.Article);
            // 
            // articleBindingSource1
            // 
            this.articleBindingSource1.DataSource = typeof(MODEL.Article);
            // 
            // articleComboBox
            // 
            this.articleComboBox.DataSource = this.articleBindingSource1;
            this.articleComboBox.DisplayMember = "Designation";
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(590, 92);
            this.articleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(226, 21);
            this.articleComboBox.TabIndex = 11;
            this.articleComboBox.ValueMember = "Code";
            this.articleComboBox.SelectedIndexChanged += new System.EventHandler(this.articleComboBox_SelectedIndexChanged);
            // 
            // ligneBindingSource
            // 
            this.ligneBindingSource.DataMember = "Ligne";
            this.ligneBindingSource.DataSource = this.commandeBindingSource;
            // 
            // designationLabel1
            // 
            this.designationLabel1.BackColor = System.Drawing.Color.Transparent;
            this.designationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource1, "Designation", true));
            this.designationLabel1.Location = new System.Drawing.Point(587, 183);
            this.designationLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.designationLabel1.Name = "designationLabel1";
            this.designationLabel1.Size = new System.Drawing.Size(75, 19);
            this.designationLabel1.TabIndex = 13;
            this.designationLabel1.Text = "label1";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource1, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(587, 142);
            this.idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(75, 19);
            this.idLabel1.TabIndex = 15;
            this.idLabel1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(653, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(726, 555);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 22);
            this.button3.TabIndex = 18;
            this.button3.Text = "enregistrer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // qteBox
            // 
            this.qteBox.Location = new System.Drawing.Point(440, 259);
            this.qteBox.Margin = new System.Windows.Forms.Padding(2);
            this.qteBox.Name = "qteBox";
            this.qteBox.Size = new System.Drawing.Size(183, 20);
            this.qteBox.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(440, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 174);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.prenomLabel1);
            this.panel2.Controls.Add(prenomLabel);
            this.panel2.Location = new System.Drawing.Point(25, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 174);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Location = new System.Drawing.Point(25, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 42);
            this.panel3.TabIndex = 26;
            // 
            // ligne_cmdDataGridView
            // 
            this.ligne_cmdDataGridView.AutoGenerateColumns = false;
            this.ligne_cmdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ligne_cmdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ligne_cmdDataGridView.DataSource = this.ligneBindingSource;
            this.ligne_cmdDataGridView.Location = new System.Drawing.Point(25, 330);
            this.ligne_cmdDataGridView.Name = "ligne_cmdDataGridView";
            this.ligne_cmdDataGridView.Size = new System.Drawing.Size(804, 220);
            this.ligne_cmdDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_art";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id Article";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "designation";
            this.dataGridViewTextBoxColumn4.HeaderText = "designation";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Qte";
            this.dataGridViewTextBoxColumn1.HeaderText = "Qte";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn6.HeaderText = "prix";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "prixT";
            this.dataGridViewTextBoxColumn7.HeaderText = "prix Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // commandeint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 592);
            this.Controls.Add(this.ligne_cmdDataGridView);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.qteBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationLabel1);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(adresse_livraiseLabel);
            this.Controls.Add(this.adresse_livraiseTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomLabel1);
            this.Controls.Add(numLabel);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "commandeint";
            this.Text = "commandeint";
            this.Load += new System.EventHandler(this.commandeint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ligne_cmdDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Label nomLabel1;
        private System.Windows.Forms.Label prenomLabel1;
        private System.Windows.Forms.BindingSource clientBindingSource3;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox adresse_livraiseTextBox;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.BindingSource articleBindingSource1;
        private System.Windows.Forms.ComboBox articleComboBox;
        private System.Windows.Forms.Label designationLabel1;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource ligneBindingSource;
        private System.Windows.Forms.TextBox qteBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ligne_cmdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}