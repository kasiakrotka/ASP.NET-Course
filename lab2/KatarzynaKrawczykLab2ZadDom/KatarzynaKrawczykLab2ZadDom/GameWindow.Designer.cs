namespace KatarzynaKrawczykLab2ZadDom
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.buttonHit = new System.Windows.Forms.Button();
            this.labelStats = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelCritical = new System.Windows.Forms.Label();
            this.labelDodge = new System.Windows.Forms.Label();
            this.progressBarPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.labelPlayerHealthPoints = new System.Windows.Forms.Label();
            this.progressBarEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.labelEnemyHealthPoints = new System.Windows.Forms.Label();
            this.labelEnemyStats = new System.Windows.Forms.Label();
            this.labelEnemyDamage = new System.Windows.Forms.Label();
            this.labelEnemyCritical = new System.Windows.Forms.Label();
            this.labelEnemyDodge = new System.Windows.Forms.Label();
            this.timerTurnPause = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyLabelMove = new System.Windows.Forms.Timer(this.components);
            this.labelEnemyTakenDamage = new System.Windows.Forms.Label();
            this.tableLayoutPanelPlayerStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlayerDamageValue = new System.Windows.Forms.Label();
            this.labelPlayerCriticalValue = new System.Windows.Forms.Label();
            this.labelPlayerDodgeValue = new System.Windows.Forms.Label();
            this.tableLayoutPanelEnemyStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelEnemyCriticalValue = new System.Windows.Forms.Label();
            this.labelEnemyDamageValue = new System.Windows.Forms.Label();
            this.labelEnemyDodgeValue = new System.Windows.Forms.Label();
            this.pictureBoxPlayerPicture = new System.Windows.Forms.PictureBox();
            this.labelEnemyName = new System.Windows.Forms.Label();
            this.labelPlayerTakenDamage = new System.Windows.Forms.Label();
            this.timerPlayerLabelMove = new System.Windows.Forms.Timer(this.components);
            this.timerPlayerLabelMoveTime = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyLabelMoveTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxEnemyPicture = new System.Windows.Forms.PictureBox();
            this.labelKilled = new System.Windows.Forms.Label();
            this.labelKilledValue = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelExperienceValue = new System.Windows.Forms.Label();
            this.buttonNextBattle = new System.Windows.Forms.Button();
            this.tableLayoutPanelPlayerStats.SuspendLayout();
            this.tableLayoutPanelEnemyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacterName.Location = new System.Drawing.Point(100, 85);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(120, 17);
            this.labelCharacterName.TabIndex = 0;
            this.labelCharacterName.Text = "CharacterName";
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(103, 213);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(75, 23);
            this.buttonHit.TabIndex = 1;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Location = new System.Drawing.Point(100, 121);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(44, 17);
            this.labelStats.TabIndex = 2;
            this.labelStats.Text = "Stats:";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Location = new System.Drawing.Point(3, 0);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(41, 17);
            this.labelDamage.TabIndex = 3;
            this.labelDamage.Text = "Dmg:";
            // 
            // labelCritical
            // 
            this.labelCritical.AutoSize = true;
            this.labelCritical.Location = new System.Drawing.Point(3, 22);
            this.labelCritical.Name = "labelCritical";
            this.labelCritical.Size = new System.Drawing.Size(33, 17);
            this.labelCritical.TabIndex = 4;
            this.labelCritical.Text = "Crit:";
            // 
            // labelDodge
            // 
            this.labelDodge.AutoSize = true;
            this.labelDodge.Location = new System.Drawing.Point(3, 44);
            this.labelDodge.Name = "labelDodge";
            this.labelDodge.Size = new System.Drawing.Size(54, 17);
            this.labelDodge.TabIndex = 5;
            this.labelDodge.Text = "Dodge:";
            // 
            // progressBarPlayerHealth
            // 
            this.progressBarPlayerHealth.Location = new System.Drawing.Point(103, 105);
            this.progressBarPlayerHealth.Name = "progressBarPlayerHealth";
            this.progressBarPlayerHealth.Size = new System.Drawing.Size(109, 13);
            this.progressBarPlayerHealth.TabIndex = 6;
            this.progressBarPlayerHealth.Value = 100;
            // 
            // labelPlayerHealthPoints
            // 
            this.labelPlayerHealthPoints.AutoSize = true;
            this.labelPlayerHealthPoints.Location = new System.Drawing.Point(218, 101);
            this.labelPlayerHealthPoints.Name = "labelPlayerHealthPoints";
            this.labelPlayerHealthPoints.Size = new System.Drawing.Size(44, 17);
            this.labelPlayerHealthPoints.TabIndex = 8;
            this.labelPlayerHealthPoints.Text = "100%";
            // 
            // progressBarEnemyHealth
            // 
            this.progressBarEnemyHealth.Location = new System.Drawing.Point(459, 105);
            this.progressBarEnemyHealth.Name = "progressBarEnemyHealth";
            this.progressBarEnemyHealth.Size = new System.Drawing.Size(109, 13);
            this.progressBarEnemyHealth.TabIndex = 9;
            this.progressBarEnemyHealth.Value = 100;
            // 
            // labelEnemyHealthPoints
            // 
            this.labelEnemyHealthPoints.AutoSize = true;
            this.labelEnemyHealthPoints.Location = new System.Drawing.Point(409, 101);
            this.labelEnemyHealthPoints.Name = "labelEnemyHealthPoints";
            this.labelEnemyHealthPoints.Size = new System.Drawing.Size(44, 17);
            this.labelEnemyHealthPoints.TabIndex = 10;
            this.labelEnemyHealthPoints.Text = "100%";
            // 
            // labelEnemyStats
            // 
            this.labelEnemyStats.AutoSize = true;
            this.labelEnemyStats.Location = new System.Drawing.Point(409, 121);
            this.labelEnemyStats.Name = "labelEnemyStats";
            this.labelEnemyStats.Size = new System.Drawing.Size(44, 17);
            this.labelEnemyStats.TabIndex = 11;
            this.labelEnemyStats.Text = "Stats:";
            // 
            // labelEnemyDamage
            // 
            this.labelEnemyDamage.AutoSize = true;
            this.labelEnemyDamage.Location = new System.Drawing.Point(3, 0);
            this.labelEnemyDamage.Name = "labelEnemyDamage";
            this.labelEnemyDamage.Size = new System.Drawing.Size(41, 17);
            this.labelEnemyDamage.TabIndex = 12;
            this.labelEnemyDamage.Text = "Dmg:";
            // 
            // labelEnemyCritical
            // 
            this.labelEnemyCritical.AutoSize = true;
            this.labelEnemyCritical.Location = new System.Drawing.Point(3, 22);
            this.labelEnemyCritical.Name = "labelEnemyCritical";
            this.labelEnemyCritical.Size = new System.Drawing.Size(33, 17);
            this.labelEnemyCritical.TabIndex = 13;
            this.labelEnemyCritical.Text = "Crit:";
            // 
            // labelEnemyDodge
            // 
            this.labelEnemyDodge.AutoSize = true;
            this.labelEnemyDodge.Location = new System.Drawing.Point(3, 44);
            this.labelEnemyDodge.Name = "labelEnemyDodge";
            this.labelEnemyDodge.Size = new System.Drawing.Size(54, 17);
            this.labelEnemyDodge.TabIndex = 14;
            this.labelEnemyDodge.Text = "Dodge:";
            // 
            // timerTurnPause
            // 
            this.timerTurnPause.Interval = 1500;
            this.timerTurnPause.Tick += new System.EventHandler(this.timerTurnPause_Tick);
            // 
            // timerEnemyLabelMove
            // 
            this.timerEnemyLabelMove.Tick += new System.EventHandler(this.timerEnemyLabelMove_Tick);
            // 
            // labelEnemyTakenDamage
            // 
            this.labelEnemyTakenDamage.AutoSize = true;
            this.labelEnemyTakenDamage.Location = new System.Drawing.Point(505, 68);
            this.labelEnemyTakenDamage.Name = "labelEnemyTakenDamage";
            this.labelEnemyTakenDamage.Size = new System.Drawing.Size(16, 17);
            this.labelEnemyTakenDamage.TabIndex = 15;
            this.labelEnemyTakenDamage.Text = "0";
            // 
            // tableLayoutPanelPlayerStats
            // 
            this.tableLayoutPanelPlayerStats.ColumnCount = 2;
            this.tableLayoutPanelPlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelPlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanelPlayerStats.Controls.Add(this.labelCritical, 0, 1);
            this.tableLayoutPanelPlayerStats.Controls.Add(this.labelDamage, 0, 0);
            this.tableLayoutPanelPlayerStats.Controls.Add(this.labelDodge, 0, 2);
            this.tableLayoutPanelPlayerStats.Controls.Add(this.labelPlayerDamageValue, 1, 0);
            this.tableLayoutPanelPlayerStats.Controls.Add(this.labelPlayerCriticalValue, 1, 1);
            this.tableLayoutPanelPlayerStats.Controls.Add(this.labelPlayerDodgeValue, 1, 2);
            this.tableLayoutPanelPlayerStats.Location = new System.Drawing.Point(103, 141);
            this.tableLayoutPanelPlayerStats.Name = "tableLayoutPanelPlayerStats";
            this.tableLayoutPanelPlayerStats.RowCount = 3;
            this.tableLayoutPanelPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelPlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelPlayerStats.Size = new System.Drawing.Size(159, 66);
            this.tableLayoutPanelPlayerStats.TabIndex = 16;
            // 
            // labelPlayerDamageValue
            // 
            this.labelPlayerDamageValue.AutoSize = true;
            this.labelPlayerDamageValue.Location = new System.Drawing.Point(65, 0);
            this.labelPlayerDamageValue.Name = "labelPlayerDamageValue";
            this.labelPlayerDamageValue.Size = new System.Drawing.Size(16, 17);
            this.labelPlayerDamageValue.TabIndex = 6;
            this.labelPlayerDamageValue.Text = "0";
            // 
            // labelPlayerCriticalValue
            // 
            this.labelPlayerCriticalValue.AutoSize = true;
            this.labelPlayerCriticalValue.Location = new System.Drawing.Point(65, 22);
            this.labelPlayerCriticalValue.Name = "labelPlayerCriticalValue";
            this.labelPlayerCriticalValue.Size = new System.Drawing.Size(16, 17);
            this.labelPlayerCriticalValue.TabIndex = 7;
            this.labelPlayerCriticalValue.Text = "0";
            // 
            // labelPlayerDodgeValue
            // 
            this.labelPlayerDodgeValue.AutoSize = true;
            this.labelPlayerDodgeValue.Location = new System.Drawing.Point(65, 44);
            this.labelPlayerDodgeValue.Name = "labelPlayerDodgeValue";
            this.labelPlayerDodgeValue.Size = new System.Drawing.Size(16, 17);
            this.labelPlayerDodgeValue.TabIndex = 8;
            this.labelPlayerDodgeValue.Text = "0";
            // 
            // tableLayoutPanelEnemyStats
            // 
            this.tableLayoutPanelEnemyStats.ColumnCount = 2;
            this.tableLayoutPanelEnemyStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelEnemyStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanelEnemyStats.Controls.Add(this.labelEnemyCriticalValue, 1, 1);
            this.tableLayoutPanelEnemyStats.Controls.Add(this.labelEnemyCritical, 0, 1);
            this.tableLayoutPanelEnemyStats.Controls.Add(this.labelEnemyDodge, 0, 2);
            this.tableLayoutPanelEnemyStats.Controls.Add(this.labelEnemyDamageValue, 1, 0);
            this.tableLayoutPanelEnemyStats.Controls.Add(this.labelEnemyDamage, 0, 0);
            this.tableLayoutPanelEnemyStats.Controls.Add(this.labelEnemyDodgeValue, 1, 2);
            this.tableLayoutPanelEnemyStats.Location = new System.Drawing.Point(412, 141);
            this.tableLayoutPanelEnemyStats.Name = "tableLayoutPanelEnemyStats";
            this.tableLayoutPanelEnemyStats.RowCount = 3;
            this.tableLayoutPanelEnemyStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelEnemyStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelEnemyStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelEnemyStats.Size = new System.Drawing.Size(154, 66);
            this.tableLayoutPanelEnemyStats.TabIndex = 17;
            // 
            // labelEnemyCriticalValue
            // 
            this.labelEnemyCriticalValue.AutoSize = true;
            this.labelEnemyCriticalValue.Location = new System.Drawing.Point(65, 22);
            this.labelEnemyCriticalValue.Name = "labelEnemyCriticalValue";
            this.labelEnemyCriticalValue.Size = new System.Drawing.Size(16, 17);
            this.labelEnemyCriticalValue.TabIndex = 15;
            this.labelEnemyCriticalValue.Text = "0";
            // 
            // labelEnemyDamageValue
            // 
            this.labelEnemyDamageValue.AutoSize = true;
            this.labelEnemyDamageValue.Location = new System.Drawing.Point(65, 0);
            this.labelEnemyDamageValue.Name = "labelEnemyDamageValue";
            this.labelEnemyDamageValue.Size = new System.Drawing.Size(16, 17);
            this.labelEnemyDamageValue.TabIndex = 16;
            this.labelEnemyDamageValue.Text = "0";
            // 
            // labelEnemyDodgeValue
            // 
            this.labelEnemyDodgeValue.AutoSize = true;
            this.labelEnemyDodgeValue.Location = new System.Drawing.Point(65, 44);
            this.labelEnemyDodgeValue.Name = "labelEnemyDodgeValue";
            this.labelEnemyDodgeValue.Size = new System.Drawing.Size(16, 17);
            this.labelEnemyDodgeValue.TabIndex = 17;
            this.labelEnemyDodgeValue.Text = "0";
            // 
            // pictureBoxPlayerPicture
            // 
            this.pictureBoxPlayerPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPlayerPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayerPicture.Image")));
            this.pictureBoxPlayerPicture.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlayerPicture.Name = "pictureBoxPlayerPicture";
            this.pictureBoxPlayerPicture.Size = new System.Drawing.Size(94, 280);
            this.pictureBoxPlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPlayerPicture.TabIndex = 18;
            this.pictureBoxPlayerPicture.TabStop = false;
            // 
            // labelEnemyName
            // 
            this.labelEnemyName.AutoSize = true;
            this.labelEnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnemyName.Location = new System.Drawing.Point(499, 85);
            this.labelEnemyName.Name = "labelEnemyName";
            this.labelEnemyName.Size = new System.Drawing.Size(67, 17);
            this.labelEnemyName.TabIndex = 20;
            this.labelEnemyName.Text = "Bad guy";
            // 
            // labelPlayerTakenDamage
            // 
            this.labelPlayerTakenDamage.AutoSize = true;
            this.labelPlayerTakenDamage.Location = new System.Drawing.Point(149, 68);
            this.labelPlayerTakenDamage.Name = "labelPlayerTakenDamage";
            this.labelPlayerTakenDamage.Size = new System.Drawing.Size(16, 17);
            this.labelPlayerTakenDamage.TabIndex = 21;
            this.labelPlayerTakenDamage.Text = "0";
            // 
            // timerPlayerLabelMove
            // 
            this.timerPlayerLabelMove.Tick += new System.EventHandler(this.timerPlayerLabelMove_Tick);
            // 
            // timerPlayerLabelMoveTime
            // 
            this.timerPlayerLabelMoveTime.Interval = 1500;
            this.timerPlayerLabelMoveTime.Tick += new System.EventHandler(this.timerPlayerLabelMoveTime_Tick);
            // 
            // timerEnemyLabelMoveTime
            // 
            this.timerEnemyLabelMoveTime.Interval = 1500;
            this.timerEnemyLabelMoveTime.Tick += new System.EventHandler(this.timerEnemyLabelMoveTime_Tick);
            // 
            // pictureBoxEnemyPicture
            // 
            this.pictureBoxEnemyPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxEnemyPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyPicture.Image")));
            this.pictureBoxEnemyPicture.Location = new System.Drawing.Point(581, 0);
            this.pictureBoxEnemyPicture.Name = "pictureBoxEnemyPicture";
            this.pictureBoxEnemyPicture.Size = new System.Drawing.Size(88, 280);
            this.pictureBoxEnemyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEnemyPicture.TabIndex = 22;
            this.pictureBoxEnemyPicture.TabStop = false;
            // 
            // labelKilled
            // 
            this.labelKilled.AutoSize = true;
            this.labelKilled.Location = new System.Drawing.Point(278, 9);
            this.labelKilled.Name = "labelKilled";
            this.labelKilled.Size = new System.Drawing.Size(46, 17);
            this.labelKilled.TabIndex = 23;
            this.labelKilled.Text = "Killed:";
            // 
            // labelKilledValue
            // 
            this.labelKilledValue.AutoSize = true;
            this.labelKilledValue.Location = new System.Drawing.Point(331, 9);
            this.labelKilledValue.Name = "labelKilledValue";
            this.labelKilledValue.Size = new System.Drawing.Size(16, 17);
            this.labelKilledValue.TabIndex = 24;
            this.labelKilledValue.Text = "0";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(242, 26);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(82, 17);
            this.labelExperience.TabIndex = 25;
            this.labelExperience.Text = "Experience:";
            // 
            // labelExperienceValue
            // 
            this.labelExperienceValue.AutoSize = true;
            this.labelExperienceValue.Location = new System.Drawing.Point(331, 26);
            this.labelExperienceValue.Name = "labelExperienceValue";
            this.labelExperienceValue.Size = new System.Drawing.Size(16, 17);
            this.labelExperienceValue.TabIndex = 26;
            this.labelExperienceValue.Text = "0";
            // 
            // buttonNextBattle
            // 
            this.buttonNextBattle.Location = new System.Drawing.Point(103, 243);
            this.buttonNextBattle.Name = "buttonNextBattle";
            this.buttonNextBattle.Size = new System.Drawing.Size(109, 23);
            this.buttonNextBattle.TabIndex = 27;
            this.buttonNextBattle.Text = "Next battle";
            this.buttonNextBattle.UseVisualStyleBackColor = true;
            this.buttonNextBattle.Click += new System.EventHandler(this.buttonNextBattle_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 280);
            this.Controls.Add(this.buttonNextBattle);
            this.Controls.Add(this.labelExperienceValue);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelKilledValue);
            this.Controls.Add(this.labelKilled);
            this.Controls.Add(this.pictureBoxEnemyPicture);
            this.Controls.Add(this.labelPlayerTakenDamage);
            this.Controls.Add(this.labelEnemyName);
            this.Controls.Add(this.pictureBoxPlayerPicture);
            this.Controls.Add(this.labelEnemyStats);
            this.Controls.Add(this.tableLayoutPanelEnemyStats);
            this.Controls.Add(this.tableLayoutPanelPlayerStats);
            this.Controls.Add(this.labelEnemyTakenDamage);
            this.Controls.Add(this.labelEnemyHealthPoints);
            this.Controls.Add(this.progressBarEnemyHealth);
            this.Controls.Add(this.labelPlayerHealthPoints);
            this.Controls.Add(this.progressBarPlayerHealth);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.labelCharacterName);
            this.DoubleBuffered = true;
            this.Name = "GameWindow";
            this.Text = "Form1";
            this.tableLayoutPanelPlayerStats.ResumeLayout(false);
            this.tableLayoutPanelPlayerStats.PerformLayout();
            this.tableLayoutPanelEnemyStats.ResumeLayout(false);
            this.tableLayoutPanelEnemyStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelCritical;
        private System.Windows.Forms.Label labelDodge;
        private System.Windows.Forms.ProgressBar progressBarPlayerHealth;
        private System.Windows.Forms.Label labelPlayerHealthPoints;
        private System.Windows.Forms.ProgressBar progressBarEnemyHealth;
        private System.Windows.Forms.Label labelEnemyHealthPoints;
        private System.Windows.Forms.Label labelEnemyStats;
        private System.Windows.Forms.Label labelEnemyDamage;
        private System.Windows.Forms.Label labelEnemyCritical;
        private System.Windows.Forms.Label labelEnemyDodge;
        private System.Windows.Forms.Timer timerTurnPause;
        private System.Windows.Forms.Timer timerEnemyLabelMove;
        private System.Windows.Forms.Label labelEnemyTakenDamage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayerStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEnemyStats;
        private System.Windows.Forms.PictureBox pictureBoxPlayerPicture;
        private System.Windows.Forms.Label labelPlayerDamageValue;
        private System.Windows.Forms.Label labelPlayerCriticalValue;
        private System.Windows.Forms.Label labelPlayerDodgeValue;
        private System.Windows.Forms.Label labelEnemyCriticalValue;
        private System.Windows.Forms.Label labelEnemyDamageValue;
        private System.Windows.Forms.Label labelEnemyDodgeValue;
        private System.Windows.Forms.Label labelEnemyName;
        private System.Windows.Forms.Label labelPlayerTakenDamage;
        private System.Windows.Forms.Timer timerPlayerLabelMove;
        private System.Windows.Forms.Timer timerPlayerLabelMoveTime;
        private System.Windows.Forms.Timer timerEnemyLabelMoveTime;
        private System.Windows.Forms.PictureBox pictureBoxEnemyPicture;
        private System.Windows.Forms.Label labelKilled;
        private System.Windows.Forms.Label labelKilledValue;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelExperienceValue;
        private System.Windows.Forms.Button buttonNextBattle;
    }
}