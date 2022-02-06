namespace WindowsFormsApp2
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExitCancelled = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.ExitFormMainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitFormMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(218, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "YES";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // btnExitCancelled
            // 
            this.btnExitCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitCancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExitCancelled.FlatAppearance.BorderSize = 0;
            this.btnExitCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitCancelled.Font = new System.Drawing.Font("Forza Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCancelled.ForeColor = System.Drawing.Color.White;
            this.btnExitCancelled.Location = new System.Drawing.Point(432, 476);
            this.btnExitCancelled.Name = "btnExitCancelled";
            this.btnExitCancelled.Size = new System.Drawing.Size(192, 31);
            this.btnExitCancelled.TabIndex = 7;
            this.btnExitCancelled.Text = "NO";
            this.btnExitCancelled.UseVisualStyleBackColor = false;
            this.btnExitCancelled.Click += new System.EventHandler(this.btnExitCancelled_Click);
            this.btnExitCancelled.MouseLeave += new System.EventHandler(this.btnExitCancelled_MouseLeave);
            this.btnExitCancelled.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExitCancelled_MouseMove);
            // 
            // ErrorText
            // 
            this.ErrorText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorText.Font = new System.Drawing.Font("Forza Medium", 18F);
            this.ErrorText.ForeColor = System.Drawing.Color.White;
            this.ErrorText.Location = new System.Drawing.Point(12, 411);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(812, 62);
            this.ErrorText.TabIndex = 9;
            this.ErrorText.Text = "Are you sure you want to quit the program?";
            // 
            // ExitFormMainImage
            // 
            this.ExitFormMainImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitFormMainImage.Image = global::WindowsFormsApp2.Properties.Resources.Car1007;
            this.ExitFormMainImage.Location = new System.Drawing.Point(12, 9);
            this.ExitFormMainImage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ExitFormMainImage.Name = "ExitFormMainImage";
            this.ExitFormMainImage.Size = new System.Drawing.Size(812, 399);
            this.ExitFormMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitFormMainImage.TabIndex = 8;
            this.ExitFormMainImage.TabStop = false;
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 519);
            this.Controls.Add(this.btnExitCancelled);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ExitFormMainImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExitForm";
            this.ShowInTaskbar = false;
            this.Text = "Exit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExitForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ExitFormMainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExitCancelled;
        private System.Windows.Forms.PictureBox ExitFormMainImage;
        private System.Windows.Forms.Label ErrorText;
    }
}