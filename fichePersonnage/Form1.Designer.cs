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
            this.imgAvatarPerso = new System.Windows.Forms.PictureBox();
            this.btnImporter = new System.Windows.Forms.Button();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.rtbHistoire = new System.Windows.Forms.RichTextBox();
            this.lblHistoire = new System.Windows.Forms.Label();
            this.btnGenerHistoire = new System.Windows.Forms.Button();
            this.lblNbPoints = new System.Windows.Forms.Label();
            this.txtPointsRepartition = new System.Windows.Forms.TextBox();
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
            this.lblAttributs = new System.Windows.Forms.Label();
            this.btnAjouterAttribut = new System.Windows.Forms.Button();
            this.lblCompetences = new System.Windows.Forms.Label();
            this.btnAjoutCompetences = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLimiteCaractere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarPerso)).BeginInit();
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
            // imgAvatarPerso
            // 
            this.imgAvatarPerso.Location = new System.Drawing.Point(379, 15);
            this.imgAvatarPerso.Name = "imgAvatarPerso";
            this.imgAvatarPerso.Size = new System.Drawing.Size(154, 154);
            this.imgAvatarPerso.TabIndex = 6;
            this.imgAvatarPerso.TabStop = false;
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(421, 175);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(75, 23);
            this.btnImporter.TabIndex = 7;
            this.btnImporter.Text = "Importer";
            this.btnImporter.UseVisualStyleBackColor = true;
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
            // lblNbPoints
            // 
            this.lblNbPoints.AutoSize = true;
            this.lblNbPoints.Location = new System.Drawing.Point(24, 505);
            this.lblNbPoints.Name = "lblNbPoints";
            this.lblNbPoints.Size = new System.Drawing.Size(217, 13);
            this.lblNbPoints.TabIndex = 14;
            this.lblNbPoints.Text = "Nombre de points caractéristiques à répartir :";
            // 
            // txtPointsRepartition
            // 
            this.txtPointsRepartition.Location = new System.Drawing.Point(247, 502);
            this.txtPointsRepartition.Name = "txtPointsRepartition";
            this.txtPointsRepartition.Size = new System.Drawing.Size(100, 20);
            this.txtPointsRepartition.TabIndex = 15;
            this.txtPointsRepartition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPointsRepartition_KeyPress);
            // 
            // lblPhysique
            // 
            this.lblPhysique.AutoSize = true;
            this.lblPhysique.Location = new System.Drawing.Point(89, 576);
            this.lblPhysique.Name = "lblPhysique";
            this.lblPhysique.Size = new System.Drawing.Size(50, 13);
            this.lblPhysique.TabIndex = 16;
            this.lblPhysique.Text = "Physique";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(274, 575);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(36, 13);
            this.lblSocial.TabIndex = 17;
            this.lblSocial.Text = "Social";
            // 
            // lblMental
            // 
            this.lblMental.AutoSize = true;
            this.lblMental.Location = new System.Drawing.Point(447, 574);
            this.lblMental.Name = "lblMental";
            this.lblMental.Size = new System.Drawing.Size(39, 13);
            this.lblMental.TabIndex = 18;
            this.lblMental.Text = "Mental";
            // 
            // txtPhysique
            // 
            this.txtPhysique.Location = new System.Drawing.Point(61, 592);
            this.txtPhysique.Name = "txtPhysique";
            this.txtPhysique.Size = new System.Drawing.Size(100, 20);
            this.txtPhysique.TabIndex = 19;
            this.txtPhysique.TextChanged += new System.EventHandler(this.txtPhysique_TextChanged);
            this.txtPhysique.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhysique_KeyPress);
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(242, 592);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 20;
            this.txtSocial.TextChanged += new System.EventHandler(this.txtSocial_TextChanged);
            this.txtSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocial_KeyPress);
            // 
            // txtMental
            // 
            this.txtMental.Location = new System.Drawing.Point(414, 592);
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
            this.lblForce.Location = new System.Drawing.Point(46, 632);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(34, 13);
            this.lblForce.TabIndex = 24;
            this.lblForce.Text = "Force";
            // 
            // lblPerception
            // 
            this.lblPerception.AutoSize = true;
            this.lblPerception.Location = new System.Drawing.Point(103, 632);
            this.lblPerception.Name = "lblPerception";
            this.lblPerception.Size = new System.Drawing.Size(58, 13);
            this.lblPerception.TabIndex = 25;
            this.lblPerception.Text = "Perception";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(179, 632);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(62, 13);
            this.lblConstitution.TabIndex = 26;
            this.lblConstitution.Text = "Constitution";
            // 
            // lblCharisme
            // 
            this.lblCharisme.AutoSize = true;
            this.lblCharisme.Location = new System.Drawing.Point(260, 632);
            this.lblCharisme.Name = "lblCharisme";
            this.lblCharisme.Size = new System.Drawing.Size(50, 13);
            this.lblCharisme.TabIndex = 27;
            this.lblCharisme.Text = "Charisme";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(333, 632);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 28;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // lblDexterite
            // 
            this.lblDexterite.AutoSize = true;
            this.lblDexterite.Location = new System.Drawing.Point(411, 632);
            this.lblDexterite.Name = "lblDexterite";
            this.lblDexterite.Size = new System.Drawing.Size(49, 13);
            this.lblDexterite.TabIndex = 29;
            this.lblDexterite.Text = "Dextérité";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Location = new System.Drawing.Point(481, 632);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(60, 13);
            this.lblResistance.TabIndex = 30;
            this.lblResistance.Text = "Résistance";
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(20, 648);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(75, 20);
            this.txtForce.TabIndex = 31;
            this.txtForce.TextChanged += new System.EventHandler(this.txtForce_TextChanged);
            this.txtForce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForce_KeyPress);
            // 
            // txtPerception
            // 
            this.txtPerception.Location = new System.Drawing.Point(92, 648);
            this.txtPerception.Name = "txtPerception";
            this.txtPerception.Size = new System.Drawing.Size(77, 20);
            this.txtPerception.TabIndex = 32;
            this.txtPerception.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerception_KeyPress);
            // 
            // txtConstitution
            // 
            this.txtConstitution.Location = new System.Drawing.Point(166, 648);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(84, 20);
            this.txtConstitution.TabIndex = 33;
            this.txtConstitution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConstitution_KeyPress);
            // 
            // txtCharisme
            // 
            this.txtCharisme.Location = new System.Drawing.Point(242, 648);
            this.txtCharisme.Name = "txtCharisme";
            this.txtCharisme.Size = new System.Drawing.Size(79, 20);
            this.txtCharisme.TabIndex = 34;
            this.txtCharisme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharisme_KeyPress);
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(320, 648);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(84, 20);
            this.txtIntelligence.TabIndex = 35;
            this.txtIntelligence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntelligence_KeyPress);
            // 
            // txtDexterite
            // 
            this.txtDexterite.Location = new System.Drawing.Point(400, 648);
            this.txtDexterite.Name = "txtDexterite";
            this.txtDexterite.Size = new System.Drawing.Size(75, 20);
            this.txtDexterite.TabIndex = 36;
            this.txtDexterite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDexterite_KeyPress);
            // 
            // txtResistance
            // 
            this.txtResistance.Location = new System.Drawing.Point(471, 648);
            this.txtResistance.Name = "txtResistance";
            this.txtResistance.Size = new System.Drawing.Size(87, 20);
            this.txtResistance.TabIndex = 37;
            this.txtResistance.TextChanged += new System.EventHandler(this.txtResistance_TextChanged);
            this.txtResistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResistance_KeyPress);
            // 
            // lblAttributs
            // 
            this.lblAttributs.AutoSize = true;
            this.lblAttributs.Location = new System.Drawing.Point(265, 693);
            this.lblAttributs.Name = "lblAttributs";
            this.lblAttributs.Size = new System.Drawing.Size(45, 13);
            this.lblAttributs.TabIndex = 38;
            this.lblAttributs.Text = "Attributs";
            // 
            // btnAjouterAttribut
            // 
            this.btnAjouterAttribut.Location = new System.Drawing.Point(242, 709);
            this.btnAjouterAttribut.Name = "btnAjouterAttribut";
            this.btnAjouterAttribut.Size = new System.Drawing.Size(90, 23);
            this.btnAjouterAttribut.TabIndex = 39;
            this.btnAjouterAttribut.Text = "Ajouter Attributs";
            this.btnAjouterAttribut.UseVisualStyleBackColor = true;
            // 
            // lblCompetences
            // 
            this.lblCompetences.AutoSize = true;
            this.lblCompetences.Location = new System.Drawing.Point(249, 765);
            this.lblCompetences.Name = "lblCompetences";
            this.lblCompetences.Size = new System.Drawing.Size(72, 13);
            this.lblCompetences.TabIndex = 40;
            this.lblCompetences.Text = "Compétences";
            // 
            // btnAjoutCompetences
            // 
            this.btnAjoutCompetences.Location = new System.Drawing.Point(218, 781);
            this.btnAjoutCompetences.Name = "btnAjoutCompetences";
            this.btnAjoutCompetences.Size = new System.Drawing.Size(129, 23);
            this.btnAjoutCompetences.TabIndex = 41;
            this.btnAjoutCompetences.Text = "Ajouter Compétences";
            this.btnAjoutCompetences.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(361, 175);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(54, 13);
            this.lblSize.TabIndex = 42;
            this.lblSize.Text = "154 x 154";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 835);
            this.Controls.Add(this.lblLimiteCaractere);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnAjoutCompetences);
            this.Controls.Add(this.lblCompetences);
            this.Controls.Add(this.btnAjouterAttribut);
            this.Controls.Add(this.lblAttributs);
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
            this.Controls.Add(this.txtPointsRepartition);
            this.Controls.Add(this.lblNbPoints);
            this.Controls.Add(this.btnGenerHistoire);
            this.Controls.Add(this.lblHistoire);
            this.Controls.Add(this.rtbHistoire);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.rdbFemme);
            this.Controls.Add(this.rdbHomme);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.imgAvatarPerso);
            this.Controls.Add(this.btnGenerPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnGenerNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Name = "Form1";
            this.Text = "Fiche Personnage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarPerso)).EndInit();
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
        private System.Windows.Forms.PictureBox imgAvatarPerso;
        private System.Windows.Forms.Button btnImporter;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.RichTextBox rtbHistoire;
        private System.Windows.Forms.Label lblHistoire;
        private System.Windows.Forms.Button btnGenerHistoire;
        private System.Windows.Forms.Label lblNbPoints;
        private System.Windows.Forms.TextBox txtPointsRepartition;
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
        private System.Windows.Forms.Label lblAttributs;
        private System.Windows.Forms.Button btnAjouterAttribut;
        private System.Windows.Forms.Label lblCompetences;
        private System.Windows.Forms.Button btnAjoutCompetences;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLimiteCaractere;
    }
}

