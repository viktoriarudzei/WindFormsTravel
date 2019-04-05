namespace WindFormsTravel
{
    partial class Finder3
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
            this.mANAGERDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
     
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.textBoxFilialN = new System.Windows.Forms.TextBox();
            this.textBoxOrderN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.managerSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerRANKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filialNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGERDTBindingSource)).BeginInit();
      
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerSURNAMEDataGridViewTextBoxColumn,
            this.managerRANKDataGridViewTextBoxColumn,
            this.filialNAMEDataGridViewTextBoxColumn,
            this.orderNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mANAGERDTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // mANAGERDTBindingSource
            // 
            this.mANAGERDTBindingSource.DataMember = "MANAGER_DT";
   
            // 
            // dsLibrary1
            // 
          
            // 
            // manageR_DTTableAdapter1
            // 
      
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(148, 48);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxRank
            // 
            this.textBoxRank.Location = new System.Drawing.Point(148, 118);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(100, 22);
            this.textBoxRank.TabIndex = 5;
            // 
            // textBoxFilialN
            // 
            this.textBoxFilialN.Location = new System.Drawing.Point(450, 48);
            this.textBoxFilialN.Name = "textBoxFilialN";
            this.textBoxFilialN.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilialN.TabIndex = 6;
            // 
            // textBoxOrderN
            // 
            this.textBoxOrderN.Location = new System.Drawing.Point(450, 118);
            this.textBoxOrderN.Name = "textBoxOrderN";
            this.textBoxOrderN.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderN.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "SURNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "RANK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "NAME FILIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "NAME ORDER";
            // 
            // managerSURNAMEDataGridViewTextBoxColumn
            // 
            this.managerSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "Manager_SURNAME";
            this.managerSURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.managerSURNAMEDataGridViewTextBoxColumn.Name = "managerSURNAMEDataGridViewTextBoxColumn";
            // 
            // managerRANKDataGridViewTextBoxColumn
            // 
            this.managerRANKDataGridViewTextBoxColumn.DataPropertyName = "Manager_RANK";
            this.managerRANKDataGridViewTextBoxColumn.HeaderText = "RANK";
            this.managerRANKDataGridViewTextBoxColumn.Name = "managerRANKDataGridViewTextBoxColumn";
            // 
            // filialNAMEDataGridViewTextBoxColumn
            // 
            this.filialNAMEDataGridViewTextBoxColumn.DataPropertyName = "Filial_NAME";
            this.filialNAMEDataGridViewTextBoxColumn.HeaderText = "NAME FILIAL";
            this.filialNAMEDataGridViewTextBoxColumn.Name = "filialNAMEDataGridViewTextBoxColumn";
            // 
            // orderNAMEDataGridViewTextBoxColumn
            // 
            this.orderNAMEDataGridViewTextBoxColumn.DataPropertyName = "Order_NAME";
            this.orderNAMEDataGridViewTextBoxColumn.HeaderText = "NAME ORDER";
            this.orderNAMEDataGridViewTextBoxColumn.Name = "orderNAMEDataGridViewTextBoxColumn";
            // 
            // Finder3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 439);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrderN);
            this.Controls.Add(this.textBoxFilialN);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Finder3";
            this.Text = "Finder3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGERDTBindingSource)).EndInit();
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mANAGERDTBindingSource;
   
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.TextBox textBoxFilialN;
        private System.Windows.Forms.TextBox textBoxOrderN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerRANKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filialNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNAMEDataGridViewTextBoxColumn;
    }
}