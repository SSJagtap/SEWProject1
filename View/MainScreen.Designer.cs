namespace SEWProject1.View
{
    partial class MainScreen
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseInvoiceToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(1, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(126, 308);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.DoubleClickEnabled = true;
            this.purchaseInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInvoiceToolStripMenuItem,
            this.addVendorToolStripMenuItem});
            this.purchaseInvoiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(108, 19);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            // 
            // addInvoiceToolStripMenuItem
            // 
            this.addInvoiceToolStripMenuItem.Name = "addInvoiceToolStripMenuItem";
            this.addInvoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addInvoiceToolStripMenuItem.Text = "Add / Show Invoice";
            this.addInvoiceToolStripMenuItem.Click += new System.EventHandler(this.addInvoiceToolStripMenuItem_Click);
            // 
            // addVendorToolStripMenuItem
            // 
            this.addVendorToolStripMenuItem.Name = "addVendorToolStripMenuItem";
            this.addVendorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVendorToolStripMenuItem.Text = "Add Vendor";
            this.addVendorToolStripMenuItem.Click += new System.EventHandler(this.addVendorToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVendorToolStripMenuItem;
    }
}