namespace WindowsFormsApp2
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowStatistics = new System.Windows.Forms.Label();
            this.btnManufacturers = new System.Windows.Forms.Label();
            this.btnBlockUsers = new System.Windows.Forms.Label();
            this.btnEditAccount = new System.Windows.Forms.Label();
            this.btnEditCarStats = new System.Windows.Forms.Label();
            this.currentCollectorLevel = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyBudget = new System.Windows.Forms.Label();
            this.lb_CurrentUser = new System.Windows.Forms.Label();
            this.panelUserCountry = new System.Windows.Forms.Panel();
            this.pb_BigCarImage = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Label();
            this.btnAdministration = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BigCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1355, 505);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Image = global::WindowsFormsApp2.Properties.Resources.Statistics;
            this.btnShowStatistics.Location = new System.Drawing.Point(0, 315);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(400, 200);
            this.btnShowStatistics.TabIndex = 7;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            this.btnShowStatistics.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.btnShowStatistics.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // btnManufacturers
            // 
            this.btnManufacturers.Image = global::WindowsFormsApp2.Properties.Resources.Manufacturers;
            this.btnManufacturers.Location = new System.Drawing.Point(390, 315);
            this.btnManufacturers.Name = "btnManufacturers";
            this.btnManufacturers.Size = new System.Drawing.Size(400, 200);
            this.btnManufacturers.TabIndex = 6;
            this.btnManufacturers.Click += new System.EventHandler(this.btnManufacturers_Click);
            this.btnManufacturers.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.btnManufacturers.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // btnBlockUsers
            // 
            this.btnBlockUsers.Image = global::WindowsFormsApp2.Properties.Resources.OtherUsers;
            this.btnBlockUsers.Location = new System.Drawing.Point(0, 125);
            this.btnBlockUsers.Name = "btnBlockUsers";
            this.btnBlockUsers.Size = new System.Drawing.Size(400, 200);
            this.btnBlockUsers.TabIndex = 5;
            this.btnBlockUsers.Visible = false;
            this.btnBlockUsers.Click += new System.EventHandler(this.btnBlockUsers_Click);
            this.btnBlockUsers.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.btnBlockUsers.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Image = global::WindowsFormsApp2.Properties.Resources.Account;
            this.btnEditAccount.Location = new System.Drawing.Point(390, 125);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(400, 200);
            this.btnEditAccount.TabIndex = 4;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            this.btnEditAccount.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.btnEditAccount.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // btnEditCarStats
            // 
            this.btnEditCarStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(126)))));
            this.btnEditCarStats.Image = global::WindowsFormsApp2.Properties.Resources.Cars;
            this.btnEditCarStats.Location = new System.Drawing.Point(0, 125);
            this.btnEditCarStats.Name = "btnEditCarStats";
            this.btnEditCarStats.Size = new System.Drawing.Size(400, 200);
            this.btnEditCarStats.TabIndex = 3;
            this.btnEditCarStats.Click += new System.EventHandler(this.btnEditCarStats_Click);
            this.btnEditCarStats.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.btnEditCarStats.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
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
            this.currentCollectorLevel.Location = new System.Drawing.Point(1412, 12);
            this.currentCollectorLevel.Margin = new System.Windows.Forms.Padding(0);
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
            this.currentCollectorLevel.TabIndex = 8;
            this.currentCollectorLevel.Text = "99";
            this.currentCollectorLevel.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.currentCollectorLevel.Value = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.MyBudget);
            this.panel1.Controls.Add(this.lb_CurrentUser);
            this.panel1.Location = new System.Drawing.Point(1212, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 9;
            // 
            // MyBudget
            // 
            this.MyBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyBudget.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.MyBudget.ForeColor = System.Drawing.Color.White;
            this.MyBudget.Location = new System.Drawing.Point(0, 31);
            this.MyBudget.Name = "MyBudget";
            this.MyBudget.Size = new System.Drawing.Size(200, 19);
            this.MyBudget.TabIndex = 10;
            this.MyBudget.Text = "Budget";
            this.MyBudget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_CurrentUser
            // 
            this.lb_CurrentUser.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lb_CurrentUser.ForeColor = System.Drawing.Color.Gold;
            this.lb_CurrentUser.Location = new System.Drawing.Point(0, 10);
            this.lb_CurrentUser.Name = "lb_CurrentUser";
            this.lb_CurrentUser.Size = new System.Drawing.Size(200, 19);
            this.lb_CurrentUser.TabIndex = 24;
            this.lb_CurrentUser.Text = "UserName";
            this.lb_CurrentUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelUserCountry
            // 
            this.panelUserCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUserCountry.Location = new System.Drawing.Point(1122, 12);
            this.panelUserCountry.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserCountry.Name = "panelUserCountry";
            this.panelUserCountry.Size = new System.Drawing.Size(90, 60);
            this.panelUserCountry.TabIndex = 10;
            // 
            // pb_BigCarImage
            // 
            this.pb_BigCarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_BigCarImage.Location = new System.Drawing.Point(860, 157);
            this.pb_BigCarImage.Name = "pb_BigCarImage";
            this.pb_BigCarImage.Size = new System.Drawing.Size(612, 345);
            this.pb_BigCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BigCarImage.TabIndex = 26;
            this.pb_BigCarImage.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMainMenu.BackColor = System.Drawing.Color.Black;
            this.btnMainMenu.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 102);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(155, 23);
            this.btnMainMenu.TabIndex = 27;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnAdministration
            // 
            this.btnAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdministration.BackColor = System.Drawing.Color.Black;
            this.btnAdministration.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.btnAdministration.ForeColor = System.Drawing.Color.White;
            this.btnAdministration.Location = new System.Drawing.Point(172, 102);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(155, 23);
            this.btnAdministration.TabIndex = 28;
            this.btnAdministration.Text = "ADMINISTRATION";
            this.btnAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1484, 536);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAdministration);
            this.Controls.Add(this.panelUserCountry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentCollectorLevel);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.btnManufacturers);
            this.Controls.Add(this.btnBlockUsers);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnEditCarStats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pb_BigCarImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminMenuForm";
            this.ShowInTaskbar = false;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BigCarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label btnEditCarStats;
        private System.Windows.Forms.Label btnEditAccount;
        private System.Windows.Forms.Label btnBlockUsers;
        private System.Windows.Forms.Label btnManufacturers;
        private System.Windows.Forms.Label btnShowStatistics;
        private CircularProgressBar.CircularProgressBar currentCollectorLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_CurrentUser;
        private System.Windows.Forms.Label MyBudget;
        private System.Windows.Forms.Panel panelUserCountry;
        private System.Windows.Forms.PictureBox pb_BigCarImage;
        private System.Windows.Forms.Label btnMainMenu;
        private System.Windows.Forms.Label btnAdministration;
    }
}