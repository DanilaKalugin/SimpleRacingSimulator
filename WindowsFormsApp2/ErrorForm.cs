using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string Message, Image image)
        {
            InitializeComponent();
            lbMessage.Text = Message;
            pbError.Image = image;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}