using System;

namespace MorphologyEntities
{

    public class leafArrangement
    {
        public int leafArrangementID { get; set; }
        public string leafArrangementName { get; set; }
        public string leafArrangementDescription { get; set; }

        public leafArrangement(int id, string name, string description)
        {
            leafArrangementID = id;
            leafArrangementName = name;
            leafArrangementDescription = description;
        }

        public leafArrangement(string name, string description)
        {
            leafArrangementName = name;
            leafArrangementDescription = description;
        }
    }

    public class leafStructure
    {
        public int leafStructureID { get; set; }
        public string leafStructureName { get; set; }
        public string leafStructureDescription { get; set; }

        public leafStructure(int id, string name, string description)
        {
            leafStructureID = id;
            leafStructureName = name;
            leafStructureDescription = description;
        }

        public leafStructure(string name, string description)
        {
            leafStructureName = name;
            leafStructureDescription = description;
        }
    }

    public class leafMargin
    {
        public int leafMarginID { get; set; }
        public string leafMarginName { get; set; }
        public string leafMarginDescription { get; set; }

        public leafMargin(int id, string name, string description)
        {
            leafMarginID = id;
            leafMarginName = name;
            leafMarginDescription = description;
        }

        public leafMargin(string name, string description)
        {
            leafMarginName = name;
            leafMarginDescription = description;
        }
    }

    public class leafAttachment
    {
        public int leafAttachmentID { get; set; }
        public string leafAttachmentName { get; set; }
        public string leafAttachmentDescription { get; set; }

        public leafAttachment(int id, string name, string description)
        {
            leafAttachmentID = id;
            leafAttachmentName = name;
            leafAttachmentDescription = description;
        }

        public leafAttachment(string name, string description)
        {
            leafAttachmentName = name;
            leafAttachmentDescription = description;
        }
    }

    public class leafShape
    {
        public int leafShapeID { get; set; }
        public string leafShapeName { get; set; }
        public string leafShapeDescription { get; set; }

        public leafShape(int id, string name, string description)
        {
            leafShapeID = id;
            leafShapeName = name;
            leafShapeDescription = description;
        }

        public leafShape(string name, string description)
        {
            leafShapeName = name;
            leafShapeDescription = description;
        }
    }

    public class leafSurface
    {
        public int leafSurfaceID { get; set; }
        public string leafSurfaceName { get; set; }
        public string leafSurfaceDescription { get; set; }

        public leafSurface(int id, string name, string description)
        {
            leafSurfaceID = id;
            leafSurfaceName = name;
            leafSurfaceDescription = description;
        }

        public leafSurface(string name, string description)
        {
            leafSurfaceName = name;
            leafSurfaceDescription = description;
        }

    }

    public class leafVenation
    {
        public int leafVenationID { get; set; }
        public string leafVenationName { get; set; }
        public string leafVenationDescription { get; set; }

        public leafVenation(int id, string name, string description)
        {
            leafVenationID = id;
            leafVenationName = name;
            leafVenationDescription = description;
        }

        public leafVenation(string name, string description)
        {
            leafVenationName = name;
            leafVenationDescription = description;
        }
    }

    public class leafHairs
    {
        public int leafHairsID { get; set; }
        public string leafHairsName { get; set; }
        public string leafHairsDescription { get; set; }

        public leafHairs(int id, string name, string description)
        {
            leafHairsID = id;
            leafHairsName = name;
            leafHairsDescription = description;
        }

        public leafHairs(string name, string description)
        {
            leafHairsName = name;
            leafHairsDescription = description;
        }
    }

    public class leafMorph
    {
        public int leafMorphID { get; set; }
        public int species_FK { get; set; }
        public int leafArrangement_FK { get; set; }
        public int leafStructure_FK { get; set; }
        public int leafMargin_FK { get; set; }
        public int leafAttachment_FK { get; set; }
        public int leafShape_FK { get; set; }
        public int leafApex_FK { get; set; }
        public int leafBase_FK { get; set; }
        public int leafSurfaceTop_FK { get; set; }
        public int leafSurfaceBottom_FK { get; set; }
        public int leafVenation_FK { get; set; }
        public int leafHairsTop_FK { get; set; }
        public int leafHairsBottom_FK { get; set; }

        public leafMorph(int id, int speciesFK, int arrangementFK, int structureFK, int marginFK, int attachmentFK, int shapeFK, int leafApexFK, int leafBaseFK, int surfaceTopFK, int surfaceBottomFK, int venationFK, int leafHairsTopFK, int leafHairsBottomFK)
        {
            leafMorphID = id;
            species_FK = speciesFK;
            leafArrangement_FK = arrangementFK;
            leafStructure_FK = structureFK;
            leafMargin_FK = marginFK;
            leafAttachment_FK = attachmentFK;
            leafShape_FK = shapeFK;
            leafApex_FK = leafApexFK;
            leafBase_FK = leafBaseFK;
            leafSurfaceTop_FK = surfaceTopFK;
            leafSurfaceBottom_FK = surfaceBottomFK;
            leafVenation_FK = venationFK;
            leafHairsTop_FK = leafHairsTopFK;
            leafHairsBottom_FK = leafHairsBottomFK;
        }

        public leafMorph(int speciesFK, int arrangementFK, int structureFK, int marginFK, int attachmentFK, int shapeFK, int leafApexFK, int leafBaseFK, int surfaceTopFK, int surfaceBottomFK, int venationFK, int leafHairsTopFK, int leafHairsBottomFK)
        {
            species_FK = speciesFK;
            leafArrangement_FK = arrangementFK;
            leafStructure_FK = structureFK;
            leafMargin_FK = marginFK;
            leafAttachment_FK = attachmentFK;
            leafShape_FK = shapeFK;
            leafApex_FK = leafApexFK;
            leafBase_FK = leafBaseFK;
            leafSurfaceTop_FK = surfaceTopFK;
            leafSurfaceBottom_FK = surfaceBottomFK;
            leafVenation_FK = venationFK;
            leafHairsTop_FK = leafHairsTopFK;
            leafHairsBottom_FK = leafHairsBottomFK;
        }
    }
}