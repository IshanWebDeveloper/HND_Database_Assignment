namespace HND_Database_Assignment
{
    partial class HomePageForm
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
            this.GoToProductionBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToProductionBtn
            // 
            this.GoToProductionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToProductionBtn.Location = new System.Drawing.Point(414, 85);
            this.GoToProductionBtn.Name = "GoToProductionBtn";
            this.GoToProductionBtn.Size = new System.Drawing.Size(269, 66);
            this.GoToProductionBtn.TabIndex = 0;
            this.GoToProductionBtn.Text = "Production Details";
            this.GoToProductionBtn.UseVisualStyleBackColor = true;
            this.GoToProductionBtn.Click += new System.EventHandler(this.GoToProductionBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Client Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToProductionBtn);
            this.Name = "HomePageForm";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToProductionBtn;
        private System.Windows.Forms.Button button1;
    }
}