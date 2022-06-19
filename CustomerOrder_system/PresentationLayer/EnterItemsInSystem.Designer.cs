namespace CustomerOrder_system.PresentationLayer
{
    partial class EnterItemsInSystem
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Size_textBox = new System.Windows.Forms.TextBox();
            this.AddCart_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNumber_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ITEM SIZE";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(174, 118);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(150, 20);
            this.Name_textBox.TabIndex = 6;
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(174, 204);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(150, 20);
            this.Quantity_textBox.TabIndex = 10;
            // 
            // Size_textBox
            // 
            this.Size_textBox.Location = new System.Drawing.Point(174, 160);
            this.Size_textBox.Name = "Size_textBox";
            this.Size_textBox.Size = new System.Drawing.Size(150, 20);
            this.Size_textBox.TabIndex = 11;
            // 
            // AddCart_button
            // 
            this.AddCart_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddCart_button.Location = new System.Drawing.Point(53, 252);
            this.AddCart_button.Name = "AddCart_button";
            this.AddCart_button.Size = new System.Drawing.Size(271, 23);
            this.AddCart_button.TabIndex = 12;
            this.AddCart_button.Text = "ADD CART";
            this.AddCart_button.UseVisualStyleBackColor = false;
            this.AddCart_button.Click += new System.EventHandler(this.AddCart_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CUSTOMER NUMBER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CustomerNumber_textBox
            // 
            this.CustomerNumber_textBox.Location = new System.Drawing.Point(174, 77);
            this.CustomerNumber_textBox.Name = "CustomerNumber_textBox";
            this.CustomerNumber_textBox.Size = new System.Drawing.Size(150, 20);
            this.CustomerNumber_textBox.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewCartToolStripMenuItem
            // 
            this.viewCartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCartToolStripMenuItem1,
            this.emptyCartToolStripMenuItem});
            this.viewCartToolStripMenuItem.Name = "viewCartToolStripMenuItem";
            this.viewCartToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewCartToolStripMenuItem.Text = "Cart";
            this.viewCartToolStripMenuItem.Click += new System.EventHandler(this.viewCartToolStripMenuItem_Click);
            // 
            // viewCartToolStripMenuItem1
            // 
            this.viewCartToolStripMenuItem1.Name = "viewCartToolStripMenuItem1";
            this.viewCartToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewCartToolStripMenuItem1.Text = "View Cart";
            this.viewCartToolStripMenuItem1.Click += new System.EventHandler(this.viewCartToolStripMenuItem1_Click);
            // 
            // emptyCartToolStripMenuItem
            // 
            this.emptyCartToolStripMenuItem.Name = "emptyCartToolStripMenuItem";
            this.emptyCartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emptyCartToolStripMenuItem.Text = "Empty cart";
            // 
            // EnterItemsInSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 345);
            this.Controls.Add(this.CustomerNumber_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCart_button);
            this.Controls.Add(this.Size_textBox);
            this.Controls.Add(this.Quantity_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EnterItemsInSystem";
            this.RightToLeftLayout = true;
            this.Text = "EnterInSystem";
            this.Load += new System.EventHandler(this.EnterInSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.TextBox Size_textBox;
        private System.Windows.Forms.Button AddCart_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNumber_textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emptyCartToolStripMenuItem;
    }
}