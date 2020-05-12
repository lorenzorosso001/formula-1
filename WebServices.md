##IMPLEMENTED WEB SERVICES
#FORMULA ONE PROJ – Rosso Lorenzo

###TEAMS
**api/teams**
[
  - same as: api/teams/id/details--,
  - same as: api/teams/id/details--
  … 
]

**api/teams/1/details**
{
  name: “Alfa Romeo”,
  fullTeamName: “Alfa Romeo Racing”,
  country: { countryCode: ”CH”, countryName: “Switzerland” }
  powerUnit: “Ferrari”,
  technicalChief: “Jan Monchaux”,
  chassis: “C38”,
  img: “...”,
  drivers:
    [
      { firstname: “Antonio”, lastName: “Giovinazzi” },
      {firstname: “Kimi”, lastName: “Räikkönen” }
    ]
}



###DRIVERS
**api/drivers**
[
  --same as: api/drivers/id/details--,
  --same as: api/drivers/id/details--
  … 
]

**api/drivers/1/details**
{
  firstName: “Lewis”,
  lastName: “Hamilton”,
  img: “...”,
   dob: “07/01/1985”,
  placeOfBirth: “Stevenage”,
  Country: { countryCode: “GB”, countryName: “United Kingdom”}
}


###COUNTRIES
**api/countries**
[
  --same as: api/countries/code/details --,
  --same as: api/countries/code/details--
  … 
]
**api/countries/AF/details**
{
  countryCode: “AF”,
  countryName: “Afghanistan”
}


###RACES
**api/races**
[
  --same as: api/races/id/details --,
  --same as: api/races/id/details--
  … 
]
**api/races/1/details**
{
  grandPrixName: “FORMULA 1 ROLEX AUSTRALIAN GRAND PRIX 2019”,
  grandPrixDate: “17-03-2019”
  country: { countryCode: “AU”, countryName: “Australia”}
  circuit : {name: “Autodròmo Hermanos Rodriguez, nLaps: 71, length: 4304, recordLap: '1.18.741'}
}

###CIRCUITS
**api/circuits**
[
  --same as: api/circuits/id/details --,
  --same as: api/circuits/id/details--
  … 
]
**api/circuits/1/details**
{
  name: “Autódromo Hermanos Rodríguez”,
  nLaps: 71
  length: 4304,
  recordLap: “1.18.741”
}

###SCORES
**api/scores**
[
  --same as: api/scores/id/details --,
  --same as: api/scores/id/details--
  … 
]
**api/scores/1/details**
{
   score: 400,
   details: “No accidents”
}


###RACES SCORES
**api/racesscores**
[
  --same as: api/racesscores/id/details --,
  --same as: api/racesscores/id/details--
  … 
]
**api/racesscores/1/details**
{
  driver: {firstname: “Kimi”, lastName: “Räikkönen” },
  score: {score: 400, details: “No accidents”},
  race: {
  grandPrixName: “FORMULA 1 ROLEX AUSTRALIAN GRAND PRIX 2019”,
  circuitName: “Melbourne Grand Prix Circuit”,
  nLaps: 58,
  grandPrixDate: “17-03-2019”
  country: { countryCode: “AU”, countryName: “Australia”}
    },
fastestLap: “2'18"300”
}

