namespace DichotomousPlant
{
    partial class frmEditPlant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPlant));
            this.label1 = new System.Windows.Forms.Label();
            this.lblExistingSpecies = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.leafMorphDataTable = new System.Windows.Forms.DataGridView();
            this.cbxSpeciesSymbol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.leafMorphDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Add an Additional description to a known Plant existing in Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExistingSpecies
            // 
            this.lblExistingSpecies.AutoSize = true;
            this.lblExistingSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingSpecies.Location = new System.Drawing.Point(12, 46);
            this.lblExistingSpecies.Name = "lblExistingSpecies";
            this.lblExistingSpecies.Size = new System.Drawing.Size(79, 22);
            this.lblExistingSpecies.TabIndex = 90;
            this.lblExistingSpecies.Text = "Species:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orchid;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(893, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 69);
            this.btnClose.TabIndex = 96;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // leafMorphDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.leafMorphDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.leafMorphDataTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leafMorphDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.leafMorphDataTable.ColumnHeadersHeight = 20;
            this.leafMorphDataTable.Location = new System.Drawing.Point(16, 83);
            this.leafMorphDataTable.Name = "leafMorphDataTable";
            this.leafMorphDataTable.RowHeadersVisible = false;
            this.leafMorphDataTable.RowHeadersWidth = 10;
            this.leafMorphDataTable.Size = new System.Drawing.Size(968, 459);
            this.leafMorphDataTable.TabIndex = 97;
            // 
            // cbxSpeciesSymbol
            // 
            this.cbxSpeciesSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpeciesSymbol.FormattingEnabled = true;
            this.cbxSpeciesSymbol.Location = new System.Drawing.Point(98, 46);
            this.cbxSpeciesSymbol.Name = "cbxSpeciesSymbol";
            this.cbxSpeciesSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbxSpeciesSymbol.TabIndex = 98;
            // 
            // frmEditPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 629);
            this.Controls.Add(this.cbxSpeciesSymbol);
            this.Controls.Add(this.leafMorphDataTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExistingSpecies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditPlant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmEditPlant";
            this.Load += new System.EventHandler(this.frmEditPlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leafMorphDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExistingSpecies;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView leafMorphDataTable;
        private System.Windows.Forms.ComboBox cbxSpeciesSymbol;

    }
}