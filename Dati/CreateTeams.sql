CREATE TABLE [dbo].[Teams]
(
	[id] INT NOT NULL PRIMARY KEY,
    [name] VARCHAR(128) NOT NULL,
    [fullTeamName] VARCHAR(128) NOT NULL, 
    [extCountry] CHAR(2) NOT NULL, 
    [powerUnit] VARCHAR(128) NOT NULL, 
    [technicalChief] VARCHAR(128) NOT NULL,
	[chassis] VARCHAR(128) NOT NULL,
	[img] VARCHAR(512),
	[extFirstDriver] INT NOT NULL,
	[extSecondDriver] INT NOT NULL
);

INSERT INTO [dbo].[Teams]
(
	id,
	name,
	fullTeamName,
	extCountry,
	powerUnit,
	technicalChief,
	chassis,
	img,
	extFirstDriver,
	extSecondDriver
)
VALUES
(1,'Alfa Romeo', 'Alfa Romeo Racing', 'CH', 'Ferrari', 'Jan Monchaux', 'C38', 'https://www.formula1.com/content/fom-website/en/teams/Alfa-Romeo-Racing/_jcr_content/logo.img.jpg/1582650443223.jpg', 14, 16),
(2,'Ferrari', 'Scuderia Ferrari Mission Winnow', 'IT', 'Ferrari', 'Mattia Binotto', 'SF90', 'https://www.formula1.com/content/fom-website/en/teams/Ferrari/_jcr_content/logo.img.jpg/1521797345005.jpg', 3,5),
(3,'Red Bull', 'Aston Martin Red Bull Racing', 'GB', 'Honda', 'Pierre Waché', 'RB15','https://www.formula1.com/content/fom-website/en/teams/Red-Bull-Racing/_jcr_content/logo.img.jpg/1514762875081.jpg',7,4),
(4,'Haas', 'Haas F1 Team', 'US', 'Ferrari', 'Rob Taylor', 'VF-19', 'https://www.formula1.com/content/fom-website/en/teams/Haas-F1-Team/_jcr_content/logo.img.png/1568040720597.png', 18, 17),
(5,'McLaren', 'McLaren F1 Team', 'GB', 'Renault', 'James Key', 'MCL34', 'https://www.formula1.com/content/fom-website/en/teams/McLaren/_jcr_content/logo.img.jpg/1515152671364.jpg', 9, 10),
(6,'Mercedes', 'Mercedes AMG Petronas Motorsport', 'GB', 'Mercedes', 'James Allison', 'W10', 'https://www.formula1.com/content/fom-website/en/teams/Mercedes/_jcr_content/logo.img.jpg/1582638375557.jpg', 1,2),
(7,'Toro Rosso', 'Red Bull Toro Rosso Honda', 'IT', 'Honda', 'Jody Eggington', 'STR14', 'https://www.formula1.it/admin/foto/Scuderie/Scuderia_173.gif.png', 20, 8),
(8,'Racing Point', 'SportPesa Racing Point F1 Team', 'GB', 'BWT Mercedes', 'Andrew Green', 'RP19','https://www.formula1.com/content/fom-website/en/teams/Racing-Point/_jcr_content/logo.img.jpg/1582650505746.jpg', 12, 15),
(9,'Williams', 'ROKiT Williams Racing', 'GB', 'Mercedes', 'TBC', 'FW42','https://www.formula1.com/content/fom-website/en/teams/Williams/_jcr_content/logo.img.png/1551261665481.png', 13, 19),
(10,'Renault', 'Renault F1 Team', 'GB', 'Renault', 'Nick Chester', 'R.S.19','https://www.formula1.com/content/fom-website/en/teams/Renault/_jcr_content/logo.img.jpg/1584017512684.jpg',6,11);
