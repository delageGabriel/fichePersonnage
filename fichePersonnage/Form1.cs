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
using Spire.Doc.Fields;
using Spire.Doc.Documents;
using HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;

namespace fichePersonnage
{
    public partial class Form1 : Form
    {
        private Prenom unPrenom;
        private Nom unNom;
        private BackGround unBackGround;
        private Document document;
        private Caracteristiques caracteristiques;
        private Langue uneLangue;
        private string laLangue;
        private string cheminTemplate;
        private string cheminSauvegardeDocx;
        private string cheminSauvegardePdf;
        private ImageClasse uneImage;

        public Form1()
        {
            InitializeComponent();
            unPrenom = new Prenom("Isse");
            unNom = new Nom("La Chancla");
            unBackGround = new BackGround("Ceci est un BackGround");
            document = new Document();
            caracteristiques = new Caracteristiques();
            laLangue = "Français";
            uneLangue = new Langue();
            cheminTemplate = Path.GetFullPath("template/templateFichePerso.docx");
            cheminSauvegardeDocx = Path.GetFullPath("template/fichePersonnage.docx");
            cheminSauvegardePdf = Path.GetFullPath("template/fichePersonnage.pdf");
            uneImage = new ImageClasse();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHomme.Checked == true)
            {
                btnGenerPrenom.Enabled = true;
            }
        }

        private void btnGenerzNom_Click(object sender, EventArgs e)
        {
            unNom.NomPersonnageAleatoire(txtNom);
        }

        private void btnGenerPrenom_Click(object sender, EventArgs e)
        {
            if (rdbHomme.Checked == true)
            {
                unPrenom.PrenomAleatoireGarcon(txtPrenom);
            }
            else if (rdbFemme.Checked == true)
            {
                unPrenom.PrenomAleatoireFille(txtPrenom);
            }
            else if(rdbAutre.Checked == true)
            {
                unPrenom.PrenomAleatoireNeutre(txtPrenom);
            }

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbFemme_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemme.Checked == true)
            {
                btnGenerPrenom.Enabled = true;
            }
        }

        private void rdbAutre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAutre.Checked == true)
            {
                txtAutre.Enabled = true;
                btnGenerPrenom.Enabled = true;
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

        private void btnSoumettre_Click(object sender, EventArgs e)
        {
            document.LoadFromFile(cheminTemplate);
            string sexe = "";

            if (rdbHomme.Checked == true)
            {
                sexe = "Homme";
            }
            else if (rdbFemme.Checked == true)
            {
                sexe = "Femme";
            }
            else if (rdbAutre.Checked == true && txtAutre != null)
            {
                sexe = txtAutre.Text;
            }
            Image picture = uneImage.GetPictureBox(pteBox);
            Section section = document.Sections[0];
            Paragraph paragraphe
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            TextRange rangeNomPrenom = paragraphe.AppendText(txtNom.Text + " " + txtPrenom.Text);
            rangeNomPrenom.CharacterFormat.FontSize = 36;
            rangeNomPrenom.CharacterFormat.TextColor = Color.DarkRed;
            paragraphe = section.AddParagraph();

            TextRange rangeSexe = paragraphe.AppendText("Sexe : " + sexe);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeSexe.CharacterFormat.FontSize = 24;
            paragraphe = section.AddParagraph();

            TextRange rangeAge = paragraphe.AppendText("Âge : " + txtAge.Text + " ans");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeAge.CharacterFormat.FontSize = 24;
            paragraphe = section.AddParagraph();

            TextRange rangeRace = paragraphe.AppendText("Race : " + txtRace.Text);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeRace.CharacterFormat.FontSize = 24;
            paragraphe = section.AddParagraph();

            TextRange rangeClasseMetier = paragraphe.AppendText("Classe : " + txtClasseMetier.Text);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeClasseMetier.CharacterFormat.FontSize = 24;
            paragraphe = section.AddParagraph();

            DocPicture imageARepositionner = paragraphe.AppendPicture(picture);
            imageARepositionner.TextWrappingStyle = TextWrappingStyle.Square;
            imageARepositionner.HorizontalPosition = 200.0F;
            imageARepositionner.VerticalPosition = -200.0F;
            paragraphe = section.AddParagraph();

            TextRange rangeNiveau = paragraphe.AppendText("Niveau " + txtNiveau.Text);
            paragraphe.ApplyStyle(BuiltinStyle.Heading5);
            rangeNiveau.CharacterFormat.FontSize = 28;
            paragraphe.Format.HorizontalAlignment = HorizontalAlignment.Center;
            paragraphe = section.AddParagraph();

            TextRange rangeIntituleHistoire = paragraphe.AppendText("Histoire :");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeIntituleHistoire.CharacterFormat.FontSize = 28;
            rangeIntituleHistoire.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            paragraphe = section.AddParagraph();

            paragraphe.AppendText(rtbHistoire.Text);
            paragraphe.ApplyStyle(BuiltinStyle.BodyText);
            paragraphe.Format.HorizontalAlignment = HorizontalAlignment.Justify;
            paragraphe = section.AddParagraph();

            TextRange rangeCaracteristiques = paragraphe.AppendText("Caractéristiques :");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeCaracteristiques.CharacterFormat.FontSize = 28;
            rangeCaracteristiques.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            paragraphe = section.AddParagraph();

            TextRange rangePointsDeVie = paragraphe.AppendText("Points de vies : " + txtPV.Text);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangePointsDeVie.CharacterFormat.FontSize = 19;
            TextRange rangePointDeMana = paragraphe.AppendText("                 Points de Mana : " + txtPM.Text);
            rangePointDeMana.CharacterFormat.FontSize = 19;
            paragraphe = section.AddParagraph();

            TextRange rangePhysique = paragraphe.AppendText("Physique");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangePhysique.CharacterFormat.FontSize = 20;
            TextRange rangeSocial = paragraphe.AppendText("                              Social");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeSocial.CharacterFormat.FontSize = 20;
            TextRange rangeMental = paragraphe.AppendText("                              Mental");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeMental.CharacterFormat.FontSize = 20;
            paragraphe = section.AddParagraph();

            TextRange rangePhysiqueStat = paragraphe.AppendText(txtPhysique.Text);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangePhysiqueStat.CharacterFormat.FontSize = 20;
            TextRange rangeSocialStat = paragraphe.AppendText($"                                           {txtSocial.Text}");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeSocialStat.CharacterFormat.FontSize = 20;
            TextRange rangeMentalStat = paragraphe.AppendText($"                                     {txtMental.Text}");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeMentalStat.CharacterFormat.FontSize = 20;
            paragraphe.Format.BeforeSpacing = 30;
            paragraphe.Format.AfterSpacing = 30;
            paragraphe = section.AddParagraph();

            TextRange rangeLangue = paragraphe.AppendText("Langue(s) :");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeLangue.CharacterFormat.FontSize = 28;
            rangeLangue.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            paragraphe = section.AddParagraph();

            paragraphe.AppendText(rtbLangue.Text);
            paragraphe.ApplyStyle(BuiltinStyle.BodyText1I);
            paragraphe.Format.HorizontalAlignment = HorizontalAlignment.Justify;
            paragraphe = section.AddParagraph();

            // Enregistrer le fichier doc.  
            document.SaveToFile(cheminSauvegardeDocx, FileFormat.Docx);
            // Convertir en PDF  
            document.SaveToFile(cheminSauvegardePdf, FileFormat.PDF);
            MessageBox.Show("Toutes les tâches sont terminées.", "Traitement des documents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }

        private void btnImporterImage_Click(object sender, EventArgs e)
        {
            pteBox.Image = uneImage.GetUneImage();
        }

        private void pteBox_Click(object sender, EventArgs e)
        {

        }

        private void txtPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPV_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtNnPointRepartir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNnPointRepartir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void btnRepartition_Click(object sender, EventArgs e)
        {
            caracteristiques.RepartitionPointsPVPMAleatoire(txtNnPointRepartir, txtPV, txtPM);
        }

        private void btnRepartitionPhyMenSoc_Click(object sender, EventArgs e)
        {
            caracteristiques.RepartitionCaracteristiquePrincipale(txtNbRepartitionPhySocMen, txtPhysique, txtSocial, txtMental);
        }

        private void txtRace_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHistoire_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenereLangues_Click(object sender, EventArgs e)
        {
            uneLangue.LanguesAleatoire(rtbLangue, txtMental, laLangue);
        }

        private void txtNiveau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
