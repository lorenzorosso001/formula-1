using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Team
    {
        #region Attributes
        private int id;
        private string name;
        private string fullTeamName;
        private Country country;
        private string powerUnit;
        private string technicalChief;
        private string chassis;
        private string img;
        private Driver firstDriver;
        private Driver secondDriver;
        #endregion

        #region Constructors
        public Team () { }

        public Team(int id, string nome, string fullTeamName, Country country, string powerUnit, string technicalChief, string chassis, string img, Driver firstDriver, Driver secondDriver)
        {
            this.ID = id;
            this.Name = nome;
            this.FullTeamName = fullTeamName;
            this.Country = country;
            this.PowerUnit = powerUnit;
            this.TechnicalChief = technicalChief;
            this.Chassis = chassis;
            this.img = img;
            this.FirstDriver = firstDriver;
            this.SecondDriver = secondDriver;
        }
        #endregion

        #region Properties
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string FullTeamName { get => fullTeamName; set => fullTeamName = value; }
        public Country Country { get => country; set => country = value; }
        public string PowerUnit { get => powerUnit; set => powerUnit = value; }
        public string TechnicalChief { get => technicalChief; set => technicalChief = value; }
        public string Chassis { get => chassis; set => chassis = value; }
        public string Img { get => img; set => img = value; }
        public Driver FirstDriver { get => firstDriver; set => firstDriver = value; }
        public Driver SecondDriver { get => secondDriver; set => secondDriver = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.Name} ({this.Country.CountryName})";
        #endregion
    }
}
