CREATE TABLE [dbo].[Circuits]
(
	[id] [int] NOT NULL,
	[name] [varchar](128) NOT NULL,
	[length] [int] NOT NULL,
	[recordLap] [varchar](16) NOT NULL,
 	CONSTRAINT [PK_Circuits] PRIMARY KEY CLUSTERED([id] ASC)
);

SET IDENTITY_INSERT [dbo].[Circuits] ON;

INSERT INTO [dbo].[Circuits]
(
	id,
	name,
	length,
	recordLap
)
VALUES
(1, 'Autódromo Hermanos Rodríguez', '4304', '1'18"741')
