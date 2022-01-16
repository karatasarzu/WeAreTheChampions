
namespace WeAreTheChampions
{
    partial class MatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchForm));
            this.cmbTeam2 = new System.Windows.Forms.ComboBox();
            this.cmbTeam1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMatchAdd = new System.Windows.Forms.Button();
            this.btnMatchCancel = new System.Windows.Forms.Button();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.btnMatchSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTeam2
            // 
            this.cmbTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTeam2.BackColor = System.Drawing.Color.White;
            this.cmbTeam2.DisplayMember = "TeamName";
            this.cmbTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam2.FormattingEnabled = true;
            this.cmbTeam2.Location = new System.Drawing.Point(771, 154);
            this.cmbTeam2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTeam2.Name = "cmbTeam2";
            this.cmbTeam2.Size = new System.Drawing.Size(159, 21);
            this.cmbTeam2.TabIndex = 19;
            this.cmbTeam2.ValueMember = "Id";
            // 
            // cmbTeam1
            // 
            this.cmbTeam1.BackColor = System.Drawing.Color.White;
            this.cmbTeam1.DisplayMember = "TeamName";
            this.cmbTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam1.FormattingEnabled = true;
            this.cmbTeam1.Location = new System.Drawing.Point(37, 154);
            this.cmbTeam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTeam1.Name = "cmbTeam1";
            this.cmbTeam1.Size = new System.Drawing.Size(159, 21);
            this.cmbTeam1.TabIndex = 18;
            this.cmbTeam1.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Match Time";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(895, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Score";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(887, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Team 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Team 1";
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpMatchTime.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtpMatchTime.Location = new System.Drawing.Point(384, 60);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(200, 20);
            this.dtpMatchTime.TabIndex = 30;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WeAreTheChampions.Properties.Resources.vs5;
            this.pictureBox3.Location = new System.Drawing.Point(410, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 148);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WeAreTheChampions.Properties.Resources.Right;
            this.pictureBox2.Location = new System.Drawing.Point(480, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(543, 560);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeAreTheChampions.Properties.Resources.Left;
            this.pictureBox1.Location = new System.Drawing.Point(-53, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnMatchAdd
            // 
            this.btnMatchAdd.Location = new System.Drawing.Point(436, 484);
            this.btnMatchAdd.Name = "btnMatchAdd";
            this.btnMatchAdd.Size = new System.Drawing.Size(86, 23);
            this.btnMatchAdd.TabIndex = 32;
            this.btnMatchAdd.Text = "Add";
            this.btnMatchAdd.UseVisualStyleBackColor = true;
            this.btnMatchAdd.Click += new System.EventHandler(this.btnMatchAdd_Click);
            // 
            // btnMatchCancel
            // 
            this.btnMatchCancel.Location = new System.Drawing.Point(528, 484);
            this.btnMatchCancel.Name = "btnMatchCancel";
            this.btnMatchCancel.Size = new System.Drawing.Size(86, 23);
            this.btnMatchCancel.TabIndex = 33;
            this.btnMatchCancel.Text = "Cancel";
            this.btnMatchCancel.UseVisualStyleBackColor = true;
            this.btnMatchCancel.Click += new System.EventHandler(this.btnMatchCancel_Click);
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(37, 201);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(89, 20);
            this.txtScore1.TabIndex = 34;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(841, 201);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(89, 20);
            this.txtScore2.TabIndex = 35;
            // 
            // btnMatchSave
            // 
            this.btnMatchSave.Location = new System.Drawing.Point(344, 484);
            this.btnMatchSave.Name = "btnMatchSave";
            this.btnMatchSave.Size = new System.Drawing.Size(86, 23);
            this.btnMatchSave.TabIndex = 36;
            this.btnMatchSave.Text = "Save";
            this.btnMatchSave.UseVisualStyleBackColor = true;
            this.btnMatchSave.Visible = false;
            this.btnMatchSave.Click += new System.EventHandler(this.btnMatchSave_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 519);
            this.Controls.Add(this.btnMatchSave);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.btnMatchCancel);
            this.Controls.Add(this.btnMatchAdd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dtpMatchTime);
            this.Controls.Add(this.cmbTeam2);
            this.Controls.Add(this.cmbTeam1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTeam2;
        private System.Windows.Forms.ComboBox cmbTeam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMatchAdd;
        private System.Windows.Forms.Button btnMatchCancel;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Button btnMatchSave;
    }
}