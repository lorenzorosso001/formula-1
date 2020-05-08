CREATE TABLE [dbo].[Races_Scores](
	[id] INT NOT NULL,
	[extDriver] INT NOT NULL,
	[extScore] INT NOT NULL,
	[extRace] INT NOT NULL,
	[fastestLap] VARCHAR(16) NOT NULL,
	CONSTRAINT [PK_Races_Scores] PRIMARY KEY CLUSTERED ([id] ASC)
 );
 
INSERT INTO [dbo].[Races_Scores]
(
	id,
	extDriver,
	extScore,
	extRace,
	fastestLap
)
VALUES
(1, 2, 1, 3, '1.10.32'),
(2, 5, 2, 4, '1.11.36'),
(3, 1, 3, 1, '1.12.32'),
(4, 7, 4, 5, '1.11.41'),
(5, 4, 5, 6, '1.12.11')