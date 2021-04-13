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
            document.LoadFromFile(cheminTemplate);
            string sexe = "";
            
            if(rdbHomme.Checked == true)
            {
                sexe = "Homme";
            }
            else if(rdbFemme.Checked == true)
            {
                sexe = "Femme";
            }
            else if(rdbAutre.Checked == true && txtAutre != null)
            {
                sexe = txtAutre.Text;
            }
            Image picture = uneImage.GetPictureBox(pteBox);
            Section section = document.Sections[0];
            Paragraph paragraphe 
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            paragraphe.AppendText(txtNom.Text.Trim() + " " + txtPrenom.Text.Trim());
            paragraphe.ApplyStyle(BuiltinStyle.Heading1);
            paragraphe = section.AddParagraph();
            paragraphe.AppendText("Sexe : " + sexe);
            paragraphe.ApplyStyle(BuiltinStyle.Heading3);
            paragraphe = section.AddParagraph();
            DocPicture imageAImporter = document.Sections[0].Paragraphs[2].AppendPicture(picture);
            imageAImporter.HorizontalAlignment = ShapeHorizontalAlignment.Right;
            paragraphe = section.AddParagraph();
            paragraphe.AppendText(rtbHistoire.Text);
            paragraphe.ApplyStyle(BuiltinStyle.BodyText);
            paragraphe.Format.HorizontalAlignment = HorizontalAlignment.Justify;
            // Enregistrer le fichier doc.  
            document.SaveToFile(cheminSauvegardeDocx, FileFormat.Docx);
            // Convertir en PDF  
            document.SaveToFile(cheminSauvegardePdf, FileFormat.PDF);
            MessageBox.Show("Toutes les tâches sont terminées.", "Traitement des documents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }

        private void btnImporterImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opf = new OpenFileDialog();
            //opf.Title = "Choisissez votre image";
            //opf.Filter = "JPEG(*.jpeg)|.*jpeg|JPG(*.jpg)|.*jpg|PNG(*.png)|*.png";

            //if(opf.ShowDialog()== DialogResult.OK)
            //{
            //    Bitmap image = new Bitmap(opf.FileName);
            //    pteBox.Image = image;
            //}

            pteBox.Image = uneImage.GetUneImage();
        }

        private void pteBox_Click(object sender, EventArgs e)
        {

        }
    }
}
