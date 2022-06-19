namespace CustomerOrder_system
{
    partial class CHECK_CUSTOMER
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
            this.Customer_number = new System.Windows.Forms.Label();
            this.CustomerNumber_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Message_listView = new System.Windows.Forms.ListView();
            this.Submit_customerNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_number
            // 
            this.Customer_number.AutoSize = true;
            this.Customer_number.Location = new System.Drawing.Point(42, 70);
            this.Customer_number.Name = "Customer_number";
            this.Customer_number.Size = new System.Drawing.Size(121, 13);
            this.Customer_number.TabIndex = 0;
            this.Customer_number.Text = "CUSTOMER NUMBER:";
            this.Customer_number.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerNumber_textBox
            // 
            this.CustomerNumber_textBox.Location = new System.Drawing.Point(160, 67);
            this.CustomerNumber_textBox.Name = "CustomerNumber_textBox";
            this.CustomerNumber_textBox.Size = new System.Drawing.Size(140, 20);
            this.CustomerNumber_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUSTOMER STATUSS";
            // 
            // Message_listView
            // 
            this.Message_listView.HideSelection = false;
            this.Message_listView.Location = new System.Drawing.Point(45, 191);
            this.Message_listView.Name = "Message_listView";
            this.Message_listView.Size = new System.Drawing.Size(255, 205);
            this.Message_listView.TabIndex = 3;
            this.Message_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Submit_customerNumber
            // 
            this.Submit_customerNumber.Location = new System.Drawing.Point(45, 104);
            this.Submit_customerNumber.Name = "Submit_customerNumber";
            this.Submit_customerNumber.Size = new System.Drawing.Size(255, 23);
            this.Submit_customerNumber.TabIndex = 4;
            this.Submit_customerNumber.Text = "SUBMIT";
            this.Submit_customerNumber.UseVisualStyleBackColor = true;
            // 
            // CHECK_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.Submit_customerNumber);
            this.Controls.Add(this.Message_listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNumber_textBox);
            this.Controls.Add(this.Customer_number);
            this.Name = "CHECK_CUSTOMER";
            this.Text = "CHECK_CUSTOMER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customer_number;
        private System.Windows.Forms.TextBox CustomerNumber_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Message_listView;
        private System.Windows.Forms.Button Submit_customerNumber;
    }
}

