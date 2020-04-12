using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.IO;

// Cercare questi pacchetti su nuget
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.ComponentModel;

using Newtonsoft.Json;

namespace FormulaOneDll
{
    public class DbTools
    {
        private const string WORKINGPATH = @"C:\Dati\C#\formula-1-lorenzorosso001\Dati\"; //DA CAMBIARE
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dati\C#\formula-1-lorenzorosso001\Dati\FormulaOne.mdf;Integrated Security=True";

        private Dictionary<int, Driver> drivers;
        private Dictionary<string, Country> countries;
        private List<Team> teams;

        public Dictionary<int, Driver> Drivers
        {
            get
            {
                if (this.drivers == null || this.drivers.Count == 0)
                    this.GetDrivers();
                return this.drivers;
            }
            set => drivers = value;
        }
        public Dictionary<string, Country> Countries
        {
            get
            {
                if (this.countries == null)
                    this.GetCountries();
                return this.countries;
            }
            set => countries = value;
        }
        public List<Team> Teams
        {
            get
            {
                if (teams == null || teams.Count == 0)
                    this.LoadTeams();
                return teams;
            }
            set => teams = value;
        }

        //public void CreateCountriesWithSmo()
        //{
        //    string sqlConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; 
        //        AttachDbFilename =C:\Users\loren\OneDrive\Desktop\_Scuola\2019-2020\INFORMATICA\CAMBIERI\FormulaOneSolution\FormulaOne.mdf; Integrated Security = True";
        //    FileInfo file = new FileInfo(@"Countries.sql");
        //    string script = file.OpenText().ReadToEnd();
        //    SqlConnection conn = new SqlConnection(sqlConnectionString);
        //    Server server = new Server(new ServerConnection(conn));

        //    try
        //    {
        //        server.ConnectionContext.ExecuteNonQuery(script);
        //        file.OpenText().Close();
        //        conn.Close();
        //        Console.WriteLine("CreateCountries: SUCCESS");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex);
        //    }
        //}

        public void ExecuteSqlScript(string sqlScriptPath)
        {
            var fileContent = File.ReadAllText($"{WORKINGPATH}{sqlScriptPath}");
            fileContent = fileContent
                .Replace("\r\n", "")
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\t", "");
            var sqlQueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOne.mdf;Integrated Security=True");
            var cmd = new SqlCommand("query", con);
            con.Open();
            foreach (var query in sqlQueries)
            {
                cmd.CommandText = query;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Errore in esecuzione della query numero: {ex.LineNumber}");
                    Console.WriteLine($"Errore: {ex.Number} {ex.Message}");
                }
            }
            con.Close();
            con.Dispose();
            SqlConnection.ClearAllPools();
        }

        //public void MakeBackup()
        //{
        //    StreamReader sr = new StreamReader($"{WORKINGPATH}FormulaOne.mdf");
        //    StreamWriter sw = new StreamWriter($"{WORKINGPATH}FormulaOneBackup.mdf");
        //    sw.Write(sr.ReadToEnd());
        //    sr.Close();
        //    sw.Close();
        //}
        //public void Restore()
        //{
        //    StreamReader sr = new StreamReader($"{WORKINGPATH}FormulaOneBackup.mdf");
        //    StreamWriter sw = new StreamWriter($"{WORKINGPATH}FormulaOne.mdf");
        //    sw.Write(sr.ReadToEnd());
        //    sr.Close();
        //    sw.Close();
        //}

        //public void DropTable(string tableName)
        //{
        //    var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOne.mdf;Integrated Security=True");
        //    var cmd = new SqlCommand($"Drop Table {tableName};", con);
        //    con.Open();
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine($"Errore: {ex.Number} {ex.Message}");
        //    }
        //    con.Close();
        //    con.Dispose();
        //}

        public void GetCountries()
        {
            if (this.countries == null)
            {
                this.countries = new Dictionary<string, Country>();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    con.Open();
                    var command = new SqlCommand("SELECT * FROM Countries;", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string countryIsoCode = reader.GetString(0);
                        Country c = new Country()
                        {
                            CountryCode = countryIsoCode,
                            CountryName = reader.GetString(1)
                        };
                        this.countries.Add(countryIsoCode, c);
                    }
                    con.Close();
                    con.Dispose();
                }
                SqlConnection.ClearAllPools();
            }
        }


        public void GetDrivers(bool forceReload = false)
        {
            if (forceReload/* || this.countries == null*/)
            {
                this.GetCountries();
            }
            if (forceReload || this.drivers == null)
            {
                this.Drivers = new Dictionary<int, Driver>();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    con.Open();
                    var command = new SqlCommand("SELECT * FROM Drivers;", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int driverIsoCode = reader.GetInt32(0);
                        Driver d = new Driver(driverIsoCode)
                        {
                            Firstname = reader.GetString(1),
                            Lastname = reader.GetString(2),
                            Dob = reader.GetDateTime(3),
                            PlaceOfBirthday = reader.GetString(4),
                            Country = Countries[reader.GetString(5)]
                        };
                        this.Drivers.Add(driverIsoCode, d);
                    }
                    con.Close();
                    con.Dispose();
                }
                SqlConnection.ClearAllPools();
            }
        }

        public List<Driver> GetDriversAsList()
        {
            List<Driver> lstDrivers = new List<Driver>();

            var con = new SqlConnection(CONNECTION_STRING);
            using (con)
            {
                con.Open();
                var command = new SqlCommand("SELECT * FROM Drivers;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Firstname = reader.GetString(1);
                    string Lastname = reader.GetString(2);
                    DateTime Dob = reader.GetDateTime(3);
                    string PlaceOfBirthday = reader.GetString(4);
                    Country Country = Countries[reader.GetString(5)];
                    Driver d = new Driver(Id, Firstname, Lastname, Dob, PlaceOfBirthday, Country);
                    lstDrivers.Add(d);
                };            
                con.Close();
                con.Dispose();
            }
            SqlConnection.ClearAllPools();
            
            return lstDrivers;
        }

            public void LoadTeams()
            {
                GetCountries();
                GetDrivers(true);
                teams = new List<Team>();
                var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOne.mdf;Integrated Security=True");
                using (con)
                {
                    con.Open();
                    var command = new SqlCommand("SELECT * FROM Teams;", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Team t = new Team()
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            FullTeamName = reader.GetString(2),
                            Country = this.Countries[reader.GetString(3)],
                            PowerUnit = reader.GetString(4),
                            TechnicalChief = reader.GetString(5),
                            Chassis = reader.GetString(6),
                            FirstDriver = this.Drivers[reader.GetInt32(7)],
                            SecondDriver = this.Drivers[reader.GetInt32(8)]
                        };
                        teams.Add(t);
                    }
                    con.Close();
                    con.Dispose();
                }
                SqlConnection.ClearAllPools();
        }

        public bool SerializeToJSON<T>(IEnumerable<T> list, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(list, Formatting.Indented);
                new StreamWriter(path, false).Write(json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
