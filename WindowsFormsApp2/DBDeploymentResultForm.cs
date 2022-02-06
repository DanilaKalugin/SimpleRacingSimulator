using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DBDeploymentResultForm : Form
    {
        public DBDeploymentResultForm(bool IsSuccessful, string message)
        {
            InitializeComponent();
            pbResult.Visible = !IsSuccessful;
            lbMessage.Text = message;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DBDeploymentResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}