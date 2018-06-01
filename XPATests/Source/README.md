# Source \/

This is a Magic XPA "Source" directory. Magic XPA creates such a source directory (collection of XML files) whenever you create a XPA project
(XPA application). Location of this source directory is specified in the application's .edp (eDeveloper project file), which typically resides 
in the parent folder. [XPATests.edp](/XPATests/XPATests.edp) - in our case (see value "SourceDirectory" there).  

The format of the sources is proprietary and may change with every version of Magic XPA. Magic XPA ships with XML schema files for the sources 
which do describe their content.  

## Team development / Version control

Magic XPA SingleUser has the "team development" feature disabled and even if it would be enabled, or you have a full version, team developmen 
is an issue, due to the usage of "indexes" in these source files, where entiities (models, programs, tables, ...) are not referenced by a 
unique name (guid) but an index - which is only unique inside a specific repository.  

Concurrent development where developers do their changes in parallel and resolve merge conflicts when they check-in / commit their changes 
is therefore not possible with Magic. Magic XPA also only supports those MVCS systems which do provide a MS SCC Api (and allow to disable 
multiple chechout of objects).  

For this demo-project we do version the complete project with git on github. Push requests and forges will result in Merge conflicts which are 
very hard to resolve with Magic XPA due to the thing with the "indexes" explained above. Meanwhile there is some third party products 
which do help a lttle with these issues a bit (Magic Optimizer / Magic Compare).  

Also in this project it's planned to add some tools which do work on "Magic sources" in order to be able to refactor them. 

# Repositories
## [Components](Comps.xml)
## [Data Sources](DataSources.xml)
## [Data Sources Indexes](DataSourcesIndex.xml)
## [Help] definitions(Helps.xml)
## [Menues](Menues.xml)
## [Models](Models.xml)
## [Programs](Headers) (ProgramHeaders.xml)
## [Programs](Progs.xml)
## [Project properties](ProjProps.xml)
## [Rights](Rights.xml)
