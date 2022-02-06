using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entities;
using Kursach5.BLL;

namespace WindowsFormsApp2
{
    public partial class AccountInfoForm : Form
    {
        private readonly UsersBL usersBL;
        private readonly CarsBL forza7BL;
        private bool CreatingUser;
        private User CurrentUser;
        public string NewLogin;
        public string currentCountry;
        List<Country> countries;
        List<string> SortingTypes;
        private bool IsClosing;
        private bool accountISUpdated;
        public AccountInfoForm()
        {
            InitializeComponent();
            usersBL = new UsersBL();
            forza7BL = new CarsBL();
            CreatingUser = true;
            IsClosing = false;
            FormMainImage.Image = Properties.Resources.Car1013;
        }

        public AccountInfoForm(User user)
        {
            InitializeComponent();
            usersBL = new UsersBL();
            forza7BL = new CarsBL();
            CurrentUser = user;
            CreatingUser = false;
            IsClosing = false;
            FormMainImage.Image = Properties.Resources.Car1014;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                panelUpdateUser.Visible = true;
                ChangingActiveControls(true);
            }
        }

        private void ChangingActiveControls(bool IsDialog)
        {
            txtLogin.Enabled = !IsDialog;
            txtName.Enabled = !IsDialog;
            txtPassword.Enabled = !IsDialog;
            txtPassword2.Enabled = !IsDialog;
            txt_UserCountry.Enabled = !IsDialog;
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            txtValidating(txtPassword, e, UserPasswordErrorText, "Password");
        }

        private void txtValidating(TextBox txt, CancelEventArgs e, Label l, string header)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.DarkRed;
                e.Cancel = true;
                l.Text = "Field \"" + header + "\" cannot be empty";
                l.ForeColor = Color.Red;
            }
            else
            {
                txt.BackColor = Color.FromArgb(40, 40, 40);
                e.Cancel = false;
                l.Text = "";
                l.ForeColor = Color.Green;
            }
        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            txtValidating(txtLogin, e, UserLoginErrorText, "Login");
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            txtValidating(txtName, e, UserNameErrorText, "Name");
        }

        private void txtPassword2_Validating(object sender, CancelEventArgs e)
        {
            txtValidating(txtPassword2, e, UserPassword2ErrorText, "Repeat password");
            if (txtPassword2.Text != txtPassword.Text)
            {
                txtPassword2.BackColor = Color.DarkOrange;
                e.Cancel = true;
                UserPassword2ErrorText.Text = "Passwords don't match";
                UserPassword2ErrorText.ForeColor = Color.Orange;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword2.BackColor = Color.DarkRed;
                    e.Cancel = false;
                    UserPassword2ErrorText.Text = "Field \"Password\" cannot be empty";
                    UserPassword2ErrorText.ForeColor = Color.Red;
                }
                else
                {
                    txtPassword2.BackColor = Color.Green;
                    e.Cancel = false;
                    UserPassword2ErrorText.Text = "Passwords match";
                    UserPassword2ErrorText.ForeColor = Color.Green;
                }
            }
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            countries = forza7BL.GetCountriesList().ToList();
            SortingTypes = usersBL.GetSortingTypesList().ToList();
            txt_UserCountry.Items.AddRange(countries.OrderBy(country => country.CountryName).Select(s => s.CountryName).ToArray());
            cb_SortingTypes.Items.AddRange(SortingTypes.ToArray());
            if (CreatingUser)
            {
                btnOK.Text = "Create";
                Text = "Creating new account";
                lb_Block_H.Text = "     CREATE ACCOUNT?";
                lb_UpdateQuestion.Text = "Do you want to create account?";
            }
            else
            {
                btnOK.Text = "Update";
                Text = "Updating account";
                lb_Block_H.Text = "     UPDATE ACCOUNT?";
                lb_UpdateQuestion.Text = "Do you want to update your account?";
                txtName.Text = CurrentUser.Name;
                txtLogin.Text = CurrentUser.Login;
                cb_SortingTypes.SelectedIndex = (int)CurrentUser.DefaultSortingType;
                pb_UserCountry.Image = Image.FromFile("CountryFlags/" + CurrentUser.Country + ".png");
                txt_UserCountry.Text = countries.Where(s => s.CountryCode == CurrentUser.Country).Select(s => s.CountryName).First();
            }
        }

        private void btnUpdatingAccepted_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreatingUser)
                {
                    usersBL.AddUser(txtName.Text, txtLogin.Text, txtPassword.Text, currentCountry, cb_SortingTypes.SelectedIndex);
                }
                else
                {
                    usersBL.UpdateUser(CurrentUser.Name, txtName.Text, txtLogin.Text, txtPassword.Text, currentCountry, cb_SortingTypes.SelectedIndex);
                    NewLogin = txtLogin.Text;
                }
                accountISUpdated = true;
                DialogResult = DialogResult.Yes;
                Hide();
            }
            catch (SqlException ex)
            {
                ErrorForm error = new ErrorForm(ex.Message, Properties.Resources.Error);
                error.ShowDialog();
                accountISUpdated = false;
                panelUpdateUser.Visible = false;
                ChangingActiveControls(false);
            }
        }

        private void btnUpdatingDenied_Click(object sender, EventArgs e)
        {
            panelUpdateUser.Visible = false;
            ChangingActiveControls(false);
        }

        private void btnClosingAccepted_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AccountInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
                if (!accountISUpdated)
                {
                    if (!panelUpdateUser.Visible)
                    {
                        panelCloseForm.Visible = true;
                        ChangingActiveControls(true);
                    }
                }
            }
        }

        private void btnClosingDenied_Click(object sender, EventArgs e)
        {
            panelCloseForm.Visible = false;
            ChangingActiveControls(false);
        }

        private void txt_UserCountry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UserCountry.Text))
            {
                txt_UserCountry.BackColor = Color.DarkRed;
                e.Cancel = true;
                UserCountryErrorText.Text = "Field \"" + "Country" + "\" cannot be empty";
                UserCountryErrorText.ForeColor = Color.Red;
            }
            else
            {
                txt_UserCountry.BackColor = Color.FromArgb(40, 40, 40);
                e.Cancel = false;
                UserCountryErrorText.Text = "";
                UserCountryErrorText.ForeColor = Color.Green;
            }
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            IsClosing = true;
            accountISUpdated = false;
            Close();
        }

        private void btnFormClose_MouseMove(object sender, MouseEventArgs e)
        {
            FormMainImage.Image = Properties.Resources.Car1015;
        }

        private void btnFormClose_MouseLeave(object sender, EventArgs e)
        {
            if (CreatingUser)
            {
                FormMainImage.Image = Properties.Resources.Car1013;
            }
            else
            {
                FormMainImage.Image = Properties.Resources.Car1014;
            }
        }

        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            FormMainImage.Image = Properties.Resources.Car1016;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            if (CreatingUser)
            {
                FormMainImage.Image = Properties.Resources.Car1013;
            }
            else
            {
                FormMainImage.Image = Properties.Resources.Car1014;
            }
        }

        private void txt_UserCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCountry = countries.Where(country => country.CountryName == txt_UserCountry.SelectedItem.ToString()).Select(country => country.CountryCode).First();
            pb_UserCountry.Image = Image.FromFile("CountryFlags\\" + currentCountry + ".png");
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            MouseActions.MouseEnter(sender as Button);
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            MouseActions.MouseLeave(sender as Button);
        }
    }
}