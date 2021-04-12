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
        private ClasseIni fichierIniPassionAvenir = new ClasseIni(@"C:\Users\Utilisateur\source\repos\delageGabriel\fichePersonnage\fichePersonnage\fichiersIni\passions.ini");
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listDesPays"></param>
        /// <param name="preposition"></param>
        /// <param name="paysRetrouvee"></param>
        /// <returns></returns>
        public string PaysEtPrepositionAleatoire(List<string> listDesPays, string preposition, string paysRetrouvee)
        {
            List<string> voyelles = new List<string> { "A", "E", "I", "O", "U", "Y" };
            List<string> consonnes = new List<string> { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z" };
            bool premiereLettreVoyelle = false;
            bool derniereLettreVoyelle = false;
            bool derniereLettreConsonne = false;
            string paysChoisisAleatoirement = "";
            int indexDerniereLettre =  0;
            string premiereLettre = "";
            string derniereLettre = "";
            string prepositionPlusPaysRetourne = "";
            string premiereLettreTrouvee = "";
            string dernierLettreTrouvee = "";
            bool play = true;
            Random nbAleatoire = new Random();
            int i = 1;
            string fmt = "000.##";

            while (play)
            {
                string repertoireALire = fichierIniPays.LireIni("PAYS", "NBPays" + i.ToString(fmt));
                string nouveauPays = repertoireALire;
                listDesPays.Add(nouveauPays);
                i++;

                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbRandom = nbAleatoire.Next((listDesPays.Count));
            paysChoisisAleatoirement = listDesPays[nbRandom];
            indexDerniereLettre = Convert.ToInt32(paysChoisisAleatoirement.Length) - 1;
            premiereLettre = paysChoisisAleatoirement.Substring(0, 1);
            derniereLettre = paysChoisisAleatoirement.Substring(indexDerniereLettre);
            listDesPays.Clear();

            // Première lettre si voyelle
            for (int k = 0; k < voyelles.Count; k++)
            {
                if (voyelles[k] == premiereLettre)
                {
                    premiereLettreTrouvee = voyelles[k];
                    premiereLettreVoyelle = true;
                }
            }

            // Dernière lettre si voyelle
            for (int k = 0; k < voyelles.Count; k++)
            {
                if (voyelles[k].ToLower() == derniereLettre)
                {
                    dernierLettreTrouvee = voyelles[k].ToLower();
                    derniereLettreVoyelle = true;
                }
            }

            for (int j = 0; j < consonnes.Count; j++)
            {
                if (consonnes[j].ToLower() == derniereLettre)
                {
                    dernierLettreTrouvee = consonnes[j].ToLower();
                    derniereLettreConsonne = true;
                }
            }

            if (premiereLettreVoyelle)
            {
                if(premiereLettreVoyelle && dernierLettreTrouvee == "s")
                {
                    preposition = "des";
                }
                else
                {
                    preposition = "d'";
                }                               
            }
            else if(derniereLettreVoyelle)
            {
                if(paysChoisisAleatoirement == "Mexique" || paysChoisisAleatoirement == "Mozambique" || paysChoisisAleatoirement == "Cambodge" || paysChoisisAleatoirement == "Canada")
                {
                    preposition = "du";
                }
                else
                {
                    preposition = "de";
                }
            }
            else if(derniereLettreConsonne && dernierLettreTrouvee == "s")
            {
                preposition = "des";
            }
            else if(derniereLettreConsonne)
            {
                preposition = "du";
            }

            if(preposition == "de" || preposition == "du" || preposition == "des")
            {
                prepositionPlusPaysRetourne = preposition + " " + paysChoisisAleatoirement;
            }
            else
            {
                prepositionPlusPaysRetourne = preposition + paysChoisisAleatoirement;
            }
            
            return prepositionPlusPaysRetourne;
        }

        public string PassionEtAvenireAleatoire(List<string> listDesPassions, List<string> listAvenir, string passion, string avenir)
        {
            Random nbAleatoirePassion = new Random();
            Random nbAleatoireAvenir = new Random();
            int i = 1;
            int j = 1;
            string phraseFinale = "";

            listDesPassions.Add("l'informatique");
            listDesPassions.Add("les jeux vidéo");
            listDesPassions.Add("la lecture");
            listDesPassions.Add("la musique");
            listDesPassions.Add("la peinture");
            listDesPassions.Add("le dessin");
            listDesPassions.Add("la photographie");
            listDesPassions.Add("l'histoire");
            listDesPassions.Add("la géographie");
            listDesPassions.Add("les sciences");
            listDesPassions.Add("la nature");
            listDesPassions.Add("la lithographie");
            listDesPassions.Add("les comics");
            listDesPassions.Add("le sport");
            listDesPassions.Add("les voitures");

            int nbRandomPassion = nbAleatoirePassion.Next((listDesPassions.Count));
            passion = listDesPassions[nbRandomPassion];
            listDesPassions.Clear();

            listAvenir.Add("mais il ne réussit pas et se contenta de faire un simple métier à sa portée.");
            listAvenir.Add("il parvint à arriver à son objectif et il fait désormais un travail dans sa passion.");
            listAvenir.Add("il y parvint, mais la désillusion s'effaça pour laisser place à un ennui mortel au boulot.");
            listAvenir.Add("il ne réussit pas et pire encore, il fut pendant un temps SDF avant de se reprendre en main.");
            listAvenir.Add("il y parvint, et fait du bénévolat et des actions humanitaires à côté.");

            int nbRandomAvenir = nbAleatoireAvenir.Next((listAvenir.Count));
            avenir = listAvenir[nbRandomAvenir];
            listAvenir.Clear();

            phraseFinale = passion + " " + avenir;
            return phraseFinale;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="laRichTexBox"></param>
        /// <param name="unBackGroundPrenom"></param>
        /// <param name="unBackGroundNom"></param>
        public void GenererBackGroundGarcon(RichTextBox laRichTexBox, TextBox unBackGroundPrenom, TextBox unBackGroundNom)
        {
            List<string> listPaysBackground = new List<string>();
            List<string> listPassionsBackground = new List<string>();
            List<string> listAvenirBackground = new List<string>();
            string prenom = unBackGroundPrenom.Text;
            string nom = unBackGroundNom.Text;
            string unePassion = "";
            string unAvenir = "";
            string unePassionPlusUnAvenir = PassionEtAvenireAleatoire(listPassionsBackground, listAvenirBackground, unePassion, unAvenir);
            string paysAleatoire = "";
            string preposition = "";
            string prepositionPlusPays = PaysEtPrepositionAleatoire(listPaysBackground, preposition, paysAleatoire);
            string backgroundHomme = $"{prenom} {nom} est un homme originaire {prepositionPlusPays} où il y a vécu toute son enfance. Depuis tout petit c'est un grand " +
                $"passionné par {unePassionPlusUnAvenir} ";
            laRichTexBox.Text = backgroundHomme;
        }
    }
}
