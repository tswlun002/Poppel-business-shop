namespace CustomerOrder_system.PresentationLayer
{
    partial class CheckCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNumbertextBox = new System.Windows.Forms.TextBox();
            this.Verifybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerNumbertextBox
            // 
            this.CustomerNumbertextBox.Location = new System.Drawing.Point(161, 61);
            this.CustomerNumbertextBox.Name = "CustomerNumbertextBox";
            this.CustomerNumbertextBox.Size = new System.Drawing.Size(128, 20);
            this.CustomerNumbertextBox.TabIndex = 1;
            // 
            // Verifybutton
            // 
            this.Verifybutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Verifybutton.Location = new System.Drawing.Point(161, 97);
            this.Verifybutton.Name = "Verifybutton";
            this.Verifybutton.Size = new System.Drawing.Size(128, 23);
            this.Verifybutton.TabIndex = 2;
            this.Verifybutton.Text = "Verify";
            this.Verifybutton.UseVisualStyleBackColor = false;
            this.Verifybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 164);
            this.Controls.Add(this.Verifybutton);
            this.Controls.Add(this.CustomerNumbertextBox);
            this.Controls.Add(this.label1);
            this.Name = "CheckCustomer";
            this.Text = "CheckCustomer";
            this.Activated += new System.EventHandler(this.CheckCustomer_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckCustomer_Closed);
            this.Load += new System.EventHandler(this.CheckCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNumbertextBox;
        private System.Windows.Forms.Button Verifybutton;
    }
}