namespace CustomerOrder_system.PresentationLayer
{
    partial class PopelReport
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
            this.report_listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // report_listView
            // 
            this.report_listView.HideSelection = false;
            this.report_listView.Location = new System.Drawing.Point(12, 48);
            this.report_listView.Name = "report_listView";
            this.report_listView.Size = new System.Drawing.Size(745, 360);
            this.report_listView.TabIndex = 0;
            this.report_listView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXPIRED PRODUCTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PopelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report_listView);
            this.Name = "PopelReport";
            this.Text = "PopelReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.PopelReport_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reportFormClosed);
            this.Load += new System.EventHandler(this.PopelReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView report_listView;
        private System.Windows.Forms.Label label1;
    }
}