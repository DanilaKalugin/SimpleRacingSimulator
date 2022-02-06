namespace WindowsFormsApp2
{
    partial class StatisticsForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDescending = new System.Windows.Forms.Button();
            this.btnToggleStats = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbValue_h = new System.Windows.Forms.Label();
            this.lbKey_h = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lbPlace_h = new System.Windows.Forms.Label();
            this.lbPlace_1 = new System.Windows.Forms.Label();
            this.lbPlace_2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.progressBar2 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.progressBar3 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.progressBar4 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.progressBar5 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDescending);
            this.splitContainer1.Panel1.Controls.Add(this.btnToggleStats);
            this.splitContainer1.Panel1.Controls.Add(this.lblHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 512);
            this.splitContainer1.SplitterDistance = 28;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnDescending
            // 
            this.btnDescending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescending.FlatAppearance.BorderSize = 0;
            this.btnDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescending.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnDescending.ForeColor = System.Drawing.Color.White;
            this.btnDescending.Location = new System.Drawing.Point(1231, 5);
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(352, 23);
            this.btnDescending.TabIndex = 9;
            this.btnDescending.TabStop = false;
            this.btnDescending.Text = "Descending";
            this.btnDescending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescending.UseMnemonic = false;
            this.btnDescending.UseVisualStyleBackColor = true;
            this.btnDescending.Click += new System.EventHandler(this.btnDescending_Click);
            // 
            // btnToggleStats
            // 
            this.btnToggleStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleStats.FlatAppearance.BorderSize = 0;
            this.btnToggleStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleStats.Font = new System.Drawing.Font("Forza Book", 10F);
            this.btnToggleStats.ForeColor = System.Drawing.Color.White;
            this.btnToggleStats.Location = new System.Drawing.Point(873, 6);
            this.btnToggleStats.Name = "btnToggleStats";
            this.btnToggleStats.Size = new System.Drawing.Size(352, 23);
            this.btnToggleStats.TabIndex = 8;
            this.btnToggleStats.TabStop = false;
            this.btnToggleStats.Text = "Ascending";
            this.btnToggleStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleStats.UseMnemonic = false;
            this.btnToggleStats.UseVisualStyleBackColor = true;
            this.btnToggleStats.Click += new System.EventHandler(this.btnToggleStats_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Forza Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(867, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Cars sorted by engine power";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.88358F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.60848F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.96062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.18805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.96062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.398635F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbValue_h, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbKey_h, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBar1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPlace_h, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPlace_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPlace_2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBar4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.progressBar5, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Forza Medium", 18F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox2, 2);
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(873, 452);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(700, 27);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Forza Medium", 14F);
            this.label21.Location = new System.Drawing.Point(330, 449);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(537, 31);
            this.label21.TabIndex = 31;
            this.label21.Text = "Objects:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Forza Medium", 14F);
            this.label20.Location = new System.Drawing.Point(330, 419);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(537, 30);
            this.label20.TabIndex = 29;
            this.label20.Text = "Sort by:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValue_h
            // 
            this.lbValue_h.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbValue_h.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lbValue_h.Location = new System.Drawing.Point(873, 0);
            this.lbValue_h.Name = "lbValue_h";
            this.lbValue_h.Size = new System.Drawing.Size(157, 59);
            this.lbValue_h.TabIndex = 28;
            this.lbValue_h.Text = "Power";
            this.lbValue_h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKey_h
            // 
            this.lbKey_h.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbKey_h.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lbKey_h.Location = new System.Drawing.Point(330, 0);
            this.lbKey_h.Name = "lbKey_h";
            this.lbKey_h.Size = new System.Drawing.Size(537, 59);
            this.lbKey_h.TabIndex = 27;
            this.lbKey_h.Text = "Car";
            this.lbKey_h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(1576, 59);
            this.vScrollBar1.Maximum = 95;
            this.vScrollBar1.Name = "vScrollBar1";
            this.tableLayoutPanel1.SetRowSpan(this.vScrollBar1, 5);
            this.vScrollBar1.Size = new System.Drawing.Size(24, 360);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 1;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // lbPlace_h
            // 
            this.lbPlace_h.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlace_h.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lbPlace_h.Location = new System.Drawing.Point(3, 0);
            this.lbPlace_h.Name = "lbPlace_h";
            this.lbPlace_h.Size = new System.Drawing.Size(136, 59);
            this.lbPlace_h.TabIndex = 1;
            this.lbPlace_h.Text = "Place";
            this.lbPlace_h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlace_1
            // 
            this.lbPlace_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlace_1.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lbPlace_1.Location = new System.Drawing.Point(3, 59);
            this.lbPlace_1.Name = "lbPlace_1";
            this.lbPlace_1.Size = new System.Drawing.Size(136, 72);
            this.lbPlace_1.TabIndex = 2;
            this.lbPlace_1.Text = "1";
            this.lbPlace_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlace_2
            // 
            this.lbPlace_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlace_2.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.lbPlace_2.Location = new System.Drawing.Point(3, 131);
            this.lbPlace_2.Name = "lbPlace_2";
            this.lbPlace_2.Size = new System.Drawing.Size(136, 72);
            this.lbPlace_2.TabIndex = 3;
            this.lbPlace_2.Text = "2";
            this.lbPlace_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 72);
            this.label4.TabIndex = 4;
            this.label4.Text = "3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 72);
            this.label5.TabIndex = 5;
            this.label5.Text = "4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 72);
            this.label6.TabIndex = 6;
            this.label6.Text = "5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(145, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(145, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(145, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(145, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(179, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(145, 350);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(179, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BarOffset = 1;
            this.progressBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar1.Caption = "Progress";
            this.progressBar1.CaptionColor = System.Drawing.Color.Black;
            this.progressBar1.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.progressBar1.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar1.ChangeByMouse = false;
            this.progressBar1.DashSpace = 0;
            this.progressBar1.DashWidth = 5;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar1.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar1.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar1.EdgeWidth = 0;
            this.progressBar1.FloodPercentage = 1F;
            this.progressBar1.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Invert = false;
            this.progressBar1.Location = new System.Drawing.Point(1041, 67);
            this.progressBar1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar1.Margin = new System.Windows.Forms.Padding(8);
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.progressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar1.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar1.SecondColor = System.Drawing.Color.White;
            this.progressBar1.Shadow = true;
            this.progressBar1.ShadowOffset = 1;
            this.progressBar1.Size = new System.Drawing.Size(527, 56);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.TextAntialias = true;
            this.progressBar1.Value = 33;
            // 
            // progressBar2
            // 
            this.progressBar2.BarOffset = 1;
            this.progressBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar2.Caption = "Progress";
            this.progressBar2.CaptionColor = System.Drawing.Color.Black;
            this.progressBar2.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.progressBar2.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar2.ChangeByMouse = false;
            this.progressBar2.DashSpace = 0;
            this.progressBar2.DashWidth = 5;
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar2.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar2.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar2.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar2.EdgeWidth = 0;
            this.progressBar2.FloodPercentage = 1F;
            this.progressBar2.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.progressBar2.ForeColor = System.Drawing.Color.White;
            this.progressBar2.Invert = false;
            this.progressBar2.Location = new System.Drawing.Point(1041, 139);
            this.progressBar2.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar2.Margin = new System.Windows.Forms.Padding(8);
            this.progressBar2.Maximum = 100;
            this.progressBar2.Minimum = 0;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.progressBar2.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar2.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar2.SecondColor = System.Drawing.Color.White;
            this.progressBar2.Shadow = true;
            this.progressBar2.ShadowOffset = 1;
            this.progressBar2.Size = new System.Drawing.Size(527, 56);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 13;
            this.progressBar2.TextAntialias = true;
            this.progressBar2.Value = 33;
            // 
            // progressBar3
            // 
            this.progressBar3.BarOffset = 1;
            this.progressBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar3.Caption = "Progress";
            this.progressBar3.CaptionColor = System.Drawing.Color.Black;
            this.progressBar3.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.progressBar3.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar3.ChangeByMouse = false;
            this.progressBar3.DashSpace = 0;
            this.progressBar3.DashWidth = 5;
            this.progressBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar3.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar3.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar3.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar3.EdgeWidth = 0;
            this.progressBar3.FloodPercentage = 1F;
            this.progressBar3.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.progressBar3.ForeColor = System.Drawing.Color.White;
            this.progressBar3.Invert = false;
            this.progressBar3.Location = new System.Drawing.Point(1041, 211);
            this.progressBar3.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar3.Margin = new System.Windows.Forms.Padding(8);
            this.progressBar3.Maximum = 100;
            this.progressBar3.Minimum = 0;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.progressBar3.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar3.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar3.SecondColor = System.Drawing.Color.White;
            this.progressBar3.Shadow = true;
            this.progressBar3.ShadowOffset = 1;
            this.progressBar3.Size = new System.Drawing.Size(527, 56);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 14;
            this.progressBar3.TextAntialias = true;
            this.progressBar3.Value = 33;
            // 
            // progressBar4
            // 
            this.progressBar4.BarOffset = 1;
            this.progressBar4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar4.Caption = "Progress";
            this.progressBar4.CaptionColor = System.Drawing.Color.Black;
            this.progressBar4.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.progressBar4.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar4.ChangeByMouse = false;
            this.progressBar4.DashSpace = 0;
            this.progressBar4.DashWidth = 5;
            this.progressBar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar4.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar4.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar4.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar4.EdgeWidth = 0;
            this.progressBar4.FloodPercentage = 1F;
            this.progressBar4.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.progressBar4.ForeColor = System.Drawing.Color.White;
            this.progressBar4.Invert = false;
            this.progressBar4.Location = new System.Drawing.Point(1041, 283);
            this.progressBar4.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar4.Margin = new System.Windows.Forms.Padding(8);
            this.progressBar4.Maximum = 100;
            this.progressBar4.Minimum = 0;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.progressBar4.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar4.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar4.SecondColor = System.Drawing.Color.White;
            this.progressBar4.Shadow = true;
            this.progressBar4.ShadowOffset = 1;
            this.progressBar4.Size = new System.Drawing.Size(527, 56);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 15;
            this.progressBar4.TextAntialias = true;
            this.progressBar4.Value = 33;
            // 
            // progressBar5
            // 
            this.progressBar5.BarOffset = 1;
            this.progressBar5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar5.Caption = "Progress";
            this.progressBar5.CaptionColor = System.Drawing.Color.Black;
            this.progressBar5.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.progressBar5.CaptionShadowColor = System.Drawing.Color.White;
            this.progressBar5.ChangeByMouse = false;
            this.progressBar5.DashSpace = 0;
            this.progressBar5.DashWidth = 5;
            this.progressBar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar5.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.progressBar5.EdgeColor = System.Drawing.Color.Gray;
            this.progressBar5.EdgeLightColor = System.Drawing.Color.LightGray;
            this.progressBar5.EdgeWidth = 0;
            this.progressBar5.FloodPercentage = 1F;
            this.progressBar5.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.progressBar5.ForeColor = System.Drawing.Color.White;
            this.progressBar5.Invert = false;
            this.progressBar5.Location = new System.Drawing.Point(1041, 355);
            this.progressBar5.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar5.Margin = new System.Windows.Forms.Padding(8);
            this.progressBar5.Maximum = 100;
            this.progressBar5.Minimum = 0;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.progressBar5.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar5.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.progressBar5.SecondColor = System.Drawing.Color.White;
            this.progressBar5.Shadow = true;
            this.progressBar5.ShadowOffset = 1;
            this.progressBar5.Size = new System.Drawing.Size(527, 56);
            this.progressBar5.Step = 1;
            this.progressBar5.TabIndex = 16;
            this.progressBar5.TextAntialias = true;
            this.progressBar5.Value = 33;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(330, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(537, 72);
            this.label9.TabIndex = 18;
            this.label9.Text = "1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(330, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(537, 72);
            this.label10.TabIndex = 19;
            this.label10.Text = "1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(330, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(537, 72);
            this.label8.TabIndex = 17;
            this.label8.Text = "1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(330, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(537, 72);
            this.label12.TabIndex = 21;
            this.label12.Text = "1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Forza Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(330, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(537, 72);
            this.label11.TabIndex = 20;
            this.label11.Text = "1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Forza Medium", 21F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(873, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 72);
            this.label13.TabIndex = 22;
            this.label13.Text = "1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Forza Medium", 21F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(873, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 72);
            this.label14.TabIndex = 23;
            this.label14.Text = "1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Forza Medium", 21F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(873, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 72);
            this.label17.TabIndex = 26;
            this.label17.Text = "1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Forza Medium", 21F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(873, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 72);
            this.label16.TabIndex = 25;
            this.label16.Text = "1";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Forza Medium", 21F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(873, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 72);
            this.label15.TabIndex = 24;
            this.label15.Text = "1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Forza Medium", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(873, 422);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(700, 27);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1600, 512);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lbPlace_h;
        private System.Windows.Forms.Label lbPlace_1;
        private System.Windows.Forms.Label lbPlace_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar1;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar2;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar3;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar4;
        private ExtendedDotNET.Controls.Progress.ProgressBar progressBar5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbValue_h;
        private System.Windows.Forms.Label lbKey_h;
        private System.Windows.Forms.Button btnDescending;
        private System.Windows.Forms.Button btnToggleStats;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label21;
    }
}