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
using Color = WeAreTheChampions.Models.Color;
using System.IO;

namespace WeAreTheChampions
{
    public partial class HomePage : Form
    {
        WATCDbContext db = new WATCDbContext();
        public HomePage()
        {
            InitializeComponent();
            ListTeams();
            ListColors();
            ListPlayers();
            ListMatches();
            FillMainPage();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            string infoMessage = "Hold down CTRL to make multiple choice!";
            string infoMessageColorWheel = "Click the color wheel to choose any color!";
            tlpInfo.SetToolTip(pboColorInfo, infoMessage);
            tlpInfo.SetToolTip(pboTeamColorInfo, infoMessage);
            tlpInfo.SetToolTip(pboColorWheelInfo, infoMessageColorWheel);
        }

        #region Color Section
        private void ListColors()
        {
            lviColors.Items.Clear();
            foreach (var item in db.Colors)
            {
                ListViewItem lvi = new ListViewItem($"{item.ColorName}");
                lvi.Text = $"{item.ColorName}\nR:{item.Red} G:{item.Green} B:{item.Blue}";
                lvi.Tag = item.Id;
                lvi.ImageKey = "fill";
                lvi.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                if (lvi.BackColor == System.Drawing.Color.FromArgb(0, 0, 0)) //If the color is black write it with white!
                {
                    lvi.ForeColor = System.Drawing.Color.White;
                }
                lviColors.Items.Add(lvi);
            }

            lviTeamColorsToChoose.Items.Clear();
            foreach (var item in db.Colors)
            {
                ListViewItem lvi = new ListViewItem($"{item.ColorName}");
                lvi.Text = $"{item.ColorName}\nR:{item.Red} G:{item.Green} B:{item.Blue}";
                lvi.Tag = item.Id;
                lvi.ImageKey = "fill";
                lvi.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                if (lvi.BackColor == System.Drawing.Color.FromArgb(0, 0, 0)) //if the color is black write it with white!
                {
                    lvi.ForeColor = System.Drawing.Color.White;
                }
                lviTeamColorsToChoose.Items.Add(lvi);
            }
        }
        private void pboColorWheel_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            txtR.Text = cd.Color.R.ToString();
            txtG.Text = cd.Color.G.ToString();
            txtB.Text = cd.Color.B.ToString();
            pboSelectedColor.BackColor = cd.Color;
        }
        private void pboSelectedColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            txtR.Text = cd.Color.R.ToString();
            txtG.Text = cd.Color.G.ToString();
            txtB.Text = cd.Color.B.ToString();
            pboSelectedColor.BackColor = cd.Color;
        }
        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColorName.Text) || string.IsNullOrEmpty(txtR.Text) || string.IsNullOrEmpty(txtG.Text) || string.IsNullOrEmpty(txtB.Text))
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }

            db.Colors.Add(new Color()
            {
                ColorName = txtColorName.Text.Trim(),
                Red = Convert.ToInt32(txtR.Text),
                Green = Convert.ToInt32(txtG.Text),
                Blue = Convert.ToInt32(txtB.Text)
            });

            db.SaveChanges();
            ClearColorForm();
            ListColors();
        }
        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            if (lviColors.SelectedItems.Count != 1)
            {
                MessageBox.Show("Incorrect choice! Please choose one color!");
                return;
            }

            btnColorOk.Visible = true;
            btnColorCancel.Visible = true;
            btnColorAdd.Visible = false;
            btnColorEdit.Visible = false;
            btnColorDelete.Visible = false;

            ListViewItem lviItem = lviColors.SelectedItems[0];
            int colorId = (int)lviItem.Tag;
            Color willEdited = db.Colors.Where(x => x.Id == colorId).FirstOrDefault();

            txtColorName.Text = willEdited.ColorName;
            txtR.Text = willEdited.Red.ToString();
            txtG.Text = willEdited.Green.ToString();
            txtB.Text = willEdited.Blue.ToString();
            pboSelectedColor.BackColor = System.Drawing.Color.FromArgb(willEdited.Red, willEdited.Green, willEdited.Blue);
        }
        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            if (lviColors.SelectedItems.Count != 1)
            {
                MessageBox.Show("Incorrect choice! Please choose one color!");
                return;
            }
            ListViewItem lviItem = lviColors.SelectedItems[0];
            int colorId = (int)lviItem.Tag;
            Color willDeleted = db.Colors.Where(x => x.Id == colorId).FirstOrDefault();
            imlColors.Images.RemoveByKey(willDeleted.ColorName);
            db.Colors.Remove(willDeleted);
            db.SaveChanges();
            ListColors();
        }
        private void btnColorOk_Click(object sender, EventArgs e)
        {
            if (lviColors.SelectedItems.Count != 1)
            {
                MessageBox.Show("Incorrect choice! Please choose one color!");
                return;
            }

            ListViewItem lviItem = lviColors.SelectedItems[0];
            int colorId = (int)lviItem.Tag;
            Color editedColor = db.Colors.Find(colorId);

            if (string.IsNullOrEmpty(txtColorName.Text) || string.IsNullOrEmpty(txtR.Text) || string.IsNullOrEmpty(txtG.Text) || string.IsNullOrEmpty(txtB.Text))
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }
            editedColor.ColorName = txtColorName.Text.Trim();
            editedColor.Red = Convert.ToInt32(txtR.Text);
            editedColor.Green = Convert.ToInt32(txtG.Text);
            editedColor.Blue = Convert.ToInt32(txtB.Text);

            if (editedColor.Id == 0)
            {
                db.Colors.Add(editedColor);
                MessageBox.Show("Color added!");
            }

            db.SaveChanges();
            ClearColorForm();
            ListColors();
        }
        private void btnColorCancel_Click(object sender, EventArgs e)
        {
            ClearColorForm();
            ListColors();
        }
        private void ClearColorForm()
        {
            txtColorName.Clear();
            txtR.Clear();
            txtG.Clear();
            txtB.Clear();
            pboSelectedColor.BackColor = System.Drawing.Color.Transparent;
            btnColorOk.Visible = false;
            btnColorCancel.Visible = false;
            btnColorAdd.Visible = true;
            btnColorEdit.Visible = true;
            btnColorDelete.Visible = true;
        }

        #endregion

        #region Team Section
        private void ListTeams()
        {
            lstTeams.Items.Clear();
            lstTeams.DataSource = db.Teams.ToList();
            cmbPlayerWillAddTeam.Items.Clear();
            cmbPlayerWillAddTeam.DataSource = db.Teams.ToList();
            cmbPlayerWillAddTeam.SelectedIndex = -1;
            cmbPlayerTransferTeam.Items.Clear();
            cmbPlayerTransferTeam.DataSource = db.Teams.ToList();
        }
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamName.Text) || lviTeamColorsToChoose.SelectedItems.Count <= 0)
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }
            Team team = new Team()
            {
                TeamName = txtTeamName.Text.Trim()
            };

            foreach (ListViewItem item in lviTeamColorsToChoose.SelectedItems)
            {
                Color color = db.Colors.Where(x => x.Id == (int)item.Tag).FirstOrDefault();
                team.Colors.Add(color);
            }

            db.Teams.Add(team);
            db.SaveChanges();
            ListTeams();
            ClearTeamForm();
        }
        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            ListSelectedTeamColors(selectedTeam);
            lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
            pboTeamPlayerPhoto.ImageLocation = selectedTeam.Players.Select(x => x.PhotoPath).ToString();
            Player selectedPlayer = (Player)lstTeamPlayers.SelectedItem;
            pboTeamPlayerPhoto.ImageLocation = selectedPlayer.PhotoPath;
        }
        private void ListSelectedTeamColors(Team selectedTeam)
        {
            lviTeamColors.Items.Clear();
            foreach (var item in selectedTeam.Colors)
            {
                ListViewItem lvi = new ListViewItem($"{item.ColorName}");
                lvi.Text = $"{item.ColorName}\nR:{item.Red} G:{item.Green} B:{item.Blue}";
                lvi.Tag = item.Id;
                lvi.ImageKey = "dropper";
                lvi.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                if (lvi.BackColor == System.Drawing.Color.FromArgb(0, 0, 0)) //if the color is black write it with white!
                {
                    lvi.ForeColor = System.Drawing.Color.White;
                }
                lviTeamColors.Items.Add(lvi);
            }
        }
        private void btnTeamEdit_Click(object sender, EventArgs e)
        {
            btnTeamEdit.Visible = false;
            btnTeamDelete.Visible = false;
            btnTeamAdd.Visible = false;
            btnTeamOk.Visible = true;
            btnTeamCancel.Visible = true;

            Team selectedTeam = (Team)lstTeams.SelectedItem;
            txtTeamName.Text = selectedTeam.TeamName.ToString();

            //Show the colors of the selected team as selected to edit.
            for (int i = 0; i < lviTeamColors.Items.Count; i++)
            {
                ListViewItem willSelectedColors = lviTeamColors.Items[i];
                foreach (ListViewItem item in lviTeamColorsToChoose.Items)
                {
                    if (item.Text == willSelectedColors.Text)
                    {
                        lviTeamColorsToChoose.Items[item.Index].Selected = true;
                    }
                }
            }
        }
        private void btnTeamCancel_Click(object sender, EventArgs e)
        {
            ClearTeamForm();
        }
        private void btnTeamOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamName.Text) || lviTeamColorsToChoose.SelectedItems.Count <= 0)
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }

            Team selectedTeam = (Team)lstTeams.SelectedItem;
            selectedTeam.TeamName = txtTeamName.Text.Trim();

            selectedTeam.Colors.Clear();
            foreach (ListViewItem item in lviTeamColorsToChoose.SelectedItems)
            {
                Color color = db.Colors.Where(x => x.Id == (int)item.Tag).FirstOrDefault();
                selectedTeam.Colors.Add(color);
            }

            db.SaveChanges();
            ClearTeamForm();
            ListSelectedTeamColors(selectedTeam);
        }
        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose a team!");
                return;
            }
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            Team willDeleted = db.Teams.Find(selectedTeam.Id);
            db.Teams.Remove(willDeleted);
            db.SaveChanges();
            ClearTeamForm();
        }
        private void btnTeamRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lstTeamPlayers.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)lstTeamPlayers.SelectedItem;
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                selectedTeam.Players.Remove(selectedPlayer);
                db.SaveChanges();
                lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
            }
        }
        private void lstTeamPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstTeamPlayers.SelectedItem;
            pboTeamPlayerPhoto.ImageLocation = selectedPlayer.PhotoPath;
        }
        private void ClearTeamForm()
        {
            txtTeamName.Clear();
            btnTeamEdit.Visible = true;
            btnTeamDelete.Visible = true;
            btnTeamOk.Visible = false;
            btnTeamCancel.Visible = false;
            btnTeamAdd.Visible = true;
            ListColors();
            ListTeams();
        }

        #endregion

        #region Player Section
        private void ListPlayers()
        {
            cmbTeams.Items.Clear();
            cmbTeams.Items.Add("All Players");
            foreach (var item in db.Teams)
            {
                cmbTeams.Items.Add(item);
            }
            cmbTeams.SelectedIndex = 0;
        }
        private void btnPlayerBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "Image Files | *.jpeg;*.jpg;*.png;",
                Title = "Choose image for Super Character"
            };
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(filePath);
                string ext = Path.GetExtension(filePath);
                string imagePath = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + Guid.NewGuid().ToString() + ext;
                bitmap.Save(imagePath);
                pboPlayerWillAddPhoto.ImageLocation = imagePath;
                txtPlayerPhotoPath.Text = imagePath;
            }
        }
        private void btnPlayerAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerWillAddName.Text))
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }

            Player player = new Player()
            {
                PlayerName = txtPlayerWillAddName.Text,
                //Team = (Team)cmbPlayerWillAddTeam.SelectedItem
            };
            if (!string.IsNullOrEmpty(pboPlayerWillAddPhoto.ImageLocation))
            {
                player.PhotoPath = pboPlayerWillAddPhoto.ImageLocation;
            }
            if (cmbPlayerWillAddTeam.SelectedIndex != -1)
            {
                player.Team = (Team)cmbPlayerWillAddTeam.SelectedItem;
            }
            db.Players.Add(player);
            db.SaveChanges();
            ClearPlayerForm();
            ListColors();
        }
        private void btnPlayerSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelectedPlayerName.Text) || string.IsNullOrEmpty(txtSelectedPlayerTeam.Text))
            {
                MessageBox.Show("These field cannot be empty!");
                return;
            }
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            if (selectedPlayer.PhotoPath != pboPlayerWillAddPhoto.ImageLocation) //Photo has changed.
            {
                DeleteImage(selectedPlayer.PhotoPath); //Delete previous photo.
                selectedPlayer.PhotoPath = pboPlayerWillAddPhoto.ImageLocation; //Add new one.
            }
            selectedPlayer.PhotoPath = txtPlayerPhotoPath.Text.Trim();
            selectedPlayer.PlayerName = txtPlayerWillAddName.Text.Trim();
            db.SaveChanges();
            ClearPlayerForm();
        }
        private void btnPlayerCancel_Click(object sender, EventArgs e)
        {
            ClearPlayerForm();
        }
        private void btnPlayerChangeTeam_Click(object sender, EventArgs e)
        {
            gbTransfer.Enabled = true;
            gbPlayers.Enabled = false;
            gbPlayerAdd.Enabled = false;
            gbPlayerInfo.Enabled = false;
            btnPlayerTransferCancel.Visible = true;
        }
        private void btnPlayerTransfer_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)lstPlayers.SelectedItem;
                selectedPlayer.Team = (Team)cmbPlayerTransferTeam.SelectedItem;
                db.SaveChanges();
            }
            ClearPlayerForm();
        }
        private void btnPlayerTransferCancel_Click(object sender, EventArgs e)
        {
            ClearPlayerForm();
        }
        private void btnPlayerEdit_Click(object sender, EventArgs e)
        {
            cmbPlayerWillAddTeam.Enabled = false;
            btnPlayerSave.Visible = true;
            btnPlayerCancel.Visible = true;
            btnPlayerAdd.Visible = false;

            if (lstPlayers.SelectedIndex != 0)
            {
                Player selectedPlayer = (Player)lstPlayers.SelectedItem;
                txtPlayerPhotoPath.Text = selectedPlayer.PhotoPath;
                pboPlayerWillAddPhoto.ImageLocation = selectedPlayer.PhotoPath;
                txtPlayerWillAddName.Text = selectedPlayer.PlayerName;
                cmbPlayerWillAddTeam.SelectedItem = selectedPlayer.Team;
            }
        }
        private void btnPlayerDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose a team!");
                return;
            }
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            Player willDeleted = db.Players.Find(selectedPlayer.Id);
            db.Players.Remove(willDeleted);
            db.SaveChanges();
            DeleteImage(selectedPlayer.PhotoPath);
            ClearTeamForm();
        }
        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeams.SelectedIndex == 0)
            {
                lstPlayers.DataSource = db.Players.OrderBy(x => x.PlayerName).ToList();
            }
            else
            {
                Team selectedTeam = (Team)cmbTeams.SelectedItem;
                lstPlayers.DataSource = db.Players.Where(x => x.Team.Id == selectedTeam.Id).OrderBy(x => x.PlayerName).ToList();
            }
        }
        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)lstPlayers.SelectedItem;
                pboPlayerSelectedPhoto.ImageLocation = selectedPlayer.PhotoPath;
                txtSelectedPlayerName.Text = selectedPlayer.PlayerName;
                txtSelectedPlayerTeam.Text = selectedPlayer.TeamId == null ? "The player has no team!" : selectedPlayer.Team.TeamName;
            }
        }
        private void DeleteImage(string photoPath)
        {
            //If player's photo is default, don't delete it.
            if (photoPath != Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "defaultimage.png")
                File.Delete(photoPath);
        }
        private void ClearPlayerForm()
        {
            txtPlayerPhotoPath.Clear();
            txtPlayerWillAddName.Clear();
            cmbPlayerWillAddTeam.SelectedIndex = -1;
            pboPlayerWillAddPhoto.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "defaultimage.png";
            btnPlayerSave.Visible = false;
            btnPlayerCancel.Visible = false;
            btnPlayerAdd.Visible = true;
            cmbPlayerWillAddTeam.Enabled = true;
            gbTransfer.Enabled = false;
            gbPlayers.Enabled = true;
            gbPlayerAdd.Enabled = true;
            gbPlayerInfo.Enabled = true;
            btnPlayerTransferCancel.Visible = false;
            cmbPlayerTransferTeam.SelectedIndex = -1;
            ListPlayers();
            lstPlayers.SelectedIndex = 0;
        }
        #endregion

        #region Match Section
        private void FillMainPage()
        {
            int selectedMatchId = (int)dgvMatches.Rows[0].Cells[0].Value;
            Match selectedMatch = db.Matches.FirstOrDefault(x => x.Id == selectedMatchId);
            lblTeam1.Text = $"{selectedMatch.Team1.TeamName}";
            lblTeam2.Text = $"{selectedMatch.Team2.TeamName}";
            lblScore1.Text = $"{selectedMatch.Score1}";
            lblScore2.Text = $"{selectedMatch.Score2}";
            if (selectedMatch.Score1 > selectedMatch.Score2)
            {
                pbTeam1.Visible = true;
                pbTeam2.Visible = false;
            }
            else if (selectedMatch.Score1 < selectedMatch.Score2)
            {
                pbTeam1.Visible = false;
                pbTeam2.Visible = true;
            }
            else
            {
                pbTeam1.Visible = false;
                pbTeam2.Visible = false;
            }
        }
        private void ListMatches()
        {
            #region Datagridview Settings
            dgvMatches.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            dgvMatches.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvMatches.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 208, 120);
            dgvMatches.EnableHeadersVisualStyles = false;
            dgvMatches.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
            dgvMatches.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvMatches.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            #endregion
            dgvMatches.DataSource = null;
            dgvMatches.DataSource = db.Matches.Select(x => new
            {
                MatchId = x.Id,
                Time = x.MatchTime,
                Match = x.Team1.TeamName + "-" + x.Team2.TeamName,
                Score = x.Score1 + "-" + x.Score2,
                Result = x.Result == null ? "Result is not known yet" : x.Result.ToString()
            }).OrderBy(x => x.MatchId).ToList();
        }
        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            MatchForm matchForm = new MatchForm(db);
            matchForm.ShowDialog();
            ListMatches();
        }
        private void btnEditSelectedMatch_Click(object sender, EventArgs e)
        {
            int selectedMatchId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match selectedMatch = db.Matches.FirstOrDefault(x => x.Id == selectedMatchId);
            MatchForm matchForm = new MatchForm(db, selectedMatch);
            matchForm.ShowDialog();
            ListMatches();
        }
        private void btnDeleteSelectedMatch_Click(object sender, EventArgs e)
        {
            int selectedMatchId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match selectedMatch = db.Matches.ToList().FirstOrDefault(x => x.Id == selectedMatchId);
            db.Matches.Remove(selectedMatch);
            db.SaveChanges();
            ListMatches();
        }
        private void chkHideMatches_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideMatches.Checked == true)
            {
                dgvMatches.DataSource = null;
                dgvMatches.DataSource = db.Matches.Where(x => x.Result != null).Select(x => new
                {
                    MatchId = x.Id,
                    Time = x.MatchTime,
                    Match = x.Team1.TeamName + "-" + x.Team2.TeamName,
                    Score = x.Score1 + "-" + x.Score2,
                    Result = x.Result == null ? "Result is not known yet" : x.Result.ToString()
                }).OrderBy(x => x.MatchId).ToList();
            }
            else
                ListMatches();
        }
        private void dgvMatches_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedMatchId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match selectedMatch = db.Matches.FirstOrDefault(x => x.Id == selectedMatchId);
            lblScore1.Text = $"{selectedMatch.Score1.ToString()}";
            lblScore2.Text = $"{selectedMatch.Score2.ToString()}";
            lblTeam1.Text = selectedMatch.Team1.TeamName.ToString();
            lblTeam2.Text = selectedMatch.Team2.TeamName.ToString();
            if (selectedMatch.Score1 > selectedMatch.Score2)
            {
                pbTeam1.Visible = true;
                pbTeam2.Visible = false;
            }
            else if (selectedMatch.Score1 < selectedMatch.Score2)
            {
                pbTeam1.Visible = false;
                pbTeam2.Visible = true;
            }
            else
            {
                pbTeam1.Visible = false;
                pbTeam2.Visible = false;
            }
        }
        #endregion

    }
}


