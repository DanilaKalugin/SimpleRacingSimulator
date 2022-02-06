namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label lb_frontWeight_h;
            System.Windows.Forms.Label lb_Weight_h;
            System.Windows.Forms.Label lb_torque_h;
            System.Windows.Forms.Label lb_power_h;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label lb_brake_h;
            System.Windows.Forms.Label lb_acceleration_h;
            System.Windows.Forms.Label lb_handling_h;
            System.Windows.Forms.Label lb_speed_h;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.PictureBox pictureBox3;
            System.Windows.Forms.PictureBox pictureBox4;
            System.Windows.Forms.PictureBox pictureBox5;
            System.Windows.Forms.PictureBox pictureBox6;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.PictureBox pictureBox7;
            System.Windows.Forms.PictureBox pictureBox9;
            System.Windows.Forms.PictureBox pictureBox11;
            System.Windows.Forms.PictureBox pictureBox12;
            System.Windows.Forms.Label label23;
            this.BuyCarTitle = new System.Windows.Forms.Label();
            this.currentGroup = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy1 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy2 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy3 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy4 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy5 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy6 = new System.Windows.Forms.Label();
            this.btnDecreaseGroupNumberBy7 = new System.Windows.Forms.Button();
            this.btnIncreaseGroupNumberBy7 = new System.Windows.Forms.Button();
            this.GroupNumberGreaterBy7 = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_manufacturer = new System.Windows.Forms.Label();
            this.lb_model = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SortingCriterion = new System.Windows.Forms.Label();
            this.carPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.currentCollectorLevel = new CircularProgressBar.CircularProgressBar();
            this.CurrentTierUpperBorder = new System.Windows.Forms.Label();
            this.CollectorTierProgress = new System.Windows.Forms.Label();
            this.totalCollectorScore = new System.Windows.Forms.Label();
            this.MyBudget = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel_Quit = new System.Windows.Forms.Panel();
            this.lb_ExitText = new System.Windows.Forms.Label();
            this.btnExitDenied = new System.Windows.Forms.Button();
            this.btnExitAccepted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_BuyCar = new System.Windows.Forms.Panel();
            this.CollectorScore = new System.Windows.Forms.Label();
            this.carShortTitle = new System.Windows.Forms.Label();
            this.lb_BuyCarQuestion = new System.Windows.Forms.Label();
            this.BuyCarCancel = new System.Windows.Forms.Button();
            this.BuyCarAccept = new System.Windows.Forms.Button();
            this.panel_NotEnoughMoney = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NotEnoughMoneyOK = new System.Windows.Forms.Button();
            this.panelCollectorInfo = new System.Windows.Forms.Panel();
            this.lb_TierTitle = new System.Windows.Forms.Label();
            this.numCollectorTier = new System.Windows.Forms.NumericUpDown();
            this.lb_CollectionPoints = new System.Windows.Forms.Label();
            this.numCollectorPoints = new System.Windows.Forms.NumericUpDown();
            this.pb_TierImage = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.panelReset = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetCancelled = new System.Windows.Forms.Button();
            this.btnResetAccepted = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_LockedCar = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.necessaryTier = new System.Windows.Forms.Label();
            this.LockedCarOK = new System.Windows.Forms.Button();
            this.newCarModel = new System.Windows.Forms.TextBox();
            this.newCarShortTitle = new System.Windows.Forms.TextBox();
            this.newCarShortTitle_h = new System.Windows.Forms.Label();
            this.panel_newStatsSaving = new System.Windows.Forms.Panel();
            this.carNewShortTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newStatsSaved = new System.Windows.Forms.Button();
            this.newStatsSavingCancelled = new System.Windows.Forms.Button();
            this.newStatsNotSaved = new System.Windows.Forms.Button();
            this.panelCarStats2 = new System.Windows.Forms.Panel();
            this.lb_frontWeight = new System.Windows.Forms.Label();
            this.numFrontWeightPercentage = new System.Windows.Forms.NumericUpDown();
            this.lb_weight = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lb_torque = new System.Windows.Forms.Label();
            this.numTorque = new System.Windows.Forms.NumericUpDown();
            this.lb_power = new System.Windows.Forms.Label();
            this.numPower = new System.Windows.Forms.NumericUpDown();
            this.btnToggleStats = new System.Windows.Forms.Button();
            this.btnChangeUnits = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.lb_Division = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnDeleteSmallImage = new System.Windows.Forms.Button();
            this.btnDeleteBigImage = new System.Windows.Forms.Button();
            this.btnAddCarPhoto = new System.Windows.Forms.Button();
            this.btnAddBigImage = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnResetMyStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditCarStats = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.panelToMainMenu = new System.Windows.Forms.Panel();
            this.btnReturnToMainMenuDenied = new System.Windows.Forms.Button();
            this.btnReturnToMainMenuAccepted = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveNewStats = new System.Windows.Forms.Button();
            this.panelSortAndFilter = new System.Windows.Forms.Panel();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.cb_FilterCriterions = new System.Windows.Forms.ComboBox();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.panelUnits = new System.Windows.Forms.Panel();
            this.btnSetUnitsSystemForThisUser = new System.Windows.Forms.Button();
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser = new System.Windows.Forms.Button();
            this.rbEnglishUnits = new System.Windows.Forms.RadioButton();
            this.rbMetricUnits = new System.Windows.Forms.RadioButton();
            this.txtMaxPower = new System.Windows.Forms.Label();
            this.txtMinPower = new System.Windows.Forms.Label();
            this.btnClearPowerBorders = new System.Windows.Forms.Button();
            this.btnCloseSortAndFilterPanel = new System.Windows.Forms.Button();
            this.numMaxPower = new System.Windows.Forms.NumericUpDown();
            this.numMinPower = new System.Windows.Forms.NumericUpDown();
            this.btnApplyNewSortAndFilter = new System.Windows.Forms.Button();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbClass = new System.Windows.Forms.RadioButton();
            this.rbManufacturer = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.btnSortAndFilter = new System.Windows.Forms.Button();
            this.panelDeleteAccount = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDeletingDenied = new System.Windows.Forms.Button();
            this.btnDeletingAccepted = new System.Windows.Forms.Button();
            this.lblDelete_H = new System.Windows.Forms.Label();
            this.cb_CarManufacturer = new System.Windows.Forms.ComboBox();
            this.panelPowerLimitsViolation = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPowerLimitsViolationOK = new System.Windows.Forms.Button();
            this.btnEditManufacturer = new System.Windows.Forms.Button();
            this.lb_CtrlPlus1 = new System.Windows.Forms.Label();
            this.cb_Divisions = new System.Windows.Forms.ComboBox();
            this.cbIsFE = new System.Windows.Forms.CheckBox();
            this.panelCarStats = new System.Windows.Forms.Panel();
            this.btnAWD = new System.Windows.Forms.Button();
            this.btnRWD = new System.Windows.Forms.Button();
            this.btnFWD = new System.Windows.Forms.Button();
            this.pbREngine = new System.Windows.Forms.PictureBox();
            this.pbMEngine = new System.Windows.Forms.PictureBox();
            this.pbFEngine = new System.Windows.Forms.PictureBox();
            this.lb_PI = new System.Windows.Forms.Label();
            this.numPerformanceIndex = new System.Windows.Forms.NumericUpDown();
            this.lb_brake = new System.Windows.Forms.Label();
            this.lb_acceleration = new System.Windows.Forms.Label();
            this.numAcceleration = new System.Windows.Forms.NumericUpDown();
            this.lb_handling = new System.Windows.Forms.Label();
            this.numHandling = new System.Windows.Forms.NumericUpDown();
            this.lb_speed = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.lb_CarClass = new System.Windows.Forms.Label();
            this.pb_brake = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_acceleration = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_handling = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.pb_speed = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.EngineAndDrivenWheels_scheme = new System.Windows.Forms.PictureBox();
            this.manufacturerCountry = new System.Windows.Forms.PictureBox();
            this.numBrake = new System.Windows.Forms.NumericUpDown();
            this.smallCarImage = new System.Windows.Forms.OpenFileDialog();
            this.num_Year = new System.Windows.Forms.NumericUpDown();
            this.btnAddManufacturer = new System.Windows.Forms.Button();
            this.btnAddDivision = new System.Windows.Forms.Button();
            this.btnEditDivision = new System.Windows.Forms.Button();
            this.btnJumpToGroups = new System.Windows.Forms.Button();
            this.pb_C = new System.Windows.Forms.Label();
            this.pb_B = new System.Windows.Forms.Label();
            this.pb_O = new System.Windows.Forms.Label();
            this.pb_R = new System.Windows.Forms.Label();
            this.pb_V = new System.Windows.Forms.Label();
            this.pb_S = new System.Windows.Forms.Label();
            this.pb_Ctrl1 = new System.Windows.Forms.Label();
            this.ManufacturerLogo = new System.Windows.Forms.PictureBox();
            this.pb_Division = new System.Windows.Forms.PictureBox();
            this.carNumberIs2MoreLocked = new System.Windows.Forms.PictureBox();
            this.carNumberIs1MoreLocked = new System.Windows.Forms.PictureBox();
            this.currentCarLocked = new System.Windows.Forms.PictureBox();
            this.carNumberIs1LessLocked = new System.Windows.Forms.PictureBox();
            this.carNumberIs2LessLocked = new System.Windows.Forms.PictureBox();
            this.carNumberIs2MoreTier = new System.Windows.Forms.PictureBox();
            this.carNumberIs1MoreTier = new System.Windows.Forms.PictureBox();
            this.currentCarTier = new System.Windows.Forms.PictureBox();
            this.carNumberIs1LessTier = new System.Windows.Forms.PictureBox();
            this.carNumberIs2LessTier = new System.Windows.Forms.PictureBox();
            this.carNumberIs2LessFE = new System.Windows.Forms.PictureBox();
            this.carNumberIs2MoreFE = new System.Windows.Forms.PictureBox();
            this.carNumberIs1MoreFE = new System.Windows.Forms.PictureBox();
            this.currentCarFE_Large = new System.Windows.Forms.PictureBox();
            this.currentCarFE = new System.Windows.Forms.PictureBox();
            this.carNumberIs1LessFE = new System.Windows.Forms.PictureBox();
            this.carIsBought = new System.Windows.Forms.PictureBox();
            this.carNumberIs2Less = new System.Windows.Forms.Label();
            this.carNumberIs1More = new System.Windows.Forms.Label();
            this.carNumberIs2More = new System.Windows.Forms.Label();
            this.carNumberIs1Less = new System.Windows.Forms.Label();
            this.CarLocked = new System.Windows.Forms.PictureBox();
            this.currentCar = new System.Windows.Forms.PictureBox();
            this.pb_BigCarImage = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lb_frontWeight_h = new System.Windows.Forms.Label();
            lb_Weight_h = new System.Windows.Forms.Label();
            lb_torque_h = new System.Windows.Forms.Label();
            lb_power_h = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lb_brake_h = new System.Windows.Forms.Label();
            lb_acceleration_h = new System.Windows.Forms.Label();
            lb_handling_h = new System.Windows.Forms.Label();
            lb_speed_h = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            label22 = new System.Windows.Forms.Label();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            pictureBox9 = new System.Windows.Forms.PictureBox();
            pictureBox11 = new System.Windows.Forms.PictureBox();
            pictureBox12 = new System.Windows.Forms.PictureBox();
            label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox12)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panel_Quit.SuspendLayout();
            this.panel_BuyCar.SuspendLayout();
            this.panel_NotEnoughMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panelCollectorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectorTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectorPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TierImage)).BeginInit();
            this.panelReset.SuspendLayout();
            this.panel_LockedCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel_newStatsSaving.SuspendLayout();
            this.panelCarStats2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrontWeightPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.panelToMainMenu.SuspendLayout();
            this.panelSortAndFilter.SuspendLayout();
            this.panelUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPower)).BeginInit();
            this.panelDeleteAccount.SuspendLayout();
            this.panelPowerLimitsViolation.SuspendLayout();
            this.panelCarStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbREngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerformanceIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHandling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngineAndDrivenWheels_scheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2MoreLocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1MoreLocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarLocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1LessLocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2LessLocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2MoreTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1MoreTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1LessTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2LessTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2LessFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2MoreFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1MoreFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarFE_Large)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1LessFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carIsBought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarLocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BigCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(418, 123);
            label6.TabIndex = 0;
            label6.Text = "      INSUFFICIENT CREDITS";
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label10.Dock = System.Windows.Forms.DockStyle.Top;
            label10.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(0, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(418, 123);
            label10.TabIndex = 0;
            label10.Text = "      CAR IS LOCKED";
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label11.Dock = System.Windows.Forms.DockStyle.Top;
            label11.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(0, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(418, 210);
            label11.TabIndex = 0;
            label11.Text = "      SAVING";
            // 
            // lb_frontWeight_h
            // 
            lb_frontWeight_h.AutoSize = true;
            lb_frontWeight_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_frontWeight_h.ForeColor = System.Drawing.Color.White;
            lb_frontWeight_h.Location = new System.Drawing.Point(487, 0);
            lb_frontWeight_h.Name = "lb_frontWeight_h";
            lb_frontWeight_h.Size = new System.Drawing.Size(61, 19);
            lb_frontWeight_h.TabIndex = 4;
            lb_frontWeight_h.Text = "FRONT";
            // 
            // lb_Weight_h
            // 
            lb_Weight_h.AutoSize = true;
            lb_Weight_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Weight_h.ForeColor = System.Drawing.Color.White;
            lb_Weight_h.Location = new System.Drawing.Point(328, 0);
            lb_Weight_h.Name = "lb_Weight_h";
            lb_Weight_h.Size = new System.Drawing.Size(70, 19);
            lb_Weight_h.TabIndex = 4;
            lb_Weight_h.Text = "WEIGHT";
            // 
            // lb_torque_h
            // 
            lb_torque_h.AutoSize = true;
            lb_torque_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_torque_h.ForeColor = System.Drawing.Color.White;
            lb_torque_h.Location = new System.Drawing.Point(169, 0);
            lb_torque_h.Name = "lb_torque_h";
            lb_torque_h.Size = new System.Drawing.Size(73, 19);
            lb_torque_h.TabIndex = 4;
            lb_torque_h.Text = "TORQUE";
            // 
            // lb_power_h
            // 
            lb_power_h.AutoSize = true;
            lb_power_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_power_h.ForeColor = System.Drawing.Color.White;
            lb_power_h.Location = new System.Drawing.Point(10, 0);
            lb_power_h.Name = "lb_power_h";
            lb_power_h.Size = new System.Drawing.Size(66, 19);
            lb_power_h.TabIndex = 4;
            lb_power_h.Text = "POWER";
            // 
            // label13
            // 
            label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label13.Dock = System.Windows.Forms.DockStyle.Top;
            label13.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(0, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(418, 70);
            label13.TabIndex = 0;
            label13.Text = "      OPTIONS";
            // 
            // label16
            // 
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            label16.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label16.ForeColor = System.Drawing.Color.White;
            label16.Location = new System.Drawing.Point(3, 264);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(100, 21);
            label16.TabIndex = 5;
            label16.Text = "<=";
            // 
            // label15
            // 
            label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            label15.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label15.ForeColor = System.Drawing.Color.White;
            label15.Location = new System.Drawing.Point(3, 240);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(100, 19);
            label15.TabIndex = 5;
            label15.Text = ">=";
            // 
            // label14
            // 
            label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            label14.Font = new System.Drawing.Font("Forza Medium", 12F);
            label14.Location = new System.Drawing.Point(-1, 201);
            label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(420, 29);
            label14.TabIndex = 2;
            label14.Text = "  FILTER BY POWER";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            label12.Font = new System.Drawing.Font("Forza Medium", 12F);
            label12.Location = new System.Drawing.Point(0, 111);
            label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(420, 29);
            label12.TabIndex = 2;
            label12.Text = "  SORT BY";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(420, 104);
            label2.TabIndex = 1;
            label2.Text = "      SORT/FILTER";
            // 
            // label17
            // 
            label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            label17.Font = new System.Drawing.Font("Forza Medium", 12F);
            label17.Location = new System.Drawing.Point(1, 317);
            label17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(420, 29);
            label17.TabIndex = 10;
            label17.Text = "  UNITS";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label20.Dock = System.Windows.Forms.DockStyle.Top;
            label20.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(0, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(418, 123);
            label20.TabIndex = 0;
            label20.Text = "      WARNING";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(641, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(61, 19);
            label9.TabIndex = 4;
            label9.Text = "CLASS";
            // 
            // lb_brake_h
            // 
            lb_brake_h.AutoSize = true;
            lb_brake_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_brake_h.ForeColor = System.Drawing.Color.White;
            lb_brake_h.Location = new System.Drawing.Point(487, 0);
            lb_brake_h.Name = "lb_brake_h";
            lb_brake_h.Size = new System.Drawing.Size(61, 19);
            lb_brake_h.TabIndex = 4;
            lb_brake_h.Text = "BRAKE";
            // 
            // lb_acceleration_h
            // 
            lb_acceleration_h.AutoSize = true;
            lb_acceleration_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_acceleration_h.ForeColor = System.Drawing.Color.White;
            lb_acceleration_h.Location = new System.Drawing.Point(328, 0);
            lb_acceleration_h.Name = "lb_acceleration_h";
            lb_acceleration_h.Size = new System.Drawing.Size(126, 19);
            lb_acceleration_h.TabIndex = 4;
            lb_acceleration_h.Text = "ACCELERATION";
            // 
            // lb_handling_h
            // 
            lb_handling_h.AutoSize = true;
            lb_handling_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_handling_h.ForeColor = System.Drawing.Color.White;
            lb_handling_h.Location = new System.Drawing.Point(169, 0);
            lb_handling_h.Name = "lb_handling_h";
            lb_handling_h.Size = new System.Drawing.Size(90, 19);
            lb_handling_h.TabIndex = 4;
            lb_handling_h.Text = "HANDLING";
            // 
            // lb_speed_h
            // 
            lb_speed_h.AutoSize = true;
            lb_speed_h.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_speed_h.ForeColor = System.Drawing.Color.White;
            lb_speed_h.Location = new System.Drawing.Point(10, 0);
            lb_speed_h.Name = "lb_speed_h";
            lb_speed_h.Size = new System.Drawing.Size(61, 19);
            lb_speed_h.TabIndex = 4;
            lb_speed_h.Text = "SPEED";
            // 
            // label21
            // 
            label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            label21.Location = new System.Drawing.Point(1040, 56);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(2, 23);
            label21.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(24, 24);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(5, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(24, 24);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            pictureBox4.Location = new System.Drawing.Point(5, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(24, 24);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            pictureBox5.Location = new System.Drawing.Point(5, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(24, 24);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            pictureBox6.Location = new System.Drawing.Point(5, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(24, 24);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // label22
            // 
            label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label22.Font = new System.Drawing.Font("Forza Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = System.Drawing.Color.Black;
            label22.Image = global::WindowsFormsApp2.Properties.Resources.SteeringWheel;
            label22.Location = new System.Drawing.Point(9, 6);
            label22.Margin = new System.Windows.Forms.Padding(6);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(34, 34);
            label22.TabIndex = 59;
            label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            pictureBox7.Location = new System.Drawing.Point(5, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(24, 24);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            pictureBox9.Location = new System.Drawing.Point(5, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(24, 24);
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 4;
            pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            pictureBox11.Location = new System.Drawing.Point(5, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(24, 24);
            pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 4;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            pictureBox12.Location = new System.Drawing.Point(5, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new System.Drawing.Size(24, 24);
            pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 4;
            pictureBox12.TabStop = false;
            // 
            // label23
            // 
            label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label23.Font = new System.Drawing.Font("Forza Bold", 12F);
            label23.ForeColor = System.Drawing.Color.White;
            label23.Location = new System.Drawing.Point(52, 12);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(161, 23);
            label23.TabIndex = 60;
            label23.Text = "BUY CARS";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BuyCarTitle
            // 
            this.BuyCarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BuyCarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyCarTitle.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCarTitle.Location = new System.Drawing.Point(0, 0);
            this.BuyCarTitle.Name = "BuyCarTitle";
            this.BuyCarTitle.Size = new System.Drawing.Size(418, 210);
            this.BuyCarTitle.TabIndex = 0;
            this.BuyCarTitle.Text = "      BUY CAR?";
            // 
            // currentGroup
            // 
            this.currentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentGroup.BackColor = System.Drawing.Color.White;
            this.currentGroup.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.currentGroup.ForeColor = System.Drawing.Color.Black;
            this.currentGroup.Location = new System.Drawing.Point(49, 103);
            this.currentGroup.Name = "currentGroup";
            this.currentGroup.Size = new System.Drawing.Size(155, 23);
            this.currentGroup.TabIndex = 0;
            this.currentGroup.Text = "1";
            this.currentGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupNumberGreaterBy1
            // 
            this.GroupNumberGreaterBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy1.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy1.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy1.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy1.Location = new System.Drawing.Point(209, 103);
            this.GroupNumberGreaterBy1.Name = "GroupNumberGreaterBy1";
            this.GroupNumberGreaterBy1.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy1.TabIndex = 0;
            this.GroupNumberGreaterBy1.Text = "2";
            this.GroupNumberGreaterBy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy1.Click += new System.EventHandler(this.label2_Click);
            this.GroupNumberGreaterBy1.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy1.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // GroupNumberGreaterBy2
            // 
            this.GroupNumberGreaterBy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy2.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy2.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy2.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy2.Location = new System.Drawing.Point(369, 103);
            this.GroupNumberGreaterBy2.Name = "GroupNumberGreaterBy2";
            this.GroupNumberGreaterBy2.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy2.TabIndex = 0;
            this.GroupNumberGreaterBy2.Text = "3";
            this.GroupNumberGreaterBy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy2.Click += new System.EventHandler(this.label3_Click);
            this.GroupNumberGreaterBy2.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy2.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // GroupNumberGreaterBy3
            // 
            this.GroupNumberGreaterBy3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy3.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy3.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy3.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy3.Location = new System.Drawing.Point(530, 103);
            this.GroupNumberGreaterBy3.Name = "GroupNumberGreaterBy3";
            this.GroupNumberGreaterBy3.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy3.TabIndex = 0;
            this.GroupNumberGreaterBy3.Text = "4";
            this.GroupNumberGreaterBy3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy3.Click += new System.EventHandler(this.label4_Click);
            this.GroupNumberGreaterBy3.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy3.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // GroupNumberGreaterBy4
            // 
            this.GroupNumberGreaterBy4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNumberGreaterBy4.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy4.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy4.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy4.Location = new System.Drawing.Point(692, 103);
            this.GroupNumberGreaterBy4.Name = "GroupNumberGreaterBy4";
            this.GroupNumberGreaterBy4.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy4.TabIndex = 0;
            this.GroupNumberGreaterBy4.Text = "5";
            this.GroupNumberGreaterBy4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy4.Click += new System.EventHandler(this.label5_Click);
            this.GroupNumberGreaterBy4.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy4.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // GroupNumberGreaterBy5
            // 
            this.GroupNumberGreaterBy5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNumberGreaterBy5.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy5.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy5.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy5.Location = new System.Drawing.Point(853, 103);
            this.GroupNumberGreaterBy5.Name = "GroupNumberGreaterBy5";
            this.GroupNumberGreaterBy5.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy5.TabIndex = 0;
            this.GroupNumberGreaterBy5.Text = "6";
            this.GroupNumberGreaterBy5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy5.Click += new System.EventHandler(this.label6_Click);
            this.GroupNumberGreaterBy5.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy5.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // GroupNumberGreaterBy6
            // 
            this.GroupNumberGreaterBy6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNumberGreaterBy6.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy6.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy6.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy6.Location = new System.Drawing.Point(1013, 103);
            this.GroupNumberGreaterBy6.Name = "GroupNumberGreaterBy6";
            this.GroupNumberGreaterBy6.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy6.TabIndex = 0;
            this.GroupNumberGreaterBy6.Text = "7";
            this.GroupNumberGreaterBy6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy6.Click += new System.EventHandler(this.label7_Click);
            this.GroupNumberGreaterBy6.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy6.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // btnDecreaseGroupNumberBy7
            // 
            this.btnDecreaseGroupNumberBy7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecreaseGroupNumberBy7.BackColor = System.Drawing.Color.Black;
            this.btnDecreaseGroupNumberBy7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecreaseGroupNumberBy7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseGroupNumberBy7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecreaseGroupNumberBy7.Location = new System.Drawing.Point(9, 103);
            this.btnDecreaseGroupNumberBy7.Name = "btnDecreaseGroupNumberBy7";
            this.btnDecreaseGroupNumberBy7.Size = new System.Drawing.Size(34, 23);
            this.btnDecreaseGroupNumberBy7.TabIndex = 1;
            this.btnDecreaseGroupNumberBy7.TabStop = false;
            this.btnDecreaseGroupNumberBy7.Text = "[";
            this.btnDecreaseGroupNumberBy7.UseVisualStyleBackColor = false;
            this.btnDecreaseGroupNumberBy7.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIncreaseGroupNumberBy7
            // 
            this.btnIncreaseGroupNumberBy7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseGroupNumberBy7.BackColor = System.Drawing.Color.Black;
            this.btnIncreaseGroupNumberBy7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncreaseGroupNumberBy7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseGroupNumberBy7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncreaseGroupNumberBy7.Location = new System.Drawing.Point(1333, 103);
            this.btnIncreaseGroupNumberBy7.Name = "btnIncreaseGroupNumberBy7";
            this.btnIncreaseGroupNumberBy7.Size = new System.Drawing.Size(34, 23);
            this.btnIncreaseGroupNumberBy7.TabIndex = 1;
            this.btnIncreaseGroupNumberBy7.TabStop = false;
            this.btnIncreaseGroupNumberBy7.Text = "]";
            this.btnIncreaseGroupNumberBy7.UseVisualStyleBackColor = false;
            this.btnIncreaseGroupNumberBy7.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupNumberGreaterBy7
            // 
            this.GroupNumberGreaterBy7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNumberGreaterBy7.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy7.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy7.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy7.Location = new System.Drawing.Point(1173, 103);
            this.GroupNumberGreaterBy7.Name = "GroupNumberGreaterBy7";
            this.GroupNumberGreaterBy7.Size = new System.Drawing.Size(155, 23);
            this.GroupNumberGreaterBy7.TabIndex = 0;
            this.GroupNumberGreaterBy7.Text = "8";
            this.GroupNumberGreaterBy7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy7.Click += new System.EventHandler(this.label8_Click);
            this.GroupNumberGreaterBy7.MouseLeave += new System.EventHandler(this.MouseLeaving);
            this.GroupNumberGreaterBy7.MouseHover += new System.EventHandler(this.MouseHove);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_year.ForeColor = System.Drawing.Color.White;
            this.lb_year.Location = new System.Drawing.Point(462, 191);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(65, 29);
            this.lb_year.TabIndex = 4;
            this.lb_year.Text = "Year";
            this.lb_year.TextChanged += new System.EventHandler(this.YearOrModelChanging);
            // 
            // lb_manufacturer
            // 
            this.lb_manufacturer.AutoSize = true;
            this.lb_manufacturer.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_manufacturer.ForeColor = System.Drawing.Color.White;
            this.lb_manufacturer.Location = new System.Drawing.Point(528, 191);
            this.lb_manufacturer.Name = "lb_manufacturer";
            this.lb_manufacturer.Size = new System.Drawing.Size(145, 29);
            this.lb_manufacturer.TabIndex = 4;
            this.lb_manufacturer.Text = "Manufacter";
            // 
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.BackColor = System.Drawing.Color.Transparent;
            this.lb_model.Font = new System.Drawing.Font("Forza Light", 16F);
            this.lb_model.ForeColor = System.Drawing.Color.White;
            this.lb_model.Location = new System.Drawing.Point(463, 220);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(75, 26);
            this.lb_model.TabIndex = 4;
            this.lb_model.Text = "Model";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.SortingCriterion);
            this.panel4.Controls.Add(label23);
            this.panel4.Controls.Add(label22);
            this.panel4.Controls.Add(label21);
            this.panel4.Controls.Add(this.carPrice);
            this.panel4.Controls.Add(this.numPrice);
            this.panel4.Controls.Add(this.currentCollectorLevel);
            this.panel4.Controls.Add(this.CurrentTierUpperBorder);
            this.panel4.Controls.Add(this.CollectorTierProgress);
            this.panel4.Controls.Add(this.totalCollectorScore);
            this.panel4.Controls.Add(this.MyBudget);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy6);
            this.panel4.Controls.Add(this.currentGroup);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy1);
            this.panel4.Controls.Add(this.btnIncreaseGroupNumberBy7);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy2);
            this.panel4.Controls.Add(this.btnDecreaseGroupNumberBy7);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy3);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy7);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy4);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy5);
            this.panel4.Font = new System.Drawing.Font("Forza Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 136);
            this.panel4.TabIndex = 5;
            // 
            // SortingCriterion
            // 
            this.SortingCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortingCriterion.Font = new System.Drawing.Font("Forza Bold", 12F);
            this.SortingCriterion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.SortingCriterion.Location = new System.Drawing.Point(52, 50);
            this.SortingCriterion.Name = "SortingCriterion";
            this.SortingCriterion.Size = new System.Drawing.Size(312, 23);
            this.SortingCriterion.TabIndex = 61;
            this.SortingCriterion.Text = "BUY CARS";
            this.SortingCriterion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carPrice
            // 
            this.carPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carPrice.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.carPrice.ForeColor = System.Drawing.Color.Black;
            this.carPrice.Location = new System.Drawing.Point(1205, 56);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(152, 23);
            this.carPrice.TabIndex = 0;
            this.carPrice.Text = "Price";
            this.carPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrice.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(1225, 56);
            this.numPrice.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 23);
            this.numPrice.TabIndex = 27;
            this.numPrice.TabStop = false;
            this.numPrice.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numPrice.Visible = false;
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // currentCollectorLevel
            // 
            this.currentCollectorLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentCollectorLevel.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.currentCollectorLevel.AnimationSpeed = 500;
            this.currentCollectorLevel.BackColor = System.Drawing.Color.Gainsboro;
            this.currentCollectorLevel.Font = new System.Drawing.Font("Forza Medium", 16F, System.Drawing.FontStyle.Bold);
            this.currentCollectorLevel.ForeColor = System.Drawing.Color.White;
            this.currentCollectorLevel.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.currentCollectorLevel.InnerMargin = 2;
            this.currentCollectorLevel.InnerWidth = 21;
            this.currentCollectorLevel.Location = new System.Drawing.Point(1134, 28);
            this.currentCollectorLevel.MarqueeAnimationSpeed = 2000;
            this.currentCollectorLevel.Name = "currentCollectorLevel";
            this.currentCollectorLevel.OuterColor = System.Drawing.Color.White;
            this.currentCollectorLevel.OuterMargin = -5;
            this.currentCollectorLevel.OuterWidth = 5;
            this.currentCollectorLevel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.currentCollectorLevel.ProgressWidth = 5;
            this.currentCollectorLevel.SecondaryFont = new System.Drawing.Font("Forza Medium", 12F);
            this.currentCollectorLevel.Size = new System.Drawing.Size(60, 60);
            this.currentCollectorLevel.StartAngle = 270;
            this.currentCollectorLevel.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.currentCollectorLevel.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.currentCollectorLevel.SubscriptText = "";
            this.currentCollectorLevel.SuperscriptColor = System.Drawing.Color.White;
            this.currentCollectorLevel.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.currentCollectorLevel.SuperscriptText = "";
            this.currentCollectorLevel.TabIndex = 2;
            this.currentCollectorLevel.Text = "99";
            this.currentCollectorLevel.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.currentCollectorLevel.Value = 68;
            // 
            // CurrentTierUpperBorder
            // 
            this.CurrentTierUpperBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTierUpperBorder.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.CurrentTierUpperBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CurrentTierUpperBorder.Location = new System.Drawing.Point(1046, 56);
            this.CurrentTierUpperBorder.Name = "CurrentTierUpperBorder";
            this.CurrentTierUpperBorder.Size = new System.Drawing.Size(82, 23);
            this.CurrentTierUpperBorder.TabIndex = 0;
            this.CurrentTierUpperBorder.Text = "Upper Border";
            this.CurrentTierUpperBorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CollectorTierProgress
            // 
            this.CollectorTierProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectorTierProgress.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.CollectorTierProgress.ForeColor = System.Drawing.Color.White;
            this.CollectorTierProgress.Location = new System.Drawing.Point(968, 33);
            this.CollectorTierProgress.Name = "CollectorTierProgress";
            this.CollectorTierProgress.Size = new System.Drawing.Size(161, 23);
            this.CollectorTierProgress.TabIndex = 0;
            this.CollectorTierProgress.Text = "Collector Score";
            this.CollectorTierProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCollectorScore
            // 
            this.totalCollectorScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCollectorScore.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.totalCollectorScore.ForeColor = System.Drawing.Color.White;
            this.totalCollectorScore.Location = new System.Drawing.Point(952, 56);
            this.totalCollectorScore.Name = "totalCollectorScore";
            this.totalCollectorScore.Size = new System.Drawing.Size(82, 23);
            this.totalCollectorScore.TabIndex = 0;
            this.totalCollectorScore.Text = "Collector Score";
            this.totalCollectorScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyBudget
            // 
            this.MyBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyBudget.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.MyBudget.ForeColor = System.Drawing.Color.White;
            this.MyBudget.Location = new System.Drawing.Point(1201, 33);
            this.MyBudget.Name = "MyBudget";
            this.MyBudget.Size = new System.Drawing.Size(156, 23);
            this.MyBudget.TabIndex = 0;
            this.MyBudget.Text = "Budget";
            this.MyBudget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(1222, 733);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(45, 23);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.TabStop = false;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel_Quit
            // 
            this.panel_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panel_Quit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Quit.Controls.Add(pictureBox12);
            this.panel_Quit.Controls.Add(this.lb_ExitText);
            this.panel_Quit.Controls.Add(this.btnExitDenied);
            this.panel_Quit.Controls.Add(this.btnExitAccepted);
            this.panel_Quit.Controls.Add(this.label1);
            this.panel_Quit.Location = new System.Drawing.Point(974, 161);
            this.panel_Quit.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Quit.Name = "panel_Quit";
            this.panel_Quit.Size = new System.Drawing.Size(420, 500);
            this.panel_Quit.TabIndex = 10;
            this.panel_Quit.Visible = false;
            // 
            // lb_ExitText
            // 
            this.lb_ExitText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ExitText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_ExitText.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExitText.Location = new System.Drawing.Point(0, 41);
            this.lb_ExitText.Name = "lb_ExitText";
            this.lb_ExitText.Size = new System.Drawing.Size(418, 50);
            this.lb_ExitText.TabIndex = 2;
            this.lb_ExitText.Text = "Are you sure you want to quit the game?";
            // 
            // btnExitDenied
            // 
            this.btnExitDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExitDenied.FlatAppearance.BorderSize = 0;
            this.btnExitDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDenied.ForeColor = System.Drawing.Color.White;
            this.btnExitDenied.Location = new System.Drawing.Point(0, 164);
            this.btnExitDenied.Name = "btnExitDenied";
            this.btnExitDenied.Size = new System.Drawing.Size(418, 23);
            this.btnExitDenied.TabIndex = 1;
            this.btnExitDenied.Text = "CANCEL";
            this.btnExitDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitDenied.UseVisualStyleBackColor = false;
            this.btnExitDenied.Click += new System.EventHandler(this.button4_Click);
            this.btnExitDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnExitDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnExitAccepted
            // 
            this.btnExitAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExitAccepted.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitAccepted.FlatAppearance.BorderSize = 0;
            this.btnExitAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAccepted.ForeColor = System.Drawing.Color.White;
            this.btnExitAccepted.Location = new System.Drawing.Point(0, 135);
            this.btnExitAccepted.Name = "btnExitAccepted";
            this.btnExitAccepted.Size = new System.Drawing.Size(418, 23);
            this.btnExitAccepted.TabIndex = 1;
            this.btnExitAccepted.Text = "OK";
            this.btnExitAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitAccepted.UseVisualStyleBackColor = false;
            this.btnExitAccepted.Click += new System.EventHandler(this.button3_Click);
            this.btnExitAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnExitAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "      QUITTING?";
            // 
            // panel_BuyCar
            // 
            this.panel_BuyCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_BuyCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panel_BuyCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BuyCar.Controls.Add(pictureBox11);
            this.panel_BuyCar.Controls.Add(this.CollectorScore);
            this.panel_BuyCar.Controls.Add(this.carShortTitle);
            this.panel_BuyCar.Controls.Add(this.lb_BuyCarQuestion);
            this.panel_BuyCar.Controls.Add(this.BuyCarCancel);
            this.panel_BuyCar.Controls.Add(this.BuyCarAccept);
            this.panel_BuyCar.Controls.Add(this.BuyCarTitle);
            this.panel_BuyCar.Location = new System.Drawing.Point(974, 161);
            this.panel_BuyCar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_BuyCar.Name = "panel_BuyCar";
            this.panel_BuyCar.Size = new System.Drawing.Size(420, 500);
            this.panel_BuyCar.TabIndex = 11;
            this.panel_BuyCar.Visible = false;
            // 
            // CollectorScore
            // 
            this.CollectorScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectorScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CollectorScore.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectorScore.Location = new System.Drawing.Point(0, 70);
            this.CollectorScore.Name = "CollectorScore";
            this.CollectorScore.Size = new System.Drawing.Size(418, 30);
            this.CollectorScore.TabIndex = 2;
            // 
            // carShortTitle
            // 
            this.carShortTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carShortTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carShortTitle.Font = new System.Drawing.Font("Forza Medium", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carShortTitle.Location = new System.Drawing.Point(0, 38);
            this.carShortTitle.Name = "carShortTitle";
            this.carShortTitle.Size = new System.Drawing.Size(418, 85);
            this.carShortTitle.TabIndex = 2;
            // 
            // lb_BuyCarQuestion
            // 
            this.lb_BuyCarQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_BuyCarQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_BuyCarQuestion.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BuyCarQuestion.Location = new System.Drawing.Point(0, 145);
            this.lb_BuyCarQuestion.Name = "lb_BuyCarQuestion";
            this.lb_BuyCarQuestion.Size = new System.Drawing.Size(418, 50);
            this.lb_BuyCarQuestion.TabIndex = 2;
            // 
            // BuyCarCancel
            // 
            this.BuyCarCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyCarCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BuyCarCancel.FlatAppearance.BorderSize = 0;
            this.BuyCarCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyCarCancel.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCarCancel.ForeColor = System.Drawing.Color.White;
            this.BuyCarCancel.Location = new System.Drawing.Point(0, 246);
            this.BuyCarCancel.Name = "BuyCarCancel";
            this.BuyCarCancel.Size = new System.Drawing.Size(418, 23);
            this.BuyCarCancel.TabIndex = 1;
            this.BuyCarCancel.Text = "CANCEL";
            this.BuyCarCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyCarCancel.UseVisualStyleBackColor = false;
            this.BuyCarCancel.Click += new System.EventHandler(this.button5_Click);
            this.BuyCarCancel.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.BuyCarCancel.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // BuyCarAccept
            // 
            this.BuyCarAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyCarAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BuyCarAccept.FlatAppearance.BorderSize = 0;
            this.BuyCarAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyCarAccept.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCarAccept.ForeColor = System.Drawing.Color.White;
            this.BuyCarAccept.Location = new System.Drawing.Point(0, 217);
            this.BuyCarAccept.Name = "BuyCarAccept";
            this.BuyCarAccept.Size = new System.Drawing.Size(418, 23);
            this.BuyCarAccept.TabIndex = 1;
            this.BuyCarAccept.Text = "BUY";
            this.BuyCarAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyCarAccept.UseVisualStyleBackColor = false;
            this.BuyCarAccept.Click += new System.EventHandler(this.button6_Click);
            this.BuyCarAccept.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.BuyCarAccept.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // panel_NotEnoughMoney
            // 
            this.panel_NotEnoughMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_NotEnoughMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panel_NotEnoughMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NotEnoughMoney.Controls.Add(this.pictureBox10);
            this.panel_NotEnoughMoney.Controls.Add(this.label5);
            this.panel_NotEnoughMoney.Controls.Add(this.NotEnoughMoneyOK);
            this.panel_NotEnoughMoney.Controls.Add(label6);
            this.panel_NotEnoughMoney.Location = new System.Drawing.Point(974, 161);
            this.panel_NotEnoughMoney.Margin = new System.Windows.Forms.Padding(0);
            this.panel_NotEnoughMoney.Name = "panel_NotEnoughMoney";
            this.panel_NotEnoughMoney.Size = new System.Drawing.Size(420, 500);
            this.panel_NotEnoughMoney.TabIndex = 12;
            this.panel_NotEnoughMoney.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApp2.Properties.Resources.IsLockedWhite;
            this.pictureBox10.Location = new System.Drawing.Point(5, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 30;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 50);
            this.label5.TabIndex = 2;
            this.label5.Text = "You currently do not enough CR to buy this car.";
            // 
            // NotEnoughMoneyOK
            // 
            this.NotEnoughMoneyOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotEnoughMoneyOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NotEnoughMoneyOK.FlatAppearance.BorderSize = 0;
            this.NotEnoughMoneyOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotEnoughMoneyOK.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotEnoughMoneyOK.ForeColor = System.Drawing.Color.White;
            this.NotEnoughMoneyOK.Location = new System.Drawing.Point(0, 130);
            this.NotEnoughMoneyOK.Name = "NotEnoughMoneyOK";
            this.NotEnoughMoneyOK.Size = new System.Drawing.Size(418, 23);
            this.NotEnoughMoneyOK.TabIndex = 1;
            this.NotEnoughMoneyOK.Text = "OK";
            this.NotEnoughMoneyOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotEnoughMoneyOK.UseVisualStyleBackColor = false;
            this.NotEnoughMoneyOK.Click += new System.EventHandler(this.button8_Click);
            this.NotEnoughMoneyOK.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.NotEnoughMoneyOK.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // panelCollectorInfo
            // 
            this.panelCollectorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelCollectorInfo.Controls.Add(this.lb_TierTitle);
            this.panelCollectorInfo.Controls.Add(this.numCollectorTier);
            this.panelCollectorInfo.Controls.Add(this.lb_CollectionPoints);
            this.panelCollectorInfo.Controls.Add(this.numCollectorPoints);
            this.panelCollectorInfo.Controls.Add(this.pb_TierImage);
            this.panelCollectorInfo.Location = new System.Drawing.Point(255, 326);
            this.panelCollectorInfo.Name = "panelCollectorInfo";
            this.panelCollectorInfo.Size = new System.Drawing.Size(181, 72);
            this.panelCollectorInfo.TabIndex = 13;
            // 
            // lb_TierTitle
            // 
            this.lb_TierTitle.Font = new System.Drawing.Font("Forza Medium", 11.25F);
            this.lb_TierTitle.ForeColor = System.Drawing.Color.Black;
            this.lb_TierTitle.Location = new System.Drawing.Point(66, 13);
            this.lb_TierTitle.Name = "lb_TierTitle";
            this.lb_TierTitle.Size = new System.Drawing.Size(106, 21);
            this.lb_TierTitle.TabIndex = 4;
            this.lb_TierTitle.Text = "Year";
            this.lb_TierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCollectorTier
            // 
            this.numCollectorTier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.numCollectorTier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCollectorTier.Font = new System.Drawing.Font("Forza Medium", 11.25F);
            this.numCollectorTier.Location = new System.Drawing.Point(66, 13);
            this.numCollectorTier.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCollectorTier.Name = "numCollectorTier";
            this.numCollectorTier.Size = new System.Drawing.Size(115, 21);
            this.numCollectorTier.TabIndex = 26;
            this.numCollectorTier.Visible = false;
            this.numCollectorTier.ValueChanged += new System.EventHandler(this.numCollectorTier_ValueChanged);
            // 
            // lb_CollectionPoints
            // 
            this.lb_CollectionPoints.Font = new System.Drawing.Font("Forza Medium", 11.25F);
            this.lb_CollectionPoints.ForeColor = System.Drawing.Color.Black;
            this.lb_CollectionPoints.Location = new System.Drawing.Point(66, 42);
            this.lb_CollectionPoints.Name = "lb_CollectionPoints";
            this.lb_CollectionPoints.Size = new System.Drawing.Size(66, 18);
            this.lb_CollectionPoints.TabIndex = 4;
            this.lb_CollectionPoints.Text = "Year";
            this.lb_CollectionPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCollectorPoints
            // 
            this.numCollectorPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.numCollectorPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCollectorPoints.Font = new System.Drawing.Font("Forza Medium", 11.25F);
            this.numCollectorPoints.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCollectorPoints.Location = new System.Drawing.Point(66, 42);
            this.numCollectorPoints.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.numCollectorPoints.Name = "numCollectorPoints";
            this.numCollectorPoints.Size = new System.Drawing.Size(83, 21);
            this.numCollectorPoints.TabIndex = 25;
            this.numCollectorPoints.TabStop = false;
            this.numCollectorPoints.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCollectorPoints.Visible = false;
            this.numCollectorPoints.ValueChanged += new System.EventHandler(this.numCollectorPoints_ValueChanged);
            // 
            // pb_TierImage
            // 
            this.pb_TierImage.Location = new System.Drawing.Point(12, 12);
            this.pb_TierImage.Name = "pb_TierImage";
            this.pb_TierImage.Size = new System.Drawing.Size(48, 48);
            this.pb_TierImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_TierImage.TabIndex = 0;
            this.pb_TierImage.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(1118, 733);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 7;
            this.btnOptions.TabStop = false;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.UseMnemonic = false;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // panelReset
            // 
            this.panelReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReset.Controls.Add(pictureBox9);
            this.panelReset.Controls.Add(this.label4);
            this.panelReset.Controls.Add(this.btnResetCancelled);
            this.panelReset.Controls.Add(this.btnResetAccepted);
            this.panelReset.Controls.Add(this.label7);
            this.panelReset.Location = new System.Drawing.Point(974, 161);
            this.panelReset.Margin = new System.Windows.Forms.Padding(0);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(420, 500);
            this.panelReset.TabIndex = 14;
            this.panelReset.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Are you sure you want to reset purchase history?";
            // 
            // btnResetCancelled
            // 
            this.btnResetCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetCancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnResetCancelled.FlatAppearance.BorderSize = 0;
            this.btnResetCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCancelled.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCancelled.ForeColor = System.Drawing.Color.White;
            this.btnResetCancelled.Location = new System.Drawing.Point(0, 164);
            this.btnResetCancelled.Name = "btnResetCancelled";
            this.btnResetCancelled.Size = new System.Drawing.Size(418, 23);
            this.btnResetCancelled.TabIndex = 1;
            this.btnResetCancelled.TabStop = false;
            this.btnResetCancelled.Text = "CANCEL";
            this.btnResetCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetCancelled.UseVisualStyleBackColor = true;
            this.btnResetCancelled.Click += new System.EventHandler(this.btnResetCancelled_Click);
            this.btnResetCancelled.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnResetCancelled.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnResetAccepted
            // 
            this.btnResetAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnResetAccepted.FlatAppearance.BorderSize = 0;
            this.btnResetAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAccepted.ForeColor = System.Drawing.Color.White;
            this.btnResetAccepted.Location = new System.Drawing.Point(0, 135);
            this.btnResetAccepted.Name = "btnResetAccepted";
            this.btnResetAccepted.Size = new System.Drawing.Size(418, 23);
            this.btnResetAccepted.TabIndex = 1;
            this.btnResetAccepted.TabStop = false;
            this.btnResetAccepted.Text = "OK";
            this.btnResetAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetAccepted.UseVisualStyleBackColor = false;
            this.btnResetAccepted.Click += new System.EventHandler(this.btnResetAccepted_Click);
            this.btnResetAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnResetAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 128);
            this.label7.TabIndex = 0;
            this.label7.Text = "      RESET?";
            // 
            // panel_LockedCar
            // 
            this.panel_LockedCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LockedCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panel_LockedCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LockedCar.Controls.Add(this.pictureBox8);
            this.panel_LockedCar.Controls.Add(this.necessaryTier);
            this.panel_LockedCar.Controls.Add(this.LockedCarOK);
            this.panel_LockedCar.Controls.Add(label10);
            this.panel_LockedCar.Location = new System.Drawing.Point(974, 161);
            this.panel_LockedCar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_LockedCar.Name = "panel_LockedCar";
            this.panel_LockedCar.Size = new System.Drawing.Size(420, 500);
            this.panel_LockedCar.TabIndex = 16;
            this.panel_LockedCar.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp2.Properties.Resources.IsLockedWhite;
            this.pictureBox8.Location = new System.Drawing.Point(5, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            // 
            // necessaryTier
            // 
            this.necessaryTier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.necessaryTier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.necessaryTier.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.necessaryTier.Location = new System.Drawing.Point(0, 57);
            this.necessaryTier.Name = "necessaryTier";
            this.necessaryTier.Size = new System.Drawing.Size(418, 50);
            this.necessaryTier.TabIndex = 2;
            this.necessaryTier.Text = "You need to reach tier # to unlock this car";
            // 
            // LockedCarOK
            // 
            this.LockedCarOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LockedCarOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LockedCarOK.FlatAppearance.BorderSize = 0;
            this.LockedCarOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockedCarOK.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockedCarOK.ForeColor = System.Drawing.Color.White;
            this.LockedCarOK.Location = new System.Drawing.Point(0, 130);
            this.LockedCarOK.Name = "LockedCarOK";
            this.LockedCarOK.Size = new System.Drawing.Size(418, 23);
            this.LockedCarOK.TabIndex = 1;
            this.LockedCarOK.Text = "OK";
            this.LockedCarOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LockedCarOK.UseVisualStyleBackColor = false;
            this.LockedCarOK.Click += new System.EventHandler(this.LockedCarOK_Click);
            this.LockedCarOK.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.LockedCarOK.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // newCarModel
            // 
            this.newCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCarModel.Font = new System.Drawing.Font("Forza Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCarModel.ForeColor = System.Drawing.Color.White;
            this.newCarModel.Location = new System.Drawing.Point(463, 229);
            this.newCarModel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.newCarModel.MaxLength = 70;
            this.newCarModel.Name = "newCarModel";
            this.newCarModel.Size = new System.Drawing.Size(502, 33);
            this.newCarModel.TabIndex = 18;
            this.newCarModel.Visible = false;
            this.newCarModel.TextChanged += new System.EventHandler(this.YearOrModelChanging);
            this.newCarModel.Validating += new System.ComponentModel.CancelEventHandler(this.newCarModel_Validating);
            this.newCarModel.Validated += new System.EventHandler(this.newCarModel_Validated);
            // 
            // newCarShortTitle
            // 
            this.newCarShortTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newCarShortTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCarShortTitle.Font = new System.Drawing.Font("Forza Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCarShortTitle.ForeColor = System.Drawing.Color.White;
            this.newCarShortTitle.Location = new System.Drawing.Point(542, 275);
            this.newCarShortTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.newCarShortTitle.MaxLength = 25;
            this.newCarShortTitle.Name = "newCarShortTitle";
            this.newCarShortTitle.Size = new System.Drawing.Size(281, 33);
            this.newCarShortTitle.TabIndex = 18;
            this.newCarShortTitle.Visible = false;
            this.newCarShortTitle.TextChanged += new System.EventHandler(this.newCarShortTitle_TextChanged);
            this.newCarShortTitle.Validating += new System.ComponentModel.CancelEventHandler(this.newCarShortTitle_Validating);
            this.newCarShortTitle.Validated += new System.EventHandler(this.newCarShortTitle_Validated);
            // 
            // newCarShortTitle_h
            // 
            this.newCarShortTitle_h.AutoSize = true;
            this.newCarShortTitle_h.Font = new System.Drawing.Font("Forza Light", 16F);
            this.newCarShortTitle_h.ForeColor = System.Drawing.Color.White;
            this.newCarShortTitle_h.Location = new System.Drawing.Point(463, 275);
            this.newCarShortTitle_h.Name = "newCarShortTitle_h";
            this.newCarShortTitle_h.Size = new System.Drawing.Size(73, 26);
            this.newCarShortTitle_h.TabIndex = 20;
            this.newCarShortTitle_h.Text = "Short:";
            this.newCarShortTitle_h.Visible = false;
            // 
            // panel_newStatsSaving
            // 
            this.panel_newStatsSaving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_newStatsSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panel_newStatsSaving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_newStatsSaving.Controls.Add(pictureBox7);
            this.panel_newStatsSaving.Controls.Add(this.carNewShortTitle);
            this.panel_newStatsSaving.Controls.Add(this.label8);
            this.panel_newStatsSaving.Controls.Add(this.newStatsSaved);
            this.panel_newStatsSaving.Controls.Add(label11);
            this.panel_newStatsSaving.Controls.Add(this.newStatsSavingCancelled);
            this.panel_newStatsSaving.Controls.Add(this.newStatsNotSaved);
            this.panel_newStatsSaving.Location = new System.Drawing.Point(974, 161);
            this.panel_newStatsSaving.Margin = new System.Windows.Forms.Padding(0);
            this.panel_newStatsSaving.Name = "panel_newStatsSaving";
            this.panel_newStatsSaving.Size = new System.Drawing.Size(420, 500);
            this.panel_newStatsSaving.TabIndex = 23;
            this.panel_newStatsSaving.Visible = false;
            // 
            // carNewShortTitle
            // 
            this.carNewShortTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carNewShortTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carNewShortTitle.Font = new System.Drawing.Font("Forza Medium", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNewShortTitle.Location = new System.Drawing.Point(0, 38);
            this.carNewShortTitle.Name = "carNewShortTitle";
            this.carNewShortTitle.Size = new System.Drawing.Size(418, 85);
            this.carNewShortTitle.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 50);
            this.label8.TabIndex = 2;
            this.label8.Text = "Do you want to save new stats of this car?";
            // 
            // newStatsSaved
            // 
            this.newStatsSaved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStatsSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newStatsSaved.FlatAppearance.BorderSize = 0;
            this.newStatsSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newStatsSaved.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStatsSaved.ForeColor = System.Drawing.Color.White;
            this.newStatsSaved.Location = new System.Drawing.Point(0, 217);
            this.newStatsSaved.Name = "newStatsSaved";
            this.newStatsSaved.Size = new System.Drawing.Size(418, 23);
            this.newStatsSaved.TabIndex = 1;
            this.newStatsSaved.Text = "YES";
            this.newStatsSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newStatsSaved.UseVisualStyleBackColor = false;
            this.newStatsSaved.Click += new System.EventHandler(this.newStatsSaved_Click);
            this.newStatsSaved.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.newStatsSaved.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // newStatsSavingCancelled
            // 
            this.newStatsSavingCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStatsSavingCancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newStatsSavingCancelled.FlatAppearance.BorderSize = 0;
            this.newStatsSavingCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newStatsSavingCancelled.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStatsSavingCancelled.ForeColor = System.Drawing.Color.White;
            this.newStatsSavingCancelled.Location = new System.Drawing.Point(0, 275);
            this.newStatsSavingCancelled.Name = "newStatsSavingCancelled";
            this.newStatsSavingCancelled.Size = new System.Drawing.Size(418, 23);
            this.newStatsSavingCancelled.TabIndex = 1;
            this.newStatsSavingCancelled.Text = "CANCEL";
            this.newStatsSavingCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newStatsSavingCancelled.UseVisualStyleBackColor = false;
            this.newStatsSavingCancelled.Click += new System.EventHandler(this.newStatsSavingCancelled_Click);
            this.newStatsSavingCancelled.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.newStatsSavingCancelled.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // newStatsNotSaved
            // 
            this.newStatsNotSaved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newStatsNotSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newStatsNotSaved.FlatAppearance.BorderSize = 0;
            this.newStatsNotSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newStatsNotSaved.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStatsNotSaved.ForeColor = System.Drawing.Color.White;
            this.newStatsNotSaved.Location = new System.Drawing.Point(0, 246);
            this.newStatsNotSaved.Name = "newStatsNotSaved";
            this.newStatsNotSaved.Size = new System.Drawing.Size(418, 23);
            this.newStatsNotSaved.TabIndex = 1;
            this.newStatsNotSaved.Text = "NO";
            this.newStatsNotSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newStatsNotSaved.UseVisualStyleBackColor = false;
            this.newStatsNotSaved.Click += new System.EventHandler(this.newStatsNotSaved_Click);
            this.newStatsNotSaved.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.newStatsNotSaved.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // panelCarStats2
            // 
            this.panelCarStats2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCarStats2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelCarStats2.Controls.Add(this.lb_frontWeight);
            this.panelCarStats2.Controls.Add(this.numFrontWeightPercentage);
            this.panelCarStats2.Controls.Add(this.lb_weight);
            this.panelCarStats2.Controls.Add(this.numWeight);
            this.panelCarStats2.Controls.Add(this.lb_torque);
            this.panelCarStats2.Controls.Add(this.numTorque);
            this.panelCarStats2.Controls.Add(this.lb_power);
            this.panelCarStats2.Controls.Add(this.numPower);
            this.panelCarStats2.Controls.Add(lb_frontWeight_h);
            this.panelCarStats2.Controls.Add(lb_Weight_h);
            this.panelCarStats2.Controls.Add(lb_torque_h);
            this.panelCarStats2.Controls.Add(lb_power_h);
            this.panelCarStats2.Font = new System.Drawing.Font("Forza Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelCarStats2.Location = new System.Drawing.Point(449, 654);
            this.panelCarStats2.Name = "panelCarStats2";
            this.panelCarStats2.Size = new System.Drawing.Size(640, 73);
            this.panelCarStats2.TabIndex = 24;
            this.panelCarStats2.Visible = false;
            // 
            // lb_frontWeight
            // 
            this.lb_frontWeight.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_frontWeight.ForeColor = System.Drawing.Color.White;
            this.lb_frontWeight.Location = new System.Drawing.Point(487, 29);
            this.lb_frontWeight.Name = "lb_frontWeight";
            this.lb_frontWeight.Size = new System.Drawing.Size(115, 19);
            this.lb_frontWeight.TabIndex = 4;
            this.lb_frontWeight.Text = "0";
            // 
            // numFrontWeightPercentage
            // 
            this.numFrontWeightPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numFrontWeightPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFrontWeightPercentage.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numFrontWeightPercentage.Location = new System.Drawing.Point(487, 29);
            this.numFrontWeightPercentage.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numFrontWeightPercentage.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFrontWeightPercentage.Name = "numFrontWeightPercentage";
            this.numFrontWeightPercentage.Size = new System.Drawing.Size(133, 23);
            this.numFrontWeightPercentage.TabIndex = 26;
            this.numFrontWeightPercentage.TabStop = false;
            this.numFrontWeightPercentage.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numFrontWeightPercentage.Visible = false;
            this.numFrontWeightPercentage.ValueChanged += new System.EventHandler(this.numFrontWeightPercentage_ValueChanged);
            // 
            // lb_weight
            // 
            this.lb_weight.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_weight.ForeColor = System.Drawing.Color.White;
            this.lb_weight.Location = new System.Drawing.Point(328, 29);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(115, 19);
            this.lb_weight.TabIndex = 4;
            this.lb_weight.Text = "0";
            // 
            // numWeight
            // 
            this.numWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numWeight.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numWeight.Location = new System.Drawing.Point(328, 29);
            this.numWeight.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.numWeight.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(133, 23);
            this.numWeight.TabIndex = 25;
            this.numWeight.TabStop = false;
            this.numWeight.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numWeight.Visible = false;
            this.numWeight.ValueChanged += new System.EventHandler(this.numWeight_ValueChanged);
            // 
            // lb_torque
            // 
            this.lb_torque.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_torque.ForeColor = System.Drawing.Color.White;
            this.lb_torque.Location = new System.Drawing.Point(169, 29);
            this.lb_torque.Name = "lb_torque";
            this.lb_torque.Size = new System.Drawing.Size(115, 19);
            this.lb_torque.TabIndex = 4;
            this.lb_torque.Text = "0";
            // 
            // numTorque
            // 
            this.numTorque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numTorque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numTorque.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numTorque.Location = new System.Drawing.Point(169, 29);
            this.numTorque.Maximum = new decimal(new int[] {
            4500,
            0,
            0,
            0});
            this.numTorque.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTorque.Name = "numTorque";
            this.numTorque.Size = new System.Drawing.Size(133, 23);
            this.numTorque.TabIndex = 24;
            this.numTorque.TabStop = false;
            this.numTorque.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTorque.Visible = false;
            this.numTorque.ValueChanged += new System.EventHandler(this.numTorque_ValueChanged);
            // 
            // lb_power
            // 
            this.lb_power.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_power.ForeColor = System.Drawing.Color.White;
            this.lb_power.Location = new System.Drawing.Point(10, 29);
            this.lb_power.Name = "lb_power";
            this.lb_power.Size = new System.Drawing.Size(115, 19);
            this.lb_power.TabIndex = 4;
            this.lb_power.Text = "0";
            // 
            // numPower
            // 
            this.numPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPower.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numPower.Location = new System.Drawing.Point(10, 29);
            this.numPower.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numPower.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPower.Name = "numPower";
            this.numPower.Size = new System.Drawing.Size(133, 23);
            this.numPower.TabIndex = 23;
            this.numPower.TabStop = false;
            this.numPower.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPower.Visible = false;
            this.numPower.ValueChanged += new System.EventHandler(this.numPower_ValueChanged);
            // 
            // btnToggleStats
            // 
            this.btnToggleStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleStats.FlatAppearance.BorderSize = 0;
            this.btnToggleStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleStats.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnToggleStats.ForeColor = System.Drawing.Color.White;
            this.btnToggleStats.Location = new System.Drawing.Point(1026, 733);
            this.btnToggleStats.Name = "btnToggleStats";
            this.btnToggleStats.Size = new System.Drawing.Size(63, 23);
            this.btnToggleStats.TabIndex = 7;
            this.btnToggleStats.TabStop = false;
            this.btnToggleStats.Text = "Toggle";
            this.btnToggleStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleStats.UseMnemonic = false;
            this.btnToggleStats.UseVisualStyleBackColor = true;
            this.btnToggleStats.Click += new System.EventHandler(this.btnToggleStats_Click);
            // 
            // btnChangeUnits
            // 
            this.btnChangeUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeUnits.FlatAppearance.BorderSize = 0;
            this.btnChangeUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUnits.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnChangeUnits.ForeColor = System.Drawing.Color.White;
            this.btnChangeUnits.Location = new System.Drawing.Point(675, 733);
            this.btnChangeUnits.Name = "btnChangeUnits";
            this.btnChangeUnits.Size = new System.Drawing.Size(124, 23);
            this.btnChangeUnits.TabIndex = 7;
            this.btnChangeUnits.TabStop = false;
            this.btnChangeUnits.Text = "Change Units";
            this.btnChangeUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUnits.UseMnemonic = false;
            this.btnChangeUnits.UseVisualStyleBackColor = true;
            this.btnChangeUnits.Visible = false;
            this.btnChangeUnits.Click += new System.EventHandler(this.btnChangeUnits_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.ErrorText.ForeColor = System.Drawing.Color.White;
            this.ErrorText.Location = new System.Drawing.Point(445, 513);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(79, 29);
            this.ErrorText.TabIndex = 4;
            this.ErrorText.Text = "Error:";
            // 
            // lb_Division
            // 
            this.lb_Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(171)))), ((int)(((byte)(175)))));
            this.lb_Division.Font = new System.Drawing.Font("Forza Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Division.Location = new System.Drawing.Point(246, 605);
            this.lb_Division.Name = "lb_Division";
            this.lb_Division.Size = new System.Drawing.Size(178, 113);
            this.lb_Division.TabIndex = 30;
            this.lb_Division.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.btnDeleteSmallImage);
            this.panelOptions.Controls.Add(this.btnDeleteBigImage);
            this.panelOptions.Controls.Add(this.btnAddCarPhoto);
            this.panelOptions.Controls.Add(this.btnAddBigImage);
            this.panelOptions.Controls.Add(this.btnAddCar);
            this.panelOptions.Controls.Add(pictureBox6);
            this.panelOptions.Controls.Add(this.btnDeleteAccount);
            this.panelOptions.Controls.Add(this.btnResetMyStats);
            this.panelOptions.Controls.Add(label13);
            this.panelOptions.Controls.Add(this.btnExit);
            this.panelOptions.Controls.Add(this.btnEditCarStats);
            this.panelOptions.Controls.Add(this.btnLogOut);
            this.panelOptions.Controls.Add(this.btnReturnToMainMenu);
            this.panelOptions.Location = new System.Drawing.Point(974, 161);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(420, 500);
            this.panelOptions.TabIndex = 31;
            this.panelOptions.Visible = false;
            // 
            // btnDeleteSmallImage
            // 
            this.btnDeleteSmallImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSmallImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteSmallImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteSmallImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSmallImage.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSmallImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSmallImage.Location = new System.Drawing.Point(0, 193);
            this.btnDeleteSmallImage.Name = "btnDeleteSmallImage";
            this.btnDeleteSmallImage.Size = new System.Drawing.Size(418, 23);
            this.btnDeleteSmallImage.TabIndex = 9;
            this.btnDeleteSmallImage.Text = "DELETE SMALL ICON FOR THIS CAR";
            this.btnDeleteSmallImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSmallImage.UseVisualStyleBackColor = false;
            this.btnDeleteSmallImage.Click += new System.EventHandler(this.btnDeleteSmallImage_Click);
            this.btnDeleteSmallImage.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnDeleteSmallImage.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnDeleteBigImage
            // 
            this.btnDeleteBigImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBigImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteBigImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteBigImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBigImage.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBigImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBigImage.Location = new System.Drawing.Point(0, 164);
            this.btnDeleteBigImage.Name = "btnDeleteBigImage";
            this.btnDeleteBigImage.Size = new System.Drawing.Size(418, 23);
            this.btnDeleteBigImage.TabIndex = 8;
            this.btnDeleteBigImage.Text = "DELETE BIG MODEL FOR THIS CAR";
            this.btnDeleteBigImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBigImage.UseVisualStyleBackColor = false;
            this.btnDeleteBigImage.Click += new System.EventHandler(this.btnDeleteBigImage_Click);
            this.btnDeleteBigImage.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnDeleteBigImage.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnAddCarPhoto
            // 
            this.btnAddCarPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCarPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddCarPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddCarPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarPhoto.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddCarPhoto.Location = new System.Drawing.Point(0, 193);
            this.btnAddCarPhoto.Name = "btnAddCarPhoto";
            this.btnAddCarPhoto.Size = new System.Drawing.Size(418, 23);
            this.btnAddCarPhoto.TabIndex = 7;
            this.btnAddCarPhoto.Text = "ADD SMALL ICON FOR THIS CAR";
            this.btnAddCarPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCarPhoto.UseVisualStyleBackColor = false;
            this.btnAddCarPhoto.Click += new System.EventHandler(this.btnAddCarPhoto_Click);
            this.btnAddCarPhoto.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnAddCarPhoto.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnAddBigImage
            // 
            this.btnAddBigImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBigImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddBigImage.FlatAppearance.BorderSize = 0;
            this.btnAddBigImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBigImage.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBigImage.ForeColor = System.Drawing.Color.White;
            this.btnAddBigImage.Location = new System.Drawing.Point(0, 164);
            this.btnAddBigImage.Name = "btnAddBigImage";
            this.btnAddBigImage.Size = new System.Drawing.Size(418, 23);
            this.btnAddBigImage.TabIndex = 6;
            this.btnAddBigImage.Text = "ADD BIG MODEL FOR THIS CAR";
            this.btnAddBigImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBigImage.UseVisualStyleBackColor = false;
            this.btnAddBigImage.Click += new System.EventHandler(this.btnAddBigImage_Click);
            this.btnAddBigImage.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnAddBigImage.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.Location = new System.Drawing.Point(0, 135);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(418, 23);
            this.btnAddCar.TabIndex = 5;
            this.btnAddCar.Text = "ADD NEW CAR";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            this.btnAddCar.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnAddCar.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(0, 373);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(418, 23);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "DELETE ACCOUNT";
            this.btnDeleteAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            this.btnDeleteAccount.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnDeleteAccount.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnResetMyStats
            // 
            this.btnResetMyStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetMyStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnResetMyStats.FlatAppearance.BorderSize = 0;
            this.btnResetMyStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMyStats.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetMyStats.ForeColor = System.Drawing.Color.White;
            this.btnResetMyStats.Location = new System.Drawing.Point(0, 77);
            this.btnResetMyStats.Name = "btnResetMyStats";
            this.btnResetMyStats.Size = new System.Drawing.Size(418, 23);
            this.btnResetMyStats.TabIndex = 1;
            this.btnResetMyStats.Text = "RESET MY STATS";
            this.btnResetMyStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetMyStats.UseVisualStyleBackColor = false;
            this.btnResetMyStats.Click += new System.EventHandler(this.btnResetMyStats_Click);
            this.btnResetMyStats.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnResetMyStats.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(418, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnEditCarStats
            // 
            this.btnEditCarStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCarStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditCarStats.FlatAppearance.BorderSize = 0;
            this.btnEditCarStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCarStats.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCarStats.ForeColor = System.Drawing.Color.White;
            this.btnEditCarStats.Location = new System.Drawing.Point(0, 106);
            this.btnEditCarStats.Name = "btnEditCarStats";
            this.btnEditCarStats.Size = new System.Drawing.Size(418, 23);
            this.btnEditCarStats.TabIndex = 1;
            this.btnEditCarStats.Text = "EDIT CAR STATS";
            this.btnEditCarStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCarStats.UseVisualStyleBackColor = false;
            this.btnEditCarStats.Click += new System.EventHandler(this.btnEditCarStats_Click);
            this.btnEditCarStats.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnEditCarStats.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 431);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(418, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReturnToMainMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(0, 402);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(418, 23);
            this.btnReturnToMainMenu.TabIndex = 1;
            this.btnReturnToMainMenu.Text = "RETURN TO MAIN MENU";
            this.btnReturnToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToMainMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            this.btnReturnToMainMenu.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnReturnToMainMenu.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // panelToMainMenu
            // 
            this.panelToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelToMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToMainMenu.Controls.Add(pictureBox5);
            this.panelToMainMenu.Controls.Add(this.btnReturnToMainMenuDenied);
            this.panelToMainMenu.Controls.Add(this.btnReturnToMainMenuAccepted);
            this.panelToMainMenu.Controls.Add(this.label3);
            this.panelToMainMenu.Location = new System.Drawing.Point(974, 161);
            this.panelToMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelToMainMenu.Name = "panelToMainMenu";
            this.panelToMainMenu.Size = new System.Drawing.Size(420, 500);
            this.panelToMainMenu.TabIndex = 32;
            this.panelToMainMenu.Visible = false;
            // 
            // btnReturnToMainMenuDenied
            // 
            this.btnReturnToMainMenuDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenuDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReturnToMainMenuDenied.FlatAppearance.BorderSize = 0;
            this.btnReturnToMainMenuDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMainMenuDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenuDenied.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMainMenuDenied.Location = new System.Drawing.Point(0, 164);
            this.btnReturnToMainMenuDenied.Name = "btnReturnToMainMenuDenied";
            this.btnReturnToMainMenuDenied.Size = new System.Drawing.Size(418, 23);
            this.btnReturnToMainMenuDenied.TabIndex = 1;
            this.btnReturnToMainMenuDenied.Text = "NO";
            this.btnReturnToMainMenuDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToMainMenuDenied.UseVisualStyleBackColor = false;
            this.btnReturnToMainMenuDenied.Click += new System.EventHandler(this.btnReturnToMainMenuDenied_Click);
            this.btnReturnToMainMenuDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnReturnToMainMenuDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnReturnToMainMenuAccepted
            // 
            this.btnReturnToMainMenuAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenuAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReturnToMainMenuAccepted.FlatAppearance.BorderSize = 0;
            this.btnReturnToMainMenuAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMainMenuAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenuAccepted.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMainMenuAccepted.Location = new System.Drawing.Point(0, 135);
            this.btnReturnToMainMenuAccepted.Name = "btnReturnToMainMenuAccepted";
            this.btnReturnToMainMenuAccepted.Size = new System.Drawing.Size(418, 23);
            this.btnReturnToMainMenuAccepted.TabIndex = 1;
            this.btnReturnToMainMenuAccepted.Text = "YES";
            this.btnReturnToMainMenuAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToMainMenuAccepted.UseVisualStyleBackColor = false;
            this.btnReturnToMainMenuAccepted.Click += new System.EventHandler(this.btnReturnToMainMenuAccepted_Click);
            this.btnReturnToMainMenuAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnReturnToMainMenuAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Forza Medium", 16F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 128);
            this.label3.TabIndex = 0;
            this.label3.Text = "      RETURN TO MAIN MENU?";
            // 
            // btnSaveNewStats
            // 
            this.btnSaveNewStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNewStats.FlatAppearance.BorderSize = 0;
            this.btnSaveNewStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewStats.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnSaveNewStats.ForeColor = System.Drawing.Color.White;
            this.btnSaveNewStats.Location = new System.Drawing.Point(606, 733);
            this.btnSaveNewStats.Name = "btnSaveNewStats";
            this.btnSaveNewStats.Size = new System.Drawing.Size(63, 23);
            this.btnSaveNewStats.TabIndex = 7;
            this.btnSaveNewStats.TabStop = false;
            this.btnSaveNewStats.Text = "Save";
            this.btnSaveNewStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNewStats.UseMnemonic = false;
            this.btnSaveNewStats.UseVisualStyleBackColor = true;
            this.btnSaveNewStats.Visible = false;
            this.btnSaveNewStats.Click += new System.EventHandler(this.btnSaveNewStats_Click);
            // 
            // panelSortAndFilter
            // 
            this.panelSortAndFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSortAndFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelSortAndFilter.Controls.Add(this.rbCountry);
            this.panelSortAndFilter.Controls.Add(this.cb_FilterCriterions);
            this.panelSortAndFilter.Controls.Add(this.rbPrice);
            this.panelSortAndFilter.Controls.Add(pictureBox4);
            this.panelSortAndFilter.Controls.Add(this.panelUnits);
            this.panelSortAndFilter.Controls.Add(label17);
            this.panelSortAndFilter.Controls.Add(this.txtMaxPower);
            this.panelSortAndFilter.Controls.Add(this.txtMinPower);
            this.panelSortAndFilter.Controls.Add(this.btnClearPowerBorders);
            this.panelSortAndFilter.Controls.Add(this.btnCloseSortAndFilterPanel);
            this.panelSortAndFilter.Controls.Add(this.numMaxPower);
            this.panelSortAndFilter.Controls.Add(this.numMinPower);
            this.panelSortAndFilter.Controls.Add(label16);
            this.panelSortAndFilter.Controls.Add(label15);
            this.panelSortAndFilter.Controls.Add(this.btnApplyNewSortAndFilter);
            this.panelSortAndFilter.Controls.Add(this.rbYear);
            this.panelSortAndFilter.Controls.Add(this.rbClass);
            this.panelSortAndFilter.Controls.Add(this.rbManufacturer);
            this.panelSortAndFilter.Controls.Add(this.rbDivision);
            this.panelSortAndFilter.Controls.Add(label14);
            this.panelSortAndFilter.Controls.Add(label12);
            this.panelSortAndFilter.Controls.Add(label2);
            this.panelSortAndFilter.Location = new System.Drawing.Point(974, 161);
            this.panelSortAndFilter.Name = "panelSortAndFilter";
            this.panelSortAndFilter.Size = new System.Drawing.Size(420, 500);
            this.panelSortAndFilter.TabIndex = 33;
            // 
            // rbCountry
            // 
            this.rbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCountry.Font = new System.Drawing.Font("Forza Medium", 9.5F);
            this.rbCountry.ForeColor = System.Drawing.Color.White;
            this.rbCountry.Location = new System.Drawing.Point(283, 171);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(135, 24);
            this.rbCountry.TabIndex = 17;
            this.rbCountry.TabStop = true;
            this.rbCountry.Text = "COUNTRY";
            this.rbCountry.UseVisualStyleBackColor = false;
            this.rbCountry.CheckedChanged += new System.EventHandler(this.rbCountry_CheckedChanged);
            this.rbCountry.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbCountry.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // cb_FilterCriterions
            // 
            this.cb_FilterCriterions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_FilterCriterions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterCriterions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_FilterCriterions.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_FilterCriterions.FormattingEnabled = true;
            this.cb_FilterCriterions.Items.AddRange(new object[] {
            "POWER",
            "WEIGHT",
            "PERFORMANCE INDEX",
            "YEAR",
            "PRICE"});
            this.cb_FilterCriterions.Location = new System.Drawing.Point(93, 202);
            this.cb_FilterCriterions.Name = "cb_FilterCriterions";
            this.cb_FilterCriterions.Size = new System.Drawing.Size(307, 27);
            this.cb_FilterCriterions.TabIndex = 16;
            this.cb_FilterCriterions.SelectedIndexChanged += new System.EventHandler(this.cb_FilterCriterions_SelectedIndexChanged);
            this.cb_FilterCriterions.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // rbPrice
            // 
            this.rbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPrice.Font = new System.Drawing.Font("Forza Medium", 9.5F);
            this.rbPrice.ForeColor = System.Drawing.Color.White;
            this.rbPrice.Location = new System.Drawing.Point(142, 171);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(135, 24);
            this.rbPrice.TabIndex = 15;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "PRICE";
            this.rbPrice.UseVisualStyleBackColor = false;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
            this.rbPrice.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbPrice.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // panelUnits
            // 
            this.panelUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUnits.Controls.Add(this.btnSetUnitsSystemForThisUser);
            this.panelUnits.Controls.Add(this.btnSetDefaultUnitsSystemForUserCountry_forThisUser);
            this.panelUnits.Controls.Add(this.rbEnglishUnits);
            this.panelUnits.Controls.Add(this.rbMetricUnits);
            this.panelUnits.Location = new System.Drawing.Point(1, 349);
            this.panelUnits.Name = "panelUnits";
            this.panelUnits.Size = new System.Drawing.Size(421, 73);
            this.panelUnits.TabIndex = 13;
            // 
            // btnSetUnitsSystemForThisUser
            // 
            this.btnSetUnitsSystemForThisUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetUnitsSystemForThisUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSetUnitsSystemForThisUser.FlatAppearance.BorderSize = 0;
            this.btnSetUnitsSystemForThisUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUnitsSystemForThisUser.Font = new System.Drawing.Font("Forza Medium", 9F);
            this.btnSetUnitsSystemForThisUser.ForeColor = System.Drawing.Color.White;
            this.btnSetUnitsSystemForThisUser.Location = new System.Drawing.Point(0, 30);
            this.btnSetUnitsSystemForThisUser.Name = "btnSetUnitsSystemForThisUser";
            this.btnSetUnitsSystemForThisUser.Size = new System.Drawing.Size(207, 40);
            this.btnSetUnitsSystemForThisUser.TabIndex = 14;
            this.btnSetUnitsSystemForThisUser.Text = "SET CURRENT UNITS SYSTEM AS DEFAULT FOR THIS USER";
            this.btnSetUnitsSystemForThisUser.UseVisualStyleBackColor = false;
            this.btnSetUnitsSystemForThisUser.Click += new System.EventHandler(this.btnSetUnitsSystemForThisUser_Click);
            this.btnSetUnitsSystemForThisUser.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnSetUnitsSystemForThisUser.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnSetDefaultUnitsSystemForUserCountry_forThisUser
            // 
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.FlatAppearance.BorderSize = 0;
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Font = new System.Drawing.Font("Forza Medium", 9F);
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.ForeColor = System.Drawing.Color.White;
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Location = new System.Drawing.Point(210, 30);
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Name = "btnSetDefaultUnitsSystemForUserCountry_forThisUser";
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Size = new System.Drawing.Size(207, 40);
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.TabIndex = 13;
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Text = "RETURN TO STANDARD UNITS FOR USER\'S COUNTRY";
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.UseVisualStyleBackColor = false;
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.Click += new System.EventHandler(this.btnSetDefaultUnitsSystemForUserCountry_forThisUser_Click);
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnSetDefaultUnitsSystemForUserCountry_forThisUser.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // rbEnglishUnits
            // 
            this.rbEnglishUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbEnglishUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEnglishUnits.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEnglishUnits.ForeColor = System.Drawing.Color.White;
            this.rbEnglishUnits.Location = new System.Drawing.Point(163, 0);
            this.rbEnglishUnits.Name = "rbEnglishUnits";
            this.rbEnglishUnits.Size = new System.Drawing.Size(153, 24);
            this.rbEnglishUnits.TabIndex = 12;
            this.rbEnglishUnits.TabStop = true;
            this.rbEnglishUnits.Text = "ENGLISH";
            this.rbEnglishUnits.UseVisualStyleBackColor = false;
            this.rbEnglishUnits.CheckedChanged += new System.EventHandler(this.rbEnglishUnits_CheckedChanged);
            this.rbEnglishUnits.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbEnglishUnits.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // rbMetricUnits
            // 
            this.rbMetricUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbMetricUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMetricUnits.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMetricUnits.ForeColor = System.Drawing.Color.White;
            this.rbMetricUnits.Location = new System.Drawing.Point(4, 0);
            this.rbMetricUnits.Name = "rbMetricUnits";
            this.rbMetricUnits.Size = new System.Drawing.Size(153, 24);
            this.rbMetricUnits.TabIndex = 11;
            this.rbMetricUnits.TabStop = true;
            this.rbMetricUnits.Text = "METRIC";
            this.rbMetricUnits.UseVisualStyleBackColor = false;
            this.rbMetricUnits.CheckedChanged += new System.EventHandler(this.rbMetricUnits_CheckedChanged);
            this.rbMetricUnits.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbMetricUnits.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMaxPower.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMaxPower.ForeColor = System.Drawing.Color.White;
            this.txtMaxPower.Location = new System.Drawing.Point(107, 265);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(293, 19);
            this.txtMaxPower.TabIndex = 9;
            // 
            // txtMinPower
            // 
            this.txtMinPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMinPower.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinPower.ForeColor = System.Drawing.Color.White;
            this.txtMinPower.Location = new System.Drawing.Point(107, 240);
            this.txtMinPower.Name = "txtMinPower";
            this.txtMinPower.Size = new System.Drawing.Size(293, 19);
            this.txtMinPower.TabIndex = 9;
            // 
            // btnClearPowerBorders
            // 
            this.btnClearPowerBorders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPowerBorders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClearPowerBorders.FlatAppearance.BorderSize = 0;
            this.btnClearPowerBorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPowerBorders.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearPowerBorders.ForeColor = System.Drawing.Color.White;
            this.btnClearPowerBorders.Location = new System.Drawing.Point(1, 290);
            this.btnClearPowerBorders.Name = "btnClearPowerBorders";
            this.btnClearPowerBorders.Size = new System.Drawing.Size(417, 23);
            this.btnClearPowerBorders.TabIndex = 8;
            this.btnClearPowerBorders.Text = "CLEAR";
            this.btnClearPowerBorders.UseVisualStyleBackColor = false;
            this.btnClearPowerBorders.Click += new System.EventHandler(this.btnClearPowerBorders_Click);
            this.btnClearPowerBorders.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnClearPowerBorders.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnCloseSortAndFilterPanel
            // 
            this.btnCloseSortAndFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSortAndFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCloseSortAndFilterPanel.FlatAppearance.BorderSize = 0;
            this.btnCloseSortAndFilterPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSortAndFilterPanel.Font = new System.Drawing.Font("Forza Medium", 16F);
            this.btnCloseSortAndFilterPanel.ForeColor = System.Drawing.Color.White;
            this.btnCloseSortAndFilterPanel.Location = new System.Drawing.Point(1, 447);
            this.btnCloseSortAndFilterPanel.Name = "btnCloseSortAndFilterPanel";
            this.btnCloseSortAndFilterPanel.Size = new System.Drawing.Size(207, 40);
            this.btnCloseSortAndFilterPanel.TabIndex = 8;
            this.btnCloseSortAndFilterPanel.Text = "CLOSE";
            this.btnCloseSortAndFilterPanel.UseVisualStyleBackColor = false;
            this.btnCloseSortAndFilterPanel.Click += new System.EventHandler(this.btnCloseSortAndFilterPanel_Click);
            this.btnCloseSortAndFilterPanel.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnCloseSortAndFilterPanel.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // numMaxPower
            // 
            this.numMaxPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numMaxPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMaxPower.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMaxPower.ForeColor = System.Drawing.Color.White;
            this.numMaxPower.Location = new System.Drawing.Point(107, 265);
            this.numMaxPower.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numMaxPower.Name = "numMaxPower";
            this.numMaxPower.Size = new System.Drawing.Size(310, 19);
            this.numMaxPower.TabIndex = 7;
            this.numMaxPower.Value = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numMaxPower.ValueChanged += new System.EventHandler(this.numMaxPower_ValueChanged);
            // 
            // numMinPower
            // 
            this.numMinPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMinPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numMinPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMinPower.Font = new System.Drawing.Font("Forza Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMinPower.ForeColor = System.Drawing.Color.White;
            this.numMinPower.Location = new System.Drawing.Point(107, 240);
            this.numMinPower.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numMinPower.Name = "numMinPower";
            this.numMinPower.Size = new System.Drawing.Size(310, 19);
            this.numMinPower.TabIndex = 6;
            this.numMinPower.ValueChanged += new System.EventHandler(this.numMinPower_ValueChanged);
            // 
            // btnApplyNewSortAndFilter
            // 
            this.btnApplyNewSortAndFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyNewSortAndFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnApplyNewSortAndFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyNewSortAndFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyNewSortAndFilter.Font = new System.Drawing.Font("Forza Medium", 16F);
            this.btnApplyNewSortAndFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyNewSortAndFilter.Location = new System.Drawing.Point(212, 447);
            this.btnApplyNewSortAndFilter.Name = "btnApplyNewSortAndFilter";
            this.btnApplyNewSortAndFilter.Size = new System.Drawing.Size(207, 40);
            this.btnApplyNewSortAndFilter.TabIndex = 4;
            this.btnApplyNewSortAndFilter.Text = "APPLY";
            this.btnApplyNewSortAndFilter.UseVisualStyleBackColor = false;
            this.btnApplyNewSortAndFilter.Click += new System.EventHandler(this.btnApplyNewSortAndFilter_Click);
            this.btnApplyNewSortAndFilter.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnApplyNewSortAndFilter.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // rbYear
            // 
            this.rbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbYear.Font = new System.Drawing.Font("Forza Medium", 9.5F);
            this.rbYear.ForeColor = System.Drawing.Color.White;
            this.rbYear.Location = new System.Drawing.Point(3, 171);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(135, 24);
            this.rbYear.TabIndex = 3;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "YEAR";
            this.rbYear.UseVisualStyleBackColor = false;
            this.rbYear.CheckedChanged += new System.EventHandler(this.rbYear_CheckedChanged);
            this.rbYear.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbYear.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // rbClass
            // 
            this.rbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbClass.Font = new System.Drawing.Font("Forza Medium", 9.5F);
            this.rbClass.ForeColor = System.Drawing.Color.White;
            this.rbClass.Location = new System.Drawing.Point(283, 143);
            this.rbClass.Name = "rbClass";
            this.rbClass.Size = new System.Drawing.Size(135, 24);
            this.rbClass.TabIndex = 3;
            this.rbClass.TabStop = true;
            this.rbClass.Text = "CLASS";
            this.rbClass.UseVisualStyleBackColor = false;
            this.rbClass.CheckedChanged += new System.EventHandler(this.rbClass_CheckedChanged);
            this.rbClass.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbClass.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // rbManufacturer
            // 
            this.rbManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbManufacturer.Font = new System.Drawing.Font("Forza Medium", 9.5F);
            this.rbManufacturer.ForeColor = System.Drawing.Color.White;
            this.rbManufacturer.Location = new System.Drawing.Point(142, 143);
            this.rbManufacturer.Name = "rbManufacturer";
            this.rbManufacturer.Size = new System.Drawing.Size(135, 24);
            this.rbManufacturer.TabIndex = 3;
            this.rbManufacturer.TabStop = true;
            this.rbManufacturer.Text = "MANUFACTURER";
            this.rbManufacturer.UseVisualStyleBackColor = false;
            this.rbManufacturer.CheckedChanged += new System.EventHandler(this.rbManufacturer_CheckedChanged);
            this.rbManufacturer.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbManufacturer.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // rbDivision
            // 
            this.rbDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDivision.Font = new System.Drawing.Font("Forza Medium", 9.5F);
            this.rbDivision.ForeColor = System.Drawing.Color.White;
            this.rbDivision.Location = new System.Drawing.Point(3, 143);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(135, 24);
            this.rbDivision.TabIndex = 3;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "DIVISION";
            this.rbDivision.UseVisualStyleBackColor = false;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.rbDivision_CheckedChanged);
            this.rbDivision.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.rbDivision.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // btnSortAndFilter
            // 
            this.btnSortAndFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortAndFilter.FlatAppearance.BorderSize = 0;
            this.btnSortAndFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAndFilter.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnSortAndFilter.ForeColor = System.Drawing.Color.White;
            this.btnSortAndFilter.Location = new System.Drawing.Point(1296, 733);
            this.btnSortAndFilter.Name = "btnSortAndFilter";
            this.btnSortAndFilter.Size = new System.Drawing.Size(86, 23);
            this.btnSortAndFilter.TabIndex = 7;
            this.btnSortAndFilter.TabStop = false;
            this.btnSortAndFilter.Text = "Sort/Filter";
            this.btnSortAndFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortAndFilter.UseVisualStyleBackColor = true;
            this.btnSortAndFilter.Click += new System.EventHandler(this.btnSortAndFilter_Click);
            // 
            // panelDeleteAccount
            // 
            this.panelDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelDeleteAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeleteAccount.Controls.Add(pictureBox3);
            this.panelDeleteAccount.Controls.Add(this.label18);
            this.panelDeleteAccount.Controls.Add(this.btnDeletingDenied);
            this.panelDeleteAccount.Controls.Add(this.btnDeletingAccepted);
            this.panelDeleteAccount.Controls.Add(this.lblDelete_H);
            this.panelDeleteAccount.Location = new System.Drawing.Point(974, 161);
            this.panelDeleteAccount.Margin = new System.Windows.Forms.Padding(0);
            this.panelDeleteAccount.Name = "panelDeleteAccount";
            this.panelDeleteAccount.Size = new System.Drawing.Size(420, 500);
            this.panelDeleteAccount.TabIndex = 36;
            this.panelDeleteAccount.Visible = false;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(418, 50);
            this.label18.TabIndex = 3;
            this.label18.Text = "Are you sure you want to delete your account?";
            // 
            // btnDeletingDenied
            // 
            this.btnDeletingDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletingDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeletingDenied.FlatAppearance.BorderSize = 0;
            this.btnDeletingDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletingDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletingDenied.ForeColor = System.Drawing.Color.White;
            this.btnDeletingDenied.Location = new System.Drawing.Point(0, 164);
            this.btnDeletingDenied.Name = "btnDeletingDenied";
            this.btnDeletingDenied.Size = new System.Drawing.Size(418, 23);
            this.btnDeletingDenied.TabIndex = 1;
            this.btnDeletingDenied.Text = "NO";
            this.btnDeletingDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletingDenied.UseVisualStyleBackColor = false;
            this.btnDeletingDenied.Click += new System.EventHandler(this.btnDeletingDenied_Click);
            this.btnDeletingDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnDeletingDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnDeletingAccepted
            // 
            this.btnDeletingAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletingAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeletingAccepted.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnDeletingAccepted.FlatAppearance.BorderSize = 0;
            this.btnDeletingAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletingAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletingAccepted.ForeColor = System.Drawing.Color.White;
            this.btnDeletingAccepted.Location = new System.Drawing.Point(0, 135);
            this.btnDeletingAccepted.Name = "btnDeletingAccepted";
            this.btnDeletingAccepted.Size = new System.Drawing.Size(418, 23);
            this.btnDeletingAccepted.TabIndex = 1;
            this.btnDeletingAccepted.Text = "YES";
            this.btnDeletingAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletingAccepted.UseVisualStyleBackColor = false;
            this.btnDeletingAccepted.Click += new System.EventHandler(this.btnDeletingAccepted_Click);
            this.btnDeletingAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnDeletingAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // lblDelete_H
            // 
            this.lblDelete_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDelete_H.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDelete_H.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete_H.Location = new System.Drawing.Point(0, 0);
            this.lblDelete_H.Name = "lblDelete_H";
            this.lblDelete_H.Size = new System.Drawing.Size(418, 128);
            this.lblDelete_H.TabIndex = 0;
            this.lblDelete_H.Text = "      DELETE ACCOUNT?";
            // 
            // cb_CarManufacturer
            // 
            this.cb_CarManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cb_CarManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CarManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_CarManufacturer.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.cb_CarManufacturer.ForeColor = System.Drawing.Color.White;
            this.cb_CarManufacturer.FormattingEnabled = true;
            this.cb_CarManufacturer.IntegralHeight = false;
            this.cb_CarManufacturer.Location = new System.Drawing.Point(533, 189);
            this.cb_CarManufacturer.Name = "cb_CarManufacturer";
            this.cb_CarManufacturer.Size = new System.Drawing.Size(432, 37);
            this.cb_CarManufacturer.TabIndex = 37;
            this.cb_CarManufacturer.Visible = false;
            this.cb_CarManufacturer.SelectedIndexChanged += new System.EventHandler(this.cb_CarManufacturer_SelectedIndexChanged);
            this.cb_CarManufacturer.Validating += new System.ComponentModel.CancelEventHandler(this.cb_CarManufacturer_Validating);
            // 
            // panelPowerLimitsViolation
            // 
            this.panelPowerLimitsViolation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPowerLimitsViolation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelPowerLimitsViolation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPowerLimitsViolation.Controls.Add(pictureBox2);
            this.panelPowerLimitsViolation.Controls.Add(this.label19);
            this.panelPowerLimitsViolation.Controls.Add(this.btnPowerLimitsViolationOK);
            this.panelPowerLimitsViolation.Controls.Add(label20);
            this.panelPowerLimitsViolation.Location = new System.Drawing.Point(974, 161);
            this.panelPowerLimitsViolation.Margin = new System.Windows.Forms.Padding(0);
            this.panelPowerLimitsViolation.Name = "panelPowerLimitsViolation";
            this.panelPowerLimitsViolation.Size = new System.Drawing.Size(420, 500);
            this.panelPowerLimitsViolation.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(418, 50);
            this.label19.TabIndex = 2;
            this.label19.Text = "Car does not meet the selected limits.";
            // 
            // btnPowerLimitsViolationOK
            // 
            this.btnPowerLimitsViolationOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowerLimitsViolationOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPowerLimitsViolationOK.FlatAppearance.BorderSize = 0;
            this.btnPowerLimitsViolationOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerLimitsViolationOK.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerLimitsViolationOK.ForeColor = System.Drawing.Color.White;
            this.btnPowerLimitsViolationOK.Location = new System.Drawing.Point(0, 130);
            this.btnPowerLimitsViolationOK.Name = "btnPowerLimitsViolationOK";
            this.btnPowerLimitsViolationOK.Size = new System.Drawing.Size(418, 23);
            this.btnPowerLimitsViolationOK.TabIndex = 1;
            this.btnPowerLimitsViolationOK.Text = "OK";
            this.btnPowerLimitsViolationOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPowerLimitsViolationOK.UseVisualStyleBackColor = false;
            this.btnPowerLimitsViolationOK.Click += new System.EventHandler(this.btnPowerLimitsViolationOK_Click);
            this.btnPowerLimitsViolationOK.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnPowerLimitsViolationOK.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnEditManufacturer
            // 
            this.btnEditManufacturer.FlatAppearance.BorderSize = 0;
            this.btnEditManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditManufacturer.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnEditManufacturer.ForeColor = System.Drawing.Color.White;
            this.btnEditManufacturer.Location = new System.Drawing.Point(755, 164);
            this.btnEditManufacturer.Name = "btnEditManufacturer";
            this.btnEditManufacturer.Size = new System.Drawing.Size(210, 23);
            this.btnEditManufacturer.TabIndex = 39;
            this.btnEditManufacturer.TabStop = false;
            this.btnEditManufacturer.Text = "Edit manufacturer";
            this.btnEditManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditManufacturer.UseMnemonic = false;
            this.btnEditManufacturer.UseVisualStyleBackColor = true;
            this.btnEditManufacturer.Visible = false;
            this.btnEditManufacturer.Click += new System.EventHandler(this.btnEditManufacturer_Click);
            // 
            // lb_CtrlPlus1
            // 
            this.lb_CtrlPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CtrlPlus1.Font = new System.Drawing.Font("Forza Book", 10F);
            this.lb_CtrlPlus1.ForeColor = System.Drawing.Color.White;
            this.lb_CtrlPlus1.Location = new System.Drawing.Point(560, 733);
            this.lb_CtrlPlus1.Name = "lb_CtrlPlus1";
            this.lb_CtrlPlus1.Size = new System.Drawing.Size(23, 23);
            this.lb_CtrlPlus1.TabIndex = 42;
            this.lb_CtrlPlus1.Text = "+";
            this.lb_CtrlPlus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_CtrlPlus1.Visible = false;
            // 
            // cb_Divisions
            // 
            this.cb_Divisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(171)))), ((int)(((byte)(175)))));
            this.cb_Divisions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Divisions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Divisions.FormattingEnabled = true;
            this.cb_Divisions.Location = new System.Drawing.Point(243, 601);
            this.cb_Divisions.Name = "cb_Divisions";
            this.cb_Divisions.Size = new System.Drawing.Size(184, 21);
            this.cb_Divisions.TabIndex = 45;
            this.cb_Divisions.Visible = false;
            this.cb_Divisions.SelectedIndexChanged += new System.EventHandler(this.cb_Divisions_SelectedIndexChanged);
            // 
            // cbIsFE
            // 
            this.cbIsFE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(200)))), ((int)(((byte)(234)))));
            this.cbIsFE.Font = new System.Drawing.Font("Forza Medium", 14F);
            this.cbIsFE.Location = new System.Drawing.Point(530, 615);
            this.cbIsFE.Name = "cbIsFE";
            this.cbIsFE.Size = new System.Drawing.Size(147, 30);
            this.cbIsFE.TabIndex = 46;
            this.cbIsFE.Text = "Is FE";
            this.cbIsFE.UseVisualStyleBackColor = false;
            this.cbIsFE.Visible = false;
            this.cbIsFE.CheckedChanged += new System.EventHandler(this.cbIsFE_CheckedChanged);
            // 
            // panelCarStats
            // 
            this.panelCarStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCarStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelCarStats.Controls.Add(this.btnAWD);
            this.panelCarStats.Controls.Add(this.btnRWD);
            this.panelCarStats.Controls.Add(this.btnFWD);
            this.panelCarStats.Controls.Add(this.pbREngine);
            this.panelCarStats.Controls.Add(this.pbMEngine);
            this.panelCarStats.Controls.Add(this.pbFEngine);
            this.panelCarStats.Controls.Add(this.lb_PI);
            this.panelCarStats.Controls.Add(this.numPerformanceIndex);
            this.panelCarStats.Controls.Add(this.lb_brake);
            this.panelCarStats.Controls.Add(this.lb_acceleration);
            this.panelCarStats.Controls.Add(this.numAcceleration);
            this.panelCarStats.Controls.Add(this.lb_handling);
            this.panelCarStats.Controls.Add(this.numHandling);
            this.panelCarStats.Controls.Add(this.lb_speed);
            this.panelCarStats.Controls.Add(this.numSpeed);
            this.panelCarStats.Controls.Add(this.lb_CarClass);
            this.panelCarStats.Controls.Add(this.pb_brake);
            this.panelCarStats.Controls.Add(this.pb_acceleration);
            this.panelCarStats.Controls.Add(this.pb_handling);
            this.panelCarStats.Controls.Add(this.pb_speed);
            this.panelCarStats.Controls.Add(this.EngineAndDrivenWheels_scheme);
            this.panelCarStats.Controls.Add(this.manufacturerCountry);
            this.panelCarStats.Controls.Add(label9);
            this.panelCarStats.Controls.Add(lb_brake_h);
            this.panelCarStats.Controls.Add(lb_acceleration_h);
            this.panelCarStats.Controls.Add(lb_handling_h);
            this.panelCarStats.Controls.Add(lb_speed_h);
            this.panelCarStats.Controls.Add(this.numBrake);
            this.panelCarStats.Location = new System.Drawing.Point(449, 654);
            this.panelCarStats.Name = "panelCarStats";
            this.panelCarStats.Size = new System.Drawing.Size(945, 73);
            this.panelCarStats.TabIndex = 47;
            // 
            // btnAWD
            // 
            this.btnAWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAWD.FlatAppearance.BorderSize = 0;
            this.btnAWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAWD.ForeColor = System.Drawing.Color.White;
            this.btnAWD.Location = new System.Drawing.Point(845, 50);
            this.btnAWD.Name = "btnAWD";
            this.btnAWD.Size = new System.Drawing.Size(45, 19);
            this.btnAWD.TabIndex = 40;
            this.btnAWD.Text = "AWD";
            this.btnAWD.UseVisualStyleBackColor = false;
            this.btnAWD.Visible = false;
            this.btnAWD.Click += new System.EventHandler(this.btnAWD_Click);
            // 
            // btnRWD
            // 
            this.btnRWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRWD.FlatAppearance.BorderSize = 0;
            this.btnRWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRWD.ForeColor = System.Drawing.Color.White;
            this.btnRWD.Location = new System.Drawing.Point(845, 30);
            this.btnRWD.Name = "btnRWD";
            this.btnRWD.Size = new System.Drawing.Size(45, 19);
            this.btnRWD.TabIndex = 39;
            this.btnRWD.Text = "RWD";
            this.btnRWD.UseVisualStyleBackColor = false;
            this.btnRWD.Visible = false;
            this.btnRWD.Click += new System.EventHandler(this.btnRWD_Click);
            // 
            // btnFWD
            // 
            this.btnFWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFWD.FlatAppearance.BorderSize = 0;
            this.btnFWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFWD.ForeColor = System.Drawing.Color.White;
            this.btnFWD.Location = new System.Drawing.Point(845, 10);
            this.btnFWD.Name = "btnFWD";
            this.btnFWD.Size = new System.Drawing.Size(45, 19);
            this.btnFWD.TabIndex = 38;
            this.btnFWD.Text = "FWD";
            this.btnFWD.UseVisualStyleBackColor = false;
            this.btnFWD.Visible = false;
            this.btnFWD.Click += new System.EventHandler(this.btnFWD_Click);
            // 
            // pbREngine
            // 
            this.pbREngine.Image = global::WindowsFormsApp2.Properties.Resources.RearEngine;
            this.pbREngine.Location = new System.Drawing.Point(895, 50);
            this.pbREngine.Name = "pbREngine";
            this.pbREngine.Size = new System.Drawing.Size(39, 19);
            this.pbREngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbREngine.TabIndex = 37;
            this.pbREngine.TabStop = false;
            this.pbREngine.Visible = false;
            this.pbREngine.Click += new System.EventHandler(this.pbREngine_Click);
            // 
            // pbMEngine
            // 
            this.pbMEngine.Image = global::WindowsFormsApp2.Properties.Resources.MiddleEngine;
            this.pbMEngine.Location = new System.Drawing.Point(895, 30);
            this.pbMEngine.Name = "pbMEngine";
            this.pbMEngine.Size = new System.Drawing.Size(39, 19);
            this.pbMEngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMEngine.TabIndex = 36;
            this.pbMEngine.TabStop = false;
            this.pbMEngine.Visible = false;
            this.pbMEngine.Click += new System.EventHandler(this.pbMEngine_Click);
            // 
            // pbFEngine
            // 
            this.pbFEngine.Image = global::WindowsFormsApp2.Properties.Resources.FrontEngine;
            this.pbFEngine.Location = new System.Drawing.Point(895, 10);
            this.pbFEngine.Name = "pbFEngine";
            this.pbFEngine.Size = new System.Drawing.Size(39, 19);
            this.pbFEngine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFEngine.TabIndex = 35;
            this.pbFEngine.TabStop = false;
            this.pbFEngine.Visible = false;
            this.pbFEngine.Click += new System.EventHandler(this.pbFEngine_Click);
            // 
            // lb_PI
            // 
            this.lb_PI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_PI.Font = new System.Drawing.Font("Forza Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PI.Location = new System.Drawing.Point(668, 27);
            this.lb_PI.Name = "lb_PI";
            this.lb_PI.Size = new System.Drawing.Size(53, 23);
            this.lb_PI.TabIndex = 0;
            this.lb_PI.Text = "PI";
            this.lb_PI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPerformanceIndex
            // 
            this.numPerformanceIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numPerformanceIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPerformanceIndex.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numPerformanceIndex.Location = new System.Drawing.Point(668, 27);
            this.numPerformanceIndex.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPerformanceIndex.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPerformanceIndex.Name = "numPerformanceIndex";
            this.numPerformanceIndex.Size = new System.Drawing.Size(68, 23);
            this.numPerformanceIndex.TabIndex = 34;
            this.numPerformanceIndex.TabStop = false;
            this.numPerformanceIndex.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPerformanceIndex.Visible = false;
            this.numPerformanceIndex.ValueChanged += new System.EventHandler(this.numPerformaceIndex_ValueChanged);
            // 
            // lb_brake
            // 
            this.lb_brake.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_brake.ForeColor = System.Drawing.Color.White;
            this.lb_brake.Location = new System.Drawing.Point(487, 29);
            this.lb_brake.Name = "lb_brake";
            this.lb_brake.Size = new System.Drawing.Size(135, 19);
            this.lb_brake.TabIndex = 4;
            this.lb_brake.Text = "10.0";
            // 
            // lb_acceleration
            // 
            this.lb_acceleration.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_acceleration.ForeColor = System.Drawing.Color.White;
            this.lb_acceleration.Location = new System.Drawing.Point(328, 29);
            this.lb_acceleration.Name = "lb_acceleration";
            this.lb_acceleration.Size = new System.Drawing.Size(135, 19);
            this.lb_acceleration.TabIndex = 4;
            this.lb_acceleration.Text = "0";
            // 
            // numAcceleration
            // 
            this.numAcceleration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numAcceleration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAcceleration.DecimalPlaces = 1;
            this.numAcceleration.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numAcceleration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAcceleration.Location = new System.Drawing.Point(328, 29);
            this.numAcceleration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAcceleration.Name = "numAcceleration";
            this.numAcceleration.Size = new System.Drawing.Size(153, 23);
            this.numAcceleration.TabIndex = 32;
            this.numAcceleration.TabStop = false;
            this.numAcceleration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAcceleration.Visible = false;
            this.numAcceleration.ValueChanged += new System.EventHandler(this.numAcceleration_ValueChanged);
            // 
            // lb_handling
            // 
            this.lb_handling.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_handling.ForeColor = System.Drawing.Color.White;
            this.lb_handling.Location = new System.Drawing.Point(169, 29);
            this.lb_handling.Name = "lb_handling";
            this.lb_handling.Size = new System.Drawing.Size(135, 19);
            this.lb_handling.TabIndex = 4;
            this.lb_handling.Text = "0";
            // 
            // numHandling
            // 
            this.numHandling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numHandling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numHandling.DecimalPlaces = 1;
            this.numHandling.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numHandling.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHandling.Location = new System.Drawing.Point(169, 29);
            this.numHandling.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHandling.Name = "numHandling";
            this.numHandling.Size = new System.Drawing.Size(153, 23);
            this.numHandling.TabIndex = 31;
            this.numHandling.TabStop = false;
            this.numHandling.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHandling.Visible = false;
            this.numHandling.ValueChanged += new System.EventHandler(this.numHandling_ValueChanged);
            // 
            // lb_speed
            // 
            this.lb_speed.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_speed.ForeColor = System.Drawing.Color.White;
            this.lb_speed.Location = new System.Drawing.Point(10, 29);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(135, 19);
            this.lb_speed.TabIndex = 4;
            this.lb_speed.Text = "0";
            // 
            // numSpeed
            // 
            this.numSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSpeed.DecimalPlaces = 1;
            this.numSpeed.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSpeed.Location = new System.Drawing.Point(10, 29);
            this.numSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(153, 23);
            this.numSpeed.TabIndex = 30;
            this.numSpeed.TabStop = false;
            this.numSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeed.Visible = false;
            this.numSpeed.ValueChanged += new System.EventHandler(this.numSpeed_ValueChanged);
            // 
            // lb_CarClass
            // 
            this.lb_CarClass.Font = new System.Drawing.Font("Forza Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CarClass.ForeColor = System.Drawing.Color.White;
            this.lb_CarClass.Location = new System.Drawing.Point(641, 27);
            this.lb_CarClass.Name = "lb_CarClass";
            this.lb_CarClass.Size = new System.Drawing.Size(32, 23);
            this.lb_CarClass.TabIndex = 0;
            this.lb_CarClass.Text = "Class";
            this.lb_CarClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_brake
            // 
            this.pb_brake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_brake.BarOffset = 0;
            this.pb_brake.Caption = "";
            this.pb_brake.CaptionColor = System.Drawing.Color.Black;
            this.pb_brake.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_brake.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_brake.ChangeByMouse = false;
            this.pb_brake.DashSpace = 0;
            this.pb_brake.DashWidth = 0;
            this.pb_brake.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rectangle;
            this.pb_brake.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_brake.EdgeLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_brake.EdgeWidth = 0;
            this.pb_brake.FloodPercentage = 0F;
            this.pb_brake.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_brake.Invert = false;
            this.pb_brake.Location = new System.Drawing.Point(490, 52);
            this.pb_brake.MainColor = System.Drawing.Color.White;
            this.pb_brake.Maximum = 100;
            this.pb_brake.Minimum = 0;
            this.pb_brake.Name = "pb_brake";
            this.pb_brake.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_brake.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_brake.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_brake.SecondColor = System.Drawing.Color.White;
            this.pb_brake.Shadow = true;
            this.pb_brake.ShadowOffset = 0;
            this.pb_brake.Size = new System.Drawing.Size(140, 5);
            this.pb_brake.Step = 0;
            this.pb_brake.TabIndex = 29;
            this.pb_brake.TabStop = false;
            this.pb_brake.TextAntialias = true;
            this.pb_brake.Value = 10;
            // 
            // pb_acceleration
            // 
            this.pb_acceleration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_acceleration.BarOffset = 0;
            this.pb_acceleration.Caption = "";
            this.pb_acceleration.CaptionColor = System.Drawing.Color.Black;
            this.pb_acceleration.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_acceleration.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_acceleration.ChangeByMouse = false;
            this.pb_acceleration.DashSpace = 0;
            this.pb_acceleration.DashWidth = 0;
            this.pb_acceleration.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rectangle;
            this.pb_acceleration.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_acceleration.EdgeLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_acceleration.EdgeWidth = 0;
            this.pb_acceleration.FloodPercentage = 0F;
            this.pb_acceleration.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_acceleration.Invert = false;
            this.pb_acceleration.Location = new System.Drawing.Point(331, 52);
            this.pb_acceleration.MainColor = System.Drawing.Color.White;
            this.pb_acceleration.Maximum = 100;
            this.pb_acceleration.Minimum = 0;
            this.pb_acceleration.Name = "pb_acceleration";
            this.pb_acceleration.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_acceleration.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_acceleration.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_acceleration.SecondColor = System.Drawing.Color.White;
            this.pb_acceleration.Shadow = true;
            this.pb_acceleration.ShadowOffset = 0;
            this.pb_acceleration.Size = new System.Drawing.Size(140, 5);
            this.pb_acceleration.Step = 0;
            this.pb_acceleration.TabIndex = 29;
            this.pb_acceleration.TabStop = false;
            this.pb_acceleration.TextAntialias = true;
            this.pb_acceleration.Value = 10;
            // 
            // pb_handling
            // 
            this.pb_handling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_handling.BarOffset = 0;
            this.pb_handling.Caption = "";
            this.pb_handling.CaptionColor = System.Drawing.Color.Black;
            this.pb_handling.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_handling.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_handling.ChangeByMouse = false;
            this.pb_handling.DashSpace = 0;
            this.pb_handling.DashWidth = 0;
            this.pb_handling.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rectangle;
            this.pb_handling.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_handling.EdgeLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_handling.EdgeWidth = 0;
            this.pb_handling.FloodPercentage = 0F;
            this.pb_handling.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_handling.Invert = false;
            this.pb_handling.Location = new System.Drawing.Point(172, 52);
            this.pb_handling.MainColor = System.Drawing.Color.White;
            this.pb_handling.Maximum = 100;
            this.pb_handling.Minimum = 0;
            this.pb_handling.Name = "pb_handling";
            this.pb_handling.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_handling.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_handling.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_handling.SecondColor = System.Drawing.Color.White;
            this.pb_handling.Shadow = true;
            this.pb_handling.ShadowOffset = 0;
            this.pb_handling.Size = new System.Drawing.Size(140, 5);
            this.pb_handling.Step = 0;
            this.pb_handling.TabIndex = 29;
            this.pb_handling.TabStop = false;
            this.pb_handling.TextAntialias = true;
            this.pb_handling.Value = 10;
            // 
            // pb_speed
            // 
            this.pb_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pb_speed.BarOffset = 0;
            this.pb_speed.Caption = "";
            this.pb_speed.CaptionColor = System.Drawing.Color.Black;
            this.pb_speed.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pb_speed.CaptionShadowColor = System.Drawing.Color.White;
            this.pb_speed.ChangeByMouse = false;
            this.pb_speed.DashSpace = 0;
            this.pb_speed.DashWidth = 0;
            this.pb_speed.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rectangle;
            this.pb_speed.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_speed.EdgeLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_speed.EdgeWidth = 0;
            this.pb_speed.FloodPercentage = 0F;
            this.pb_speed.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pb_speed.Invert = false;
            this.pb_speed.Location = new System.Drawing.Point(13, 52);
            this.pb_speed.MainColor = System.Drawing.Color.White;
            this.pb_speed.Maximum = 100;
            this.pb_speed.Minimum = 0;
            this.pb_speed.Name = "pb_speed";
            this.pb_speed.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.pb_speed.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.pb_speed.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pb_speed.SecondColor = System.Drawing.Color.White;
            this.pb_speed.Shadow = true;
            this.pb_speed.ShadowOffset = 0;
            this.pb_speed.Size = new System.Drawing.Size(140, 5);
            this.pb_speed.Step = 0;
            this.pb_speed.TabIndex = 29;
            this.pb_speed.TabStop = false;
            this.pb_speed.TextAntialias = true;
            this.pb_speed.Value = 10;
            // 
            // EngineAndDrivenWheels_scheme
            // 
            this.EngineAndDrivenWheels_scheme.Location = new System.Drawing.Point(743, 27);
            this.EngineAndDrivenWheels_scheme.Name = "EngineAndDrivenWheels_scheme";
            this.EngineAndDrivenWheels_scheme.Size = new System.Drawing.Size(49, 25);
            this.EngineAndDrivenWheels_scheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EngineAndDrivenWheels_scheme.TabIndex = 6;
            this.EngineAndDrivenWheels_scheme.TabStop = false;
            // 
            // manufacturerCountry
            // 
            this.manufacturerCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manufacturerCountry.Location = new System.Drawing.Point(801, 28);
            this.manufacturerCountry.Name = "manufacturerCountry";
            this.manufacturerCountry.Size = new System.Drawing.Size(36, 24);
            this.manufacturerCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manufacturerCountry.TabIndex = 6;
            this.manufacturerCountry.TabStop = false;
            // 
            // numBrake
            // 
            this.numBrake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.numBrake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBrake.DecimalPlaces = 1;
            this.numBrake.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.numBrake.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBrake.Location = new System.Drawing.Point(487, 29);
            this.numBrake.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBrake.Name = "numBrake";
            this.numBrake.Size = new System.Drawing.Size(153, 23);
            this.numBrake.TabIndex = 33;
            this.numBrake.TabStop = false;
            this.numBrake.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBrake.Visible = false;
            this.numBrake.ValueChanged += new System.EventHandler(this.numBrake_ValueChanged);
            // 
            // num_Year
            // 
            this.num_Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_Year.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.num_Year.ForeColor = System.Drawing.Color.White;
            this.num_Year.Location = new System.Drawing.Point(445, 191);
            this.num_Year.Maximum = new decimal(new int[] {
            2554,
            0,
            0,
            0});
            this.num_Year.Minimum = new decimal(new int[] {
            723,
            0,
            0,
            0});
            this.num_Year.Name = "num_Year";
            this.num_Year.ReadOnly = true;
            this.num_Year.Size = new System.Drawing.Size(78, 32);
            this.num_Year.TabIndex = 48;
            this.num_Year.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.num_Year.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.num_Year.Visible = false;
            this.num_Year.ValueChanged += new System.EventHandler(this.num_Year_ValueChanged);
            // 
            // btnAddManufacturer
            // 
            this.btnAddManufacturer.FlatAppearance.BorderSize = 0;
            this.btnAddManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManufacturer.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnAddManufacturer.ForeColor = System.Drawing.Color.White;
            this.btnAddManufacturer.Location = new System.Drawing.Point(533, 164);
            this.btnAddManufacturer.Name = "btnAddManufacturer";
            this.btnAddManufacturer.Size = new System.Drawing.Size(210, 23);
            this.btnAddManufacturer.TabIndex = 49;
            this.btnAddManufacturer.TabStop = false;
            this.btnAddManufacturer.Text = "Add manufacturer";
            this.btnAddManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManufacturer.UseMnemonic = false;
            this.btnAddManufacturer.UseVisualStyleBackColor = true;
            this.btnAddManufacturer.Visible = false;
            this.btnAddManufacturer.Click += new System.EventHandler(this.btnAddManufacturer_Click);
            // 
            // btnAddDivision
            // 
            this.btnAddDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDivision.FlatAppearance.BorderSize = 0;
            this.btnAddDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDivision.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnAddDivision.ForeColor = System.Drawing.Color.White;
            this.btnAddDivision.Location = new System.Drawing.Point(240, 726);
            this.btnAddDivision.Name = "btnAddDivision";
            this.btnAddDivision.Size = new System.Drawing.Size(52, 23);
            this.btnAddDivision.TabIndex = 51;
            this.btnAddDivision.TabStop = false;
            this.btnAddDivision.Text = "Add";
            this.btnAddDivision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDivision.UseMnemonic = false;
            this.btnAddDivision.UseVisualStyleBackColor = true;
            this.btnAddDivision.Visible = false;
            this.btnAddDivision.Click += new System.EventHandler(this.btnAddDivision_Click);
            // 
            // btnEditDivision
            // 
            this.btnEditDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDivision.FlatAppearance.BorderSize = 0;
            this.btnEditDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDivision.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnEditDivision.ForeColor = System.Drawing.Color.White;
            this.btnEditDivision.Location = new System.Drawing.Point(384, 726);
            this.btnEditDivision.Name = "btnEditDivision";
            this.btnEditDivision.Size = new System.Drawing.Size(52, 23);
            this.btnEditDivision.TabIndex = 52;
            this.btnEditDivision.TabStop = false;
            this.btnEditDivision.Text = "Edit";
            this.btnEditDivision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDivision.UseMnemonic = false;
            this.btnEditDivision.UseVisualStyleBackColor = true;
            this.btnEditDivision.Visible = false;
            this.btnEditDivision.Click += new System.EventHandler(this.btnEditDivision_Click);
            // 
            // btnJumpToGroups
            // 
            this.btnJumpToGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJumpToGroups.FlatAppearance.BorderSize = 0;
            this.btnJumpToGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJumpToGroups.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnJumpToGroups.ForeColor = System.Drawing.Color.White;
            this.btnJumpToGroups.Location = new System.Drawing.Point(828, 733);
            this.btnJumpToGroups.Name = "btnJumpToGroups";
            this.btnJumpToGroups.Size = new System.Drawing.Size(172, 23);
            this.btnJumpToGroups.TabIndex = 53;
            this.btnJumpToGroups.TabStop = false;
            this.btnJumpToGroups.Text = "Jump to groups";
            this.btnJumpToGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJumpToGroups.UseMnemonic = false;
            this.btnJumpToGroups.UseVisualStyleBackColor = true;
            this.btnJumpToGroups.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pb_C
            // 
            this.pb_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_C.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_C.ForeColor = System.Drawing.Color.White;
            this.pb_C.Location = new System.Drawing.Point(1273, 733);
            this.pb_C.Name = "pb_C";
            this.pb_C.Size = new System.Drawing.Size(23, 23);
            this.pb_C.TabIndex = 55;
            this.pb_C.Text = "C";
            this.pb_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_B
            // 
            this.pb_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_B.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_B.ForeColor = System.Drawing.Color.White;
            this.pb_B.Location = new System.Drawing.Point(1199, 733);
            this.pb_B.Name = "pb_B";
            this.pb_B.Size = new System.Drawing.Size(23, 23);
            this.pb_B.TabIndex = 56;
            this.pb_B.Text = "B";
            this.pb_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_O
            // 
            this.pb_O.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_O.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_O.ForeColor = System.Drawing.Color.White;
            this.pb_O.Location = new System.Drawing.Point(1095, 733);
            this.pb_O.Name = "pb_O";
            this.pb_O.Size = new System.Drawing.Size(23, 23);
            this.pb_O.TabIndex = 57;
            this.pb_O.Text = "O";
            this.pb_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_R
            // 
            this.pb_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_R.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_R.ForeColor = System.Drawing.Color.White;
            this.pb_R.Location = new System.Drawing.Point(1003, 733);
            this.pb_R.Name = "pb_R";
            this.pb_R.Size = new System.Drawing.Size(23, 23);
            this.pb_R.TabIndex = 58;
            this.pb_R.Text = "R";
            this.pb_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_V
            // 
            this.pb_V.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_V.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_V.ForeColor = System.Drawing.Color.White;
            this.pb_V.Location = new System.Drawing.Point(805, 733);
            this.pb_V.Name = "pb_V";
            this.pb_V.Size = new System.Drawing.Size(23, 23);
            this.pb_V.TabIndex = 59;
            this.pb_V.Text = "V";
            this.pb_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_S
            // 
            this.pb_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_S.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_S.ForeColor = System.Drawing.Color.White;
            this.pb_S.Location = new System.Drawing.Point(583, 733);
            this.pb_S.Name = "pb_S";
            this.pb_S.Size = new System.Drawing.Size(23, 23);
            this.pb_S.TabIndex = 60;
            this.pb_S.Text = "S";
            this.pb_S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pb_S.Visible = false;
            // 
            // pb_Ctrl1
            // 
            this.pb_Ctrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Ctrl1.Font = new System.Drawing.Font("Forza Light", 12F);
            this.pb_Ctrl1.ForeColor = System.Drawing.Color.White;
            this.pb_Ctrl1.Location = new System.Drawing.Point(522, 733);
            this.pb_Ctrl1.Name = "pb_Ctrl1";
            this.pb_Ctrl1.Size = new System.Drawing.Size(38, 23);
            this.pb_Ctrl1.TabIndex = 61;
            this.pb_Ctrl1.Text = "Ctrl";
            this.pb_Ctrl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pb_Ctrl1.Visible = false;
            // 
            // ManufacturerLogo
            // 
            this.ManufacturerLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ManufacturerLogo.Location = new System.Drawing.Point(245, 163);
            this.ManufacturerLogo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ManufacturerLogo.Name = "ManufacturerLogo";
            this.ManufacturerLogo.Size = new System.Drawing.Size(179, 128);
            this.ManufacturerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ManufacturerLogo.TabIndex = 40;
            this.ManufacturerLogo.TabStop = false;
            // 
            // pb_Division
            // 
            this.pb_Division.Image = ((System.Drawing.Image)(resources.GetObject("pb_Division.Image")));
            this.pb_Division.Location = new System.Drawing.Point(240, 601);
            this.pb_Division.Name = "pb_Division";
            this.pb_Division.Size = new System.Drawing.Size(196, 122);
            this.pb_Division.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Division.TabIndex = 29;
            this.pb_Division.TabStop = false;
            // 
            // carNumberIs2MoreLocked
            // 
            this.carNumberIs2MoreLocked.Image = global::WindowsFormsApp2.Properties.Resources.IsLocked;
            this.carNumberIs2MoreLocked.Location = new System.Drawing.Point(198, 690);
            this.carNumberIs2MoreLocked.Name = "carNumberIs2MoreLocked";
            this.carNumberIs2MoreLocked.Size = new System.Drawing.Size(22, 22);
            this.carNumberIs2MoreLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carNumberIs2MoreLocked.TabIndex = 28;
            this.carNumberIs2MoreLocked.TabStop = false;
            this.carNumberIs2MoreLocked.Visible = false;
            // 
            // carNumberIs1MoreLocked
            // 
            this.carNumberIs1MoreLocked.Image = global::WindowsFormsApp2.Properties.Resources.IsLocked;
            this.carNumberIs1MoreLocked.Location = new System.Drawing.Point(198, 584);
            this.carNumberIs1MoreLocked.Name = "carNumberIs1MoreLocked";
            this.carNumberIs1MoreLocked.Size = new System.Drawing.Size(22, 22);
            this.carNumberIs1MoreLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carNumberIs1MoreLocked.TabIndex = 28;
            this.carNumberIs1MoreLocked.TabStop = false;
            this.carNumberIs1MoreLocked.Visible = false;
            // 
            // currentCarLocked
            // 
            this.currentCarLocked.Image = global::WindowsFormsApp2.Properties.Resources.IsLocked;
            this.currentCarLocked.Location = new System.Drawing.Point(198, 481);
            this.currentCarLocked.Name = "currentCarLocked";
            this.currentCarLocked.Size = new System.Drawing.Size(22, 22);
            this.currentCarLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentCarLocked.TabIndex = 28;
            this.currentCarLocked.TabStop = false;
            this.currentCarLocked.Visible = false;
            // 
            // carNumberIs1LessLocked
            // 
            this.carNumberIs1LessLocked.Image = global::WindowsFormsApp2.Properties.Resources.IsLocked;
            this.carNumberIs1LessLocked.Location = new System.Drawing.Point(198, 372);
            this.carNumberIs1LessLocked.Name = "carNumberIs1LessLocked";
            this.carNumberIs1LessLocked.Size = new System.Drawing.Size(22, 22);
            this.carNumberIs1LessLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carNumberIs1LessLocked.TabIndex = 28;
            this.carNumberIs1LessLocked.TabStop = false;
            this.carNumberIs1LessLocked.Visible = false;
            // 
            // carNumberIs2LessLocked
            // 
            this.carNumberIs2LessLocked.Image = global::WindowsFormsApp2.Properties.Resources.IsLocked;
            this.carNumberIs2LessLocked.Location = new System.Drawing.Point(198, 266);
            this.carNumberIs2LessLocked.Name = "carNumberIs2LessLocked";
            this.carNumberIs2LessLocked.Size = new System.Drawing.Size(22, 22);
            this.carNumberIs2LessLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carNumberIs2LessLocked.TabIndex = 28;
            this.carNumberIs2LessLocked.TabStop = false;
            this.carNumberIs2LessLocked.Visible = false;
            // 
            // carNumberIs2MoreTier
            // 
            this.carNumberIs2MoreTier.Location = new System.Drawing.Point(25, 616);
            this.carNumberIs2MoreTier.Name = "carNumberIs2MoreTier";
            this.carNumberIs2MoreTier.Size = new System.Drawing.Size(5, 100);
            this.carNumberIs2MoreTier.TabIndex = 27;
            this.carNumberIs2MoreTier.TabStop = false;
            // 
            // carNumberIs1MoreTier
            // 
            this.carNumberIs1MoreTier.Location = new System.Drawing.Point(25, 513);
            this.carNumberIs1MoreTier.Name = "carNumberIs1MoreTier";
            this.carNumberIs1MoreTier.Size = new System.Drawing.Size(5, 100);
            this.carNumberIs1MoreTier.TabIndex = 27;
            this.carNumberIs1MoreTier.TabStop = false;
            // 
            // currentCarTier
            // 
            this.currentCarTier.Location = new System.Drawing.Point(25, 407);
            this.currentCarTier.Name = "currentCarTier";
            this.currentCarTier.Size = new System.Drawing.Size(5, 100);
            this.currentCarTier.TabIndex = 27;
            this.currentCarTier.TabStop = false;
            // 
            // carNumberIs1LessTier
            // 
            this.carNumberIs1LessTier.Location = new System.Drawing.Point(25, 298);
            this.carNumberIs1LessTier.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.carNumberIs1LessTier.Name = "carNumberIs1LessTier";
            this.carNumberIs1LessTier.Size = new System.Drawing.Size(5, 100);
            this.carNumberIs1LessTier.TabIndex = 27;
            this.carNumberIs1LessTier.TabStop = false;
            // 
            // carNumberIs2LessTier
            // 
            this.carNumberIs2LessTier.Location = new System.Drawing.Point(25, 192);
            this.carNumberIs2LessTier.Name = "carNumberIs2LessTier";
            this.carNumberIs2LessTier.Size = new System.Drawing.Size(5, 100);
            this.carNumberIs2LessTier.TabIndex = 27;
            this.carNumberIs2LessTier.TabStop = false;
            // 
            // carNumberIs2LessFE
            // 
            this.carNumberIs2LessFE.Image = global::WindowsFormsApp2.Properties.Resources.FE;
            this.carNumberIs2LessFE.Location = new System.Drawing.Point(34, 268);
            this.carNumberIs2LessFE.Name = "carNumberIs2LessFE";
            this.carNumberIs2LessFE.Size = new System.Drawing.Size(20, 20);
            this.carNumberIs2LessFE.TabIndex = 26;
            this.carNumberIs2LessFE.TabStop = false;
            // 
            // carNumberIs2MoreFE
            // 
            this.carNumberIs2MoreFE.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs2MoreFE.Image")));
            this.carNumberIs2MoreFE.Location = new System.Drawing.Point(35, 692);
            this.carNumberIs2MoreFE.Name = "carNumberIs2MoreFE";
            this.carNumberIs2MoreFE.Size = new System.Drawing.Size(20, 20);
            this.carNumberIs2MoreFE.TabIndex = 26;
            this.carNumberIs2MoreFE.TabStop = false;
            // 
            // carNumberIs1MoreFE
            // 
            this.carNumberIs1MoreFE.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs1MoreFE.Image")));
            this.carNumberIs1MoreFE.Location = new System.Drawing.Point(34, 586);
            this.carNumberIs1MoreFE.Name = "carNumberIs1MoreFE";
            this.carNumberIs1MoreFE.Size = new System.Drawing.Size(20, 20);
            this.carNumberIs1MoreFE.TabIndex = 26;
            this.carNumberIs1MoreFE.TabStop = false;
            // 
            // currentCarFE_Large
            // 
            this.currentCarFE_Large.Image = ((System.Drawing.Image)(resources.GetObject("currentCarFE_Large.Image")));
            this.currentCarFE_Large.Location = new System.Drawing.Point(500, 615);
            this.currentCarFE_Large.Name = "currentCarFE_Large";
            this.currentCarFE_Large.Size = new System.Drawing.Size(30, 30);
            this.currentCarFE_Large.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentCarFE_Large.TabIndex = 26;
            this.currentCarFE_Large.TabStop = false;
            // 
            // currentCarFE
            // 
            this.currentCarFE.Image = ((System.Drawing.Image)(resources.GetObject("currentCarFE.Image")));
            this.currentCarFE.Location = new System.Drawing.Point(34, 483);
            this.currentCarFE.Name = "currentCarFE";
            this.currentCarFE.Size = new System.Drawing.Size(20, 20);
            this.currentCarFE.TabIndex = 26;
            this.currentCarFE.TabStop = false;
            // 
            // carNumberIs1LessFE
            // 
            this.carNumberIs1LessFE.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs1LessFE.Image")));
            this.carNumberIs1LessFE.Location = new System.Drawing.Point(34, 374);
            this.carNumberIs1LessFE.Name = "carNumberIs1LessFE";
            this.carNumberIs1LessFE.Size = new System.Drawing.Size(20, 20);
            this.carNumberIs1LessFE.TabIndex = 26;
            this.carNumberIs1LessFE.TabStop = false;
            // 
            // carIsBought
            // 
            this.carIsBought.Image = ((System.Drawing.Image)(resources.GetObject("carIsBought.Image")));
            this.carIsBought.Location = new System.Drawing.Point(459, 611);
            this.carIsBought.Name = "carIsBought";
            this.carIsBought.Size = new System.Drawing.Size(35, 35);
            this.carIsBought.TabIndex = 8;
            this.carIsBought.TabStop = false;
            this.carIsBought.Visible = false;
            // 
            // carNumberIs2Less
            // 
            this.carNumberIs2Less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.carNumberIs2Less.ForeColor = System.Drawing.Color.White;
            this.carNumberIs2Less.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs2Less.Image")));
            this.carNumberIs2Less.Location = new System.Drawing.Point(22, 189);
            this.carNumberIs2Less.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.carNumberIs2Less.Name = "carNumberIs2Less";
            this.carNumberIs2Less.Padding = new System.Windows.Forms.Padding(6);
            this.carNumberIs2Less.Size = new System.Drawing.Size(206, 106);
            this.carNumberIs2Less.TabIndex = 6;
            this.carNumberIs2Less.Click += new System.EventHandler(this.label14_Click);
            this.carNumberIs2Less.Paint += new System.Windows.Forms.PaintEventHandler(this.label14_Paint);
            // 
            // carNumberIs1More
            // 
            this.carNumberIs1More.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.carNumberIs1More.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.carNumberIs1More.ForeColor = System.Drawing.Color.White;
            this.carNumberIs1More.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs1More.Image")));
            this.carNumberIs1More.Location = new System.Drawing.Point(22, 510);
            this.carNumberIs1More.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.carNumberIs1More.Name = "carNumberIs1More";
            this.carNumberIs1More.Padding = new System.Windows.Forms.Padding(6);
            this.carNumberIs1More.Size = new System.Drawing.Size(206, 106);
            this.carNumberIs1More.TabIndex = 6;
            this.carNumberIs1More.Click += new System.EventHandler(this.label11_Click);
            this.carNumberIs1More.Paint += new System.Windows.Forms.PaintEventHandler(this.label11_Paint);
            // 
            // carNumberIs2More
            // 
            this.carNumberIs2More.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.carNumberIs2More.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.carNumberIs2More.ForeColor = System.Drawing.Color.White;
            this.carNumberIs2More.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs2More.Image")));
            this.carNumberIs2More.Location = new System.Drawing.Point(22, 613);
            this.carNumberIs2More.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.carNumberIs2More.Name = "carNumberIs2More";
            this.carNumberIs2More.Padding = new System.Windows.Forms.Padding(6);
            this.carNumberIs2More.Size = new System.Drawing.Size(206, 106);
            this.carNumberIs2More.TabIndex = 6;
            this.carNumberIs2More.Click += new System.EventHandler(this.label10_Click);
            this.carNumberIs2More.Paint += new System.Windows.Forms.PaintEventHandler(this.label10_Paint);
            // 
            // carNumberIs1Less
            // 
            this.carNumberIs1Less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.carNumberIs1Less.ForeColor = System.Drawing.Color.White;
            this.carNumberIs1Less.Image = ((System.Drawing.Image)(resources.GetObject("carNumberIs1Less.Image")));
            this.carNumberIs1Less.Location = new System.Drawing.Point(22, 295);
            this.carNumberIs1Less.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.carNumberIs1Less.Name = "carNumberIs1Less";
            this.carNumberIs1Less.Padding = new System.Windows.Forms.Padding(6);
            this.carNumberIs1Less.Size = new System.Drawing.Size(206, 106);
            this.carNumberIs1Less.TabIndex = 6;
            this.carNumberIs1Less.Click += new System.EventHandler(this.label13_Click);
            this.carNumberIs1Less.Paint += new System.Windows.Forms.PaintEventHandler(this.label13_Paint);
            // 
            // CarLocked
            // 
            this.CarLocked.Image = global::WindowsFormsApp2.Properties.Resources.IsLocked;
            this.CarLocked.Location = new System.Drawing.Point(1247, 611);
            this.CarLocked.Name = "CarLocked";
            this.CarLocked.Size = new System.Drawing.Size(35, 35);
            this.CarLocked.TabIndex = 17;
            this.CarLocked.TabStop = false;
            this.CarLocked.Visible = false;
            // 
            // currentCar
            // 
            this.currentCar.Image = global::WindowsFormsApp2.Properties.Resources.CarImage;
            this.currentCar.Location = new System.Drawing.Point(19, 401);
            this.currentCar.Name = "currentCar";
            this.currentCar.Size = new System.Drawing.Size(212, 112);
            this.currentCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.currentCar.TabIndex = 50;
            this.currentCar.TabStop = false;
            this.currentCar.Paint += new System.Windows.Forms.PaintEventHandler(this.currentCar_Paint);
            // 
            // pb_BigCarImage
            // 
            this.pb_BigCarImage.Location = new System.Drawing.Point(465, 165);
            this.pb_BigCarImage.Name = "pb_BigCarImage";
            this.pb_BigCarImage.Size = new System.Drawing.Size(816, 480);
            this.pb_BigCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BigCarImage.TabIndex = 25;
            this.pb_BigCarImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1394, 761);
            this.Controls.Add(this.pb_Ctrl1);
            this.Controls.Add(this.pb_S);
            this.Controls.Add(this.pb_V);
            this.Controls.Add(this.pb_R);
            this.Controls.Add(this.pb_O);
            this.Controls.Add(this.pb_B);
            this.Controls.Add(this.pb_C);
            this.Controls.Add(this.btnJumpToGroups);
            this.Controls.Add(this.btnEditDivision);
            this.Controls.Add(this.btnAddDivision);
            this.Controls.Add(this.btnAddManufacturer);
            this.Controls.Add(this.panelCarStats2);
            this.Controls.Add(this.cbIsFE);
            this.Controls.Add(this.cb_Divisions);
            this.Controls.Add(this.lb_CtrlPlus1);
            this.Controls.Add(this.ManufacturerLogo);
            this.Controls.Add(this.btnEditManufacturer);
            this.Controls.Add(this.panelPowerLimitsViolation);
            this.Controls.Add(this.cb_CarManufacturer);
            this.Controls.Add(this.panelDeleteAccount);
            this.Controls.Add(this.panelSortAndFilter);
            this.Controls.Add(this.panelToMainMenu);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.lb_Division);
            this.Controls.Add(this.pb_Division);
            this.Controls.Add(this.carNumberIs2MoreLocked);
            this.Controls.Add(this.carNumberIs1MoreLocked);
            this.Controls.Add(this.currentCarLocked);
            this.Controls.Add(this.carNumberIs1LessLocked);
            this.Controls.Add(this.carNumberIs2LessLocked);
            this.Controls.Add(this.carNumberIs2MoreTier);
            this.Controls.Add(this.carNumberIs1MoreTier);
            this.Controls.Add(this.currentCarTier);
            this.Controls.Add(this.carNumberIs1LessTier);
            this.Controls.Add(this.carNumberIs2LessTier);
            this.Controls.Add(this.carNumberIs2LessFE);
            this.Controls.Add(this.carNumberIs2MoreFE);
            this.Controls.Add(this.carNumberIs1MoreFE);
            this.Controls.Add(this.currentCarFE_Large);
            this.Controls.Add(this.currentCarFE);
            this.Controls.Add(this.carNumberIs1LessFE);
            this.Controls.Add(this.newCarShortTitle_h);
            this.Controls.Add(this.newCarShortTitle);
            this.Controls.Add(this.newCarModel);
            this.Controls.Add(this.carIsBought);
            this.Controls.Add(this.btnChangeUnits);
            this.Controls.Add(this.btnToggleStats);
            this.Controls.Add(this.btnSaveNewStats);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnSortAndFilter);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.carNumberIs2Less);
            this.Controls.Add(this.carNumberIs1More);
            this.Controls.Add(this.carNumberIs2More);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.lb_manufacturer);
            this.Controls.Add(this.lb_model);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.panelCollectorInfo);
            this.Controls.Add(this.carNumberIs1Less);
            this.Controls.Add(this.panel_newStatsSaving);
            this.Controls.Add(this.panel_LockedCar);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.panel_NotEnoughMoney);
            this.Controls.Add(this.panel_BuyCar);
            this.Controls.Add(this.panel_Quit);
            this.Controls.Add(this.CarLocked);
            this.Controls.Add(this.panelCarStats);
            this.Controls.Add(this.num_Year);
            this.Controls.Add(this.currentCar);
            this.Controls.Add(this.pb_BigCarImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Cars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox12)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panel_Quit.ResumeLayout(false);
            this.panel_BuyCar.ResumeLayout(false);
            this.panel_NotEnoughMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panelCollectorInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCollectorTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectorPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TierImage)).EndInit();
            this.panelReset.ResumeLayout(false);
            this.panel_LockedCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel_newStatsSaving.ResumeLayout(false);
            this.panelCarStats2.ResumeLayout(false);
            this.panelCarStats2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrontWeightPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelToMainMenu.ResumeLayout(false);
            this.panelSortAndFilter.ResumeLayout(false);
            this.panelUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPower)).EndInit();
            this.panelDeleteAccount.ResumeLayout(false);
            this.panelPowerLimitsViolation.ResumeLayout(false);
            this.panelCarStats.ResumeLayout(false);
            this.panelCarStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbREngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerformanceIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHandling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EngineAndDrivenWheels_scheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2MoreLocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1MoreLocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarLocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1LessLocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2LessLocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2MoreTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1MoreTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1LessTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2LessTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2LessFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs2MoreFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1MoreFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarFE_Large)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNumberIs1LessFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carIsBought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarLocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BigCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentGroup;
        private System.Windows.Forms.Label GroupNumberGreaterBy1;
        private System.Windows.Forms.Label GroupNumberGreaterBy2;
        private System.Windows.Forms.Label GroupNumberGreaterBy3;
        private System.Windows.Forms.Label GroupNumberGreaterBy4;
        private System.Windows.Forms.Label GroupNumberGreaterBy5;
        private System.Windows.Forms.Label GroupNumberGreaterBy6;
        private System.Windows.Forms.Button btnDecreaseGroupNumberBy7;
        private System.Windows.Forms.Button btnIncreaseGroupNumberBy7;
        private System.Windows.Forms.Label GroupNumberGreaterBy7;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_manufacturer;
        private System.Windows.Forms.Label lb_model;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label MyBudget;
        private System.Windows.Forms.Label carPrice;
        private System.Windows.Forms.Label carNumberIs2More;
        private System.Windows.Forms.Label carNumberIs1More;
        private System.Windows.Forms.Label carNumberIs1Less;
        private System.Windows.Forms.Label carNumberIs2Less;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox carIsBought;
        private System.Windows.Forms.Panel panel_Quit;
        private System.Windows.Forms.Label lb_ExitText;
        private System.Windows.Forms.Button btnExitDenied;
        private System.Windows.Forms.Button btnExitAccepted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_BuyCar;
        private System.Windows.Forms.Label lb_BuyCarQuestion;
        private System.Windows.Forms.Button BuyCarCancel;
        private System.Windows.Forms.Button BuyCarAccept;
        private System.Windows.Forms.Panel panel_NotEnoughMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NotEnoughMoneyOK;
        private System.Windows.Forms.Label carShortTitle;
        private System.Windows.Forms.Label BuyCarTitle;
        private System.Windows.Forms.Panel panelCollectorInfo;
        private System.Windows.Forms.PictureBox pb_TierImage;
        private System.Windows.Forms.Label lb_TierTitle;
        private System.Windows.Forms.Label lb_CollectionPoints;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetCancelled;
        private System.Windows.Forms.Button btnResetAccepted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CollectorScore;
        private System.Windows.Forms.Label totalCollectorScore;
        private CircularProgressBar.CircularProgressBar currentCollectorLevel;
        private System.Windows.Forms.Label CurrentTierUpperBorder;
        private System.Windows.Forms.Label CollectorTierProgress;
        private System.Windows.Forms.Panel panel_LockedCar;
        private System.Windows.Forms.Label necessaryTier;
        private System.Windows.Forms.Button LockedCarOK;
        private System.Windows.Forms.PictureBox CarLocked;
        private System.Windows.Forms.TextBox newCarModel;
        private System.Windows.Forms.TextBox newCarShortTitle;
        private System.Windows.Forms.Label newCarShortTitle_h;
        private System.Windows.Forms.Panel panel_newStatsSaving;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newStatsSaved;
        private System.Windows.Forms.Button newStatsSavingCancelled;
        private System.Windows.Forms.Button newStatsNotSaved;
        private System.Windows.Forms.Label carNewShortTitle;
        private System.Windows.Forms.Panel panelCarStats2;
        private System.Windows.Forms.Label lb_frontWeight;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.Label lb_torque;
        private System.Windows.Forms.Label lb_power;
        private System.Windows.Forms.Button btnToggleStats;
        private System.Windows.Forms.Button btnChangeUnits;
        private System.Windows.Forms.PictureBox pb_BigCarImage;
        private System.Windows.Forms.PictureBox carNumberIs2LessFE;
        private System.Windows.Forms.PictureBox carNumberIs1LessFE;
        private System.Windows.Forms.PictureBox currentCarFE;
        private System.Windows.Forms.PictureBox carNumberIs1MoreFE;
        private System.Windows.Forms.PictureBox carNumberIs2MoreFE;
        private System.Windows.Forms.PictureBox currentCarFE_Large;
        private System.Windows.Forms.PictureBox carNumberIs2LessTier;
        private System.Windows.Forms.PictureBox carNumberIs1LessTier;
        private System.Windows.Forms.PictureBox currentCarTier;
        private System.Windows.Forms.PictureBox carNumberIs1MoreTier;
        private System.Windows.Forms.PictureBox carNumberIs2MoreTier;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.PictureBox carNumberIs2LessLocked;
        private System.Windows.Forms.PictureBox carNumberIs1LessLocked;
        private System.Windows.Forms.PictureBox currentCarLocked;
        private System.Windows.Forms.PictureBox carNumberIs1MoreLocked;
        private System.Windows.Forms.PictureBox carNumberIs2MoreLocked;
        private System.Windows.Forms.PictureBox pb_Division;
        private System.Windows.Forms.Label lb_Division;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btnResetMyStats;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditCarStats;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Panel panelToMainMenu;
        private System.Windows.Forms.Button btnReturnToMainMenuDenied;
        private System.Windows.Forms.Button btnReturnToMainMenuAccepted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveNewStats;
        private System.Windows.Forms.Panel panelSortAndFilter;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbClass;
        private System.Windows.Forms.RadioButton rbManufacturer;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Button btnApplyNewSortAndFilter;
        private System.Windows.Forms.NumericUpDown numMinPower;
        private System.Windows.Forms.NumericUpDown numMaxPower;
        private System.Windows.Forms.Button btnCloseSortAndFilterPanel;
        private System.Windows.Forms.Button btnClearPowerBorders;
        private System.Windows.Forms.Label txtMinPower;
        private System.Windows.Forms.Label txtMaxPower;
        private System.Windows.Forms.RadioButton rbEnglishUnits;
        private System.Windows.Forms.RadioButton rbMetricUnits;
        private System.Windows.Forms.Button btnSortAndFilter;
        private System.Windows.Forms.Panel panelUnits;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Panel panelDeleteAccount;
        private System.Windows.Forms.Button btnDeletingDenied;
        private System.Windows.Forms.Button btnDeletingAccepted;
        private System.Windows.Forms.Label lblDelete_H;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_CarManufacturer;
        private System.Windows.Forms.Panel panelPowerLimitsViolation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPowerLimitsViolationOK;
        private System.Windows.Forms.Button btnEditManufacturer;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox ManufacturerLogo;
        private System.Windows.Forms.Label lb_CtrlPlus1;
        private System.Windows.Forms.ComboBox cb_Divisions;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.ComboBox cb_FilterCriterions;
        private System.Windows.Forms.NumericUpDown numPower;
        private System.Windows.Forms.NumericUpDown numTorque;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.NumericUpDown numFrontWeightPercentage;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.CheckBox cbIsFE;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.Panel panelCarStats;
        private System.Windows.Forms.Label lb_PI;
        private System.Windows.Forms.Label lb_CarClass;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_brake;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_acceleration;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_handling;
        private ExtendedDotNET.Controls.Progress.ProgressBar pb_speed;
        private System.Windows.Forms.PictureBox EngineAndDrivenWheels_scheme;
        private System.Windows.Forms.PictureBox manufacturerCountry;
        private System.Windows.Forms.Label lb_brake;
        private System.Windows.Forms.Label lb_acceleration;
        private System.Windows.Forms.Label lb_handling;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.NumericUpDown numHandling;
        private System.Windows.Forms.NumericUpDown numAcceleration;
        private System.Windows.Forms.NumericUpDown numBrake;
        private System.Windows.Forms.NumericUpDown numPerformanceIndex;
        private System.Windows.Forms.PictureBox pbREngine;
        private System.Windows.Forms.PictureBox pbMEngine;
        private System.Windows.Forms.PictureBox pbFEngine;
        private System.Windows.Forms.Button btnAWD;
        private System.Windows.Forms.Button btnRWD;
        private System.Windows.Forms.Button btnFWD;
        private System.Windows.Forms.OpenFileDialog smallCarImage;
        private System.Windows.Forms.NumericUpDown num_Year;
        private System.Windows.Forms.NumericUpDown numCollectorPoints;
        private System.Windows.Forms.Button btnAddManufacturer;
        private System.Windows.Forms.PictureBox currentCar;
        private System.Windows.Forms.Button btnAddCarPhoto;
        private System.Windows.Forms.Button btnAddBigImage;
        private System.Windows.Forms.Button btnSetUnitsSystemForThisUser;
        private System.Windows.Forms.Button btnSetDefaultUnitsSystemForUserCountry_forThisUser;
        private System.Windows.Forms.Button btnAddDivision;
        private System.Windows.Forms.Button btnEditDivision;
        private System.Windows.Forms.NumericUpDown numCollectorTier;
        private System.Windows.Forms.Button btnDeleteBigImage;
        private System.Windows.Forms.Button btnDeleteSmallImage;
        private System.Windows.Forms.Button btnJumpToGroups;
        private System.Windows.Forms.Label pb_C;
        private System.Windows.Forms.Label pb_B;
        private System.Windows.Forms.Label pb_O;
        private System.Windows.Forms.Label pb_R;
        private System.Windows.Forms.Label pb_V;
        private System.Windows.Forms.Label pb_S;
        private System.Windows.Forms.Label pb_Ctrl1;
        private System.Windows.Forms.Label SortingCriterion;
    }
}

