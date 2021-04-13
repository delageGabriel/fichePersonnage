namespace fichePersonnage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnGenerNom = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnGenerPrenom = new System.Windows.Forms.Button();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.rtbHistoire = new System.Windows.Forms.RichTextBox();
            this.lblHistoire = new System.Windows.Forms.Label();
            this.btnGenerHistoire = new System.Windows.Forms.Button();
            this.lblPhysique = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.lblMental = new System.Windows.Forms.Label();
            this.txtPhysique = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtMental = new System.Windows.Forms.TextBox();
            this.rdbAutre = new System.Windows.Forms.RadioButton();
            this.txtAutre = new System.Windows.Forms.TextBox();
            this.lblForce = new System.Windows.Forms.Label();
            this.lblPerception = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblCharisme = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblDexterite = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.txtPerception = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.txtCharisme = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtDexterite = new System.Windows.Forms.TextBox();
            this.txtResistance = new System.Windows.Forms.TextBox();
            this.lblLimiteCaractere = new System.Windows.Forms.Label();
            this.lblAventures = new System.Windows.Forms.Label();
            this.rdbModeAventures = new System.Windows.Forms.RadioButton();
            this.lblModeNoeliste = new System.Windows.Forms.Label();
            this.rdbNoeliste = new System.Windows.Forms.RadioButton();
            this.btnSoumettre = new System.Windows.Forms.Button();
            this.pteBox = new System.Windows.Forms.PictureBox();
            this.btnImporterImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(28, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(63, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // btnGenerNom
            // 
            this.btnGenerNom.Location = new System.Drawing.Point(28, 57);
            this.btnGenerNom.Name = "btnGenerNom";
            this.btnGenerNom.Size = new System.Drawing.Size(98, 23);
            this.btnGenerNom.TabIndex = 2;
            this.btnGenerNom.Text = "Générer Nom";
            this.btnGenerNom.UseVisualStyleBackColor = true;
            this.btnGenerNom.Click += new System.EventHandler(this.btnGenerzNom_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(185, 31);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(215, 15);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // btnGenerPrenom
            // 
            this.btnGenerPrenom.Enabled = false;
            this.btnGenerPrenom.Location = new System.Drawing.Point(185, 57);
            this.btnGenerPrenom.Name = "btnGenerPrenom";
            this.btnGenerPrenom.Size = new System.Drawing.Size(100, 23);
            this.btnGenerPrenom.TabIndex = 5;
            this.btnGenerPrenom.Text = "Générer Prénom";
            this.btnGenerPrenom.UseVisualStyleBackColor = true;
            this.btnGenerPrenom.Click += new System.EventHandler(this.btnGenerPrenom_Click);
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Location = new System.Drawing.Point(28, 141);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(61, 17);
            this.rdbHomme.TabIndex = 8;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            this.rdbHomme.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Location = new System.Drawing.Point(28, 175);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(59, 17);
            this.rdbFemme.TabIndex = 9;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            this.rdbFemme.CheckedChanged += new System.EventHandler(this.rdbFemme_CheckedChanged);
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(63, 115);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(31, 13);
            this.lblSexe.TabIndex = 10;
            this.lblSexe.Text = "Sexe";
            // 
            // rtbHistoire
            // 
            this.rtbHistoire.Location = new System.Drawing.Point(28, 270);
            this.rtbHistoire.MaxLength = 500;
            this.rtbHistoire.Name = "rtbHistoire";
            this.rtbHistoire.Size = new System.Drawing.Size(505, 180);
            this.rtbHistoire.TabIndex = 11;
            this.rtbHistoire.Text = "";
            this.rtbHistoire.TextChanged += new System.EventHandler(this.rtbHistoire_TextChanged);
            // 
            // lblHistoire
            // 
            this.lblHistoire.AutoSize = true;
            this.lblHistoire.Location = new System.Drawing.Point(86, 242);
            this.lblHistoire.Name = "lblHistoire";
            this.lblHistoire.Size = new System.Drawing.Size(42, 13);
            this.lblHistoire.TabIndex = 12;
            this.lblHistoire.Text = "Histoire";
            // 
            // btnGenerHistoire
            // 
            this.btnGenerHistoire.Location = new System.Drawing.Point(347, 456);
            this.btnGenerHistoire.Name = "btnGenerHistoire";
            this.btnGenerHistoire.Size = new System.Drawing.Size(159, 23);
            this.btnGenerHistoire.TabIndex = 13;
            this.btnGenerHistoire.Text = "Générer Histoire";
            this.btnGenerHistoire.UseVisualStyleBackColor = true;
            this.btnGenerHistoire.Click += new System.EventHandler(this.btnGenerHistoire_Click);
            // 
            // lblPhysique
            // 
            this.lblPhysique.AutoSize = true;
            this.lblPhysique.Location = new System.Drawing.Point(80, 537);
            this.lblPhysique.Name = "lblPhysique";
            this.lblPhysique.Size = new System.Drawing.Size(50, 13);
            this.lblPhysique.TabIndex = 16;
            this.lblPhysique.Text = "Physique";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(265, 536);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(36, 13);
            this.lblSocial.TabIndex = 17;
            this.lblSocial.Text = "Social";
            // 
            // lblMental
            // 
            this.lblMental.AutoSize = true;
            this.lblMental.Location = new System.Drawing.Point(438, 535);
            this.lblMental.Name = "lblMental";
            this.lblMental.Size = new System.Drawing.Size(39, 13);
            this.lblMental.TabIndex = 18;
            this.lblMental.Text = "Mental";
            // 
            // txtPhysique
            // 
            this.txtPhysique.Enabled = false;
            this.txtPhysique.Location = new System.Drawing.Point(52, 553);
            this.txtPhysique.Name = "txtPhysique";
            this.txtPhysique.Size = new System.Drawing.Size(100, 20);
            this.txtPhysique.TabIndex = 19;
            this.txtPhysique.TextChanged += new System.EventHandler(this.txtPhysique_TextChanged);
            this.txtPhysique.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhysique_KeyPress);
            // 
            // txtSocial
            // 
            this.txtSocial.Enabled = false;
            this.txtSocial.Location = new System.Drawing.Point(233, 553);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 20;
            this.txtSocial.TextChanged += new System.EventHandler(this.txtSocial_TextChanged);
            this.txtSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocial_KeyPress);
            // 
            // txtMental
            // 
            this.txtMental.Enabled = false;
            this.txtMental.Location = new System.Drawing.Point(405, 553);
            this.txtMental.Name = "txtMental";
            this.txtMental.Size = new System.Drawing.Size(100, 20);
            this.txtMental.TabIndex = 21;
            this.txtMental.TextChanged += new System.EventHandler(this.txtMental_TextChanged);
            this.txtMental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMental_KeyPress);
            // 
            // rdbAutre
            // 
            this.rdbAutre.AutoSize = true;
            this.rdbAutre.Location = new System.Drawing.Point(185, 141);
            this.rdbAutre.Name = "rdbAutre";
            this.rdbAutre.Size = new System.Drawing.Size(100, 17);
            this.rdbAutre.TabIndex = 22;
            this.rdbAutre.TabStop = true;
            this.rdbAutre.Text = "Autre (Spécifier)";
            this.rdbAutre.UseVisualStyleBackColor = true;
            this.rdbAutre.CheckedChanged += new System.EventHandler(this.rdbAutre_CheckedChanged);
            // 
            // txtAutre
            // 
            this.txtAutre.Enabled = false;
            this.txtAutre.Location = new System.Drawing.Point(185, 172);
            this.txtAutre.Name = "txtAutre";
            this.txtAutre.Size = new System.Drawing.Size(100, 20);
            this.txtAutre.TabIndex = 23;
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.Location = new System.Drawing.Point(37, 593);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(34, 13);
            this.lblForce.TabIndex = 24;
            this.lblForce.Text = "Force";
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Location = new System.Drawing.Point(94, 593);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(58, 13);
            this.lblPerception.TabIndex = 25;
            this.lblPerception.Text = "Perception";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(170, 593);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(62, 13);
            this.lblConstitution.TabIndex = 26;
            this.lblConstitution.Text = "Constitution";
            // 
            // lblCharisme
            // 
            this.lblCharisme.AutoSize = true;
            this.lblCharisme.Location = new System.Drawing.Point(251, 593);
            this.lblCharisme.Name = "lblCharisme";
            this.lblCharisme.Size = new System.Drawing.Size(50, 13);
            this.lblCharisme.TabIndex = 27;
            this.lblCharisme.Text = "Charisme";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(324, 593);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 28;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // lblDexterite
            // 
            this.lblDexterite.AutoSize = true;
            this.lblDexterite.Location = new System.Drawing.Point(402, 593);
            this.lblDexterite.Name = "lblDexterite";
            this.lblDexterite.Size = new System.Drawing.Size(49, 13);
            this.lblDexterite.TabIndex = 29;
            this.lblDexterite.Text = "Dextérité";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Location = new System.Drawing.Point(472, 593);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(60, 13);
            this.lblResistance.TabIndex = 30;
            this.lblResistance.Text = "Résistance";
            // 
            // txtForce
            // 
            this.txtForce.Enabled = false;
            this.txtForce.Location = new System.Drawing.Point(11, 609);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(75, 20);
            this.txtForce.TabIndex = 31;
            this.txtForce.TextChanged += new System.EventHandler(this.txtForce_TextChanged);
            this.txtForce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForce_KeyPress);
            // 
            // txtPerception
            // 
            this.txtPerception.Enabled = false;
            this.txtPerception.Location = new System.Drawing.Point(83, 609);
            this.txtPerception.Name = "txtPerception";
            this.txtPerception.Size = new System.Drawing.Size(77, 20);
            this.txtPerception.TabIndex = 32;
            this.txtPerception.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerception_KeyPress);
            // 
            // txtConstitution
            // 
            this.txtConstitution.Enabled = false;
            this.txtConstitution.Location = new System.Drawing.Point(157, 609);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(84, 20);
            this.txtConstitution.TabIndex = 33;
            this.txtConstitution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConstitution_KeyPress);
            // 
            // txtCharisme
            // 
            this.txtCharisme.Enabled = false;
            this.txtCharisme.Location = new System.Drawing.Point(233, 609);
            this.txtCharisme.Name = "txtCharisme";
            this.txtCharisme.Size = new System.Drawing.Size(79, 20);
            this.txtCharisme.TabIndex = 34;
            this.txtCharisme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharisme_KeyPress);
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Enabled = false;
            this.txtIntelligence.Location = new System.Drawing.Point(311, 609);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(84, 20);
            this.txtIntelligence.TabIndex = 35;
            this.txtIntelligence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntelligence_KeyPress);
            // 
            // txtDexterite
            // 
            this.txtDexterite.Enabled = false;
            this.txtDexterite.Location = new System.Drawing.Point(391, 609);
            this.txtDexterite.Name = "txtDexterite";
            this.txtDexterite.Size = new System.Drawing.Size(75, 20);
            this.txtDexterite.TabIndex = 36;
            this.txtDexterite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDexterite_KeyPress);
            // 
            // txtResistance
            // 
            this.txtResistance.Enabled = false;
            this.txtResistance.Location = new System.Drawing.Point(462, 609);
            this.txtResistance.Name = "txtResistance";
            this.txtResistance.Size = new System.Drawing.Size(87, 20);
            this.txtResistance.TabIndex = 37;
            this.txtResistance.TextChanged += new System.EventHandler(this.txtResistance_TextChanged);
            this.txtResistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResistance_KeyPress);
            // 
            // lblLimiteCaractere
            // 
            this.lblLimiteCaractere.AutoSize = true;
            this.lblLimiteCaractere.Location = new System.Drawing.Point(49, 456);
            this.lblLimiteCaractere.Name = "lblLimiteCaractere";
            this.lblLimiteCaractere.Size = new System.Drawing.Size(125, 13);
            this.lblLimiteCaractere.TabIndex = 43;
            this.lblLimiteCaractere.Text = "Maximum 500 caractères";
            // 
            // lblAventures
            // 
            this.lblAventures.AutoSize = true;
            this.lblAventures.Location = new System.Drawing.Point(116, 509);
            this.lblAventures.Name = "lblAventures";
            this.lblAventures.Size = new System.Drawing.Size(85, 13);
            this.lblAventures.TabIndex = 44;
            this.lblAventures.Text = "Mode Aventures";
            // 
            // rdbModeAventures
            // 
            this.rdbModeAventures.AutoSize = true;
            this.rdbModeAventures.Location = new System.Drawing.Point(207, 509);
            this.rdbModeAventures.Name = "rdbModeAventures";
            this.rdbModeAventures.Size = new System.Drawing.Size(14, 13);
            this.rdbModeAventures.TabIndex = 45;
            this.rdbModeAventures.TabStop = true;
            this.rdbModeAventures.UseVisualStyleBackColor = true;
            this.rdbModeAventures.CheckedChanged += new System.EventHandler(this.rdbModeAventures_CheckedChanged);
            // 
            // lblModeNoeliste
            // 
            this.lblModeNoeliste.AutoSize = true;
            this.lblModeNoeliste.Location = new System.Drawing.Point(308, 509);
            this.lblModeNoeliste.Name = "lblModeNoeliste";
            this.lblModeNoeliste.Size = new System.Drawing.Size(75, 13);
            this.lblModeNoeliste.TabIndex = 46;
            this.lblModeNoeliste.Text = "Mode Noeliste";
            // 
            // rdbNoeliste
            // 
            this.rdbNoeliste.AutoSize = true;
            this.rdbNoeliste.Location = new System.Drawing.Point(389, 509);
            this.rdbNoeliste.Name = "rdbNoeliste";
            this.rdbNoeliste.Size = new System.Drawing.Size(14, 13);
            this.rdbNoeliste.TabIndex = 47;
            this.rdbNoeliste.TabStop = true;
            this.rdbNoeliste.UseVisualStyleBackColor = true;
            this.rdbNoeliste.CheckedChanged += new System.EventHandler(this.rdbNoeliste_CheckedChanged);
            // 
            // btnSoumettre
            // 
            this.btnSoumettre.Location = new System.Drawing.Point(237, 649);
            this.btnSoumettre.Name = "btnSoumettre";
            this.btnSoumettre.Size = new System.Drawing.Size(75, 23);
            this.btnSoumettre.TabIndex = 50;
            this.btnSoumettre.Text = "Soumettre";
            this.btnSoumettre.UseVisualStyleBackColor = true;
            this.btnSoumettre.Click += new System.EventHandler(this.btnSoumettre_Click);
            // 
            // pteBox
            // 
            this.pteBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pteBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pteBox.Location = new System.Drawing.Point(343, 15);
            this.pteBox.Name = "pteBox";
            this.pteBox.Size = new System.Drawing.Size(200, 200);
            this.pteBox.TabIndex = 51;
            this.pteBox.TabStop = false;
            this.pteBox.Click += new System.EventHandler(this.pteBox_Click);
            // 
            // btnImporterImage
            // 
            this.btnImporterImage.Location = new System.Drawing.Point(391, 232);
            this.btnImporterImage.Name = "btnImporterImage";
            this.btnImporterImage.Size = new System.Drawing.Size(91, 23);
            this.btnImporterImage.TabIndex = 52;
            this.btnImporterImage.Text = "Importer Image";
            this.btnImporterImage.UseVisualStyleBackColor = true;
            this.btnImporterImage.Click += new System.EventHandler(this.btnImporterImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 702);
            this.Controls.Add(this.btnImporterImage);
            this.Controls.Add(this.pteBox);
            this.Controls.Add(this.btnSoumettre);
            this.Controls.Add(this.rdbNoeliste);
            this.Controls.Add(this.lblModeNoeliste);
            this.Controls.Add(this.rdbModeAventures);
            this.Controls.Add(this.lblAventures);
            this.Controls.Add(this.lblLimiteCaractere);
            this.Controls.Add(this.txtResistance);
            this.Controls.Add(this.txtDexterite);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtCharisme);
            this.Controls.Add(this.txtConstitution);
            this.Controls.Add(this.txtPerception);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.lblResistance);
            this.Controls.Add(this.lblDexterite);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblCharisme);
            this.Controls.Add(this.lblConstitution);
            this.Controls.Add(this.lblPerception);
            this.Controls.Add(this.lblForce);
            this.Controls.Add(this.txtAutre);
            this.Controls.Add(this.rdbAutre);
            this.Controls.Add(this.txtMental);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtPhysique);
            this.Controls.Add(this.lblMental);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblPhysique);
            this.Controls.Add(this.btnGenerHistoire);
            this.Controls.Add(this.lblHistoire);
            this.Controls.Add(this.rtbHistoire);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.rdbFemme);
            this.Controls.Add(this.rdbHomme);
            this.Controls.Add(this.btnGenerPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnGenerNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Name = "Form1";
            this.Text = "Fiche Personnage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnGenerNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnGenerPrenom;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.RichTextBox rtbHistoire;
        private System.Windows.Forms.Label lblHistoire;
        private System.Windows.Forms.Button btnGenerHistoire;
        private System.Windows.Forms.Label lblPhysique;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblMental;
        private System.Windows.Forms.TextBox txtPhysique;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtMental;
        private System.Windows.Forms.RadioButton rdbAutre;
        private System.Windows.Forms.TextBox txtAutre;
        private System.Windows.Forms.Label lblForce;
        private System.Windows.Forms.Label lblPerception;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblCharisme;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblDexterite;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.TextBox txtPerception;
        private System.Windows.Forms.TextBox txtConstitution;
        private System.Windows.Forms.TextBox txtCharisme;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtDexterite;
        private System.Windows.Forms.TextBox txtResistance;
        private System.Windows.Forms.Label lblLimiteCaractere;
        private System.Windows.Forms.Label lblAventures;
        private System.Windows.Forms.RadioButton rdbModeAventures;
        private System.Windows.Forms.Label lblModeNoeliste;
        private System.Windows.Forms.RadioButton rdbNoeliste;
        private System.Windows.Forms.Button btnSoumettre;
        private System.Windows.Forms.PictureBox pteBox;
        private System.Windows.Forms.Button btnImporterImage;
    }
}

