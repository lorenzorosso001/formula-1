CREATE TABLE [dbo].[Drivers]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [firstname] VARCHAR(128) NOT NULL, 
    [lastname] VARCHAR(128) NOT NULL, 
	[img] VARCHAR(512),
    [dob] DATE NOT NULL, 
    [placeOfBirth] VARCHAR(64) NOT NULL, 
    [extCountry] CHAR(2) NOT NULL
);

INSERT INTO [dbo].[Drivers]
(
	id,
	firstName,
	lastName,
	img,
	dob,
	placeOfBirth,
	extCountry
)
VALUES
(1,'Lewis', 'Hamilton', 'https://www.formula1.com/content/fom-website/en/drivers/lewis-hamilton/_jcr_content/image.img.1024.medium.jpg/1584013371803.jpg',convert(date, '07-01-1985',105), 'Stevenage', 'GB'),
(2,'Valtteri', 'Bottas', 'https://www.formula1.com/content/fom-website/en/drivers/valtteri-bottas/_jcr_content/image.img.1024.medium.jpg/1584013243241.jpg',convert(date, '28-08-1989',105), 'Nastola', 'FI'),
(3,'Sebastian', 'Vettel','https://www.formula1.com/content/fom-website/en/drivers/sebastian-vettel/_jcr_content/image.img.1024.medium.jpg/1584013014200.jpg',convert(date, '03-07-1987',105), 'Heppenheim', 'DE'),
(4,'Pierre', 'Gasly', 'https://www.formula1.com/content/fom-website/en/drivers/pierre-gasly/_jcr_content/image.img.1024.medium.jpg/1584013791271.jpg', convert(date, '07-02-1996',105), 'Rouen', 'FR'),
(5,'Charles', 'Leclerc', 'https://www.formula1.com/content/fom-website/en/drivers/charles-leclerc/_jcr_content/image.img.1024.medium.jpg/1584013824254.jpg',convert(date, '16-10-1997',105), 'Monte Carlo', 'MC'),
(6,'Daniel', 'Ricciardo', 'https://www.formula1.com/content/fom-website/en/drivers/daniel-ricciardo/_jcr_content/image.img.1024.medium.jpg/1584012376585.jpg',convert(date, '01-07-1989',105), 'Perth', 'AU'),
(7,'Max', 'Verstappen', 'https://www.formula1.com/content/fom-website/en/drivers/max-verstappen/_jcr_content/image.img.1024.medium.jpg/1584012927837.jpg',convert(date, '30-09-1997',105), 'Hasselt', 'NL'),
(8,'Alexander', 'Albon', 'https://www.formula1.com/content/fom-website/en/drivers/alexander-albon/_jcr_content/image.img.1024.medium.jpg/1584012927837.jpg',convert(date, '23-03-1996',105), 'London', 'TH'),
(9,'Carlos', 'Sainz', 'https://www.formula1.com/content/fom-website/en/drivers/carlos-sainz/_jcr_content/image.img.1024.medium.jpg/1584012341233.jpg',convert(date, '01-09-1994',105), 'Madrid', 'ES'),
(10,'Lando', 'Norris', 'https://www.formula1.com/content/fom-website/en/drivers/lando-norris/_jcr_content/image.img.1024.medium.jpg/1584013897913.jpg',convert(date, '13-11-1999',105), 'Bristol', 'GB'),
(11,'Nico', 'Hulkenberg', 'https://www.motorbox.com/assets/img/f1/piloti/nico-hulkenberg-renault-f1.jpg',convert(date, '19-08-1987',105), 'Emmerich am Rhein', 'DE'),
(12,'Sergio','Perez','https://www.formula1.com/content/fom-website/en/drivers/sergio-perez/_jcr_content/image.img.1024.medium.jpg/1584013058541.jpg',convert(date, '26-01-1990',105), 'Guadalajara', 'MX'),
(13,'Robert', 'Kubica','https://i.pinimg.com/originals/d1/8d/5b/d18d5bdae9c786ea2d8c2c922dd36151.jpg',convert(date, '07-12-1984',105), 'Krakow', 'PL'),
(14,'Kimi', 'Räikkönen', 'https://www.formula1.com/content/fom-website/en/drivers/kimi-raikkonen/_jcr_content/image.img.1024.medium.jpg/1584012751723.jpg',convert(date, '17-10-1979',105), 'Espoo', 'FI'),
(15,'Lance', 'Stroll', 'https://www.formula1.com/content/fom-website/en/drivers/lance-stroll/_jcr_content/image.img.1024.medium.jpg/1584013460046.jpg',convert(date, '29-10-1998',105), 'Montreal', 'CA'),
(16,'Antonio', 'Giovinazzi', 'https://www.formula1.com/content/fom-website/en/drivers/antonio-giovinazzi/_jcr_content/image.img.1024.medium.jpg/1584013739535.jpg',convert(date, '14-12-1993',105), 'Martina Franca', 'IT'),
(17,'Kevin', 'Magnussen', 'https://www.formula1.com/content/fom-website/en/drivers/kevin-magnussen/_jcr_content/image.img.1024.medium.jpg/1584012829634.jpg',convert(date, '05-10-1992',105), 'Roskilde', 'DK'),
(18,'Romain', 'Grosjean', 'https://www.formula1.com/content/fom-website/en/drivers/romain-grosjean/_jcr_content/image.img.1024.medium.jpg/1584012955838.jpg',convert(date, '17-04-1986',105), 'Geneva', 'CH'),
(19,'George', 'Russell', 'https://www.formula1.com/content/fom-website/en/drivers/george-russell/_jcr_content/image.img.1024.medium.jpg/1584013858126.jpg',convert(date, '15-02-1998',105), 'Kings Lynn', 'GB'),
(20,'Daniil', 'Kvyat', 'https://www.formula1.com/content/fom-website/en/drivers/daniil-kvyat/_jcr_content/image.img.1024.medium.jpg/1584012653479.jpg',convert(date, '26-04-1994',105), 'Ufa', 'RU');