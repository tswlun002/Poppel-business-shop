namespace CustomerOrder_system.PresentationLayer
{
    partial class ViewCustomers
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
            this.Customer_listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customer_listView
            // 
            this.Customer_listView.HideSelection = false;
            this.Customer_listView.Location = new System.Drawing.Point(29, 47);
            this.Customer_listView.Name = "Customer_listView";
            this.Customer_listView.Size = new System.Drawing.Size(573, 365);
            this.Customer_listView.TabIndex = 0;
            this.Customer_listView.UseCompatibleStateImageBehavior = false;
            this.Customer_listView.SelectedIndexChanged += new System.EventHandler(this.Customer_listView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL CUSTOMERS";
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_listView);
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            this.Activated += new System.EventHandler(this.CustomerView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Closed);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Customer_listView;
        private System.Windows.Forms.Label label1;
    }
}