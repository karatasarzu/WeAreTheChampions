using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class MatchForm : Form
    {
        private readonly WATCDbContext db;
        private readonly Match selectedMatch;
        public MatchForm(WATCDbContext db)
        {
            InitializeComponent();
            this.db = db;
            ListTeams();
        }
        public MatchForm(WATCDbContext db, Match selectedMatch)
        {
            InitializeComponent();
            this.db = db;
            this.selectedMatch = selectedMatch;
            dtpMatchTime.Value = selectedMatch.MatchTime;
            cmbTeam1.DataSource = db.Teams.ToList();
            cmbTeam2.DataSource = db.Teams.ToList();
            cmbTeam1.SelectedItem = selectedMatch.Team1;
            cmbTeam2.SelectedItem = selectedMatch.Team2;
            txtScore1.Text = selectedMatch.Score1.ToString();
            txtScore2.Text = selectedMatch.Score2.ToString();
            btnMatchSave.Visible = true;
            btnMatchAdd.Visible = false;
        }
        private void ListTeams()
        {
            cmbTeam1.DataSource = db.Teams.ToList();
            cmbTeam1.SelectedIndex = -1;
            cmbTeam2.DataSource = db.Teams.ToList();
            cmbTeam2.SelectedIndex = -1;
        }
        private void btnMatchAdd_Click(object sender, EventArgs e)
        {
            if (cmbTeam1.SelectedIndex < 0 || cmbTeam2.SelectedIndex < 0)
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }
            if (cmbTeam1.SelectedItem == cmbTeam2.SelectedItem)
            {
                MessageBox.Show("Please Select Different Teams");
                return;
            }
            Match match = new Match()
            {
                Team1 = (Team)cmbTeam1.SelectedItem,
                Team2 = (Team)cmbTeam2.SelectedItem,
                MatchTime = dtpMatchTime.Value,
                Score1 = string.IsNullOrEmpty(txtScore1.Text) ? null as int? : Convert.ToInt32(txtScore1.Text.Trim()),
                Score2 = string.IsNullOrEmpty(txtScore2.Text) ? null as int? : Convert.ToInt32(txtScore2.Text.Trim()),
                Result = CalculateResult()
            };

            db.Matches.Add(match);
            db.SaveChanges();
            ClearMatchForm();
        }
        private void btnMatchSave_Click(object sender, EventArgs e)
        {
            if (cmbTeam1.SelectedIndex < 0 || cmbTeam2.SelectedIndex < 0)
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }
            if (cmbTeam1.SelectedItem == cmbTeam2.SelectedItem)
            {
                MessageBox.Show("Please Select Different Teams");
                return;
            }
            selectedMatch.MatchTime = dtpMatchTime.Value;
            selectedMatch.Team1 = (Team)cmbTeam1.SelectedItem;
            selectedMatch.Team2 = (Team)cmbTeam2.SelectedItem;
            selectedMatch.Score1 = string.IsNullOrEmpty(txtScore1.Text) ? null as int? : Convert.ToInt32(txtScore1.Text.Trim());
            selectedMatch.Score2 = string.IsNullOrEmpty(txtScore2.Text) ? null as int? : Convert.ToInt32(txtScore2.Text.Trim());
            selectedMatch.Result = CalculateResult();
            db.SaveChanges();
            Close();
        }
        private void btnMatchCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Result? CalculateResult()
        {
            int? a = string.IsNullOrEmpty(txtScore1.Text) ? null as int? : Convert.ToInt32(txtScore1.Text.Trim());
            int? b = string.IsNullOrEmpty(txtScore2.Text) ? null as int? : Convert.ToInt32(txtScore2.Text.Trim());
            if (a > b)
                return Result.Team1Win;
            else if (b > a)
                return Result.Team2Win;
            else if (a == b && a != null && b != null)
                return Result.Draw;
            else
                return null;
        }
        private void ClearMatchForm()
        {
            txtScore1.Clear();
            txtScore2.Clear();
            dtpMatchTime.Value = DateTime.Now;
            cmbTeam1.SelectedIndex = -1;
            cmbTeam2.SelectedIndex = -1;
            btnMatchSave.Visible = false;
            btnMatchAdd.Visible = true;
        }
    }
}
