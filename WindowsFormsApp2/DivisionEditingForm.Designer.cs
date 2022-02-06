namespace WindowsFormsApp2
{
    partial class DivisionEditingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivisionEditingForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.newDivisionTitle_H = new System.Windows.Forms.Label();
            this.newDivisionTitle = new System.Windows.Forms.TextBox();
            this.btnCancelSaving = new MetroFramework.Controls.MetroButton();
            this.btnSaveDivision = new MetroFramework.Controls.MetroButton();
            this.DivisionTitleErrorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // newDivisionTitle_H
            // 
            this.newDivisionTitle_H.AutoSize = true;
            this.newDivisionTitle_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newDivisionTitle_H.Font = new System.Drawing.Font("Forza Light", 16F);
            this.newDivisionTitle_H.ForeColor = System.Drawing.Color.White;
            this.newDivisionTitle_H.Location = new System.Drawing.Point(27, 20);
            this.newDivisionTitle_H.Name = "newDivisionTitle_H";
            this.newDivisionTitle_H.Size = new System.Drawing.Size(59, 26);
            this.newDivisionTitle_H.TabIndex = 22;
            this.newDivisionTitle_H.Text = "Title:";
            // 
            // newDivisionTitle
            // 
            this.newDivisionTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newDivisionTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newDivisionTitle.Font = new System.Drawing.Font("Forza Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDivisionTitle.ForeColor = System.Drawing.Color.White;
            this.newDivisionTitle.Location = new System.Drawing.Point(120, 20);
            this.newDivisionTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.newDivisionTitle.MaxLength = 25;
            this.newDivisionTitle.Name = "newDivisionTitle";
            this.newDivisionTitle.Size = new System.Drawing.Size(327, 33);
            this.newDivisionTitle.TabIndex = 21;
            this.newDivisionTitle.Validating += new System.ComponentModel.CancelEventHandler(this.newCarShortTitle_Validating);
            // 
            // btnCancelSaving
            // 
            this.btnCancelSaving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelSaving.Location = new System.Drawing.Point(26, 96);
            this.btnCancelSaving.Name = "btnCancelSaving";
            this.btnCancelSaving.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSaving.TabIndex = 25;
            this.btnCancelSaving.Text = "Cancel";
            this.btnCancelSaving.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancelSaving.Click += new System.EventHandler(this.btnCancelSaving_Click);
            // 
            // btnSaveDivision
            // 
            this.btnSaveDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveDivision.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveDivision.Location = new System.Drawing.Point(372, 96);
            this.btnSaveDivision.Name = "btnSaveDivision";
            this.btnSaveDivision.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDivision.TabIndex = 26;
            this.btnSaveDivision.Text = "Save";
            this.btnSaveDivision.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSaveDivision.Click += new System.EventHandler(this.btnSaveDivision_Click);
            // 
            // DivisionTitleErrorText
            // 
            this.DivisionTitleErrorText.Font = new System.Drawing.Font("Forza Light", 9F);
            this.DivisionTitleErrorText.Location = new System.Drawing.Point(29, 65);
            this.DivisionTitleErrorText.Name = "DivisionTitleErrorText";
            this.DivisionTitleErrorText.Size = new System.Drawing.Size(418, 28);
            this.DivisionTitleErrorText.TabIndex = 27;
            // 
            // DivisionEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(473, 144);
            this.Controls.Add(this.DivisionTitleErrorText);
            this.Controls.Add(this.btnSaveDivision);
            this.Controls.Add(this.btnCancelSaving);
            this.Controls.Add(this.newDivisionTitle_H);
            this.Controls.Add(this.newDivisionTitle);
            this.Font = new System.Drawing.Font("Forza Light", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DivisionEditingForm";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Text = "DivisionEditingForm";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label newDivisionTitle_H;
        private System.Windows.Forms.TextBox newDivisionTitle;
        private MetroFramework.Controls.MetroButton btnSaveDivision;
        private MetroFramework.Controls.MetroButton btnCancelSaving;
        private System.Windows.Forms.Label DivisionTitleErrorText;
    }
}