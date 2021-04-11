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
        private ClasseIni fichierIniPays = new ClasseIni(@"C:\Users\Utilisateur\source\repos\delageGabriel\fichePersonnage\fichePersonnage\fichiersIni\pays.ini");
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
            bool derniereLettreConsonne = false;
            string paysChoisisAleatoirement = PaysAleatoire(listDesPays);
            int indexDerniereLettre = Convert.ToInt32(paysChoisisAleatoirement.Length) - 1;
            string premiereLettre = paysChoisisAleatoirement.Substring(0);
            string derniereLettre = paysChoisisAleatoirement.Substring(indexDerniereLettre);
            string prepositionRetourne = "";
            string premiereLettreTrouvee = "";
            string dernierLettreTrouvee = "";

            // Première lettre si voyelle
            for (int i = 0; i < voyelles.Count; i++)
            {
                if (voyelles[i] == premiereLettre)
                {
                    premiereLettreTrouvee = voyelles[i];
                    premiereLettreVoyelle = true;
                }
            }

            // Dernière lettre si voyelle
            for (int i = 0; i < voyelles.Count; i++)
            {
                if (voyelles[i] == derniereLettre)
                {
                    dernierLettreTrouvee = voyelles[i].ToLower();
                    derniereLettreVoyelle = true;
                }
            }

            for (int j = 0; j < consonnes.Count; j++)
            {
                if (consonnes[j] == derniereLettre)
                {
                    dernierLettreTrouvee = consonnes[j].ToLower();
                    derniereLettreConsonne = true;
                }
            }

            if (premiereLettreVoyelle)
            {
                preposition = "d'";
            }
            else if(derniereLettreVoyelle)
            {
                preposition = "de";
            }
            else if(derniereLettreConsonne && dernierLettreTrouvee == "s")
            {
                preposition = "des";
            }
            else if(derniereLettreConsonne || paysChoisisAleatoirement == "Mexique" || paysChoisisAleatoirement == "Mozambique" || paysChoisisAleatoirement == "Cambodge")
            {
                preposition = "du";
            }
            prepositionRetourne = preposition;
            return prepositionRetourne;
        }

        public void GenererBackGroundGarcon(RichTextBox laRichTexBox, TextBox unBackGroundPrenom, TextBox unBackGroundNom)
        {
            List<string> listPaysBackground = new List<string>();
            string paysChoisisAleatoirement = PaysAleatoire(listPaysBackground);
            string preposition = "";
            string article = RecherchePreposition(listPaysBackground, preposition);
            string backgroundHomme = $"{unBackGroundPrenom} est un jeune homme originaire {article} {paysChoisisAleatoirement}";
            laRichTexBox.Text = backgroundHomme;
        }
    }
}
