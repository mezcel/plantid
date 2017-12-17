using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; 

//entity related
using TaxononmyEntities;
using MorphologyEntities;

using MySql.Data.MySqlClient; //use mysql


namespace DichotomousPlant
{
    

    public static class ConnectionClass
    {
        private static string _globalConnString = "datasource=127.0.0.1;port=3306;username=root;password=Sumano00!;";

        public static string GlobalConnectionVarClass
        {
            get
            {
                return _globalConnString;
            }
            set
            {
                _globalConnString = value;
            }
        }

        static ConnectionClass()
        {
       
            string connectionString = DichotomousPlant.ConnectionClass.GlobalConnectionVarClass;

            MySqlConnection conn = new MySqlConnection(connectionString); 
            MySqlCommand command = new MySqlCommand("", conn);


        }

        #region morphology
        
        public static string input_LeafMorphRecord(leafMorph input_leafMorph)
        {
            MySqlConnection conn = new MySqlConnection(DichotomousPlant.ConnectionClass.GlobalConnectionVarClass);
            conn.Open();

            string query = string.Format("INSERT INTO leafMorph VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                    input_leafMorph.species_FK,
                    input_leafMorph.leafArrangement_FK,
                    input_leafMorph.leafStructure_FK,
                    input_leafMorph.leafMargin_FK,
                    input_leafMorph.leafAttachment_FK,
                    input_leafMorph.leafShape_FK,
                    input_leafMorph.leafApex_FK,
                    input_leafMorph.leafBase_FK,
                    input_leafMorph.leafSurfaceTop_FK,
                    input_leafMorph.leafSurfaceBottom_FK,
                    input_leafMorph.leafVenation_FK,
                    input_leafMorph.leafHairsTop_FK,
                    input_leafMorph.leafHairsBottom_FK
                    );

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            conn.Close();

            return "leafMorph was sucessfully edited.";

        }

        public static bool identicalMorphology(leafMorph input_leafMorph)
        {
            bool identicalrecordFlag = false;

            // string querycountstring = "SELECT COUNT(*) FROM dbo.leafMorph WHERE ((species_FK = " + input_leafMorph.species_FK + ") AND " + " (leafArrangement_FK = " + input_leafMorph.leafArrangement_FK + ") AND " + "(leafStructure_FK = " + input_leafMorph.leafStructure_FK + ") AND " + " (leafMargin_FK = " + input_leafMorph.leafMargin_FK + ") AND " + "(leafAttachment_FK = " + input_leafMorph.leafAttachment_FK + ") AND " + "(leafShape_FK = " + input_leafMorph.leafShape_FK + ") AND " + "(leafApex_FK = " + input_leafMorph.leafApex_FK + ") AND " + "(leafBase_FK = " + input_leafMorph.leafBase_FK + ") AND " + "(leafSurfaceTop_FK = " + input_leafMorph.leafSurfaceTop_FK + ") AND " + "(leafSurfaceBottom_FK = " + input_leafMorph.leafSurfaceBottom_FK + ") AND " + "(leafVenation_FK = " + input_leafMorph.leafVenation_FK + ") AND " + "(leafHairsTop_FK = " + input_leafMorph.leafHairsTop_FK + ") AND " + "(leafHairsBottom_FK = " + input_leafMorph.leafHairsBottom_FK + "))";

            string querycountstring = "SELECT COUNT(*) FROM plantdb.leafMorph WHERE ((species_FK = " + input_leafMorph.species_FK + ") AND " + " (leafArrangement_FK = " + input_leafMorph.leafArrangement_FK + ") AND " + "(leafStructure_FK = " + input_leafMorph.leafStructure_FK + ") AND " + " (leafMargin_FK = " + input_leafMorph.leafMargin_FK + ") AND " + "(leafAttachment_FK = " + input_leafMorph.leafAttachment_FK + ") AND " + "(leafShape_FK = " + input_leafMorph.leafShape_FK + ") AND " + "(leafApex_FK = " + input_leafMorph.leafApex_FK + ") AND " + "(leafBase_FK = " + input_leafMorph.leafBase_FK + ") AND " + "(leafSurfaceTop_FK = " + input_leafMorph.leafSurfaceTop_FK + ") AND " + "(leafSurfaceBottom_FK = " + input_leafMorph.leafSurfaceBottom_FK + ") AND " + "(leafVenation_FK = " + input_leafMorph.leafVenation_FK + ") AND " + "(leafHairsTop_FK = " + input_leafMorph.leafHairsTop_FK + ") AND " + "(leafHairsBottom_FK = " + input_leafMorph.leafHairsBottom_FK + "))";
            
            MySqlConnection conn = new MySqlConnection(DichotomousPlant.ConnectionClass.GlobalConnectionVarClass);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            string query = string.Format(querycountstring);
            command.CommandText = query;

            int numberOfidenticalRecords = (int)command.ExecuteScalar();
            if (numberOfidenticalRecords < 1)
            {
                identicalrecordFlag = false;
            }
            else
            {
                identicalrecordFlag = true;
            }

            conn.Close();

            return identicalrecordFlag;
        }

        public static leafMorph returnleafMorphrecord(int leafMorphID)
        {
            leafMorph morphEntityrecord = null;

            string query = string.Format("SELECT * FROM leafMorph WHERE leafMorphID = '{0}'", leafMorphID);
            MySqlConnection conn = new MySqlConnection(DichotomousPlant.ConnectionClass.GlobalConnectionVarClass);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = query;

            conn.Open();

            //SqlDataReader reader = command.ExecuteReader();
            
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int speciesFK = reader.GetInt32(0);
                int arrangementFK = reader.GetInt32(0);
                int structureFK = reader.GetInt32(0);
                int marginFK = reader.GetInt32(0);
                int attachmentFK = reader.GetInt32(0);
                int shapeFK = reader.GetInt32(0);
                int leafApexFK = reader.GetInt32(0);
                int leafBaseFK = reader.GetInt32(0);
                int surfaceTopFK = reader.GetInt32(0);
                int surfaceBottomFK = reader.GetInt32(0);
                int venationFK = reader.GetInt32(0);
                int leafHairsTopFK = reader.GetInt32(0);
                int leafHairsBottomFK = reader.GetInt32(0);

                morphEntityrecord = new leafMorph(id, speciesFK, arrangementFK, structureFK, marginFK, attachmentFK, shapeFK, leafApexFK, leafBaseFK, surfaceTopFK, surfaceBottomFK, venationFK, leafHairsTopFK, leafHairsBottomFK);
            }

            conn.Close();

            return morphEntityrecord;
        }

        #endregion morphology

        #region species

        public static string input_SpeciesRecord(species input_species) 
        {
            MySqlConnection conn = new MySqlConnection(DichotomousPlant.ConnectionClass.GlobalConnectionVarClass);

            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            /*
            string query = string.Format("INSERT INTO species VALUES ('{0}','{1}', '{2}', '{3}', '{4}')",
                    input_species.speciesName,
                    input_species.speciesSymbol,
                    input_species.speciesCommonName,
                    input_species.speciesDescription,
                    input_species.genus_FK
                    );
            */
            string query = string.Format("INSERT INTO species VALUES ('{0}','{1}', '{2}', '{3}')",
                    input_species.speciesName,
                    input_species.speciesSymbol,
                    input_species.speciesDescription,
                    input_species.genus_FK
                    );

            command.CommandText = query;
            command.ExecuteNonQuery();

            conn.Close();

            return "Species: `" + input_species.speciesName + "` record was added into `species` table";
        }

        public static bool identicalSpecies(species input_species)
        {
            bool identicalrecordFlag = false;

            string querycountstring = "SELECT COUNT(*) FROM dbo.species WHERE ((speciesName = '" + input_species.speciesName + "') AND " + " (speciesSymbol = '" + input_species.speciesSymbol + "') AND " + " (speciesDescription = '" + input_species.speciesDescription + "') AND " + "(genus_FK = '" + input_species.genus_FK + "'))";
            MySqlConnection conn = new MySqlConnection(DichotomousPlant.ConnectionClass.GlobalConnectionVarClass);

            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            string query = string.Format(querycountstring);
            command.CommandText = query;

            int numberOfidenticalRecords = (int)command.ExecuteScalar();

            if (numberOfidenticalRecords < 1)
            {
                identicalrecordFlag = false;
            }
            else
            {
                identicalrecordFlag = true;
            }

            conn.Close();

            return identicalrecordFlag;
        }

        public static species returnSpeciesrecord(int speciesID)
        {
            species speciesEntityrecord = null;

            string query = string.Format("SELECT * FROM plantdb.species WHERE speciesID = '{0}'", speciesID);
            MySqlConnection conn = new MySqlConnection(DichotomousPlant.ConnectionClass.GlobalConnectionVarClass);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = query;

            conn.Open();

            //SqlDataReader reader = command.ExecuteReader();

            MySqlDataReader reader = command.ExecuteReader();

            command.CommandText = query;

            while (reader.Read())
            {
                /*
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string symbol = reader.GetString(2);
                string commonname = reader.GetString(3);
                string description = reader.GetString(4);
                int genusFK = reader.GetInt32(5);
                */
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string symbol = reader.GetString(2);
                string description = reader.GetString(3);
                int genusFK = reader.GetInt32(4);

                speciesEntityrecord = new species(id, name, symbol, description, genusFK);
            }

            conn.Close();

            return speciesEntityrecord;
        }
        
        #endregion species
    }
}
