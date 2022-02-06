using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class WorkWithImages
    {
        public static void GetNewImage(PictureBox pb, OpenFileDialog openFileDialog)
        {
            while (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                ErrorForm error = new ErrorForm("Image not selected", Properties.Resources.Stop);
                error.ShowDialog();
            }
            pb.Image = Image.FromFile(openFileDialog.FileName);
        }

        public static void SaveNewImage(PictureBox pb, OpenFileDialog openFileDialog, string path, int number)
        {
            pb.Image = null;
            string NewCarImageTitle = openFileDialog.FileName;
            openFileDialog.Dispose();
            openFileDialog.Reset();
            File.Copy(NewCarImageTitle, path + number.ToString("0000") + ".png");
        }

        public static void DeleteImage(PictureBox pb, string path, int number)
        {
            pb.Image = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete(path + number.ToString("0000") + ".png");
        }
    }
}