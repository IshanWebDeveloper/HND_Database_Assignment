namespace HND_Database_Assignment
{
    partial class ProductionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductionID = new System.Windows.Forms.Label();
            this.prdIDTextBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prdNameTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientIDTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addPrdBtn = new System.Windows.Forms.Button();
            this.clearPrdBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addCustLink = new System.Windows.Forms.LinkLabel();
            this.searchPrdBtn = new System.Windows.Forms.Button();
            this.editPrdBtn = new System.Windows.Forms.Button();
            this.deletePrdBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionProperitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocatonLink = new System.Windows.Forms.LinkLabel();
            this.calcProdCostBtn = new System.Windows.Forms.Button();
            this.prdTypeTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prdStartDate = new System.Windows.Forms.DateTimePicker();
            this.prdEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.viewStfDetailsBtn = new System.Windows.Forms.Button();
            this.totalPrdDayLabel = new System.Windows.Forms.Label();
            this.prdDaysLabel = new System.Windows.Forms.Label();
            this.locationListBx = new System.Windows.Forms.ListBox();
            this.clientNameTxtBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductionID
            // 
            this.ProductionID.AutoSize = true;
            this.ProductionID.Location = new System.Drawing.Point(19, 40);
            this.ProductionID.Name = "ProductionID";
            this.ProductionID.Size = new System.Drawing.Size(84, 16);
            this.ProductionID.TabIndex = 0;
            this.ProductionID.Text = "ProductionID";
            // 
            // prdIDTextBx
            // 
            this.prdIDTextBx.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.prdIDTextBx.Location = new System.Drawing.Point(139, 34);
            this.prdIDTextBx.Name = "prdIDTextBx";
            this.prdIDTextBx.Size = new System.Drawing.Size(72, 22);
            this.prdIDTextBx.TabIndex = 0;
            this.prdIDTextBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prdIDKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Production Name";
            // 
            // prdNameTxtBx
            // 
            this.prdNameTxtBx.Location = new System.Drawing.Point(139, 166);
            this.prdNameTxtBx.Name = "prdNameTxtBx";
            this.prdNameTxtBx.Size = new System.Drawing.Size(247, 22);
            this.prdNameTxtBx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Production Type";
            // 
            // clientIDTxtBx
            // 
            this.clientIDTxtBx.Location = new System.Drawing.Point(139, 78);
            this.clientIDTxtBx.Name = "clientIDTxtBx";
            this.clientIDTxtBx.Size = new System.Drawing.Size(72, 22);
            this.clientIDTxtBx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ClientID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Client Name";
            // 
            // addPrdBtn
            // 
            this.addPrdBtn.Enabled = false;
            this.addPrdBtn.Location = new System.Drawing.Point(13, 461);
            this.addPrdBtn.Name = "addPrdBtn";
            this.addPrdBtn.Size = new System.Drawing.Size(150, 56);
            this.addPrdBtn.TabIndex = 9;
            this.addPrdBtn.Text = "ADD";
            this.addPrdBtn.UseVisualStyleBackColor = true;
            // 
            // clearPrdBtn
            // 
            this.clearPrdBtn.Enabled = false;
            this.clearPrdBtn.Location = new System.Drawing.Point(953, 461);
            this.clearPrdBtn.Name = "clearPrdBtn";
            this.clearPrdBtn.Size = new System.Drawing.Size(150, 56);
            this.clearPrdBtn.TabIndex = 13;
            this.clearPrdBtn.Text = "CLEAR";
            this.clearPrdBtn.UseVisualStyleBackColor = true;
            this.clearPrdBtn.Click += new System.EventHandler(this.clearPrdBtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(415, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 313);
            this.dataGridView1.TabIndex = 12;
            // 
            // addCustLink
            // 
            this.addCustLink.AutoSize = true;
            this.addCustLink.Enabled = false;
            this.addCustLink.Location = new System.Drawing.Point(317, 125);
            this.addCustLink.Name = "addCustLink";
            this.addCustLink.Size = new System.Drawing.Size(92, 16);
            this.addCustLink.TabIndex = 13;
            this.addCustLink.TabStop = true;
            this.addCustLink.Text = "Add Customer";
            this.addCustLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // searchPrdBtn
            // 
            this.searchPrdBtn.Location = new System.Drawing.Point(248, 461);
            this.searchPrdBtn.Name = "searchPrdBtn";
            this.searchPrdBtn.Size = new System.Drawing.Size(150, 56);
            this.searchPrdBtn.TabIndex = 10;
            this.searchPrdBtn.Text = "Search";
            this.searchPrdBtn.UseVisualStyleBackColor = true;
            // 
            // editPrdBtn
            // 
            this.editPrdBtn.Enabled = false;
            this.editPrdBtn.Location = new System.Drawing.Point(483, 461);
            this.editPrdBtn.Name = "editPrdBtn";
            this.editPrdBtn.Size = new System.Drawing.Size(150, 56);
            this.editPrdBtn.TabIndex = 11;
            this.editPrdBtn.Text = "Edit";
            this.editPrdBtn.UseVisualStyleBackColor = true;
            // 
            // deletePrdBtn
            // 
            this.deletePrdBtn.Enabled = false;
            this.deletePrdBtn.Location = new System.Drawing.Point(718, 461);
            this.deletePrdBtn.Name = "deletePrdBtn";
            this.deletePrdBtn.Size = new System.Drawing.Size(150, 56);
            this.deletePrdBtn.TabIndex = 12;
            this.deletePrdBtn.Text = "Delete";
            this.deletePrdBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Locations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(413, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Film Production Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem1});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.logOutToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.productionProperitesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffTypesToolStripMenuItem,
            this.viewStaffDetailsToolStripMenuItem});
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addStaffToolStripMenuItem.Text = "Production Staff";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // addStaffTypesToolStripMenuItem
            // 
            this.addStaffTypesToolStripMenuItem.Name = "addStaffTypesToolStripMenuItem";
            this.addStaffTypesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.addStaffTypesToolStripMenuItem.Text = "Add Staff Types";
            // 
            // viewStaffDetailsToolStripMenuItem
            // 
            this.viewStaffDetailsToolStripMenuItem.Name = "viewStaffDetailsToolStripMenuItem";
            this.viewStaffDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.viewStaffDetailsToolStripMenuItem.Text = "View Staff Details";
            // 
            // productionProperitesToolStripMenuItem
            // 
            this.productionProperitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPropertiesToolStripMenuItem});
            this.productionProperitesToolStripMenuItem.Name = "productionProperitesToolStripMenuItem";
            this.productionProperitesToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.productionProperitesToolStripMenuItem.Text = "Production Properties";
            this.productionProperitesToolStripMenuItem.Click += new System.EventHandler(this.productionProperitesToolStripMenuItem_Click);
            // 
            // addPropertiesToolStripMenuItem
            // 
            this.addPropertiesToolStripMenuItem.Name = "addPropertiesToolStripMenuItem";
            this.addPropertiesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addPropertiesToolStripMenuItem.Text = "Add Properties";
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.locationsToolStripMenuItem.Text = "Production Locatons";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.userDocumentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // userDocumentationToolStripMenuItem
            // 
            this.userDocumentationToolStripMenuItem.Name = "userDocumentationToolStripMenuItem";
            this.userDocumentationToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.userDocumentationToolStripMenuItem.Text = "User Documentation";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeProgramToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // addLocatonLink
            // 
            this.addLocatonLink.AutoSize = true;
            this.addLocatonLink.Location = new System.Drawing.Point(317, 358);
            this.addLocatonLink.Name = "addLocatonLink";
            this.addLocatonLink.Size = new System.Drawing.Size(86, 16);
            this.addLocatonLink.TabIndex = 21;
            this.addLocatonLink.TabStop = true;
            this.addLocatonLink.Text = "Add Location";
            this.addLocatonLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLocatonLink_LinkClicked);
            // 
            // calcProdCostBtn
            // 
            this.calcProdCostBtn.Location = new System.Drawing.Point(828, 392);
            this.calcProdCostBtn.Name = "calcProdCostBtn";
            this.calcProdCostBtn.Size = new System.Drawing.Size(228, 49);
            this.calcProdCostBtn.TabIndex = 15;
            this.calcProdCostBtn.Text = "Calculate Total Production Cost";
            this.calcProdCostBtn.UseVisualStyleBackColor = true;
            // 
            // prdTypeTxtBx
            // 
            this.prdTypeTxtBx.Location = new System.Drawing.Point(139, 306);
            this.prdTypeTxtBx.Name = "prdTypeTxtBx";
            this.prdTypeTxtBx.Size = new System.Drawing.Size(247, 22);
            this.prdTypeTxtBx.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Start Date";
            // 
            // prdStartDate
            // 
            this.prdStartDate.Location = new System.Drawing.Point(139, 211);
            this.prdStartDate.Name = "prdStartDate";
            this.prdStartDate.Size = new System.Drawing.Size(247, 22);
            this.prdStartDate.TabIndex = 5;
            // 
            // prdEndDate
            // 
            this.prdEndDate.Location = new System.Drawing.Point(139, 253);
            this.prdEndDate.Name = "prdEndDate";
            this.prdEndDate.Size = new System.Drawing.Size(247, 22);
            this.prdEndDate.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "End Date";
            // 
            // viewStfDetailsBtn
            // 
            this.viewStfDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.viewStfDetailsBtn.Location = new System.Drawing.Point(418, 392);
            this.viewStfDetailsBtn.Name = "viewStfDetailsBtn";
            this.viewStfDetailsBtn.Size = new System.Drawing.Size(228, 49);
            this.viewStfDetailsBtn.TabIndex = 14;
            this.viewStfDetailsBtn.Text = "View Staff Details";
            this.viewStfDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // totalPrdDayLabel
            // 
            this.totalPrdDayLabel.AutoSize = true;
            this.totalPrdDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrdDayLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalPrdDayLabel.Location = new System.Drawing.Point(776, 24);
            this.totalPrdDayLabel.Name = "totalPrdDayLabel";
            this.totalPrdDayLabel.Size = new System.Drawing.Size(225, 25);
            this.totalPrdDayLabel.TabIndex = 30;
            this.totalPrdDayLabel.Text = "Total Production Days";
            // 
            // prdDaysLabel
            // 
            this.prdDaysLabel.AutoSize = true;
            this.prdDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdDaysLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prdDaysLabel.Location = new System.Drawing.Point(1026, 25);
            this.prdDaysLabel.Name = "prdDaysLabel";
            this.prdDaysLabel.Size = new System.Drawing.Size(78, 22);
            this.prdDaysLabel.TabIndex = 31;
            this.prdDaysLabel.Text = "<none>";
            // 
            // locationListBx
            // 
            this.locationListBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationListBx.FormattingEnabled = true;
            this.locationListBx.ItemHeight = 16;
            this.locationListBx.Location = new System.Drawing.Point(139, 347);
            this.locationListBx.Name = "locationListBx";
            this.locationListBx.Size = new System.Drawing.Size(172, 82);
            this.locationListBx.TabIndex = 32;
            // 
            // clientNameTxtBx
            // 
            this.clientNameTxtBx.Location = new System.Drawing.Point(139, 119);
            this.clientNameTxtBx.Name = "clientNameTxtBx";
            this.clientNameTxtBx.Size = new System.Drawing.Size(172, 22);
            this.clientNameTxtBx.TabIndex = 33;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 540);
            this.Controls.Add(this.clientNameTxtBx);
            this.Controls.Add(this.locationListBx);
            this.Controls.Add(this.prdDaysLabel);
            this.Controls.Add(this.totalPrdDayLabel);
            this.Controls.Add(this.viewStfDetailsBtn);
            this.Controls.Add(this.prdEndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prdStartDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prdTypeTxtBx);
            this.Controls.Add(this.calcProdCostBtn);
            this.Controls.Add(this.addLocatonLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletePrdBtn);
            this.Controls.Add(this.editPrdBtn);
            this.Controls.Add(this.searchPrdBtn);
            this.Controls.Add(this.addCustLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearPrdBtn);
            this.Controls.Add(this.addPrdBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientIDTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prdNameTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prdIDTextBx);
            this.Controls.Add(this.ProductionID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductionForm";
            this.Text = "Film Production Details";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductionID;
        private System.Windows.Forms.TextBox prdIDTextBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prdNameTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientIDTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPrdBtn;
        private System.Windows.Forms.Button clearPrdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel addCustLink;
        private System.Windows.Forms.Button searchPrdBtn;
        private System.Windows.Forms.Button editPrdBtn;
        private System.Windows.Forms.Button deletePrdBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel addLocatonLink;
        private System.Windows.Forms.Button calcProdCostBtn;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.TextBox prdTypeTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker prdStartDate;
        private System.Windows.Forms.DateTimePicker prdEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem productionProperitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.Button viewStfDetailsBtn;
        private System.Windows.Forms.Label totalPrdDayLabel;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffDetailsToolStripMenuItem;
        private System.Windows.Forms.Label prdDaysLabel;
        private System.Windows.Forms.ListBox locationListBx;
        private System.Windows.Forms.TextBox clientNameTxtBx;
    }
}