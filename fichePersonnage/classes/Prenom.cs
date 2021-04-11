using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    class Prenom
    {
        // Attributs
        private string prenom;
        private ClasseIni fichierIni = new ClasseIni(@"C:\Users\Utilisateur\source\repos\fichePersonnage\fichePersonnage\fichiersIni\prenom.ini");

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

            int nbAleatoire = nbRandom.Next((listPrenom.Count));
            prenomRetourner = listPrenom[nbAleatoire];
            unPrenom.Text = prenomRetourner;
            listPrenom.Clear();
        }
    }
}
