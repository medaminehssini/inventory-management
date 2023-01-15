namespace view
{
    partial class ArticleForm
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label prix_uLabel;
            System.Windows.Forms.Label rayonLabel;
            System.Windows.Forms.Label ss_rayonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleForm));
            this.articleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.articleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.articleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.prix_uTextBox = new System.Windows.Forms.TextBox();
            this.rayonTextBox = new System.Windows.Forms.TextBox();
            this.ss_rayonTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            codeLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            prix_uLabel = new System.Windows.Forms.Label();
            rayonLabel = new System.Windows.Forms.Label();
            ss_rayonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingNavigator)).BeginInit();
            this.articleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(41, 37);
            codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(41, 72);
            designationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 4;
            designationLabel.Text = "Designation:";
            // 
            // prix_uLabel
            // 
            prix_uLabel.AutoSize = true;
            prix_uLabel.Location = new System.Drawing.Point(41, 106);
            prix_uLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prix_uLabel.Name = "prix_uLabel";
            prix_uLabel.Size = new System.Drawing.Size(36, 13);
            prix_uLabel.TabIndex = 6;
            prix_uLabel.Text = "Prix u:";
            // 
            // rayonLabel
            // 
            rayonLabel.AutoSize = true;
            rayonLabel.Location = new System.Drawing.Point(41, 147);
            rayonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rayonLabel.Name = "rayonLabel";
            rayonLabel.Size = new System.Drawing.Size(41, 13);
            rayonLabel.TabIndex = 8;
            rayonLabel.Text = "Rayon:";
            // 
            // ss_rayonLabel
            // 
            ss_rayonLabel.AutoSize = true;
            ss_rayonLabel.Location = new System.Drawing.Point(41, 186);
            ss_rayonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ss_rayonLabel.Name = "ss_rayonLabel";
            ss_rayonLabel.Size = new System.Drawing.Size(51, 13);
            ss_rayonLabel.TabIndex = 10;
            ss_rayonLabel.Text = "Ss rayon:";
            // 
            // articleBindingNavigator
            // 
            this.articleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articleBindingNavigator.BindingSource = this.articleBindingSource;
            this.articleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.articleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.articleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.articleBindingNavigatorSaveItem});
            this.articleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.articleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.articleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.articleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articleBindingNavigator.Name = "articleBindingNavigator";
            this.articleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.articleBindingNavigator.Size = new System.Drawing.Size(600, 27);
            this.articleBindingNavigator.TabIndex = 0;
            this.articleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MODEL.Article);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // articleBindingNavigatorSaveItem
            // 
            this.articleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articleBindingNavigatorSaveItem.Enabled = false;
            this.articleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articleBindingNavigatorSaveItem.Image")));
            this.articleBindingNavigatorSaveItem.Name = "articleBindingNavigatorSaveItem";
            this.articleBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.articleBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // articleDataGridView
            // 
            this.articleDataGridView.AutoGenerateColumns = false;
            this.articleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.articleDataGridView.DataSource = this.articleBindingSource;
            this.articleDataGridView.Location = new System.Drawing.Point(9, 265);
            this.articleDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.articleDataGridView.Name = "articleDataGridView";
            this.articleDataGridView.RowHeadersWidth = 51;
            this.articleDataGridView.RowTemplate.Height = 24;
            this.articleDataGridView.Size = new System.Drawing.Size(582, 179);
            this.articleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prix_u";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix_u";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rayon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rayon";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ss_rayon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ss_rayon";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(107, 37);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(76, 20);
            this.codeTextBox.TabIndex = 3;
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(107, 69);
            this.designationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(76, 20);
            this.designationTextBox.TabIndex = 5;
            // 
            // prix_uTextBox
            // 
            this.prix_uTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Prix_u", true));
            this.prix_uTextBox.Location = new System.Drawing.Point(107, 106);
            this.prix_uTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prix_uTextBox.Name = "prix_uTextBox";
            this.prix_uTextBox.Size = new System.Drawing.Size(76, 20);
            this.prix_uTextBox.TabIndex = 7;
            // 
            // rayonTextBox
            // 
            this.rayonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Rayon", true));
            this.rayonTextBox.Location = new System.Drawing.Point(107, 147);
            this.rayonTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rayonTextBox.Name = "rayonTextBox";
            this.rayonTextBox.Size = new System.Drawing.Size(76, 20);
            this.rayonTextBox.TabIndex = 9;
            // 
            // ss_rayonTextBox
            // 
            this.ss_rayonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Ss_rayon", true));
            this.ss_rayonTextBox.Location = new System.Drawing.Point(107, 186);
            this.ss_rayonTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ss_rayonTextBox.Name = "ss_rayonTextBox";
            this.ss_rayonTextBox.Size = new System.Drawing.Size(76, 20);
            this.ss_rayonTextBox.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(484, 126);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 25);
            this.button4.TabIndex = 19;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(484, 99);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 22);
            this.button3.TabIndex = 18;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(484, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(484, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 24);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(ss_rayonLabel);
            this.Controls.Add(this.ss_rayonTextBox);
            this.Controls.Add(rayonLabel);
            this.Controls.Add(this.rayonTextBox);
            this.Controls.Add(prix_uLabel);
            this.Controls.Add(this.prix_uTextBox);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.articleDataGridView);
            this.Controls.Add(this.articleBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArticleForm";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.Article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingNavigator)).EndInit();
            this.articleBindingNavigator.ResumeLayout(false);
            this.articleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.BindingNavigator articleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton articleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView articleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.TextBox prix_uTextBox;
        private System.Windows.Forms.TextBox rayonTextBox;
        private System.Windows.Forms.TextBox ss_rayonTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}