namespace KatarzynaKrawczykLab2ZadDom
{
    partial class StartWindow
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.textBoxCharacterName = new System.Windows.Forms.TextBox();
            this.buttonAboutBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(44, 82);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(200, 17);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Type name and select a class.";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(107, 151);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Start!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStart);
            // 
            // textBoxCharacterName
            // 
            this.textBoxCharacterName.Location = new System.Drawing.Point(46, 123);
            this.textBoxCharacterName.MaxLength = 20;
            this.textBoxCharacterName.Name = "textBoxCharacterName";
            this.textBoxCharacterName.Size = new System.Drawing.Size(197, 22);
            this.textBoxCharacterName.TabIndex = 2;
            this.textBoxCharacterName.Text = "Cookie";
            this.textBoxCharacterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAboutBox
            // 
            this.buttonAboutBox.Location = new System.Drawing.Point(95, 180);
            this.buttonAboutBox.Name = "buttonAboutBox";
            this.buttonAboutBox.Size = new System.Drawing.Size(98, 27);
            this.buttonAboutBox.TabIndex = 3;
            this.buttonAboutBox.Text = "AboutBox";
            this.buttonAboutBox.UseVisualStyleBackColor = true;
            this.buttonAboutBox.Click += new System.EventHandler(this.buttonAboutBox_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonAboutBox);
            this.Controls.Add(this.textBoxCharacterName);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelInstruction);
            this.Name = "StartWindow";
            this.Text = "Fight the bad guys - menu. ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.TextBox textBoxCharacterName;
        private System.Windows.Forms.Button buttonAboutBox;
    }
}

