using Infrastructure;
using System.Linq;
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
            // **************************************************
            // **************************************************
            // **************************************************
            // علامت|| علامت یای منطقی است
            //برای بررسی پر یا خالی بودن کنترل های فرم ، کدهای زیر را استفاده می کنیم 
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                //usernameTextBox.Text =
                //	usernameTextBox.Text.Trim();

                //passwordTextBox.Text =
                //	passwordTextBox.Text.Trim();

                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

                return;
            }
            // **************************************************
            // **************************************************
            // **************************************************

            // از این قسمت به بعد باید سر کلاس نوشته شود

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User foundedUser =
                    databaseContext.Users
                    //در دستور زیر به معنی این است که بزرگی و کوچکی حروف برای ما مهم نیستTrue
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();


                if (foundedUser == null)
                {
                    //System.Windows.Forms.MessageBox
                    //	.Show("Username is not correct!");

                    // دقت کنید که در این حالت پیغام باید گنگ باشد

                    System.Windows.Forms.MessageBox
                        .Show("Username and/or Password is not correct!");

                    usernameTextBox.Focus();

                    return;
                }


                if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    //System.Windows.Forms.MessageBox
                    //	.Show("Password is not correct!");

                    // دقت کنید که در این حالت پیغام باید گنگ باشد

                    System.Windows.Forms.MessageBox
                        .Show("Username and/or Password is not correct!");

                    usernameTextBox.Focus();

                    return;
                }


                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox
                        .Show("You can not login to this application! Please contact support team.");

                    usernameTextBox.Focus();

                    return;
                }

                // **************************************************
                // **************************************************
                // **************************************************
                System.Windows.Forms.MessageBox.Show("Welcome!");
                // **************************************************

                // **************************************************
                //Infrastructure.Utility.AuthenticatedUser = foundedUser;

                //Hide();
                // **************************************************

                // **************************************************
                //MainForm mainForm = new MainForm();

                //mainForm.InitializeMainForm();

                //mainForm.Show();
                // **************************************************

                // **************************************************
                //Infrastructure.Utility.MainForm.InitializeMainForm();

                //Infrastructure.Utility.MainForm.Show();
                // **************************************************
                // **************************************************
                // **************************************************
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
            ////******************************************************
            ////******************************************************
            ////******************************************************
            //if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
            //    (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            //{
            //    //usernameTextBox.Text = usernameTextBox.Text.Trim();
            //    //passwordTextBox.Text = passwordTextBox.Text.Trim();

            //    usernameTextBox.Text = usernameTextBox.Text.Replace(" ", string.Empty);
            //    passwordTextBox.Text = passwordTextBox.Text.Replace(" ", string.Empty);

            //    System.Windows.Forms.MessageBox.Show("Username And Password Is Required");
            //    if (usernameTextBox.Text==string.Empty)
            //    {
            //        usernameTextBox.Focus();
            //    }
            //    else
            //    {
            //        passwordTextBox.Focus();
            //    }

            //    return ;
            //}
            ////******************************************************
            ////******************************************************
            ////******************************************************
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
