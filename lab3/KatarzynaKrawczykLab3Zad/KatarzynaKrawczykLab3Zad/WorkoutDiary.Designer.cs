namespace KatarzynaKrawczykLab3Zad
{
    partial class WorkoutDiary
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
            this.dataGridViewWorkoutDiary = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkoutTable = new System.Windows.Forms.DataGridView();
            this.buttonAddToDiary = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonChangeDate = new System.Windows.Forms.Button();
            this.textBoxWorkoutName = new System.Windows.Forms.TextBox();
            this.textBoxWorkoutTime = new System.Windows.Forms.TextBox();
            this.textBoxWorkoutKcal = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelKcal = new System.Windows.Forms.Label();
            this.buttonAddNewWorkout = new System.Windows.Forms.Button();
            this.buttonDeleteWorkot = new System.Windows.Forms.Button();
            this.buttonDeleteFromDiary = new System.Windows.Forms.Button();
            this.labelArrow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkoutDiary
            // 
            this.dataGridViewWorkoutDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkoutDiary.Location = new System.Drawing.Point(27, 114);
            this.dataGridViewWorkoutDiary.Name = "dataGridViewWorkoutDiary";
            this.dataGridViewWorkoutDiary.RowTemplate.Height = 24;
            this.dataGridViewWorkoutDiary.Size = new System.Drawing.Size(203, 319);
            this.dataGridViewWorkoutDiary.TabIndex = 0;
            // 
            // dataGridViewWorkoutTable
            // 
            this.dataGridViewWorkoutTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkoutTable.Location = new System.Drawing.Point(401, 114);
            this.dataGridViewWorkoutTable.Name = "dataGridViewWorkoutTable";
            this.dataGridViewWorkoutTable.RowTemplate.Height = 24;
            this.dataGridViewWorkoutTable.Size = new System.Drawing.Size(307, 319);
            this.dataGridViewWorkoutTable.TabIndex = 1;
            // 
            // buttonAddToDiary
            // 
            this.buttonAddToDiary.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAddToDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToDiary.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToDiary.ForeColor = System.Drawing.Color.White;
            this.buttonAddToDiary.Location = new System.Drawing.Point(236, 114);
            this.buttonAddToDiary.Name = "buttonAddToDiary";
            this.buttonAddToDiary.Size = new System.Drawing.Size(159, 36);
            this.buttonAddToDiary.TabIndex = 2;
            this.buttonAddToDiary.Text = "Ad to diary";
            this.buttonAddToDiary.UseVisualStyleBackColor = false;
            this.buttonAddToDiary.Click += new System.EventHandler(this.buttonAddToDiary_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(27, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(203, 22);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // buttonChangeDate
            // 
            this.buttonChangeDate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeDate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeDate.ForeColor = System.Drawing.Color.White;
            this.buttonChangeDate.Location = new System.Drawing.Point(27, 76);
            this.buttonChangeDate.Name = "buttonChangeDate";
            this.buttonChangeDate.Size = new System.Drawing.Size(203, 36);
            this.buttonChangeDate.TabIndex = 4;
            this.buttonChangeDate.Text = "Change Date";
            this.buttonChangeDate.UseVisualStyleBackColor = false;
            this.buttonChangeDate.Click += new System.EventHandler(this.buttonChangeDate_Click);
            // 
            // textBoxWorkoutName
            // 
            this.textBoxWorkoutName.Location = new System.Drawing.Point(441, 25);
            this.textBoxWorkoutName.MaxLength = 20;
            this.textBoxWorkoutName.Name = "textBoxWorkoutName";
            this.textBoxWorkoutName.Size = new System.Drawing.Size(128, 22);
            this.textBoxWorkoutName.TabIndex = 5;
            // 
            // textBoxWorkoutTime
            // 
            this.textBoxWorkoutTime.Location = new System.Drawing.Point(443, 57);
            this.textBoxWorkoutTime.MaxLength = 5;
            this.textBoxWorkoutTime.Name = "textBoxWorkoutTime";
            this.textBoxWorkoutTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxWorkoutTime.TabIndex = 6;
            // 
            // textBoxWorkoutKcal
            // 
            this.textBoxWorkoutKcal.Location = new System.Drawing.Point(443, 85);
            this.textBoxWorkoutKcal.MaxLength = 5;
            this.textBoxWorkoutKcal.Name = "textBoxWorkoutKcal";
            this.textBoxWorkoutKcal.Size = new System.Drawing.Size(100, 22);
            this.textBoxWorkoutKcal.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(388, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(394, 60);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 17);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Time:";
            // 
            // labelKcal
            // 
            this.labelKcal.AutoSize = true;
            this.labelKcal.ForeColor = System.Drawing.Color.Black;
            this.labelKcal.Location = new System.Drawing.Point(398, 88);
            this.labelKcal.Name = "labelKcal";
            this.labelKcal.Size = new System.Drawing.Size(39, 17);
            this.labelKcal.TabIndex = 10;
            this.labelKcal.Text = "Kcal:";
            // 
            // buttonAddNewWorkout
            // 
            this.buttonAddNewWorkout.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAddNewWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewWorkout.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewWorkout.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewWorkout.Location = new System.Drawing.Point(575, 25);
            this.buttonAddNewWorkout.Name = "buttonAddNewWorkout";
            this.buttonAddNewWorkout.Size = new System.Drawing.Size(133, 36);
            this.buttonAddNewWorkout.TabIndex = 11;
            this.buttonAddNewWorkout.Text = "Add New Workout";
            this.buttonAddNewWorkout.UseVisualStyleBackColor = false;
            this.buttonAddNewWorkout.Click += new System.EventHandler(this.buttonAddNewWorkout_Click);
            // 
            // buttonDeleteWorkot
            // 
            this.buttonDeleteWorkot.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDeleteWorkot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteWorkot.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteWorkot.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteWorkot.Location = new System.Drawing.Point(575, 64);
            this.buttonDeleteWorkot.Name = "buttonDeleteWorkot";
            this.buttonDeleteWorkot.Size = new System.Drawing.Size(133, 44);
            this.buttonDeleteWorkot.TabIndex = 12;
            this.buttonDeleteWorkot.Text = "Delete from Database";
            this.buttonDeleteWorkot.UseVisualStyleBackColor = false;
            this.buttonDeleteWorkot.Click += new System.EventHandler(this.buttonDeleteWorkot_Click);
            // 
            // buttonDeleteFromDiary
            // 
            this.buttonDeleteFromDiary.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDeleteFromDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFromDiary.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteFromDiary.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteFromDiary.Location = new System.Drawing.Point(27, 40);
            this.buttonDeleteFromDiary.Name = "buttonDeleteFromDiary";
            this.buttonDeleteFromDiary.Size = new System.Drawing.Size(203, 36);
            this.buttonDeleteFromDiary.TabIndex = 13;
            this.buttonDeleteFromDiary.Text = "Delete From Diary";
            this.buttonDeleteFromDiary.UseVisualStyleBackColor = false;
            this.buttonDeleteFromDiary.Click += new System.EventHandler(this.buttonDeleteFromDiary_Click);
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.ForeColor = System.Drawing.Color.Black;
            this.labelArrow.Location = new System.Drawing.Point(288, 153);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(41, 17);
            this.labelArrow.TabIndex = 14;
            this.labelArrow.Text = "<-----";
            // 
            // WorkoutDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 468);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.buttonDeleteFromDiary);
            this.Controls.Add(this.buttonDeleteWorkot);
            this.Controls.Add(this.buttonAddNewWorkout);
            this.Controls.Add(this.labelKcal);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxWorkoutKcal);
            this.Controls.Add(this.textBoxWorkoutTime);
            this.Controls.Add(this.textBoxWorkoutName);
            this.Controls.Add(this.buttonChangeDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonAddToDiary);
            this.Controls.Add(this.dataGridViewWorkoutTable);
            this.Controls.Add(this.dataGridViewWorkoutDiary);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "WorkoutDiary";
            this.Text = "WorkoutDiary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorkoutDiary;
        private System.Windows.Forms.DataGridView dataGridViewWorkoutTable;
        private System.Windows.Forms.Button buttonAddToDiary;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonChangeDate;
        private System.Windows.Forms.TextBox textBoxWorkoutName;
        private System.Windows.Forms.TextBox textBoxWorkoutTime;
        private System.Windows.Forms.TextBox textBoxWorkoutKcal;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelKcal;
        private System.Windows.Forms.Button buttonAddNewWorkout;
        private System.Windows.Forms.Button buttonDeleteWorkot;
        private System.Windows.Forms.Button buttonDeleteFromDiary;
        private System.Windows.Forms.Label labelArrow;
    }
}