namespace WindowsFormsApp2
{
    partial class NewConnectionForm
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
            System.Windows.Forms.Label lb_Country;
            System.Windows.Forms.Label lb_Login;
            System.Windows.Forms.Label lb_Password;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConnectionForm));
            this.cb_Servers = new System.Windows.Forms.ComboBox();
            this.cb_IntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerLoginErrorText = new System.Windows.Forms.Label();
            this.ServerPasswordErrorText = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbConnectionStringTitle = new System.Windows.Forms.Label();
            this.btnDeployBaseOnNewServer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lb_Country = new System.Windows.Forms.Label();
            lb_Login = new System.Windows.Forms.Label();
            lb_Password = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Country
            // 
            lb_Country.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Country.ForeColor = System.Drawing.Color.White;
            lb_Country.Location = new System.Drawing.Point(8, 8);
            lb_Country.Name = "lb_Country";
            lb_Country.Size = new System.Drawing.Size(112, 22);
            lb_Country.TabIndex = 8;
            lb_Country.Text = "Server:";
            // 
            // lb_Login
            // 
            lb_Login.AutoSize = true;
            lb_Login.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Login.ForeColor = System.Drawing.Color.White;
            lb_Login.Location = new System.Drawing.Point(6, 7);
            lb_Login.Name = "lb_Login";
            lb_Login.Size = new System.Drawing.Size(58, 19);
            lb_Login.TabIndex = 5;
            lb_Login.Text = "Login:";
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Password.ForeColor = System.Drawing.Color.White;
            lb_Password.Location = new System.Drawing.Point(6, 53);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new System.Drawing.Size(92, 19);
            lb_Password.TabIndex = 6;
            lb_Password.Text = "Password:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 175);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(349, 22);
            label1.TabIndex = 12;
            label1.Text = "Connection string title:";
            // 
            // cb_Servers
            // 
            this.cb_Servers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cb_Servers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Servers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Servers.Font = new System.Drawing.Font("Forza Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Servers.ForeColor = System.Drawing.Color.White;
            this.cb_Servers.FormattingEnabled = true;
            this.cb_Servers.Location = new System.Drawing.Point(126, 8);
            this.cb_Servers.Name = "cb_Servers";
            this.cb_Servers.Size = new System.Drawing.Size(231, 22);
            this.cb_Servers.TabIndex = 9;
            this.cb_Servers.TextChanged += new System.EventHandler(this.cb_Servers_TextChanged);
            // 
            // cb_IntegratedSecurity
            // 
            this.cb_IntegratedSecurity.AutoSize = true;
            this.cb_IntegratedSecurity.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_IntegratedSecurity.ForeColor = System.Drawing.Color.White;
            this.cb_IntegratedSecurity.Location = new System.Drawing.Point(12, 37);
            this.cb_IntegratedSecurity.Name = "cb_IntegratedSecurity";
            this.cb_IntegratedSecurity.Size = new System.Drawing.Size(185, 23);
            this.cb_IntegratedSecurity.TabIndex = 10;
            this.cb_IntegratedSecurity.Text = "Integrated security";
            this.cb_IntegratedSecurity.UseVisualStyleBackColor = true;
            this.cb_IntegratedSecurity.CheckedChanged += new System.EventHandler(this.cb_IntegratedSecurity_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ServerLoginErrorText);
            this.panel1.Controls.Add(this.ServerPasswordErrorText);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(lb_Login);
            this.panel1.Controls.Add(lb_Password);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 106);
            this.panel1.TabIndex = 11;
            // 
            // ServerLoginErrorText
            // 
            this.ServerLoginErrorText.AutoSize = true;
            this.ServerLoginErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.ServerLoginErrorText.ForeColor = System.Drawing.Color.White;
            this.ServerLoginErrorText.Location = new System.Drawing.Point(121, 26);
            this.ServerLoginErrorText.Name = "ServerLoginErrorText";
            this.ServerLoginErrorText.Size = new System.Drawing.Size(0, 14);
            this.ServerLoginErrorText.TabIndex = 15;
            // 
            // ServerPasswordErrorText
            // 
            this.ServerPasswordErrorText.AutoSize = true;
            this.ServerPasswordErrorText.Font = new System.Drawing.Font("Forza Medium", 8F);
            this.ServerPasswordErrorText.ForeColor = System.Drawing.Color.White;
            this.ServerPasswordErrorText.Location = new System.Drawing.Point(121, 75);
            this.ServerPasswordErrorText.Name = "ServerPasswordErrorText";
            this.ServerPasswordErrorText.Size = new System.Drawing.Size(0, 14);
            this.ServerPasswordErrorText.TabIndex = 14;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(124, 3);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(218, 23);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.TabStop = false;
            this.txtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogin_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(124, 49);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(218, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TabStop = false;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lbConnectionStringTitle
            // 
            this.lbConnectionStringTitle.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStringTitle.ForeColor = System.Drawing.Color.White;
            this.lbConnectionStringTitle.Location = new System.Drawing.Point(11, 197);
            this.lbConnectionStringTitle.Name = "lbConnectionStringTitle";
            this.lbConnectionStringTitle.Size = new System.Drawing.Size(349, 22);
            this.lbConnectionStringTitle.TabIndex = 13;
            this.lbConnectionStringTitle.Text = "Connection string title:";
            // 
            // btnDeployBaseOnNewServer
            // 
            this.btnDeployBaseOnNewServer.FlatAppearance.BorderSize = 0;
            this.btnDeployBaseOnNewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployBaseOnNewServer.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnDeployBaseOnNewServer.ForeColor = System.Drawing.Color.White;
            this.btnDeployBaseOnNewServer.Location = new System.Drawing.Point(283, 222);
            this.btnDeployBaseOnNewServer.Name = "btnDeployBaseOnNewServer";
            this.btnDeployBaseOnNewServer.Size = new System.Drawing.Size(74, 23);
            this.btnDeployBaseOnNewServer.TabIndex = 39;
            this.btnDeployBaseOnNewServer.TabStop = false;
            this.btnDeployBaseOnNewServer.Text = "OK";
            this.btnDeployBaseOnNewServer.UseMnemonic = false;
            this.btnDeployBaseOnNewServer.UseVisualStyleBackColor = true;
            this.btnDeployBaseOnNewServer.Click += new System.EventHandler(this.btnDeployBaseOnNewServer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Car1012;
            this.pictureBox1.Location = new System.Drawing.Point(366, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // NewConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(804, 257);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeployBaseOnNewServer);
            this.Controls.Add(this.lbConnectionStringTitle);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_IntegratedSecurity);
            this.Controls.Add(this.cb_Servers);
            this.Controls.Add(lb_Country);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewConnectionForm";
            this.Text = "Simple Racing Simulator";
            this.Load += new System.EventHandler(this.NewConnectionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Servers;
        private System.Windows.Forms.CheckBox cb_IntegratedSecurity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDeployBaseOnNewServer;
        private System.Windows.Forms.Label lbConnectionStringTitle;
        private System.Windows.Forms.Label ServerLoginErrorText;
        private System.Windows.Forms.Label ServerPasswordErrorText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}