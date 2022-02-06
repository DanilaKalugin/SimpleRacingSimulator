using Entities;
using Kursach5.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProgressBar = ExtendedDotNET.Controls.Progress.ProgressBar;

namespace WindowsFormsApp2
{
    public partial class StatisticsForm : Form
    {
        private enum ObjectType { Cars, Manufacturers, Countries, Users }
        private readonly StatisticsBL StatisticsBL;
        List<Car> cars;
        List<Manufacturer> manufacturers;
        List<ProgressBar> progressBars;
        List<Country> countries;
        List<User> users;
        int CarIndex;
        StatisticsBL.Direction direction;
        StatisticsBL.SortingCriterion sortingCriterion;
        StatisticsBL.UserSortingCriterion userSortingCriterion;
        ObjectType Object;

        public StatisticsForm()
        {
            InitializeComponent();
            StatisticsBL = new StatisticsBL();
            progressBars = new List<ProgressBar>
            {
                progressBar1,
                progressBar2,
                progressBar3,
                progressBar4,
                progressBar5
            };
            Object = ObjectType.Cars;
            sortingCriterion = StatisticsBL.SortingCriterion.Power;
            userSortingCriterion = StatisticsBL.UserSortingCriterion.Balance;
            comboBox2.Items.Add(ObjectType.Cars);
            comboBox2.Items.Add(ObjectType.Manufacturers);
            comboBox2.Items.Add(ObjectType.Countries);
            comboBox2.Items.Add(ObjectType.Users);
        }

        private void SortingTypeChanging(StatisticsBL.Direction direction, double AscExtremeValue, double DescExtremeValue, string criterion)
        {
            foreach (ProgressBar pb in progressBars)
            {
                if (direction == StatisticsBL.Direction.Descending)
                {
                    pb.Maximum = (int)(DescExtremeValue * 1.05);
                }
                else
                {
                    pb.Maximum = (int)(AscExtremeValue * 1.05);
                }
            }
            lblHeader.Text = criterion;
        }

        private void GetList(ObjectType currentObject, StatisticsBL.SortingCriterion criterion, StatisticsBL.Direction direction)
        {
            cars = StatisticsBL.GetSortedCarsList(direction, criterion);
            comboBox1.DataSource = StatisticsBL.GetSortingCriteria();
            switch (currentObject)
            {
                case ObjectType.Cars:
                    {
                        vScrollBar1.Maximum = cars.Count - 5;
                        break;
                    }
                case ObjectType.Manufacturers:
                    {
                        manufacturers = StatisticsBL.GetSortedManufacturersList(direction);
                        vScrollBar1.Maximum = manufacturers.Count - 5;
                        break;
                    }
                case ObjectType.Countries:
                    {
                        manufacturers = StatisticsBL.GetSortedManufacturersList(direction);
                        countries = StatisticsBL.GetSortedCountriesList(direction);
                        vScrollBar1.Maximum = countries.Count - 5;
                        break;
                    }
            }
            vScrollBar1.Value = 0;
            switch (currentObject)
            {
                case ObjectType.Cars:
                    {
                        switch (criterion)
                        {
                            case StatisticsBL.SortingCriterion.Power:
                                {
                                    SortingTypeChanging(direction, cars[cars.Count - 1].Power, cars[0].Power, "Cars sorted by engine power");

                                    break;
                                }
                            case StatisticsBL.SortingCriterion.Price:
                                {
                                    SortingTypeChanging(direction, cars[cars.Count - 1].Price, cars[0].Price, "Cars sorted by price");
                                    break;
                                }
                            case StatisticsBL.SortingCriterion.Weight:
                                {
                                    SortingTypeChanging(direction, cars[cars.Count - 1].Weight, cars[0].Weight, "Cars sorted by weight");
                                    break;
                                }
                            case StatisticsBL.SortingCriterion.PowerToWeight:
                                {
                                    SortingTypeChanging(direction, cars[cars.Count - 1].PowerToWeight() * 100, cars[0].PowerToWeight() * 100, "Cars sorted by power to weight ratio");
                                    break;
                                }
                        }
                        criterion = StatisticsBL.SortingCriterion.Power;
                        break;
                    }
                case ObjectType.Manufacturers:
                    {
                        SortingTypeChanging(direction, cars.Count(car => car.manufacturer == manufacturers[manufacturers.Count - 1].Title), cars.Count(car => car.manufacturer == manufacturers[0].Title), "Manufacturers sorted by the number of models");
                        break;
                    }
                case ObjectType.Countries:
                    {
                        SortingTypeChanging(direction, manufacturers.Count(manufacturer => manufacturer.Country == countries[countries.Count - 1].CountryCode), manufacturers.Count(manufacturer => manufacturer.Country == countries[0].CountryCode), "Countries sorted by number of manufacturers");
                        break;
                    }
            }
            CarIndex = 1;
            CarChanging();
        }

        private void GetList(StatisticsBL.UserSortingCriterion criterion, StatisticsBL.Direction direction)
        {
            users = StatisticsBL.GetSortedUsersList(direction, criterion);
            if (users.Count < 5)
            {
                vScrollBar1.Maximum = 1;
            }
            else
            {
                vScrollBar1.Maximum = users.Count - 5;
            }
            vScrollBar1.Visible = users.Count > 5;
            comboBox1.DataSource = StatisticsBL.GetSortingCriterions();
            switch (criterion)
            {
                case StatisticsBL.UserSortingCriterion.Balance:
                    {
                        SortingTypeChanging(direction, users[users.Count - 1].Balance, users[0].Balance, "Users sorted by balance");
                        break;
                    }
                case StatisticsBL.UserSortingCriterion.Level:
                    {
                        SortingTypeChanging(direction, users[users.Count - 1].CollectorLevel, users[0].CollectorLevel, "Users sorted by collector level");
                        break;
                    }
                case StatisticsBL.UserSortingCriterion.Cars:
                    {
                        SortingTypeChanging(direction, users[users.Count - 1].CountOfCars, users[0].CountOfCars, "Users sorted by amount of cars");
                        break;
                    }
            }
            CarIndex = 1;
            CarChanging();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            direction = StatisticsBL.Direction.Descending;
            Object = ObjectType.Users;
            if (Object == ObjectType.Users)
            {
                comboBox1.DataSource = StatisticsBL.GetSortingCriterions();
            }
            else
            {
                comboBox1.DataSource = StatisticsBL.GetSortingCriteria();
            }
            comboBox2.SelectedIndex = (int)Object;
            comboBox1.SelectedIndex = (int)sortingCriterion;
            if (Object == ObjectType.Users)
            {
                GetList(userSortingCriterion, direction);
            }
            else GetList(Object, sortingCriterion, direction);
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            CarIndex = vScrollBar1.Value + 1;
            CarChanging();
        }

        private void CarChanging()
        {
            RowChanging(-1, lbPlace_1, label9, label13, progressBar1, pictureBox1, Object);
            RowChanging(0, lbPlace_2, label10, label14, progressBar2, pictureBox2, Object);
            RowChanging(1, label4, label8, label17, progressBar3, pictureBox3, Object);
            RowChanging(2, label5, label12, label16, progressBar4, pictureBox4, Object);
            RowChanging(3, label6, label11, label15, progressBar5, pictureBox5, Object);
        }

        private void RowChanging(int step, Label Place, Label Title, Label Power, ProgressBar progressBar, PictureBox pb, ObjectType @object)
        {
            Place.Text = (CarIndex + 1 + step).ToString();
            switch (@object)
            {
                case ObjectType.Cars:
                    {
                        Title.Text = cars[CarIndex + step].ShortTitle;
                        lbKey_h.Text = "Car";
                        lbValue_h.Font = new Font("Forza Medium", 20, FontStyle.Bold);
                        switch (sortingCriterion)
                        {
                            case StatisticsBL.SortingCriterion.Power:
                                {
                                    lbValue_h.Text = "Power";
                                    Power.Font = new Font("Forza Medium", 18, FontStyle.Bold);
                                    Power.Text = cars[CarIndex + step].Power.ToString("N0", CultureInfo.InvariantCulture) + " HP";
                                    progressBar.Value = cars[CarIndex + step].Power;
                                    break;
                                }
                            case StatisticsBL.SortingCriterion.Price:
                                {
                                    lbValue_h.Text = "Price";
                                    Power.Font = new Font("Forza Medium", 14, FontStyle.Bold);
                                    Power.Text = cars[CarIndex + step].Price.ToString("N0", CultureInfo.InvariantCulture) + " CR";
                                    progressBar.Value = cars[CarIndex + step].Price;
                                    break;
                                }
                            case StatisticsBL.SortingCriterion.Weight:
                                {
                                    lbValue_h.Text = "Weight";
                                    Power.Font = new Font("Forza Medium", 18, FontStyle.Bold);
                                    Power.Text = cars[CarIndex + step].Weight.ToString("N0", CultureInfo.InvariantCulture) + " LBS";
                                    progressBar.Value = cars[CarIndex + step].Weight;
                                    break;
                                }
                            default:
                                {
                                    lbValue_h.Text = "Ratio";
                                    Power.Font = new Font("Forza Medium", 14, FontStyle.Bold);
                                    Power.Text = cars[CarIndex + step].PowerToWeight().ToString("N3", CultureInfo.InvariantCulture) + " HP - FT";
                                    progressBar.Value = (int)(cars[CarIndex + step].PowerToWeight() * 100);
                                    break;
                                }
                        }

                        if (File.Exists("BigCarImages2/Car" + cars[CarIndex + step].ImageNumber.ToString("0000") + ".png"))
                        {
                            pb.Image = Image.FromFile("BigCarImages2/Car" + cars[CarIndex + step].ImageNumber.ToString("0000") + ".png");
                        }
                        else
                        {
                            pb.Image = Properties.Resources.Error;
                        }
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case ObjectType.Manufacturers:
                    {
                        Title.Text = manufacturers[CarIndex + step].Title;
                        Power.Font = new Font("Forza Medium", 20, FontStyle.Bold);
                        lbValue_h.Font = new Font("Forza Medium", 20, FontStyle.Bold);
                        lbValue_h.Text = "Cars";
                        lbKey_h.Text = "Manufacturer";
                        Power.Text = cars.Count(car => car.manufacturer == manufacturers[CarIndex + step].Title).ToString("N0", CultureInfo.InvariantCulture);
                        progressBar.Value = cars.Count(car => car.manufacturer == manufacturers[CarIndex + step].Title);

                        if (File.Exists("ManufacturerLogos/Manufacturer" + manufacturers[CarIndex + step].Number.ToString("0000") + ".png"))
                        {
                            pb.Image = Image.FromFile("ManufacturerLogos/Manufacturer" + manufacturers[CarIndex + step].Number.ToString("0000") + ".png");
                        }
                        else
                        {
                            pb.Image = Properties.Resources.Error;
                        }
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    }
                case ObjectType.Countries:
                    {
                        Title.Text = countries[CarIndex + step].CountryName;
                        Power.Font = new Font("Forza Medium", 20, FontStyle.Bold);
                        lbValue_h.Font = new Font("Forza Medium", 12, FontStyle.Bold);
                        lbValue_h.Text = "Manufacturers";
                        lbKey_h.Text = "Country";
                        Power.Text = manufacturers.Count(manufacturer => manufacturer.Country == countries[CarIndex + step].CountryCode).ToString("N0", CultureInfo.InvariantCulture);
                        progressBar.Value = manufacturers.Count(manufacturer => manufacturer.Country == countries[CarIndex + step].CountryCode);

                        if (File.Exists("CountryFlags/" + countries[CarIndex + step].CountryCode + ".png"))
                        {
                            pb.Image = Image.FromFile("CountryFlags/" + countries[CarIndex + step].CountryCode + ".png");
                        }
                        else
                        {
                            pb.Image = Properties.Resources.Error;
                        }
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    }
                case ObjectType.Users:
                    {
                        /*
                        if (users[CarIndex + step].IsAdmin)
                        {
                            Title.Text = users[CarIndex + step].Name + "👑";
                        }
                        else
                        {
                            Title.Text = users[CarIndex + step].Name;
                        }
                        lbKey_h.Text = "User";
                        lbValue_h.Font = new Font("Forza Medium", 20, FontStyle.Bold);
                        switch (userSortingCriterion)
                        {
                            case StatisticsBL.UserSortingCriterion.Balance:
                                {
                                    lbValue_h.Text = "Balance";
                                    Power.Font = new Font("Forza Medium", 12, FontStyle.Bold);
                                    Power.Text = users[CarIndex + step].Balance.ToString("N0", CultureInfo.InvariantCulture) + " CR";
                                    progressBar.Value = users[CarIndex + step].Balance;
                                    break;
                                }
                            case StatisticsBL.UserSortingCriterion.Level:
                                {
                                    lbValue_h.Text = "Level";
                                    Power.Font = new Font("Forza Medium", 18, FontStyle.Bold);
                                    Power.Text = users[CarIndex + step].CollectorLevel.ToString("N0", CultureInfo.InvariantCulture);
                                    progressBar.Value = users[CarIndex + step].CollectorLevel;
                                    break;
                                }
                            case StatisticsBL.UserSortingCriterion.Cars:
                                {
                                    lbValue_h.Text = "Cars";
                                    Power.Font = new Font("Forza Medium", 18, FontStyle.Bold);
                                    Power.Text = users[CarIndex + step].CountOfCars.ToString("N0", CultureInfo.InvariantCulture);
                                    progressBar.Value = users[CarIndex + step].CountOfCars;
                                    break;
                                }
                        }
                        if (File.Exists("CountryFlags/" + users[CarIndex + step].Country + ".png"))
                        {
                            pb.Image = Image.FromFile("CountryFlags/" + users[CarIndex + step].Country + ".png");
                        }
                        else
                        {
                            pb.Image = Properties.Resources.Error;
                        }

                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        */
                        break;
                    }
                        
            }
        }

        private void btnToggleStats_Click(object sender, EventArgs e)
        {
            direction = StatisticsBL.Direction.Ascending;
            if (Object == ObjectType.Users)
            {
                GetList(userSortingCriterion, direction);
            }
            else GetList(Object, sortingCriterion, direction);
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            direction = StatisticsBL.Direction.Descending;
            if (Object == ObjectType.Users)
            {
                GetList(userSortingCriterion, direction);
            }
            else GetList(Object, sortingCriterion, direction);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Object == ObjectType.Users)
            {
                userSortingCriterion = (StatisticsBL.UserSortingCriterion)comboBox1.SelectedIndex;
                GetList(userSortingCriterion, direction);
            }
            else
            {
                sortingCriterion = (StatisticsBL.SortingCriterion)comboBox1.SelectedIndex;
                GetList(Object, sortingCriterion, direction);
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Object = (ObjectType)comboBox2.SelectedIndex;
            if (Object == ObjectType.Users)
            {
                GetList(userSortingCriterion, direction);
            }
            else GetList(Object, sortingCriterion, direction);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = Object == ObjectType.Cars || Object == ObjectType.Users;
            label20.Visible = Object == ObjectType.Cars || Object == ObjectType.Users;
        }
    }
}