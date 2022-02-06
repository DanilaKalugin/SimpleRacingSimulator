using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Kursach5.BLL;
using Entities;
using System.Globalization;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class OtherUsersForm : Form
    {
        private readonly UsersBL usersBL;
        private readonly CarsBL forza7BL;
        private List<Country> countries;
        private List<User> users;
        private List<Car> cars;
        private int UserNumber;

        public OtherUsersForm()
        {
            InitializeComponent();
            usersBL = new UsersBL();
            forza7BL = new CarsBL();
        }

        private void UserBlockingForm_Load(object sender, EventArgs e)
        {
            users = usersBL.GetAllUsers().ToList();
            countries = forza7BL.GetCountriesList().ToList();
            cars = forza7BL.GetUnSortedCarList().ToList();
            UserNumber = 0;
            ShowNewUser(UserNumber);
            PurchaseHistory.SelectionChanged += PurchaseHistory_SelectionChanged;
        }

        private void ShowNewUser(int _Number)
        {
            pb_UserCountry.Image = Image.FromFile("CountryFlags/" + users[_Number].Country + ".png");
            PurchaseHistory.DataSource = usersBL.GetPurchaseHistoryForThisUser(users[_Number].Name).ToList();
            txt_UserCountry.Text = countries.Where(s => s.CountryCode == users[_Number].Country).Select(s => s.CountryName).First();
            PurchaseHistory.Columns[1].HeaderText = "Time of purchase";
            PurchaseHistory.Columns[2].HeaderText = "Operation type";
            txtName.Text = users[_Number].Name;
            txtBalance.Text = users[_Number].Balance.ToString("N0", CultureInfo.InvariantCulture) + " CR";
            txtCollectorLevel.Text = users[_Number].CollectorLevel.ToString();
            pbIsBlocked.Visible = !users[_Number].IsAdmin;
            btnBlock.Visible = !users[_Number].IsAdmin;
            lbIsblocked.Visible = !users[_Number].IsAdmin;
            if (users[_Number].IsBlocked)
            {
                pbIsBlocked.Image = Properties.Resources.UserIsBlocked;
                btnBlock.Text = "Unblock this user";
            }
            else
            {
                pbIsBlocked.Image = Properties.Resources.UserIsNotBlocked;
                btnBlock.Text = "Block this user";
            }
        }

        private void UserNumberChanging(PositionChanging.Direction direction)
        {
            switch (direction)
            {
                case PositionChanging.Direction.Up:
                    {
                        if (UserNumber < users.Count - 1)
                        {
                            UserNumber += 1;
                        }
                        else
                        {
                            UserNumber = 0;
                        }
                        break;
                    }
                case PositionChanging.Direction.Down:
                    {
                        if (UserNumber > 0)
                        {
                            UserNumber -= 1;
                        }
                        else
                        {
                            UserNumber = users.Count - 1;
                        }
                        break;
                    }
            }
            ShowNewUser(UserNumber);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            UserNumberChanging(PositionChanging.Direction.Down);
        }

        private void ShowPanel(bool _IsShowed, User user)
        {
            panelBlockUser.Visible = _IsShowed;
            btnPrevious.Enabled = !_IsShowed;
            btnNext.Enabled = !_IsShowed;
            btnBlock.Enabled = !_IsShowed;
            if (user.IsBlocked)
            {
                lb_BlockQuestion.Text = "Do you want to unblock " + user.Name + "?";
                lb_Block_H.Text = "     Unblock this user?".ToUpper();
            }
            else
            {
                lb_BlockQuestion.Text = "Do you want to block " + user.Name + "?";
                lb_Block_H.Text = "      Block this user?".ToUpper();
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            ShowPanel(true, users[UserNumber]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UserNumberChanging(PositionChanging.Direction.Up);
        }

        private void btnBlockingAccepted_Click(object sender, EventArgs e)
        {
            ShowPanel(false, users[UserNumber]);
            usersBL.BlockUser(users[UserNumber].Name);
            users = usersBL.GetAllUsers().ToList();
            ShowNewUser(UserNumber);
        }

        private void btnBlockingDenied_Click(object sender, EventArgs e)
        {
            ShowPanel(false, users[UserNumber]);
        }

        private void UserBlockingForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        UserNumberChanging(PositionChanging.Direction.Down);
                        break;
                    }
                case Keys.Right:
                    {
                        UserNumberChanging(PositionChanging.Direction.Up);
                        break;
                    }
            }
        }

        private void btnClosingAccepted_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void OtherUsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (!panelBlockUser.Visible)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnBlock.Enabled = false;
                panelCloseForm.Visible = true;
            }
        }

        private void btnClosingDenied_Click(object sender, EventArgs e)
        {
            ShowPanel(false, users[UserNumber]);
            panelCloseForm.Visible = false;
        }

        private void PurchaseHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (PurchaseHistory.SelectedRows.Count > 0)
            {
                Car currentCar = cars.Where(car => car.ShortTitle == PurchaseHistory.SelectedRows[0].Cells[0].Value.ToString()).First();
                if (File.Exists("BigCarImages2/Car" + currentCar.ImageNumber.ToString("0000") + ".png"))
                {
                    pb_BigCarImage.Image = Image.FromFile("BigCarImages2/Car" + currentCar.ImageNumber.ToString("0000") + ".png");
                }
                else
                {
                    pb_BigCarImage.Image = null;
                }
            }
            else
            {
                pb_BigCarImage.Image = null;
            }
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