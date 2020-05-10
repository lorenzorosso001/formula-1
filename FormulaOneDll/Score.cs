using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Score
    {
        #region Attributes
        private int id;
        private int score;
        private string details;
        #endregion

        #region Constructors
        public Score(int id) { this.id = id; }

        public Score(int id, int score, string details)
        {
            this.Id = id;
            this.Scoree = score;
            this.Details = details;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public int Scoree { get => score; set => score = value; }
        public string Details { get => details; set => details = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.Scoree} {this.Details}";
        #endregion
    }
}
