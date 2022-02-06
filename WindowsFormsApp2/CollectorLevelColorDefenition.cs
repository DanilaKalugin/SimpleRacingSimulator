using System.Drawing;

namespace WindowsFormsApp2
{
    static class CollectorLevelColorDefenition
    {   
        public static void GetCollectorLevelColor(CircularProgressBar.CircularProgressBar pb, int level)
        {
            pb.Text = level.ToString();
            switch (level)
            {
                case 1:
                    {
                        pb.ProgressColor = Color.FromArgb(0, 135, 0);
                        break;
                    }
                case 2:
                    {
                        pb.ProgressColor = Color.FromArgb(17, 67, 178);
                        break;
                    }
                case 3:
                    {
                        pb.ProgressColor = Color.FromArgb(122, 12, 172);
                        break;
                    }
                case 4:
                    {
                        pb.ProgressColor = Color.FromArgb(202, 0, 44);
                        break;
                    }
                case 5:
                    {
                        pb.ProgressColor = Color.FromArgb(219, 153, 0);
                        break;
                    }
                default:
                    {
                        pb.ProgressColor = Color.FromArgb(0, 0, 0);
                        break;
                    }
            }
            pb.InnerColor = pb.ProgressColor;
        }
    }
}