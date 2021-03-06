﻿namespace WindFormsTravel
{
    partial class Finder
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
            this.oRDERDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLibrary1 = new ClassLibrary.DSLibrary();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxManagerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ordeR_DTTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.ORDER_DTTableAdapter();
            this.orderNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibrary1)).BeginInit();
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
            this.orderNAMEDataGridViewTextBoxColumn,
            this.orderPRICEDataGridViewTextBoxColumn,
            this.orderDURATIONDataGridViewTextBoxColumn,
            this.destinationNAMEDataGridViewTextBoxColumn,
            this.clientNAMEDataGridViewTextBoxColumn,
            this.managerNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oRDERDTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // oRDERDTBindingSource
            // 
            this.oRDERDTBindingSource.DataMember = "ORDER_DT";
            this.oRDERDTBindingSource.DataSource = this.dsLibrary1;
            // 
            // dsLibrary1
            // 
            this.dsLibrary1.DataSetName = "DSLibrary";
            this.dsLibrary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(171, 37);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(171, 97);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(171, 151);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 22);
            this.textBoxDuration.TabIndex = 3;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(477, 37);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(100, 22);
            this.textBoxDestination.TabIndex = 4;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(477, 97);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientName.TabIndex = 5;
            // 
            // textBoxManagerName
            // 
            this.textBoxManagerName.Location = new System.Drawing.Point(477, 151);
            this.textBoxManagerName.Name = "textBoxManagerName";
            this.textBoxManagerName.Size = new System.Drawing.Size(100, 22);
            this.textBoxManagerName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME ORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "DURATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "DESTINATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "NAME CLIENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "NAME MANAGER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordeR_DTTableAdapter1
            // 
            this.ordeR_DTTableAdapter1.ClearBeforeFill = true;
            // 
            // orderNAMEDataGridViewTextBoxColumn
            // 
            this.orderNAMEDataGridViewTextBoxColumn.DataPropertyName = "Order_NAME";
            this.orderNAMEDataGridViewTextBoxColumn.HeaderText = "NAME ORDER";
            this.orderNAMEDataGridViewTextBoxColumn.Name = "orderNAMEDataGridViewTextBoxColumn";
            // 
            // orderPRICEDataGridViewTextBoxColumn
            // 
            this.orderPRICEDataGridViewTextBoxColumn.DataPropertyName = "Order_PRICE";
            this.orderPRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.orderPRICEDataGridViewTextBoxColumn.Name = "orderPRICEDataGridViewTextBoxColumn";
            // 
            // orderDURATIONDataGridViewTextBoxColumn
            // 
            this.orderDURATIONDataGridViewTextBoxColumn.DataPropertyName = "Order_DURATION";
            this.orderDURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.orderDURATIONDataGridViewTextBoxColumn.Name = "orderDURATIONDataGridViewTextBoxColumn";
            // 
            // destinationNAMEDataGridViewTextBoxColumn
            // 
            this.destinationNAMEDataGridViewTextBoxColumn.DataPropertyName = "Destination_NAME";
            this.destinationNAMEDataGridViewTextBoxColumn.HeaderText = "DESTINATION";
            this.destinationNAMEDataGridViewTextBoxColumn.Name = "destinationNAMEDataGridViewTextBoxColumn";
            // 
            // clientNAMEDataGridViewTextBoxColumn
            // 
            this.clientNAMEDataGridViewTextBoxColumn.DataPropertyName = "Client_NAME";
            this.clientNAMEDataGridViewTextBoxColumn.HeaderText = "NAME CLIENT";
            this.clientNAMEDataGridViewTextBoxColumn.Name = "clientNAMEDataGridViewTextBoxColumn";
            // 
            // managerNAMEDataGridViewTextBoxColumn
            // 
            this.managerNAMEDataGridViewTextBoxColumn.DataPropertyName = "Manager_NAME";
            this.managerNAMEDataGridViewTextBoxColumn.HeaderText = "NAME MANAGER";
            this.managerNAMEDataGridViewTextBoxColumn.Name = "managerNAMEDataGridViewTextBoxColumn";
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxManagerName);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxOrderName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Finder";
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.Finder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibrary1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oRDERDTBindingSource;
        private System.Windows.Forms.TextBox textBoxOrderName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxManagerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private ClassLibrary.DSLibrary dsLibrary1;
        private ClassLibrary.DSLibraryTableAdapters.ORDER_DTTableAdapter ordeR_DTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNAMEDataGridViewTextBoxColumn;
    }
}