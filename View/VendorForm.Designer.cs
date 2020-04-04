namespace SEWProject1.View
{
    partial class VendorForm
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
            this.vendoridtextBox = new System.Windows.Forms.TextBox();
            this.vendoraddresstextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vendornametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor Id";
            // 
            // vendoridtextBox
            // 
            this.vendoridtextBox.Location = new System.Drawing.Point(136, 40);
            this.vendoridtextBox.Name = "vendoridtextBox";
            this.vendoridtextBox.Size = new System.Drawing.Size(100, 20);
            this.vendoridtextBox.TabIndex = 1;
            // 
            // vendoraddresstextBox
            // 
            this.vendoraddresstextBox.Location = new System.Drawing.Point(136, 96);
            this.vendoraddresstextBox.Name = "vendoraddresstextBox";
            this.vendoraddresstextBox.Size = new System.Drawing.Size(174, 20);
            this.vendoraddresstextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor Address";
            // 
            // vendornametextBox
            // 
            this.vendornametextBox.Location = new System.Drawing.Point(136, 66);
            this.vendornametextBox.Name = "vendornametextBox";
            this.vendornametextBox.Size = new System.Drawing.Size(174, 20);
            this.vendornametextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendor Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.vendornametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vendoridtextBox);
            this.groupBox1.Controls.Add(this.vendoraddresstextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(244, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 299);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Details";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(136, 153);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(26, 153);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Vendor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddVendor_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Back_Click);
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VendorForm";
            this.Text = "VendorForm";
            this.Load += new System.EventHandler(this.VendorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vendoridtextBox;
        private System.Windows.Forms.TextBox vendoraddresstextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vendornametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}