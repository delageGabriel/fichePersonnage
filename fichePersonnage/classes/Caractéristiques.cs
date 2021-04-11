using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    class Caractéristiques
    {
        // Attributs
        private int nbPoints;

        // Constructeur
        public Caractéristiques(int nbPoints)
        {
            this.NbPoints = nbPoints;
        }

        // Accesseurs/Mutateurs
        public int NbPoints { get => nbPoints; set => nbPoints = value; }

        public void checkLimitePointsAventures(TextBox txbPhysique, TextBox txbSocial, TextBox txbMental, TextBox nbPointsARepartir)
        {
            string strSocial = txbSocial.ToString();
            if (Int32.Parse(strSocial) >= 100)
            {
                MessageBox.Show("Le nombre de point attribué est trop élevé");
                txbSocial.Clear();
            }

            string strMental = txbMental.ToString();
            if (Int32.Parse(strMental) >= 100)
            {
                MessageBox.Show("Le nombre de point attribué est trop élevé");
                txbSocial.Clear();
            }
        }

        public void checkRepartitionsPointsPhysique(TextBox txbPhysique, TextBox nbPointsARepartir)
        {
            try
            {
                if (Convert.ToInt32(txbPhysique.Text) >= 100)
                {
                    MessageBox.Show("Le nombre de point attribué est trop élevé");
                    txbPhysique.Text = null;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
