using Kursach5.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DivisionEditingForm : Form
    {
        private readonly CarsBL carsBL;
        public string DivisionForChanging;
        bool UpdatingExistingDivision;
        List<string> divisions;
        public DivisionEditingForm()
        {
            InitializeComponent();
            carsBL = new CarsBL();
            Text = "Adding a new division";
            UpdatingExistingDivision = false;
            divisions = carsBL.GetDivisionsList().ToList();
        }

        public DivisionEditingForm(string Division)
        {
            InitializeComponent();
            carsBL = new CarsBL();
            DivisionForChanging = Division;
            Text = "Changing division title";
            UpdatingExistingDivision = true;
            divisions = carsBL.GetDivisionsList().ToList();
            newDivisionTitle.Text = DivisionForChanging;
        }

        private void newCarShortTitle_Validating(object sender, CancelEventArgs e)
        {
            if (divisions.IndexOf(newDivisionTitle.Text) != -1 && newDivisionTitle.Text != DivisionForChanging)
            {
                e.Cancel = true;
                newDivisionTitle.BackColor = Color.Red;
                DivisionTitleErrorText.Text = "Error: This division already exists";
            }
            else
            {
                e.Cancel = false;
                newDivisionTitle.BackColor = Color.FromArgb(40,40,40);
                DivisionTitleErrorText.Text = "";
            }
        }

        private void btnCancelSaving_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Close();
            }
        }

        private void btnSaveDivision_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (newDivisionTitle.Text == "")
                {
                    newDivisionTitle.BackColor = Color.Red;
                    DivisionTitleErrorText.Text = "Error: Division must have a title";
                    DialogResult = DialogResult.None;
                }
                else
                {
                    if (UpdatingExistingDivision)
                    {
                        carsBL.UpdateDivision(DivisionForChanging, newDivisionTitle.Text);
                    }
                    else
                    {
                        carsBL.AddDivision(newDivisionTitle.Text);
                    }
                    DivisionForChanging = newDivisionTitle.Text;
                }
            }
        }
    }
}