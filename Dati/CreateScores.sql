CREATE TABLE [dbo].[Scores]
(
	[id] INT NOT NULL PRIMARY KEY, 
	[score] INT NOT NULL, 
	[details] VARCHAR(128) NOT NULL
);

INSERT INTO [dbo].[Scores]
(
	id,
	score,
	details
)
VALUES
(1, '26', 'No accidents'),
(2, '31', 'No accidents'),
(3, '24', 'No accidents'),
(4, '25', 'No accidents'),
(5, '23', 'No accidents')