namespace SEWProject1.View
{
    partial class PurchaseInvoicedata
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VendorcomboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BasicPrice_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalamttextbox = new System.Windows.Forms.TextBox();
            this.gsttextbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.shapetextbox = new System.Windows.Forms.TextBox();
            this.qtytextbox = new System.Windows.Forms.TextBox();
            this.itemtextbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Invnotextbox = new System.Windows.Forms.TextBox();
            this.Billnotextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Invoice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Invoice_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Invoice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowInvoice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.VendorcomboBox);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.BasicPrice_textbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.totalamttextbox);
            this.groupBox1.Controls.Add(this.gsttextbox);
            this.groupBox1.Controls.Add(this.pricetextbox);
            this.groupBox1.Controls.Add(this.shapetextbox);
            this.groupBox1.Controls.Add(this.qtytextbox);
            this.groupBox1.Controls.Add(this.itemtextbox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Invnotextbox);
            this.groupBox1.Controls.Add(this.Billnotextbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Invoice";
            // 
            // VendorcomboBox
            // 
            this.VendorcomboBox.FormattingEnabled = true;
            this.VendorcomboBox.Location = new System.Drawing.Point(100, 58);
            this.VendorcomboBox.Name = "VendorcomboBox";
            this.VendorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.VendorcomboBox.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveInvoice_Click);
            // 
            // BasicPrice_textbox
            // 
            this.BasicPrice_textbox.Location = new System.Drawing.Point(99, 200);
            this.BasicPrice_textbox.Name = "BasicPrice_textbox";
            this.BasicPrice_textbox.Size = new System.Drawing.Size(138, 20);
            this.BasicPrice_textbox.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Basic_Total";
            // 
            // totalamttextbox
            // 
            this.totalamttextbox.Location = new System.Drawing.Point(100, 257);
            this.totalamttextbox.Name = "totalamttextbox";
            this.totalamttextbox.Size = new System.Drawing.Size(138, 20);
            this.totalamttextbox.TabIndex = 27;
            // 
            // gsttextbox
            // 
            this.gsttextbox.Location = new System.Drawing.Point(99, 228);
            this.gsttextbox.Name = "gsttextbox";
            this.gsttextbox.Size = new System.Drawing.Size(138, 20);
            this.gsttextbox.TabIndex = 26;
            this.gsttextbox.TextChanged += new System.EventHandler(this.gsttextbox_TextChanged);
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(99, 173);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(138, 20);
            this.pricetextbox.TabIndex = 25;
            this.pricetextbox.TextChanged += new System.EventHandler(this.pricetextbox_TextChanged);
            // 
            // shapetextbox
            // 
            this.shapetextbox.Location = new System.Drawing.Point(99, 151);
            this.shapetextbox.Name = "shapetextbox";
            this.shapetextbox.Size = new System.Drawing.Size(138, 20);
            this.shapetextbox.TabIndex = 24;
            // 
            // qtytextbox
            // 
            this.qtytextbox.Location = new System.Drawing.Point(99, 128);
            this.qtytextbox.Name = "qtytextbox";
            this.qtytextbox.Size = new System.Drawing.Size(138, 20);
            this.qtytextbox.TabIndex = 23;
            this.qtytextbox.TextChanged += new System.EventHandler(this.qtytextbox_TextChanged);
            // 
            // itemtextbox
            // 
            this.itemtextbox.Location = new System.Drawing.Point(99, 106);
            this.itemtextbox.Name = "itemtextbox";
            this.itemtextbox.Size = new System.Drawing.Size(138, 20);
            this.itemtextbox.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // Invnotextbox
            // 
            this.Invnotextbox.Location = new System.Drawing.Point(99, 41);
            this.Invnotextbox.Name = "Invnotextbox";
            this.Invnotextbox.Size = new System.Drawing.Size(40, 20);
            this.Invnotextbox.TabIndex = 19;
            // 
            // Billnotextbox
            // 
            this.Billnotextbox.Location = new System.Drawing.Point(99, 13);
            this.Billnotextbox.Name = "Billnotextbox";
            this.Billnotextbox.Size = new System.Drawing.Size(40, 20);
            this.Billnotextbox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "GST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Shape";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Purchase Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Invoice No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Vendor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Bill No.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 312);
            this.dataGridView1.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(42, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Purchase Invoice";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(195, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Back_Click);
            // 
            // PurchaseInvoicedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 593);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PurchaseInvoicedata";
            this.Text = "Show Invoice";
            this.Load += new System.EventHandler(this.PurchaseInvoicedata_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalamttextbox;
        private System.Windows.Forms.TextBox gsttextbox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.TextBox shapetextbox;
        private System.Windows.Forms.TextBox qtytextbox;
        private System.Windows.Forms.TextBox itemtextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Invnotextbox;
        private System.Windows.Forms.TextBox Billnotextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BasicPrice_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox VendorcomboBox;
        private System.Windows.Forms.Button button5;
    }
}