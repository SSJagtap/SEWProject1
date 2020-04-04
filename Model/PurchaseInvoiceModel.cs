using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SEWProject1.Model
{
    class PurchaseInvoiceModel
    {
      public int Bill_No { get; set; }
      public int Invoice_No { get; set; }
      public string Vendor { get; set; }
     public DateTime Date { get; set; }
      public string Item { get; set; }
      public int Quantity { get; set; }
      public string Shape { get; set; }
      public Int64 Unit_Price { get; set; }
        public Int64 Basic_Price { get; set; }
        public int GST { get; set; }
      public Int64 Total_Amount { get; set; }

        public List<PurchaseInvoiceModel> get()
        {
            List<PurchaseInvoiceModel> purchaselist = new List<PurchaseInvoiceModel>();
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillManager;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SelectPurchaseInvoice", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
           PurchaseInvoiceModel purchaseprod = new PurchaseInvoiceModel();
            while (dr.Read())
            { 
                purchaselist.Add(new PurchaseInvoiceModel()
                {
                    Bill_No = dr.GetInt32(0),
                    Invoice_No =dr.GetInt32(1),
                    Vendor = dr.GetString(2),
                    Date = dr.GetDateTime(3),
                    Item = dr.GetString(4),
                    Quantity = dr.GetInt32(5),
                    Shape = dr.GetString(6),
                    Unit_Price = dr.GetInt64(7),
                    Basic_Price = dr.GetInt64(8),
                    GST = dr.GetInt32(9),
                    Total_Amount = dr.GetInt64(10)
                });
            }
            conn.Close();
            return purchaselist;
        }
        public int getcount() 
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillManager;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PurchaseInvoice", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = dt.Rows.Count+1;
            return i;
        }
    }
}
