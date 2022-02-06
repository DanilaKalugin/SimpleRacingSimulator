using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class MouseActions
    {
        public enum ItemType { Group, MenuItem }
        public static void MouseEnter(Label sender, ItemType type)
        {
            switch (type)
            {
                case ItemType.Group:
                    {
                        if (sender.Text != "")
                        {
                            sender.BorderStyle = BorderStyle.FixedSingle;
                        }
                        else
                        {
                            sender.BorderStyle = BorderStyle.None;
                        }
                        break;
                    }
                case ItemType.MenuItem:
                    {
                        sender.BackColor = Color.FromArgb(5, 77, 126);
                        break;
                    }
            }

        }

        public static void MouseEnter(Button sender)
        {
            sender.BackColor = Color.FromArgb(5, 77, 126);
        }

        public static void MouseLeave(Label sender, ItemType type)
        {
            switch (type)
            {
                case ItemType.Group:
                    {
                        sender.BorderStyle = BorderStyle.None;
                        break;
                    }
                case ItemType.MenuItem:
                    {
                        sender.BackColor = Color.Black;
                        break;
                    }
            }

        }

        public static void MouseLeave(Button sender)
        {
            sender.BackColor = Color.FromArgb(30, 30, 30);
        }

        public static void MouseEnter(RadioButton sender)
        {
            sender.BackColor = Color.FromArgb(5, 77, 126);
        }

        public static void MouseLeave(RadioButton sender)
        {
            sender.BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}