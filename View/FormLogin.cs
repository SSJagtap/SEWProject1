using SEWProject1.Presenter;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SEWProject1.View
{
    public partial class FormLogin : Form
    {
        LoginPresenter loginPresenter = new LoginPresenter();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var log=  loginPresenter.GetLogin();
            if ((log.Any(item => item.userid == Username.Text) & log.Any(pass => pass.password == Password.Text)))
                {
                this.Hide();
                 MainScreen mainScreen = new MainScreen();
                 mainScreen.Show();
            }
            else
            {
                MessageBox.Show("Incorrect details!!");
            }
        }
        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSignup formSignup=new FormSignup();
            formSignup.Show();
        }
    }
}
