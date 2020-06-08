namespace KatarzynaKrawczykLab3Zad
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonAddMealOrIngredient = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddWeight = new System.Windows.Forms.Button();
            this.buttonAddTodaysMeals = new System.Windows.Forms.Button();
            this.buttonAddExercises = new System.Windows.Forms.Button();
            this.buttonSeeDiary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddMealOrIngredient
            // 
            this.buttonAddMealOrIngredient.BackColor = System.Drawing.Color.Plum;
            this.buttonAddMealOrIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMealOrIngredient.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddMealOrIngredient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddMealOrIngredient.Location = new System.Drawing.Point(227, 394);
            this.buttonAddMealOrIngredient.Name = "buttonAddMealOrIngredient";
            this.buttonAddMealOrIngredient.Size = new System.Drawing.Size(202, 59);
            this.buttonAddMealOrIngredient.TabIndex = 0;
            this.buttonAddMealOrIngredient.Text = "Add meal or ingredient to database";
            this.buttonAddMealOrIngredient.UseVisualStyleBackColor = false;
            this.buttonAddMealOrIngredient.Click += new System.EventHandler(this.buttonAddMeal_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWelcome.Location = new System.Drawing.Point(205, 50);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(277, 33);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome to FitApp!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddWeight
            // 
            this.buttonAddWeight.BackColor = System.Drawing.Color.Gold;
            this.buttonAddWeight.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWeight.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddWeight.ForeColor = System.Drawing.Color.Snow;
            this.buttonAddWeight.Location = new System.Drawing.Point(227, 262);
            this.buttonAddWeight.Name = "buttonAddWeight";
            this.buttonAddWeight.Size = new System.Drawing.Size(202, 38);
            this.buttonAddWeight.TabIndex = 3;
            this.buttonAddWeight.Text = "Add Weight";
            this.buttonAddWeight.UseVisualStyleBackColor = false;
            this.buttonAddWeight.Click += new System.EventHandler(this.buttonAddWeight_Click);
            // 
            // buttonAddTodaysMeals
            // 
            this.buttonAddTodaysMeals.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddTodaysMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTodaysMeals.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddTodaysMeals.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddTodaysMeals.Location = new System.Drawing.Point(227, 306);
            this.buttonAddTodaysMeals.Name = "buttonAddTodaysMeals";
            this.buttonAddTodaysMeals.Size = new System.Drawing.Size(202, 38);
            this.buttonAddTodaysMeals.TabIndex = 4;
            this.buttonAddTodaysMeals.Text = "Add today\'s meals";
            this.buttonAddTodaysMeals.UseVisualStyleBackColor = false;
            this.buttonAddTodaysMeals.Click += new System.EventHandler(this.buttonAddTodaysMeals_Click);
            // 
            // buttonAddExercises
            // 
            this.buttonAddExercises.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAddExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddExercises.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddExercises.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddExercises.Location = new System.Drawing.Point(227, 350);
            this.buttonAddExercises.Name = "buttonAddExercises";
            this.buttonAddExercises.Size = new System.Drawing.Size(202, 38);
            this.buttonAddExercises.TabIndex = 5;
            this.buttonAddExercises.Text = "Add Exercises";
            this.buttonAddExercises.UseVisualStyleBackColor = false;
            this.buttonAddExercises.Click += new System.EventHandler(this.buttonAddExercises_Click);
            // 
            // buttonSeeDiary
            // 
            this.buttonSeeDiary.BackColor = System.Drawing.Color.Tomato;
            this.buttonSeeDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeDiary.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSeeDiary.ForeColor = System.Drawing.Color.Snow;
            this.buttonSeeDiary.Location = new System.Drawing.Point(227, 218);
            this.buttonSeeDiary.Name = "buttonSeeDiary";
            this.buttonSeeDiary.Size = new System.Drawing.Size(202, 38);
            this.buttonSeeDiary.TabIndex = 6;
            this.buttonSeeDiary.Text = "See your diary";
            this.buttonSeeDiary.UseVisualStyleBackColor = false;
            this.buttonSeeDiary.Click += new System.EventHandler(this.buttonSeeDiary_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 465);
            this.Controls.Add(this.buttonSeeDiary);
            this.Controls.Add(this.buttonAddExercises);
            this.Controls.Add(this.buttonAddTodaysMeals);
            this.Controls.Add(this.buttonAddWeight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAddMealOrIngredient);
            this.Name = "Menu";
            this.Text = "FitApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMealOrIngredient;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddWeight;
        private System.Windows.Forms.Button buttonAddTodaysMeals;
        private System.Windows.Forms.Button buttonAddExercises;
        private System.Windows.Forms.Button buttonSeeDiary;
    }
}

