using SEWProject1.Model;
using SEWProject1.Presenter;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SEWProject1.View
{
    public partial class PurchaseInvoicedata : Form
    { 
        PurchaseInvoicePresenter purchaseInvoicePresenter = new PurchaseInvoicePresenter();
        VendorPresenter vendorPresenter = new VendorPresenter();
        SqlConnection sqlConnection;
        public void showinvoice()
        {
            var ShowInvoicelist = new BindingList<PurchaseInvoiceModel>(purchaseInvoicePresenter.Getpurchase());
            dataGridView1.DataSource = ShowInvoicelist;
        }
        public void showvendor()
        {
            var Showvendorlist = new BindingList<VendorModel>(vendorPresenter.Getvendor());
            foreach (var item in Showvendorlist)
            {
                VendorcomboBox.Items.Add(item.Vendor_Name);
            }
        }
        public PurchaseInvoicedata()
        {
            InitializeComponent();
        }
        private void PurchaseInvoicedata_Load(object sender, EventArgs e)
        {
            showinvoice();
            showvendor();
            groupBox1.Enabled = false;
        }
        private void Add_Invoice_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            Invnotextbox.Text = purchaseInvoicePresenter.getcnt().ToString();
        }
        private void qtytextbox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(qtytextbox.Text) && (!String.IsNullOrEmpty(pricetextbox.Text)))
            {
                BasicPrice_textbox.Text = ((Convert.ToInt32(qtytextbox.Text) * (Convert.ToInt32(pricetextbox.Text))).ToString());
            }
        }
        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(qtytextbox.Text) && (!String.IsNullOrEmpty(pricetextbox.Text)))
            {
                BasicPrice_textbox.Text = ((Convert.ToInt32(qtytextbox.Text) * (Convert.ToInt32(pricetextbox.Text))).ToString());
            }
        }
        private void gsttextbox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(BasicPrice_textbox.Text))
            { int tax = Convert.ToInt32(BasicPrice_textbox.Text) * Convert.ToInt32(gsttextbox.Text) / 100;
                int baseamt = Convert.ToInt32(BasicPrice_textbox.Text);
                int totalamt= baseamt + tax;
                totalamttextbox.Text = totalamt.ToString();
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        private void SaveInvoice_Click(object sender, EventArgs e)
        {
            sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("InsertintoPurchaseInvoice", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();
            PurchaseInvoiceModel purchaseProvider = new PurchaseInvoiceModel();
            purchaseProvider.Bill_No = Convert.ToInt32(Billnotextbox.Text);
            purchaseProvider.Invoice_No = Convert.ToInt32(Invnotextbox.Text);
            purchaseProvider.Vendor = VendorcomboBox.SelectedItem.ToString();
            purchaseProvider.Date = Convert.ToDateTime(dateTimePicker1.Text);
            purchaseProvider.Item = itemtextbox.Text;
            purchaseProvider.Quantity = Convert.ToInt32(qtytextbox.Text);
            purchaseProvider.Shape = shapetextbox.Text;
            purchaseProvider.Unit_Price = Convert.ToInt32(pricetextbox.Text);
            purchaseProvider.Basic_Price = Convert.ToInt32(BasicPrice_textbox.Text);
            purchaseProvider.GST = Convert.ToInt32(gsttextbox.Text);
            purchaseProvider.Total_Amount=Convert.ToInt32(totalamttextbox.Text);
            sqlCommand.Parameters.AddWithValue("@billno", purchaseProvider.Bill_No);
            sqlCommand.Parameters.AddWithValue("@invoiceno", purchaseProvider.Invoice_No);
            sqlCommand.Parameters.AddWithValue("@vendor", purchaseProvider.Vendor);
            sqlCommand.Parameters.AddWithValue("@date", purchaseProvider.Date);
            sqlCommand.Parameters.AddWithValue("@item", purchaseProvider.Item);
            sqlCommand.Parameters.AddWithValue("@qty", purchaseProvider.Quantity);
            sqlCommand.Parameters.AddWithValue("@shape", purchaseProvider.Shape);
            sqlCommand.Parameters.AddWithValue("@price", purchaseProvider.Unit_Price);
            sqlCommand.Parameters.AddWithValue("@basic_amt", purchaseProvider.Basic_Price);
            sqlCommand.Parameters.AddWithValue("@gst", purchaseProvider.GST);
            sqlCommand.Parameters.AddWithValue("@totalamt", purchaseProvider.Total_Amount);
            int i = sqlCommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Successfully Saved!!");
            }
        }
        private void ShowInvoice_Click(object sender, EventArgs e)
        {
            showinvoice();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
        }
    }
}