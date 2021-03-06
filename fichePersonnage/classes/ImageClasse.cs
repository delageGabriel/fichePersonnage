using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fichePersonnage
{
    class ImageClasse
    {
        public Bitmap GetUneImage()
        {
            Bitmap uneImage = new Bitmap(Path.GetFullPath("img/sansAvatar.png"));
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Choisissez votre image";
            opf.Filter = "Tous les formats(*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp|JPEG|*.jpg|PNG|*.png|BMP|*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap imageRecuperee = new Bitmap(opf.FileName);
                Bitmap imageRedimensionner = new Bitmap(imageRecuperee, new Size(300,300));
                uneImage = imageRedimensionner;
            }
            return uneImage;
        }

        public Image GetPictureBox(PictureBox unePictureBox)
        {
            return unePictureBox.Image;
        }
    }
}
