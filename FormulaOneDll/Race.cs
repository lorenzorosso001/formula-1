using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Race
    {
        #region Attributes
        private int id;
        private string grandPrixName;
        private DateTime grandPrixDate;
        private Country country;
        private Circuit circuit;
        #endregion

        #region Constructors
        public Race(int id) { this.id = id; }

        public Race(int id, string grandPrixName, DateTime grandPrixDate, Country country, Circuit circuit)
        {
            this.Id = id;
            this.GrandPrixName = grandPrixName;
            this.GrandPrixDate = grandPrixDate;
            this.Country = country;
            this.Circuit = circuit;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string GrandPrixName { get => grandPrixName; set => grandPrixName = value; }
        public DateTime GrandPrixDate { get => grandPrixDate; set => grandPrixDate = value; }
        public Country Country { get => country; set => country = value; }
        public Circuit Circuit { get => circuit; set => circuit = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.grandPrixName} {this.GrandPrixDate} {this.Country.CountryName} {this.Circuit.Name}";
        #endregion
    }
}
