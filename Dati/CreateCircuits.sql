CREATE TABLE [dbo].[Circuits]
(
	[id] [int] NOT NULL PRIMARY KEY,
	[name] [varchar](128) NOT NULL,
	[nLaps] [INT] NOT NULL,
	[length] [int] NOT NULL,
	[recordLap] [varchar](16) NOT NULL
);

INSERT INTO [dbo].[Circuits]
(
	id,
	name,
	nLaps,
	length,
	recordLap
)
VALUES
(1, 'Melbourne Grand Prix Circuit', 58, 4304, '1.18.741'),
(2, 'Bahrain International Circuit', 57, 5412, '1.27.958'),
(3, 'Shanghai International Circuit', 56, 5451, '1.31.678'),
(4, 'Baku City Circuit', 51, 6003, '1.43.009'),
(5, 'CIRCUIT DE BARCELONA-CATALUNYA', 66, 4655, '1.18.441'),
(6, 'Circuit de Monaco', 78, 3337, '1.14.439'),
(7, 'Circuit Gilles-Villeneuve', 70, 4421, '1.13.078'),
(8, 'Circuit Paul Ricard', 53, 5842, '1.32.740'),
(9, 'Red Bull Ring', 71, 4326, '1.06.957'),
(10, 'Silverstone Circuit', 52, 5891, '1.27.369'),
(11, 'Hockenheimring', 67, 4574, '1.13.780'),
(12, 'Hungaroring', 70, 4381, '1.17.103'),
(13, 'Spa-Francorchamps', 44, 7004, '1.46.286'), 
(14, 'Autodromo Nazionale Monza', 53, 5793, '1.21.046'),
(15, 'Marina Bay Street Circuit', 61, 5063, '1.41.905'),
(16, 'Sochi Autodrom', 53, 5848, '1.35.761'),
(17, 'Autódromo Hermanos Rodríguez', 71, 4304, '1.18.741'),
(18, 'Autódromo José Carlos Pace', 71, 4309, '1.10.540'),
(19, 'Yas Marina Circuit', 55, 5554, '1.39.283')