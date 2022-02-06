using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChangingTheGroupForm : Form
    {
        Label[] labels;
        List<string> groupsList;
        public int groupNumber;
        public ChangingTheGroupForm(List<string> groups, string header)
        {
            InitializeComponent();
            labels = new Label[groups.Count];
            groupsList = new List<string>();
            labelHeader.Text = "      " + header.ToUpper();
            Text = header;
            for (int i = 0; i < groups.Count - 1; i++)
            {
                groupsList.Add(groups[i + 1].ToUpper());
                labels[i] = new Label
                {
                    Location = new Point(3 + i % 5 * 200, 3 + i / 5 * 30),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Size = new Size(194, 24),
                    Text = groups[i + 1].ToUpper(),
                    Font = new Font("Forza Book", 10 - (groups[i + 1].Length / 20) - (groups[i + 1].Length - 20) / 3),
                    ForeColor = Color.White,
                    BackColor = Color.Black
                };
                labels[i].MouseEnter += MouseEnter;
                labels[i].MouseLeave += MouseLeave;
                labels[i].Click += newGroupNumber_Click;
                panel1.Controls.Add(labels[i]);
            }
            if (groupsList.Count <= 35)
            {
                if (groupsList.Count % 5 == 1)
                {
                    panel1.Height = groupsList.Count / 5 * 30;
                    Height = groupsList.Count / 5 * 30 + 160;
                }
                else
                {
                    panel1.Height = (groupsList.Count / 5 + 1) * 30;
                    Height = (groupsList.Count / 5 + 1) * 30 + 160;
                }
                Width = 1016;
            }
            else
            {
                Label l1 = new Label();
                l1.Location = new Point(0, groups.Count / 5 * 30 + 28);
                l1.Size = new Size(1, 2);
                panel1.Controls.Add(l1);
            }
        }

        private void newGroupNumber_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            groupNumber = groupsList.IndexOf(l.Text) + 1;
            DialogResult = DialogResult.OK;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            MouseActions.MouseLeave((Label)sender, MouseActions.ItemType.MenuItem);
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            MouseActions.MouseEnter((Label)sender, MouseActions.ItemType.MenuItem);
        }
    }
}