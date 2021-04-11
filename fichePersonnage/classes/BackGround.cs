using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    class BackGround
    {
        // Attributs
        private string backGround;
        private List<string> listBackGround = new List<string>();

        // Constructeur
        public BackGround(string backGround)
        {
            this.BackGroundPersonnage = backGround;
        }

        // Accesseur/Mutateur
        public string BackGroundPersonnage { get => backGround; set => backGround = value; }

        public void GenererBackGroundGarcon(RichTextBox laRichTexBox, TextBox unBackGroundPrenom, TextBox unBackGroundNom)
        {
            Random nbRandom = new Random();
            string bgUn = $"{unBackGroundPrenom.Text} est issu d'une famille de prolo, dernier héritier de la maison {unBackGroundNom.Text}, il est toutefois désemparé devant une femme. " +
                $"Toutefois, il travaille sur ce point et a décidé de commencer à go muscu, pour honorer la mémoire de ses ancêtres, la plupart sont morts dans des guerres. " +
                $"Malheureusement ses muscles ne se sont pas assez développés pour l'aventure qu'il va endurer, mais ses réflexes hors du commun qui s'activent seulement lorsqu'il est " +
                $"réellement en danger peuvent l'aider quand même. A part les femoïdes, {unBackGroundPrenom.Text} s'en sort assez bien avec les relations sociales, en faisant une " +
                $"personne presque normale.";
            string bgDeux = $"Élevé dans une famille pauvre, {unBackGroundPrenom.Text} finit par décrocher son diplôme et rentrer dans une école de cinéma. Débutant avec des stages dans de petites productions, " +
                "il s'est fait une petite renommée dans le milieu cinématographique.";

            listBackGround.Add(bgUn);
            listBackGround.Add(bgDeux);

            int nbAleatoire = nbRandom.Next((listBackGround.Count));

            laRichTexBox.Text = listBackGround[nbAleatoire];
        }
    }
}
