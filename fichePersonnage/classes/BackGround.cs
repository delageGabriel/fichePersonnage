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
        private ClasseIni fichierIniPays = new ClasseIni("./fichePersonnage/fichiersIni/pays.ini");
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
            paysChoisisAleatoirement = listDesPays[nbRandom].Trim();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listDesPassions"></param>
        /// <param name="listAvenir"></param>
        /// <param name="passion"></param>
        /// <param name="avenir"></param>
        /// <returns></returns>
        public string PassionEtAvenirAleatoireGarcon(List<string> listDesPassions, List<string> listAvenir, string passion, string avenir)
        {
            Random nbAleatoirePassion = new Random();
            Random nbAleatoireAvenir = new Random();
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
            listAvenir.Add("il y parvint, mais le rêve s'effaça pour laisser place à un ennui mortel au boulot.");
            listAvenir.Add("il ne réussit pas et pire encore, il fut pendant un temps SDF avant de se reprendre en main.");
            listAvenir.Add("il y parvint, et fait du bénévolat et des actions humanitaires à côté.");

            int nbRandomAvenir = nbAleatoireAvenir.Next((listAvenir.Count));
            avenir = listAvenir[nbRandomAvenir];
            listAvenir.Clear();

            phraseFinale = passion + " " + "il fit des études pour faire carrière dans le domaine," + " " + avenir;
            return phraseFinale;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listDesPassions"></param>
        /// <param name="listAvenir"></param>
        /// <param name="passion"></param>
        /// <param name="avenir"></param>
        /// <returns></returns>
        public string PassionEtAvenirAleatoireFille(List<string> listDesPassions, List<string> listAvenir, string passion, string avenir)
        {
            Random nbAleatoirePassion = new Random();
            Random nbAleatoireAvenir = new Random();
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

            listAvenir.Add("mais elle ne réussit pas et se contenta de faire un simple métier à sa portée.");
            listAvenir.Add("elle parvint à arriver à son objectif et elle fait désormais un travail dans sa passion.");
            listAvenir.Add("elle y parvint, mais le rêve s'effaça pour laisser place à un ennui mortel au boulot.");
            listAvenir.Add("elle ne réussit pas et pire encore, elle fut pendant un temps SDF avant de se reprendre en main.");
            listAvenir.Add("elle y parvint, et fait du bénévolat et des actions humanitaires à côté.");

            int nbRandomAvenir = nbAleatoireAvenir.Next((listAvenir.Count));
            avenir = listAvenir[nbRandomAvenir];
            listAvenir.Clear();

            phraseFinale = passion + " " + "elle fit des études pour faire carrière dans le domaine," + " " + avenir;
            return phraseFinale;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listPasse"></param>
        /// <param name="passe"></param>
        /// <returns></returns>
        public string PasseSombreEtTortueuxAleatoireFille(List<string> listPasse, string passe)
        {
            Random nbAleatoire = new Random();
            string passeFinale = "";
            listPasse.Add("Plus jeune, elle fit une formation dans un couvent pour rester chaste et pure.");
            listPasse.Add("Plus jeune, elle faisait déjà des petits boulots à côté des études pour aider sa famille pauvre.");
            listPasse.Add("Plus jeune, elle faisait parti d'une association sportive où il y remporta quelques médailles dont elle est très fier.");
            listPasse.Add("Plus jeune, elle se perdit en forêt, ce qui lui causa un traumatisme profond, depuis elle a peur de s'aventurer seul dans des endroits sans aucune présence");
            listPasse.Add("Plus jeune, elle resta impassible devant un tigre qui rugit devant elle dans un zoo, elle est surnommée depuis Lily la tigresse.");
            listPasse.Add("Plus jeune, elle était en surpoids à cause d'une alimentation à base de bonbons et de chips, mais elle réussit à se reprendre en main.");
            listPasse.Add("Plus jeune, elle n'avait pas ou peu d'amis, ce qui lui valut le fait d'être la tête de Turc de groupe. Mais elle surmonta ces harcèlements.");

            int nbRandomPasse = nbAleatoire.Next((listPasse.Count));
            passe = listPasse[nbRandomPasse];
            listPasse.Clear();
            passeFinale = passe;
            return passeFinale;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listPasse"></param>
        /// <param name="passe"></param>
        /// <returns></returns>
        public string PasseSombreEtTortueuxAleatoireGarcon(List<string> listPasse, string passe)
        {
            Random nbAleatoire = new Random();
            string passeFinale = "";
            listPasse.Add("Plus jeune, il fit quelques bêtises qui lui valurent de passer du temps en prison où il s'y endurcit aussi bien mentalement que physiquement.");
            listPasse.Add("Plus jeune, il faisait déjà des petits boulots à côté des études pour aider sa famille pauvre.");
            listPasse.Add("Plus jeune, il faisait parti d'une association sportive où il y remporta quelques médailles dont il est très fier.");
            listPasse.Add("Plus jeune, il se perdit en forêt, ce qui lui causa un traumatisme profond, depuis il a peur de s'aventurer seul dans des endroits sans aucune présence.");
            listPasse.Add("Plus jeune, il survécut à une rencontre avec sanglier qu'il battu à mains nues, parce que sans rigoler c'était pas plus compliqué qu'avec un couteau. Son surnom depuis est Pumba.");
            listPasse.Add("Plus jeune, il était en surpoids à cause d'une alimentation à base de bonbons et de chips, mais il réussit à se reprendre en main.");
            listPasse.Add("Plus jeune, il n'avait pas ou peu d'amis, ce qui lui valut le fait d'être la tête de Turc de groupe. Mais il surmonta ces harcèlements.");

            int nbRandomPasse = nbAleatoire.Next((listPasse.Count));
            passe = listPasse[nbRandomPasse];
            listPasse.Clear();
            passeFinale = passe;
            return passeFinale;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listDeCompagnons"></param>
        /// <param name="unCompagnon"></param>
        /// <returns></returns>
        public string UnCompagnonAleatoireFille(List<string> listDeCompagnons, string unCompagnon)
        {
            Random nbAleatoire = new Random();
            string compagnonFinal = "";
            listDeCompagnons.Add("Elle est follement amoureuse du jeune Kévin le chad, et cherche à lui parler en secret.");
            listDeCompagnons.Add("Elle sait qu'elle peut toujours compter sur sa meilleure ami Chouffine, qui l'aidera peu importe la situation.");
            listDeCompagnons.Add("Elle sait qu'elle peut toujours faire appel à sa famille en cas de pépin.");

            int nbRandomCompagnons = nbAleatoire.Next(listDeCompagnons.Count);
            unCompagnon = listDeCompagnons[nbRandomCompagnons];
            listDeCompagnons.Clear();
            compagnonFinal = unCompagnon;
            return compagnonFinal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listDeCompagnons"></param>
        /// <param name="unCompagnon"></param>
        /// <returns></returns>
        public string UnCompagnonAleatoireGarcon(List<string> listDeCompagnons, string unCompagnon)
        {
            Random nbAleatoire = new Random();
            string compagnonFinal = "";
            listDeCompagnons.Add("Il est follement amoureux de la jeune Béatrice sa voisine, et serait prêt à tout pour l'épouser.");
            listDeCompagnons.Add("Il sait qu'il peut toujours compter sur son meilleur ami Jean-René, qui l'aidera peu importe la situation.");
            listDeCompagnons.Add("Il sait qu'il peut toujours faire appel à sa famille en cas de pépin.");

            int nbRandomCompagnons = nbAleatoire.Next(listDeCompagnons.Count);
            unCompagnon = listDeCompagnons[nbRandomCompagnons];
            listDeCompagnons.Clear();
            compagnonFinal = unCompagnon;
            return compagnonFinal;
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
            List<string> listPasseBackground = new List<string>();
            List<string> listCompagnonBackground = new List<string>();
            string prenom = unBackGroundPrenom.Text;
            string nom = unBackGroundNom.Text;
            string unPasse = "";
            string unePassion = "";
            string unAvenir = "";
            string unCompagnon = "";
            string unePassionPlusUnAvenir = PassionEtAvenirAleatoireGarcon(listPassionsBackground, listAvenirBackground, unePassion, unAvenir);
            string unPasseSombre = PasseSombreEtTortueuxAleatoireGarcon(listPasseBackground, unPasse);
            string compagnonUltime = UnCompagnonAleatoireGarcon(listCompagnonBackground, unCompagnon);
            string paysAleatoire = "";
            string preposition = "";
            string prepositionPlusPays = PaysEtPrepositionAleatoire(listPaysBackground, preposition, paysAleatoire);
            string backgroundHomme = $"{prenom} {nom} est un homme originaire {prepositionPlusPays} où il y a vécu toute son enfance. Depuis tout petit c'est un grand " +
                $"passionné par {unePassionPlusUnAvenir} {unPasseSombre}. {compagnonUltime}";
            laRichTexBox.Text = backgroundHomme;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="laRichTexBox"></param>
        /// <param name="unBackGroundPrenom"></param>
        /// <param name="unBackGroundNom"></param>
        public void GenererBackGroundFille(RichTextBox laRichTexBox, TextBox unBackGroundPrenom, TextBox unBackGroundNom)
        {
            List<string> listPaysBackground = new List<string>();
            List<string> listPassionsBackground = new List<string>();
            List<string> listAvenirBackground = new List<string>();
            List<string> listPasseBackground = new List<string>();
            List<string> listCompagnonBackground = new List<string>();
            string prenom = unBackGroundPrenom.Text;
            string nom = unBackGroundNom.Text;
            string unPasse = "";
            string unePassion = "";
            string unAvenir = "";
            string unCompagnon = "";
            string unePassionPlusUnAvenir = PassionEtAvenirAleatoireFille(listPassionsBackground, listAvenirBackground, unePassion, unAvenir);
            string unPasseSombre = PasseSombreEtTortueuxAleatoireFille(listPasseBackground, unPasse);
            string compagnonUltime = UnCompagnonAleatoireFille(listCompagnonBackground, unCompagnon);
            string paysAleatoire = "";
            string preposition = "";
            string prepositionPlusPays = PaysEtPrepositionAleatoire(listPaysBackground, preposition, paysAleatoire);
            string backgroundFemme = $"{prenom} {nom} est une femme originaire {prepositionPlusPays} où elle y a vécu toute son enfance. Depuis toute petite c'est une grande " +
                $"passionnée par {unePassionPlusUnAvenir} {unPasseSombre}. {compagnonUltime}";
            laRichTexBox.Text = backgroundFemme;
        }
    }
}
