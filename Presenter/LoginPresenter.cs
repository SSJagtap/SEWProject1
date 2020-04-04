using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using SEWProject1.Model;
namespace SEWProject1.Presenter
{
    class LoginPresenter
    {
        LoginProvider loginProvider = new LoginProvider();
        public void Addproduct() 
        {
           var logindata= loginProvider.get();
            Console.WriteLine(logindata);
        }
    }
}
