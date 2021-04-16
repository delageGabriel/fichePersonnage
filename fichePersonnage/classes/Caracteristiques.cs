using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    class Caracteristiques
    {

        public Caracteristiques()
        {

        }

        public int GetNbPointsARepartir(TextBox uneTextBox)
        {
            try
            {
                return Convert.ToInt32(uneTextBox.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return Convert.ToInt32(uneTextBox.Text);
            }
        }

        public void RepartitionPointsPVPMAleatoire(TextBox laTextBox, TextBox txtPV, TextBox txtPM)
        {
            try
            {
                int nbPointsARepartir;
                int dividendeNbPoints;
                int nbPV;
                int nbPM;
                Random chiffreRandom = new Random();
                int nbChiffreRandom = chiffreRandom.Next(9);

                // nbChiffreRandom = 0
                if(nbChiffreRandom == 0)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if(nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        txtPV.Text = dividendeNbPoints.ToString();
                        txtPM.Text = dividendeNbPoints.ToString();
                    }
                    
                }

                // nbChiffreRandom = 1

                if (nbChiffreRandom == 1)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 1;
                        nbPM = dividendeNbPoints - 1;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 2
                if(nbChiffreRandom == 2)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 1;
                        nbPM = dividendeNbPoints + 1;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 3
                if (nbChiffreRandom == 3)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 2;
                        nbPM = dividendeNbPoints - 2;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 4
                if (nbChiffreRandom == 4)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 2;
                        nbPM = dividendeNbPoints + 2;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 5
                if (nbChiffreRandom == 5)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 3;
                        nbPM = dividendeNbPoints - 3;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 6
                if (nbChiffreRandom == 6)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 3;
                        nbPM = dividendeNbPoints + 3;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }                }

                // nbChiffreRandom = 7
                if (nbChiffreRandom == 7)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 4;
                        nbPM = dividendeNbPoints - 4;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 8
                if (nbChiffreRandom == 8)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 4;
                        nbPM = dividendeNbPoints + 4;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 9
                if (nbChiffreRandom == 9)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 5;
                        nbPM = dividendeNbPoints - 5;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 10
                if (nbChiffreRandom == 10)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 5;
                        nbPM = dividendeNbPoints + 5;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 11
                if (nbChiffreRandom == 11)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 6;
                        nbPM = dividendeNbPoints - 6;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 12
                if (nbChiffreRandom == 12)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 6;
                        nbPM = dividendeNbPoints + 6;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 13
                if (nbChiffreRandom == 13)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 7;
                        nbPM = dividendeNbPoints - 7;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 14
                if (nbChiffreRandom == 14)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 7;
                        nbPM = dividendeNbPoints + 7;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 15
                if (nbChiffreRandom == 15)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 8;
                        nbPM = dividendeNbPoints - 8;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 16
                if (nbChiffreRandom == 16)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 8;
                        nbPM = dividendeNbPoints + 8;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 17
                if (nbChiffreRandom == 17)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints + 9 ;
                        nbPM = dividendeNbPoints - 9;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }

                // nbChiffreRandom = 18
                if (nbChiffreRandom == 18)
                {
                    nbPointsARepartir = GetNbPointsARepartir(laTextBox);
                    if (nbPointsARepartir < 10)
                    {
                        MessageBox.Show("Le nombre de points à distribuer est inférieur à 10.");
                    }
                    else
                    {
                        dividendeNbPoints = nbPointsARepartir / 2;
                        nbPV = dividendeNbPoints - 9;
                        nbPM = dividendeNbPoints + 9;
                        if (nbPV <= 0)
                        {
                            nbPV = 1;
                        }
                        else if (nbPM <= 0)
                        {
                            nbPM = 1;
                        }
                        txtPV.Text = nbPV.ToString();
                        txtPM.Text = nbPM.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void RepartitionCaracteristiquePrincipale(TextBox txtBoxPoints, TextBox txtPhy, TextBox txtSoc, TextBox txtMen)
        {
            try
            {
                int nbPointsARepartir;
                int dividendeNbPoints;
                int nbPhy;
                int nbSoc;
                int nbMen;
                int uneChanceSurTrois;
                Random chiffreAleatoireSurTrois = new Random();
                Random chiffreRandom = new Random();
                int nbChiffreRandom = chiffreRandom.Next(4);

                // nbChiffreRandom = 0
                if(nbChiffreRandom == 0)
                {
                    nbPointsARepartir = GetNbPointsARepartir(txtBoxPoints);
                    dividendeNbPoints = nbPointsARepartir / 3;
                    nbPhy = dividendeNbPoints;
                    nbSoc = dividendeNbPoints;
                    nbMen = dividendeNbPoints;
                    txtPhy.Text = nbPhy.ToString();
                    txtSoc.Text = nbSoc.ToString();
                    txtMen.Text = nbMen.ToString();
                }

                // nbChiffreRandom = 1
                if(nbChiffreRandom == 1)
                {
                    nbPointsARepartir = GetNbPointsARepartir(txtBoxPoints);
                    uneChanceSurTrois = chiffreAleatoireSurTrois.Next(3);
                    dividendeNbPoints = nbPointsARepartir / 3;
                    if(uneChanceSurTrois == 0)
                    {
                        nbPhy = dividendeNbPoints + 10;
                        nbSoc = dividendeNbPoints;
                        nbMen = dividendeNbPoints - 10;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                    else if(uneChanceSurTrois == 1)
                    {
                        nbPhy = dividendeNbPoints - 5;
                        nbSoc = dividendeNbPoints + 10;
                        nbMen = dividendeNbPoints - 5;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                    else if(uneChanceSurTrois == 2)
                    {
                        nbPhy = dividendeNbPoints - 10;
                        nbSoc = dividendeNbPoints;
                        nbMen = dividendeNbPoints + 10;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                }

                // nbChiffreRandom = 2
                if (nbChiffreRandom == 2)
                {
                    nbPointsARepartir = GetNbPointsARepartir(txtBoxPoints);
                    uneChanceSurTrois = chiffreAleatoireSurTrois.Next(3);
                    dividendeNbPoints = nbPointsARepartir / 3;
                    if (uneChanceSurTrois == 0)
                    {
                        nbPhy = dividendeNbPoints + 20;
                        nbSoc = dividendeNbPoints;
                        nbMen = dividendeNbPoints - 20;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                    else if (uneChanceSurTrois == 1)
                    {
                        nbPhy = dividendeNbPoints - 10;
                        nbSoc = dividendeNbPoints + 20;
                        nbMen = dividendeNbPoints - 10;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                    else if (uneChanceSurTrois == 2)
                    {
                        nbPhy = dividendeNbPoints - 20;
                        nbSoc = dividendeNbPoints;
                        nbMen = dividendeNbPoints + 20;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                }

                // nbChiffreRandom = 3
                if (nbChiffreRandom == 3)
                {
                    nbPointsARepartir = GetNbPointsARepartir(txtBoxPoints);
                    uneChanceSurTrois = chiffreAleatoireSurTrois.Next(3);
                    dividendeNbPoints = nbPointsARepartir / 3;
                    if (uneChanceSurTrois == 0)
                    {
                        nbPhy = dividendeNbPoints + 30;
                        nbSoc = dividendeNbPoints;
                        nbMen = dividendeNbPoints - 30;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                    else if (uneChanceSurTrois == 1)
                    {
                        nbPhy = dividendeNbPoints - 15;
                        nbSoc = dividendeNbPoints + 30;
                        nbMen = dividendeNbPoints - 15;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                    else if (uneChanceSurTrois == 2)
                    {
                        nbPhy = dividendeNbPoints - 30;
                        nbSoc = dividendeNbPoints;
                        nbMen = dividendeNbPoints + 30;

                        txtPhy.Text = nbPhy.ToString();
                        txtSoc.Text = nbSoc.ToString();
                        txtMen.Text = nbMen.ToString();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
