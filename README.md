# Plant Morphology App - plantid
#### This Application Is A Dichotomous Plant Identification Key

---
___Update Disclaimer:___

    I initially posted this Repo before I understood the power of Git, let alone how to use Git. This has been many months before this 'Resurrected Legacy Version'. Three PCs later and numerous factory restores on each, I revisited my code snippets posted on Github (they were only script files, not full project repo's). I discovered there was a mismatch between the Visual Studio Project and the Sql Files. I had uploaded the wrong or a WIP ```script file notes```.

    What I am doing now is cutting my losses and making a working version for Git. For now I will keep the ```Sql ER``` the same, even though my original had ```views``` and ```sql logic``` for efficient interfacing between the Plant Add Form and the Plant Query Form.
---

[Wiki - PlantApp Website](http://mezcel.wixsite.com/plantmorphology) This link has more Information about how this App works & why this this technique is important

 [YouTube](https://www.youtube.com/watch?time_continue=4&v=PrrcG2r2R-k): Past Original Stop Point Video

### About

This application, in conjunction with a separate image matching software I am also developing, is a reliable way to identify different plant species. It adds an additional degree of certainty to image matching methods and human visual perception alone.

This application was developed in VB.NET because my initial audience consisted of veteran biologists who had a minimal education in programming, yet felt comfortable with Visual Basic.

### What Works / What Needs Fixed

The Plant query works, but the list of plant observations are empty. You will have to use the App's ```Add Observation``` button to enter your own samples.

    Note:    

        Server Password: You will need your own Password, ```yourserverpw``` is a place holder for the reader.

        In other Repo's and later C#/Server Projects, I don't hard code any PW into the software.
File: VisualStudio-Csharp-plantid\DichotomousPlant\ConnectionClass.cs
Line: 21-ish
```c
/* C# mysql connector hack */
private static string _globalConnString = "datasource=127.0.0.1;port=3306;username=root;password=yourserverpw;";
```

* The Add ```New species``` Form needs to be Fixed
* The original worked for MsSql and MySql. It was this form I used to build the Morphology in the Sql Server.
* For now I will have to hand type it until my testbech is working properly again.

File: mysql\MySql_plantdb.sql
Line: 493-ish
```sql
/* optional hard code MySql data entry technique */
INSERT INTO `leafMorph` (`leafMorphID`, `species_FK`, `leafArrangement_FK`, `leafStructure_FK`, `leafMargin_FK`, `leafAttachment_FK`, `leafShape_FK`, `leafApex_FK`, `leafBase_FK`, `leafSurfaceTop_FK`, `leafSurfaceBottom_FK`, `leafVenation_FK`, `leafHairsTop_FK`, `leafHairsBottom_FK`) VALUES ('0','0','0','0','0','0','0','0','0','0','0','0','0','0');
```
## How This Application Is Used

### This application is an elaborate dichotomous tree identification key.

* Instruction Steps:
    * The end user looks at a plant leaf based on what that person sees as a definitive descriptive characteristic of that leaf.
    * The end user selects from an existing list of descriptive terms (minimum of one description).
    * The software will return a list of known plants which match that description.

[PlantApp Website](http://mezcel.wixsite.com/plantmorphology) This link has more Information about how this App works & why this this technique is important
