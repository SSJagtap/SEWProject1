using SEWProject1.Model;
using SEWProject1.Presenter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SEWProject1.View
{
    public partial class VendorForm : Form
    {
        VendorPresenter vendorPresenter = new VendorPresenter();
        SqlConnection sqlConnection;
        public VendorForm()
        {
            InitializeComponent();
        }
        
        private void VendorForm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void AddVendor_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            vendoridtextBox.Text = vendorPresenter.getcnt().ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("InsertintoVendor", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();
            VendorModel vendorProvider = new VendorModel();
          
           vendorProvider.Vendor_Id= Convert.ToInt32(vendoridtextBox.Text);
            vendorProvider.Vendor_Name= vendornametextBox.Text;
            vendorProvider.Vendor_Address =(vendoraddresstextBox.Text);
            sqlCommand.Parameters.AddWithValue("@vendorid", vendorProvider.Vendor_Id);
            sqlCommand.Parameters.AddWithValue("@vendor_name", vendorProvider.Vendor_Name);
            sqlCommand.Parameters.AddWithValue("@vendor_address", vendorProvider.Vendor_Address);
            int i = sqlCommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Successfully Saved!!");
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

        private void Back_Click(object sender, EventArgs e)
        {  
                this.Hide();
                MainScreen mainScreen = new MainScreen();
              
        }
    }
}
