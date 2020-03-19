using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FormulaOneDll;

namespace FormulaOneCrudFormProject
{
    public partial class FormMain : Form
    {
        private DbTools db;
        private BindingList<Team> teams;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            teams = new BindingList<Team>(db.LoadTeams());
            listBoxTeam.DataSource = teams;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (db.SerializeToJSON<Team>(teams, @"C:\Users\loren\OneDrive\Desktop\teams.json"))
                MessageBox.Show("Operazione completata con successo.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operazione fallita.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s = listBoxTeam.SelectedItem.ToString().Split('(')[0].Trim();
            //Team team = teams.ToList().Find(t => t.Name == s);
        }
    }
}
