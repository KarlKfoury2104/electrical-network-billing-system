namespace ElectricalNetworkProj
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBills = new System.Windows.Forms.GroupBox();
            this.lblColorLegend = new System.Windows.Forms.Label();
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilowattHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOwedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBillDetails = new System.Windows.Forms.GroupBox();
            this.lblMeterID = new System.Windows.Forms.Label();
            this.txtMeterID = new System.Windows.Forms.TextBox();
            this.lblKilowattHours = new System.Windows.Forms.Label();
            this.txtKilowattHours = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.lblBillID = new System.Windows.Forms.Label();
            this.cmbBillIDs = new System.Windows.Forms.ComboBox();
            this.lblMeterSelection = new System.Windows.Forms.Label();
            this.cmbMeterIDs = new System.Windows.Forms.ComboBox();
            this.lblActionHint = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnShowMeterBills = new System.Windows.Forms.Button();
            this.btnCalculateAmountOwed = new System.Windows.Forms.Button();
            this.lblOutstandingBalance = new System.Windows.Forms.Label();
            this.grpBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.grpBillDetails.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electrical Network - Bills";
            // 
            // grpBills
            // 
            this.grpBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right))));
            this.grpBills.Controls.Add(this.lblColorLegend);
            this.grpBills.Controls.Add(this.dataGridViewBills);
            this.grpBills.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBills.Location = new System.Drawing.Point(20, 60);
            this.grpBills.Name = "grpBills";
            this.grpBills.Padding = new System.Windows.Forms.Padding(12);
            this.grpBills.Size = new System.Drawing.Size(1140, 325);
            this.grpBills.TabIndex = 1;
            this.grpBills.TabStop = false;
            this.grpBills.Text = "Bills";
            // 
            // lblColorLegend
            // 
            this.lblColorLegend.AutoSize = true;
            this.lblColorLegend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorLegend.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblColorLegend.Location = new System.Drawing.Point(14, 30);
            this.lblColorLegend.Name = "lblColorLegend";
            this.lblColorLegend.Size = new System.Drawing.Size(401, 19);
            this.lblColorLegend.TabIndex = 0;
            this.lblColorLegend.Text = "Green = paid in full   |   Red = past due with an outstanding balance";
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.AllowUserToAddRows = false;
            this.dataGridViewBills.AllowUserToDeleteRows = false;
            this.dataGridViewBills.AllowUserToResizeRows = false;
            this.dataGridViewBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBills.AutoGenerateColumns = false;
            this.dataGridViewBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.meterIDDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.kilowattHoursDataGridViewTextBoxColumn,
            this.amountOwedDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.dataGridViewBills.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBills.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewBills.MultiSelect = false;
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.ReadOnly = true;
            this.dataGridViewBills.RowHeadersVisible = false;
            this.dataGridViewBills.RowHeadersWidth = 51;
            this.dataGridViewBills.RowTemplate.Height = 26;
            this.dataGridViewBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBills.Size = new System.Drawing.Size(1116, 257);
            this.dataGridViewBills.TabIndex = 1;
            // 
            // billIDDataGridViewTextBoxColumn
            // 
            this.billIDDataGridViewTextBoxColumn.DataPropertyName = "BillID";
            this.billIDDataGridViewTextBoxColumn.HeaderText = "Bill ID";
            this.billIDDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.billIDDataGridViewTextBoxColumn.Name = "billIDDataGridViewTextBoxColumn";
            this.billIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meterIDDataGridViewTextBoxColumn
            // 
            this.meterIDDataGridViewTextBoxColumn.DataPropertyName = "MeterID";
            this.meterIDDataGridViewTextBoxColumn.HeaderText = "Meter ID";
            this.meterIDDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.meterIDDataGridViewTextBoxColumn.Name = "meterIDDataGridViewTextBoxColumn";
            this.meterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate / kWh";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilowattHoursDataGridViewTextBoxColumn
            // 
            this.kilowattHoursDataGridViewTextBoxColumn.DataPropertyName = "KilowattHours";
            this.kilowattHoursDataGridViewTextBoxColumn.HeaderText = "Kilowatt Hours";
            this.kilowattHoursDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.kilowattHoursDataGridViewTextBoxColumn.Name = "kilowattHoursDataGridViewTextBoxColumn";
            this.kilowattHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOwedDataGridViewTextBoxColumn
            // 
            this.amountOwedDataGridViewTextBoxColumn.DataPropertyName = "AmountOwed";
            this.amountOwedDataGridViewTextBoxColumn.HeaderText = "Amount Owed";
            this.amountOwedDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.amountOwedDataGridViewTextBoxColumn.Name = "amountOwedDataGridViewTextBoxColumn";
            this.amountOwedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount Paid";
            this.amountPaidDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grpBillDetails
            // 
            this.grpBillDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left))));
            this.grpBillDetails.Controls.Add(this.lblMeterID);
            this.grpBillDetails.Controls.Add(this.txtMeterID);
            this.grpBillDetails.Controls.Add(this.lblKilowattHours);
            this.grpBillDetails.Controls.Add(this.txtKilowattHours);
            this.grpBillDetails.Controls.Add(this.lblIssueDate);
            this.grpBillDetails.Controls.Add(this.dtpIssueDate);
            this.grpBillDetails.Controls.Add(this.lblDueDate);
            this.grpBillDetails.Controls.Add(this.dtpDueDate);
            this.grpBillDetails.Controls.Add(this.lblAmountPaid);
            this.grpBillDetails.Controls.Add(this.txtAmountPaid);
            this.grpBillDetails.Controls.Add(this.lblRate);
            this.grpBillDetails.Controls.Add(this.txtRate);
            this.grpBillDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBillDetails.Location = new System.Drawing.Point(20, 400);
            this.grpBillDetails.Name = "grpBillDetails";
            this.grpBillDetails.Size = new System.Drawing.Size(560, 250);
            this.grpBillDetails.TabIndex = 2;
            this.grpBillDetails.TabStop = false;
            this.grpBillDetails.Text = "Bill Details";
            // 
            // lblMeterID
            // 
            this.lblMeterID.AutoSize = true;
            this.lblMeterID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterID.Location = new System.Drawing.Point(20, 39);
            this.lblMeterID.Name = "lblMeterID";
            this.lblMeterID.Size = new System.Drawing.Size(68, 20);
            this.lblMeterID.TabIndex = 0;
            this.lblMeterID.Text = "Meter ID";
            // 
            // txtMeterID
            // 
            this.txtMeterID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeterID.Location = new System.Drawing.Point(145, 35);
            this.txtMeterID.Name = "txtMeterID";
            this.txtMeterID.Size = new System.Drawing.Size(125, 27);
            this.txtMeterID.TabIndex = 1;
            // 
            // lblKilowattHours
            // 
            this.lblKilowattHours.AutoSize = true;
            this.lblKilowattHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilowattHours.Location = new System.Drawing.Point(20, 82);
            this.lblKilowattHours.Name = "lblKilowattHours";
            this.lblKilowattHours.Size = new System.Drawing.Size(112, 20);
            this.lblKilowattHours.TabIndex = 2;
            this.lblKilowattHours.Text = "Kilowatt Hours";
            // 
            // txtKilowattHours
            // 
            this.txtKilowattHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilowattHours.Location = new System.Drawing.Point(145, 78);
            this.txtKilowattHours.Name = "txtKilowattHours";
            this.txtKilowattHours.Size = new System.Drawing.Size(125, 27);
            this.txtKilowattHours.TabIndex = 3;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(20, 125);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(77, 20);
            this.lblIssueDate.TabIndex = 4;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "yyyy-MM-dd";
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(145, 121);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(125, 27);
            this.dtpIssueDate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(300, 39);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(69, 20);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(390, 35);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(145, 27);
            this.dtpDueDate.TabIndex = 7;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(300, 82);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(94, 20);
            this.lblAmountPaid.TabIndex = 8;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(410, 78);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(125, 27);
            this.txtAmountPaid.TabIndex = 9;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(300, 125);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(76, 20);
            this.lblRate.TabIndex = 10;
            this.lblRate.Text = "Rate / kWh";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(410, 121);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(125, 27);
            this.txtRate.TabIndex = 11;
            this.txtRate.Text = "0.15";
            // 
            // grpActions
            // 
            this.grpActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))));
            this.grpActions.Controls.Add(this.lblBillID);
            this.grpActions.Controls.Add(this.cmbBillIDs);
            this.grpActions.Controls.Add(this.lblMeterSelection);
            this.grpActions.Controls.Add(this.cmbMeterIDs);
            this.grpActions.Controls.Add(this.lblActionHint);
            this.grpActions.Controls.Add(this.btnAddBill);
            this.grpActions.Controls.Add(this.btnRead);
            this.grpActions.Controls.Add(this.btnUpdate);
            this.grpActions.Controls.Add(this.btnDeleteBill);
            this.grpActions.Controls.Add(this.btnShowMeterBills);
            this.grpActions.Controls.Add(this.btnCalculateAmountOwed);
            this.grpActions.Controls.Add(this.lblOutstandingBalance);
            this.grpActions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(600, 400);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(560, 250);
            this.grpActions.TabIndex = 3;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.Location = new System.Drawing.Point(20, 39);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(92, 20);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "Selected Bill";
            // 
            // cmbBillIDs
            // 
            this.cmbBillIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillIDs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillIDs.FormattingEnabled = true;
            this.cmbBillIDs.Location = new System.Drawing.Point(125, 35);
            this.cmbBillIDs.Name = "cmbBillIDs";
            this.cmbBillIDs.Size = new System.Drawing.Size(125, 28);
            this.cmbBillIDs.TabIndex = 1;
            // 
            // lblMeterSelection
            // 
            this.lblMeterSelection.AutoSize = true;
            this.lblMeterSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterSelection.Location = new System.Drawing.Point(285, 39);
            this.lblMeterSelection.Name = "lblMeterSelection";
            this.lblMeterSelection.Size = new System.Drawing.Size(109, 20);
            this.lblMeterSelection.TabIndex = 2;
            this.lblMeterSelection.Text = "Selected Meter";
            // 
            // cmbMeterIDs
            // 
            this.cmbMeterIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeterIDs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeterIDs.FormattingEnabled = true;
            this.cmbMeterIDs.Location = new System.Drawing.Point(410, 35);
            this.cmbMeterIDs.Name = "cmbMeterIDs";
            this.cmbMeterIDs.Size = new System.Drawing.Size(125, 28);
            this.cmbMeterIDs.TabIndex = 3;
            // 
            // lblActionHint
            // 
            this.lblActionHint.AutoSize = true;
            this.lblActionHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionHint.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblActionHint.Location = new System.Drawing.Point(20, 74);
            this.lblActionHint.Name = "lblActionHint";
            this.lblActionHint.Size = new System.Drawing.Size(487, 19);
            this.lblActionHint.TabIndex = 4;
            this.lblActionHint.Text = "Bill actions use Selected Bill. Meter actions use Selected Meter.";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(20, 105);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(250, 32);
            this.btnAddBill.TabIndex = 5;
            this.btnAddBill.Text = "Add New Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(285, 105);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(250, 32);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read Selected Bill";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(20, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(250, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Payment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.Location = new System.Drawing.Point(285, 143);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(250, 32);
            this.btnDeleteBill.TabIndex = 8;
            this.btnDeleteBill.Text = "Delete Selected Bill";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnShowMeterBills
            // 
            this.btnShowMeterBills.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMeterBills.Location = new System.Drawing.Point(20, 181);
            this.btnShowMeterBills.Name = "btnShowMeterBills";
            this.btnShowMeterBills.Size = new System.Drawing.Size(250, 32);
            this.btnShowMeterBills.TabIndex = 9;
            this.btnShowMeterBills.Text = "Show Bills of This Meter";
            this.btnShowMeterBills.UseVisualStyleBackColor = true;
            this.btnShowMeterBills.Click += new System.EventHandler(this.btnShowMeterBills_Click);
            // 
            // btnCalculateAmountOwed
            // 
            this.btnCalculateAmountOwed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAmountOwed.Location = new System.Drawing.Point(285, 181);
            this.btnCalculateAmountOwed.Name = "btnCalculateAmountOwed";
            this.btnCalculateAmountOwed.Size = new System.Drawing.Size(250, 32);
            this.btnCalculateAmountOwed.TabIndex = 10;
            this.btnCalculateAmountOwed.Text = "Calculate Amount Owed";
            this.btnCalculateAmountOwed.UseVisualStyleBackColor = true;
            this.btnCalculateAmountOwed.Click += new System.EventHandler(this.btnCalculateAmountOwed_Click);
            // 
            // lblOutstandingBalance
            // 
            this.lblOutstandingBalance.AutoSize = true;
            this.lblOutstandingBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstandingBalance.Location = new System.Drawing.Point(285, 220);
            this.lblOutstandingBalance.Name = "lblOutstandingBalance";
            this.lblOutstandingBalance.Size = new System.Drawing.Size(173, 20);
            this.lblOutstandingBalance.TabIndex = 11;
            this.lblOutstandingBalance.Text = "Outstanding balance: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpBillDetails);
            this.Controls.Add(this.grpBills);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1198, 717);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrical Network - Bill Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBills.ResumeLayout(false);
            this.grpBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.grpBillDetails.ResumeLayout(false);
            this.grpBillDetails.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBills;
        private System.Windows.Forms.Label lblColorLegend;
        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilowattHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOwedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpBillDetails;
        private System.Windows.Forms.Label lblMeterID;
        private System.Windows.Forms.TextBox txtMeterID;
        private System.Windows.Forms.Label lblKilowattHours;
        private System.Windows.Forms.TextBox txtKilowattHours;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.ComboBox cmbBillIDs;
        private System.Windows.Forms.Label lblMeterSelection;
        private System.Windows.Forms.ComboBox cmbMeterIDs;
        private System.Windows.Forms.Label lblActionHint;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnShowMeterBills;
        private System.Windows.Forms.Button btnCalculateAmountOwed;
        private System.Windows.Forms.Label lblOutstandingBalance;
    }
}
