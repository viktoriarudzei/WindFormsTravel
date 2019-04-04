namespace WindFormsTravel
{
    partial class FormTrip
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOwners = new System.Windows.Forms.TabPage();
            this.buttonOwnersDelete = new System.Windows.Forms.Button();
            this.buttonOwnersSave = new System.Windows.Forms.Button();
            this.dataGridViewOWNER = new System.Windows.Forms.DataGridView();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oWNERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLibrary1 = new ClassLibrary.DSLibrary();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.buttonCompanyDelete = new System.Windows.Forms.Button();
            this.buttonCompanySave = new System.Windows.Forms.Button();
            this.dataGridViewCOMPANY = new System.Windows.Forms.DataGridView();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyOWNERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OWNERS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabFilial = new System.Windows.Forms.TabPage();
            this.buttonFilialDelete = new System.Windows.Forms.Button();
            this.buttonFilialSave = new System.Windows.Forms.Button();
            this.dataGridViewFILIAL = new System.Windows.Forms.DataGridView();
            this.filialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filialNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.filialLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filialCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabManagers = new System.Windows.Forms.TabPage();
            this.buttonManagS = new System.Windows.Forms.Button();
            this.buttonManagersDelete = new System.Windows.Forms.Button();
            this.buttonManagersSave = new System.Windows.Forms.Button();
            this.dataGridViewMANAGERS = new System.Windows.Forms.DataGridView();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerRANKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.managerFILIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANAGERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabClients = new System.Windows.Forms.TabPage();
            this.buttonClientsSearch = new System.Windows.Forms.Button();
            this.buttonClientsDelete = new System.Windows.Forms.Button();
            this.buttonClientsSave = new System.Windows.Forms.Button();
            this.dataGridViewCLIENTS = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBORNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.buttonOrderSearch = new System.Windows.Forms.Button();
            this.buttonOrdersDelete = new System.Windows.Forms.Button();
            this.buttonOrdersSave = new System.Windows.Forms.Button();
            this.dataGridViewORDERS = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dESTINATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderMANAGERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDESTINATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDestination = new System.Windows.Forms.TabPage();
            this.buttonDestinationDelete = new System.Windows.Forms.Button();
            this.buttonDestinatioSave = new System.Windows.Forms.Button();
            this.dataGridViewDESTINATION = new System.Windows.Forms.DataGridView();
            this.destinationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownersTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.OWNERSTableAdapter();
            this.companyTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.COMPANYTableAdapter();
            this.filialTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.FILIALTableAdapter();
            this.managersTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.MANAGERSTableAdapter();
            this.clientsTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.CLIENTSTableAdapter();
            this.ordersTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.ORDERSTableAdapter();
            this.destinationTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.DESTINATIONTableAdapter();
            this.destinationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queriesTableAdapter1 = new ClassLibrary.DSLibraryTableAdapters.QueriesTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOWNER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oWNERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibrary1)).BeginInit();
            this.tabCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCOMPANY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).BeginInit();
            this.tabFilial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFILIAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILIALBindingSource)).BeginInit();
            this.tabManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMANAGERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGERSBindingSource)).BeginInit();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLIENTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewORDERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            this.tabDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDESTINATION)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabOwners);
            this.tabControl.Controls.Add(this.tabCompany);
            this.tabControl.Controls.Add(this.tabFilial);
            this.tabControl.Controls.Add(this.tabManagers);
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Controls.Add(this.tabDestination);
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(558, 350);
            this.tabControl.TabIndex = 0;
            // 
            // tabOwners
            // 
            this.tabOwners.Controls.Add(this.buttonOwnersDelete);
            this.tabOwners.Controls.Add(this.buttonOwnersSave);
            this.tabOwners.Controls.Add(this.dataGridViewOWNER);
            this.tabOwners.Location = new System.Drawing.Point(4, 25);
            this.tabOwners.Name = "tabOwners";
            this.tabOwners.Padding = new System.Windows.Forms.Padding(3);
            this.tabOwners.Size = new System.Drawing.Size(550, 321);
            this.tabOwners.TabIndex = 0;
            this.tabOwners.Text = "Owners";
            this.tabOwners.UseVisualStyleBackColor = true;
            // 
            // buttonOwnersDelete
            // 
            this.buttonOwnersDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonOwnersDelete.Name = "buttonOwnersDelete";
            this.buttonOwnersDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonOwnersDelete.TabIndex = 2;
            this.buttonOwnersDelete.Text = "Delete";
            this.buttonOwnersDelete.UseVisualStyleBackColor = true;
            this.buttonOwnersDelete.Click += new System.EventHandler(this.buttonOwnersDelete_Click);
            // 
            // buttonOwnersSave
            // 
            this.buttonOwnersSave.Location = new System.Drawing.Point(17, 7);
            this.buttonOwnersSave.Name = "buttonOwnersSave";
            this.buttonOwnersSave.Size = new System.Drawing.Size(75, 23);
            this.buttonOwnersSave.TabIndex = 1;
            this.buttonOwnersSave.Text = "Save";
            this.buttonOwnersSave.UseVisualStyleBackColor = true;
            this.buttonOwnersSave.Click += new System.EventHandler(this.buttonOwnersSave_Click);
            // 
            // dataGridViewOWNER
            // 
            this.dataGridViewOWNER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOWNER.AutoGenerateColumns = false;
            this.dataGridViewOWNER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOWNER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerIDDataGridViewTextBoxColumn,
            this.ownerNAMEDataGridViewTextBoxColumn,
            this.ownerSURNAMEDataGridViewTextBoxColumn});
            this.dataGridViewOWNER.DataSource = this.oWNERSBindingSource;
            this.dataGridViewOWNER.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewOWNER.Name = "dataGridViewOWNER";
            this.dataGridViewOWNER.RowTemplate.Height = 24;
            this.dataGridViewOWNER.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewOWNER.TabIndex = 0;
            this.dataGridViewOWNER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "Owner_ID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "Owner_ID";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            this.ownerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerNAMEDataGridViewTextBoxColumn
            // 
            this.ownerNAMEDataGridViewTextBoxColumn.DataPropertyName = "Owner_NAME";
            this.ownerNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.ownerNAMEDataGridViewTextBoxColumn.Name = "ownerNAMEDataGridViewTextBoxColumn";
            // 
            // ownerSURNAMEDataGridViewTextBoxColumn
            // 
            this.ownerSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "Owner_SURNAME";
            this.ownerSURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.ownerSURNAMEDataGridViewTextBoxColumn.Name = "ownerSURNAMEDataGridViewTextBoxColumn";
            // 
            // oWNERSBindingSource
            // 
            this.oWNERSBindingSource.DataMember = "OWNERS";
            this.oWNERSBindingSource.DataSource = this.dsLibrary1;
            // 
            // dsLibrary1
            // 
            this.dsLibrary1.DataSetName = "DSLibrary";
            this.dsLibrary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.buttonCompanyDelete);
            this.tabCompany.Controls.Add(this.buttonCompanySave);
            this.tabCompany.Controls.Add(this.dataGridViewCOMPANY);
            this.tabCompany.Location = new System.Drawing.Point(4, 25);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompany.Size = new System.Drawing.Size(550, 321);
            this.tabCompany.TabIndex = 1;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // buttonCompanyDelete
            // 
            this.buttonCompanyDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonCompanyDelete.Name = "buttonCompanyDelete";
            this.buttonCompanyDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCompanyDelete.TabIndex = 2;
            this.buttonCompanyDelete.Text = "Delete";
            this.buttonCompanyDelete.UseVisualStyleBackColor = true;
            this.buttonCompanyDelete.Click += new System.EventHandler(this.buttonCompanyDelete_Click);
            // 
            // buttonCompanySave
            // 
            this.buttonCompanySave.Location = new System.Drawing.Point(17, 7);
            this.buttonCompanySave.Name = "buttonCompanySave";
            this.buttonCompanySave.Size = new System.Drawing.Size(75, 23);
            this.buttonCompanySave.TabIndex = 1;
            this.buttonCompanySave.Text = "Save";
            this.buttonCompanySave.UseVisualStyleBackColor = true;
            this.buttonCompanySave.Click += new System.EventHandler(this.buttonCompanySave_Click);
            // 
            // dataGridViewCOMPANY
            // 
            this.dataGridViewCOMPANY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCOMPANY.AutoGenerateColumns = false;
            this.dataGridViewCOMPANY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCOMPANY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDDataGridViewTextBoxColumn,
            this.companyNAMEDataGridViewTextBoxColumn,
            this.companyLOCATIONDataGridViewTextBoxColumn,
            this.companyOWNERSDataGridViewTextBoxColumn,
            this.OWNERS});
            this.dataGridViewCOMPANY.DataSource = this.cOMPANYBindingSource;
            this.dataGridViewCOMPANY.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewCOMPANY.Name = "dataGridViewCOMPANY";
            this.dataGridViewCOMPANY.RowTemplate.Height = 24;
            this.dataGridViewCOMPANY.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewCOMPANY.TabIndex = 0;
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "Company_ID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "Company_ID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            this.companyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyNAMEDataGridViewTextBoxColumn
            // 
            this.companyNAMEDataGridViewTextBoxColumn.DataPropertyName = "Company_NAME";
            this.companyNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.companyNAMEDataGridViewTextBoxColumn.Name = "companyNAMEDataGridViewTextBoxColumn";
            // 
            // companyLOCATIONDataGridViewTextBoxColumn
            // 
            this.companyLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "Company_LOCATION";
            this.companyLOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION";
            this.companyLOCATIONDataGridViewTextBoxColumn.Name = "companyLOCATIONDataGridViewTextBoxColumn";
            // 
            // companyOWNERSDataGridViewTextBoxColumn
            // 
            this.companyOWNERSDataGridViewTextBoxColumn.DataPropertyName = "Company_OWNERS";
            this.companyOWNERSDataGridViewTextBoxColumn.HeaderText = "Company_OWNERS";
            this.companyOWNERSDataGridViewTextBoxColumn.Name = "companyOWNERSDataGridViewTextBoxColumn";
            this.companyOWNERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // OWNERS
            // 
            this.OWNERS.DataPropertyName = "Company_OWNERS";
            this.OWNERS.DataSource = this.oWNERSBindingSource;
            this.OWNERS.DisplayMember = "Owner_SURNAME";
            this.OWNERS.HeaderText = "OWNERS";
            this.OWNERS.Name = "OWNERS";
            this.OWNERS.ValueMember = "Owner_ID";
            // 
            // cOMPANYBindingSource
            // 
            this.cOMPANYBindingSource.DataMember = "COMPANY";
            this.cOMPANYBindingSource.DataSource = this.dsLibrary1;
            // 
            // tabFilial
            // 
            this.tabFilial.Controls.Add(this.buttonFilialDelete);
            this.tabFilial.Controls.Add(this.buttonFilialSave);
            this.tabFilial.Controls.Add(this.dataGridViewFILIAL);
            this.tabFilial.Location = new System.Drawing.Point(4, 25);
            this.tabFilial.Name = "tabFilial";
            this.tabFilial.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilial.Size = new System.Drawing.Size(550, 321);
            this.tabFilial.TabIndex = 2;
            this.tabFilial.Text = "Filial";
            this.tabFilial.UseVisualStyleBackColor = true;
            // 
            // buttonFilialDelete
            // 
            this.buttonFilialDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonFilialDelete.Name = "buttonFilialDelete";
            this.buttonFilialDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonFilialDelete.TabIndex = 3;
            this.buttonFilialDelete.Text = "Delete";
            this.buttonFilialDelete.UseVisualStyleBackColor = true;
            this.buttonFilialDelete.Click += new System.EventHandler(this.buttonFilialDelete_Click);
            // 
            // buttonFilialSave
            // 
            this.buttonFilialSave.Location = new System.Drawing.Point(17, 7);
            this.buttonFilialSave.Name = "buttonFilialSave";
            this.buttonFilialSave.Size = new System.Drawing.Size(75, 23);
            this.buttonFilialSave.TabIndex = 2;
            this.buttonFilialSave.Text = "Save";
            this.buttonFilialSave.UseVisualStyleBackColor = true;
            this.buttonFilialSave.Click += new System.EventHandler(this.buttonFilialSave_Click);
            // 
            // dataGridViewFILIAL
            // 
            this.dataGridViewFILIAL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFILIAL.AutoGenerateColumns = false;
            this.dataGridViewFILIAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFILIAL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filialIDDataGridViewTextBoxColumn,
            this.filialNAMEDataGridViewTextBoxColumn,
            this.Column1,
            this.filialLOCATIONDataGridViewTextBoxColumn,
            this.filialCOMPANYDataGridViewTextBoxColumn});
            this.dataGridViewFILIAL.DataSource = this.fILIALBindingSource;
            this.dataGridViewFILIAL.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewFILIAL.Name = "dataGridViewFILIAL";
            this.dataGridViewFILIAL.RowTemplate.Height = 24;
            this.dataGridViewFILIAL.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewFILIAL.TabIndex = 1;
            // 
            // filialIDDataGridViewTextBoxColumn
            // 
            this.filialIDDataGridViewTextBoxColumn.DataPropertyName = "Filial_ID";
            this.filialIDDataGridViewTextBoxColumn.HeaderText = "Filial_ID";
            this.filialIDDataGridViewTextBoxColumn.Name = "filialIDDataGridViewTextBoxColumn";
            this.filialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.filialIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // filialNAMEDataGridViewTextBoxColumn
            // 
            this.filialNAMEDataGridViewTextBoxColumn.DataPropertyName = "Filial_NAME";
            this.filialNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.filialNAMEDataGridViewTextBoxColumn.Name = "filialNAMEDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Filial_COMPANY";
            this.Column1.DataSource = this.cOMPANYBindingSource;
            this.Column1.DisplayMember = "Company_NAME";
            this.Column1.HeaderText = "COMPANY";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "Company_ID";
            // 
            // filialLOCATIONDataGridViewTextBoxColumn
            // 
            this.filialLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "Filial_LOCATION";
            this.filialLOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION";
            this.filialLOCATIONDataGridViewTextBoxColumn.Name = "filialLOCATIONDataGridViewTextBoxColumn";
            // 
            // filialCOMPANYDataGridViewTextBoxColumn
            // 
            this.filialCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "Filial_COMPANY";
            this.filialCOMPANYDataGridViewTextBoxColumn.HeaderText = "Filial_COMPANY";
            this.filialCOMPANYDataGridViewTextBoxColumn.Name = "filialCOMPANYDataGridViewTextBoxColumn";
            this.filialCOMPANYDataGridViewTextBoxColumn.Visible = false;
            // 
            // fILIALBindingSource
            // 
            this.fILIALBindingSource.DataMember = "FILIAL";
            this.fILIALBindingSource.DataSource = this.dsLibrary1;
            // 
            // tabManagers
            // 
            this.tabManagers.Controls.Add(this.buttonManagS);
            this.tabManagers.Controls.Add(this.buttonManagersDelete);
            this.tabManagers.Controls.Add(this.buttonManagersSave);
            this.tabManagers.Controls.Add(this.dataGridViewMANAGERS);
            this.tabManagers.Location = new System.Drawing.Point(4, 25);
            this.tabManagers.Name = "tabManagers";
            this.tabManagers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManagers.Size = new System.Drawing.Size(550, 321);
            this.tabManagers.TabIndex = 3;
            this.tabManagers.Text = "Managers";
            this.tabManagers.UseVisualStyleBackColor = true;
            // 
            // buttonManagS
            // 
            this.buttonManagS.Location = new System.Drawing.Point(222, 7);
            this.buttonManagS.Name = "buttonManagS";
            this.buttonManagS.Size = new System.Drawing.Size(75, 23);
            this.buttonManagS.TabIndex = 4;
            this.buttonManagS.Text = "Search";
            this.buttonManagS.UseVisualStyleBackColor = true;
            this.buttonManagS.Click += new System.EventHandler(this.buttonManagS_Click);
            // 
            // buttonManagersDelete
            // 
            this.buttonManagersDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonManagersDelete.Name = "buttonManagersDelete";
            this.buttonManagersDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonManagersDelete.TabIndex = 3;
            this.buttonManagersDelete.Text = "Delete";
            this.buttonManagersDelete.UseVisualStyleBackColor = true;
            this.buttonManagersDelete.Click += new System.EventHandler(this.buttonManagersDelete_Click);
            // 
            // buttonManagersSave
            // 
            this.buttonManagersSave.Location = new System.Drawing.Point(17, 7);
            this.buttonManagersSave.Name = "buttonManagersSave";
            this.buttonManagersSave.Size = new System.Drawing.Size(75, 23);
            this.buttonManagersSave.TabIndex = 2;
            this.buttonManagersSave.Text = "Save";
            this.buttonManagersSave.UseVisualStyleBackColor = true;
            this.buttonManagersSave.Click += new System.EventHandler(this.buttonManagersSave_Click);
            // 
            // dataGridViewMANAGERS
            // 
            this.dataGridViewMANAGERS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMANAGERS.AutoGenerateColumns = false;
            this.dataGridViewMANAGERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMANAGERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerIDDataGridViewTextBoxColumn,
            this.managerNAMEDataGridViewTextBoxColumn,
            this.managerSURNAMEDataGridViewTextBoxColumn,
            this.managerRANKDataGridViewTextBoxColumn,
            this.Filial,
            this.managerFILIALDataGridViewTextBoxColumn});
            this.dataGridViewMANAGERS.DataSource = this.mANAGERSBindingSource;
            this.dataGridViewMANAGERS.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewMANAGERS.Name = "dataGridViewMANAGERS";
            this.dataGridViewMANAGERS.RowTemplate.Height = 24;
            this.dataGridViewMANAGERS.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewMANAGERS.TabIndex = 1;
            this.dataGridViewMANAGERS.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewMANAGERS_EditingControlShowing);
            this.dataGridViewMANAGERS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewMANAGERS_KeyPress);
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            this.managerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // managerNAMEDataGridViewTextBoxColumn
            // 
            this.managerNAMEDataGridViewTextBoxColumn.DataPropertyName = "Manager_NAME";
            this.managerNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.managerNAMEDataGridViewTextBoxColumn.Name = "managerNAMEDataGridViewTextBoxColumn";
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
            // Filial
            // 
            this.Filial.DataPropertyName = "Manager_FILIAL";
            this.Filial.DataSource = this.fILIALBindingSource;
            this.Filial.DisplayMember = "Filial_NAME";
            this.Filial.HeaderText = "FILIAL";
            this.Filial.Name = "Filial";
            this.Filial.ValueMember = "Filial_ID";
            // 
            // managerFILIALDataGridViewTextBoxColumn
            // 
            this.managerFILIALDataGridViewTextBoxColumn.DataPropertyName = "Manager_FILIAL";
            this.managerFILIALDataGridViewTextBoxColumn.HeaderText = "Manager_FILIAL";
            this.managerFILIALDataGridViewTextBoxColumn.Name = "managerFILIALDataGridViewTextBoxColumn";
            this.managerFILIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // mANAGERSBindingSource
            // 
            this.mANAGERSBindingSource.DataMember = "MANAGERS";
            this.mANAGERSBindingSource.DataSource = this.dsLibrary1;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.buttonClientsSearch);
            this.tabClients.Controls.Add(this.buttonClientsDelete);
            this.tabClients.Controls.Add(this.buttonClientsSave);
            this.tabClients.Controls.Add(this.dataGridViewCLIENTS);
            this.tabClients.Location = new System.Drawing.Point(4, 25);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(550, 321);
            this.tabClients.TabIndex = 4;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // buttonClientsSearch
            // 
            this.buttonClientsSearch.Location = new System.Drawing.Point(224, 7);
            this.buttonClientsSearch.Name = "buttonClientsSearch";
            this.buttonClientsSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsSearch.TabIndex = 5;
            this.buttonClientsSearch.Text = "Search";
            this.buttonClientsSearch.UseVisualStyleBackColor = true;
            this.buttonClientsSearch.Click += new System.EventHandler(this.buttonClientsSearch_Click);
            // 
            // buttonClientsDelete
            // 
            this.buttonClientsDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonClientsDelete.Name = "buttonClientsDelete";
            this.buttonClientsDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsDelete.TabIndex = 4;
            this.buttonClientsDelete.Text = "Delete";
            this.buttonClientsDelete.UseVisualStyleBackColor = true;
            this.buttonClientsDelete.Click += new System.EventHandler(this.buttonClientsDelete_Click);
            // 
            // buttonClientsSave
            // 
            this.buttonClientsSave.Location = new System.Drawing.Point(17, 7);
            this.buttonClientsSave.Name = "buttonClientsSave";
            this.buttonClientsSave.Size = new System.Drawing.Size(75, 23);
            this.buttonClientsSave.TabIndex = 3;
            this.buttonClientsSave.Text = "Save";
            this.buttonClientsSave.UseVisualStyleBackColor = true;
            this.buttonClientsSave.Click += new System.EventHandler(this.buttonClientsSave_Click);
            // 
            // dataGridViewCLIENTS
            // 
            this.dataGridViewCLIENTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCLIENTS.AutoGenerateColumns = false;
            this.dataGridViewCLIENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCLIENTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNAMEDataGridViewTextBoxColumn,
            this.clientSURNAMEDataGridViewTextBoxColumn,
            this.clientBORNDataGridViewTextBoxColumn});
            this.dataGridViewCLIENTS.DataSource = this.cLIENTSBindingSource;
            this.dataGridViewCLIENTS.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewCLIENTS.Name = "dataGridViewCLIENTS";
            this.dataGridViewCLIENTS.RowTemplate.Height = 24;
            this.dataGridViewCLIENTS.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewCLIENTS.TabIndex = 2;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
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
            // cLIENTSBindingSource
            // 
            this.cLIENTSBindingSource.DataMember = "CLIENTS";
            this.cLIENTSBindingSource.DataSource = this.dsLibrary1;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.buttonOrderSearch);
            this.tabOrders.Controls.Add(this.buttonOrdersDelete);
            this.tabOrders.Controls.Add(this.buttonOrdersSave);
            this.tabOrders.Controls.Add(this.dataGridViewORDERS);
            this.tabOrders.Location = new System.Drawing.Point(4, 25);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(550, 321);
            this.tabOrders.TabIndex = 5;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // buttonOrderSearch
            // 
            this.buttonOrderSearch.Location = new System.Drawing.Point(224, 7);
            this.buttonOrderSearch.Name = "buttonOrderSearch";
            this.buttonOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderSearch.TabIndex = 6;
            this.buttonOrderSearch.Text = "Search";
            this.buttonOrderSearch.UseVisualStyleBackColor = true;
            this.buttonOrderSearch.Click += new System.EventHandler(this.buttonOrderSearch_Click);
            // 
            // buttonOrdersDelete
            // 
            this.buttonOrdersDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonOrdersDelete.Name = "buttonOrdersDelete";
            this.buttonOrdersDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdersDelete.TabIndex = 5;
            this.buttonOrdersDelete.Text = "Delete";
            this.buttonOrdersDelete.UseVisualStyleBackColor = true;
            this.buttonOrdersDelete.Click += new System.EventHandler(this.buttonOrdersDelete_Click);
            // 
            // buttonOrdersSave
            // 
            this.buttonOrdersSave.Location = new System.Drawing.Point(17, 7);
            this.buttonOrdersSave.Name = "buttonOrdersSave";
            this.buttonOrdersSave.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdersSave.TabIndex = 4;
            this.buttonOrdersSave.Text = "Save";
            this.buttonOrdersSave.UseVisualStyleBackColor = true;
            this.buttonOrdersSave.Click += new System.EventHandler(this.buttonOrdersSave_Click);
            // 
            // dataGridViewORDERS
            // 
            this.dataGridViewORDERS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewORDERS.AutoGenerateColumns = false;
            this.dataGridViewORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewORDERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderNAMEDataGridViewTextBoxColumn,
            this.Manager,
            this.Client,
            this.Destination,
            this.orderMANAGERDataGridViewTextBoxColumn,
            this.orderDESTINATIONDataGridViewTextBoxColumn,
            this.orderDURATIONDataGridViewTextBoxColumn,
            this.orderPRICEDataGridViewTextBoxColumn,
            this.orderCLIENTDataGridViewTextBoxColumn});
            this.dataGridViewORDERS.DataSource = this.oRDERSBindingSource;
            this.dataGridViewORDERS.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewORDERS.Name = "dataGridViewORDERS";
            this.dataGridViewORDERS.RowTemplate.Height = 24;
            this.dataGridViewORDERS.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewORDERS.TabIndex = 3;
            this.dataGridViewORDERS.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewORDERS_EditingControlShowing);
            this.dataGridViewORDERS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewORDERS_KeyPress);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderNAMEDataGridViewTextBoxColumn
            // 
            this.orderNAMEDataGridViewTextBoxColumn.DataPropertyName = "Order_NAME";
            this.orderNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.orderNAMEDataGridViewTextBoxColumn.Name = "orderNAMEDataGridViewTextBoxColumn";
            // 
            // Manager
            // 
            this.Manager.DataPropertyName = "Order_MANAGER";
            this.Manager.DataSource = this.mANAGERSBindingSource;
            this.Manager.DisplayMember = "Manager_SURNAME";
            this.Manager.HeaderText = "MANAGER";
            this.Manager.Name = "Manager";
            this.Manager.ValueMember = "Manager_ID";
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Order_CLIENT";
            this.Client.DataSource = this.cLIENTSBindingSource;
            this.Client.DisplayMember = "Client_SURNAME";
            this.Client.HeaderText = "CLIENT";
            this.Client.Name = "Client";
            this.Client.ValueMember = "Client_ID";
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Order_DESTINATION";
            this.Destination.DataSource = this.dESTINATIONBindingSource;
            this.Destination.DisplayMember = "Destination_NAME";
            this.Destination.HeaderText = "DESTINATION";
            this.Destination.Name = "Destination";
            this.Destination.ValueMember = "Destination_ID";
            // 
            // dESTINATIONBindingSource
            // 
            this.dESTINATIONBindingSource.DataMember = "DESTINATION";
            this.dESTINATIONBindingSource.DataSource = this.dsLibrary1;
            // 
            // orderMANAGERDataGridViewTextBoxColumn
            // 
            this.orderMANAGERDataGridViewTextBoxColumn.DataPropertyName = "Order_MANAGER";
            this.orderMANAGERDataGridViewTextBoxColumn.HeaderText = "Order_MANAGER";
            this.orderMANAGERDataGridViewTextBoxColumn.Name = "orderMANAGERDataGridViewTextBoxColumn";
            this.orderMANAGERDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDESTINATIONDataGridViewTextBoxColumn
            // 
            this.orderDESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "Order_DESTINATION";
            this.orderDESTINATIONDataGridViewTextBoxColumn.HeaderText = "Order_DESTINATION";
            this.orderDESTINATIONDataGridViewTextBoxColumn.Name = "orderDESTINATIONDataGridViewTextBoxColumn";
            this.orderDESTINATIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDURATIONDataGridViewTextBoxColumn
            // 
            this.orderDURATIONDataGridViewTextBoxColumn.DataPropertyName = "Order_DURATION";
            this.orderDURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.orderDURATIONDataGridViewTextBoxColumn.Name = "orderDURATIONDataGridViewTextBoxColumn";
            // 
            // orderPRICEDataGridViewTextBoxColumn
            // 
            this.orderPRICEDataGridViewTextBoxColumn.DataPropertyName = "Order_PRICE";
            this.orderPRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.orderPRICEDataGridViewTextBoxColumn.Name = "orderPRICEDataGridViewTextBoxColumn";
            // 
            // orderCLIENTDataGridViewTextBoxColumn
            // 
            this.orderCLIENTDataGridViewTextBoxColumn.DataPropertyName = "Order_CLIENT";
            this.orderCLIENTDataGridViewTextBoxColumn.HeaderText = "Order_CLIENT";
            this.orderCLIENTDataGridViewTextBoxColumn.Name = "orderCLIENTDataGridViewTextBoxColumn";
            this.orderCLIENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.dsLibrary1;
            // 
            // tabDestination
            // 
            this.tabDestination.Controls.Add(this.buttonDestinationDelete);
            this.tabDestination.Controls.Add(this.buttonDestinatioSave);
            this.tabDestination.Controls.Add(this.dataGridViewDESTINATION);
            this.tabDestination.Location = new System.Drawing.Point(4, 25);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestination.Size = new System.Drawing.Size(550, 321);
            this.tabDestination.TabIndex = 6;
            this.tabDestination.Text = "Destination";
            this.tabDestination.UseVisualStyleBackColor = true;
            // 
            // buttonDestinationDelete
            // 
            this.buttonDestinationDelete.Location = new System.Drawing.Point(116, 7);
            this.buttonDestinationDelete.Name = "buttonDestinationDelete";
            this.buttonDestinationDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDestinationDelete.TabIndex = 6;
            this.buttonDestinationDelete.Text = "Delete";
            this.buttonDestinationDelete.UseVisualStyleBackColor = true;
            this.buttonDestinationDelete.Click += new System.EventHandler(this.buttonDestinationDelete_Click);
            // 
            // buttonDestinatioSave
            // 
            this.buttonDestinatioSave.Location = new System.Drawing.Point(17, 7);
            this.buttonDestinatioSave.Name = "buttonDestinatioSave";
            this.buttonDestinatioSave.Size = new System.Drawing.Size(75, 23);
            this.buttonDestinatioSave.TabIndex = 5;
            this.buttonDestinatioSave.Text = "Save";
            this.buttonDestinatioSave.UseVisualStyleBackColor = true;
            this.buttonDestinatioSave.Click += new System.EventHandler(this.buttonDestinatioSave_Click);
            // 
            // dataGridViewDESTINATION
            // 
            this.dataGridViewDESTINATION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDESTINATION.AutoGenerateColumns = false;
            this.dataGridViewDESTINATION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDESTINATION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destinationIDDataGridViewTextBoxColumn,
            this.destinationNAMEDataGridViewTextBoxColumn});
            this.dataGridViewDESTINATION.DataSource = this.dESTINATIONBindingSource;
            this.dataGridViewDESTINATION.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewDESTINATION.Name = "dataGridViewDESTINATION";
            this.dataGridViewDESTINATION.RowTemplate.Height = 24;
            this.dataGridViewDESTINATION.Size = new System.Drawing.Size(550, 282);
            this.dataGridViewDESTINATION.TabIndex = 4;
            // 
            // destinationIDDataGridViewTextBoxColumn
            // 
            this.destinationIDDataGridViewTextBoxColumn.DataPropertyName = "Destination_ID";
            this.destinationIDDataGridViewTextBoxColumn.HeaderText = "Destination_ID";
            this.destinationIDDataGridViewTextBoxColumn.Name = "destinationIDDataGridViewTextBoxColumn";
            this.destinationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinationNAMEDataGridViewTextBoxColumn
            // 
            this.destinationNAMEDataGridViewTextBoxColumn.DataPropertyName = "Destination_NAME";
            this.destinationNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.destinationNAMEDataGridViewTextBoxColumn.Name = "destinationNAMEDataGridViewTextBoxColumn";
            // 
            // ownersTableAdapter1
            // 
            this.ownersTableAdapter1.ClearBeforeFill = true;
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // filialTableAdapter1
            // 
            this.filialTableAdapter1.ClearBeforeFill = true;
            // 
            // managersTableAdapter1
            // 
            this.managersTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // destinationTableAdapter1
            // 
            this.destinationTableAdapter1.ClearBeforeFill = true;
            // 
            // destinationIDDataGridViewTextBoxColumn1
            // 
            this.destinationIDDataGridViewTextBoxColumn1.DataPropertyName = "Destination_ID";
            this.destinationIDDataGridViewTextBoxColumn1.HeaderText = "Destination_ID";
            this.destinationIDDataGridViewTextBoxColumn1.Name = "destinationIDDataGridViewTextBoxColumn1";
            this.destinationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // destinationNAMEDataGridViewTextBoxColumn1
            // 
            this.destinationNAMEDataGridViewTextBoxColumn1.DataPropertyName = "Destination_NAME";
            this.destinationNAMEDataGridViewTextBoxColumn1.HeaderText = "Destination_NAME";
            this.destinationNAMEDataGridViewTextBoxColumn1.Name = "destinationNAMEDataGridViewTextBoxColumn1";
            // 
            // FormTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 349);
            this.Controls.Add(this.tabControl);
            this.Name = "FormTrip";
            this.Text = "Trip";
            this.tabControl.ResumeLayout(false);
            this.tabOwners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOWNER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oWNERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibrary1)).EndInit();
            this.tabCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCOMPANY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYBindingSource)).EndInit();
            this.tabFilial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFILIAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILIALBindingSource)).EndInit();
            this.tabManagers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMANAGERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANAGERSBindingSource)).EndInit();
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLIENTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewORDERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            this.tabDestination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDESTINATION)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOwners;
        private System.Windows.Forms.Button buttonOwnersDelete;
        private System.Windows.Forms.Button buttonOwnersSave;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.TabPage tabFilial;
        private System.Windows.Forms.TabPage tabManagers;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabDestination;
        private System.Windows.Forms.Button buttonCompanyDelete;
        private System.Windows.Forms.Button buttonCompanySave;
        private System.Windows.Forms.DataGridView dataGridViewCOMPANY;
        private System.Windows.Forms.DataGridView dataGridViewFILIAL;
        private System.Windows.Forms.DataGridView dataGridViewMANAGERS;
        private System.Windows.Forms.Button buttonFilialDelete;
        private System.Windows.Forms.Button buttonFilialSave;
        private System.Windows.Forms.Button buttonManagersDelete;
        private System.Windows.Forms.Button buttonManagersSave;
        private System.Windows.Forms.DataGridView dataGridViewCLIENTS;
        private System.Windows.Forms.DataGridView dataGridViewORDERS;
        private System.Windows.Forms.DataGridView dataGridViewDESTINATION;
        private System.Windows.Forms.Button buttonClientsDelete;
        private System.Windows.Forms.Button buttonClientsSave;
        private System.Windows.Forms.Button buttonOrdersDelete;
        private System.Windows.Forms.Button buttonOrdersSave;
        private System.Windows.Forms.Button buttonDestinationDelete;
        private System.Windows.Forms.Button buttonDestinatioSave;
        private System.Windows.Forms.DataGridView dataGridViewOWNER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oWNERSBindingSource;
        private ClassLibrary.DSLibrary dsLibrary1;
        private System.Windows.Forms.BindingSource cOMPANYBindingSource;
        private System.Windows.Forms.BindingSource fILIALBindingSource;
        private System.Windows.Forms.BindingSource mANAGERSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBORNDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private ClassLibrary.DSLibraryTableAdapters.OWNERSTableAdapter ownersTableAdapter1;
        private ClassLibrary.DSLibraryTableAdapters.COMPANYTableAdapter companyTableAdapter1;
        private ClassLibrary.DSLibraryTableAdapters.FILIALTableAdapter filialTableAdapter1;
        private ClassLibrary.DSLibraryTableAdapters.MANAGERSTableAdapter managersTableAdapter1;
        private ClassLibrary.DSLibraryTableAdapters.CLIENTSTableAdapter clientsTableAdapter1;
        private ClassLibrary.DSLibraryTableAdapters.ORDERSTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyOWNERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OWNERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn filialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filialNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filialLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filialCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerRANKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerFILIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Manager;
        private System.Windows.Forms.DataGridViewComboBoxColumn Client;
        private System.Windows.Forms.DataGridViewComboBoxColumn Destination;
        private System.Windows.Forms.BindingSource dESTINATIONBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderMANAGERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNAMEDataGridViewTextBoxColumn;
        private ClassLibrary.DSLibraryTableAdapters.DESTINATIONTableAdapter destinationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNAMEDataGridViewTextBoxColumn1;
        private ClassLibrary.DSLibraryTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Button buttonOrderSearch;
        private System.Windows.Forms.Button buttonClientsSearch;
        private System.Windows.Forms.Button buttonManagS;
    }
}

