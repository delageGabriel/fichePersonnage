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
        private ImageClasse uneImage;

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
            uneImage = new ImageClasse();
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
            if (rdbHomme.Checked == true)
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
            Table table = section.AddTable(true);
            Paragraph paragraphe
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            TextRange rangeNomPrenom = paragraphe.AppendText(txtNom.Text + " " + txtPrenom.Text);
            rangeNomPrenom.CharacterFormat.FontSize = 36;
            paragraphe = section.AddParagraph();

            TextRange rangeSexe = paragraphe.AppendText("Sexe : " + sexe);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeSexe.CharacterFormat.FontSize = 32;
            paragraphe = section.AddParagraph();

            DocPicture imageARepositionner = paragraphe.AppendPicture(picture);
            imageARepositionner.TextWrappingStyle = TextWrappingStyle.Square;
            imageARepositionner.HorizontalPosition = 300.0F;
            imageARepositionner.VerticalPosition = -100.0F;
            paragraphe = section.AddParagraph();

            TextRange rangeIntituleHistoire = paragraphe.AppendText("Histoire :");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeIntituleHistoire.CharacterFormat.FontSize = 28;
            paragraphe = section.AddParagraph();

            paragraphe.AppendText(rtbHistoire.Text);
            paragraphe.ApplyStyle(BuiltinStyle.BodyText);
            paragraphe.Format.HorizontalAlignment = HorizontalAlignment.Justify;
            paragraphe = section.AddParagraph();

            TextRange rangeCaracteristiques = paragraphe.AppendText("Caractéristiques :");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            rangeCaracteristiques.CharacterFormat.FontSize = 28;
            paragraphe = section.AddParagraph();

            paragraphe.AppendText("Physique" + "                        " + "Social" + "                        " + "Mental");
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
            paragraphe = section.AddParagraph();

            paragraphe.AppendText(txtPhysique.Text + "                        " + txtSocial.Text + "                        " + txtMental.Text);
            paragraphe.ApplyStyle(BuiltinStyle.Heading8);
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
    }
}
