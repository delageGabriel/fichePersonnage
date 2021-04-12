using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;

namespace fichePersonnage
{
    public partial class Form1 : Form
    {
        private Prenom unPrenom;
        private Nom unNom;
        private BackGround unBackGround;
        private Document document;
        private string cheminTemplate;
        private string cheminSauvegardeDocx;
        private string cheminSauvegardePdf;

        public Form1()
        {
            InitializeComponent();

            unPrenom = new Prenom("Isse");
            unNom = new Nom("La Chancla");
            unBackGround = new BackGround("Ceci est un BackGround");
            document = new Document();
            cheminTemplate = @"C:\Users\Utilisateur\source\repos\delageGabriel\fichePersonnage\fichePersonnage\template\templateFichePerso.docx";
            cheminSauvegardeDocx = @"C:\Users\Utilisateur\source\repos\delageGabriel\fichePersonnage\fichePersonnage\template\fichePersonnage.docx";
            cheminSauvegardePdf = @"C:\Users\Utilisateur\source\repos\delageGabriel\fichePersonnage\fichePersonnage\template\fichePersonnage.pdf";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHomme.Checked == true)
            {
                txtPrenom.Enabled = true;
                btnGenerPrenom.Enabled = true;
            }            
        }

        private void btnGenerzNom_Click(object sender, EventArgs e)
        {
            unNom.NomPersonnageAleatoire(txtNom);
        }

        private void btnGenerPrenom_Click(object sender, EventArgs e)
        {
            if(rdbHomme.Checked == true)
            {
                unPrenom.PrenomAleatoireGarcon(txtPrenom);
            }
            else if (rdbFemme.Checked == true)
            {
                unPrenom.PrenomAleatoireFille(txtPrenom);
            }
            
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbFemme_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemme.Checked == true)
            {
                txtPrenom.Enabled = true;
                btnGenerPrenom.Enabled = true;
            }
        }

        private void rdbAutre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAutre.Checked == true)
            {
                txtPrenom.Enabled = true;
                txtAutre.Enabled = true;
                btnGenerPrenom.Enabled = false;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnGenerHistoire_Click(object sender, EventArgs e)
        {
            if (rdbHomme.Checked == true)
            {
                unBackGround.GenererBackGroundGarcon(rtbHistoire, txtPrenom, txtNom); 
            }
            else if (rdbFemme.Checked == true)
            {
                unBackGround.GenererBackGroundFille(rtbHistoire, txtPrenom, txtNom);
            }
        }

        private void rtbHistoire_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPointsRepartition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtPhysique_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPhysique_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtMental_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMental_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtForce_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForce_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPerception_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtConstitution_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCharisme_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtIntelligence_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDexterite_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtResistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPointsRepartition_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbModeAventures_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbModeAventures.Checked == true)
            {
                txtPhysique.Enabled = true;
                txtSocial.Enabled = true;
                txtMental.Enabled = true;
                txtForce.Enabled = false;
                txtPerception.Enabled = false;
                txtConstitution.Enabled = false;
                txtCharisme.Enabled = false;
                txtIntelligence.Enabled = false;
                txtDexterite.Enabled = false;
                txtResistance.Enabled = false;
                btnGenerPrenom.Enabled = false;
            }
        }

        private void rdbNoeliste_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNoeliste.Checked == true)
            {
                txtForce.Enabled = true;
                txtPerception.Enabled = true;
                txtConstitution.Enabled = true;
                txtCharisme.Enabled = true;
                txtIntelligence.Enabled = true;
                txtDexterite.Enabled = true;
                txtResistance.Enabled = true;
                txtPhysique.Enabled = false;
                txtSocial.Enabled = false;
                txtMental.Enabled = false;
                btnGenerPrenom.Enabled = false;
            }
        }

        private void btnSoumettre_Click(object sender, EventArgs e)
        {
            // initialise l'objet mot
            document.LoadFromFile(cheminTemplate);
            // récupère les chaînes à remplacer  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            // Remplacer le texte  
            foreach (KeyValuePair<string, string> kvp  in  dictReplace)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }
            // Enregistrer le fichier doc.  
            document.SaveToFile(cheminSauvegardeDocx, FileFormat.Docx);
            // Convertir en PDF  
            document.SaveToFile(cheminSauvegardePdf, FileFormat.PDF);
            MessageBox.Show("Toutes les tâches sont terminées.", "Traitement des documents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }

        Dictionary<string, string> GetReplaceDictionary()
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();
            replaceDict.Add("#Nom#", txtNom.Text.Trim());
            replaceDict.Add("#Prenom#", txtPrenom.Text);
            replaceDict.Add("#Histoire#", rtbHistoire.Text.Trim());
            replaceDict.Add("#Physique#", txtPhysique.Text);
            replaceDict.Add("#Social#", txtSocial.Text);
            replaceDict.Add("#Mental#", txtMental.Text.Trim());
            replaceDict.Add("#Force#", txtForce.Text.Trim());
            replaceDict.Add("#Perception#", txtPerception.Text.Trim());
            replaceDict.Add("#Constitution#", txtConstitution.Text);
            // string isEmployed = this.radio_isEmployed_Yes.Checked ? "Yes" : "No";
            replaceDict.Add("#Charisme#", txtCharisme.Text.Trim());
            replaceDict.Add("#Intelligence#", txtIntelligence.Text.Trim());
            replaceDict.Add("#Dextérité#", txtDexterite.Text.Trim());
            replaceDict.Add("#Résistance#", txtDexterite.Text.Trim());

            return replaceDict;
        }
    }
}
