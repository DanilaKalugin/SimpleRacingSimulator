using Kursach5.BLL;
using System;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace WindowsFormsApp2
{
    public partial class ManufacturersForm : Form
    {
        private readonly CarsBL forza7BL;
        private readonly ManufacturersBL manufacturersBL;
        private List<List<Manufacturer>> manufacturers;
        List<string> groups;
        List<Country> countries;
        private ManufacturersBL.SortingType sortingType;
        int groupNumber;
        int manufacturerNumber;
        bool isEditing;
        Manufacturer manufacturerWithNewInfo;
        List<string> existingManufacturerTitles;
        List<string> existingManufacturerShortTitles;
        private bool savingBeforeReturnToMainMenu;
        private bool EditCurrentManufacturerFromMainForm;
        public Manufacturer ManufacturerWithChangedInfo;
        private User CurrentUser;
        private bool AddingNewManufacturer;

        public ManufacturersForm(User user)
        {
            InitializeComponent();
            forza7BL = new CarsBL();
            manufacturersBL = new ManufacturersBL();
            existingManufacturerTitles = new List<string>();
            existingManufacturerShortTitles = new List<string>();
            countries = forza7BL.GetCountriesList().ToList();
            sortingType = ManufacturersBL.SortingType.Country;
            CurrentUser = user;
            btnEditManufacturerStats.Visible = user.IsAdmin;
            cb_ManufacturerCountries.Items.AddRange(countries.Select(country => country.CountryName).ToArray());
            EditCurrentManufacturerFromMainForm = false;
            DisplayManufacturers(sortingType);
        }

        public ManufacturersForm(Manufacturer manufacturer)
        {
            InitializeComponent();
            forza7BL = new CarsBL();
            manufacturersBL = new ManufacturersBL();
            existingManufacturerTitles = new List<string>();
            existingManufacturerShortTitles = new List<string>();
            countries = forza7BL.GetCountriesList().ToList();
            sortingType = ManufacturersBL.SortingType.Country;
            cb_ManufacturerCountries.Items.AddRange(countries.Select(country => country.CountryName).ToArray());
            DisplayManufacturers(sortingType);
            groupNumber = groups.IndexOf(countries.Where(country => country.CountryCode == manufacturer.Country).Select(country => country.CountryName).Min());
            if (groupNumber == -1)
            {
                manufacturers.Add(new List<Manufacturer>());
                groups.Add("");
                groupNumber = manufacturers.Count - 1;
                AddingNewManufacturer = true;
            }
            else
            {
                AddingNewManufacturer = false;
            }
            GroupChanged(groupNumber);
            manufacturerNumber = manufacturers[groupNumber].IndexOf(manufacturers[groupNumber].Where(manufacturerInfo => manufacturerInfo.Number == manufacturer.Number).Min());
            if (manufacturerNumber == -1)
            {
                manufacturers[groupNumber].Add(manufacturer);
                manufacturerNumber = 0;
            }
            ManufacturerChanged(manufacturers[groupNumber][manufacturerNumber]);
            EditCurrentManufacturerFromMainForm = true;
            if (AddingNewManufacturer)
            {
                WorkWithImages.GetNewImage(manufacturerCurrent, manufacturerImage);
            }
            StartOfEditing(manufacturers[groupNumber][manufacturerNumber]);
        }

        private void ManufacturersForm_Load(object sender, EventArgs e)
        {
            btnDecreaseGroupNumberBy5.Enabled = false;
            isEditing = false;
            foreach (List<Manufacturer> manufacturersGroup in manufacturers)
            {
                existingManufacturerTitles.AddRange(manufacturersGroup.Select(manufacturer => manufacturer.Title.ToLower()).ToList());
                existingManufacturerShortTitles.AddRange(manufacturersGroup.Select(manufacturer => manufacturer.ShortTitle.ToLower()).ToList());
            }
        }
        private void DisplayManufacturers(ManufacturersBL.SortingType sortingType)
        {
            manufacturers = manufacturersBL.GetManufacturerslistGroupByParameter(out groups, sortingType);
            groupNumber = 0;
            GroupChanged(groupNumber);
            manufacturerNumber = 0;
            switch (sortingType)
            {
                case ManufacturersBL.SortingType.Country:
                    {
                        btnChangeSortingType.Text = "Sort alphabetically";
                        break;
                    }
                case ManufacturersBL.SortingType.FirstLetter:
                    {
                        btnChangeSortingType.Text = "Sort by country";
                        break;
                    }
            }
        }

        public void GroupChanged(int i)
        {
            currentManufacturer.Text = groups[i];
            groupAvailabilityCheck(GroupNumberGreaterBy1, 1);
            groupAvailabilityCheck(GroupNumberGreaterBy2, 2);
            groupAvailabilityCheck(GroupNumberGreaterBy3, 3);
            groupAvailabilityCheck(GroupNumberGreaterBy4, 4);
            groupAvailabilityCheck(GroupNumberGreaterBy5, 5);
            manufacturerNumber = 0;
            if (manufacturers[i].Count != 0)
            {
                ManufacturerChanged(manufacturers[groupNumber][manufacturerNumber]);
            }
        }

        private void groupAvailabilityCheck(Label l, int step)
        {
            if (groupNumber < groups.Count - step)
            {
                l.Text = groups[groupNumber + step];
            }
            else
            {
                l.Text = null;
            }
        }

        private void groupNumberChanging(int step, PositionChanging.Direction direction)
        {
            PositionChanging.groupNumberChanging(step, direction, groups, ref groupNumber);
            GroupChanged(groupNumber);
            manufacturerNumber = 0;
            ManufacturerChanged(manufacturers[groupNumber][manufacturerNumber]);
        }

        private void btnIncreaseGroupNumberBy7_Click(object sender, EventArgs e)
        {
            groupNumberChanging(5, PositionChanging.Direction.Up);
        }

        private void btnDecreaseGroupNumberBy7_Click(object sender, EventArgs e)
        {
            groupNumberChanging(5, PositionChanging.Direction.Down);
        }

        private void GroupNumberGreaterBy1_Click(object sender, EventArgs e)
        {
            groupNumberChanging(1, PositionChanging.Direction.Up);
        }

        private void GroupNumberGreaterBy2_Click(object sender, EventArgs e)
        {
            groupNumberChanging(2, PositionChanging.Direction.Up);
        }

        private void GroupNumberGreaterBy3_Click(object sender, EventArgs e)
        {
            groupNumberChanging(3, PositionChanging.Direction.Up);
        }

        private void GroupNumberGreaterBy4_Click(object sender, EventArgs e)
        {
            groupNumberChanging(4, PositionChanging.Direction.Up);
        }

        private void GroupNumberGreaterBy5_Click(object sender, EventArgs e)
        {
            groupNumberChanging(5, PositionChanging.Direction.Up);
        }

        private void ManufacturerCountryFlagAvailibilityCheck(Manufacturer manufacturer)
        {
            if (File.Exists("CountryFlags/" + manufacturer.Country + ".png"))
            {
                pb_ManufacturerCountry.Image = Image.FromFile("CountryFlags/" + manufacturer.Country + ".png");
            }
            else
            {
                pb_ManufacturerCountry.Image = null;
            }
        }

        private void ManufacturerChanged(Manufacturer manufacturer)
        {
            ManufacturerCountryFlagAvailibilityCheck(manufacturer);
            lb_manufacturer.Text = manufacturer.Title;
            lb_ManufacturerCountry.Text = countries.Where(country => country.CountryCode == manufacturer.Country).Select(country => country.CountryName).Min();
            lbCarsCount.Text = manufacturersBL.GetCarsCountForManufacturer(manufacturer).ToString();
            manufacturersLogoShowing(groupNumber, manufacturerNumber);
        }

        private void manufacturersLogoShowing(int groupNumber, int elementNumber)
        {
            if (elementNumber > 0)
            {
                if (File.Exists("ManufacturerLogos/Manufacturer" + manufacturers[groupNumber][elementNumber - 1].Number.ToString("0000") + ".png"))
                {
                    manufacturerNumberLessBy1.Image = Image.FromFile("ManufacturerLogos/Manufacturer" + manufacturers[groupNumber][elementNumber - 1].Number.ToString("0000") + ".png");
                }
                else
                {
                    manufacturerNumberLessBy1.Image = null;
                }
            }
            else
            {
                manufacturerNumberLessBy1.Image = null;
            }

            if (File.Exists("ManufacturerLogos/Manufacturer" + manufacturers[groupNumber][elementNumber].Number.ToString("0000") + ".png"))
            {
                manufacturerCurrent.Image = Image.FromFile("ManufacturerLogos/Manufacturer" + manufacturers[groupNumber][elementNumber].Number.ToString("0000") + ".png");
            }
            else
            {
                manufacturerCurrent.Image = null;
            }

            if (elementNumber < manufacturers[groupNumber].Count - 1)
            {
                if (File.Exists("ManufacturerLogos/Manufacturer" + manufacturers[groupNumber][elementNumber + 1].Number.ToString("0000") + ".png"))
                {
                    manufacturerNumberUpBy1.Image = Image.FromFile("ManufacturerLogos/Manufacturer" + manufacturers[groupNumber][elementNumber + 1].Number.ToString("0000") + ".png");
                }
                else
                {
                    manufacturerNumberUpBy1.Image = null;
                }
            }
            else
            {
                manufacturerNumberUpBy1.Image = null;
            }
        }

        private void manufacturerNumberUpBy1_Click(object sender, EventArgs e)
        {
            ManufacturerNumberChanging(1, PositionChanging.Direction.Up);
            if (manufacturerNumber == manufacturers[groupNumber].Count - 1)
            {
                manufacturerNumberUpBy1.BorderStyle = BorderStyle.None;
            }
            else
            {
                manufacturerNumberUpBy1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        public void ManufacturerNumberChanging(int step, PositionChanging.Direction direction)
        {
            PositionChanging.elementNumberChanging(step, direction, manufacturers[groupNumber], ref manufacturerNumber);
            ManufacturerChanged(manufacturers[groupNumber][manufacturerNumber]);
        }

        private void manufacturerNumberLessBy1_Click(object sender, EventArgs e)
        {
            ManufacturerNumberChanging(1, PositionChanging.Direction.Down);
            if (manufacturerNumber == 0)
            {
                manufacturerNumberLessBy1.BorderStyle = BorderStyle.None;
            }
            else
            {
                manufacturerNumberLessBy1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void SortingTypeChanged(ManufacturersBL.SortingType newSortingType)
        {
            if (sortingType != newSortingType)
            {
                sortingType = newSortingType;
                DisplayManufacturers(sortingType);
            }
        }

        private void ManufacturersForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnChangeSortingType.Enabled)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        {
                            ManufacturerNumberChanging(1, PositionChanging.Direction.Up);
                            break;
                        }
                    case Keys.Up:
                        {
                            ManufacturerNumberChanging(1, PositionChanging.Direction.Down);
                            break;
                        }
                    case Keys.PageDown:
                        {
                            ManufacturerNumberChanging(5, PositionChanging.Direction.Up);
                            break;
                        }
                    case Keys.PageUp:
                        {
                            ManufacturerNumberChanging(5, PositionChanging.Direction.Down);
                            break;
                        }
                    case Keys.Left:
                        {
                            groupNumberChanging(1, PositionChanging.Direction.Down);
                            break;
                        }
                    case Keys.Right:
                        {
                            groupNumberChanging(1, PositionChanging.Direction.Up);
                            break;
                        }
                    case Keys.Oem6:
                        {
                            groupNumberChanging(5, PositionChanging.Direction.Up);
                            break;
                        }
                    case Keys.OemOpenBrackets:
                        {
                            groupNumberChanging(5, PositionChanging.Direction.Down);
                            break;
                        }
                    case Keys.Escape:
                        {
                            Close();
                            break;
                        }
                }
            }
        }

        private void btnChangeSortingType_Click(object sender, EventArgs e)
        {
            switch (sortingType)
            {
                case ManufacturersBL.SortingType.Country:
                    {
                        SortingTypeChanged(ManufacturersBL.SortingType.FirstLetter);
                        break;
                    }
                case ManufacturersBL.SortingType.FirstLetter:
                    {
                        SortingTypeChanged(ManufacturersBL.SortingType.Country);
                        break;
                    }
            }
        }

        private void ManufacturersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (EditCurrentManufacturerFromMainForm)
            {
                isEditing = true;
            }
            if (isEditing)
            {
                if (ValidateChildren())
                {
                    panelSaveNewStats.Visible = true;
                    savingBeforeReturnToMainMenu = true;
                }
            }
            else
            {
                panelReturnToMainMenu.Visible = true;
            }
        }

        private void btnReturnToMainMenuAccepted_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnReturnToMainMenuDenied_Click(object sender, EventArgs e)
        {
            panelReturnToMainMenu.Visible = false;
        }

        private void StartOfEditing(Manufacturer ManufacturerForChanging)
        {
            isEditing = true;
            manufacturerWithNewInfo = new Manufacturer(ManufacturerForChanging.Number, ManufacturerForChanging.Title, ManufacturerForChanging.Country, ManufacturerForChanging.ShortTitle);
            EditingStarted(isEditing);
            ChangeVisibleControls(isEditing);
            newManufacturerTitle.Text = manufacturerWithNewInfo.Title;
            cb_ManufacturerCountries.Text = lb_ManufacturerCountry.Text;
            txt_ShortTitle.Text = manufacturerWithNewInfo.ShortTitle;
        }

        private void btnEditManufacturerStats_Click(object sender, EventArgs e)
        {
            StartOfEditing(manufacturers[groupNumber][manufacturerNumber]);
        }

        private void EditingStarted(bool IsEditing)
        {
            btnChangeSortingType.Enabled = !IsEditing;
            btnEditManufacturerStats.Enabled = !IsEditing;
            manufacturerNumberLessBy1.Enabled = !IsEditing;
            manufacturerNumberUpBy1.Enabled = !IsEditing;
            GroupNumberGreaterBy1.Enabled = !IsEditing;
            GroupNumberGreaterBy2.Enabled = !IsEditing;
            GroupNumberGreaterBy3.Enabled = !IsEditing;
            GroupNumberGreaterBy4.Enabled = !IsEditing;
            GroupNumberGreaterBy5.Enabled = !IsEditing;
            btnIncreaseGroupNumberBy5.Enabled = !IsEditing;
            btnDecreaseGroupNumberBy5.Enabled = !IsEditing;
        }

        private void ChangeVisibleControls(bool IsEditing)
        {
            newManufacturerTitle.Visible = IsEditing;
            cb_ManufacturerCountries.Visible = IsEditing;
            btnSaveDialog.Visible = IsEditing;
            lbShortTitle.Visible = IsEditing;
            txt_ShortTitle.Visible = IsEditing;
        }

        private void textBoxValidation(TextBox field, string header, Label errorText, List<string> existingFields, string oldValue, CancelEventArgs e)
        {
            string input = field.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                field.BackColor = Color.DarkRed;
                errorText.Text = "Field \"" + header + "\" cannot be empty";
                errorText.ForeColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                if (!((input[0] >= 'A' && input[0] <= 'Z') || (input[0] >= 'a' && input[0] <= 'z')))
                {
                    field.BackColor = Color.Sienna;
                    errorText.Text = header + " must begin with a letter of the English alphabet";
                    errorText.ForeColor = Color.Sienna;
                    e.Cancel = true;
                }
                else
                {
                    if (existingFields.IndexOf(input.ToLower()) != -1 && input.ToLower() != oldValue.ToLower().Trim())
                    {
                        field.BackColor = Color.DarkOrange;
                        errorText.Text = "Manufacturer with this " + header + " already exists";
                        errorText.ForeColor = Color.DarkOrange;
                        e.Cancel = true;
                    }
                    else
                    {
                        field.BackColor = Color.FromArgb(40, 40, 40);
                        errorText.Text = "";
                        errorText.ForeColor = field.BackColor;
                        e.Cancel = false;
                    }

                }
            }
        }

        private void newManufacturerTitle_Validating(object sender, CancelEventArgs e)
        {
            textBoxValidation(newManufacturerTitle, "Title", ManufacturerTitleErrorText, existingManufacturerTitles, manufacturers[groupNumber][manufacturerNumber].Title, e);
        }

        private void cb_ManufacturerCountries_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_ManufacturerCountries.Text))
            {
                cb_ManufacturerCountries.BackColor = Color.DarkRed;
                e.Cancel = true;
                ManufacturerCountryErrorText.Text = "Field \"" + "Country" + "\" cannot be empty";
                ManufacturerCountryErrorText.ForeColor = Color.Red;
            }
            else
            {
                cb_ManufacturerCountries.BackColor = Color.FromArgb(40, 40, 40);
                e.Cancel = false;
                ManufacturerCountryErrorText.Text = "";
                ManufacturerCountryErrorText.ForeColor = Color.Green;
            }
        }

        private void btnSaveDialog_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                panelSaveNewStats.Visible = true;
                savingBeforeReturnToMainMenu = false;
                ChangeVisibleControls(false);
                string newTitle = manufacturerWithNewInfo.Title.Substring(0, 1).ToUpper() + manufacturerWithNewInfo.Title.Substring(1, manufacturerWithNewInfo.Title.Length - 1);
                manufacturerWithNewInfo.Title = newTitle;
                lb_manufacturer.Text = manufacturerWithNewInfo.Title;
                lb_ManufacturerCountry.Text = cb_ManufacturerCountries.Text;
            }
        }

        private void newManufacturerTitle_TextChanged(object sender, EventArgs e)
        {
            manufacturerWithNewInfo.Title = newManufacturerTitle.Text;
        }

        private void newManufacturerInfoSavingCancelled_Click(object sender, EventArgs e)
        {
            isEditing = true;
            ChangeVisibleControls(isEditing);
            panelSaveNewStats.Visible = false;
        }

        private void newManufacturerInfoSavingDenied_Click(object sender, EventArgs e)
        {
            isEditing = false;
            panelSaveNewStats.Visible = false;
            if (EditCurrentManufacturerFromMainForm)
            {
                manufacturerWithNewInfo = manufacturers[groupNumber][manufacturerNumber];
                ManufacturerWithChangedInfo = manufacturerWithNewInfo;
                Hide();
            }
            else if (!savingBeforeReturnToMainMenu)
            {
                EditingStarted(isEditing);
                ChangeVisibleControls(isEditing);
                ManufacturerChanged(manufacturers[groupNumber][manufacturerNumber]);
            }
            else Hide();
        }

        private void newManufacturerInfoSavingAccepted_Click(object sender, EventArgs e)
        {
            isEditing = false;
            panelSaveNewStats.Visible = false;
            if (AddingNewManufacturer)
            {
                WorkWithImages.SaveNewImage(manufacturerCurrent, manufacturerImage, "ManufacturerLogos/Manufacturer", manufacturerWithNewInfo.Number);
                manufacturersBL.AddManufacturer(manufacturerWithNewInfo);
            }
            else
            {
                manufacturersBL.UpdateManufacturer(manufacturerWithNewInfo);
            }
            if (savingBeforeReturnToMainMenu)
            {
                Hide();
            }
            else if (EditCurrentManufacturerFromMainForm)
            {
                if (!AddingNewManufacturer)
                {
                    ManufacturerWithChangedInfo = manufacturerWithNewInfo;
                }
                Hide();
            }
            else
            {
                DisplayManufacturers(sortingType);
                existingManufacturerTitles.Clear();
                foreach (List<Manufacturer> manufacturersGroup in manufacturers)
                {
                    existingManufacturerTitles.AddRange(manufacturersGroup.Select(manufacturer => manufacturer.Title.ToLower()).ToList());
                    existingManufacturerShortTitles.AddRange(manufacturersGroup.Select(manufacturer => manufacturer.ShortTitle.ToLower()).ToList());
                }
                ChangeVisibleControls(isEditing);
                EditingStarted(isEditing);
                string NewValue;
                switch (sortingType)
                {
                    case ManufacturersBL.SortingType.Country:
                        {
                            NewValue = cb_ManufacturerCountries.Text;
                            groupNumber = groups.IndexOf(NewValue);
                            break;
                        }
                    case ManufacturersBL.SortingType.FirstLetter:
                        {
                            NewValue = manufacturerWithNewInfo.Title[0].ToString();
                            groupNumber = groups.IndexOf(NewValue);
                            break;
                        }
                }
                GroupChanged(groupNumber);
                Manufacturer manufacturerWithSavedStats = manufacturers[groupNumber].Where(manufacturer => manufacturer.Number == manufacturerWithNewInfo.Number).Min();
                manufacturerNumber = manufacturers[groupNumber].IndexOf(manufacturerWithSavedStats);
                ManufacturerChanged(manufacturers[groupNumber][manufacturerNumber]);
            }
        }

        private void manufacturerCurrent_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid);
        }

        private void ManufacturersformMouseEnter(object sender, EventArgs e)
        {
            MouseActions.MouseEnter(sender as Label, MouseActions.ItemType.Group);
        }

        private void ManufacturersFormMouseLeave(object sender, EventArgs e)
        {
            MouseActions.MouseLeave(sender as Label, MouseActions.ItemType.Group);
        }

        private void manufacturerNumberUpBy1_MouseEnter(object sender, EventArgs e)
        {
            if (manufacturerNumber < manufacturers[groupNumber].Count - 1)
            {
                manufacturerNumberUpBy1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                manufacturerNumberUpBy1.BorderStyle = BorderStyle.None;
            }
        }

        private void manufacturerNumberUpBy1_MouseLeave(object sender, EventArgs e)
        {
            manufacturerNumberUpBy1.BorderStyle = BorderStyle.None;
        }

        private void manufacturerNumberLessBy1_MouseEnter(object sender, EventArgs e)
        {
            if (manufacturerNumber > 0)
            {
                manufacturerNumberLessBy1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                manufacturerNumberLessBy1.BorderStyle = BorderStyle.None;
            }
        }

        private void manufacturerNumberLessBy1_MouseLeave(object sender, EventArgs e)
        {
            manufacturerNumberLessBy1.BorderStyle = BorderStyle.None;
        }

        private void cb_ManufacturerCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            manufacturerWithNewInfo.Country = countries.Where(country => country.CountryName == cb_ManufacturerCountries.Text).Select(country => country.CountryCode).Min();
            ManufacturerCountryFlagAvailibilityCheck(manufacturerWithNewInfo);
        }

        private void txt_ShortTitle_Validating(object sender, CancelEventArgs e)
        {
            textBoxValidation(txt_ShortTitle, "Title", ManufacturerShortTitleErrorText, existingManufacturerShortTitles, manufacturers[groupNumber][manufacturerNumber].ShortTitle, e);
        }

        private void txt_ShortTitle_TextChanged(object sender, EventArgs e)
        {
            manufacturerWithNewInfo.ShortTitle = txt_ShortTitle.Text;
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