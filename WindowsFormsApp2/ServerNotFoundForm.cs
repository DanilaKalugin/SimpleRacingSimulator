using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ServerNotFoundForm : Form
    {
        public ServerNotFoundForm()
        {
            InitializeComponent();
        }

        private void btnDeployingDenied_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDeployungAccepted_Click(object sender, EventArgs e)
        {
            NewConnectionForm form = new NewConnectionForm();
            form.ShowDialog();
        }
    }
}