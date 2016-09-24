namespace DichotomousPlant
{
    partial class frmDichotomy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichotomy));
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnLearningDB = new System.Windows.Forms.Button();
            this.cboMargin = new System.Windows.Forms.ComboBox();
            this.cboSurface = new System.Windows.Forms.ComboBox();
            this.cboShape = new System.Windows.Forms.ComboBox();
            this.cboAttachment = new System.Windows.Forms.ComboBox();
            this.cboVenation = new System.Windows.Forms.ComboBox();
            this.cboHairs = new System.Windows.Forms.ComboBox();
            this.pbMorph = new System.Windows.Forms.PictureBox();
            this.btnArrangement = new System.Windows.Forms.Button();
            this.cbxArangement = new System.Windows.Forms.CheckBox();
            this.cbxStructure = new System.Windows.Forms.CheckBox();
            this.btnStructure = new System.Windows.Forms.Button();
            this.cbxMargin = new System.Windows.Forms.CheckBox();
            this.btnMargin = new System.Windows.Forms.Button();
            this.cbxSurface = new System.Windows.Forms.CheckBox();
            this.btnSurface = new System.Windows.Forms.Button();
            this.cbxShape = new System.Windows.Forms.CheckBox();
            this.btnShape = new System.Windows.Forms.Button();
            this.cbxAttachment = new System.Windows.Forms.CheckBox();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.cbxHairs = new System.Windows.Forms.CheckBox();
            this.btnHairs = new System.Windows.Forms.Button();
            this.cbxVenation = new System.Windows.Forms.CheckBox();
            this.btnVenation = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCommonName = new System.Windows.Forms.Label();
            this.lblSciName = new System.Windows.Forms.Label();
            this.cboStructure = new System.Windows.Forms.ComboBox();
            this.cboArrangement = new System.Windows.Forms.ComboBox();
            this.lbxSearchResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMatch
            // 
            this.btnMatch.Enabled = false;
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(641, 519);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(210, 44);
            this.btnMatch.TabIndex = 0;
            this.btnMatch.Text = "Visual Conirmation";
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // btnLearningDB
            // 
            this.btnLearningDB.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLearningDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearningDB.Location = new System.Drawing.Point(244, 519);
            this.btnLearningDB.Name = "btnLearningDB";
            this.btnLearningDB.Size = new System.Drawing.Size(322, 44);
            this.btnLearningDB.TabIndex = 1;
            this.btnLearningDB.Text = "Observation (Editor)";
            this.btnLearningDB.UseVisualStyleBackColor = false;
            this.btnLearningDB.Click += new System.EventHandler(this.btnLearningDB_Click);
            // 
            // cboMargin
            // 
            this.cboMargin.BackColor = System.Drawing.Color.White;
            this.cboMargin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMargin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMargin.FormattingEnabled = true;
            this.cboMargin.Location = new System.Drawing.Point(88, 199);
            this.cboMargin.Name = "cboMargin";
            this.cboMargin.Size = new System.Drawing.Size(150, 28);
            this.cboMargin.TabIndex = 4;
            this.cboMargin.SelectedIndexChanged += new System.EventHandler(this.cboMargin_SelectedIndexChanged);
            // 
            // cboSurface
            // 
            this.cboSurface.BackColor = System.Drawing.Color.White;
            this.cboSurface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSurface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSurface.FormattingEnabled = true;
            this.cboSurface.Location = new System.Drawing.Point(88, 328);
            this.cboSurface.Name = "cboSurface";
            this.cboSurface.Size = new System.Drawing.Size(150, 28);
            this.cboSurface.TabIndex = 7;
            this.cboSurface.SelectedIndexChanged += new System.EventHandler(this.cboSurface_SelectedIndexChanged);
            // 
            // cboShape
            // 
            this.cboShape.BackColor = System.Drawing.Color.White;
            this.cboShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShape.FormattingEnabled = true;
            this.cboShape.Location = new System.Drawing.Point(88, 285);
            this.cboShape.Name = "cboShape";
            this.cboShape.Size = new System.Drawing.Size(150, 28);
            this.cboShape.TabIndex = 6;
            this.cboShape.SelectedIndexChanged += new System.EventHandler(this.cboShape_SelectedIndexChanged);
            // 
            // cboAttachment
            // 
            this.cboAttachment.BackColor = System.Drawing.Color.White;
            this.cboAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboAttachment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAttachment.FormattingEnabled = true;
            this.cboAttachment.Location = new System.Drawing.Point(88, 242);
            this.cboAttachment.Name = "cboAttachment";
            this.cboAttachment.Size = new System.Drawing.Size(150, 28);
            this.cboAttachment.TabIndex = 5;
            this.cboAttachment.SelectedIndexChanged += new System.EventHandler(this.cboAttachment_SelectedIndexChanged);
            // 
            // cboVenation
            // 
            this.cboVenation.BackColor = System.Drawing.Color.White;
            this.cboVenation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboVenation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenation.FormattingEnabled = true;
            this.cboVenation.Location = new System.Drawing.Point(88, 369);
            this.cboVenation.Name = "cboVenation";
            this.cboVenation.Size = new System.Drawing.Size(150, 28);
            this.cboVenation.TabIndex = 8;
            this.cboVenation.SelectedIndexChanged += new System.EventHandler(this.cboVenation_SelectedIndexChanged);
            // 
            // cboHairs
            // 
            this.cboHairs.BackColor = System.Drawing.Color.White;
            this.cboHairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboHairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHairs.FormattingEnabled = true;
            this.cboHairs.Location = new System.Drawing.Point(88, 412);
            this.cboHairs.Name = "cboHairs";
            this.cboHairs.Size = new System.Drawing.Size(150, 28);
            this.cboHairs.TabIndex = 9;
            this.cboHairs.SelectedIndexChanged += new System.EventHandler(this.cboHairs_SelectedIndexChanged);
            // 
            // pbMorph
            // 
            this.pbMorph.BackColor = System.Drawing.Color.Transparent;
            this.pbMorph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMorph.Location = new System.Drawing.Point(578, 285);
            this.pbMorph.Name = "pbMorph";
            this.pbMorph.Size = new System.Drawing.Size(336, 163);
            this.pbMorph.TabIndex = 10;
            this.pbMorph.TabStop = false;
            // 
            // btnArrangement
            // 
            this.btnArrangement.BackColor = System.Drawing.Color.BurlyWood;
            this.btnArrangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrangement.Location = new System.Drawing.Point(244, 113);
            this.btnArrangement.Name = "btnArrangement";
            this.btnArrangement.Size = new System.Drawing.Size(145, 36);
            this.btnArrangement.TabIndex = 12;
            this.btnArrangement.UseVisualStyleBackColor = false;
            this.btnArrangement.Click += new System.EventHandler(this.btnArrangement_Click);
            // 
            // cbxArangement
            // 
            this.cbxArangement.BackColor = System.Drawing.Color.Transparent;
            this.cbxArangement.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxArangement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxArangement.FlatAppearance.BorderSize = 5;
            this.cbxArangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArangement.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxArangement.Location = new System.Drawing.Point(88, 116);
            this.cbxArangement.Name = "cbxArangement";
            this.cbxArangement.Size = new System.Drawing.Size(478, 33);
            this.cbxArangement.TabIndex = 13;
            this.cbxArangement.Text = "arrangement";
            this.cbxArangement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxArangement.UseVisualStyleBackColor = false;
            this.cbxArangement.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxArangement_MouseClick);
            // 
            // cbxStructure
            // 
            this.cbxStructure.BackColor = System.Drawing.Color.Transparent;
            this.cbxStructure.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxStructure.FlatAppearance.BorderSize = 5;
            this.cbxStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStructure.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxStructure.Location = new System.Drawing.Point(88, 159);
            this.cbxStructure.Name = "cbxStructure";
            this.cbxStructure.Size = new System.Drawing.Size(478, 33);
            this.cbxStructure.TabIndex = 15;
            this.cbxStructure.Text = "structure";
            this.cbxStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxStructure.UseVisualStyleBackColor = false;
            this.cbxStructure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxStructure_MouseClick);
            // 
            // btnStructure
            // 
            this.btnStructure.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStructure.Location = new System.Drawing.Point(244, 156);
            this.btnStructure.Name = "btnStructure";
            this.btnStructure.Size = new System.Drawing.Size(145, 36);
            this.btnStructure.TabIndex = 14;
            this.btnStructure.UseVisualStyleBackColor = false;
            this.btnStructure.Click += new System.EventHandler(this.btnStructure_Click);
            // 
            // cbxMargin
            // 
            this.cbxMargin.BackColor = System.Drawing.Color.Transparent;
            this.cbxMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMargin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMargin.FlatAppearance.BorderSize = 5;
            this.cbxMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMargin.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxMargin.Location = new System.Drawing.Point(88, 202);
            this.cbxMargin.Name = "cbxMargin";
            this.cbxMargin.Size = new System.Drawing.Size(478, 33);
            this.cbxMargin.TabIndex = 17;
            this.cbxMargin.Text = "margin";
            this.cbxMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMargin.UseVisualStyleBackColor = false;
            this.cbxMargin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxMargin_MouseClick);
            // 
            // btnMargin
            // 
            this.btnMargin.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMargin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMargin.Location = new System.Drawing.Point(244, 199);
            this.btnMargin.Name = "btnMargin";
            this.btnMargin.Size = new System.Drawing.Size(145, 36);
            this.btnMargin.TabIndex = 16;
            this.btnMargin.UseVisualStyleBackColor = false;
            this.btnMargin.Click += new System.EventHandler(this.btnMargin_Click);
            // 
            // cbxSurface
            // 
            this.cbxSurface.BackColor = System.Drawing.Color.Transparent;
            this.cbxSurface.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSurface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSurface.FlatAppearance.BorderSize = 5;
            this.cbxSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSurface.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxSurface.Location = new System.Drawing.Point(88, 331);
            this.cbxSurface.Name = "cbxSurface";
            this.cbxSurface.Size = new System.Drawing.Size(478, 33);
            this.cbxSurface.TabIndex = 23;
            this.cbxSurface.Text = "surface";
            this.cbxSurface.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSurface.UseVisualStyleBackColor = false;
            this.cbxSurface.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxSurface_MouseClick);
            // 
            // btnSurface
            // 
            this.btnSurface.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSurface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurface.Location = new System.Drawing.Point(244, 328);
            this.btnSurface.Name = "btnSurface";
            this.btnSurface.Size = new System.Drawing.Size(145, 36);
            this.btnSurface.TabIndex = 22;
            this.btnSurface.UseVisualStyleBackColor = false;
            this.btnSurface.Click += new System.EventHandler(this.btnSurface_Click);
            // 
            // cbxShape
            // 
            this.cbxShape.BackColor = System.Drawing.Color.Transparent;
            this.cbxShape.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShape.FlatAppearance.BorderSize = 5;
            this.cbxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShape.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxShape.Location = new System.Drawing.Point(88, 288);
            this.cbxShape.Name = "cbxShape";
            this.cbxShape.Size = new System.Drawing.Size(478, 33);
            this.cbxShape.TabIndex = 21;
            this.cbxShape.Text = "shape";
            this.cbxShape.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShape.UseVisualStyleBackColor = false;
            this.cbxShape.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxShape_MouseClick);
            // 
            // btnShape
            // 
            this.btnShape.BackColor = System.Drawing.Color.BurlyWood;
            this.btnShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShape.Location = new System.Drawing.Point(244, 285);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(145, 36);
            this.btnShape.TabIndex = 20;
            this.btnShape.UseVisualStyleBackColor = false;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // cbxAttachment
            // 
            this.cbxAttachment.BackColor = System.Drawing.Color.Transparent;
            this.cbxAttachment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAttachment.FlatAppearance.BorderSize = 5;
            this.cbxAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAttachment.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxAttachment.Location = new System.Drawing.Point(88, 245);
            this.cbxAttachment.Name = "cbxAttachment";
            this.cbxAttachment.Size = new System.Drawing.Size(478, 33);
            this.cbxAttachment.TabIndex = 19;
            this.cbxAttachment.Text = "attachment";
            this.cbxAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxAttachment.UseVisualStyleBackColor = false;
            this.cbxAttachment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxAttachment_MouseClick);
            // 
            // btnAttachment
            // 
            this.btnAttachment.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachment.Location = new System.Drawing.Point(244, 242);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(145, 36);
            this.btnAttachment.TabIndex = 18;
            this.btnAttachment.UseVisualStyleBackColor = false;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // cbxHairs
            // 
            this.cbxHairs.BackColor = System.Drawing.Color.Transparent;
            this.cbxHairs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxHairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxHairs.FlatAppearance.BorderSize = 5;
            this.cbxHairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHairs.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxHairs.Location = new System.Drawing.Point(88, 415);
            this.cbxHairs.Name = "cbxHairs";
            this.cbxHairs.Size = new System.Drawing.Size(478, 33);
            this.cbxHairs.TabIndex = 27;
            this.cbxHairs.Text = "hairs";
            this.cbxHairs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxHairs.UseVisualStyleBackColor = false;
            this.cbxHairs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxHairs_MouseClick);
            // 
            // btnHairs
            // 
            this.btnHairs.BackColor = System.Drawing.Color.BurlyWood;
            this.btnHairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHairs.Location = new System.Drawing.Point(244, 412);
            this.btnHairs.Name = "btnHairs";
            this.btnHairs.Size = new System.Drawing.Size(145, 36);
            this.btnHairs.TabIndex = 26;
            this.btnHairs.UseVisualStyleBackColor = false;
            this.btnHairs.Click += new System.EventHandler(this.btnHairs_Click);
            // 
            // cbxVenation
            // 
            this.cbxVenation.BackColor = System.Drawing.Color.Transparent;
            this.cbxVenation.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxVenation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxVenation.FlatAppearance.BorderSize = 5;
            this.cbxVenation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVenation.ForeColor = System.Drawing.Color.ForestGreen;
            this.cbxVenation.Location = new System.Drawing.Point(88, 372);
            this.cbxVenation.Name = "cbxVenation";
            this.cbxVenation.Size = new System.Drawing.Size(478, 33);
            this.cbxVenation.TabIndex = 25;
            this.cbxVenation.Text = "venation";
            this.cbxVenation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxVenation.UseVisualStyleBackColor = false;
            this.cbxVenation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxVenation_MouseClick);
            // 
            // btnVenation
            // 
            this.btnVenation.BackColor = System.Drawing.Color.BurlyWood;
            this.btnVenation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenation.Location = new System.Drawing.Point(244, 369);
            this.btnVenation.Name = "btnVenation";
            this.btnVenation.Size = new System.Drawing.Size(145, 36);
            this.btnVenation.TabIndex = 24;
            this.btnVenation.UseVisualStyleBackColor = false;
            this.btnVenation.Click += new System.EventHandler(this.btnVenation_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orchid;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(88, 519);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 44);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home / Exit";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Font = new System.Drawing.Font("Webdings", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrev.Location = new System.Drawing.Point(578, 519);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(57, 44);
            this.btnPrev.TabIndex = 29;
            this.btnPrev.Text = "9";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Webdings", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNext.Location = new System.Drawing.Point(857, 519);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 44);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = ":";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(88, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(826, 39);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "lblDescription";
            // 
            // lblCommonName
            // 
            this.lblCommonName.BackColor = System.Drawing.Color.Transparent;
            this.lblCommonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonName.Location = new System.Drawing.Point(578, 459);
            this.lblCommonName.Name = "lblCommonName";
            this.lblCommonName.Size = new System.Drawing.Size(336, 23);
            this.lblCommonName.TabIndex = 33;
            this.lblCommonName.Text = "common name";
            this.lblCommonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSciName
            // 
            this.lblSciName.BackColor = System.Drawing.Color.Transparent;
            this.lblSciName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSciName.Location = new System.Drawing.Point(578, 482);
            this.lblSciName.Name = "lblSciName";
            this.lblSciName.Size = new System.Drawing.Size(336, 23);
            this.lblSciName.TabIndex = 34;
            this.lblSciName.Text = "sci name";
            this.lblSciName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboStructure
            // 
            this.cboStructure.BackColor = System.Drawing.Color.White;
            this.cboStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStructure.FormattingEnabled = true;
            this.cboStructure.Location = new System.Drawing.Point(88, 156);
            this.cboStructure.Name = "cboStructure";
            this.cboStructure.Size = new System.Drawing.Size(150, 28);
            this.cboStructure.TabIndex = 35;
            this.cboStructure.SelectedIndexChanged += new System.EventHandler(this.cboStructure_SelectedIndexChanged);
            // 
            // cboArrangement
            // 
            this.cboArrangement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArrangement.FormattingEnabled = true;
            this.cboArrangement.Location = new System.Drawing.Point(88, 112);
            this.cboArrangement.Name = "cboArrangement";
            this.cboArrangement.Size = new System.Drawing.Size(150, 28);
            this.cboArrangement.TabIndex = 36;
            this.cboArrangement.SelectedIndexChanged += new System.EventHandler(this.cboArrangement_SelectedIndexChanged);
            // 
            // lbxSearchResult
            // 
            this.lbxSearchResult.BackColor = System.Drawing.Color.White;
            this.lbxSearchResult.ColumnWidth = 2;
            this.lbxSearchResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSearchResult.FormattingEnabled = true;
            this.lbxSearchResult.ItemHeight = 20;
            this.lbxSearchResult.Location = new System.Drawing.Point(578, 112);
            this.lbxSearchResult.Name = "lbxSearchResult";
            this.lbxSearchResult.ScrollAlwaysVisible = true;
            this.lbxSearchResult.Size = new System.Drawing.Size(336, 164);
            this.lbxSearchResult.TabIndex = 37;
            this.lbxSearchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxSearchResult_MouseClick);
            // 
            // frmDichotomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DichotomousPlant.Properties.Resources.work_background_v3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 629);
            this.Controls.Add(this.lbxSearchResult);
            this.Controls.Add(this.cboArrangement);
            this.Controls.Add(this.cboStructure);
            this.Controls.Add(this.lblSciName);
            this.Controls.Add(this.lblCommonName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnHairs);
            this.Controls.Add(this.btnVenation);
            this.Controls.Add(this.btnSurface);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.btnMargin);
            this.Controls.Add(this.btnStructure);
            this.Controls.Add(this.btnArrangement);
            this.Controls.Add(this.pbMorph);
            this.Controls.Add(this.cboHairs);
            this.Controls.Add(this.cboVenation);
            this.Controls.Add(this.cboSurface);
            this.Controls.Add(this.cboShape);
            this.Controls.Add(this.cboAttachment);
            this.Controls.Add(this.cboMargin);
            this.Controls.Add(this.btnLearningDB);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.cbxArangement);
            this.Controls.Add(this.cbxHairs);
            this.Controls.Add(this.cbxVenation);
            this.Controls.Add(this.cbxSurface);
            this.Controls.Add(this.cbxShape);
            this.Controls.Add(this.cbxAttachment);
            this.Controls.Add(this.cbxMargin);
            this.Controls.Add(this.cbxStructure);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDichotomy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dichotomy Key";
            this.Load += new System.EventHandler(this.frmDichotomy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMorph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnLearningDB;
        private System.Windows.Forms.ComboBox cboMargin;
        private System.Windows.Forms.ComboBox cboSurface;
        private System.Windows.Forms.ComboBox cboShape;
        private System.Windows.Forms.ComboBox cboAttachment;
        private System.Windows.Forms.ComboBox cboVenation;
        private System.Windows.Forms.ComboBox cboHairs;
        private System.Windows.Forms.PictureBox pbMorph;
        private System.Windows.Forms.Button btnArrangement;
        private System.Windows.Forms.CheckBox cbxArangement;
        private System.Windows.Forms.CheckBox cbxStructure;
        private System.Windows.Forms.Button btnStructure;
        private System.Windows.Forms.CheckBox cbxMargin;
        private System.Windows.Forms.Button btnMargin;
        private System.Windows.Forms.CheckBox cbxSurface;
        private System.Windows.Forms.Button btnSurface;
        private System.Windows.Forms.CheckBox cbxShape;
        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.CheckBox cbxAttachment;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.CheckBox cbxHairs;
        private System.Windows.Forms.Button btnHairs;
        private System.Windows.Forms.CheckBox cbxVenation;
        private System.Windows.Forms.Button btnVenation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCommonName;
        private System.Windows.Forms.Label lblSciName;
        private System.Windows.Forms.ComboBox cboStructure;
        private System.Windows.Forms.ComboBox cboArrangement;
        private System.Windows.Forms.ListBox lbxSearchResult;
    }
}

