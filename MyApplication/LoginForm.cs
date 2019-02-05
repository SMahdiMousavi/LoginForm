using Infrastructure;
//using Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, System.EventArgs e)
        {
            //******************************************************
            //******************************************************
            //******************************************************
            if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            {
                //usernameTextBox.Text = usernameTextBox.Text.Trim();
                //passwordTextBox.Text = passwordTextBox.Text.Trim();

                usernameTextBox.Text = usernameTextBox.Text.Replace(" ", string.Empty);
                passwordTextBox.Text = passwordTextBox.Text.Replace(" ", string.Empty);

                System.Windows.Forms.MessageBox.Show("Username And Password Is Required");
                if (usernameTextBox.Text==string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

                return ;
            }
            //******************************************************
            //******************************************************
            //******************************************************
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {
            Hide();

        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            resetForm();
        }

        public void resetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



    }
}
