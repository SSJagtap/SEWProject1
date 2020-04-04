using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SEWProject1.Model
{
       public class LoginProvider
    {
        LoginProvider GetLogin = new LoginProvider();
        public string userid { get; set; }
        public string password { get; set; }
  
    public LoginProvider get() 
    {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillManager;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SelectLogin", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
                {
                GetLogin.userid = dr.GetString(0);
                GetLogin.password = dr.GetString(1);
                 }

            return GetLogin;
    }
}
}
