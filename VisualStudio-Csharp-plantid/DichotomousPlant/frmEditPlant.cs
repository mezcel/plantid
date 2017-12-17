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
    public partial class frmEditPlant : Form
    {
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
        
        public static string connectionString = DichotomousPlant.ConnectionClass.GlobalConnectionVarClass;
        MySqlConnection conn = new MySqlConnection(connectionString);

        public frmEditPlant()
        {
            InitializeComponent();

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

        private void frmEditPlant_Load(object sender, EventArgs e)
        {
            //used for open/close of the form objects
            //cbxSpeciesSymbol.Enabled = true;

            //cbxSpeciesSymbol.SelectedValue = 0;

            //cbxSpeciesSymbol
            cbxSpeciesSymbol.DataSource = getData("SELECT * FROM plantdb.species;");
            cbxSpeciesSymbol.DisplayMember = "speciesSymbol";
            cbxSpeciesSymbol.ValueMember = "speciesID";

            leafMorphDataTable.DataSource = getData("SELECT * FROM plantdb.leafmorph;");
            
        }

        
        private void fillleafMorpphView(string species_FK)
        {

            string select = "SELECT * FROM plantdb.leafmorph WHERE species_FK = " + species_FK + ";";

            if (cbxSpeciesSymbol.SelectedIndex > -1)
            {
                conn.Open();

                leafMorphDataTable.DataSource = getData(select);

                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cbxSpeciesSymbol.Enabled = false;

            frmAddPlant backtoAdd = new frmAddPlant();
            backtoAdd.Show();

            this.Close();
        }

        
    
    }
}
