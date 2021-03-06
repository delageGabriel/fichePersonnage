using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace fichePersonnage
{
    class Prenom
    {
        // Attributs
        private string prenom;
        private ClasseIni fichierIni = new ClasseIni(Path.GetFullPath("fichiersIni/prenom.ini"));

        // Constructeur
        public Prenom(string prenom)
        {
            this.PrenomPersonnage = prenom;
        }

        // Accesseur/Mutateur
        public string PrenomPersonnage { get => prenom; set => prenom = value; }

        public void PrenomAleatoireGarcon(TextBox unPrenom)
        {
            bool play = true;
            Random nbRandom = new Random();
            string prenomRetourner;
            int i = 1;
            List<string> listPrenom = new List<string>();
            string fmt = "000.##";
            while (play)
            {
                string repertoireALire = fichierIni.LireIni("PRENOM GARCON", "NBPrenom" + i.ToString(fmt));
                string nouveauPrenom = repertoireALire;
                listPrenom.Add(nouveauPrenom);
                i++;

                if(repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbAleatoire = nbRandom.Next((listPrenom.Count));
            prenomRetourner = listPrenom[nbAleatoire];            
            unPrenom.Text = prenomRetourner;
            listPrenom.Clear();            
        }

        public string PrenomAleatoireGarcon()
        {
            bool play = true;
            Random nbRandom = new Random();
            string prenomRetourner;
            int i = 1;
            List<string> listPrenom = new List<string>();
            string fmt = "000.##";
            while (play)
            {
                string repertoireALire = fichierIni.LireIni("PRENOM GARCON", "NBPrenom" + i.ToString(fmt));
                string nouveauPrenom = repertoireALire;
                listPrenom.Add(nouveauPrenom);
                i++;

                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbAleatoire = nbRandom.Next((listPrenom.Count));
            prenomRetourner = listPrenom[nbAleatoire];
            listPrenom.Clear();
            return prenomRetourner;
        }

        public void PrenomAleatoireNeutre(TextBox unPrenom)
        {
            bool play = true;
            Random nbRandom = new Random();
            string prenomRetourner;
            int i = 1;
            List<string> listPrenom = new List<string>();
            string fmt = "000.##";
            while (play)
            {
                string repertoireALire = fichierIni.LireIni("NEUTRE", "NBPrenom" + i.ToString(fmt));
                string nouveauPrenom = repertoireALire;
                listPrenom.Add(nouveauPrenom);
                i++;
                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbAleatoire = nbRandom.Next((listPrenom.Count));
            prenomRetourner = listPrenom[nbAleatoire];
            unPrenom.Text = prenomRetourner;
            listPrenom.Clear();
        }

        public void PrenomAleatoireFille(TextBox unPrenom)
        {
            bool play = true;
            Random nbRandom = new Random();
            string prenomRetourner;
            int i = 1;
            List<string> listPrenom = new List<string>();
            string fmt = "000.##";
            while (play)
            {
                string repertoireALire = fichierIni.LireIni("PRENOM FILLE", "NBPrenom" + i.ToString(fmt));
                string nouveauPrenom = repertoireALire;
                listPrenom.Add(nouveauPrenom);
                i++;
                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbAleatoire = nbRandom.Next(1, (listPrenom.Count));
            prenomRetourner = listPrenom[nbAleatoire];
            unPrenom.Text = prenomRetourner;
            listPrenom.Clear();
        }

        public string PrenomAleatoireFille()
        {
            bool play = true;
            Random nbRandom = new Random();
            string prenomRetourner;
            int i = 1;
            List<string> listPrenom = new List<string>();
            string fmt = "000.##";
            while (play)
            {
                string repertoireALire = fichierIni.LireIni("PRENOM FILLE", "NBPrenom" + i.ToString(fmt));
                string nouveauPrenom = repertoireALire;
                listPrenom.Add(nouveauPrenom);
                i++;
                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbAleatoire = nbRandom.Next((listPrenom.Count));
            prenomRetourner = listPrenom[nbAleatoire];
            listPrenom.Clear();
            return prenomRetourner;
        }
    }
}
