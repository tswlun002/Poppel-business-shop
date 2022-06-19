namespace CustomerOrder_system.PresentationLayer
{
    partial class ViewCart
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
            this.Cart_listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cart_listView
            // 
            this.Cart_listView.HideSelection = false;
            this.Cart_listView.Location = new System.Drawing.Point(12, 57);
            this.Cart_listView.Name = "Cart_listView";
            this.Cart_listView.Size = new System.Drawing.Size(747, 359);
            this.Cart_listView.TabIndex = 0;
            this.Cart_listView.UseCompatibleStateImageBehavior = false;
            this.Cart_listView.SelectedIndexChanged += new System.EventHandler(this.Cart_listView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CART ITEMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cart_listView);
            this.Name = "ViewCart";
            this.Text = "ViewCart";
            this.Activated += new System.EventHandler(this.Cart_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cart_Closed);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Cart_listView;
        private System.Windows.Forms.Label label1;
    }
}