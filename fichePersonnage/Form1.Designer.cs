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
            this.lblLimiteCaractere = new System.Windows.Forms.Label();
            this.btnSoumettre = new System.Windows.Forms.Button();
            this.pteBox = new System.Windows.Forms.PictureBox();
            this.btnImporterImage = new System.Windows.Forms.Button();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.txtPM = new System.Windows.Forms.TextBox();
            this.lblPV = new System.Windows.Forms.Label();
            this.lblPM = new System.Windows.Forms.Label();
            this.lblPointARepartir = new System.Windows.Forms.Label();
            this.btnRepartition = new System.Windows.Forms.Button();
            this.txtNnPointRepartir = new System.Windows.Forms.TextBox();
            this.lblNbRepartitionPhySocMen = new System.Windows.Forms.Label();
            this.txtNbRepartitionPhySocMen = new System.Windows.Forms.TextBox();
            this.btnRepartitionPhyMenSoc = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblClasseMetier = new System.Windows.Forms.Label();
            this.txtClasseMetier = new System.Windows.Forms.TextBox();
            this.lblLangues = new System.Windows.Forms.Label();
            this.rtbLangue = new System.Windows.Forms.RichTextBox();
            this.btnGenereLangues = new System.Windows.Forms.Button();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(24, 66);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(59, 50);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // btnGenerNom
            // 
            this.btnGenerNom.Location = new System.Drawing.Point(24, 92);
            this.btnGenerNom.Name = "btnGenerNom";
            this.btnGenerNom.Size = new System.Drawing.Size(98, 23);
            this.btnGenerNom.TabIndex = 2;
            this.btnGenerNom.Text = "Générer Nom";
            this.btnGenerNom.UseVisualStyleBackColor = true;
            this.btnGenerNom.Click += new System.EventHandler(this.btnGenerzNom_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(181, 66);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(211, 50);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // btnGenerPrenom
            // 
            this.btnGenerPrenom.Enabled = false;
            this.btnGenerPrenom.Location = new System.Drawing.Point(181, 92);
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
            this.rdbHomme.Location = new System.Drawing.Point(24, 176);
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
            this.rdbFemme.Location = new System.Drawing.Point(24, 210);
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
            this.lblSexe.Location = new System.Drawing.Point(59, 150);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(31, 13);
            this.lblSexe.TabIndex = 10;
            this.lblSexe.Text = "Sexe";
            // 
            // rtbHistoire
            // 
            this.rtbHistoire.Location = new System.Drawing.Point(60, 421);
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
            this.lblHistoire.Location = new System.Drawing.Point(85, 405);
            this.lblHistoire.Name = "lblHistoire";
            this.lblHistoire.Size = new System.Drawing.Size(42, 13);
            this.lblHistoire.TabIndex = 12;
            this.lblHistoire.Text = "Histoire";
            this.lblHistoire.Click += new System.EventHandler(this.lblHistoire_Click);
            // 
            // btnGenerHistoire
            // 
            this.btnGenerHistoire.Location = new System.Drawing.Point(395, 607);
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
            this.lblPhysique.Location = new System.Drawing.Point(116, 836);
            this.lblPhysique.Name = "lblPhysique";
            this.lblPhysique.Size = new System.Drawing.Size(50, 13);
            this.lblPhysique.TabIndex = 16;
            this.lblPhysique.Text = "Physique";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(301, 835);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(36, 13);
            this.lblSocial.TabIndex = 17;
            this.lblSocial.Text = "Social";
            // 
            // lblMental
            // 
            this.lblMental.AutoSize = true;
            this.lblMental.Location = new System.Drawing.Point(474, 834);
            this.lblMental.Name = "lblMental";
            this.lblMental.Size = new System.Drawing.Size(39, 13);
            this.lblMental.TabIndex = 18;
            this.lblMental.Text = "Mental";
            // 
            // txtPhysique
            // 
            this.txtPhysique.Location = new System.Drawing.Point(88, 852);
            this.txtPhysique.Name = "txtPhysique";
            this.txtPhysique.Size = new System.Drawing.Size(100, 20);
            this.txtPhysique.TabIndex = 19;
            this.txtPhysique.TextChanged += new System.EventHandler(this.txtPhysique_TextChanged);
            this.txtPhysique.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhysique_KeyPress);
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(269, 852);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 20;
            this.txtSocial.TextChanged += new System.EventHandler(this.txtSocial_TextChanged);
            this.txtSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocial_KeyPress);
            // 
            // txtMental
            // 
            this.txtMental.Location = new System.Drawing.Point(441, 852);
            this.txtMental.Name = "txtMental";
            this.txtMental.Size = new System.Drawing.Size(100, 20);
            this.txtMental.TabIndex = 21;
            this.txtMental.TextChanged += new System.EventHandler(this.txtMental_TextChanged);
            this.txtMental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMental_KeyPress);
            // 
            // rdbAutre
            // 
            this.rdbAutre.AutoSize = true;
            this.rdbAutre.Location = new System.Drawing.Point(181, 176);
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
            this.txtAutre.Location = new System.Drawing.Point(181, 207);
            this.txtAutre.Name = "txtAutre";
            this.txtAutre.Size = new System.Drawing.Size(100, 20);
            this.txtAutre.TabIndex = 23;
            // 
            // lblLimiteCaractere
            // 
            this.lblLimiteCaractere.AutoSize = true;
            this.lblLimiteCaractere.Location = new System.Drawing.Point(81, 607);
            this.lblLimiteCaractere.Name = "lblLimiteCaractere";
            this.lblLimiteCaractere.Size = new System.Drawing.Size(125, 13);
            this.lblLimiteCaractere.TabIndex = 43;
            this.lblLimiteCaractere.Text = "Maximum 500 caractères";
            // 
            // btnSoumettre
            // 
            this.btnSoumettre.Location = new System.Drawing.Point(658, 868);
            this.btnSoumettre.Name = "btnSoumettre";
            this.btnSoumettre.Size = new System.Drawing.Size(227, 129);
            this.btnSoumettre.TabIndex = 50;
            this.btnSoumettre.Text = "Soumettre la fiche";
            this.btnSoumettre.UseVisualStyleBackColor = true;
            this.btnSoumettre.Click += new System.EventHandler(this.btnSoumettre_Click);
            // 
            // pteBox
            // 
            this.pteBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pteBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pteBox.ErrorImage = null;
            this.pteBox.InitialImage = null;
            this.pteBox.Location = new System.Drawing.Point(320, 35);
            this.pteBox.Name = "pteBox";
            this.pteBox.Size = new System.Drawing.Size(300, 300);
            this.pteBox.TabIndex = 51;
            this.pteBox.TabStop = false;
            this.pteBox.Click += new System.EventHandler(this.pteBox_Click);
            // 
            // btnImporterImage
            // 
            this.btnImporterImage.Location = new System.Drawing.Point(422, 377);
            this.btnImporterImage.Name = "btnImporterImage";
            this.btnImporterImage.Size = new System.Drawing.Size(91, 23);
            this.btnImporterImage.TabIndex = 52;
            this.btnImporterImage.Text = "Importer Image";
            this.btnImporterImage.UseVisualStyleBackColor = true;
            this.btnImporterImage.Click += new System.EventHandler(this.btnImporterImage_Click);
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(88, 705);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(100, 20);
            this.txtPV.TabIndex = 53;
            this.txtPV.TextChanged += new System.EventHandler(this.txtPV_TextChanged);
            this.txtPV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPV_KeyDown);
            this.txtPV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // txtPM
            // 
            this.txtPM.Location = new System.Drawing.Point(454, 708);
            this.txtPM.Name = "txtPM";
            this.txtPM.Size = new System.Drawing.Size(100, 20);
            this.txtPM.TabIndex = 54;
            this.txtPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPM_KeyPress);
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.Location = new System.Drawing.Point(108, 689);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(68, 13);
            this.lblPV.TabIndex = 55;
            this.lblPV.Text = "Points de vie";
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Location = new System.Drawing.Point(460, 689);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(81, 13);
            this.lblPM.TabIndex = 56;
            this.lblPM.Text = "Points de Mana";
            // 
            // lblPointARepartir
            // 
            this.lblPointARepartir.AutoSize = true;
            this.lblPointARepartir.Location = new System.Drawing.Point(248, 645);
            this.lblPointARepartir.Name = "lblPointARepartir";
            this.lblPointARepartir.Size = new System.Drawing.Size(134, 13);
            this.lblPointARepartir.TabIndex = 57;
            this.lblPointARepartir.Text = "Nombre de points à répartir";
            // 
            // btnRepartition
            // 
            this.btnRepartition.Location = new System.Drawing.Point(251, 705);
            this.btnRepartition.Name = "btnRepartition";
            this.btnRepartition.Size = new System.Drawing.Size(130, 23);
            this.btnRepartition.TabIndex = 58;
            this.btnRepartition.Text = "Répartition automatique";
            this.btnRepartition.UseVisualStyleBackColor = true;
            this.btnRepartition.Click += new System.EventHandler(this.btnRepartition_Click);
            // 
            // txtNnPointRepartir
            // 
            this.txtNnPointRepartir.Location = new System.Drawing.Point(269, 661);
            this.txtNnPointRepartir.Name = "txtNnPointRepartir";
            this.txtNnPointRepartir.Size = new System.Drawing.Size(100, 20);
            this.txtNnPointRepartir.TabIndex = 59;
            this.txtNnPointRepartir.TextChanged += new System.EventHandler(this.txtNnPointRepartir_TextChanged);
            this.txtNnPointRepartir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNnPointRepartir_KeyPress);
            // 
            // lblNbRepartitionPhySocMen
            // 
            this.lblNbRepartitionPhySocMen.AutoSize = true;
            this.lblNbRepartitionPhySocMen.Location = new System.Drawing.Point(165, 772);
            this.lblNbRepartitionPhySocMen.Name = "lblNbRepartitionPhySocMen";
            this.lblNbRepartitionPhySocMen.Size = new System.Drawing.Size(134, 13);
            this.lblNbRepartitionPhySocMen.TabIndex = 60;
            this.lblNbRepartitionPhySocMen.Text = "Nombre de points à répartir";
            // 
            // txtNbRepartitionPhySocMen
            // 
            this.txtNbRepartitionPhySocMen.Location = new System.Drawing.Point(178, 798);
            this.txtNbRepartitionPhySocMen.Name = "txtNbRepartitionPhySocMen";
            this.txtNbRepartitionPhySocMen.Size = new System.Drawing.Size(100, 20);
            this.txtNbRepartitionPhySocMen.TabIndex = 61;
            // 
            // btnRepartitionPhyMenSoc
            // 
            this.btnRepartitionPhyMenSoc.Location = new System.Drawing.Point(357, 796);
            this.btnRepartitionPhyMenSoc.Name = "btnRepartitionPhyMenSoc";
            this.btnRepartitionPhyMenSoc.Size = new System.Drawing.Size(128, 23);
            this.btnRepartitionPhyMenSoc.TabIndex = 62;
            this.btnRepartitionPhyMenSoc.Text = "Répartition automatique";
            this.btnRepartitionPhyMenSoc.UseVisualStyleBackColor = true;
            this.btnRepartitionPhyMenSoc.Click += new System.EventHandler(this.btnRepartitionPhyMenSoc_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(22, 265);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 63;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(57, 249);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 64;
            this.lblAge.Text = "Âge";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(52, 299);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 65;
            this.lblRace.Text = "Race";
            // 
            // txtRace
            // 
            this.txtRace.AccessibleName = "";
            this.txtRace.Location = new System.Drawing.Point(22, 315);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(100, 20);
            this.txtRace.TabIndex = 66;
            this.txtRace.Text = "Humain";
            this.txtRace.TextChanged += new System.EventHandler(this.txtRace_TextChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(406, 350);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(132, 13);
            this.lblFormat.TabIndex = 67;
            this.lblFormat.Text = "Image au format 300 * 300";
            // 
            // lblClasseMetier
            // 
            this.lblClasseMetier.AutoSize = true;
            this.lblClasseMetier.Location = new System.Drawing.Point(32, 350);
            this.lblClasseMetier.Name = "lblClasseMetier";
            this.lblClasseMetier.Size = new System.Drawing.Size(72, 13);
            this.lblClasseMetier.TabIndex = 68;
            this.lblClasseMetier.Text = "Classe/Métier";
            // 
            // txtClasseMetier
            // 
            this.txtClasseMetier.Location = new System.Drawing.Point(22, 366);
            this.txtClasseMetier.Name = "txtClasseMetier";
            this.txtClasseMetier.Size = new System.Drawing.Size(100, 20);
            this.txtClasseMetier.TabIndex = 69;
            // 
            // lblLangues
            // 
            this.lblLangues.AutoSize = true;
            this.lblLangues.Location = new System.Drawing.Point(289, 892);
            this.lblLangues.Name = "lblLangues";
            this.lblLangues.Size = new System.Drawing.Size(48, 13);
            this.lblLangues.TabIndex = 70;
            this.lblLangues.Text = "Langues";
            // 
            // rtbLangue
            // 
            this.rtbLangue.Location = new System.Drawing.Point(62, 909);
            this.rtbLangue.Name = "rtbLangue";
            this.rtbLangue.Size = new System.Drawing.Size(503, 59);
            this.rtbLangue.TabIndex = 71;
            this.rtbLangue.Text = "";
            // 
            // btnGenereLangues
            // 
            this.btnGenereLangues.Location = new System.Drawing.Point(270, 974);
            this.btnGenereLangues.Name = "btnGenereLangues";
            this.btnGenereLangues.Size = new System.Drawing.Size(99, 23);
            this.btnGenereLangues.TabIndex = 72;
            this.btnGenereLangues.Text = "Générer langue(s)";
            this.btnGenereLangues.UseVisualStyleBackColor = true;
            this.btnGenereLangues.Click += new System.EventHandler(this.btnGenereLangues_Click);
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(211, 249);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(41, 13);
            this.lblNiveau.TabIndex = 73;
            this.lblNiveau.Text = "Niveau";
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(201, 265);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(53, 20);
            this.txtNiveau.TabIndex = 74;
            this.txtNiveau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNiveau_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 1061);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.btnGenereLangues);
            this.Controls.Add(this.rtbLangue);
            this.Controls.Add(this.lblLangues);
            this.Controls.Add(this.txtClasseMetier);
            this.Controls.Add(this.lblClasseMetier);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnRepartitionPhyMenSoc);
            this.Controls.Add(this.txtNbRepartitionPhySocMen);
            this.Controls.Add(this.lblNbRepartitionPhySocMen);
            this.Controls.Add(this.txtNnPointRepartir);
            this.Controls.Add(this.btnRepartition);
            this.Controls.Add(this.lblPointARepartir);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.lblPV);
            this.Controls.Add(this.txtPM);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.btnImporterImage);
            this.Controls.Add(this.pteBox);
            this.Controls.Add(this.btnSoumettre);
            this.Controls.Add(this.lblLimiteCaractere);
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
        private System.Windows.Forms.Label lblLimiteCaractere;
        private System.Windows.Forms.Button btnSoumettre;
        private System.Windows.Forms.PictureBox pteBox;
        private System.Windows.Forms.Button btnImporterImage;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.TextBox txtPM;
        private System.Windows.Forms.Label lblPV;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.Label lblPointARepartir;
        private System.Windows.Forms.Button btnRepartition;
        private System.Windows.Forms.TextBox txtNnPointRepartir;
        private System.Windows.Forms.Label lblNbRepartitionPhySocMen;
        private System.Windows.Forms.TextBox txtNbRepartitionPhySocMen;
        private System.Windows.Forms.Button btnRepartitionPhyMenSoc;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblClasseMetier;
        private System.Windows.Forms.TextBox txtClasseMetier;
        private System.Windows.Forms.Label lblLangues;
        private System.Windows.Forms.RichTextBox rtbLangue;
        private System.Windows.Forms.Button btnGenereLangues;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.TextBox txtNiveau;
    }
}

