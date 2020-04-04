using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SEWProject1.Model
{
    class VendorModel
    {
        public int Vendor_Id { get; set; }
        public string Vendor_Name { get; set; }
        public string Vendor_Address { get; set; }

        public List<VendorModel> get()
        {
            List<VendorModel> vendorlist = new List<VendorModel>();
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillManager;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("selectVendor", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vendorlist.Add(new VendorModel()
                {
                    Vendor_Name = dr.GetString(1)
                }) ; 
            }
            conn.Close();
            return vendorlist;
        }
        public int getcount()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillManager;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Vendor_Table", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = dt.Rows.Count + 1;
            return i;
        }
    }
}
