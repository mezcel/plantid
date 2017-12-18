# Plant Morphology App - plantid
#### This Application Is A Dichotomous Plant Identification Key

---
___Update Disclaimer:___

    I initially posted this Repo before I understood the power of Git, let alone how to use Git. This has been many months before this 'Resurrected Legacy Version'. Three PCs later and numerous factory restores on each, I revisited my code snippets posted on Github (they were only script files, not full project repo's). I discovered there was a mismatch between the Visual Studio Project and the Sql Files. I had uploaded the wrong files.

    What I am doing now is cutting my losses and making a working version for Git. For now I will keep the Sql the same, even though my original had ```views``` and ```sql logic``` for efficient interfacing between the Plant Add Form and the Plan Query Form. I noticed there were queries with declared table attributes in the C#.

    For now I feel it is safest to stick with the Sql as-is, and tailor the C# around the Sql. After it works, I will make a new version with ```views``` and ```sql logic``` for efficient interfacing between the Plant Add Form and the Plan Query Form.
---

[Wiki - PlantApp Website](http://mezcel.wixsite.com/plantmorphology) This link has more Information about how this App works & why this this technique is important

### About

This application, in conjunction with a separate image matching software I am also developing, is a reliable way to identify different plant species. It adds an additional degree of certainty to image matching methods and human visual perception alone.

This application was developed in VB.NET because my initial audience consisted of veteran biologists who had a minimal education in programming, yet felt comfortable with Visual Basic.

### What Works / What Needs Fixed

The Plant query works, but I only did and ```INSERT``` for 2 plants, each having one morphology description.

    Note:    
        File: VisualStudio-Csharp-plantid\DichotomousPlant\ConnectionClass.cs
        Line: 21-ish
        Server Password: You will need your own Password, ```yourserverpw``` is a place holder for the reader

        In other Repo's and later C#/Server Projects, I don't hard code any PW into the software.

```c
private static string _globalConnString = "datasource=127.0.0.1;port=3306;username=root;password=yourserverpw;";
```

The Plant Add Form needs to be Fixed
    The original worked for MSSql and MySql. It was this form I used to build the Morphology in the Sql Server.
    For now I will have to hand type it until my testbech is working properly again.

```sql
INSERT INTO `leafMorph` (`leafMorphID`, `species_FK`, `leafArrangement_FK`, `leafStructure_FK`, `leafMargin_FK`, `leafAttachment_FK`, `leafShape_FK`, `leafSurface_FK`, `leafVenation_FK`, `leafHairs_FK`) VALUES ('0','0','0','0','0','0','0','0','0','0');
INSERT INTO `leafMorph` (`leafMorphID`, `species_FK`, `leafArrangement_FK`, `leafStructure_FK`, `leafMargin_FK`, `leafAttachment_FK`, `leafShape_FK`, `leafSurface_FK`, `leafVenation_FK`, `leafHairs_FK`) VALUES ('1','1','6','4','8','0','18','0','7','0');
INSERT INTO `leafMorph` (`leafMorphID`, `species_FK`, `leafArrangement_FK`, `leafStructure_FK`, `leafMargin_FK`, `leafAttachment_FK`, `leafShape_FK`, `leafSurface_FK`, `leafVenation_FK`, `leafHairs_FK`) VALUES ('2','33','1','4','8','6','14','2','8','12');
```
## How This Application Is Used

### This application is an elaborate dichotomous tree identification key.

* Instruction Steps:
    * The end user looks at a plant leaf based on what that person sees as a definitive descriptive characteristic of that leaf.
    * The end user selects from an existing list of descriptive terms (minimum of one description).
    * The software will return a list of known plants which match that description.

[PlantApp Website](http://mezcel.wixsite.com/plantmorphology) This link has more Information about how this App works & why this this technique is important
