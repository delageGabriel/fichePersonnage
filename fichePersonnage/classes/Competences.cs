using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    class Competences
    {
        private ClasseIni fichierIni = new ClasseIni(Path.GetFullPath("fichiersIni/competencesEtDons.ini"));

        public Competences()
        {

        }

        public string GetCompetences(string laCompetence)
        {
            try
            {
                bool play = true;
                Random nbRandom = new Random();
                int i = 1;
                List<string> listCompetences = new List<string>();
                string fmt = "000.##";
                while (play)
                {
                    string repertoireALire = fichierIni.LireIni("COMPETENCES", "NBCompetences" + i.ToString(fmt));
                    string nouvelleCompetence = repertoireALire;
                    listCompetences.Add(nouvelleCompetence);
                    i++;
                    if (repertoireALire == null)
                    {
                        play = false;
                    }
                }

                int nbAleatoire = nbRandom.Next(1, (listCompetences.Count));
                laCompetence = listCompetences[nbAleatoire];
                listCompetences.Clear();

                return laCompetence;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return laCompetence;
            }
        }

        public void TroisCompetencesAleatoire(TextBox txtCompetences)
        {
            try
            {
                string lesCompetences = string.Empty;
                string lesCompetencesRetourner = string.Empty;
                string competenceUne = string.Empty;
                string competenceUneTexte = string.Empty;
                string competenceDeux = string.Empty;
                string competenceDeuxTexte = string.Empty;
                string competenceTrois = string.Empty;
                string competenceTroisTexte = string.Empty;

                competenceUne = GetCompetences(lesCompetences);
                competenceUneTexte = competenceUne.Trim().Split('+').First<string>();
                competenceDeux = GetCompetences(lesCompetences);
                competenceDeuxTexte = competenceDeux.Trim().Split('+').First<string>();
                while (competenceDeuxTexte == competenceUneTexte)
                {
                    competenceDeux = GetCompetences(lesCompetences);
                    competenceDeuxTexte = competenceDeux.Trim().Split('+').First<string>();
                }
                competenceTrois = GetCompetences(lesCompetences);
                competenceTroisTexte = competenceTrois.Trim().Split('+').First<string>();
                while (competenceTroisTexte == competenceUneTexte && competenceTroisTexte == competenceDeuxTexte)
                {
                    competenceTrois = GetCompetences(lesCompetences);
                    competenceTroisTexte = competenceTrois.Trim().Split('+').First<string>();
                }

                lesCompetencesRetourner = competenceUne + ", " + competenceDeux + ", " + competenceTrois;
                txtCompetences.Text = lesCompetencesRetourner;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
