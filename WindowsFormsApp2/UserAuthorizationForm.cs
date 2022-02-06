using Entities;
using Kursach5.BLL;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserAuthorizationForm : Form
    {
        private readonly UsersBL usersBL;

        public UserAuthorizationForm()
        {
            try
            {
                InitializeComponent();
                usersBL = new UsersBL();
            }
            catch (SqlException)
            {
                ShowInTaskbar = false;
                ServerNotFoundForm form = new ServerNotFoundForm();
                form.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int result = usersBL.UserPasswordCheck(txtLogin.Text, txtPassword.Text);
                if (result == 0)
                {
                    User user = usersBL.GetUserInformationByLogin(txtLogin.Text);
                    if (user.IsBlocked)
                    {
                        ErrorForm UserForm = new ErrorForm("Your account is blocked", Properties.Resources.Stop);
                        UserForm.ShowDialog();
                        {
                            txtLogin.Clear();
                            txtPassword.Clear();
                        }
                    }
                    else
                    {
                        AdminMenuForm Form = new AdminMenuForm(user);
                        Form.ShowDialog();
                        if (Form.DialogResult == DialogResult.Cancel)
                        {
                            if (Form.DeletingAccount)
                            {
                                usersBL.DeleteUser(user.Name);
                            }
                            txtLogin.Clear();
                            txtPassword.Clear();
                        }
                    }
                }
                else
                {
                    string message;
                    if (result == 1)
                    {
                        message = "User not found!";
                    }
                    else
                    {
                        message = "Incorrect password";
                    }
                    ErrorForm error = new ErrorForm(message, Properties.Resources.Error);
                    error.ShowDialog();
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            AccountInfoForm account = new AccountInfoForm();
            account.ShowDialog();
            if (account.DialogResult == DialogResult.Yes)
            {
                txtLogin.Clear();
                txtPassword.Clear();
            }
        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.BackColor = Color.DarkRed;
                e.Cancel = true;
            }
            else
            {
                txtLogin.BackColor = Color.FromArgb(30, 30, 30);
                e.Cancel = false;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BackColor = Color.DarkRed;
                e.Cancel = true;
            }
            else
            {
                txtPassword.BackColor = Color.FromArgb(30, 30, 30);
                e.Cancel = false;
            }
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            FormMainImage.Image = Properties.Resources.Car1010;
        }

        private void btnCreateAccount_MouseMove(object sender, MouseEventArgs e)
        {
            FormMainImage.Image = Properties.Resources.Car1011;
        }

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            FormMainImage.Image = Properties.Resources.Car1009;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            FormMainImage.Image = Properties.Resources.Car1009;
        }

        private void UserAuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ExitForm Exit = new ExitForm();
            Exit.ShowDialog();
        }
    }
}