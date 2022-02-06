namespace WindowsFormsApp2
{
    partial class AccountInfoForm
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
            System.Windows.Forms.Label lb_Password;
            System.Windows.Forms.Label lb_Login;
            System.Windows.Forms.Label lb_Name;
            System.Windows.Forms.Label lb_Password2;
            System.Windows.Forms.Label lb_Country;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoForm));
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.Label label4;
            this.UserNameErrorText = new System.Windows.Forms.Label();
            this.UserCountryErrorText = new System.Windows.Forms.Label();
            this.UserPassword2ErrorText = new System.Windows.Forms.Label();
            this.UserLoginErrorText = new System.Windows.Forms.Label();
            this.UserPasswordErrorText = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txt_UserCountry = new System.Windows.Forms.ComboBox();
            this.panelUpdateUser = new System.Windows.Forms.Panel();
            this.lb_UpdateQuestion = new System.Windows.Forms.Label();
            this.btnUpdatingDenied = new System.Windows.Forms.Button();
            this.btnUpdatingAccepted = new System.Windows.Forms.Button();
            this.lb_Block_H = new System.Windows.Forms.Label();
            this.panelCloseForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosingDenied = new System.Windows.Forms.Button();
            this.btnClosingAccepted = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FormMainImage = new System.Windows.Forms.PictureBox();
            this.pb_UserCountry = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_SortingTypes = new System.Windows.Forms.ComboBox();
            this.UserSortingTypeErrorText = new System.Windows.Forms.Label();
            lb_Password = new System.Windows.Forms.Label();
            lb_Login = new System.Windows.Forms.Label();
            lb_Name = new System.Windows.Forms.Label();
            lb_Password2 = new System.Windows.Forms.Label();
            lb_Country = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.panelUpdateUser.SuspendLayout();
            this.panelCloseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Password.ForeColor = System.Drawing.Color.White;
            lb_Password.Location = new System.Drawing.Point(12, 101);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new System.Drawing.Size(92, 19);
            lb_Password.TabIndex = 3;
            lb_Password.Text = "Password:";
            // 
            // lb_Login
            // 
            lb_Login.AutoSize = true;
            lb_Login.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Login.ForeColor = System.Drawing.Color.White;
            lb_Login.Location = new System.Drawing.Point(12, 58);
            lb_Login.Name = "lb_Login";
            lb_Login.Size = new System.Drawing.Size(58, 19);
            lb_Login.TabIndex = 3;
            lb_Login.Text = "Login:";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Name.ForeColor = System.Drawing.Color.White;
            lb_Name.Location = new System.Drawing.Point(12, 12);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new System.Drawing.Size(60, 19);
            lb_Name.TabIndex = 3;
            lb_Name.Text = "Name:";
            // 
            // lb_Password2
            // 
            lb_Password2.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Password2.ForeColor = System.Drawing.Color.White;
            lb_Password2.Location = new System.Drawing.Point(12, 140);
            lb_Password2.Name = "lb_Password2";
            lb_Password2.Size = new System.Drawing.Size(112, 43);
            lb_Password2.TabIndex = 3;
            lb_Password2.Text = "Repeat password:";
            // 
            // lb_Country
            // 
            lb_Country.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Country.ForeColor = System.Drawing.Color.White;
            lb_Country.Location = new System.Drawing.Point(12, 203);
            lb_Country.Name = "lb_Country";
            lb_Country.Size = new System.Drawing.Size(112, 22);
            lb_Country.TabIndex = 3;
            lb_Country.Text = "Country:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(24, 24);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
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
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(12, 248);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(112, 38);
            label4.TabIndex = 42;
            label4.Text = "Sorting type:";
            // 
            // UserNameErrorText
            // 
            this.UserNameErrorText.AutoSize = true;
            this.UserNameErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.UserNameErrorText.ForeColor = System.Drawing.Color.White;
            this.UserNameErrorText.Location = new System.Drawing.Point(127, 37);
            this.UserNameErrorText.Name = "UserNameErrorText";
            this.UserNameErrorText.Size = new System.Drawing.Size(0, 14);
            this.UserNameErrorText.TabIndex = 9;
            // 
            // UserCountryErrorText
            // 
            this.UserCountryErrorText.AutoSize = true;
            this.UserCountryErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.UserCountryErrorText.ForeColor = System.Drawing.Color.White;
            this.UserCountryErrorText.Location = new System.Drawing.Point(127, 230);
            this.UserCountryErrorText.Name = "UserCountryErrorText";
            this.UserCountryErrorText.Size = new System.Drawing.Size(0, 14);
            this.UserCountryErrorText.TabIndex = 10;
            // 
            // UserPassword2ErrorText
            // 
            this.UserPassword2ErrorText.AutoSize = true;
            this.UserPassword2ErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.UserPassword2ErrorText.ForeColor = System.Drawing.Color.White;
            this.UserPassword2ErrorText.Location = new System.Drawing.Point(127, 186);
            this.UserPassword2ErrorText.Name = "UserPassword2ErrorText";
            this.UserPassword2ErrorText.Size = new System.Drawing.Size(0, 14);
            this.UserPassword2ErrorText.TabIndex = 11;
            // 
            // UserLoginErrorText
            // 
            this.UserLoginErrorText.AutoSize = true;
            this.UserLoginErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.UserLoginErrorText.ForeColor = System.Drawing.Color.White;
            this.UserLoginErrorText.Location = new System.Drawing.Point(127, 80);
            this.UserLoginErrorText.Name = "UserLoginErrorText";
            this.UserLoginErrorText.Size = new System.Drawing.Size(0, 14);
            this.UserLoginErrorText.TabIndex = 12;
            // 
            // UserPasswordErrorText
            // 
            this.UserPasswordErrorText.AutoSize = true;
            this.UserPasswordErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.UserPasswordErrorText.ForeColor = System.Drawing.Color.White;
            this.UserPasswordErrorText.Location = new System.Drawing.Point(127, 124);
            this.UserPasswordErrorText.Name = "UserPasswordErrorText";
            this.UserPasswordErrorText.Size = new System.Drawing.Size(0, 14);
            this.UserPasswordErrorText.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(130, 101);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(273, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(130, 54);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(273, 23);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TabStop = false;
            this.txtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogin_Validating);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(130, 11);
            this.txtName.MaxLength = 15;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(12, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 31);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseMove);
            // 
            // btnFormClose
            // 
            this.btnFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormClose.ForeColor = System.Drawing.Color.White;
            this.btnFormClose.Location = new System.Drawing.Point(291, 315);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(112, 31);
            this.btnFormClose.TabIndex = 6;
            this.btnFormClose.Text = "Close";
            this.btnFormClose.UseVisualStyleBackColor = false;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            this.btnFormClose.MouseLeave += new System.EventHandler(this.btnFormClose_MouseLeave);
            this.btnFormClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFormClose_MouseMove);
            // 
            // txtPassword2
            // 
            this.txtPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword2.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.Color.White;
            this.txtPassword2.Location = new System.Drawing.Point(130, 160);
            this.txtPassword2.MaxLength = 15;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '•';
            this.txtPassword2.Size = new System.Drawing.Size(273, 23);
            this.txtPassword2.TabIndex = 4;
            this.txtPassword2.TabStop = false;
            this.txtPassword2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword2_Validating);
            // 
            // txt_UserCountry
            // 
            this.txt_UserCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_UserCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_UserCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_UserCountry.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.txt_UserCountry.ForeColor = System.Drawing.Color.White;
            this.txt_UserCountry.FormattingEnabled = true;
            this.txt_UserCountry.Location = new System.Drawing.Point(172, 203);
            this.txt_UserCountry.Name = "txt_UserCountry";
            this.txt_UserCountry.Size = new System.Drawing.Size(231, 23);
            this.txt_UserCountry.TabIndex = 7;
            this.txt_UserCountry.SelectedIndexChanged += new System.EventHandler(this.txt_UserCountry_SelectedIndexChanged);
            this.txt_UserCountry.Validating += new System.ComponentModel.CancelEventHandler(this.txt_UserCountry_Validating);
            // 
            // panelUpdateUser
            // 
            this.panelUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelUpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateUser.Controls.Add(pictureBox2);
            this.panelUpdateUser.Controls.Add(this.lb_UpdateQuestion);
            this.panelUpdateUser.Controls.Add(this.btnUpdatingDenied);
            this.panelUpdateUser.Controls.Add(this.btnUpdatingAccepted);
            this.panelUpdateUser.Controls.Add(this.lb_Block_H);
            this.panelUpdateUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUpdateUser.Location = new System.Drawing.Point(744, 0);
            this.panelUpdateUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdateUser.Name = "panelUpdateUser";
            this.panelUpdateUser.Size = new System.Drawing.Size(296, 358);
            this.panelUpdateUser.TabIndex = 34;
            this.panelUpdateUser.Visible = false;
            // 
            // lb_UpdateQuestion
            // 
            this.lb_UpdateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_UpdateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_UpdateQuestion.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UpdateQuestion.Location = new System.Drawing.Point(1, 36);
            this.lb_UpdateQuestion.Name = "lb_UpdateQuestion";
            this.lb_UpdateQuestion.Size = new System.Drawing.Size(290, 50);
            this.lb_UpdateQuestion.TabIndex = 3;
            this.lb_UpdateQuestion.Text = "Do you want to update yoyr account?";
            // 
            // btnUpdatingDenied
            // 
            this.btnUpdatingDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatingDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdatingDenied.FlatAppearance.BorderSize = 0;
            this.btnUpdatingDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatingDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatingDenied.ForeColor = System.Drawing.Color.White;
            this.btnUpdatingDenied.Location = new System.Drawing.Point(1, 139);
            this.btnUpdatingDenied.Name = "btnUpdatingDenied";
            this.btnUpdatingDenied.Size = new System.Drawing.Size(294, 23);
            this.btnUpdatingDenied.TabIndex = 1;
            this.btnUpdatingDenied.Text = "NO";
            this.btnUpdatingDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatingDenied.UseVisualStyleBackColor = false;
            this.btnUpdatingDenied.Click += new System.EventHandler(this.btnUpdatingDenied_Click);
            this.btnUpdatingDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnUpdatingDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnUpdatingAccepted
            // 
            this.btnUpdatingAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatingAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdatingAccepted.FlatAppearance.BorderSize = 0;
            this.btnUpdatingAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatingAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatingAccepted.ForeColor = System.Drawing.Color.White;
            this.btnUpdatingAccepted.Location = new System.Drawing.Point(0, 110);
            this.btnUpdatingAccepted.Name = "btnUpdatingAccepted";
            this.btnUpdatingAccepted.Size = new System.Drawing.Size(294, 23);
            this.btnUpdatingAccepted.TabIndex = 1;
            this.btnUpdatingAccepted.Text = "YES";
            this.btnUpdatingAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatingAccepted.UseVisualStyleBackColor = false;
            this.btnUpdatingAccepted.Click += new System.EventHandler(this.btnUpdatingAccepted_Click);
            this.btnUpdatingAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnUpdatingAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // lb_Block_H
            // 
            this.lb_Block_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_Block_H.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Block_H.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Block_H.Location = new System.Drawing.Point(0, 0);
            this.lb_Block_H.Name = "lb_Block_H";
            this.lb_Block_H.Size = new System.Drawing.Size(294, 106);
            this.lb_Block_H.TabIndex = 0;
            this.lb_Block_H.Text = "     UPDATE ACCOUNT?";
            // 
            // panelCloseForm
            // 
            this.panelCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCloseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCloseForm.Controls.Add(pictureBox1);
            this.panelCloseForm.Controls.Add(this.label1);
            this.panelCloseForm.Controls.Add(this.btnClosingDenied);
            this.panelCloseForm.Controls.Add(this.btnClosingAccepted);
            this.panelCloseForm.Controls.Add(this.label2);
            this.panelCloseForm.Location = new System.Drawing.Point(744, 0);
            this.panelCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelCloseForm.Name = "panelCloseForm";
            this.panelCloseForm.Size = new System.Drawing.Size(296, 357);
            this.panelCloseForm.TabIndex = 35;
            this.panelCloseForm.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to close this window?";
            // 
            // btnClosingDenied
            // 
            this.btnClosingDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosingDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClosingDenied.FlatAppearance.BorderSize = 0;
            this.btnClosingDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosingDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosingDenied.ForeColor = System.Drawing.Color.White;
            this.btnClosingDenied.Location = new System.Drawing.Point(1, 139);
            this.btnClosingDenied.Name = "btnClosingDenied";
            this.btnClosingDenied.Size = new System.Drawing.Size(294, 23);
            this.btnClosingDenied.TabIndex = 1;
            this.btnClosingDenied.Text = "NO";
            this.btnClosingDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosingDenied.UseVisualStyleBackColor = false;
            this.btnClosingDenied.Click += new System.EventHandler(this.btnClosingDenied_Click);
            this.btnClosingDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnClosingDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnClosingAccepted
            // 
            this.btnClosingAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosingAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClosingAccepted.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClosingAccepted.FlatAppearance.BorderSize = 0;
            this.btnClosingAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosingAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosingAccepted.ForeColor = System.Drawing.Color.White;
            this.btnClosingAccepted.Location = new System.Drawing.Point(0, 110);
            this.btnClosingAccepted.Name = "btnClosingAccepted";
            this.btnClosingAccepted.Size = new System.Drawing.Size(294, 23);
            this.btnClosingAccepted.TabIndex = 1;
            this.btnClosingAccepted.Text = "YES";
            this.btnClosingAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosingAccepted.UseVisualStyleBackColor = false;
            this.btnClosingAccepted.Click += new System.EventHandler(this.btnClosingAccepted_Click);
            this.btnClosingAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnClosingAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 106);
            this.label2.TabIndex = 0;
            this.label2.Text = "      CLOSE?";
            // 
            // FormMainImage
            // 
            this.FormMainImage.Image = global::WindowsFormsApp2.Properties.Resources.Car1013;
            this.FormMainImage.Location = new System.Drawing.Point(420, 0);
            this.FormMainImage.Name = "FormMainImage";
            this.FormMainImage.Size = new System.Drawing.Size(620, 358);
            this.FormMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormMainImage.TabIndex = 41;
            this.FormMainImage.TabStop = false;
            // 
            // pb_UserCountry
            // 
            this.pb_UserCountry.Location = new System.Drawing.Point(130, 203);
            this.pb_UserCountry.Name = "pb_UserCountry";
            this.pb_UserCountry.Size = new System.Drawing.Size(36, 24);
            this.pb_UserCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_UserCountry.TabIndex = 8;
            this.pb_UserCountry.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 44;
            // 
            // cb_SortingTypes
            // 
            this.cb_SortingTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cb_SortingTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortingTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_SortingTypes.Font = new System.Drawing.Font("Forza Medium", 10F);
            this.cb_SortingTypes.ForeColor = System.Drawing.Color.White;
            this.cb_SortingTypes.FormattingEnabled = true;
            this.cb_SortingTypes.Location = new System.Drawing.Point(130, 263);
            this.cb_SortingTypes.Name = "cb_SortingTypes";
            this.cb_SortingTypes.Size = new System.Drawing.Size(273, 23);
            this.cb_SortingTypes.TabIndex = 43;
            // 
            // UserSortingTypeErrorText
            // 
            this.UserSortingTypeErrorText.AutoSize = true;
            this.UserSortingTypeErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.UserSortingTypeErrorText.ForeColor = System.Drawing.Color.White;
            this.UserSortingTypeErrorText.Location = new System.Drawing.Point(127, 289);
            this.UserSortingTypeErrorText.Name = "UserSortingTypeErrorText";
            this.UserSortingTypeErrorText.Size = new System.Drawing.Size(0, 14);
            this.UserSortingTypeErrorText.TabIndex = 45;
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 358);
            this.Controls.Add(this.UserSortingTypeErrorText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_SortingTypes);
            this.Controls.Add(label4);
            this.Controls.Add(this.panelCloseForm);
            this.Controls.Add(this.panelUpdateUser);
            this.Controls.Add(this.FormMainImage);
            this.Controls.Add(this.UserNameErrorText);
            this.Controls.Add(this.UserCountryErrorText);
            this.Controls.Add(this.UserPassword2ErrorText);
            this.Controls.Add(this.UserLoginErrorText);
            this.Controls.Add(this.UserPasswordErrorText);
            this.Controls.Add(this.pb_UserCountry);
            this.Controls.Add(this.txt_UserCountry);
            this.Controls.Add(this.btnFormClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(lb_Name);
            this.Controls.Add(lb_Country);
            this.Controls.Add(lb_Password2);
            this.Controls.Add(lb_Login);
            this.Controls.Add(lb_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountInfoForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.panelUpdateUser.ResumeLayout(false);
            this.panelCloseForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.ComboBox txt_UserCountry;
        private System.Windows.Forms.PictureBox pb_UserCountry;
        private System.Windows.Forms.Label UserNameErrorText;
        private System.Windows.Forms.Label UserCountryErrorText;
        private System.Windows.Forms.Label UserPassword2ErrorText;
        private System.Windows.Forms.Label UserLoginErrorText;
        private System.Windows.Forms.Label UserPasswordErrorText;
        private System.Windows.Forms.Panel panelUpdateUser;
        private System.Windows.Forms.Label lb_UpdateQuestion;
        private System.Windows.Forms.Button btnUpdatingDenied;
        private System.Windows.Forms.Button btnUpdatingAccepted;
        private System.Windows.Forms.Label lb_Block_H;
        private System.Windows.Forms.Panel panelCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClosingDenied;
        private System.Windows.Forms.Button btnClosingAccepted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox FormMainImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_SortingTypes;
        private System.Windows.Forms.Label UserSortingTypeErrorText;
    }
}