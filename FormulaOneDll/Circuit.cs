using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Circuit
    {
        #region Attributes
        private int id;
        private string name;
        private int nLaps;
        private int length;
        private string recordLap;
        #endregion

        #region Constructors
        public Circuit(int id) { this.id = id; }

        public Circuit(int id, string name, int nLaps, int length, string recordLap)
        {
            this.Id = id;
            this.Name = name;
            this.NLaps = nLaps;
            this.Length = length;
            this.RecordLap = recordLap;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NLaps { get => nLaps; set => nLaps = value; }
        public int Length { get => length; set => length = value; }
        public string RecordLap { get => recordLap; set => recordLap = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.Name} {this.NLaps} {this.Length} {this.RecordLap}";
        #endregion
    }
}
