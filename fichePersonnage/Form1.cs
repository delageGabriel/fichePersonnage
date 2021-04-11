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

        public Form1()
        {
            InitializeComponent();

            unPrenom = new Prenom("Isse");
            unNom = new Nom("La Chancla");
            unBackGround = new BackGround("Ceci est un BackGround");
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
            unBackGround.GenererBackGroundGarcon(rtbHistoire, txtPrenom, txtNom);
        }

        private void rtbHistoire_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
