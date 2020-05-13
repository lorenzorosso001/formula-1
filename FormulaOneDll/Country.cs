using System;
using System.Collections.Generic;
using System.Globalization;
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
        private string img;
        #endregion

        #region Constructors
        public Country() { }

        public Country(string countryCode, string countryName, string img)
        {
            this.CountryCode = countryCode;
            this.CountryName = countryName;
            this.Img = img;
        }
        #endregion

        #region Properties
        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public string Img { get => img; set => img = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.CountryCode} {this.CountryName}";
        #endregion
    }
}
