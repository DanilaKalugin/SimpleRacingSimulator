namespace WindowsFormsApp2
{
    partial class ServerNotFoundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerNotFoundForm));
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnDeployingDenied = new System.Windows.Forms.Button();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.btnDeployungAccepted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(138, 12);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(348, 30);
            this.lbMessage.TabIndex = 8;
            this.lbMessage.Text = "Server not found";
            // 
            // btnDeployingDenied
            // 
            this.btnDeployingDenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeployingDenied.FlatAppearance.BorderSize = 0;
            this.btnDeployingDenied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployingDenied.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployingDenied.ForeColor = System.Drawing.Color.White;
            this.btnDeployingDenied.Location = new System.Drawing.Point(357, 110);
            this.btnDeployingDenied.Name = "btnDeployingDenied";
            this.btnDeployingDenied.Size = new System.Drawing.Size(129, 31);
            this.btnDeployingDenied.TabIndex = 7;
            this.btnDeployingDenied.Text = "NO";
            this.btnDeployingDenied.UseVisualStyleBackColor = false;
            this.btnDeployingDenied.Click += new System.EventHandler(this.btnDeployingDenied_Click);
            // 
            // pbError
            // 
            this.pbError.Image = global::WindowsFormsApp2.Properties.Resources.Error;
            this.pbError.Location = new System.Drawing.Point(12, 12);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(120, 120);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbError.TabIndex = 9;
            this.pbError.TabStop = false;
            // 
            // btnDeployungAccepted
            // 
            this.btnDeployungAccepted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeployungAccepted.FlatAppearance.BorderSize = 0;
            this.btnDeployungAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployungAccepted.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployungAccepted.ForeColor = System.Drawing.Color.White;
            this.btnDeployungAccepted.Location = new System.Drawing.Point(142, 110);
            this.btnDeployungAccepted.Name = "btnDeployungAccepted";
            this.btnDeployungAccepted.Size = new System.Drawing.Size(129, 31);
            this.btnDeployungAccepted.TabIndex = 7;
            this.btnDeployungAccepted.Text = "YES";
            this.btnDeployungAccepted.UseVisualStyleBackColor = false;
            this.btnDeployungAccepted.Click += new System.EventHandler(this.btnDeployungAccepted_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Forza Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Do you want to deploy a database on your server?";
            // 
            // ServerNotFoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(498, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnDeployungAccepted);
            this.Controls.Add(this.btnDeployingDenied);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerNotFoundForm";
            this.ShowInTaskbar = false;
            this.Text = "Simple racing simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnDeployingDenied;
        private System.Windows.Forms.Button btnDeployungAccepted;
        private System.Windows.Forms.Label label1;
    }
}