CREATE TABLE [dbo].[Races]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [grandPrixName] VARCHAR(128) NOT NULL, 
    [circuitName] VARCHAR(128) NOT NULL, 
	[laps] INT NOT NULL,
	[circuitLength] FLOAT NOT NULL,
    [grandPrixDate] DATE NOT NULL, 
    [country] VARCHAR(64) NOT NULL, 
    [extCountry] CHAR(2) NOT NULL
);

SET IDENTITY_INSERT [dbo].[Races] ON;

INSERT INTO [dbo].[Races]
(
	id,
	grandPrixName,
	circuitName,
	laps,
	circuitLength,
	grandPrixDate,
	country,
	extCountry
)
VALUES
(1, 'FORMULA 1 ROLEX AUSTRALIAN GRAND PRIX 2019', 'Melbourne Grand Prix Circuit', 58, 5.303, convert(date, '17-03-2019',105), 'Australia', 'AU'),
(2, 'FORMULA 1 GULF AIR BAHRAIN GRAND PRIX 2019', 'Bahrain International Circuit', 57, 5.412, convert(date, '31-03-2019',105), 'Bahrain', 'BH'),
(3, 'FORMULA 1 HEINEKEN CHINESE GRAND PRIX 2019', 'Shanghai International Circuit', 56, 5.451, convert(date, '31-03-2019',105), 'China', 'CH'),
(4, 'FORMULA 1 SOCAR AZERBAIJAN GRAND PRIX 2019', 'Baku City Circuit', 51, 5.003, convert(date, '28-04-2019',105), 'Azerbaijan', 'AZ'),
(5, 'FORMULA 1 EMIRATES GRAN PREMIO DE ESPAÑA 2019', 'CIRCUIT DE BARCELONA-CATALUNYA', 66, 4.655, convert(date, '12-05-2019',105), 'Spain', 'SP'),
(6, 'FORMULA 1 GRAND PRIX DE MONACO 2019', 'Circuit de Monaco', 78, 3.337, convert(date, '12-05-2019',105), 'Monaco', 'MC'),
(7, 'FORMULA 1 PIRELLI GRAND PRIX DU CANADA 2019', 'Circuit Gilles-Villeneuve', 70, 4.361, convert(date, '09-06-2019', 105), 'Canada', 'CA'),
(8, 'FORMULA 1 PIRELLI GRAND PRIX DE FRANCE 2019', 'Circuit Paul Ricard', 53, 5.842, convert(date, '23-06-2019', 105), 'France', 'FR'),
(9, 'FORMULA 1 MYWORLD GROSSER PREIS VON ÖSTERREICH 2019', 'Red Bull Ring', 71, 4.318, convert(date, '30-06-2019', 105), 'Austria', 'AT'),
(10, 'FORMULA 1 ROLEX BRITISH GRAND PRIX 2019', 'Silverstone Circuit', 52, 5.891, convert(date, '12-07-2019', 105), 'Great Britain', 'GB'),
(11, 'FORMULA 1 MERCEDES-BENZ GROSSER PREIS VON DEUTSCHLAND 2019', 'Hockenheimring', 67, 4.574, convert(date, '28-07-2019',105), 'Germany', 'DE'),
(12, 'FORMULA 1 ROLEX MAGYAR NAGYDÍJ 2019', 'Hungaroring', 70, 4.381, convert(date, '04-08-2019', 105), 'Hungary', 'HU'),
(13, 'FORMULA 1 JOHNNIE WALKER BELGIAN GRAND PRIX 2019', 'Spa-Francorchamps', 44, 7.004, convert(date, '01-09-2019',105), 'Belgium', 'BE'),
(14, 'FORMULA 1 GRAN PREMIO HEINEKEN DI ITALIA 2019', 'Autodromo Nazionale Monza', 53, 5.793, convert(date, '08-11-2019',105), 'Italy', 'IT'),
(15, 'FORMULA 1 SINGAPORE AIRLINES SINGAPORE GRAND PRIX 2019', 'Marina Bay Street Circuit', 61, 5.063, convert(date, '22-09-2019',105), 'Singapore', 'SG'),
(16, 'FORMULA 1 VTB RUSSIAN GRAND PRIX 2019', 'Sochi Autodrom', 53, 5.848, convert(date, '29-09-2019', 105), 'Great Britain', 'GB'),
(17, 'FORMULA 1 VTB RUSSIAN GRAND PRIX 2019', 'Sochi Autodrom', 53, 5.848, convert(date, '29-09-2019', 105), 'Great Britain', 'GB'),
(18, 'FORMULA 1 GRAN PREMIO DE MÉXICO 2019', 'Autódromo Hermanos Rodríguez', 71, 4.304, convert(date, '25-10-2019', 105), 'Mexico', 'MX'),
(19, 'FORMULA 1 HEINEKEN GRANDE PRÊMIO DO BRASIL 2019', 'Autódromo José Carlos Pace', 71, 4.309, convert(date, '17-11-2019', 105), 'Brazil', 'BR'),
(20, 'FORMULA 1 ETIHAD AIRWAYS ABU DHABI GRAND PRIX 2019', 'Yas Marina Circuit', 55, 5.554, convert(date, '01-12-2019', 105), 'United Arab Emirates', 'AE');
