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
        private string préposition;
        private ClasseIni fichierIniPays = new ClasseIni(@"\fichePersonnage\fichiersIni\pays.ini");
        private List<string> listBackGround = new List<string>();

        // Constructeur
        public BackGround(string backGround)
        {
            this.BackGroundPersonnage = backGround;
            this.Préposition = préposition;
        }

        // Accesseur/Mutateur
        public string BackGroundPersonnage { get => backGround; set => backGround = value; }
        public string Préposition { get => préposition; set => préposition = value; }

        public string PaysAleatoire(List<string> listPays)
        {
            bool play = true;
            Random nbAleatoire = new Random();
            int i = 1;
            string fmt = "000.##";
            string paysRetourner;

            while (play)
            {
                string repertoireALire = fichierIniPays.LireIni("PAYS", "NBPays" + i.ToString(fmt));
                string nouveauPays = repertoireALire;
                listPays.Add(nouveauPays);
                i++;

                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbRandom = nbAleatoire.Next((listPays.Count));
            paysRetourner = listPays[nbRandom];
            return paysRetourner;
        }

        public string RecherchePreposition(List<string> listDesPays, string preposition)
        {
            List<string> voyelles = new List<string> { "A", "E", "I", "O", "U", "Y" };
            List<string> consonnes = new List<string> { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z" };
            bool premiereLettreVoyelle = false;
            bool derniereLettreVoyelle = false;
            bool premiereLettreConsonne = false;
            bool derniereLettreConsonne = false;
            string paysChoisisAleatoirement = PaysAleatoire(listDesPays);
            int indexDerniereLettre = Convert.ToInt32(paysChoisisAleatoirement.Length) - 1;
            string premiereLettre = paysChoisisAleatoirement.Substring(0);
            string derniereLettre = paysChoisisAleatoirement.Substring(indexDerniereLettre);
            string premiereLettreTrouvee;
            string dernierLettreTrouvee;

            for (int i = 0; i < voyelles.Count; i++)
            {
                if (listDesPays[i] == premiereLettre)
                {
                    premiereLettreTrouvee = listDesPays[i];
                    premiereLettreVoyelle = true;
                }
                else if (listDesPays[i] == derniereLettre)
                {
                    dernierLettreTrouvee = listDesPays[i].ToLower();
                    derniereLettreVoyelle = true;
                }
            }

            for (int j = 0; j < consonnes.Count; j++)
            {
                if (listDesPays[j] == premiereLettre)
                {
                    premiereLettreTrouvee = listDesPays[j];
                    premiereLettreConsonne = true;
                }
                else if (listDesPays[j] == derniereLettre)
                {
                    dernierLettreTrouvee = listDesPays[j].ToLower();
                    derniereLettreConsonne = true;
                }
            }

            if (premiereLettreVoyelle && derniereLettreVoyelle)
            {
                preposition = "d'";
            }

            if(!premiereLettreVoyelle && derniereLettreVoyelle)
            {
                preposition = "de";
            }
        }

        public void GenererBackGroundGarcon(RichTextBox laRichTexBox, TextBox unBackGroundPrenom, TextBox unBackGroundNom)
        {
            Random nbRandom = new Random();
            string backgroundHomme = $"{unBackGroundPrenom} est un jeune homme originaire de ";

            int nbAleatoire = nbRandom.Next((listBackGround.Count));
            laRichTexBox.Text = listBackGround[nbAleatoire];
        }
    }
}
