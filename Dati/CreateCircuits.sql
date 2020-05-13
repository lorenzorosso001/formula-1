CREATE TABLE [dbo].[Circuits]
(
	[id] [int] NOT NULL PRIMARY KEY,
	[name] [varchar](128) NOT NULL,
	[nLaps] [INT] NOT NULL,
	[length] [int] NOT NULL,
	[recordLap] [varchar](16) NOT NULL,
	[img] [varchar] (512)
);

INSERT INTO [dbo].[Circuits]
(
	id,
	name,
	nLaps,
	length,
	recordLap,
	img
)
VALUES
(1, 'Melbourne Grand Prix Circuit', 58, 4304, '1.18.741', 'https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Australia_Circuit.png.transform/9col/image.png'),
(2, 'Bahrain International Circuit', 57, 5412, '1.27.958', 'https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Bahrain_Circuit.png.transform/9col/image.png'),
(3, 'Shanghai International Circuit', 56, 5451, '1.31.678', 'https://media.motorbox.com/image/f1-gp-cina-2019-orari-meteo-risultati-prove-qualifiche-e-gara/6/3/5/635656/635656-16x9-md.jpg'),
(4, 'Baku City Circuit', 51, 6003, '1.43.009', 'https://media.motorbox.com/image/f1-gp-azerbaijan-2019-circuito-meteo-risultati-prove-qualifiche-e-gara/6/3/7/637003/637003-16x9-lg.jpg'),
(5, 'CIRCUIT DE BARCELONA-CATALUNYA', 66, 4655, '1.18.441', 'https://media.motorbox.com/image/f1-gp-spagna-2019-orari-meteo-risultati-prove-qualifiche-e-gara/6/3/7/637992/637992-16x9-md.jpg'),
(6, 'Circuit de Monaco', 78, 3337, '1.14.439', 'https://media.motorbox.com/image/f1-gp-monaco-2019-orari-meteo-risultati-prove-qualifiche-e-gara/6/3/9/639590/639590-16x9-md.jpg'),
(7, 'Circuit Gilles-Villeneuve', 70, 4421, '1.13.078', 'https://www.startyourengines.it/wp-content/uploads/2019/06/F1.png'),
(8, 'Circuit Paul Ricard', 53, 5842, '1.32.740', 'https://th.autoblog.it/qaPhsKyhnvzsD5-Fon84eU_P0OE=/fit-in/655xorig/https%3A%2F%2Fmedia.autoblog.it%2F1%2F1fa%2Fcircuito-paul-ricard-di-le-castellet-gp-francia-2019.jpg'),
(9, 'Red Bull Ring', 71, 4326, '1.06.957', 'https://www.giornalemotori.com/wp-content/uploads/2018/12/austria-768x432.png'),
(10, 'Silverstone Circuit', 52, 5891, '1.27.369', 'https://th.autoblog.it/IMsLYkTXy168Yz4betxGaLZJP2w=/fit-in/655xorig/https%3A%2F%2Fmedia.autoblog.it%2F0%2F0fc%2Fcircuito-silverstone.jpg'),
(11, 'Hockenheimring', 67, 4574, '1.13.780', 'https://media.motorbox.com/image/gp-germania-2019-orari-meteo-risultati/6/4/6/646629/646629-16x9-md.jpg'),
(12, 'Hungaroring', 70, 4381, '1.17.103', 'https://media.motorbox.com/image/gp-ungheria-2019-orari-meteo-risultati/6/4/7/647020/647020-16x9-md.jpg'),
(13, 'Spa-Francorchamps', 44, 7004, '1.46.286', 'https://media.motorbox.com/image/f1-2019-la-pista-di-spa-francorchamps-sede-del-gp-belgio/6/4/9/649327/649327-16x9-md.jpg'), 
(14, 'Autodromo Nazionale Monza', 53, 5793, '1.21.046', 'https://media.motorbox.com/image/gp-italia-2019-orari-meteo-risultati/6/5/0/650614/650614-16x9-md.jpg'),
(15, 'Marina Bay Street Circuit', 61, 5063, '1.41.905', 'https://media.motorbox.com/image/f1-2019-il-marina-bay-street-circuit-dove-si-corre-il-gp-singapore/6/5/1/651832/651832-16x9-md.jpg'),
(16, 'Sochi Autodrom', 53, 5848, '1.35.761', 'https://media.motorbox.com/image/tutte-le-info-sul-gp-russia-2019-orari-meteo-risultati/6/5/2/652862/652862-16x9-md.jpg'),
(17, 'Autódromo Hermanos Rodríguez', 71, 4304, '1.18.741', 'https://media.motorbox.com/image/tutte-le-info-sul-gp-messico-2019-orari-meteo-risultati/6/5/6/656463/656463-16x9-md.jpg'),
(18, 'Autódromo José Carlos Pace', 71, 4309, '1.10.540', 'https://media.motorbox.com/image/tutte-le-info-sul-gp-brasile-2019-orari-meteo-risultati/6/5/8/658839/658839-16x9-md.jpg'),
(19, 'Yas Marina Circuit', 55, 5554, '1.39.283', 'https://media.motorbox.com/image/tutte-le-info-sul-gp-abu-dhabi-2019-orari-meteo-risultati/6/6/0/660478/660478-16x9-md.jpg')