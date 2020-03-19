using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Country
    {
        #region Attributes
        private string countryCode;
        private string countryName;
        #endregion

        #region Constructors
        public Country() { }

        public Country(string countryCode, string countryName)
        {
            this.CountryCode = countryCode;
            this.CountryName = countryName;
        }
        #endregion

        #region Properties
        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.CountryCode} {this.CountryName}";
        #endregion
    }
}
