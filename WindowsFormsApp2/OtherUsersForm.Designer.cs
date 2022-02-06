namespace WindowsFormsApp2
{
    partial class OtherUsersForm
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
            System.Windows.Forms.Label lb_CollectorLevel;
            System.Windows.Forms.Label lb_Balance;
            System.Windows.Forms.Label lb_Name;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherUsersForm));
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtCollectorLevel = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txt_UserCountry = new System.Windows.Forms.Label();
            this.pb_UserCountry = new System.Windows.Forms.PictureBox();
            this.lb_Country = new System.Windows.Forms.Label();
            this.lbIsblocked = new System.Windows.Forms.Label();
            this.PurchaseHistory = new System.Windows.Forms.DataGridView();
            this.pbIsBlocked = new System.Windows.Forms.PictureBox();
            this.panelBlockUser = new System.Windows.Forms.Panel();
            this.lb_BlockQuestion = new System.Windows.Forms.Label();
            this.btnBlockingDenied = new System.Windows.Forms.Button();
            this.btnBlockingAccepted = new System.Windows.Forms.Button();
            this.lb_Block_H = new System.Windows.Forms.Label();
            this.panelCloseForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosingDenied = new System.Windows.Forms.Button();
            this.btnClosingAccepted = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_BigCarImage = new System.Windows.Forms.PictureBox();
            lb_CollectorLevel = new System.Windows.Forms.Label();
            lb_Balance = new System.Windows.Forms.Label();
            lb_Name = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsBlocked)).BeginInit();
            this.panelBlockUser.SuspendLayout();
            this.panelCloseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BigCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CollectorLevel
            // 
            lb_CollectorLevel.AutoSize = true;
            lb_CollectorLevel.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_CollectorLevel.ForeColor = System.Drawing.Color.White;
            lb_CollectorLevel.Location = new System.Drawing.Point(12, 61);
            lb_CollectorLevel.Name = "lb_CollectorLevel";
            lb_CollectorLevel.Size = new System.Drawing.Size(130, 19);
            lb_CollectorLevel.TabIndex = 22;
            lb_CollectorLevel.Text = "Collector level:";
            // 
            // lb_Balance
            // 
            lb_Balance.AutoSize = true;
            lb_Balance.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Balance.ForeColor = System.Drawing.Color.White;
            lb_Balance.Location = new System.Drawing.Point(12, 36);
            lb_Balance.Name = "lb_Balance";
            lb_Balance.Size = new System.Drawing.Size(78, 19);
            lb_Balance.TabIndex = 23;
            lb_Balance.Text = "Balance:";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_Name.ForeColor = System.Drawing.Color.White;
            lb_Name.Location = new System.Drawing.Point(12, 9);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new System.Drawing.Size(60, 19);
            lb_Name.TabIndex = 24;
            lb_Name.Text = "Name:";
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
            // btnBlock
            // 
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.Color.White;
            this.btnBlock.Location = new System.Drawing.Point(130, 140);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(234, 28);
            this.btnBlock.TabIndex = 31;
            this.btnBlock.Text = "Block this user";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(370, 140);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 28);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(16, 140);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 28);
            this.btnPrevious.TabIndex = 30;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtCollectorLevel
            // 
            this.txtCollectorLevel.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollectorLevel.ForeColor = System.Drawing.Color.White;
            this.txtCollectorLevel.Location = new System.Drawing.Point(148, 59);
            this.txtCollectorLevel.Name = "txtCollectorLevel";
            this.txtCollectorLevel.Size = new System.Drawing.Size(330, 23);
            this.txtCollectorLevel.TabIndex = 25;
            this.txtCollectorLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.White;
            this.txtBalance.Location = new System.Drawing.Point(148, 32);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(330, 23);
            this.txtBalance.TabIndex = 26;
            this.txtBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(148, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 23);
            this.txtName.TabIndex = 27;
            // 
            // txt_UserCountry
            // 
            this.txt_UserCountry.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserCountry.ForeColor = System.Drawing.Color.White;
            this.txt_UserCountry.Location = new System.Drawing.Point(194, 84);
            this.txt_UserCountry.Name = "txt_UserCountry";
            this.txt_UserCountry.Size = new System.Drawing.Size(284, 23);
            this.txt_UserCountry.TabIndex = 21;
            // 
            // pb_UserCountry
            // 
            this.pb_UserCountry.Location = new System.Drawing.Point(152, 83);
            this.pb_UserCountry.Name = "pb_UserCountry";
            this.pb_UserCountry.Size = new System.Drawing.Size(36, 24);
            this.pb_UserCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_UserCountry.TabIndex = 20;
            this.pb_UserCountry.TabStop = false;
            // 
            // lb_Country
            // 
            this.lb_Country.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Country.ForeColor = System.Drawing.Color.White;
            this.lb_Country.Location = new System.Drawing.Point(12, 85);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(112, 22);
            this.lb_Country.TabIndex = 19;
            this.lb_Country.Text = "Country:";
            // 
            // lbIsblocked
            // 
            this.lbIsblocked.AutoSize = true;
            this.lbIsblocked.Font = new System.Drawing.Font("Forza Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsblocked.ForeColor = System.Drawing.Color.White;
            this.lbIsblocked.Location = new System.Drawing.Point(58, 118);
            this.lbIsblocked.Name = "lbIsblocked";
            this.lbIsblocked.Size = new System.Drawing.Size(73, 19);
            this.lbIsblocked.TabIndex = 32;
            this.lbIsblocked.Text = "Blocked";
            // 
            // PurchaseHistory
            // 
            this.PurchaseHistory.AllowUserToResizeColumns = false;
            this.PurchaseHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Forza Medium", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.PurchaseHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PurchaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchaseHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Forza Medium", 9.749999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurchaseHistory.GridColor = System.Drawing.Color.WhiteSmoke;
            this.PurchaseHistory.Location = new System.Drawing.Point(12, 169);
            this.PurchaseHistory.MultiSelect = false;
            this.PurchaseHistory.Name = "PurchaseHistory";
            this.PurchaseHistory.RowHeadersVisible = false;
            this.PurchaseHistory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PurchaseHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Forza Medium", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseHistory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.PurchaseHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.PurchaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseHistory.Size = new System.Drawing.Size(776, 264);
            this.PurchaseHistory.TabIndex = 33;
            // 
            // pbIsBlocked
            // 
            this.pbIsBlocked.Location = new System.Drawing.Point(28, 118);
            this.pbIsBlocked.Name = "pbIsBlocked";
            this.pbIsBlocked.Size = new System.Drawing.Size(24, 24);
            this.pbIsBlocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsBlocked.TabIndex = 20;
            this.pbIsBlocked.TabStop = false;
            // 
            // panelBlockUser
            // 
            this.panelBlockUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelBlockUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlockUser.Controls.Add(pictureBox1);
            this.panelBlockUser.Controls.Add(this.lb_BlockQuestion);
            this.panelBlockUser.Controls.Add(this.btnBlockingDenied);
            this.panelBlockUser.Controls.Add(this.btnBlockingAccepted);
            this.panelBlockUser.Controls.Add(this.lb_Block_H);
            this.panelBlockUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBlockUser.Location = new System.Drawing.Point(504, 0);
            this.panelBlockUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelBlockUser.Name = "panelBlockUser";
            this.panelBlockUser.Size = new System.Drawing.Size(296, 450);
            this.panelBlockUser.TabIndex = 34;
            this.panelBlockUser.Visible = false;
            // 
            // lb_BlockQuestion
            // 
            this.lb_BlockQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_BlockQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_BlockQuestion.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BlockQuestion.Location = new System.Drawing.Point(1, 36);
            this.lb_BlockQuestion.Name = "lb_BlockQuestion";
            this.lb_BlockQuestion.Size = new System.Drawing.Size(290, 50);
            this.lb_BlockQuestion.TabIndex = 3;
            this.lb_BlockQuestion.Text = "Do you want to block <User>?";
            // 
            // btnBlockingDenied
            // 
            this.btnBlockingDenied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlockingDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBlockingDenied.FlatAppearance.BorderSize = 0;
            this.btnBlockingDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockingDenied.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockingDenied.ForeColor = System.Drawing.Color.White;
            this.btnBlockingDenied.Location = new System.Drawing.Point(1, 139);
            this.btnBlockingDenied.Name = "btnBlockingDenied";
            this.btnBlockingDenied.Size = new System.Drawing.Size(294, 23);
            this.btnBlockingDenied.TabIndex = 1;
            this.btnBlockingDenied.Text = "NO";
            this.btnBlockingDenied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockingDenied.UseVisualStyleBackColor = false;
            this.btnBlockingDenied.Click += new System.EventHandler(this.btnBlockingDenied_Click);
            this.btnBlockingDenied.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnBlockingDenied.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // btnBlockingAccepted
            // 
            this.btnBlockingAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlockingAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBlockingAccepted.FlatAppearance.BorderSize = 0;
            this.btnBlockingAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockingAccepted.Font = new System.Drawing.Font("Forza Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockingAccepted.ForeColor = System.Drawing.Color.White;
            this.btnBlockingAccepted.Location = new System.Drawing.Point(0, 110);
            this.btnBlockingAccepted.Name = "btnBlockingAccepted";
            this.btnBlockingAccepted.Size = new System.Drawing.Size(294, 23);
            this.btnBlockingAccepted.TabIndex = 1;
            this.btnBlockingAccepted.Text = "YES";
            this.btnBlockingAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockingAccepted.UseVisualStyleBackColor = false;
            this.btnBlockingAccepted.Click += new System.EventHandler(this.btnBlockingAccepted_Click);
            this.btnBlockingAccepted.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.btnBlockingAccepted.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
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
            this.lb_Block_H.Text = "BLOCK THIS USER?";
            // 
            // panelCloseForm
            // 
            this.panelCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCloseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCloseForm.Controls.Add(pictureBox2);
            this.panelCloseForm.Controls.Add(this.label1);
            this.panelCloseForm.Controls.Add(this.btnClosingDenied);
            this.panelCloseForm.Controls.Add(this.btnClosingAccepted);
            this.panelCloseForm.Controls.Add(this.label2);
            this.panelCloseForm.Location = new System.Drawing.Point(504, 0);
            this.panelCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelCloseForm.Name = "panelCloseForm";
            this.panelCloseForm.Size = new System.Drawing.Size(296, 450);
            this.panelCloseForm.TabIndex = 36;
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
            // pb_BigCarImage
            // 
            this.pb_BigCarImage.Location = new System.Drawing.Point(520, 12);
            this.pb_BigCarImage.Name = "pb_BigCarImage";
            this.pb_BigCarImage.Size = new System.Drawing.Size(268, 151);
            this.pb_BigCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BigCarImage.TabIndex = 37;
            this.pb_BigCarImage.TabStop = false;
            // 
            // OtherUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panelCloseForm);
            this.Controls.Add(this.panelBlockUser);
            this.Controls.Add(this.PurchaseHistory);
            this.Controls.Add(this.lbIsblocked);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCollectorLevel);
            this.Controls.Add(lb_CollectorLevel);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(lb_Balance);
            this.Controls.Add(lb_Name);
            this.Controls.Add(this.txt_UserCountry);
            this.Controls.Add(this.pbIsBlocked);
            this.Controls.Add(this.pb_UserCountry);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.pb_BigCarImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OtherUsersForm";
            this.Text = "Simple Racing Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherUsersForm_FormClosing);
            this.Load += new System.EventHandler(this.UserBlockingForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserBlockingForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsBlocked)).EndInit();
            this.panelBlockUser.ResumeLayout(false);
            this.panelCloseForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BigCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label txtCollectorLevel;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txt_UserCountry;
        private System.Windows.Forms.PictureBox pb_UserCountry;
        private System.Windows.Forms.Label lb_Country;
        private System.Windows.Forms.DataGridView PurchaseHistory;
        private System.Windows.Forms.PictureBox pbIsBlocked;
        private System.Windows.Forms.Label lbIsblocked;
        private System.Windows.Forms.Panel panelBlockUser;
        private System.Windows.Forms.Label lb_BlockQuestion;
        private System.Windows.Forms.Button btnBlockingDenied;
        private System.Windows.Forms.Button btnBlockingAccepted;
        private System.Windows.Forms.Label lb_Block_H;
        private System.Windows.Forms.Panel panelCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClosingDenied;
        private System.Windows.Forms.Button btnClosingAccepted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_BigCarImage;
    }
}