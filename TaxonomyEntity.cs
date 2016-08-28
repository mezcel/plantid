using System;

namespace TaxononmyEntities
{
    public class plantclass
    {
        public int plantclassID { get; set; }
        public string plantclassName { get; set; }
        public string plantclassDescription { get; set; }

        public plantclass(int id, string name, string description)
        {
            plantclassID = id;
            plantclassName = name;
            plantclassDescription = description;
        }

        public plantclass(string name, string description)
        {
            plantclassName = name;
            plantclassDescription = description;
        }
    }

    public class plantorder
    {
        public int plantorderID { get; set; }
        public string plantorderName { get; set; }
        public string plantorderDescription { get; set; }
        public int plantclass_FK { get; set; }

        public plantorder(int id, string name, string description, int classFK)
        {
            plantorderID = id;
            plantorderName = name;
            plantorderDescription = description;
            plantclass_FK = classFK;
        }

        public plantorder(string name, string description, int classFK)
        {
            plantorderName = name;
            plantorderDescription = description;
            plantclass_FK = classFK;
        }
    }

    public class family
    {
        public int familyID { get; set; }
        public string familyName { get; set; }
        public string familyDescription { get; set; }
        public int plantorder_FK { get; set; }

        public family(int id, string name, string description, int classFK)
        {
            familyID = id;
            familyName = name;
            familyDescription = description;
            plantorder_FK = classFK;
        }

        public family(string name, string description, int classFK)
        {
            familyName = name;
            familyDescription = description;
            plantorder_FK = classFK;
        }
    }

    public class genus
    {
        public int genusID { get; set; }
        public string genusName { get; set; }
        public string genusDescription { get; set; }
        public int family_FK { get; set; }

        public genus(int id, string name, string description, int familyFK)
        {
            genusID = id;
            genusName = name;
            genusDescription = description;
            family_FK = familyFK;
        }

        public genus(string name, string description, int familyFK)
        {
            genusName = name;
            genusDescription = description;
            family_FK = familyFK;
        }
    }

    public class species
    {
        public int speciesID { get; set; }
        public string speciesName { get; set; }
        public string speciesSymbol { get; set; }
        public string speciesCommonName { get; set; }
        public string speciesDescription { get; set; }
        public int genus_FK { get; set; }

        public species(int id, string name, string symbol, string commonName, string description, int genusFK)
        {
            speciesID = id;
            speciesName = name;
            speciesSymbol = symbol;
            speciesCommonName = commonName;
            speciesDescription = description;
            genus_FK = genusFK;
        }

        public species(string name, string symbol, string commonName, string description, int genusFK)
        {
            speciesName = name;
            speciesSymbol = symbol;
            speciesCommonName = commonName;
            speciesDescription = description;
            genus_FK = genusFK;
        }
    }
}