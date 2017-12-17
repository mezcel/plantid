using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// SQL Related
using System.Configuration;
using System.Data.SqlClient;

using TaxononmyEntities;
using MorphologyEntities;

using MySql.Data.MySqlClient; //use mysql

namespace DichotomousPlant
{
    
    public partial class frmDichotomy : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=plantdb;Integrated Security=True");
        //SqlCommand command;

        //public static string connectionString = DichotomousPlant.ConnectionClass.GlobalConnectionVarClass;
        //MySqlConnection conn = new MySqlConnection(connectionString);
        
        
        //public static string connectionString = DichotomousPlant.ConnectionClass.GlobalConnectionVarClass;

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
          
        public frmDichotomy()
        {
            InitializeComponent();

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

            //cboSurface
            cboSurface.DataSource = getData("SELECT * FROM plantdb.leafSurface;");
            cboSurface.DisplayMember = "leafSurfaceName";
            cboSurface.ValueMember = "leafSurfaceID";

            //cboVenation
            cboVenation.DataSource = getData("SELECT * FROM plantdb.leafVenation;");
            cboVenation.DisplayMember = "leafVenationName";
            cboVenation.ValueMember = "leafVenationID";

            //cboHairs
            cboHairs.DataSource = getData("SELECT * FROM plantdb.leafHairs;");
            cboHairs.DisplayMember = "leafHairsName";
            cboHairs.ValueMember = "leafHairsID";
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDichotomy_Load(object sender, EventArgs e)
        {

            lblCommonName.Text  = "";
            lblSciName.Text = "";

            //initialize lisbox view
            string displayField = "speciesName";
            string indexField = "speciesID";
            performQueryforListbox("SELECT speciesID, genusName, speciesName as speciesName FROM plantdb.species, plantdb.genus WHERE species.genus_FK = genus.genusID", indexField, displayField);

            lbxSearchResult.DataSource = null;
            //fillListBoxusingDataReader();

            btnArrangement.Text = "";
            btnStructure.Text = "";
            btnMargin.Text = "";
            btnAttachment.Text = "";
            btnShape.Text = "";
            btnSurface.Text = "";
            btnVenation.Text = "";
            btnHairs.Text = "";
        }

        #region ComboBox_Event

        private void cboArrangement_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnArrangement.Text = cboArrangement.Text;
            if (cbxArangement.Checked == true) 
            {
                determinSelections();
            }
        }

        private void cboStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStructure.Text = cboStructure.Text;
            if (cbxStructure.Checked == true)
            {
                determinSelections();
            }
        }

        private void cboMargin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMargin.Text = cboMargin.Text;
            if (cbxMargin.Checked == true)
            {
                determinSelections();
            }
        }

        private void cboAttachment_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAttachment.Text = cboAttachment.Text;
            if (cbxAttachment.Checked == true)
            {
                determinSelections();
            }
        }

        private void cboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShape.Text = cboShape.Text;
            if (cbxShape.Checked == true)
            {
                determinSelections();
            }
        }

        private void cboSurface_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSurface.Text = cboSurface.Text;
            if (cbxSurface.Checked == true)
            {
                determinSelections();
            }
        }

        private void cboVenation_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVenation.Text = cboVenation.Text;
            if (cbxVenation.Checked == true)
            {
                determinSelections();
            }
        }

        private void cboHairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHairs.Text = cboHairs.Text;
            if (cbxHairs.Checked == true)
            {
                determinSelections();
            }
        }

        #endregion ComboBox_Event

        #region CheckBoxSwitchingEvents

        private void cbxArangement_MouseClick(object sender, EventArgs e)
        {
            if (cbxArangement.Checked == true)
            {
                //cbxArangement.Font = new Font("Serif", 18, FontStyle.Underline );
                cbxArangement.BackColor = Color.PaleTurquoise;
                cbxArangement.ForeColor = Color.Black;
            }
            else 
            {
                cbxArangement.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxArangement.BackColor = Color.Transparent;
                cbxArangement.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxStructure_MouseClick(object sender, EventArgs e)
        {
            if (cbxStructure.Checked==true)
            {
                //cbxStructure.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxStructure.BackColor = Color.PaleTurquoise;
                cbxStructure.ForeColor = Color.Black;
            }
            else
            {
                cbxStructure.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxStructure.BackColor = Color.Transparent;
                cbxStructure.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxMargin_MouseClick(object sender, EventArgs e)
        {
            if (cbxMargin.Checked == true)
            {
                //cbxMargin.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxMargin.BackColor = Color.PaleTurquoise;
                cbxMargin.ForeColor = Color.Black;
            }
            else
            {
                cbxMargin.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxMargin.BackColor = Color.Transparent;
                cbxMargin.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxAttachment_MouseClick(object sender, EventArgs e)
        {
            if(cbxAttachment.Checked == true)
            {
                //cbxAttachment.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxAttachment.BackColor = Color.PaleTurquoise;
                cbxAttachment.ForeColor = Color.Black;
            }
            else
            {
                cbxAttachment.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxAttachment.BackColor = Color.Transparent;
                cbxAttachment.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxShape_MouseClick(object sender, EventArgs e)
        {
            if(cbxShape.Checked == true)
            {
                //cbxShape.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxShape.BackColor = Color.PaleTurquoise;
                cbxShape.ForeColor = Color.Black;
            }
            else
            {
                cbxShape.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxShape.BackColor = Color.Transparent;
                cbxShape.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxSurface_MouseClick(object sender, EventArgs e)
        {
            if (cbxSurface.Checked == true)
            {
                //cbxSurface.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxSurface.BackColor = Color.PaleTurquoise;
                cbxSurface.ForeColor = Color.Black;
            }
            else
            {
                cbxSurface.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxSurface.BackColor = Color.Transparent;
                cbxSurface.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxVenation_MouseClick(object sender, EventArgs e)
        {
            if (cbxVenation.Checked == true)
            {
                //cbxVenation.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxVenation.BackColor = Color.PaleTurquoise;
                cbxVenation.ForeColor = Color.Black;
            }
            else
            {
                cbxVenation.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxVenation.BackColor = Color.Transparent;
                cbxVenation.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        private void cbxHairs_MouseClick(object sender, EventArgs e)
        {
            if(cbxHairs.Checked == true)
            {
                //cbxHairs.Font = new Font("Serif", 18, FontStyle.Underline);
                cbxHairs.BackColor = Color.PaleTurquoise;
                cbxHairs.ForeColor = Color.Black;
            }
            else
            {
                cbxHairs.Font = new Font("Serif", 18, FontStyle.Regular);
                cbxHairs.BackColor = Color.Transparent;
                cbxHairs.ForeColor = Color.ForestGreen;
            }
            determinSelections();
        }

        #endregion CheckBoxSwitchingEvents

        #region Buttons

        private void btnArrangement_Click(object sender, EventArgs e)
        {
            //lbxSearchResult

            string ForeginKey = cboArrangement.SelectedIndex.ToString();
            string tablecol = "leafArrangementDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafarrangement WHERE leafArrangementID = " + ForeginKey;

            lblDescription.Text = "Arrangement Description: " + scalarReturnQuery(querystring);
        }

        private void btnStructure_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboStructure.SelectedIndex.ToString();
            string tablecol = "leafStructureDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafStructure WHERE leafStructureID = " + ForeginKey;

            lblDescription.Text = "Structure Description: " + scalarReturnQuery(querystring);
        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboMargin.SelectedIndex.ToString();
            string tablecol = "leafMarginDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafMargin WHERE leafMarginID = " + ForeginKey;

            lblDescription.Text = "Margin Description: " + scalarReturnQuery(querystring);
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboAttachment.SelectedIndex.ToString();
            string tablecol = "leafAttachmentDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafAttachment WHERE leafAttachmentID = " + ForeginKey;

            lblDescription.Text = "Attachment Description: " + scalarReturnQuery(querystring);
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboShape.SelectedIndex.ToString();
            string tablecol = "leafShapeDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafShape WHERE leafShapeID = " + ForeginKey;

            lblDescription.Text = "Shape Description: " + scalarReturnQuery(querystring);
        }

        private void btnSurface_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboSurface.SelectedIndex.ToString();
            string tablecol = "leafSurfaceDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafSurface WHERE leafSurfaceID = " + ForeginKey;

            lblDescription.Text = "Leaf Surface Description: " + scalarReturnQuery(querystring);
        }

        private void btnVenation_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboVenation.SelectedIndex.ToString();
            string tablecol = "leafVenationDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafVenation WHERE leafVenationID = " + ForeginKey;

            lblDescription.Text = "Venation Description: " + scalarReturnQuery(querystring);
        }

        private void btnHairs_Click(object sender, EventArgs e)
        {
            string ForeginKey = cboHairs.SelectedIndex.ToString();
            string tablecol = "leafHairsDescription";
            string querystring = "SELECT " + tablecol + " FROM plantdb.leafHairs WHERE leafHairsID = " + ForeginKey;

            lblDescription.Text = "Hairs Description: " + scalarReturnQuery(querystring);
        }

        #endregion Buttons

        #region Filtering_SQL

        private void determinSelections()
        {
            // this function writes an sql query based on the checkboxes selected

            /*
             * string fieldColumn = "speciesCommonName";
            string indexField = "speciesID";
            */
            string fieldColumn = "speciesDescription";
            string indexField = "speciesID";

            string SELECTstring = "SELECT DISTINCT " + indexField + ", " + fieldColumn + " FROM plantdb.species, plantdb.leafMorph WHERE (species.speciesID = leafMorph.species_FK) ";
            string ANDstring;
            string querystring;

            // cbxArangement
            if (cbxArangement.Checked == true)
            {
                string ForeginKey = cboArrangement.SelectedIndex.ToString();
                ANDstring = " AND leafArrangement_FK = " + ForeginKey;
            }
            else 
            {
                ANDstring = "";
            }

            // cbxStructure
            if (cbxStructure.Checked == true)
            {
                string ForeginKey = cboStructure.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND leafStructure_FK = " + ForeginKey;
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // cbxMargin
            if (cbxMargin.Checked == true)
            {
                string ForeginKey = cboMargin.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND leafMargin_FK = " + ForeginKey;
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // cbxAttachment
            if (cbxAttachment.Checked == true)
            {
                string ForeginKey = cboAttachment.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND leafAttachment_FK = " + ForeginKey;
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // cbxShape
            if (cbxShape.Checked == true)
            {
                string ForeginKey = cboShape.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND leafShape_FK = " + ForeginKey;
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // cbxSurface
            if (cbxSurface.Checked == true)
            {
                string ForeginKey = cboSurface.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND (leafSurfaceTop_FK = " + ForeginKey + " OR  leafSurfaceBottom_FK = " + ForeginKey + ") ";
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // cbxVenation
            if (cbxVenation.Checked == true)
            {
                string ForeginKey = cboVenation.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND leafVenation_FK = " + ForeginKey;
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // cbxHairs
            if (cbxHairs.Checked == true)
            {
                string ForeginKey = cboHairs.SelectedIndex.ToString();
                ANDstring = ANDstring + " AND (leafHairsTop_FK = " + ForeginKey + " OR  leafHairsBottom_FK = " + ForeginKey +")";
            }
            else
            {
                ANDstring = ANDstring + "";
            }

            // Perform the SQL
            querystring = SELECTstring + " " + ANDstring + ";";
            performQueryforListbox(querystring, indexField, fieldColumn);
            selectedSpeciesDisplay();
        }

        #endregion Filtering_SQL

        #region ConnectionFunction

        private void performQueryforListbox(string querystring, string indexField, string displayField)
        {
            // Note: 
            // DataSets can be serialized and represented in XML and, therefore, easily passed around to other tiers. DataReaders can't be serialized.
            // DataReader will retain an open connection to your database until you're done with it while a DataSet will be an in-memory object.
            // Datareader is more limited, but it gives MUCH better performance when all you need is to read through the data once.

            conn.Open();

            //SqlDataAdapter adapter = new SqlDataAdapter(querystring, conn);

            /*
            MySqlDataAdapter adapter = new MySqlDataAdapter(querystring, conn);
            
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            lbxSearchResult.DataSource = ds.Tables[0];
            lbxSearchResult.DisplayMember = displayField;
            lbxSearchResult.ValueMember = indexField;
            */

            lbxSearchResult.DataSource = getData(querystring);
            lbxSearchResult.DisplayMember = displayField;
            lbxSearchResult.ValueMember = indexField;

            conn.Close();


            lblDescription.Text = "List of Plants which match the (selected / checkboxed) description features.";
            //selectedSpeciesDisplay();
        }

        private string scalarReturnQuery(string querystring)
        {
            //used to return just a cell from a query
            string queryResult;

            conn.Open();

            //command.CommandText = querystring;
            //queryResult = (string)command.ExecuteScalar();

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = querystring;
            queryResult = (string)command.ExecuteScalar();

            conn.Close();

            return queryResult;
        }
        
        #endregion ConnectionFunction

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

        private void lbxSearchResult_MouseClick(object sender, MouseEventArgs e)
        {
            selectedSpeciesDisplay();
        }

        private void selectedSpeciesDisplay()
        {
            // Clean Display which show me what plants resemble the observation mande

            if (lbxSearchResult.SelectedValue != null) //avoid errors by enduring further errors are relevant
            {
                int someintegervalue = (int)lbxSearchResult.SelectedValue;

                int genusFK = ConnectionClass.returnSpeciesrecord(someintegervalue).genus_FK;
                string queryGenus = "SELECT genusName FROM plantdb.genus WHERE genusID = " + genusFK;


                lblDescription.Text = "About this plant: " + ConnectionClass.returnSpeciesrecord(someintegervalue).speciesDescription;

                lblCommonName.Text = ConnectionClass.returnSpeciesrecord(someintegervalue).speciesSymbol;

                lblSciName.Text = scalarReturnQuery(queryGenus) + " " + ConnectionClass.returnSpeciesrecord(someintegervalue).speciesName;
            }
        }

        private void btnLearningDB_Click(object sender, EventArgs e)
        {
            // editor related tasks

            frmAddPlant editor = new frmAddPlant();
            editor.StartPosition = FormStartPosition.Manual;
            editor.Left = this.Left;
            editor.Top = this.Top;

            //editor.ShowDialog();
            editor.Show();
            this.Close();
        }
        
    }
}
