namespace KatarzynaKrawczykLab3Zad
{
    partial class EditDiary
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
            this.dataGridViewDiary = new System.Windows.Forms.DataGridView();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.checkBoxVegetarian = new System.Windows.Forms.CheckBox();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.labelMealName = new System.Windows.Forms.Label();
            this.textBoxMealName = new System.Windows.Forms.TextBox();
            this.buttonAddToDiary = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChangeDate = new System.Windows.Forms.Button();
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.buttonEditMealsAndIngredients = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDiary
            // 
            this.dataGridViewDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiary.Location = new System.Drawing.Point(24, 98);
            this.dataGridViewDiary.MultiSelect = false;
            this.dataGridViewDiary.Name = "dataGridViewDiary";
            this.dataGridViewDiary.RowTemplate.Height = 24;
            this.dataGridViewDiary.Size = new System.Drawing.Size(271, 350);
            this.dataGridViewDiary.TabIndex = 0;
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Location = new System.Drawing.Point(324, 98);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.RowTemplate.Height = 24;
            this.dataGridViewMeals.Size = new System.Drawing.Size(252, 350);
            this.dataGridViewMeals.TabIndex = 1;
            this.dataGridViewMeals.SelectionChanged += new System.EventHandler(this.dataGridViewMeals_SelectionChanged);
            // 
            // checkBoxVegetarian
            // 
            this.checkBoxVegetarian.AutoSize = true;
            this.checkBoxVegetarian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxVegetarian.Location = new System.Drawing.Point(593, 25);
            this.checkBoxVegetarian.Name = "checkBoxVegetarian";
            this.checkBoxVegetarian.Size = new System.Drawing.Size(99, 21);
            this.checkBoxVegetarian.TabIndex = 2;
            this.checkBoxVegetarian.Text = "Vegetarian";
            this.checkBoxVegetarian.UseVisualStyleBackColor = false;
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxVegan.Location = new System.Drawing.Point(698, 25);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(71, 21);
            this.checkBoxVegan.TabIndex = 3;
            this.checkBoxVegan.Text = "Vegan";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            // 
            // labelMealName
            // 
            this.labelMealName.AutoSize = true;
            this.labelMealName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMealName.Location = new System.Drawing.Point(593, 61);
            this.labelMealName.Name = "labelMealName";
            this.labelMealName.Size = new System.Drawing.Size(49, 17);
            this.labelMealName.TabIndex = 5;
            this.labelMealName.Text = "Name:";
            // 
            // textBoxMealName
            // 
            this.textBoxMealName.Location = new System.Drawing.Point(648, 60);
            this.textBoxMealName.Name = "textBoxMealName";
            this.textBoxMealName.Size = new System.Drawing.Size(163, 22);
            this.textBoxMealName.TabIndex = 4;
            // 
            // buttonAddToDiary
            // 
            this.buttonAddToDiary.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddToDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToDiary.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToDiary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddToDiary.Location = new System.Drawing.Point(324, 61);
            this.buttonAddToDiary.Name = "buttonAddToDiary";
            this.buttonAddToDiary.Size = new System.Drawing.Size(252, 31);
            this.buttonAddToDiary.TabIndex = 6;
            this.buttonAddToDiary.Text = "Add selected meal";
            this.buttonAddToDiary.UseVisualStyleBackColor = false;
            this.buttonAddToDiary.Click += new System.EventHandler(this.buttonAddToDiary_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(24, 29);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(271, 22);
            this.dateTimePickerDate.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(24, 57);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(161, 31);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete Selected Meal";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChangeDate
            // 
            this.buttonChangeDate.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeDate.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeDate.Location = new System.Drawing.Point(191, 57);
            this.buttonChangeDate.Name = "buttonChangeDate";
            this.buttonChangeDate.Size = new System.Drawing.Size(104, 31);
            this.buttonChangeDate.TabIndex = 9;
            this.buttonChangeDate.Text = "Change Date";
            this.buttonChangeDate.UseVisualStyleBackColor = false;
            this.buttonChangeDate.Click += new System.EventHandler(this.buttonChangeDate_Click);
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Location = new System.Drawing.Point(582, 98);
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            this.dataGridViewIngredients.RowTemplate.Height = 24;
            this.dataGridViewIngredients.Size = new System.Drawing.Size(329, 310);
            this.dataGridViewIngredients.TabIndex = 10;
            // 
            // buttonEditMealsAndIngredients
            // 
            this.buttonEditMealsAndIngredients.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditMealsAndIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMealsAndIngredients.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditMealsAndIngredients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditMealsAndIngredients.Location = new System.Drawing.Point(582, 414);
            this.buttonEditMealsAndIngredients.Name = "buttonEditMealsAndIngredients";
            this.buttonEditMealsAndIngredients.Size = new System.Drawing.Size(329, 30);
            this.buttonEditMealsAndIngredients.TabIndex = 11;
            this.buttonEditMealsAndIngredients.Text = "Edit meals and ingredients";
            this.buttonEditMealsAndIngredients.UseVisualStyleBackColor = false;
            this.buttonEditMealsAndIngredients.Click += new System.EventHandler(this.buttonEditMealsAndIngredients_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(324, 25);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(252, 31);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // EditDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 478);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonEditMealsAndIngredients);
            this.Controls.Add(this.dataGridViewIngredients);
            this.Controls.Add(this.buttonChangeDate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonAddToDiary);
            this.Controls.Add(this.labelMealName);
            this.Controls.Add(this.textBoxMealName);
            this.Controls.Add(this.checkBoxVegan);
            this.Controls.Add(this.checkBoxVegetarian);
            this.Controls.Add(this.dataGridViewMeals);
            this.Controls.Add(this.dataGridViewDiary);
            this.Name = "EditDiary";
            this.Text = "EditDiary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDiary;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.CheckBox checkBoxVegetarian;
        private System.Windows.Forms.CheckBox checkBoxVegan;
        private System.Windows.Forms.Label labelMealName;
        private System.Windows.Forms.TextBox textBoxMealName;
        private System.Windows.Forms.Button buttonAddToDiary;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChangeDate;
        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.Button buttonEditMealsAndIngredients;
        private System.Windows.Forms.Button buttonSearch;
    }
}