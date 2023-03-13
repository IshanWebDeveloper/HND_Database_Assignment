namespace HND_Database_Assignment
{
    partial class ClientForm
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
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.clientIDTxtBx = new System.Windows.Forms.TextBox();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNameTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientLocationTxtBx = new System.Windows.Forms.TextBox();
            this.clientCoNumberTxtBx = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.clientAddBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addPrdBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIDLabel.Location = new System.Drawing.Point(27, 50);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(89, 25);
            this.clientIDLabel.TabIndex = 0;
            this.clientIDLabel.Text = "ClientID";
            this.clientIDLabel.Click += new System.EventHandler(this.clientIDLabel_Click);
            // 
            // clientIDTxtBx
            // 
            this.clientIDTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIDTxtBx.Location = new System.Drawing.Point(292, 47);
            this.clientIDTxtBx.Name = "clientIDTxtBx";
            this.clientIDTxtBx.Size = new System.Drawing.Size(71, 30);
            this.clientIDTxtBx.TabIndex = 1;
            this.clientIDTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientIDTxtBx_KeyDown);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(27, 116);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(130, 25);
            this.clientNameLabel.TabIndex = 2;
            this.clientNameLabel.Text = "Client Name";
            // 
            // clientNameTxtBx
            // 
            this.clientNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTxtBx.Location = new System.Drawing.Point(292, 113);
            this.clientNameTxtBx.Name = "clientNameTxtBx";
            this.clientNameTxtBx.Size = new System.Drawing.Size(236, 30);
            this.clientNameTxtBx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Contact Number";
            // 
            // clientLocationTxtBx
            // 
            this.clientLocationTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLocationTxtBx.Location = new System.Drawing.Point(292, 179);
            this.clientLocationTxtBx.Name = "clientLocationTxtBx";
            this.clientLocationTxtBx.Size = new System.Drawing.Size(236, 30);
            this.clientLocationTxtBx.TabIndex = 6;
            // 
            // clientCoNumberTxtBx
            // 
            this.clientCoNumberTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCoNumberTxtBx.Location = new System.Drawing.Point(292, 247);
            this.clientCoNumberTxtBx.Name = "clientCoNumberTxtBx";
            this.clientCoNumberTxtBx.Size = new System.Drawing.Size(236, 30);
            this.clientCoNumberTxtBx.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 190);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client Production Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // clientAddBtn
            // 
            this.clientAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddBtn.Location = new System.Drawing.Point(33, 390);
            this.clientAddBtn.Name = "clientAddBtn";
            this.clientAddBtn.Size = new System.Drawing.Size(119, 47);
            this.clientAddBtn.TabIndex = 10;
            this.clientAddBtn.Text = "ADD";
            this.clientAddBtn.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1175, 28);
            this.menuStrip1.TabIndex = 21;
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
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductionToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.productionProperitesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // addProductionToolStripMenuItem
            // 
            this.addProductionToolStripMenuItem.Name = "addProductionToolStripMenuItem";
            this.addProductionToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addProductionToolStripMenuItem.Text = "Add Production";
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffTypesToolStripMenuItem,
            this.viewStaffDetailsToolStripMenuItem});
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addStaffToolStripMenuItem.Text = "Production Staff";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(535, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(779, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 47);
            this.button3.TabIndex = 24;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1023, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 47);
            this.button4.TabIndex = 25;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addPrdBtn
            // 
            this.addPrdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdBtn.Location = new System.Drawing.Point(906, 310);
            this.addPrdBtn.Name = "addPrdBtn";
            this.addPrdBtn.Size = new System.Drawing.Size(236, 47);
            this.addPrdBtn.TabIndex = 27;
            this.addPrdBtn.Text = "ADD PRODUCTION";
            this.addPrdBtn.UseVisualStyleBackColor = true;
            this.addPrdBtn.Click += new System.EventHandler(this.addPrdBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 465);
            this.Controls.Add(this.addPrdBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.clientAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clientCoNumberTxtBx);
            this.Controls.Add(this.clientLocationTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientNameTxtBx);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.clientIDTxtBx);
            this.Controls.Add(this.clientIDLabel);
            this.Name = "ClientForm";
            this.Text = "Client Details";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientIDLabel;
        private System.Windows.Forms.TextBox clientIDTxtBx;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientNameTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientLocationTxtBx;
        private System.Windows.Forms.TextBox clientCoNumberTxtBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clientAddBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionProperitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem addProductionToolStripMenuItem;
        private System.Windows.Forms.Button addPrdBtn;
    }
}