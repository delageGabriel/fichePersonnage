using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    class ImageClasse
    {
        public Bitmap GetUneImage()
        {
            Bitmap uneImage = new Bitmap(@"C:\Users\Utilisateur\source\repos\delageGabriel\fichePersonnage\fichePersonnage\img\sansAvatar.png");
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Choisissez votre image";
            opf.Filter = "JPEG|*.jpg|PNG|*.png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap imageRecuperee = new Bitmap(opf.FileName);
                Bitmap imageRedimensionner = new Bitmap(imageRecuperee, new Size(200, 200));
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
