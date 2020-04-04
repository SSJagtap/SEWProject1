using SEWProject1.Model;
using SEWProject1.Presenter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SEWProject1.View
{
    public partial class FormSignup : Form
    {
        SqlConnection sqlConnection;
        LoginPresenter loginPresenter = new LoginPresenter();
        FormLogin loginform = new FormLogin();
        public string uname;
        public string password;
        public FormSignup()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            var log = loginPresenter.GetLogin();
            if (log.Any(item => item.userid == Username.Text))
            {
                MessageBox.Show("User already there,use other name!!!");
            }
            else
            {
                try
                {
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
                    SqlCommand sqlCommand = new SqlCommand("InsertintoLogin", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    LoginProvider loginProvider = new LoginProvider();
                    loginProvider.userid = Username.Text;
                    loginProvider.password = Password.Text;
                    sqlCommand.Parameters.AddWithValue("@username", loginProvider.userid);
                    sqlCommand.Parameters.AddWithValue("@pass", loginProvider.password);
                    int i = sqlCommand.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Successfully Saved!!");
                        this.Hide();
                        loginform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Something went Wrong!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                { 
                    sqlConnection.Close();
                }
            }
        }
    }
}
    

    