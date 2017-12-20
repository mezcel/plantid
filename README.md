# Plant Morphology App - plantid
#### This Application Is A Dichotomous Plant Identification Key

---
___Update Disclaimer:___

    I initially posted this Repo before I understood the power of Git, let alone how to use Git. This repo contained notes and milestones needed to recreate the plantid app. +1 year later I decided to rebuild the app as an executable repo.

    This version is not as complete as my previous "original final version", but this version works. It was a good review on MySql Connector.
---

[Wiki - PlantApp Website](http://mezcel.wixsite.com/plantmorphology) This link has more Information about how this App works & why this this technique is important

[YouTube](https://www.youtube.com/watch?time_continue=4&v=PrrcG2r2R-k): Past Original Stop Point Video

### About

This application, in conjunction with a separate image matching software I am also developing, is a reliable way to identify different plant species. It adds an additional degree of certainty to image matching methods and human visual perception alone.

This application was developed in VB.NET because my initial audience consisted of veteran biologists who had a minimal education in programming, yet felt comfortable with Visual Basic.

### What Works / What Needs Fixed

The Plant query works, but the list of plant observations will be empty. You will have to use the App's ```Add Observation``` button to enter your own samples. Observations will be added directly into the MySql Server.

    Note:    

        Server Password: You will need your own Password, [yourserverpw] is a place holder for the reader.

        In other Repo's and later C#/Server Projects, I don't hard code PW's into the software.

> File: VisualStudio-Csharp-plantid\DichotomousPlant\ConnectionClass.cs

> Line: 21-ish

> ```password``` = yourserverpw

```c
/* C# mysql connector hack */
private static string _globalConnString = "datasource=127.0.0.1;port=3306;username=root;password=yourserverpw;";
```

*** Programmatically add record to Server (Optional) ***

> File: mysql\MySql_plantdb.sql

> Line: 493-ish

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
