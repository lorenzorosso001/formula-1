CREATE TABLE [dbo].[Races_Scores]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[driver] INT NOT NULL, 
	[pos] INT NOT NULL, 
	[idRace] INT NOT NULL,
	[fastestLap] VARCHAR(30) NOT NULL
);