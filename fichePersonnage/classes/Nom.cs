using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fichePersonnage
{
    class Nom
    {
        // Attributs
        private string nom;
        private ClasseIni fichiersIni = new ClasseIni(Path.GetFullPath("fichiersIni/nom.ini"));

        // Constructeur
        public Nom(string nom)
        {
            this.NomPersonnage = nom;
        }

        // Accesseurs/Mutateurs
        public string NomPersonnage { get => nom; set => nom = value; }

        public void NomPersonnageAleatoire(TextBox unNom)
        {
            bool play = true;
            Random nbRandom = new Random();
            byte[] bytes;
            string prenomRetourner;
            int i = 1;
            List<string> listNom = new List<string>();
            string fmt = "000.##";
            while (play)
            {
                string repertoireALire = fichiersIni.LireIni("NOM DE FAMILLE", "NBNom" + i.ToString(fmt));
                string nouveauPrenom = repertoireALire;
                listNom.Add(nouveauPrenom);
                i++;
                if (repertoireALire == null)
                {
                    play = false;
                }
            }

            int nbAleatoire = nbRandom.Next(1, (listNom.Count));
            bytes = Encoding.Default.GetBytes(listNom[nbAleatoire]);
            prenomRetourner = Encoding.UTF8.GetString(bytes);
            unNom.Text = prenomRetourner;
            listNom.Clear();
        }
    }
}
