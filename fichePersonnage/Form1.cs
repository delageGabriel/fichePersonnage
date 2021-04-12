using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichePersonnage
{
    public partial class Form1 : Form
    {
        private Prenom unPrenom;
        private Nom unNom;
        private BackGround unBackGround;
        private Caractéristiques uneCaractéristique;

        public Form1()
        {
            InitializeComponent();

            unPrenom = new Prenom("Isse");
            unNom = new Nom("La Chancla");
            unBackGround = new BackGround("Ceci est un BackGround");
            uneCaractéristique = new Caractéristiques(150);
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
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPhysique_TextChanged(object sender, EventArgs e)
        {
            uneCaractéristique.checkRepartitionsPointsPhysique(txtPhysique, txtPointsRepartition);
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
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
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
    }
}
