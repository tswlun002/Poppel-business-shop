namespace CustomerOrder_system.PresentationLayer
{
    partial class RegisterCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.EmailAddress_textBox = new System.Windows.Forms.TextBox();
            this.RegisterNext_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ccExpireDate_textBox = new System.Windows.Forms.TextBox();
            this.address_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.accountNumber_textBox2 = new System.Windows.Forms.TextBox();
            this.ccNumber_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // fullname_textBox
            // 
            this.fullname_textBox.Location = new System.Drawing.Point(167, 60);
            this.fullname_textBox.Name = "fullname_textBox";
            this.fullname_textBox.Size = new System.Drawing.Size(144, 20);
            this.fullname_textBox.TabIndex = 3;
            this.fullname_textBox.TextChanged += new System.EventHandler(this.fullname_textBox_TextChanged);
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(167, 100);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(144, 20);
            this.phoneNumber_textBox.TabIndex = 4;
            this.phoneNumber_textBox.TextChanged += new System.EventHandler(this.phoneNumber_textBox_TextChanged);
            // 
            // EmailAddress_textBox
            // 
            this.EmailAddress_textBox.Location = new System.Drawing.Point(167, 138);
            this.EmailAddress_textBox.Name = "EmailAddress_textBox";
            this.EmailAddress_textBox.Size = new System.Drawing.Size(144, 20);
            this.EmailAddress_textBox.TabIndex = 5;
            this.EmailAddress_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RegisterNext_button
            // 
            this.RegisterNext_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegisterNext_button.Location = new System.Drawing.Point(66, 370);
            this.RegisterNext_button.Name = "RegisterNext_button";
            this.RegisterNext_button.Size = new System.Drawing.Size(245, 33);
            this.RegisterNext_button.TabIndex = 6;
            this.RegisterNext_button.Text = "SUBMIT";
            this.RegisterNext_button.UseVisualStyleBackColor = false;
            this.RegisterNext_button.Click += new System.EventHandler(this.RegisterNext_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CC Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Acoount Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Home Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "CC  Expire Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ccExpireDate_textBox
            // 
            this.ccExpireDate_textBox.Location = new System.Drawing.Point(167, 327);
            this.ccExpireDate_textBox.Name = "ccExpireDate_textBox";
            this.ccExpireDate_textBox.Size = new System.Drawing.Size(144, 20);
            this.ccExpireDate_textBox.TabIndex = 11;
            this.ccExpireDate_textBox.TextChanged += new System.EventHandler(this.ccExpireDate_textBox_TextChanged);
            // 
            // address_richTextBox1
            // 
            this.address_richTextBox1.Location = new System.Drawing.Point(167, 173);
            this.address_richTextBox1.Name = "address_richTextBox1";
            this.address_richTextBox1.Size = new System.Drawing.Size(144, 57);
            this.address_richTextBox1.TabIndex = 12;
            this.address_richTextBox1.Text = "";
            this.address_richTextBox1.TextChanged += new System.EventHandler(this.address_richTextBox1_TextChanged);
            // 
            // accountNumber_textBox2
            // 
            this.accountNumber_textBox2.Location = new System.Drawing.Point(167, 246);
            this.accountNumber_textBox2.Name = "accountNumber_textBox2";
            this.accountNumber_textBox2.Size = new System.Drawing.Size(144, 20);
            this.accountNumber_textBox2.TabIndex = 13;
            this.accountNumber_textBox2.TextChanged += new System.EventHandler(this.accountNumber_textBox2_TextChanged);
            // 
            // ccNumber_textBox
            // 
            this.ccNumber_textBox.Location = new System.Drawing.Point(167, 286);
            this.ccNumber_textBox.Name = "ccNumber_textBox";
            this.ccNumber_textBox.Size = new System.Drawing.Size(144, 20);
            this.ccNumber_textBox.TabIndex = 14;
            this.ccNumber_textBox.TextChanged += new System.EventHandler(this.ccNumber_textBox_TextChanged);
            // 
            // RegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 435);
            this.Controls.Add(this.ccNumber_textBox);
            this.Controls.Add(this.accountNumber_textBox2);
            this.Controls.Add(this.address_richTextBox1);
            this.Controls.Add(this.ccExpireDate_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegisterNext_button);
            this.Controls.Add(this.EmailAddress_textBox);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.fullname_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterCustomer";
            this.Text = "RegisterCustomer";
            this.Activated += new System.EventHandler(this.CustomerRegisterForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerRegisterForm_closed);
            this.Load += new System.EventHandler(this.CustomerRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullname_textBox;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.TextBox EmailAddress_textBox;
        private System.Windows.Forms.Button RegisterNext_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ccExpireDate_textBox;
        private System.Windows.Forms.RichTextBox address_richTextBox1;
        private System.Windows.Forms.TextBox accountNumber_textBox2;
        private System.Windows.Forms.TextBox ccNumber_textBox;
    }
}