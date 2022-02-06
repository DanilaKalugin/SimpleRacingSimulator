namespace WindowsFormsApp2
{
    partial class ManufacturersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturersForm));
            System.Windows.Forms.PictureBox pictureBox2;
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentManufacturer = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy1 = new System.Windows.Forms.Label();
            this.btnIncreaseGroupNumberBy5 = new System.Windows.Forms.Button();
            this.GroupNumberGreaterBy2 = new System.Windows.Forms.Label();
            this.btnDecreaseGroupNumberBy5 = new System.Windows.Forms.Button();
            this.GroupNumberGreaterBy3 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy4 = new System.Windows.Forms.Label();
            this.GroupNumberGreaterBy5 = new System.Windows.Forms.Label();
            this.manufacturerNumberUpBy1 = new System.Windows.Forms.PictureBox();
            this.manufacturerCurrent = new System.Windows.Forms.PictureBox();
            this.manufacturerNumberLessBy1 = new System.Windows.Forms.PictureBox();
            this.lb_manufacturer = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_ManufacturerCountry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_ManufacturerCountry = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeSortingType = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveDialog = new System.Windows.Forms.Button();
            this.btnEditManufacturerStats = new System.Windows.Forms.Button();
            this.panelReturnToMainMenu = new System.Windows.Forms.Panel();
            this.btnReturnToMainMenuDenied = new System.Windows.Forms.Button();
            this.btnReturnToMainMenuAccepted = new System.Windows.Forms.Button();
            this.lb_Block_H = new System.Windows.Forms.Label();
            this.newManufacturerTitle = new System.Windows.Forms.TextBox();
            this.cb_ManufacturerCountries = new System.Windows.Forms.ComboBox();
            this.ManufacturerTitleErrorText = new System.Windows.Forms.Label();
            this.ManufacturerCountryErrorText = new System.Windows.Forms.Label();
            this.panelSaveNewStats = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.newManufacturerInfoSavingCancelled = new System.Windows.Forms.Button();
            this.newManufacturerInfoSavingDenied = new System.Windows.Forms.Button();
            this.newManufacturerInfoSavingAccepted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manufacturerImage = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ShortTitle = new System.Windows.Forms.TextBox();
            this.lbShortTitle = new System.Windows.Forms.Label();
            this.ManufacturerShortTitleErrorText = new System.Windows.Forms.Label();
            this.lb_carsCount_H = new System.Windows.Forms.Label();
            this.lbCarsCount = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerNumberUpBy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerNumberLessBy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ManufacturerCountry)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelReturnToMainMenu.SuspendLayout();
            this.panelSaveNewStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(24, 24);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(24, 24);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.currentManufacturer);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy1);
            this.panel4.Controls.Add(this.btnIncreaseGroupNumberBy5);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy2);
            this.panel4.Controls.Add(this.btnDecreaseGroupNumberBy5);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy3);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy4);
            this.panel4.Controls.Add(this.GroupNumberGreaterBy5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Forza Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 46);
            this.panel4.TabIndex = 6;
            // 
            // currentManufacturer
            // 
            this.currentManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentManufacturer.BackColor = System.Drawing.Color.Black;
            this.currentManufacturer.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.currentManufacturer.ForeColor = System.Drawing.Color.White;
            this.currentManufacturer.Location = new System.Drawing.Point(114, 13);
            this.currentManufacturer.Name = "currentManufacturer";
            this.currentManufacturer.Size = new System.Drawing.Size(130, 23);
            this.currentManufacturer.TabIndex = 0;
            this.currentManufacturer.Text = "1";
            this.currentManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentManufacturer.MouseEnter += new System.EventHandler(this.ManufacturersformMouseEnter);
            this.currentManufacturer.MouseLeave += new System.EventHandler(this.ManufacturersFormMouseLeave);
            // 
            // GroupNumberGreaterBy1
            // 
            this.GroupNumberGreaterBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy1.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy1.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy1.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy1.Location = new System.Drawing.Point(250, 13);
            this.GroupNumberGreaterBy1.Name = "GroupNumberGreaterBy1";
            this.GroupNumberGreaterBy1.Size = new System.Drawing.Size(130, 23);
            this.GroupNumberGreaterBy1.TabIndex = 0;
            this.GroupNumberGreaterBy1.Text = "2";
            this.GroupNumberGreaterBy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy1.Click += new System.EventHandler(this.GroupNumberGreaterBy1_Click);
            this.GroupNumberGreaterBy1.MouseEnter += new System.EventHandler(this.ManufacturersformMouseEnter);
            this.GroupNumberGreaterBy1.MouseLeave += new System.EventHandler(this.ManufacturersFormMouseLeave);
            // 
            // btnIncreaseGroupNumberBy5
            // 
            this.btnIncreaseGroupNumberBy5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseGroupNumberBy5.BackColor = System.Drawing.Color.Black;
            this.btnIncreaseGroupNumberBy5.FlatAppearance.BorderSize = 0;
            this.btnIncreaseGroupNumberBy5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseGroupNumberBy5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncreaseGroupNumberBy5.Location = new System.Drawing.Point(930, 13);
            this.btnIncreaseGroupNumberBy5.Name = "btnIncreaseGroupNumberBy5";
            this.btnIncreaseGroupNumberBy5.Size = new System.Drawing.Size(34, 23);
            this.btnIncreaseGroupNumberBy5.TabIndex = 1;
            this.btnIncreaseGroupNumberBy5.TabStop = false;
            this.btnIncreaseGroupNumberBy5.Text = "]";
            this.btnIncreaseGroupNumberBy5.UseVisualStyleBackColor = false;
            this.btnIncreaseGroupNumberBy5.Click += new System.EventHandler(this.btnIncreaseGroupNumberBy7_Click);
            // 
            // GroupNumberGreaterBy2
            // 
            this.GroupNumberGreaterBy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy2.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy2.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy2.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy2.Location = new System.Drawing.Point(386, 13);
            this.GroupNumberGreaterBy2.Name = "GroupNumberGreaterBy2";
            this.GroupNumberGreaterBy2.Size = new System.Drawing.Size(130, 23);
            this.GroupNumberGreaterBy2.TabIndex = 0;
            this.GroupNumberGreaterBy2.Text = "3";
            this.GroupNumberGreaterBy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy2.Click += new System.EventHandler(this.GroupNumberGreaterBy2_Click);
            this.GroupNumberGreaterBy2.MouseEnter += new System.EventHandler(this.ManufacturersformMouseEnter);
            this.GroupNumberGreaterBy2.MouseLeave += new System.EventHandler(this.ManufacturersFormMouseLeave);
            // 
            // btnDecreaseGroupNumberBy5
            // 
            this.btnDecreaseGroupNumberBy5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecreaseGroupNumberBy5.BackColor = System.Drawing.Color.Black;
            this.btnDecreaseGroupNumberBy5.FlatAppearance.BorderSize = 0;
            this.btnDecreaseGroupNumberBy5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseGroupNumberBy5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecreaseGroupNumberBy5.Location = new System.Drawing.Point(74, 13);
            this.btnDecreaseGroupNumberBy5.Name = "btnDecreaseGroupNumberBy5";
            this.btnDecreaseGroupNumberBy5.Size = new System.Drawing.Size(34, 23);
            this.btnDecreaseGroupNumberBy5.TabIndex = 1;
            this.btnDecreaseGroupNumberBy5.TabStop = false;
            this.btnDecreaseGroupNumberBy5.Text = "[";
            this.btnDecreaseGroupNumberBy5.UseVisualStyleBackColor = false;
            this.btnDecreaseGroupNumberBy5.Click += new System.EventHandler(this.btnDecreaseGroupNumberBy7_Click);
            // 
            // GroupNumberGreaterBy3
            // 
            this.GroupNumberGreaterBy3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy3.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy3.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy3.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy3.Location = new System.Drawing.Point(522, 13);
            this.GroupNumberGreaterBy3.Name = "GroupNumberGreaterBy3";
            this.GroupNumberGreaterBy3.Size = new System.Drawing.Size(130, 23);
            this.GroupNumberGreaterBy3.TabIndex = 0;
            this.GroupNumberGreaterBy3.Text = "4";
            this.GroupNumberGreaterBy3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy3.Click += new System.EventHandler(this.GroupNumberGreaterBy3_Click);
            this.GroupNumberGreaterBy3.MouseEnter += new System.EventHandler(this.ManufacturersformMouseEnter);
            this.GroupNumberGreaterBy3.MouseLeave += new System.EventHandler(this.ManufacturersFormMouseLeave);
            // 
            // GroupNumberGreaterBy4
            // 
            this.GroupNumberGreaterBy4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy4.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy4.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy4.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy4.Location = new System.Drawing.Point(658, 13);
            this.GroupNumberGreaterBy4.Name = "GroupNumberGreaterBy4";
            this.GroupNumberGreaterBy4.Size = new System.Drawing.Size(130, 23);
            this.GroupNumberGreaterBy4.TabIndex = 0;
            this.GroupNumberGreaterBy4.Text = "5";
            this.GroupNumberGreaterBy4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy4.Click += new System.EventHandler(this.GroupNumberGreaterBy4_Click);
            this.GroupNumberGreaterBy4.MouseEnter += new System.EventHandler(this.ManufacturersformMouseEnter);
            this.GroupNumberGreaterBy4.MouseLeave += new System.EventHandler(this.ManufacturersFormMouseLeave);
            // 
            // GroupNumberGreaterBy5
            // 
            this.GroupNumberGreaterBy5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupNumberGreaterBy5.BackColor = System.Drawing.Color.Black;
            this.GroupNumberGreaterBy5.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.GroupNumberGreaterBy5.ForeColor = System.Drawing.Color.White;
            this.GroupNumberGreaterBy5.Location = new System.Drawing.Point(794, 13);
            this.GroupNumberGreaterBy5.Name = "GroupNumberGreaterBy5";
            this.GroupNumberGreaterBy5.Size = new System.Drawing.Size(130, 23);
            this.GroupNumberGreaterBy5.TabIndex = 0;
            this.GroupNumberGreaterBy5.Text = "6";
            this.GroupNumberGreaterBy5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupNumberGreaterBy5.Click += new System.EventHandler(this.GroupNumberGreaterBy5_Click);
            this.GroupNumberGreaterBy5.MouseEnter += new System.EventHandler(this.ManufacturersformMouseEnter);
            this.GroupNumberGreaterBy5.MouseLeave += new System.EventHandler(this.ManufacturersFormMouseLeave);
            // 
            // manufacturerNumberUpBy1
            // 
            this.manufacturerNumberUpBy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.manufacturerNumberUpBy1.Location = new System.Drawing.Point(12, 270);
            this.manufacturerNumberUpBy1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.manufacturerNumberUpBy1.Name = "manufacturerNumberUpBy1";
            this.manufacturerNumberUpBy1.Size = new System.Drawing.Size(179, 128);
            this.manufacturerNumberUpBy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manufacturerNumberUpBy1.TabIndex = 14;
            this.manufacturerNumberUpBy1.TabStop = false;
            this.manufacturerNumberUpBy1.Click += new System.EventHandler(this.manufacturerNumberUpBy1_Click);
            this.manufacturerNumberUpBy1.MouseEnter += new System.EventHandler(this.manufacturerNumberUpBy1_MouseEnter);
            this.manufacturerNumberUpBy1.MouseLeave += new System.EventHandler(this.manufacturerNumberUpBy1_MouseLeave);
            // 
            // manufacturerCurrent
            // 
            this.manufacturerCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.manufacturerCurrent.Location = new System.Drawing.Point(12, 140);
            this.manufacturerCurrent.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.manufacturerCurrent.Name = "manufacturerCurrent";
            this.manufacturerCurrent.Size = new System.Drawing.Size(179, 128);
            this.manufacturerCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manufacturerCurrent.TabIndex = 15;
            this.manufacturerCurrent.TabStop = false;
            this.manufacturerCurrent.Paint += new System.Windows.Forms.PaintEventHandler(this.manufacturerCurrent_Paint);
            // 
            // manufacturerNumberLessBy1
            // 
            this.manufacturerNumberLessBy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.manufacturerNumberLessBy1.Location = new System.Drawing.Point(12, 10);
            this.manufacturerNumberLessBy1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.manufacturerNumberLessBy1.Name = "manufacturerNumberLessBy1";
            this.manufacturerNumberLessBy1.Size = new System.Drawing.Size(179, 128);
            this.manufacturerNumberLessBy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manufacturerNumberLessBy1.TabIndex = 16;
            this.manufacturerNumberLessBy1.TabStop = false;
            this.manufacturerNumberLessBy1.Click += new System.EventHandler(this.manufacturerNumberLessBy1_Click);
            this.manufacturerNumberLessBy1.MouseEnter += new System.EventHandler(this.manufacturerNumberLessBy1_MouseEnter);
            this.manufacturerNumberLessBy1.MouseLeave += new System.EventHandler(this.manufacturerNumberLessBy1_MouseLeave);
            // 
            // lb_manufacturer
            // 
            this.lb_manufacturer.AutoSize = true;
            this.lb_manufacturer.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_manufacturer.ForeColor = System.Drawing.Color.White;
            this.lb_manufacturer.Location = new System.Drawing.Point(394, 59);
            this.lb_manufacturer.Name = "lb_manufacturer";
            this.lb_manufacturer.Size = new System.Drawing.Size(236, 29);
            this.lb_manufacturer.TabIndex = 17;
            this.lb_manufacturer.Text = "ManufacturerName";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_year.ForeColor = System.Drawing.Color.White;
            this.lb_year.Location = new System.Drawing.Point(212, 59);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(176, 29);
            this.lb_year.TabIndex = 18;
            this.lb_year.Text = "Manufacturer:";
            // 
            // lb_ManufacturerCountry
            // 
            this.lb_ManufacturerCountry.AutoSize = true;
            this.lb_ManufacturerCountry.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_ManufacturerCountry.ForeColor = System.Drawing.Color.White;
            this.lb_ManufacturerCountry.Location = new System.Drawing.Point(436, 119);
            this.lb_ManufacturerCountry.Name = "lb_ManufacturerCountry";
            this.lb_ManufacturerCountry.Size = new System.Drawing.Size(259, 29);
            this.lb_ManufacturerCountry.TabIndex = 19;
            this.lb_ManufacturerCountry.Text = "ManufacturerCountry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Country:";
            // 
            // pb_ManufacturerCountry
            // 
            this.pb_ManufacturerCountry.Location = new System.Drawing.Point(394, 124);
            this.pb_ManufacturerCountry.Name = "pb_ManufacturerCountry";
            this.pb_ManufacturerCountry.Size = new System.Drawing.Size(36, 24);
            this.pb_ManufacturerCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ManufacturerCountry.TabIndex = 21;
            this.pb_ManufacturerCountry.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manufacturerNumberLessBy1);
            this.panel1.Controls.Add(this.manufacturerCurrent);
            this.panel1.Controls.Add(this.manufacturerNumberUpBy1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 401);
            this.panel1.TabIndex = 35;
            // 
            // btnChangeSortingType
            // 
            this.btnChangeSortingType.FlatAppearance.BorderSize = 0;
            this.btnChangeSortingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSortingType.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnChangeSortingType.ForeColor = System.Drawing.Color.White;
            this.btnChangeSortingType.Location = new System.Drawing.Point(6, 3);
            this.btnChangeSortingType.Name = "btnChangeSortingType";
            this.btnChangeSortingType.Size = new System.Drawing.Size(221, 23);
            this.btnChangeSortingType.TabIndex = 37;
            this.btnChangeSortingType.TabStop = false;
            this.btnChangeSortingType.Text = "Change sorting type";
            this.btnChangeSortingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeSortingType.UseMnemonic = false;
            this.btnChangeSortingType.UseVisualStyleBackColor = true;
            this.btnChangeSortingType.Click += new System.EventHandler(this.btnChangeSortingType_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveDialog);
            this.panel2.Controls.Add(this.btnEditManufacturerStats);
            this.panel2.Controls.Add(this.btnChangeSortingType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(194, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 38);
            this.panel2.TabIndex = 38;
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.FlatAppearance.BorderSize = 0;
            this.btnSaveDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDialog.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnSaveDialog.ForeColor = System.Drawing.Color.White;
            this.btnSaveDialog.Location = new System.Drawing.Point(384, 3);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(74, 23);
            this.btnSaveDialog.TabIndex = 39;
            this.btnSaveDialog.TabStop = false;
            this.btnSaveDialog.Text = "Save";
            this.btnSaveDialog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDialog.UseMnemonic = false;
            this.btnSaveDialog.UseVisualStyleBackColor = true;
            this.btnSaveDialog.Visible = false;
            this.btnSaveDialog.Click += new System.EventHandler(this.btnSaveDialog_Click);
            // 
            // btnEditManufacturerStats
            // 
            this.btnEditManufacturerStats.FlatAppearance.BorderSize = 0;
            this.btnEditManufacturerStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditManufacturerStats.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnEditManufacturerStats.ForeColor = System.Drawing.Color.White;
            this.btnEditManufacturerStats.Location = new System.Drawing.Point(279, 3);
            this.btnEditManufacturerStats.Name = "btnEditManufacturerStats";
            this.btnEditManufacturerStats.Size = new System.Drawing.Size(74, 23);
            this.btnEditManufacturerStats.TabIndex = 38;
            this.btnEditManufacturerStats.TabStop = false;
            this.btnEditManufacturerStats.Text = "Edit";
            this.btnEditManufacturerStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditManufacturerStats.UseMnemonic = false;
            this.btnEditManufacturerStats.UseVisualStyleBackColor = true;
            this.btnEditManufacturerStats.Click += new System.EventHandler(this.btnEditManufacturerStats_Click);
            // 
            // panelReturnToMainMenu
            // 
            this.panelReturnToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelReturnToMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReturnToMainMenu.Controls.Add(pictureBox2);
            this.panelReturnToMainMenu.Controls.Add(this.btnReturnToMainMenuDenied);
            this.panelReturnToMainMenu.Controls.Add(this.btnReturnToMainMenuAccepted);
            this.panelReturnToMainMenu.Controls.Add(this.lb_Block_H);
            this.panelReturnToMainMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReturnToMainMenu.Location = new System.Drawing.Point(771, 46);
            this.panelReturnToMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelReturnToMainMenu.Name = "panelReturnToMainMenu";
            this.panelReturnToMainMenu.Size = new System.Drawing.Size(251, 363);
            this.panelReturnToMainMenu.TabIndex = 39;
            this.panelReturnToMainMenu.Visible = false;
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
            this.btnReturnToMainMenuDenied.Location = new System.Drawing.Point(1, 139);
            this.btnReturnToMainMenuDenied.Name = "btnReturnToMainMenuDenied";
            this.btnReturnToMainMenuDenied.Size = new System.Drawing.Size(249, 23);
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
            this.btnReturnToMainMenuAccepted.Location = new System.Drawing.Point(0, 110);
            this.btnReturnToMainMenuAccepted.Name = "btnReturnToMainMenuAccepted";
            this.btnReturnToMainMenuAccepted.Size = new System.Drawing.Size(249, 23);
            this.btnReturnToMainMenuAccepted.TabIndex = 1;
            this.btnReturnToMainMenuAccepted.Text = "YES";
            this.btnReturnToMainMenuAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnToMainMenuAccepted.UseVisualStyleBackColor = false;
            this.btnReturnToMainMenuAccepted.Click += new System.EventHandler(this.btnReturnToMainMenuAccepted_Click);
            this.btnReturnToMainMenuAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnReturnToMainMenuAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // lb_Block_H
            // 
            this.lb_Block_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_Block_H.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Block_H.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_Block_H.Location = new System.Drawing.Point(0, 0);
            this.lb_Block_H.Name = "lb_Block_H";
            this.lb_Block_H.Size = new System.Drawing.Size(249, 106);
            this.lb_Block_H.TabIndex = 0;
            this.lb_Block_H.Text = "      RETURN TO MAIN MENU?";
            // 
            // newManufacturerTitle
            // 
            this.newManufacturerTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newManufacturerTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newManufacturerTitle.Font = new System.Drawing.Font("Forza Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newManufacturerTitle.ForeColor = System.Drawing.Color.White;
            this.newManufacturerTitle.Location = new System.Drawing.Point(389, 59);
            this.newManufacturerTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.newManufacturerTitle.MaxLength = 70;
            this.newManufacturerTitle.Name = "newManufacturerTitle";
            this.newManufacturerTitle.Size = new System.Drawing.Size(361, 33);
            this.newManufacturerTitle.TabIndex = 40;
            this.newManufacturerTitle.Visible = false;
            this.newManufacturerTitle.TextChanged += new System.EventHandler(this.newManufacturerTitle_TextChanged);
            this.newManufacturerTitle.Validating += new System.ComponentModel.CancelEventHandler(this.newManufacturerTitle_Validating);
            // 
            // cb_ManufacturerCountries
            // 
            this.cb_ManufacturerCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cb_ManufacturerCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ManufacturerCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ManufacturerCountries.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.cb_ManufacturerCountries.ForeColor = System.Drawing.Color.White;
            this.cb_ManufacturerCountries.FormattingEnabled = true;
            this.cb_ManufacturerCountries.IntegralHeight = false;
            this.cb_ManufacturerCountries.Location = new System.Drawing.Point(436, 116);
            this.cb_ManufacturerCountries.Name = "cb_ManufacturerCountries";
            this.cb_ManufacturerCountries.Size = new System.Drawing.Size(314, 37);
            this.cb_ManufacturerCountries.TabIndex = 41;
            this.cb_ManufacturerCountries.Visible = false;
            this.cb_ManufacturerCountries.SelectedIndexChanged += new System.EventHandler(this.cb_ManufacturerCountries_SelectedIndexChanged);
            this.cb_ManufacturerCountries.Validating += new System.ComponentModel.CancelEventHandler(this.cb_ManufacturerCountries_Validating);
            // 
            // ManufacturerTitleErrorText
            // 
            this.ManufacturerTitleErrorText.AutoSize = true;
            this.ManufacturerTitleErrorText.Font = new System.Drawing.Font("Forza Medium", 9F);
            this.ManufacturerTitleErrorText.ForeColor = System.Drawing.Color.White;
            this.ManufacturerTitleErrorText.Location = new System.Drawing.Point(391, 92);
            this.ManufacturerTitleErrorText.Name = "ManufacturerTitleErrorText";
            this.ManufacturerTitleErrorText.Size = new System.Drawing.Size(0, 15);
            this.ManufacturerTitleErrorText.TabIndex = 42;
            // 
            // ManufacturerCountryErrorText
            // 
            this.ManufacturerCountryErrorText.AutoSize = true;
            this.ManufacturerCountryErrorText.Font = new System.Drawing.Font("Forza Medium", 9F);
            this.ManufacturerCountryErrorText.ForeColor = System.Drawing.Color.White;
            this.ManufacturerCountryErrorText.Location = new System.Drawing.Point(438, 157);
            this.ManufacturerCountryErrorText.Name = "ManufacturerCountryErrorText";
            this.ManufacturerCountryErrorText.Size = new System.Drawing.Size(0, 15);
            this.ManufacturerCountryErrorText.TabIndex = 43;
            // 
            // panelSaveNewStats
            // 
            this.panelSaveNewStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelSaveNewStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaveNewStats.Controls.Add(pictureBox1);
            this.panelSaveNewStats.Controls.Add(this.label8);
            this.panelSaveNewStats.Controls.Add(this.newManufacturerInfoSavingCancelled);
            this.panelSaveNewStats.Controls.Add(this.newManufacturerInfoSavingDenied);
            this.panelSaveNewStats.Controls.Add(this.newManufacturerInfoSavingAccepted);
            this.panelSaveNewStats.Controls.Add(this.label1);
            this.panelSaveNewStats.Location = new System.Drawing.Point(771, 46);
            this.panelSaveNewStats.Margin = new System.Windows.Forms.Padding(0);
            this.panelSaveNewStats.Name = "panelSaveNewStats";
            this.panelSaveNewStats.Size = new System.Drawing.Size(251, 363);
            this.panelSaveNewStats.TabIndex = 44;
            this.panelSaveNewStats.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 54);
            this.label8.TabIndex = 3;
            this.label8.Text = "Do you want to save new stats of this manufacturer?";
            // 
            // newManufacturerInfoSavingCancelled
            // 
            this.newManufacturerInfoSavingCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newManufacturerInfoSavingCancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newManufacturerInfoSavingCancelled.FlatAppearance.BorderSize = 0;
            this.newManufacturerInfoSavingCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newManufacturerInfoSavingCancelled.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newManufacturerInfoSavingCancelled.ForeColor = System.Drawing.Color.White;
            this.newManufacturerInfoSavingCancelled.Location = new System.Drawing.Point(0, 169);
            this.newManufacturerInfoSavingCancelled.Name = "newManufacturerInfoSavingCancelled";
            this.newManufacturerInfoSavingCancelled.Size = new System.Drawing.Size(249, 23);
            this.newManufacturerInfoSavingCancelled.TabIndex = 2;
            this.newManufacturerInfoSavingCancelled.Text = "CANCEL";
            this.newManufacturerInfoSavingCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newManufacturerInfoSavingCancelled.UseVisualStyleBackColor = false;
            this.newManufacturerInfoSavingCancelled.Click += new System.EventHandler(this.newManufacturerInfoSavingCancelled_Click);
            this.newManufacturerInfoSavingCancelled.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.newManufacturerInfoSavingCancelled.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // newManufacturerInfoSavingDenied
            // 
            this.newManufacturerInfoSavingDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newManufacturerInfoSavingDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newManufacturerInfoSavingDenied.FlatAppearance.BorderSize = 0;
            this.newManufacturerInfoSavingDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newManufacturerInfoSavingDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newManufacturerInfoSavingDenied.ForeColor = System.Drawing.Color.White;
            this.newManufacturerInfoSavingDenied.Location = new System.Drawing.Point(1, 139);
            this.newManufacturerInfoSavingDenied.Name = "newManufacturerInfoSavingDenied";
            this.newManufacturerInfoSavingDenied.Size = new System.Drawing.Size(249, 23);
            this.newManufacturerInfoSavingDenied.TabIndex = 1;
            this.newManufacturerInfoSavingDenied.Text = "NO";
            this.newManufacturerInfoSavingDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newManufacturerInfoSavingDenied.UseVisualStyleBackColor = false;
            this.newManufacturerInfoSavingDenied.Click += new System.EventHandler(this.newManufacturerInfoSavingDenied_Click);
            this.newManufacturerInfoSavingDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.newManufacturerInfoSavingDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // newManufacturerInfoSavingAccepted
            // 
            this.newManufacturerInfoSavingAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newManufacturerInfoSavingAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newManufacturerInfoSavingAccepted.FlatAppearance.BorderSize = 0;
            this.newManufacturerInfoSavingAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newManufacturerInfoSavingAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newManufacturerInfoSavingAccepted.ForeColor = System.Drawing.Color.White;
            this.newManufacturerInfoSavingAccepted.Location = new System.Drawing.Point(0, 110);
            this.newManufacturerInfoSavingAccepted.Name = "newManufacturerInfoSavingAccepted";
            this.newManufacturerInfoSavingAccepted.Size = new System.Drawing.Size(249, 23);
            this.newManufacturerInfoSavingAccepted.TabIndex = 1;
            this.newManufacturerInfoSavingAccepted.Text = "YES";
            this.newManufacturerInfoSavingAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newManufacturerInfoSavingAccepted.UseVisualStyleBackColor = false;
            this.newManufacturerInfoSavingAccepted.Click += new System.EventHandler(this.newManufacturerInfoSavingAccepted_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "      SAVING";
            // 
            // manufacturerImage
            // 
            this.manufacturerImage.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forza Medium", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 48;
            // 
            // txt_ShortTitle
            // 
            this.txt_ShortTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_ShortTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ShortTitle.Font = new System.Drawing.Font("Forza Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShortTitle.ForeColor = System.Drawing.Color.White;
            this.txt_ShortTitle.Location = new System.Drawing.Point(389, 217);
            this.txt_ShortTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_ShortTitle.MaxLength = 70;
            this.txt_ShortTitle.Name = "txt_ShortTitle";
            this.txt_ShortTitle.Size = new System.Drawing.Size(361, 33);
            this.txt_ShortTitle.TabIndex = 47;
            this.txt_ShortTitle.Visible = false;
            this.txt_ShortTitle.TextChanged += new System.EventHandler(this.txt_ShortTitle_TextChanged);
            this.txt_ShortTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ShortTitle_Validating);
            // 
            // lbShortTitle
            // 
            this.lbShortTitle.AutoSize = true;
            this.lbShortTitle.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lbShortTitle.ForeColor = System.Drawing.Color.White;
            this.lbShortTitle.Location = new System.Drawing.Point(212, 216);
            this.lbShortTitle.Name = "lbShortTitle";
            this.lbShortTitle.Size = new System.Drawing.Size(83, 29);
            this.lbShortTitle.TabIndex = 46;
            this.lbShortTitle.Text = "Short:";
            this.lbShortTitle.Visible = false;
            // 
            // ManufacturerShortTitleErrorText
            // 
            this.ManufacturerShortTitleErrorText.AutoSize = true;
            this.ManufacturerShortTitleErrorText.Font = new System.Drawing.Font("Forza Medium", 9F);
            this.ManufacturerShortTitleErrorText.ForeColor = System.Drawing.Color.White;
            this.ManufacturerShortTitleErrorText.Location = new System.Drawing.Point(391, 258);
            this.ManufacturerShortTitleErrorText.Name = "ManufacturerShortTitleErrorText";
            this.ManufacturerShortTitleErrorText.Size = new System.Drawing.Size(0, 15);
            this.ManufacturerShortTitleErrorText.TabIndex = 49;
            // 
            // lb_carsCount_H
            // 
            this.lb_carsCount_H.AutoSize = true;
            this.lb_carsCount_H.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lb_carsCount_H.ForeColor = System.Drawing.Color.White;
            this.lb_carsCount_H.Location = new System.Drawing.Point(212, 179);
            this.lb_carsCount_H.Name = "lb_carsCount_H";
            this.lb_carsCount_H.Size = new System.Drawing.Size(169, 29);
            this.lb_carsCount_H.TabIndex = 50;
            this.lb_carsCount_H.Text = "Availible cars:";
            // 
            // lbCarsCount
            // 
            this.lbCarsCount.AutoSize = true;
            this.lbCarsCount.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.lbCarsCount.ForeColor = System.Drawing.Color.White;
            this.lbCarsCount.Location = new System.Drawing.Point(389, 179);
            this.lbCarsCount.Name = "lbCarsCount";
            this.lbCarsCount.Size = new System.Drawing.Size(0, 29);
            this.lbCarsCount.TabIndex = 51;
            // 
            // ManufacturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1022, 447);
            this.Controls.Add(this.lbCarsCount);
            this.Controls.Add(this.lb_carsCount_H);
            this.Controls.Add(this.ManufacturerShortTitleErrorText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ShortTitle);
            this.Controls.Add(this.lbShortTitle);
            this.Controls.Add(this.panelSaveNewStats);
            this.Controls.Add(this.ManufacturerCountryErrorText);
            this.Controls.Add(this.ManufacturerTitleErrorText);
            this.Controls.Add(this.cb_ManufacturerCountries);
            this.Controls.Add(this.newManufacturerTitle);
            this.Controls.Add(this.panelReturnToMainMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_ManufacturerCountry);
            this.Controls.Add(this.lb_ManufacturerCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_manufacturer);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ManufacturersForm";
            this.ShowInTaskbar = false;
            this.Text = "Manufacturers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManufacturersForm_FormClosing);
            this.Load += new System.EventHandler(this.ManufacturersForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ManufacturersForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerNumberUpBy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerNumberLessBy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ManufacturerCountry)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelReturnToMainMenu.ResumeLayout(false);
            this.panelSaveNewStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label currentManufacturer;
        private System.Windows.Forms.Label GroupNumberGreaterBy1;
        private System.Windows.Forms.Button btnIncreaseGroupNumberBy5;
        private System.Windows.Forms.Label GroupNumberGreaterBy2;
        private System.Windows.Forms.Button btnDecreaseGroupNumberBy5;
        private System.Windows.Forms.Label GroupNumberGreaterBy3;
        private System.Windows.Forms.Label GroupNumberGreaterBy4;
        private System.Windows.Forms.Label GroupNumberGreaterBy5;
        private System.Windows.Forms.PictureBox manufacturerNumberUpBy1;
        private System.Windows.Forms.PictureBox manufacturerCurrent;
        private System.Windows.Forms.PictureBox manufacturerNumberLessBy1;
        private System.Windows.Forms.Label lb_manufacturer;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_ManufacturerCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_ManufacturerCountry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeSortingType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelReturnToMainMenu;
        private System.Windows.Forms.Button btnReturnToMainMenuDenied;
        private System.Windows.Forms.Button btnReturnToMainMenuAccepted;
        private System.Windows.Forms.Label lb_Block_H;
        private System.Windows.Forms.Button btnEditManufacturerStats;
        private System.Windows.Forms.TextBox newManufacturerTitle;
        private System.Windows.Forms.ComboBox cb_ManufacturerCountries;
        private System.Windows.Forms.Label ManufacturerTitleErrorText;
        private System.Windows.Forms.Label ManufacturerCountryErrorText;
        private System.Windows.Forms.Button btnSaveDialog;
        private System.Windows.Forms.Panel panelSaveNewStats;
        private System.Windows.Forms.Button newManufacturerInfoSavingCancelled;
        private System.Windows.Forms.Button newManufacturerInfoSavingDenied;
        private System.Windows.Forms.Button newManufacturerInfoSavingAccepted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog manufacturerImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ShortTitle;
        private System.Windows.Forms.Label lbShortTitle;
        private System.Windows.Forms.Label ManufacturerShortTitleErrorText;
        private System.Windows.Forms.Label lb_carsCount_H;
        private System.Windows.Forms.Label lbCarsCount;
    }
}