using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace fichePersonnage
{
    class Langue
    {
        private ClasseIni fichierIni = new ClasseIni(Path.GetFullPath("fichiersIni/langues.ini"));

        public Langue()
        {

        }

        public string GetLangues(string langueRetourner)
        {
            try
            {
                bool play = true;
                Random nbRandom = new Random();
                int i = 1;
                List<string> listLangues = new List<string>();
                string fmt = "000.##";
                while (play)
                {
                    string repertoireALire = fichierIni.LireIni("LANGUES", "NBLangue" + i.ToString(fmt));
                    string nouvelleLangue = repertoireALire;
                    listLangues.Add(nouvelleLangue);
                    i++;
                    if (repertoireALire == null)
                    {
                        play = false;
                    }
                }
                int nbAleatoire = nbRandom.Next((listLangues.Count));
                langueRetourner = listLangues[nbAleatoire];
                listLangues.Clear();
                return langueRetourner;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return langueRetourner;
            }
        }

        public void LanguesAleatoire(RichTextBox rtbLangues, TextBox txtMen, string uneLangue)
        {
            try
            {
                string langueUne;
                string langueDeux;
                string langueTrois;
                string langueQuatre;

                if(Convert.ToInt32(txtMen.Text) <= 25)
                {
                    langueUne = GetLangues(uneLangue);
                    rtbLangues.Text = langueUne;
                }
                else if(Convert.ToInt32(txtMen.Text) <=50)
                {
                    langueUne = GetLangues(uneLangue);
                    langueDeux = GetLangues(uneLangue);
                    rtbLangues.Text = langueUne + ", " + langueDeux;
                }
                else if(Convert.ToInt32(txtMen.Text) <= 75)
                {
                    langueUne = GetLangues(uneLangue);
                    langueDeux = GetLangues(uneLangue);
                    langueTrois = GetLangues(uneLangue);
                    rtbLangues.Text = langueUne + ", " + langueDeux + ", " + langueTrois;
                }
                else if(Convert.ToInt32(txtMen.Text) > 75 && Convert.ToInt32(txtMen.Text) < 100)
                {
                    langueUne = GetLangues(uneLangue);
                    langueDeux = GetLangues(uneLangue);
                    langueTrois = GetLangues(uneLangue);
                    langueQuatre = GetLangues(uneLangue);
                    rtbLangues.Text = langueUne + ", " + langueDeux + ", " + langueTrois + ", " + langueQuatre;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
