CREATE TABLE [dbo].[Circuits]
(
	[id] [int] NOT NULL,
	[name] [varchar](128) NOT NULL,
	[length] [int] NOT NULL,
	[recordLap] [varchar](16) NOT NULL,
 	CONSTRAINT [PK_Circuits] PRIMARY KEY CLUSTERED([id] ASC)
);