using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Driver
    {
        #region Attributes
        private readonly int id;
        private string firstname;
        private string lastname;
        private string img;
        private DateTime dob;
        private string placeOfBirthday;
        private Country country;
        #endregion

        #region Constructors
        public Driver(int id) { this.id = id; }

        public Driver(int id, string firstname, string lastname, string img, DateTime dob, string placeOfBirthday, Country country) : this (id)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Img = img;
            this.Dob = dob;
            this.PlaceOfBirthday = placeOfBirthday;
            this.Country = country;
        }
        #endregion

        #region Properties
        public int ID { get => id; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Img { get => img; set => img = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string PlaceOfBirthday { get => placeOfBirthday; set => placeOfBirthday = value; }
        public Country Country { get => country; set => country = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.Firstname} {this.lastname}";
        #endregion
    }
}
