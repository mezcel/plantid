using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//entity related
using TaxononmyEntities;
using MorphologyEntities;

using MySql.Data.MySqlClient; //use mysql


namespace DichotomousPlant
{
    public partial class frmAddPlant : Form
    {
        public static string connectionString = DichotomousPlant.ConnectionClass.GlobalConnectionVarClass;
        MySqlConnection conn = new MySqlConnection(connectionString);

        #region FormDrag
        //--- form drag vvv ----------------------------------------

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        #endregion FormDrag

        public frmAddPlant()
        {
            InitializeComponent();

            //cboSpecies
            cboSpecies.DataSource = getData("SELECT * FROM plantdb.species;");
            cboSpecies.DisplayMember = "speciesSymbol";
            cboSpecies.ValueMember = "speciesID";


            //cboArrangement
            cboArrangement.DataSource = getData("SELECT * FROM plantdb.leafarrangement;");
            cboArrangement.DisplayMember = "leafArrangementName";
            cboArrangement.ValueMember = "leafArrangementID";

            //cboStructure
            cboStructure.DataSource = getData("SELECT * FROM plantdb.leafStructure;");
            cboStructure.DisplayMember = "leafStructureName";
            cboStructure.ValueMember = "leafStructureID";

            //cboMargin
            cboMargin.DataSource = getData("SELECT * FROM plantdb.leafMargin;");
            cboMargin.DisplayMember = "leafMarginName";
            cboMargin.ValueMember = "leafMarginID";

            //cboAttachment
            cboAttachment.DataSource = getData("SELECT * FROM plantdb.leafAttachment;");
            cboAttachment.DisplayMember = "leafAttachmentName";
            cboAttachment.ValueMember = "leafAttachmentID";

            //cboShape
            cboShape.DataSource = getData("SELECT * FROM plantdb.leafShape;");
            cboShape.DisplayMember = "leafShapeName";
            cboShape.ValueMember = "leafShapeID";

            //cboApex
            cboApex.DataSource = getData("SELECT * FROM plantdb.leafShape;");
            cboApex.DisplayMember = "leafShapeName";
            cboApex.ValueMember = "leafShapeID";

            //cboBase
            cboBase.DataSource = getData("SELECT * FROM plantdb.leafShape;");
            cboBase.DisplayMember = "leafShapeName";
            cboBase.ValueMember = "leafShapeID";

            //cboSurfaceTop
            cboSurfaceTop.DataSource = getData("SELECT * FROM plantdb.leafSurface;");
            cboSurfaceTop.DisplayMember = "leafSurfaceName";
            cboSurfaceTop.ValueMember = "leafSurfaceID";

            //cboSurfaceBottom
            cboSurfaceBottom.DataSource = getData("SELECT * FROM plantdb.leafSurface;");
            cboSurfaceBottom.DisplayMember = "leafSurfaceName";
            cboSurfaceBottom.ValueMember = "leafSurfaceID";

            //cboVenation
            cboVenation.DataSource = getData("SELECT * FROM plantdb.leafVenation;");
            cboVenation.DisplayMember = "leafVenationName";
            cboVenation.ValueMember = "leafVenationID";

            //cboHairsTop
            cboHairsTop.DataSource = getData("SELECT * FROM plantdb.leafHairs;");
            cboHairsTop.DisplayMember = "leafHairsName";
            cboHairsTop.ValueMember = "leafHairsID";

            //cboHairsBottom
            cboHairsBottom.DataSource = getData("SELECT * FROM plantdb.leafHairs;");
            cboHairsBottom.DisplayMember = "leafHairsName";
            cboHairsBottom.ValueMember = "leafHairsID";

        }

        #region mysql datasets

        public DataTable getData(string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter mda = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            mda.Fill(table);
            return table;
        }

        #endregion 

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDichotomy dicot = new frmDichotomy();
            dicot.Visible = true;

            this.Close();
        }

        private void showConfirmationForm()
        {
            frmEditPlant confirm = new frmEditPlant();

            confirm.StartPosition = FormStartPosition.Manual;
            confirm.Left = this.Left;
            confirm.Top = this.Top;

            confirm.Show();
            this.Close();
        }

        private void frmAddPlant_Load(object sender, EventArgs e)
        {

            refreshInputs();

        }

        private void imageView()
        {
            if (rdoArrangement.Checked == true )
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.arrange;
            }
            else if (rdoStructure.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.leafstructure;
            }
            else if (rdoMargin.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.Margin;
            }
            else if (rdoAttachment.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.attach;
            }
            else if (rdoShape.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.leafshape;
            }
            else if (rdoApex.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.leaf_margins_2_tip;
            }
            else if (rdoBase.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.leaf_margins_3_base;
            }
            else if (rdoSurface.Checked == true)
            {
                pbxImages.Image = null;
            }
            else if (rdoVenation.Checked == true)
            {
                pbxImages.Image = DichotomousPlant.Properties.Resources.Venation ;
            }
            else if (rdoHairs.Checked == true)
            {
                pbxImages.Image = null;
            }
            else 
            {
                pbxImages.Image = null;
            }


        }

        #region rdoButtons
        
        private void rdoArrangement_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoStructure_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoMargin_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoAttachment_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoShape_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoApex_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoBase_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoSurface_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoVenation_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }

        private void rdoHairs_CheckedChanged(object sender, EventArgs e)
        {
            imageView();
        }
        #endregion rdoButtons

        private void btnAddNewDescription_Click(object sender, EventArgs e)
        {
            string inputCboSpeciesDisplay = cboSpecies.Text.ToString();

            int species_FK = (int)cboSpecies.SelectedValue;
            int leafArrangement_FK = (int)cboArrangement.SelectedValue;
            int leafStructure_FK = (int)cboStructure.SelectedValue;
            int leafMargin_FK = (int)cboMargin.SelectedValue;
            int leafAttachment_FK = (int)cboAttachment.SelectedValue;
            int leafShape_FK = (int)cboShape.SelectedValue;
            int leafApex_FK = (int)cboApex.SelectedValue;
            int leafBase_FK = (int)cboBase.SelectedValue;
            int leafSurfaceTop_FK = (int)cboSurfaceTop.SelectedValue;
            int leafSurfaceBottom_FK = (int)cboSurfaceBottom.SelectedValue;
            int leafVenation_FK = (int)cboVenation.SelectedValue;
            int leafHairsTop_FK = (int)cboHairsTop.SelectedValue;
            int leafHairsBottom_FK = (int)cboHairsBottom.SelectedValue;

            leafMorph morphology_new = new leafMorph(species_FK, leafArrangement_FK, leafStructure_FK, leafMargin_FK, leafAttachment_FK, leafShape_FK, leafApex_FK, leafBase_FK, leafSurfaceTop_FK, leafSurfaceBottom_FK, leafVenation_FK, leafHairsTop_FK, leafHairsBottom_FK);

            if (inputCboSpeciesDisplay != "")
            {
                lblAddDescription.ForeColor = Color.Black;

                lblExistingSpecies.ForeColor = Color.Black;
                lblExistingSpecies.BackColor = Color.Transparent;

                cboSpecies.BackColor = Color.White;
                rectangleShapeModifyDescription.BackColor = Color.Transparent;

                lblConfirmEdit.BackColor = Color.Transparent;
                lblConfirmEdit.ForeColor = Color.ForestGreen;
                lblConfirmEdit.BorderStyle = BorderStyle.None;

                if (ConnectionClass.identicalMorphology(morphology_new) == false)
                {
                    lblConfirmEdit.Text = "Confirm: '" + inputCboSpeciesDisplay + "', " + ConnectionClass.input_LeafMorphRecord(morphology_new);
                }
                else
                {
                    lblConfirmEdit.Text = "Error: '" + inputCboSpeciesDisplay + "', has this exact discription allready.";
                }
            }
            else if (inputCboSpeciesDisplay == "")
            {
                lblAddDescription.ForeColor = Color.Red;
                lblAddDescription.BackColor = Color.MistyRose;

                lblExistingSpecies.ForeColor = Color.Red;
                lblExistingSpecies.BackColor = Color.MistyRose;
                

                cboSpecies.BackColor = Color.MistyRose;
                rectangleShapeModifyDescription.BackColor = Color.MistyRose;

                lblConfirmEdit.BackColor = Color.Yellow ;
                lblConfirmEdit.ForeColor = Color.Red;
                lblConfirmEdit.BorderStyle = BorderStyle.Fixed3D;
                lblConfirmEdit.Text = "!!! Species (input) was left 'Blank/Empty'. !!!";
            }
            
        }
        
        private void btnAddNewSpecies_Click(object sender, EventArgs e)
        {
            string speciesString = txtSpecies.Text;
            string symbolString = txtSpeciesSymbol.Text;
            string speciesdescriptionString = txtDescription.Text;

            int genus_FK = 0;

            // species species_new = new species(speciesString, commonnameString, symbolString, speciesdescriptionString, genus_FK);
            species species_new = new species(speciesString, symbolString, speciesdescriptionString, genus_FK);

            if (txtSpecies.Text != "")
            {
                lblAddNewPlant.ForeColor = Color.Black;

                lblNewSpecies.ForeColor = Color.Black;
                lblNewSpecies.BackColor = Color.Transparent;

                lblConfirmAdd.BackColor = Color.Transparent;
                lblConfirmAdd.ForeColor = Color.ForestGreen;
                lblConfirmAdd.BorderStyle = BorderStyle.None;

                rectangleShapeModifyNewPlant.BackColor = Color.Transparent;

                if (ConnectionClass.identicalSpecies(species_new) == false)
                {
                    lblConfirmAdd.Text = ConnectionClass.input_SpeciesRecord(species_new);
                }
                else
                {
                    lblConfirmAdd.Text = "'" + speciesString + "' is a duplicate entry";
                }
            }
            else if (txtSpecies.Text == "") 
            {
                lblAddNewPlant.ForeColor = Color.Red;
                lblAddNewPlant.BackColor = Color.MistyRose;

                lblNewSpecies.ForeColor = Color.Red;
                lblNewSpecies.BackColor = Color.MistyRose;                

                txtSpecies.BackColor = Color.MistyRose;
                rectangleShapeModifyNewPlant.BackColor = Color.MistyRose;

                lblConfirmAdd.BackColor = Color.Yellow;
                lblConfirmAdd.ForeColor = Color.Red;
                lblConfirmAdd.BorderStyle = BorderStyle.Fixed3D;
                lblConfirmAdd.Text = "!!! Species (input) was left 'Blank/Empty'. !!!";

            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refreshInputs();
        }

        public void refreshInputs()
        {
            txtSpecies.Text = "";
            txtSpeciesSymbol.Text = "";
            txtDescription.Text = "";
            txtSpecies.BackColor = Color.White;

            // --- Comboxes ----

            cboSpecies.SelectedValue = 0;
            cboSpecies.SelectedText = "";
            cboSpecies.SelectedIndex = 0;

            cboArrangement.SelectedValue = 0;
            cboArrangement.SelectedText = "";
            cboArrangement.SelectedIndex = 0;

            cboStructure.SelectedValue = 0;
            cboStructure.SelectedText = "";
            cboStructure.SelectedIndex = 0;

            cboMargin.SelectedValue = 0;
            cboMargin.SelectedText = "";
            cboMargin.SelectedIndex = 0;

            cboAttachment.SelectedValue = 0;
            cboAttachment.SelectedText = "";
            cboAttachment.SelectedIndex = 0;

            cboShape.SelectedValue = 0;
            cboShape.SelectedText = "";
            cboShape.SelectedIndex = 0;

            cboApex.SelectedValue = 0;
            cboApex.SelectedText = "";
            cboApex.SelectedIndex = 0;

            cboBase.SelectedValue = 0;
            cboBase.SelectedText = "";
            cboBase.SelectedIndex = 0;

            cboSurfaceTop.SelectedValue = 0;
            cboSurfaceTop.SelectedText = "";
            cboSurfaceTop.SelectedIndex = 0;

            cboSurfaceBottom.SelectedValue = 0;
            cboSurfaceBottom.SelectedText = "";
            cboSurfaceBottom.SelectedIndex = 0;

            cboVenation.SelectedValue = 0;
            cboVenation.SelectedText = "";
            cboVenation.SelectedIndex = 0;

            cboHairsTop.SelectedValue = 0;
            cboHairsTop.SelectedText = "";
            cboHairsTop.SelectedIndex = 0;

            cboHairsBottom.SelectedValue = 0;
            cboHairsBottom.SelectedText = "";
            cboHairsBottom.SelectedIndex = 0;

            lblConfirmEdit.Text = "";
            lblConfirmAdd.Text = "";
            cboSpecies.BackColor = Color.White;

            lblAddDescription.ForeColor = Color.Black;
            lblAddDescription.BackColor = Color.Transparent;

            lblAddNewPlant.ForeColor = Color.Black;
            lblAddNewPlant.ForeColor = Color.Transparent;

            lblConfirmAdd.BorderStyle = BorderStyle.None;
            lblConfirmAdd.BackColor = Color.Transparent;
            lblConfirmAdd.ForeColor = Color.Black;
            rectangleShapeModifyNewPlant.BackColor = Color.Transparent;

            lblConfirmEdit.BorderStyle = BorderStyle.None;
            lblConfirmEdit.BackColor = Color.Transparent;
            lblConfirmEdit.ForeColor = Color.Black;
            rectangleShapeModifyDescription.BackColor = Color.Transparent;

            lblExistingSpecies.ForeColor = Color.Black;
            lblExistingSpecies.BackColor = Color.Transparent;

            lblNewSpecies.ForeColor = Color.Black;
            lblNewSpecies.BackColor = Color.Transparent;


            pbxImages.Image = null;
        }

        private void btnViewDB_Click(object sender, EventArgs e)
        {
            showConfirmationForm();
        }

    }
}
