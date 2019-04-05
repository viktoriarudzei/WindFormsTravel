namespace WindFormsTravel
{
    partial class Finder2
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
            this.clientNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
   
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxManagerSurname = new System.Windows.Forms.TextBox();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.dateTimePickerClient = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTDTBindingSource)).BeginInit();
    
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
            this.clientNAMEDataGridViewTextBoxColumn,
            this.clientSURNAMEDataGridViewTextBoxColumn,
            this.clientBORNDataGridViewTextBoxColumn,
            this.managerSURNAMEDataGridViewTextBoxColumn,
            this.orderNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTDTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // clientNAMEDataGridViewTextBoxColumn
            // 
            this.clientNAMEDataGridViewTextBoxColumn.DataPropertyName = "Client_NAME";
            this.clientNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.clientNAMEDataGridViewTextBoxColumn.Name = "clientNAMEDataGridViewTextBoxColumn";
            // 
            // clientSURNAMEDataGridViewTextBoxColumn
            // 
            this.clientSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "Client_SURNAME";
            this.clientSURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.clientSURNAMEDataGridViewTextBoxColumn.Name = "clientSURNAMEDataGridViewTextBoxColumn";
            // 
            // clientBORNDataGridViewTextBoxColumn
            // 
            this.clientBORNDataGridViewTextBoxColumn.DataPropertyName = "Client_BORN";
            this.clientBORNDataGridViewTextBoxColumn.HeaderText = "BORN";
            this.clientBORNDataGridViewTextBoxColumn.Name = "clientBORNDataGridViewTextBoxColumn";
            // 
            // managerSURNAMEDataGridViewTextBoxColumn
            // 
            this.managerSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "Manager_SURNAME";
            this.managerSURNAMEDataGridViewTextBoxColumn.HeaderText = "Manager_SURNAME";
            this.managerSURNAMEDataGridViewTextBoxColumn.Name = "managerSURNAMEDataGridViewTextBoxColumn";
            // 
            // orderNAMEDataGridViewTextBoxColumn
            // 
            this.orderNAMEDataGridViewTextBoxColumn.DataPropertyName = "Order_NAME";
            this.orderNAMEDataGridViewTextBoxColumn.HeaderText = "Order_NAME";
            this.orderNAMEDataGridViewTextBoxColumn.Name = "orderNAMEDataGridViewTextBoxColumn";
            // 
            // cLIENTDTBindingSource
            // 
            this.cLIENTDTBindingSource.DataMember = "CLIENT_DT";
       
            // 
            // dsLibrary1
            // 
         
            // 
            // clienT_DTTableAdapter1
            // 
          
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(136, 113);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxManagerSurname
            // 
            this.textBoxManagerSurname.Location = new System.Drawing.Point(511, 125);
            this.textBoxManagerSurname.Name = "textBoxManagerSurname";
            this.textBoxManagerSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxManagerSurname.TabIndex = 5;
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(511, 177);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderName.TabIndex = 6;
            // 
            // dateTimePickerClient
            // 
            this.dateTimePickerClient.Location = new System.Drawing.Point(411, 49);
            this.dateTimePickerClient.Name = "dateTimePickerClient";
            this.dateTimePickerClient.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerClient.TabIndex = 7;
            this.dateTimePickerClient.Value = new System.DateTime(2000, 7, 1, 18, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "SURNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "BORN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Manager_SURNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Order_NAME";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(42, 180);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(209, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Finder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 439);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerClient);
            this.Controls.Add(this.textBoxOrderName);
            this.Controls.Add(this.textBoxManagerSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Finder2";
            this.Text = "Finder2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTDTBindingSource)).EndInit();
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTDTBindingSource;
   
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxManagerSurname;
        private System.Windows.Forms.TextBox textBoxOrderName;
        private System.Windows.Forms.DateTimePicker dateTimePickerClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
    }
}