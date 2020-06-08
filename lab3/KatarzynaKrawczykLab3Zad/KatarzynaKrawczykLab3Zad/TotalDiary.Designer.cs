namespace KatarzynaKrawczykLab3Zad
{
    partial class TotalDiary
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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkout = new System.Windows.Forms.DataGridView();
            this.labelKcalEaten = new System.Windows.Forms.Label();
            this.labelKcalBurned = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelKcalEatenVal = new System.Windows.Forms.Label();
            this.labelKcalBurnedVal = new System.Windows.Forms.Label();
            this.labelKcalTotalVal = new System.Windows.Forms.Label();
            this.buttonChangeDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkout)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(26, 31);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Location = new System.Drawing.Point(26, 70);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.RowTemplate.Height = 24;
            this.dataGridViewMeals.Size = new System.Drawing.Size(240, 387);
            this.dataGridViewMeals.TabIndex = 1;
            // 
            // dataGridViewWorkout
            // 
            this.dataGridViewWorkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkout.Location = new System.Drawing.Point(289, 70);
            this.dataGridViewWorkout.Name = "dataGridViewWorkout";
            this.dataGridViewWorkout.RowTemplate.Height = 24;
            this.dataGridViewWorkout.Size = new System.Drawing.Size(240, 387);
            this.dataGridViewWorkout.TabIndex = 2;
            // 
            // labelKcalEaten
            // 
            this.labelKcalEaten.AutoSize = true;
            this.labelKcalEaten.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKcalEaten.ForeColor = System.Drawing.Color.Tomato;
            this.labelKcalEaten.Location = new System.Drawing.Point(548, 70);
            this.labelKcalEaten.Name = "labelKcalEaten";
            this.labelKcalEaten.Size = new System.Drawing.Size(97, 19);
            this.labelKcalEaten.TabIndex = 3;
            this.labelKcalEaten.Text = "Kcal eaten:";
            // 
            // labelKcalBurned
            // 
            this.labelKcalBurned.AutoSize = true;
            this.labelKcalBurned.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKcalBurned.ForeColor = System.Drawing.Color.Tomato;
            this.labelKcalBurned.Location = new System.Drawing.Point(548, 89);
            this.labelKcalBurned.Name = "labelKcalBurned";
            this.labelKcalBurned.Size = new System.Drawing.Size(110, 19);
            this.labelKcalBurned.TabIndex = 4;
            this.labelKcalBurned.Text = "Kcal burned:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.ForeColor = System.Drawing.Color.Tomato;
            this.labelTotal.Location = new System.Drawing.Point(548, 108);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(53, 19);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelKcalEatenVal
            // 
            this.labelKcalEatenVal.AutoSize = true;
            this.labelKcalEatenVal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKcalEatenVal.ForeColor = System.Drawing.Color.Tomato;
            this.labelKcalEatenVal.Location = new System.Drawing.Point(682, 70);
            this.labelKcalEatenVal.Name = "labelKcalEatenVal";
            this.labelKcalEatenVal.Size = new System.Drawing.Size(18, 19);
            this.labelKcalEatenVal.TabIndex = 6;
            this.labelKcalEatenVal.Text = "0";
            // 
            // labelKcalBurnedVal
            // 
            this.labelKcalBurnedVal.AutoSize = true;
            this.labelKcalBurnedVal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKcalBurnedVal.ForeColor = System.Drawing.Color.Tomato;
            this.labelKcalBurnedVal.Location = new System.Drawing.Point(682, 89);
            this.labelKcalBurnedVal.Name = "labelKcalBurnedVal";
            this.labelKcalBurnedVal.Size = new System.Drawing.Size(18, 19);
            this.labelKcalBurnedVal.TabIndex = 7;
            this.labelKcalBurnedVal.Text = "0";
            // 
            // labelKcalTotalVal
            // 
            this.labelKcalTotalVal.AutoSize = true;
            this.labelKcalTotalVal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKcalTotalVal.ForeColor = System.Drawing.Color.Tomato;
            this.labelKcalTotalVal.Location = new System.Drawing.Point(682, 108);
            this.labelKcalTotalVal.Name = "labelKcalTotalVal";
            this.labelKcalTotalVal.Size = new System.Drawing.Size(18, 19);
            this.labelKcalTotalVal.TabIndex = 8;
            this.labelKcalTotalVal.Text = "0";
            // 
            // buttonChangeDate
            // 
            this.buttonChangeDate.BackColor = System.Drawing.Color.Tomato;
            this.buttonChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeDate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonChangeDate.Location = new System.Drawing.Point(272, 29);
            this.buttonChangeDate.Name = "buttonChangeDate";
            this.buttonChangeDate.Size = new System.Drawing.Size(75, 29);
            this.buttonChangeDate.TabIndex = 9;
            this.buttonChangeDate.Text = "Change Date";
            this.buttonChangeDate.UseVisualStyleBackColor = false;
            this.buttonChangeDate.Click += new System.EventHandler(this.buttonChangeDate_Click);
            // 
            // TotalDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 506);
            this.Controls.Add(this.buttonChangeDate);
            this.Controls.Add(this.labelKcalTotalVal);
            this.Controls.Add(this.labelKcalBurnedVal);
            this.Controls.Add(this.labelKcalEatenVal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelKcalBurned);
            this.Controls.Add(this.labelKcalEaten);
            this.Controls.Add(this.dataGridViewWorkout);
            this.Controls.Add(this.dataGridViewMeals);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "TotalDiary";
            this.Text = "TotalDiary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.DataGridView dataGridViewWorkout;
        private System.Windows.Forms.Label labelKcalEaten;
        private System.Windows.Forms.Label labelKcalBurned;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelKcalEatenVal;
        private System.Windows.Forms.Label labelKcalBurnedVal;
        private System.Windows.Forms.Label labelKcalTotalVal;
        private System.Windows.Forms.Button buttonChangeDate;
    }
}