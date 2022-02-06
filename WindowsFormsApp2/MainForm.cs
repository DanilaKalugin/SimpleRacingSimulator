using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using Entities;
using Kursach5.BLL;
using System.ComponentModel;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private readonly CarsBL forza7BL;
        private readonly UsersBL usersBL;
        public User.SortingType currentSortingType;
        public User.SortingType sortingType;
        private enum ActivePanel { None, Quit, CarBuying, NotEnoughMoney, ResettingStats, LockedCar, SavingNewStats, Options, LogOut, ReturnToMainMenu, Sorting, DeletingAcount, PowerLimitsViolating };
        private User.UnitsSystem currentUnits;
        private ActivePanel activePanel;
        List<Manufacturer> manufacturers;
        public int groupNumber;
        List<List<Car>> cars;
        int carNumber = 0;
        bool changeBorder;
        int collectorTier;
        int maxCollectorTier;
        private bool newCarAdding;
        bool IsChanging;
        Car CarWithNewStats;
        bool SavingBeforeClosing;
        List<string> ExistingCombinationsOfYearManufacturerAndModel;
        List<string> ExistingShortTitles;
        bool YearOrModelChanged;
        bool ShortTitleChanged;
        User currentUser;
        private bool IsLogOut;
        private bool SavingBeforeReturningToMainMenu;
        List<string> groups;
        private int lowerBorderPower;
        private int upperBorderPower;
        List<string> collectionTiers;
        List<string> divisions;
        public bool DeletingAccount;
        List<Country> countries;
        private CarsBL.FilterOption filteringType;

        public MainForm(User user)
        {
            InitializeComponent();
            usersBL = new UsersBL();
            forza7BL = new CarsBL();
            currentUser = user;
            DeletingAccount = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupNumberChanging(7, PositionChanging.Direction.Up);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupNumberChanging(7, PositionChanging.Direction.Down);
        }

        private int CarCollectionLevel(Car car)
        {
            int level = collectionTiers.IndexOf(car.CollectionTier);
            return level + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentSortingType = currentUser.DefaultSortingType;
            SelectingNameDependingOnTheSortingType(currentSortingType);
            currentUnits = currentUser.DefaultUnitsSystem;
            countries = forza7BL.GetCountriesList().ToList();
            panelCarStats.BringToFront();
            panelCarStats2.BringToFront();
            manufacturers = forza7BL.GetManufacturersList().ToList();
            collectionTiers = forza7BL.GetCollectionTierTitlesList();
            ExistingCombinationsOfYearManufacturerAndModel = new List<string>();
            ExistingShortTitles = new List<string>();
            groupNumber = 1;
            maxCollectorTier = 1;
            cb_FilterCriterions.SelectedIndex = 0;
            DisplayCars(currentSortingType, lowerBorderPower, upperBorderPower);
            ExistingCombinationsOfYearManufacturerAndModel.Clear();
            ExistingShortTitles.Clear();
            for (int i = 1; i < cars.Count; i++)
            {
                for (int j = 0; j < cars[i].Count; j++)
                {
                    ExistingCombinationsOfYearManufacturerAndModel.Add(cars[i][j].Year.ToString() + "_" + cars[i][j].manufacturer + "_" + cars[i][j].Model);
                    ExistingShortTitles.Add(cars[i][j].ShortTitle);
                }
            }
            GroupChanged(groupNumber);
            btnEditCarStats.Visible = currentUser.IsAdmin;
            btnDeleteAccount.Visible = !currentUser.IsAdmin;
            btnAddCar.Visible = currentUser.IsAdmin;
            divisions = forza7BL.GetDivisionsList().ToList();
            cb_CarManufacturer.Items.AddRange(manufacturers.OrderBy(manufacturer => manufacturer.Title).Select(manufacturer => manufacturer.Title).ToArray());
            cb_Divisions.Items.AddRange(divisions.ToArray());
        }

        public void showCarCharacteristic(float characteristic, Label l, ExtendedDotNET.Controls.Progress.ProgressBar progressBar)
        {
            l.Text = characteristic.ToString("0.0");
            progressBar.Value = (int)(characteristic * 10);
        }

        public void CarChanging(Car car)
        {
            lb_PI.Text = car.PI.ToString();
            lb_year.Text = car.Year.ToString();
            lb_manufacturer.Text = car.manufacturer;
            lb_model.Text = car.Model;
            lb_Division.Text = car.Division;
            showCarCharacteristic(car.Speed, lb_speed, pb_speed);
            showCarCharacteristic(car.Handling, lb_handling, pb_handling);
            showCarCharacteristic(car.Acceleration, lb_acceleration, pb_acceleration);
            showCarCharacteristic(car.Brake, lb_brake, pb_brake);

            carClassDefinition(car);
            carIsBought.Visible = car.WasBought;
            CarLocked.Visible = (maxCollectorTier < CarCollectionLevel(car));
            CollectionTierDefinition(car);
            carAvailibilityCheck(car);

            if (File.Exists("BigCarImages2/Car" + car.ImageNumber.ToString("0000") + ".png"))
            {
                pb_BigCarImage.Image = Image.FromFile("BigCarImages2/Car" + car.ImageNumber.ToString("0000") + ".png");
                ErrorText.Text = "";
                pb_BigCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                ErrorText.Text = "Car model not found!";
                pb_BigCarImage.Image = Properties.Resources.Error;
                pb_BigCarImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            currentCarFE_Large.Visible = car.IsFE;
            if (car.WasBought)
            {
                btnBuy.Text = "Sell";
            }
            else
            {
                btnBuy.Text = "Buy";
            }

            int CarManufacturer;
            if (car.manufacturer != "")
            {
                CarManufacturer = manufacturers.Where(m => m.Title == car.manufacturer).Select(m => m.Number).Min();
            }
            else
            {
                CarManufacturer = 0;
            }
            ManufacturerLogoAndCountryFlagAvailibilityCheck(CarManufacturer);

            CarSmallImagesAvailibilityCheck(groupNumber, carNumber);
            DriveAndEnginePlacementSchemeDefinition(car);
            UnitsChanging(car, currentUnits);
            lb_frontWeight.Text = car.Front.ToString() + "%";

            carNumberIs2Less.Visible = true;
            carNumberIs1Less.Visible = true;
            currentCar.Visible = true;
            carNumberIs2More.Visible = true;
            carNumberIs1More.Visible = true;

            carNumberIs2LessTier.Visible = true;
            carNumberIs1LessTier.Visible = true;
            currentCarTier.Visible = true;
            carNumberIs1MoreTier.Visible = true;
            carNumberIs2MoreTier.Visible = true;

            panelCollectorInfo.Visible = true;
            panelCarStats.Visible = true;
            btnBuy.Visible = true;
            btnToggleStats.Visible = true;
            pb_B.Visible = true;
            pb_C.Visible = true;
            pb_R.Visible = true;
            lb_Division.Visible = true;
            pb_Division.Visible = true;
            HidePanels(false);
        }

        private void CarSmallImagesAvailibilityCheck(int manufacturerNumber, int carNumber)
        {
            if (carNumber > 0)
            {
                if (File.Exists("CarImages/Car" + cars[manufacturerNumber][carNumber - 1].ImageNumber.ToString("0000") + ".png"))
                {
                    carNumberIs1Less.Image = Image.FromFile("CarImages/Car" + cars[manufacturerNumber][carNumber - 1].ImageNumber.ToString("0000") + ".png");
                }
                else
                {
                    carNumberIs1Less.Image = Properties.Resources.CarImage;
                }
                carNumberIs1LessFE.Visible = cars[manufacturerNumber][carNumber - 1].IsFE;
                smallCollectionIconColourDefinition(cars[manufacturerNumber][carNumber - 1], carNumberIs1LessTier);
                if (maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber - 1]))
                {
                    carNumberIs1LessLocked.Image = Properties.Resources.IsLocked;
                    carNumberIs1LessLocked.Visible = maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber - 1]);
                }
                else
                {
                    carNumberIs1LessLocked.Image = Properties.Resources.WasBought;
                    carNumberIs1LessLocked.Visible = cars[manufacturerNumber][carNumber - 1].WasBought;
                }

                if (carNumber == 1)
                {
                    carNumberIs2Less.Image = Properties.Resources.CarImage;
                    carNumberIs2LessFE.Visible = false;
                    carNumberIs2LessTier.BackColor = Color.FromArgb(50, 50, 50);
                    carNumberIs2LessLocked.Visible = false;
                }
                else
                {
                    if (File.Exists("CarImages/Car" + cars[manufacturerNumber][carNumber - 2].ImageNumber.ToString("0000") + ".png"))
                    {
                        carNumberIs2Less.Image = Image.FromFile("CarImages/Car" + cars[manufacturerNumber][carNumber - 2].ImageNumber.ToString("0000") + ".png");
                    }
                    else
                    {
                        carNumberIs2Less.Image = Properties.Resources.CarImage;
                    }
                    carNumberIs2LessFE.Visible = cars[manufacturerNumber][carNumber - 2].IsFE;
                    smallCollectionIconColourDefinition(cars[manufacturerNumber][carNumber - 2], carNumberIs2LessTier);
                    if (maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber - 2]))
                    {
                        carNumberIs2LessLocked.Image = Properties.Resources.IsLocked;
                        carNumberIs2LessLocked.Visible = maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber - 2]);
                    }
                    else
                    {
                        carNumberIs2LessLocked.Image = Properties.Resources.WasBought;
                        carNumberIs2LessLocked.Visible = cars[manufacturerNumber][carNumber - 2].WasBought;
                    }
                }
            }
            else
            {
                carNumberIs1Less.Image = Properties.Resources.CarImage;
                carNumberIs1LessFE.Visible = false;
                carNumberIs1LessTier.BackColor = Color.FromArgb(50, 50, 50);
                carNumberIs1LessLocked.Visible = false;
                carNumberIs2Less.Image = Properties.Resources.CarImage;
                carNumberIs2LessFE.Visible = false;
                carNumberIs2LessTier.BackColor = Color.FromArgb(50, 50, 50);
                carNumberIs2LessLocked.Visible = false;
            }

            if (File.Exists("CarImages/Car" + cars[manufacturerNumber][carNumber].ImageNumber.ToString("0000") + ".png"))
            {
                currentCar.Image = Image.FromFile("CarImages/Car" + cars[manufacturerNumber][carNumber].ImageNumber.ToString("0000") + ".png");
            }
            else
            {
                currentCar.Image = Properties.Resources.CarImage;
            }
            currentCarFE.Visible = cars[manufacturerNumber][carNumber].IsFE;
            smallCollectionIconColourDefinition(cars[manufacturerNumber][carNumber], currentCarTier);

            if (maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber]))
            {
                currentCarLocked.Image = Properties.Resources.IsLocked;
                currentCarLocked.Visible = maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber]);
            }
            else
            {
                currentCarLocked.Image = Properties.Resources.WasBought;
                currentCarLocked.Visible = cars[manufacturerNumber][carNumber].WasBought;
            }

            if (carNumber < cars[manufacturerNumber].Count - 1)
            {
                if (File.Exists("CarImages/Car" + cars[manufacturerNumber][carNumber + 1].ImageNumber.ToString("0000") + ".png"))
                {
                    carNumberIs1More.Image = Image.FromFile("CarImages/Car" + cars[manufacturerNumber][carNumber + 1].ImageNumber.ToString("0000") + ".png");
                }
                else
                {
                    carNumberIs1More.Image = Properties.Resources.CarImage;
                }
                carNumberIs1MoreFE.Visible = cars[manufacturerNumber][carNumber + 1].IsFE;
                smallCollectionIconColourDefinition(cars[manufacturerNumber][carNumber + 1], carNumberIs1MoreTier);
                if (maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber + 1]))
                {
                    carNumberIs1MoreLocked.Image = Properties.Resources.IsLocked;
                    carNumberIs1MoreLocked.Visible = maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber + 1]);
                }
                else
                {
                    carNumberIs1MoreLocked.Image = Properties.Resources.WasBought;
                    carNumberIs1MoreLocked.Visible = cars[manufacturerNumber][carNumber + 1].WasBought;
                }

                if (carNumber == cars[manufacturerNumber].Count - 2)
                {
                    carNumberIs2More.Image = Properties.Resources.CarImage;
                    carNumberIs2MoreFE.Visible = false;
                    carNumberIs2MoreTier.BackColor = Color.FromArgb(50, 50, 50);
                    carNumberIs2MoreLocked.Visible = false;
                }
                else
                {
                    if (File.Exists("CarImages/Car" + cars[manufacturerNumber][carNumber + 2].ImageNumber.ToString("0000") + ".png"))
                    {
                        carNumberIs2More.Image = Image.FromFile("CarImages/Car" + cars[manufacturerNumber][carNumber + 2].ImageNumber.ToString("0000") + ".png");
                    }
                    else
                    {
                        carNumberIs2More.Image = Properties.Resources.CarImage;
                    }
                    carNumberIs2MoreFE.Visible = cars[manufacturerNumber][carNumber + 2].IsFE;
                    smallCollectionIconColourDefinition(cars[manufacturerNumber][carNumber + 2], carNumberIs2MoreTier);
                    if (maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber + 2]))
                    {
                        carNumberIs2MoreLocked.Image = Properties.Resources.IsLocked;
                        carNumberIs2MoreLocked.Visible = maxCollectorTier < CarCollectionLevel(cars[manufacturerNumber][carNumber + 2]);
                    }
                    else
                    {
                        carNumberIs2MoreLocked.Image = Properties.Resources.WasBought;
                        carNumberIs2MoreLocked.Visible = cars[manufacturerNumber][carNumber + 2].WasBought;
                    }
                }
            }
            else
            {
                carNumberIs1More.Image = Properties.Resources.CarImage;
                carNumberIs1MoreFE.Visible = false;
                carNumberIs1MoreTier.BackColor = Color.FromArgb(50, 50, 50);
                carNumberIs1MoreLocked.Visible = false;
                carNumberIs2More.Image = Properties.Resources.CarImage;
                carNumberIs2MoreFE.Visible = false;
                carNumberIs2MoreTier.BackColor = Color.FromArgb(50, 50, 50);
                carNumberIs2MoreLocked.Visible = false;
            }
        }

        private void DriveAndEnginePlacementSchemeDefinition(Car car)
        {
            string DriveAndEngine = car.Drive + car.EnginePlacement;
            switch (DriveAndEngine)
            {
                case "RF":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.RF;
                        break;
                    }
                case "RM":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.RM;
                        break;
                    }
                case "RR":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.RR;
                        break;
                    }
                case "FF":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.FF;
                        break;
                    }
                case "AF":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.AF;
                        break;
                    }
                case "AM":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.AM;
                        break;
                    }
                case "AR":
                    {
                        EngineAndDrivenWheels_scheme.Image = Properties.Resources.AR;
                        break;
                    }
                default:
                    {
                        EngineAndDrivenWheels_scheme.Image = null;
                        break;
                    }
            }
        }

        public void CarChanging()
        {
            HidePanels(false);
            lb_PI.Text = string.Empty;
            lb_year.Text = string.Empty;
            lb_manufacturer.Text = string.Empty;
            lb_model.Text = string.Empty;

            pb_BigCarImage.Image = Properties.Resources.Error;
            pb_BigCarImage.SizeMode = PictureBoxSizeMode.CenterImage;
            ErrorText.Text = "You don`t have cars";
            carPrice.Text = string.Empty;

            carNumberIs1Less.Visible = false;
            carNumberIs2Less.Visible = false;
            currentCar.Visible = false;
            carNumberIs1More.Visible = false;
            carNumberIs2More.Visible = false;

            lb_Division.Visible = false;
            pb_Division.Visible = false;
            pb_R.Visible = false;
            pb_B.Visible = false;

            ManufacturerLogo.Image = null;
            panelCollectorInfo.Visible = false;
            panelCarStats.Visible = false;
            panelCarStats2.Visible = false;

            carNumberIs2LessTier.Visible = false;
            carNumberIs1LessTier.Visible = false;
            currentCarTier.Visible = false;
            carNumberIs1MoreTier.Visible = false;
            carNumberIs2MoreTier.Visible = false;

            carNumberIs2LessLocked.Visible = false;
            carNumberIs1LessLocked.Visible = false;
            currentCarLocked.Visible = false;
            carNumberIs1MoreLocked.Visible = false;
            carNumberIs2MoreLocked.Visible = false;

            carNumberIs2LessFE.Visible = false;
            carNumberIs1LessFE.Visible = false;
            currentCarFE.Visible = false;
            carNumberIs1MoreFE.Visible = false;
            carNumberIs2MoreFE.Visible = false;
            CarLocked.Visible = false;
            currentCarFE_Large.Visible = false;

            btnBuy.Visible = false;

            btnToggleStats.Visible = false;
            carPrice.BackColor = Color.FromArgb(45, 45, 45);
            carIsBought.Visible = false;
        }

        private void ManufacturerLogoAndCountryFlagAvailibilityCheck(int number)
        {
            if (number != 0)
            {
                Manufacturer manufacturer = manufacturers.Where(m => m.Number == number).First();
                if (File.Exists("ManufacturerLogos/Manufacturer" + manufacturer.Number.ToString("0000") + ".png"))
                {
                    ManufacturerLogo.Image = Image.FromFile("ManufacturerLogos/Manufacturer" + manufacturer.Number.ToString("0000") + ".png");
                }
                else ManufacturerLogo.Image = null;

                if (File.Exists("CountryFlags/" + manufacturer.Country + ".png"))
                {
                    manufacturerCountry.Image = Image.FromFile("CountryFlags/" + manufacturer.Country + ".png");
                }
                else manufacturerCountry.Image = null;
            }
            else
            {
                manufacturerCountry.Image = null;
                ManufacturerLogo.Image = null;
            }
        }

        private void carAvailibilityCheck(Car car)
        {
            carPrice.Text = car.Price.ToString("N0", CultureInfo.InvariantCulture) + " CR";
            if (car.Price <= forza7BL.GetBalance(currentUser.Name))
            {
                carPrice.BackColor = Color.FromArgb(47, 200, 234);
            }
            else
            {
                carPrice.BackColor = Color.FromArgb(246, 135, 32);
            }
        }

        private void smallCollectionIconColourDefinition(Car car, PictureBox smallIcon)
        {
            switch (CarCollectionLevel(car))
            {
                case 1:
                    {
                        smallIcon.BackColor = Color.FromArgb(0, 135, 0);
                        break;
                    }
                case 2:
                    {
                        smallIcon.BackColor = Color.FromArgb(17, 67, 178);
                        break;
                    }
                case 3:
                    {
                        smallIcon.BackColor = Color.FromArgb(122, 12, 172);
                        break;
                    }
                case 4:
                    {
                        smallIcon.BackColor = Color.FromArgb(202, 0, 44);
                        break;
                    }
                case 5:
                    {
                        smallIcon.BackColor = Color.FromArgb(219, 153, 0);
                        break;
                    }
            }
        }

        private void CollectionTierDefinition(Car car)
        {
            lb_CollectionPoints.Text = "+" + car.CollectionPoints.ToString("N0", CultureInfo.InvariantCulture);
            lb_TierTitle.Text = car.CollectionTier.ToUpper();
            switch (CarCollectionLevel(car))
            {
                case 1:
                    {
                        pb_TierImage.Image = Properties.Resources._1;
                        break;
                    }
                case 2:
                    {
                        pb_TierImage.Image = Properties.Resources._2;
                        break;
                    }
                case 3:
                    {
                        pb_TierImage.Image = Properties.Resources._3;
                        break;
                    }
                case 4:
                    {
                        pb_TierImage.Image = Properties.Resources._4;
                        break;
                    }
                case 5:
                    {
                        pb_TierImage.Image = Properties.Resources._5;
                        break;
                    }
            }
        }

        private void ManufacturerAvailabilityCheck(Label l, int step)
        {
            if (groupNumber < groups.Count - step)
            {
                l.Font = new Font("Forza Medium", 10 - (groups[groupNumber + step].Length / 18) - (groups[groupNumber + step].Length - 18) / 3);
                l.Text = groups[groupNumber + step];
            }
            else
            {
                l.Text = null;
            }
        }

        public void GroupChanged(int i)
        {
            currentGroup.Text = groups[i];
            currentGroup.Font = new Font("Forza Medium", 10 - (groups[groupNumber].Length / 18) - (groups[groupNumber].Length - 18) / 3);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy1, 1);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy2, 2);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy3, 3);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy4, 4);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy5, 5);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy6, 6);
            ManufacturerAvailabilityCheck(GroupNumberGreaterBy7, 7);
            carNumber = 0;
            if (cars[i].Count > 0)
            {
                CarChanging(cars[i][0]);
            }
            else CarChanging();
        }

        public void carClassDefinition(Car car)
        {
            if (car.PI == 999)
            {
                lb_CarClass.BackColor = Color.FromArgb(0, 132, 67);
            }
            if (car.PI > 900 && car.PI < 999)
            {
                lb_CarClass.BackColor = Color.FromArgb(37, 93, 3);
            }
            if (car.PI > 800 && car.PI <= 900)
            {
                lb_CarClass.BackColor = Color.FromArgb(0, 39, 125);
            }
            if (car.PI > 700 && car.PI <= 800)
            {
                lb_CarClass.BackColor = Color.FromArgb(119, 96, 171);
            }
            if (car.PI > 600 && car.PI <= 700)
            {
                lb_CarClass.BackColor = Color.FromArgb(210, 34, 0);
            }
            if (car.PI > 500 && car.PI <= 600)
            {
                lb_CarClass.BackColor = Color.FromArgb(248, 104, 0);
            }
            if (car.PI > 400 && car.PI <= 500)
            {
                lb_CarClass.BackColor = Color.FromArgb(208, 165, 0);
            }
            if (car.PI > 300 && car.PI <= 400)
            {
                lb_CarClass.BackColor = Color.FromArgb(0, 149, 185);
            }
            if (car.PI >= 100 && car.PI <= 300)
            {
                lb_CarClass.BackColor = Color.FromArgb(141, 66, 124);
            }
            lb_CarClass.Text = car.carClass().ToString();
        }

        private void MouseHove(object sender, EventArgs e)
        {
            MouseActions.MouseEnter(sender as Label, MouseActions.ItemType.Group);
        }

        private void MouseLeaving(object sender, EventArgs e)
        {
            MouseActions.MouseLeave(sender as Label, MouseActions.ItemType.Group);
        }

        private void groupNumberChanging(int step, PositionChanging.Direction direction)
        {
            PositionChanging.groupNumberChanging(step, direction, groups, ref groupNumber);
            GroupChanged(groupNumber);
        }

        private void carChange(int step, PositionChanging.Direction direction)
        {
            PositionChanging.elementNumberChanging(step, direction, cars[groupNumber], ref carNumber);
            CarChanging(cars[groupNumber][carNumber]);
            changeBorder = false;
            carNumberIs2More.Refresh();
            carNumberIs1More.Refresh();
            carNumberIs2Less.Refresh();
            carNumberIs1Less.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupNumberChanging(1, PositionChanging.Direction.Up);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupNumberChanging(2, PositionChanging.Direction.Up);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            groupNumberChanging(3, PositionChanging.Direction.Up);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupNumberChanging(4, PositionChanging.Direction.Up);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            groupNumberChanging(5, PositionChanging.Direction.Up);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            groupNumberChanging(6, PositionChanging.Direction.Up);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            groupNumberChanging(7, PositionChanging.Direction.Up);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            carChange(2, PositionChanging.Direction.Up); changeBorder = true;
            carNumberIs2More.Refresh();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            carChange(1, PositionChanging.Direction.Up);
            changeBorder = true;
            carNumberIs1More.Refresh();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            carChange(1, PositionChanging.Direction.Down);
            changeBorder = true;
            carNumberIs1Less.Refresh();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            carChange(2, PositionChanging.Direction.Down);
            changeBorder = true;
            carNumberIs2Less.Refresh();
        }

        private void label14_Paint(object sender, PaintEventArgs e)
        {
            Label_Paint(carNumberIs2Less, e, carNumber >= 2);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.O:
                    {
                        if (!IsChanging && (activePanel == ActivePanel.None || activePanel == ActivePanel.Options))
                        {
                            OptionsDialogVisible();
                        }
                        break;
                    }
                case Keys.B:
                    {
                        if (cars[groupNumber].Count != 0 && !IsChanging && activePanel == ActivePanel.None)
                        {
                            CarBuyingDialog();
                        }
                        break;
                    }
                case Keys.Y:
                    {
                        switch (activePanel)
                        {
                            case ActivePanel.SavingNewStats:
                                {
                                    newStatsSavingAccepted();
                                    break;
                                }
                            case ActivePanel.CarBuying:
                                {
                                    CarBuyingAccepted();
                                    break;
                                }
                            case ActivePanel.Quit:
                                {
                                    Environment.Exit(0);
                                    break;
                                }
                            case ActivePanel.LogOut:
                                {
                                    DialogResult = DialogResult.Cancel;
                                    Hide();
                                    break;
                                }
                            case ActivePanel.ResettingStats:
                                {
                                    ResettingStats();
                                    break;
                                }
                            default:
                                {
                                    HidePanels(false);
                                    break;
                                }
                        }
                        break;
                    }
                case Keys.N:
                    {
                        switch (activePanel)
                        {
                            case ActivePanel.SavingNewStats:
                                {
                                    newStatsSavingDenied();
                                    break;
                                }
                            default:
                                {
                                    if (!IsChanging)
                                    {
                                        HidePanels(false);
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case Keys.Escape:
                    {
                        if (activePanel == ActivePanel.None)
                        {
                            Close();
                        }
                        else if (activePanel == ActivePanel.SavingNewStats)
                        {
                            HidePanels(false);
                            IsChanging = true;
                            ChangeVisibleControls(IsChanging);
                        }
                        else HidePanels(false);
                        break;
                    }
                case Keys.S:
                    {
                        if (e.Control && IsChanging && ValidateChildren())
                        {
                            NewStatsSaving();
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None && cars[groupNumber].Count != 0)
                        {
                            carChange(1, PositionChanging.Direction.Up);
                        }
                        break;
                    }
                case Keys.Up:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None && cars[groupNumber].Count != 0)
                        {
                            carChange(1, PositionChanging.Direction.Down);
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None)
                        {
                            groupNumberChanging(1, PositionChanging.Direction.Down);
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None)
                        {
                            groupNumberChanging(1, PositionChanging.Direction.Up);
                        }
                        break;
                    }
                case Keys.PageDown:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None && cars[groupNumber].Count != 0)
                        {
                            carChange(5, PositionChanging.Direction.Up);
                        }
                        break;
                    }
                case Keys.PageUp:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None && cars[groupNumber].Count != 0)
                        {
                            carChange(5, PositionChanging.Direction.Down);
                        }
                        break;
                    }
                case Keys.OemOpenBrackets:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None)
                        {
                            groupNumberChanging(7, PositionChanging.Direction.Down);
                        }
                        break;
                    }
                case Keys.Oem6:
                    {
                        if (!IsChanging && activePanel == ActivePanel.None)
                        {
                            groupNumberChanging(7, PositionChanging.Direction.Up);
                        }
                        break;
                    }
                case Keys.R:
                    {
                        if (activePanel == ActivePanel.None)
                        {
                            panelCarStats2.Visible = !panelCarStats2.Visible;
                            btnChangeUnits.Visible = panelCarStats2.Visible;
                        }
                        break;
                    }
                case Keys.C:
                    {
                        if (!IsChanging && (activePanel == ActivePanel.None || activePanel == ActivePanel.Sorting))
                        {
                            SortAndFilterDialogVisible();
                        }
                        break;
                    }
            }
        }

        private void Label_Paint(Label currentLabel, PaintEventArgs e, bool extremeValue)
        {
            currentLabel.MouseHover -= MouseHove;
            currentLabel.MouseLeave -= MouseLeaving;
            if (extremeValue)
            {
                currentLabel.MouseHover += MouseHove;
                currentLabel.MouseLeave += MouseLeaving;
            }
            else
            {
                changeBorder = false;
            }
            borderChanging(changeBorder, e);
        }

        private void label13_Paint(object sender, PaintEventArgs e)
        {
            Label_Paint(carNumberIs1Less, e, carNumber >= 1);
        }

        private void label11_Paint(object sender, PaintEventArgs e)
        {
            Label_Paint(carNumberIs1More, e, carNumber <= cars[groupNumber].Count - 2);
        }

        private void label10_Paint(object sender, PaintEventArgs e)
        {
            Label_Paint(carNumberIs2More, e, carNumber <= cars[groupNumber].Count - 3);
        }

        private void borderChanging(bool changeBorder, PaintEventArgs e)
        {
            if (changeBorder)
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                                      Color.FromArgb(47, 200, 234), 2, ButtonBorderStyle.Solid,
                                      Color.FromArgb(47, 200, 234), 2, ButtonBorderStyle.Solid,
                                      Color.FromArgb(47, 200, 234), 2, ButtonBorderStyle.Solid,
                                      Color.FromArgb(47, 200, 234), 2, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                                      Color.FromArgb(47, 200, 234), 0, ButtonBorderStyle.Solid,
                                      Color.FromArgb(47, 200, 234), 0, ButtonBorderStyle.Solid,
                                      Color.FromArgb(47, 200, 234), 0, ButtonBorderStyle.Solid,
                                      Color.FromArgb(47, 200, 234), 0, ButtonBorderStyle.Solid);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            CarBuyingDialog();
        }

        private void HidePanels(bool DialogVisible)
        {
            panel_NotEnoughMoney.Visible = false;
            panel_BuyCar.Visible = false;
            panel_Quit.Visible = false;
            panelReset.Visible = false;
            panel_LockedCar.Visible = false;
            panel_newStatsSaving.Visible = false;
            panelOptions.Visible = false;
            panelToMainMenu.Visible = false;
            panelDeleteAccount.Visible = false;
            panelPowerLimitsViolation.Visible = false;
            panelSortAndFilter.Visible = false;

            btnChangeUnits.Enabled = !DialogVisible;
            btnSortAndFilter.Enabled = !DialogVisible;
            btnJumpToGroups.Enabled = !DialogVisible;

            if (groupNumber == 0 && cars[groupNumber].Count == 0)
            {
                pb_B.Visible = false;
                pb_R.Visible = false;
            }
            else
            {
                pb_B.Visible = !DialogVisible;
                pb_R.Visible = !DialogVisible;
            }
            pb_O.Visible = !DialogVisible;
            pb_V.Visible = !DialogVisible;
            pb_C.Visible = !DialogVisible;
            btnBuy.Enabled = !DialogVisible;
            btnToggleStats.Enabled = !DialogVisible;
            btnOptions.Enabled = !DialogVisible;

            if (groupNumber != -1)
            {
                carNumberIs1Less.Enabled = !DialogVisible;
                carNumberIs2Less.Enabled = !DialogVisible;
                carNumberIs1More.Enabled = !DialogVisible;
                carNumberIs2More.Enabled = !DialogVisible;
            }

            GroupNumberGreaterBy1.Enabled = !DialogVisible;
            GroupNumberGreaterBy2.Enabled = !DialogVisible;
            GroupNumberGreaterBy3.Enabled = !DialogVisible;
            GroupNumberGreaterBy4.Enabled = !DialogVisible;
            GroupNumberGreaterBy5.Enabled = !DialogVisible;
            GroupNumberGreaterBy6.Enabled = !DialogVisible;
            GroupNumberGreaterBy7.Enabled = !DialogVisible;
            activePanel = ActivePanel.None;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (activePanel == ActivePanel.None)
            {
                if (IsChanging)
                {
                    if (ValidateChildren())
                    {
                        SavingBeforeClosing = true;
                        panel_newStatsSaving.Visible = true;
                        activePanel = ActivePanel.SavingNewStats;
                        carNewShortTitle.Text = CarWithNewStats.ShortTitle;
                    }
                }
                else
                {
                    HidePanels(true);
                    panel_Quit.Visible = true;
                    activePanel = ActivePanel.Quit;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsLogOut)
            {
                Environment.Exit(0);
            }
            else
            {
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void CarBuyingAccepted()
        {
            HidePanels(false);
            Car car = cars[groupNumber][carNumber];
            forza7BL.ChangeCarStatus(car, currentUser.Name);
            DisplayCars(currentSortingType, lowerBorderPower, upperBorderPower);
            if (cars[groupNumber].Count != 0)
            {
                if (carNumber >= cars[groupNumber].Count)
                {
                    carNumber = cars[groupNumber].Count - 1;
                }
                CarChanging(cars[groupNumber][carNumber]);
            }
            else CarChanging();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CarBuyingAccepted();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void CarBuyingDialog()
        {
            HidePanels(true);
            Car car = cars[groupNumber][carNumber];
            carShortTitle.Text = car.ShortTitle;
            if (!car.WasBought)
            {
                BuyCarTitle.Text = "       BUY CAR?";
                lb_BuyCarQuestion.Text = "Do you want to buy this car for " + car.Price.ToString("N0", CultureInfo.InvariantCulture) + " CR?";
                CollectorScore.Text = "Collector Score +" + car.CollectionPoints.ToString("N0", CultureInfo.InvariantCulture);
                BuyCarAccept.Text = "BUY";
                if ((int.Parse(currentCollectorLevel.Text)) >= CarCollectionLevel(car))
                {
                    if (forza7BL.GetBalance(currentUser.Name) >= car.Price)
                    {
                        panel_BuyCar.Visible = true;
                        activePanel = ActivePanel.CarBuying;
                    }
                    else
                    {
                        panel_NotEnoughMoney.Visible = true;
                        activePanel = ActivePanel.NotEnoughMoney;
                    }
                }
                else
                {
                    necessaryTier.Text = $"You need to reach tier {CarCollectionLevel(car)} to unlock this car";
                    panel_LockedCar.Visible = true;
                    activePanel = ActivePanel.LockedCar;
                }
            }
            else
            {
                BuyCarTitle.Text = "       SELL CAR?";
                lb_BuyCarQuestion.Text = "Do you want to sell this car for " + (car.Price * 0.9).ToString("N0", CultureInfo.InvariantCulture) + " CR?";
                CollectorScore.Text = "Collector Score -" + car.CollectionPoints.ToString("N0", CultureInfo.InvariantCulture);
                BuyCarAccept.Text = "SELL";
                panel_BuyCar.Visible = true;
                activePanel = ActivePanel.CarBuying;
            }
        }

        private void ResettingStatsDialogIsVisible()
        {
            HidePanels(true);
            activePanel = ActivePanel.ResettingStats;
            panelReset.Visible = true;
        }

        private void btnResetCancelled_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void btnResetAccepted_Click(object sender, EventArgs e)
        {
            ResettingStats();
        }

        private void ResettingStats()
        {
            HidePanels(false);
            forza7BL.ResetPurchaseHistory(currentUser.Name);
            lowerBorderPower = 0;
            upperBorderPower = 2050;
            DisplayCars(currentSortingType, lowerBorderPower, upperBorderPower);
            groupNumber = 1;
            carNumber = 0;
            GroupChanged(groupNumber);
            maxCollectorTier = 1;
            currentUnits = currentUser.DefaultUnitsSystem;
        }

        private void DisplayCars(User.SortingType sortingType, int lowerPower, int upperPower)
        {
            collectorTier = forza7BL.GetCollectorTier(out int CollectorScore, out int lowerBorder, out int upperBorder, currentUser.Name);
            if (maxCollectorTier < collectorTier)
            {
                maxCollectorTier = collectorTier;
            }
            cars = forza7BL.GetCarsAndGroupsList(currentUser.Name, sortingType, out groups, lowerPower, upperPower, filteringType);
            MyBudget.Text = forza7BL.GetBalance(currentUser.Name).ToString("N0", CultureInfo.InvariantCulture) + " CR";
            totalCollectorScore.Text = CollectorScore.ToString("N0", CultureInfo.InvariantCulture);
            currentCollectorLevel.Text = collectorTier.ToString();
            CollectorLevelColorDefenition.GetCollectorLevelColor(currentCollectorLevel, collectorTier);
            currentCollectorLevel.Value = (int)((double)(CollectorScore - lowerBorder) / (upperBorder - lowerBorder) * 100);
            CurrentTierUpperBorder.Text = upperBorder.ToString("N0", CultureInfo.InvariantCulture);
            CollectorTierProgress.Text = ("Tier " + currentCollectorLevel.Text + " Progress").ToUpper();
        }

        private void LockedCarOK_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void ChangeVisibleControls(bool editingStarted)
        {
            newCarModel.Visible = editingStarted;
            newCarShortTitle.Visible = editingStarted;
            newCarShortTitle_h.Visible = editingStarted;

            numPrice.Visible = editingStarted;
            numPower.Visible = editingStarted;
            numTorque.Visible = editingStarted;
            numWeight.Visible = editingStarted;
            numFrontWeightPercentage.Visible = editingStarted;
            numPerformanceIndex.Visible = editingStarted;
            numSpeed.Visible = editingStarted;
            numHandling.Visible = editingStarted;
            numAcceleration.Visible = editingStarted;
            numBrake.Visible = editingStarted;
            cbIsFE.Visible = editingStarted;
            num_Year.Visible = editingStarted;
            numCollectorPoints.Visible = editingStarted;
            numCollectorTier.Visible = editingStarted;

            btnSaveNewStats.Visible = editingStarted;
            pb_S.Visible = editingStarted;
            pb_Ctrl1.Visible = editingStarted;
            lb_CtrlPlus1.Visible = editingStarted;
            lb_model.Visible = !editingStarted;

            btnEditManufacturer.Visible = editingStarted;
            cb_CarManufacturer.Visible = editingStarted;
            cb_Divisions.Visible = editingStarted;
            btnAWD.Visible = editingStarted;
            btnRWD.Visible = editingStarted;
            btnFWD.Visible = editingStarted;
            pbFEngine.Visible = editingStarted;
            pbMEngine.Visible = editingStarted;
            pbREngine.Visible = editingStarted;
            btnAddManufacturer.Visible = editingStarted;
            btnAddDivision.Visible = editingStarted;
            btnEditDivision.Visible = editingStarted;
        }

        private void DeactivatingControls(bool editingStarted)
        {
            pb_O.Visible = !editingStarted;
            pb_B.Visible = !editingStarted;
            pb_C.Visible = !editingStarted;
            pb_V.Visible = !editingStarted;
            btnOptions.Visible = !editingStarted;
            btnBuy.Visible = !editingStarted;
            btnSortAndFilter.Visible = !editingStarted;
            btnJumpToGroups.Visible = !editingStarted;
            btnDecreaseGroupNumberBy7.Enabled = !editingStarted;
            btnIncreaseGroupNumberBy7.Enabled = !editingStarted;

            GroupNumberGreaterBy1.Enabled = !editingStarted;
            GroupNumberGreaterBy2.Enabled = !editingStarted;
            GroupNumberGreaterBy3.Enabled = !editingStarted;
            GroupNumberGreaterBy4.Enabled = !editingStarted;
            GroupNumberGreaterBy5.Enabled = !editingStarted;
            GroupNumberGreaterBy6.Enabled = !editingStarted;
            GroupNumberGreaterBy7.Enabled = !editingStarted;

            carNumberIs1Less.Enabled = !editingStarted;
            carNumberIs2Less.Enabled = !editingStarted;
            carNumberIs1More.Enabled = !editingStarted;
            carNumberIs2More.Enabled = !editingStarted;

            MyBudget.Visible = !editingStarted;
            btnResetMyStats.Visible = !editingStarted;

            btnBuy.Visible = !editingStarted;
            CarLocked.Visible = false;
            carIsBought.Visible = false;
        }

        private void EditingStarted(bool IsNewCar)
        {
            newCarAdding = IsNewCar;
            IsChanging = !IsChanging;
            HidePanels(false);
            ChangeVisibleControls(IsChanging);
            if (IsChanging)
            {
                DeactivatingControls(IsChanging);
                CarWithNewStats = new Car(cars[groupNumber][carNumber].Year, cars[groupNumber][carNumber].manufacturer, cars[groupNumber][carNumber].Model, cars[groupNumber][carNumber].Division,
                                          cars[groupNumber][carNumber].Price, cars[groupNumber][carNumber].Speed, cars[groupNumber][carNumber].Handling, cars[groupNumber][carNumber].Acceleration,
                                          cars[groupNumber][carNumber].Brake, cars[groupNumber][carNumber].Power, cars[groupNumber][carNumber].Torque, cars[groupNumber][carNumber].Weight,
                                          cars[groupNumber][carNumber].Front, cars[groupNumber][carNumber].PI, cars[groupNumber][carNumber].Drive, cars[groupNumber][carNumber].EnginePlacement,
                                          cars[groupNumber][carNumber].WasBought, cars[groupNumber][carNumber].CollectionTier, cars[groupNumber][carNumber].CollectionPoints,
                                          cars[groupNumber][carNumber].ShortTitle, cars[groupNumber][carNumber].IsFE, cars[groupNumber][carNumber].ImageNumber);
                cb_CarManufacturer.Text = CarWithNewStats.manufacturer;
                cb_Divisions.Text = CarWithNewStats.Division;
                newCarModel.Text = CarWithNewStats.Model;
                newCarShortTitle.Text = CarWithNewStats.ShortTitle;
                cbIsFE.Checked = CarWithNewStats.IsFE;

                numPower.Value = CarWithNewStats.Power;
                numTorque.Value = CarWithNewStats.Torque;
                numWeight.Value = CarWithNewStats.Weight;
                numFrontWeightPercentage.Value = CarWithNewStats.Front;
                numPerformanceIndex.Value = CarWithNewStats.PI;
                numSpeed.Value = (decimal)CarWithNewStats.Speed;
                numHandling.Value = (decimal)CarWithNewStats.Handling;
                numAcceleration.Value = (decimal)CarWithNewStats.Acceleration;
                numBrake.Value = (decimal)CarWithNewStats.Brake;
                numPrice.Value = CarWithNewStats.Price;
                num_Year.Value = CarWithNewStats.Year;
                numCollectorPoints.Maximum = CarCollectionLevel(CarWithNewStats) * 550;
                numCollectorPoints.Value = CarWithNewStats.CollectionPoints;
                numCollectorTier.Value = collectionTiers.IndexOf(CarWithNewStats.CollectionTier);
            }
        }

        private void newCarShortTitle_TextChanged(object sender, EventArgs e)
        {
            ShortTitleChanged = newCarShortTitle.Text != cars[groupNumber][carNumber].ShortTitle;
        }

        private void newStatsSavingCancelled_Click(object sender, EventArgs e)
        {
            HidePanels(true);
            IsChanging = true;
            ChangeVisibleControls(IsChanging);
            pb_R.Visible = true;
            btnToggleStats.Enabled = true;
        }

        private void newStatsSavingDenied()
        {
            IsChanging = false;
            if (SavingBeforeClosing)
            {
                Environment.Exit(0);
            }
            else if (SavingBeforeReturningToMainMenu)
            {
                Dispose();
            }
            else
            {
                ChangeVisibleControls(IsChanging);
                DeactivatingControls(IsChanging);
                HidePanels(true);
                DisplayCars(currentSortingType, lowerBorderPower, upperBorderPower);
                if (!newCarAdding)
                {
                    CarChanging(cars[groupNumber][carNumber]);
                }
                else
                {
                    groupNumber = 0;
                    GroupChanged(groupNumber);
                }
            }
        }

        private void newStatsNotSaved_Click(object sender, EventArgs e)
        {
            newStatsSavingDenied();
        }

        private void newStatsSavingAccepted()
        {
            IsChanging = false;
            int index = ExistingCombinationsOfYearManufacturerAndModel.IndexOf(cars[groupNumber][carNumber].Year.ToString() + "_" + cars[groupNumber][carNumber].manufacturer + "_" + cars[groupNumber][carNumber].Model);
            if (!newCarAdding)
            {
                forza7BL.UpdateCar(cars[groupNumber][carNumber], CarWithNewStats);
            }
            else
            {
                WorkWithImages.SaveNewImage(currentCar, smallCarImage, "CarImages/Car", CarWithNewStats.ImageNumber);
                forza7BL.AddCar(CarWithNewStats);
            }

            if (SavingBeforeClosing)
            {
                Environment.Exit(0);
            }
            else if (SavingBeforeReturningToMainMenu)
            {
                Dispose();
            }
            else
            {
                ChangeVisibleControls(IsChanging);
                DeactivatingControls(IsChanging);
                HidePanels(false);

                DisplayCars(currentSortingType, lowerBorderPower, upperBorderPower);
                if (!newCarAdding)
                {
                    ExistingCombinationsOfYearManufacturerAndModel[index] = CarWithNewStats.Year.ToString() + "_" + CarWithNewStats.manufacturer + "_" + CarWithNewStats.Model;
                    ExistingShortTitles[index] = CarWithNewStats.ShortTitle;
                }
                else
                {
                    ExistingCombinationsOfYearManufacturerAndModel.Add(CarWithNewStats.Year.ToString() + "_" + CarWithNewStats.manufacturer + "_" + CarWithNewStats.Model);
                    ExistingShortTitles.Add(CarWithNewStats.ShortTitle);
                }

                DefiningNewElementNumberAndGroupNumber();

                if (groupNumber == -1)
                {
                    HidePanels(true);
                    activePanel = ActivePanel.PowerLimitsViolating;
                    panelPowerLimitsViolation.Visible = true;
                }
                else
                {
                    GroupChanged(groupNumber);
                    Car CarWithSavedNewStats = cars[groupNumber].Where(car => car.Model == CarWithNewStats.Model && car.Year == CarWithNewStats.Year && car.manufacturer == CarWithNewStats.manufacturer).First();
                    carNumber = cars[groupNumber].IndexOf(CarWithSavedNewStats);
                    if (carNumber == -1)
                    {
                        HidePanels(true);
                        activePanel = ActivePanel.PowerLimitsViolating;
                        panelPowerLimitsViolation.Visible = true;
                    }
                    CarChanging(cars[groupNumber][carNumber]);
                }
            }
        }

        private void DefiningNewElementNumberAndGroupNumber()
        {
            string NewValue;
            switch (currentSortingType)
            {
                case User.SortingType.Year:
                    {
                        NewValue = (CarWithNewStats.Year / 10 * 10).ToString() + "s";
                        groupNumber = groups.IndexOf(NewValue);
                        break;
                    }
                case User.SortingType.Class:
                    {
                        NewValue = "CLASS " + CarWithNewStats.carClass().ToString();
                        groupNumber = groups.IndexOf(NewValue);
                        break;
                    }
                case User.SortingType.Division:
                    {
                        NewValue = CarWithNewStats.Division;
                        groupNumber = groups.IndexOf(NewValue);
                        break;
                    }
                case User.SortingType.Manufacturer:
                    {
                        NewValue = CarWithNewStats.manufacturer;
                        groupNumber = groups.IndexOf(NewValue);
                        break;
                    }
                case User.SortingType.Country:
                    {
                        Manufacturer manufacturer = manufacturers.Where(m => m.Title == cb_CarManufacturer.SelectedItem.ToString()).Min();
                        NewValue = countries.Where(country => manufacturer.Country == country.CountryCode).Select(country => country.CountryName).First();
                        groupNumber = groups.IndexOf(NewValue);
                        break;
                    }
                case User.SortingType.Price:
                    {
                        if (CarWithNewStats.Price < 50000)
                        {
                            NewValue = (CarWithNewStats.Price / 5000 * 5000).ToString("N0", CultureInfo.InvariantCulture) + "CR+";
                        }
                        else if (CarWithNewStats.Price < 200000)
                        {
                            NewValue = (CarWithNewStats.Price / 10000 * 10000).ToString("N0", CultureInfo.InvariantCulture) + "CR+";
                        }
                        else if (CarWithNewStats.Price < 500000)
                        {
                            NewValue = (CarWithNewStats.Price / 25000 * 25000).ToString("N0", CultureInfo.InvariantCulture) + "CR+";
                        }
                        else if (CarWithNewStats.Price < 1000000)
                        {
                            NewValue = (CarWithNewStats.Price / 50000 * 50000).ToString("N0", CultureInfo.InvariantCulture) + "CR+";
                        }
                        else
                        {
                            NewValue = (CarWithNewStats.Price / 100000 * 100000).ToString("N0", CultureInfo.InvariantCulture) + "CR+";
                        }
                        groupNumber = groups.IndexOf(NewValue);
                        break;
                    }
            }
        }

        private void newStatsSaved_Click(object sender, EventArgs e)
        {
            newStatsSavingAccepted();
        }

        private void newCarModel_Validated(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                CarWithNewStats.Model = newCarModel.Text;
            }
        }

        private void newCarModel_Validating(object sender, CancelEventArgs e)
        {
            if (IsChanging)
            {
                if (string.IsNullOrWhiteSpace(newCarModel.Text.Trim()))
                {
                    newCarModel.BackColor = Color.DarkRed;
                    ErrorText.Text = "Field \"Model\" cannot be empty";
                    ErrorText.ForeColor = Color.DarkRed;
                    e.Cancel = true;
                }
                else if (ExistingCombinationsOfYearManufacturerAndModel.IndexOf(CarWithNewStats.Year.ToString() + "_" + CarWithNewStats.manufacturer + "_" + newCarModel.Text) != -1 && YearOrModelChanged)
                {
                    newCarModel.BackColor = Color.DarkOrange;
                    lb_year.ForeColor = Color.DarkOrange;
                    ErrorText.Text = "This combination of year, manufacturer and model is already taken";
                    e.Cancel = true;
                }
                else
                {
                    newCarModel.BackColor = Color.FromArgb(40, 40, 40);
                    lb_year.ForeColor = Color.White;
                    ErrorText.Text = "";
                    e.Cancel = false;
                }
            }
        }

        private void newCarShortTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newCarShortTitle.Text.Trim()))
            {
                newCarShortTitle.BackColor = Color.DarkRed;
                ErrorText.Text = "Field \"Short title\" cannot be empty";
                ErrorText.ForeColor = Color.DarkRed;
                e.Cancel = true;
            }
            else if (ExistingShortTitles.IndexOf(newCarShortTitle.Text) != -1 && ShortTitleChanged)
            {
                newCarShortTitle.BackColor = Color.DarkOrange;
                ErrorText.ForeColor = Color.DarkOrange;
                ErrorText.Text = "Short name already exists";
                e.Cancel = true;
            }
            else
            {
                ErrorText.ForeColor = Color.White;
                ErrorText.Text = "";
                newCarShortTitle.BackColor = Color.FromArgb(40, 40, 40);
                e.Cancel = false;
            }
        }

        private void newCarShortTitle_Validated(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                CarWithNewStats.ShortTitle = newCarShortTitle.Text;
            }
        }

        private void btnToggleStats_Click(object sender, EventArgs e)
        {
            panelCarStats2.Visible = !panelCarStats2.Visible;
            btnChangeUnits.Visible = panelCarStats2.Visible;
        }

        private void btnChangeUnits_Click(object sender, EventArgs e)
        {
            if (currentUnits == User.UnitsSystem.English)
            {
                currentUnits = User.UnitsSystem.Metric;
            }
            else
            {
                currentUnits = User.UnitsSystem.English;
            }
            if (IsChanging)
            {
                UnitsChanging(CarWithNewStats, currentUnits);
            }
            else UnitsChanging(cars[groupNumber][carNumber], currentUnits);
        }

        private void UnitsChanging(User.UnitsSystem currentUnits, CarsBL.FilterOption filter)
        {
            switch (currentUnits)
            {
                case User.UnitsSystem.English:
                    {
                        switch (filter)
                        {
                            case CarsBL.FilterOption.Power:
                                {
                                    txtMinPower.Text = numMinPower.Value.ToString("N0", CultureInfo.InvariantCulture) + " HP";
                                    txtMaxPower.Text = numMaxPower.Value.ToString("N0", CultureInfo.InvariantCulture) + " HP";
                                    break;
                                }
                            case CarsBL.FilterOption.Weight:
                                {
                                    txtMinPower.Text = numMinPower.Value.ToString("N0", CultureInfo.InvariantCulture) + " LBS";
                                    txtMaxPower.Text = numMaxPower.Value.ToString("N0", CultureInfo.InvariantCulture) + " LBS";
                                    break;
                                }
                        }
                        btnChangeUnits.Text = "Metric units";
                        break;
                    }
                case User.UnitsSystem.Metric:
                    {
                        switch (filter)
                        {
                            case CarsBL.FilterOption.Power:
                                {
                                    txtMinPower.Text = (numMinPower.Value * (decimal)0.7355).ToString("N0", CultureInfo.InvariantCulture) + " KW";
                                    txtMaxPower.Text = (numMaxPower.Value * (decimal)0.7355).ToString("N0", CultureInfo.InvariantCulture) + " KW";
                                    break;
                                }
                            case CarsBL.FilterOption.Weight:
                                {
                                    txtMinPower.Text = (numMinPower.Value * (decimal)0.45359237).ToString("N0", CultureInfo.InvariantCulture) + " KG";
                                    txtMaxPower.Text = (numMaxPower.Value * (decimal)0.45359237).ToString("N0", CultureInfo.InvariantCulture) + " KG";
                                    break;
                                }
                        }
                        btnChangeUnits.Text = "English units";
                        break;
                    }
            }
            switch (filter)
            {
                case CarsBL.FilterOption.PerformanceIndex:
                    {
                        txtMaxPower.Text = numMaxPower.Value.ToString("N0", CultureInfo.InvariantCulture);
                        txtMinPower.Text = numMinPower.Value.ToString("N0", CultureInfo.InvariantCulture);
                        break;
                    }
                case CarsBL.FilterOption.Year:
                    {
                        txtMaxPower.Text = numMaxPower.Value.ToString();
                        txtMinPower.Text = numMinPower.Value.ToString();
                        break;
                    }
                case CarsBL.FilterOption.Price:
                    {
                        txtMaxPower.Text = numMaxPower.Value.ToString("N0", CultureInfo.InvariantCulture) + " CR";
                        txtMinPower.Text = numMinPower.Value.ToString("N0", CultureInfo.InvariantCulture) + " CR";
                        break;
                    }
            }
        }

        private void UnitsChanging(Car car, User.UnitsSystem currentUnits)
        {
            switch (currentUnits)
            {
                case User.UnitsSystem.English:
                    {
                        lb_power.Text = car.Power.ToString("N0", CultureInfo.InvariantCulture) + " HP";
                        lb_torque.Text = car.Torque.ToString("N0", CultureInfo.InvariantCulture) + " LB-FT";
                        lb_weight.Text = car.Weight.ToString("N0", CultureInfo.InvariantCulture) + " LBS";
                        break;
                    }
                case User.UnitsSystem.Metric:
                    {
                        lb_power.Text = (car.Power * 0.7355).ToString("N0", CultureInfo.InvariantCulture) + " KW";
                        lb_torque.Text = (car.Torque * 1.35).ToString("N0", CultureInfo.InvariantCulture) + " N-M";
                        lb_weight.Text = (car.Weight * 0.45359237).ToString("N0", CultureInfo.InvariantCulture) + " KG";
                        break;
                    }
            }
            UnitsChanging(currentUnits, filteringType);
        }

        private void YearOrModelChanging(object sender, EventArgs e)
        {
            if (cars[groupNumber].Count != 0)
            {
                YearOrModelChanged = (lb_year.Text + "_" + lb_manufacturer.Text + "_" + newCarModel.Text.Trim() != cars[groupNumber][carNumber].Year.ToString() + "_" + cars[groupNumber][carNumber].manufacturer + "_" + cars[groupNumber][carNumber].Model);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            HidePanels(true);
            Close();
            IsLogOut = false;
            lb_ExitText.Text = "Are you sure you want quit the game?";
        }

        private void btnResetMyStats_Click(object sender, EventArgs e)
        {
            ResettingStatsDialogIsVisible();
        }

        private void btnEditCarStats_Click(object sender, EventArgs e)
        {
            EditingStarted(false);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            HidePanels(true);
            IsLogOut = true;
            Close();
            lb_ExitText.Text = "Are you sure you want log out from you account?";
            activePanel = ActivePanel.LogOut;
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            HidePanels(true);
            if (!IsChanging)
            {
                activePanel = ActivePanel.ReturnToMainMenu;
                panelToMainMenu.Visible = true;
            }
            else
            {
                panel_newStatsSaving.Visible = true;
                carNewShortTitle.Text = CarWithNewStats.ShortTitle;
                SavingBeforeReturningToMainMenu = true;
            }
        }

        private void btnReturnToMainMenuDenied_Click(object sender, EventArgs e)
        {
            panelToMainMenu.Visible = false;
            OptionsDialogVisible();
        }

        private void ReturnToMainMenuAccepted()
        {
            Dispose();
        }

        private void btnReturnToMainMenuAccepted_Click(object sender, EventArgs e)
        {
            ReturnToMainMenuAccepted();
        }

        private void NewStatsSaving()
        {
            IsChanging = !IsChanging;
            HidePanels(true);
            ChangeVisibleControls(IsChanging);
            if (!IsChanging)
            {
                if (ValidateChildren())
                {
                    carNewShortTitle.Text = CarWithNewStats.ShortTitle;
                    SavingBeforeClosing = false;
                    SavingBeforeReturningToMainMenu = false;
                    panel_newStatsSaving.Visible = !IsChanging;
                    activePanel = ActivePanel.SavingNewStats;
                }
            }
        }

        private void btnSaveNewStats_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                NewStatsSaving();
            }
        }

        private void OptionsDialogVisible()
        {
            if (!panelOptions.Visible)
            {
                HidePanels(true);
                activePanel = ActivePanel.Options;
                panelOptions.Visible = true;
            }
            else
            {
                HidePanels(false);
                panelOptions.Visible = false;
            }
            btnOptions.Enabled = true;
            if (currentUser.IsAdmin)
            {
                btnAddBigImage.Visible = !File.Exists("BigCarImages2/Car" + cars[groupNumber][carNumber].ImageNumber.ToString("0000") + ".png");
                btnAddCarPhoto.Visible = !File.Exists("CarImages/Car" + cars[groupNumber][carNumber].ImageNumber.ToString("0000") + ".png");
                btnDeleteBigImage.Visible = File.Exists("BigCarImages2/Car" + cars[groupNumber][carNumber].ImageNumber.ToString("0000") + ".png");
                btnDeleteSmallImage.Visible = File.Exists("CarImages/Car" + cars[groupNumber][carNumber].ImageNumber.ToString("0000") + ".png");
            }
            else
            {
                btnAddBigImage.Visible = false;
                btnAddCarPhoto.Visible = false;
                btnDeleteBigImage.Visible = false;
                btnDeleteSmallImage.Visible = false;
            }
            pb_O.Visible = true;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsDialogVisible();
        }

        private void rbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivision.Checked)
            {
                sortingType = User.SortingType.Division;
            }
        }

        private void rbManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManufacturer.Checked)
            {
                sortingType = User.SortingType.Manufacturer;
            }
        }

        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClass.Checked)
            {
                sortingType = User.SortingType.Class;
            }
        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYear.Checked)
            {
                sortingType = User.SortingType.Year;
            }
        }

        private void btnApplyNewSortAndFilter_Click(object sender, EventArgs e)
        {
            HidePanels(false);
            lowerBorderPower = int.Parse(numMinPower.Text);
            upperBorderPower = int.Parse(numMaxPower.Text);
            currentSortingType = sortingType;
            DisplayCars(sortingType, lowerBorderPower, upperBorderPower);
            if (groups.Count == 1)
            {
                groupNumber = 0;
            }
            else
            {
                groupNumber = 1;
            }
            GroupChanged(groupNumber);
            SelectingNameDependingOnTheSortingType(currentSortingType);
        }

        private void SelectingNameDependingOnTheSortingType(User.SortingType currentSortingType)
        {
            switch (currentSortingType)
            {
                case User.SortingType.Class:
                    {
                        btnJumpToGroups.Text = "Jump to classes";
                        SortingCriterion.Text = "SORTED BY CLASS";
                        break;
                    }
                case User.SortingType.Country:
                    {
                        btnJumpToGroups.Text = "Jump to countries";
                        SortingCriterion.Text = "SORTED BY COUNTRY";
                        break;
                    }
                case User.SortingType.Division:
                    {
                        btnJumpToGroups.Text = "Jump to divisions";
                        SortingCriterion.Text = "SORTED BY DIVISION";
                        break;
                    }
                case User.SortingType.Manufacturer:
                    {
                        btnJumpToGroups.Text = "Jump to manufacturers";
                        SortingCriterion.Text = "SORTED BY MANUFACTURER";
                        break;
                    }
                case User.SortingType.Price:
                    {
                        btnJumpToGroups.Text = "Jump to prices";
                        SortingCriterion.Text = "SORTED BY PRICE";
                        break;
                    }
                case User.SortingType.Year:
                    {
                        btnJumpToGroups.Text = "Jump to years";
                        SortingCriterion.Text = "SORTED BY YEAR";
                        break;
                    }
            }
        }

        private void btnCloseSortAndFilterPanel_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void btnClearPowerBorders_Click(object sender, EventArgs e)
        {
            numMinPower.Value = numMinPower.Minimum;
            numMaxPower.Value = numMaxPower.Maximum;
        }

        private void numMaxPower_ValueChanged(object sender, EventArgs e)
        {
            if (filteringType == CarsBL.FilterOption.Year)
            {
                UnnecessaryYearsSkipping(numMaxPower);
            }
            if (numMinPower.Value > numMaxPower.Value)
            {
                numMinPower.Value = numMaxPower.Value;
            }
            UnitsChanging(currentUnits, filteringType);
        }

        private void numMinPower_ValueChanged(object sender, EventArgs e)
        {
            if (filteringType == CarsBL.FilterOption.Year)
            {
                UnnecessaryYearsSkipping(numMinPower);
            }
            if (numMinPower.Value > numMaxPower.Value)
            {
                numMaxPower.Value = numMinPower.Value;
            }
            UnitsChanging(currentUnits, filteringType);
        }

        private void UnitsChanged(RadioButton NewSortingType, User.UnitsSystem newUnits)
        {
            if (NewSortingType.Checked)
            {
                currentUnits = newUnits;
                if (cars[groupNumber].Count != 0)
                {
                    UnitsChanging(cars[groupNumber][carNumber], currentUnits);
                }
                else UnitsChanging(currentUnits, filteringType);
            }
        }

        private void rbMetricUnits_CheckedChanged(object sender, EventArgs e)
        {
            UnitsChanged(rbMetricUnits, User.UnitsSystem.Metric);
        }

        private void rbEnglishUnits_CheckedChanged(object sender, EventArgs e)
        {
            UnitsChanged(rbEnglishUnits, User.UnitsSystem.English);
        }

        private void btnSortAndFilter_Click(object sender, EventArgs e)
        {
            SortAndFilterDialogVisible();
        }

        private void SortAndFilterDialogVisible()
        {
            if (!panelSortAndFilter.Visible)
            {
                HidePanels(true);
                activePanel = ActivePanel.Sorting;
                panelSortAndFilter.Visible = true;
            }
            else
            {
                HidePanels(false);
            }
            btnSortAndFilter.Enabled = true;
            pb_C.Visible = true;
            numMinPower.Value = lowerBorderPower;
            numMaxPower.Value = upperBorderPower;
            rbClass.Checked = false;
            rbDivision.Checked = false;
            rbManufacturer.Checked = false;
            rbYear.Checked = false;
            rbMetricUnits.Checked = false;
            rbEnglishUnits.Checked = false;
            rbPrice.Checked = false;
            rbCountry.Checked = false;
            switch (currentSortingType)
            {
                case User.SortingType.Manufacturer:
                    {
                        rbManufacturer.Checked = true;
                        break;
                    }
                case User.SortingType.Division:
                    {
                        rbDivision.Checked = true;
                        break;
                    }
                case User.SortingType.Class:
                    {
                        rbClass.Checked = true;
                        break;
                    }
                case User.SortingType.Year:
                    {
                        rbYear.Checked = true;
                        break;
                    }
                case User.SortingType.Price:
                    {
                        rbPrice.Checked = true;
                        break;
                    }
                case User.SortingType.Country:
                    {
                        rbCountry.Checked = true;
                        break;
                    }
            }
            switch (currentUnits)
            {
                case User.UnitsSystem.English:
                    {
                        rbEnglishUnits.Checked = true;
                        break;
                    }
                case User.UnitsSystem.Metric:
                    {
                        rbMetricUnits.Checked = true;
                        break;
                    }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            HidePanels(true);
            activePanel = ActivePanel.DeletingAcount;
            panelDeleteAccount.Visible = true;
        }

        private void btnDeletingDenied_Click(object sender, EventArgs e)
        {
            HidePanels(false);
        }

        private void btnDeletingAccepted_Click(object sender, EventArgs e)
        {
            DeletingAccount = true;
            Hide();
        }

        private void btnPowerLimitsViolationOK_Click(object sender, EventArgs e)
        {
            HidePanels(false);
            if (groupNumber == -1)
            {
                groupNumber = 1;
                GroupChanged(groupNumber);
            }
            else if (carNumber == -1)
            {
                carNumber = 0;
                CarChanging(cars[groupNumber][carNumber]);
            }
        }

        private void ManufacturersFormOpening(Manufacturer ManufacturerForChange, bool AddingNewManufacturer)
        {
            ManufacturersForm form = new ManufacturersForm(ManufacturerForChange);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                manufacturers = forza7BL.GetManufacturersList().OrderBy(manufacturer => manufacturer.Title).ToList();
                cb_CarManufacturer.Items.Clear();
                cb_CarManufacturer.Items.AddRange(manufacturers.Select(manufacturer => manufacturer.Title).ToArray());
                if (!AddingNewManufacturer)
                {
                    int index = manufacturers.Where(manufacturer => manufacturer.Title == form.ManufacturerWithChangedInfo.Title).Select(manufacturer => manufacturer.Number).Min();
                    cb_CarManufacturer.SelectedItem = ManufacturerForChange.Title;
                    ManufacturerLogoAndCountryFlagAvailibilityCheck(index);
                }

            }
        }

        private void btnEditManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer ManufacturerForChange = manufacturers.Where(m => m.Title == CarWithNewStats.manufacturer).First();
            ManufacturersFormOpening(ManufacturerForChange, false);
        }

        private void currentCar_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid,
                                                  Color.FromArgb(5, 77, 126), 6, ButtonBorderStyle.Solid);
        }

        private void cb_CarManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = manufacturers.Where(m => m.Title == cb_CarManufacturer.SelectedItem.ToString()).Select(m => m.Number).Min();
            ManufacturerLogoAndCountryFlagAvailibilityCheck(number);
            CarWithNewStats.manufacturer = cb_CarManufacturer.SelectedItem.ToString();
        }

        private void cb_Divisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Division = cb_Divisions.SelectedItem.ToString();
            lb_Division.Text = cb_Divisions.SelectedItem.ToString();
        }

        private void rbPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrice.Checked)
            {
                sortingType = User.SortingType.Price;
            }
        }

        private void btnFWD_Click(object sender, EventArgs e)
        {
            CarWithNewStats.EnginePlacement = "F";
            DriveChanged("F");
        }

        private void btnRWD_Click(object sender, EventArgs e)
        {
            DriveChanged("R");
        }

        private void btnAWD_Click(object sender, EventArgs e)
        {
            DriveChanged("A");
        }

        private void ChangeAvailibleEnginePlacements(string Drive)
        {
            pbFEngine.Visible = true;
            pbMEngine.Visible = Drive != "F";
            pbREngine.Visible = Drive != "F";
        }

        private void pbFEngine_Click(object sender, EventArgs e)
        {
            EnginePlacementChanged("F");
        }

        private void pbMEngine_Click(object sender, EventArgs e)
        {
            EnginePlacementChanged("M");
        }

        private void pbREngine_Click(object sender, EventArgs e)
        {
            EnginePlacementChanged("R");
        }

        private void DriveChanged(string NewDrive)
        {
            CarWithNewStats.Drive = NewDrive;
            ChangeAvailibleEnginePlacements(CarWithNewStats.Drive);
            DriveAndEnginePlacementSchemeDefinition(CarWithNewStats);
        }

        private void EnginePlacementChanged(string newEnginePlacement)
        {
            CarWithNewStats.EnginePlacement = newEnginePlacement;
            DriveAndEnginePlacementSchemeDefinition(CarWithNewStats);
        }

        private void numTorque_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Torque = (int)numTorque.Value;
            UnitsChanging(CarWithNewStats, currentUnits);
        }

        private void numWeight_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Weight = (int)numWeight.Value;
            UnitsChanging(CarWithNewStats, currentUnits);
        }

        private void numFrontWeightPercentage_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Front = (int)numFrontWeightPercentage.Value;
            lb_frontWeight.Text = CarWithNewStats.Front.ToString() + "%";
        }

        private void numPerformaceIndex_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.PI = (int)numPerformanceIndex.Value;
            lb_PI.Text = CarWithNewStats.PI.ToString();
            carClassDefinition(CarWithNewStats);
        }

        private void numSpeed_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Speed = (float)numSpeed.Value;
            showCarCharacteristic(CarWithNewStats.Speed, lb_speed, pb_speed);
        }

        private void numHandling_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Handling = (float)numHandling.Value;
            showCarCharacteristic(CarWithNewStats.Handling, lb_handling, pb_handling);
        }

        private void numAcceleration_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Acceleration = (float)numAcceleration.Value;
            showCarCharacteristic(CarWithNewStats.Acceleration, lb_acceleration, pb_acceleration);
        }

        private void numBrake_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Brake = (float)numBrake.Value;
            showCarCharacteristic(CarWithNewStats.Brake, lb_brake, pb_brake);
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Price = (int)numPrice.Value;
            carAvailibilityCheck(CarWithNewStats);
        }

        private void cbIsFE_CheckedChanged(object sender, EventArgs e)
        {
            CarWithNewStats.IsFE = cbIsFE.Checked;
            currentCarFE_Large.Visible = CarWithNewStats.IsFE;
            currentCarFE.Visible = CarWithNewStats.IsFE;
            if (CarWithNewStats.IsFE)
            {
                newCarModel.Text = newCarModel.Text + " Forza Edition";
                newCarShortTitle.Text = newCarShortTitle.Text + " FE";
            }
            else
            {
                newCarModel.Text = newCarModel.Text.Substring(0, newCarModel.Text.Length - 14);
                newCarShortTitle.Text = newCarShortTitle.Text.Substring(0, newCarShortTitle.Text.Length - 3);
            }
            CarWithNewStats.Model = newCarModel.Text;
            CarWithNewStats.ShortTitle = newCarShortTitle.Text;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            cars.Add(new List<Car>());
            groups.Add("");
            groupNumber = cars.Count - 1;
            GroupChanged(groupNumber);
            cars[groupNumber].Add(new Car(1920, "", "", "",
                                      0, 0, 0, 0,
                                      0, 10, 10, 700,
                                      20, 100, "F", "F",
                                      false, collectionTiers[0], 0,
                                      "", false, cars.Where(carList => carList.Count > 0).Max(carList => carList.Max(car => car.ImageNumber + 1))));
            CarChanging(cars[groupNumber][carNumber]);
            WorkWithImages.GetNewImage(currentCar, smallCarImage);
            EditingStarted(true);
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCountry.Checked)
            {
                sortingType = User.SortingType.Country;
            }
        }

        private void cb_CarManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if (IsChanging)
            {
                if (string.IsNullOrWhiteSpace(cb_CarManufacturer.Text.Trim()))
                {
                    cb_CarManufacturer.BackColor = Color.DarkRed;
                    ErrorText.Text = "Field \"Manufacturer\" cannot be empty";
                    ErrorText.ForeColor = Color.DarkRed;
                    e.Cancel = true;
                }
                else
                {
                    cb_CarManufacturer.BackColor = Color.FromArgb(40, 40, 40);
                    ErrorText.Text = "";
                    e.Cancel = false;
                }
            }
        }

        private void UnnecessaryYearsSkipping(NumericUpDown num)
        {
            if (num.Value == 1919)
            {
                num.Value = 723;
            }
            else if (num.Value == 724)
            {
                num.Value = 1920;
            }
            else if (num.Value == 2022)
            {
                num.Value = 2554;
            }
            else if (num.Value == 2553)
            {
                num.Value = 2021;
            }
        }

        private void num_Year_ValueChanged(object sender, EventArgs e)
        {
            UnnecessaryYearsSkipping(num_Year);
            CarWithNewStats.Year = (int)num_Year.Value;
            lb_year.Text = CarWithNewStats.Year.ToString();
        }

        private void numCollectorPoints_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.CollectionPoints = (int)numCollectorPoints.Value;
            CollectionTierDefinition(CarWithNewStats);
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            int maxManufacturerNumber = manufacturers.Max(manufacturer => manufacturer.Number) + 1;
            Manufacturer newManufacturer = new Manufacturer(maxManufacturerNumber, "", "", "");
            ManufacturersFormOpening(newManufacturer, true);
        }

        private void btnAddBigImage_Click(object sender, EventArgs e)
        {
            WorkWithImages.GetNewImage(pb_BigCarImage, smallCarImage);
            WorkWithImages.SaveNewImage(pb_BigCarImage, smallCarImage, "BigCarImages2/Car", cars[groupNumber][carNumber].ImageNumber);
            CarChanging(cars[groupNumber][carNumber]);
        }

        private void btnAddCarPhoto_Click(object sender, EventArgs e)
        {
            WorkWithImages.GetNewImage(currentCar, smallCarImage);
            WorkWithImages.SaveNewImage(currentCar, smallCarImage, "CarImages/Car", cars[groupNumber][carNumber].ImageNumber);
            CarChanging(cars[groupNumber][carNumber]);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cb_FilterCriterions.SelectedIndex)
            {
                case 0:
                    {
                        filteringType = CarsBL.FilterOption.Power;
                        numMaxPower.Maximum = 2500;
                        numMinPower.Minimum = 0;
                        break;
                    }
                case 1:
                    {
                        filteringType = CarsBL.FilterOption.Weight;
                        numMaxPower.Maximum = 17000;
                        numMinPower.Minimum = 300;
                        break;
                    }
                case 2:
                    {
                        filteringType = CarsBL.FilterOption.PerformanceIndex;
                        numMaxPower.Maximum = 999;
                        numMinPower.Minimum = 100;
                        break;
                    }
                case 3:
                    {
                        filteringType = CarsBL.FilterOption.Year;
                        numMaxPower.Maximum = 2554;
                        numMinPower.Minimum = 723;
                        break;
                    }
                case 4:
                    {
                        filteringType = CarsBL.FilterOption.Price;
                        numMaxPower.Maximum = 1600000;
                        numMinPower.Minimum = 0;
                        break;
                    }
            }
            if (cb_FilterCriterions.SelectedIndex == 4)
            {
                numMaxPower.Increment = 500;
            }
            else
            {
                numMaxPower.Increment = 1;
            }
            numMinPower.Increment = numMaxPower.Increment;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numMaxPower.Minimum = numMinPower.Minimum;
            numMinPower.Maximum = numMaxPower.Maximum;
            numMinPower.Value = numMinPower.Minimum;
            numMaxPower.Value = numMaxPower.Maximum;
            lowerBorderPower = (int)numMinPower.Minimum;
            upperBorderPower = (int)numMaxPower.Maximum;
        }

        private void btnSetUnitsSystemForThisUser_Click(object sender, EventArgs e)
        {
            usersBL.SetUnitsSystemForThisUser(currentUser.Name, currentUnits);
            currentUser = usersBL.GetUserInformationByLogin(currentUser.Name);
            currentUnits = currentUser.DefaultUnitsSystem;
        }

        private void btnSetDefaultUnitsSystemForUserCountry_forThisUser_Click(object sender, EventArgs e)
        {
            usersBL.ReturnToDefaultUnitsSystem(currentUser.Name);
            currentUser = usersBL.GetUserInformationByLogin(currentUser.Name);
            currentUnits = currentUser.DefaultUnitsSystem;
        }

        private void numPower_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.Power = (int)numPower.Value;
            UnitsChanging(CarWithNewStats, currentUnits);
        }

        private void numCollectorTier_ValueChanged(object sender, EventArgs e)
        {
            CarWithNewStats.CollectionTier = collectionTiers[(int)numCollectorTier.Value];
            numCollectorPoints.Maximum = 550 * CarCollectionLevel(CarWithNewStats);
            CollectionTierDefinition(CarWithNewStats);
            smallCollectionIconColourDefinition(CarWithNewStats, currentCarTier);
            currentCarLocked.Image = Properties.Resources.IsLocked;
            currentCarLocked.Visible = CarCollectionLevel(CarWithNewStats) > maxCollectorTier;
        }

        private void cb_FilterCriterions_SelectedIndexChanged(object sender, EventArgs e)
        {
            numMaxPower.Minimum = numMinPower.Minimum;
            numMinPower.Maximum = numMaxPower.Maximum;
            numMinPower.Value = numMinPower.Minimum;
            numMaxPower.Value = numMaxPower.Maximum;
            lowerBorderPower = (int)numMinPower.Minimum;
            upperBorderPower = (int)numMaxPower.Maximum;
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            DivisionEditingForm form = new DivisionEditingForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                divisions = forza7BL.GetDivisionsList();
                cb_Divisions.Items.Clear();
                cb_Divisions.Items.AddRange(divisions.ToArray());
            }
        }

        private void btnEditDivision_Click(object sender, EventArgs e)
        {
            DivisionEditingForm form = new DivisionEditingForm(CarWithNewStats.Division);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                divisions = forza7BL.GetDivisionsList();
                cb_Divisions.Items.Clear();
                cb_Divisions.Items.AddRange(divisions.ToArray());
                cb_Divisions.SelectedItem = form.DivisionForChanging;
            }
        }

        private void btnDeleteBigImage_Click(object sender, EventArgs e)
        {
            WorkWithImages.DeleteImage(pb_BigCarImage, "BigCarImages2/Car", cars[groupNumber][carNumber].ImageNumber);
            CarChanging(cars[groupNumber][carNumber]);
        }

        private void btnDeleteSmallImage_Click(object sender, EventArgs e)
        {
            WorkWithImages.DeleteImage(currentCar, "CarImages/Car", cars[groupNumber][carNumber].ImageNumber);
            CarChanging(cars[groupNumber][carNumber]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangingTheGroupForm f = new ChangingTheGroupForm(groups, btnJumpToGroups.Text);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                int Diff = f.groupNumber - groupNumber;
                if (Diff > 0)
                {
                    groupNumberChanging(Diff, PositionChanging.Direction.Up);
                }
                else
                {
                    groupNumberChanging(Math.Abs(Diff), PositionChanging.Direction.Down);
                }
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

        private void RadioButton_MouseEnter(object sender, EventArgs e)
        {
            MouseActions.MouseEnter(sender as RadioButton);
        }

        private void RadioButton_MouseLeave(object sender, EventArgs e)
        {
            MouseActions.MouseLeave(sender as RadioButton);
        }
    }
}