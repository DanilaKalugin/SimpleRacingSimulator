using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Entities;
using Kursach5.BLL;

namespace WindowsFormsApp2
{
    public partial class AdminMenuForm : Form
    {
        User CurrentUser;
        private enum CurrentGroup { Main, Administration }
        int collectorTier;
        private readonly CarsBL forza7BL;
        private readonly UsersBL usersBL;
        private CurrentGroup currentGroup;

        public bool DeletingAccount { get; internal set; }

        public AdminMenuForm(User user)
        {
            InitializeComponent();
            usersBL = new UsersBL();
            forza7BL = new CarsBL();
            CurrentUser = user;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditCarStats_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(CurrentUser);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                DeletingAccount = form.DeletingAccount;
                form.Dispose();
                Hide();
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                CurrentUser = usersBL.GetUserInformationByLogin(CurrentUser.Login);
                if (File.Exists("BigCarImages2/Car" + CurrentUser.LastPurchasedCarID.ToString("0000") + ".png"))
                {
                    pb_BigCarImage.Image = Image.FromFile("BigCarImages2/Car" + CurrentUser.LastPurchasedCarID.ToString("0000") + ".png");
                }
                collectorTier = forza7BL.GetCollectorTier(out int CollectorScore, out int lowerBorder, out int upperBorder, CurrentUser.Name);
                MyBudget.Text = forza7BL.GetBalance(CurrentUser.Name).ToString("N0", CultureInfo.InvariantCulture) + " CR";
                currentCollectorLevel.Text = collectorTier.ToString();
                CollectorLevelColorDefenition.GetCollectorLevelColor(currentCollectorLevel, collectorTier);
                currentCollectorLevel.Value = (int)((double)(CollectorScore - lowerBorder) / (upperBorder - lowerBorder) * 100);
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            AccountInfoForm account = new AccountInfoForm(CurrentUser);
            account.ShowDialog();
            if (account.DialogResult == DialogResult.Cancel)
            {
                CurrentUser = usersBL.GetUserInformationByLogin(account.NewLogin);
            }
        }

        private void btnBlockUsers_Click(object sender, EventArgs e)
        {
            OtherUsersForm form = new OtherUsersForm();
            form.ShowDialog();
        }

        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            ManufacturersForm form = new ManufacturersForm(CurrentUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void menuItem_MouseEnter(object sender, EventArgs e)
        {
            BackColorChanging(sender as Label, true);
        }

        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            BackColorChanging(sender as Label, false);
        }

        private void BackColorChanging(Label label, bool IsSelected)
        {
            if (IsSelected)
            {
                label.BringToFront();
                label.BackColor = Color.FromArgb(5, 77, 126);
            }
            else
            {
                label.BackColor = Color.FromArgb(40, 40, 40);
            }
        }

        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            currentGroup = CurrentGroup.Main;
            GroupChanging(currentGroup);
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            currentGroup = CurrentGroup.Administration;
            GroupChanging(currentGroup);
        }

        private void GroupChanging(CurrentGroup group)
        {
            btnBlockUsers.Visible = false;
            btnEditAccount.Visible = false;
            btnEditCarStats.Visible = false;
            btnShowStatistics.Visible = false;
            btnManufacturers.Visible = false;

            btnAdministration.BackColor = Color.Black;
            btnMainMenu.BackColor = Color.Black;
            btnAdministration.ForeColor = Color.White;
            btnMainMenu.ForeColor = Color.White;

            switch (group)
            {
                case CurrentGroup.Administration:
                    {
                        btnBlockUsers.Visible = true;
                        btnAdministration.BackColor = Color.WhiteSmoke;
                        btnAdministration.ForeColor = Color.Black;
                        break;
                    }
                case CurrentGroup.Main:
                    {
                        btnEditAccount.Visible = true;
                        btnEditCarStats.Visible = true;
                        btnShowStatistics.Visible = true;
                        btnManufacturers.Visible = true;
                        btnMainMenu.BackColor = Color.WhiteSmoke;
                        btnMainMenu.ForeColor = Color.Black;
                        break;
                    }
            }
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.IsAdmin)
            {
                lb_CurrentUser.Text = "👑" + CurrentUser.Name;
            }
            else
            {
                lb_CurrentUser.Text = CurrentUser.Name;
            }
            currentGroup = CurrentGroup.Main;
            GroupChanging(currentGroup);
            collectorTier = forza7BL.GetCollectorTier(out int CollectorScore, out int lowerBorder, out int upperBorder, CurrentUser.Name);
            MyBudget.Text = forza7BL.GetBalance(CurrentUser.Name).ToString("N0", CultureInfo.InvariantCulture) + " CR";
            currentCollectorLevel.Text = collectorTier.ToString();
            CollectorLevelColorDefenition.GetCollectorLevelColor(currentCollectorLevel, collectorTier);
            currentCollectorLevel.Value = (int)((double)(CollectorScore - lowerBorder) / (upperBorder - lowerBorder) * 100);
            if (File.Exists("BigCarImages2/Car" + CurrentUser.LastPurchasedCarID.ToString("0000") + ".png"))
            {
                pb_BigCarImage.Image = Image.FromFile("BigCarImages2/Car" + CurrentUser.LastPurchasedCarID.ToString("0000") + ".png");
            }
            btnMainMenu.Visible = CurrentUser.IsAdmin;
            btnAdministration.Visible = CurrentUser.IsAdmin;
        }
    }
}