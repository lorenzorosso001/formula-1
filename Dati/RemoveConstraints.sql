ALTER TABLE [dbo].[Teams]
DROP CONSTRAINT [FK_Teams_Drivers_First];

ALTER TABLE [dbo].[Teams]
DROP CONSTRAINT [FK_Teams_Drivers_Second];

ALTER TABLE [dbo].[Teams]
DROP CONSTRAINT [FK_Teams_Countries];

ALTER TABLE [dbo].[Drivers]
DROP CONSTRAINT [FK_Drivers_Countries];

ALTER TABLE [dbo].[Races_Scores]
DROP CONSTRAINT [FK_Races_Scores_Drivers];

ALTER TABLE [dbo].[Races_Scores]
DROP CONSTRAINT [FK_Races_Scores_Races];

ALTER TABLE [dbo].[Races_Scores]
DROP CONSTRAINT [FK_Races_Scores_Scores];

ALTER TABLE [dbo].[Races]
DROP CONSTRAINT [FK_Races_Circuits];

ALTER TABLE [dbo].[Races]
DROP CONSTRAINT [FK_Races_Countries];