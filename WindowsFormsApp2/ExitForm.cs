using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            ExitFormMainImage.Image = Properties.Resources.Car1008;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ExitFormMainImage.Image = Properties.Resources.Car1007;
        }

        private void btnExitCancelled_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnExitCancelled_MouseMove(object sender, MouseEventArgs e)
        {
            ExitFormMainImage.Image = Properties.Resources.Car1006;
        }

        private void btnExitCancelled_MouseLeave(object sender, EventArgs e)
        {
            ExitFormMainImage.Image = Properties.Resources.Car1007;
        }

        private void ExitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}