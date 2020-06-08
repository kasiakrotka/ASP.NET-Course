namespace KatarzynaKrawczykLab3Zad
{
    partial class AddMeal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.textBoxMealName = new System.Windows.Forms.TextBox();
            this.labelMealName = new System.Windows.Forms.Label();
            this.checkBoxVegetarian = new System.Windows.Forms.CheckBox();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.buttonAddMeal = new System.Windows.Forms.Button();
            this.buttonEditMealName = new System.Windows.Forms.Button();
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.labelIngredientName = new System.Windows.Forms.Label();
            this.labelKcal = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.labelCarbs = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxIngredientName = new System.Windows.Forms.TextBox();
            this.textBoxKcal = new System.Windows.Forms.TextBox();
            this.textBoxProetins = new System.Windows.Forms.TextBox();
            this.textBoxFat = new System.Windows.Forms.TextBox();
            this.textBoxCarbs = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeightUnit = new System.Windows.Forms.Label();
            this.labelValueUnit = new System.Windows.Forms.Label();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonEditIngredient = new System.Windows.Forms.Button();
            this.buttonDeleteMeal = new System.Windows.Forms.Button();
            this.buttonDeleteIngredient = new System.Windows.Forms.Button();
            this.dataGridViewIngredientsOfMeal = new System.Windows.Forms.DataGridView();
            this.buttonAddInredientToMeal = new System.Windows.Forms.Button();
            this.labelArrowLeft = new System.Windows.Forms.Label();
            this.labelTotalKcal = new System.Windows.Forms.Label();
            this.labelTotalKcalValue = new System.Windows.Forms.Label();
            this.buttonDeleteIngredientFromMeal = new System.Windows.Forms.Button();
            this.labelArrowRight = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredientsOfMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.AllowUserToAddRows = false;
            this.dataGridViewMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMeals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Location = new System.Drawing.Point(17, 164);
            this.dataGridViewMeals.MultiSelect = false;
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMeals.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMeals.RowTemplate.Height = 24;
            this.dataGridViewMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMeals.Size = new System.Drawing.Size(341, 362);
            this.dataGridViewMeals.TabIndex = 0;
            this.dataGridViewMeals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeals_CellClick);
            // 
            // textBoxMealName
            // 
            this.textBoxMealName.Location = new System.Drawing.Point(75, 38);
            this.textBoxMealName.Name = "textBoxMealName";
            this.textBoxMealName.Size = new System.Drawing.Size(183, 25);
            this.textBoxMealName.TabIndex = 1;
            // 
            // labelMealName
            // 
            this.labelMealName.AutoSize = true;
            this.labelMealName.Location = new System.Drawing.Point(14, 38);
            this.labelMealName.Name = "labelMealName";
            this.labelMealName.Size = new System.Drawing.Size(52, 18);
            this.labelMealName.TabIndex = 2;
            this.labelMealName.Text = "Name:";
            // 
            // checkBoxVegetarian
            // 
            this.checkBoxVegetarian.AutoSize = true;
            this.checkBoxVegetarian.Location = new System.Drawing.Point(17, 70);
            this.checkBoxVegetarian.Name = "checkBoxVegetarian";
            this.checkBoxVegetarian.Size = new System.Drawing.Size(105, 22);
            this.checkBoxVegetarian.TabIndex = 3;
            this.checkBoxVegetarian.Text = "Vegetarian";
            this.checkBoxVegetarian.UseVisualStyleBackColor = true;
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(17, 100);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(73, 22);
            this.checkBoxVegan.TabIndex = 4;
            this.checkBoxVegan.Text = "Vegan";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            // 
            // buttonAddMeal
            // 
            this.buttonAddMeal.BackColor = System.Drawing.Color.Plum;
            this.buttonAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddMeal.Location = new System.Drawing.Point(15, 132);
            this.buttonAddMeal.Name = "buttonAddMeal";
            this.buttonAddMeal.Size = new System.Drawing.Size(115, 26);
            this.buttonAddMeal.TabIndex = 5;
            this.buttonAddMeal.Text = "Add meal";
            this.buttonAddMeal.UseVisualStyleBackColor = false;
            this.buttonAddMeal.Click += new System.EventHandler(this.buttonAddMeal_Click);
            // 
            // buttonEditMealName
            // 
            this.buttonEditMealName.BackColor = System.Drawing.Color.Plum;
            this.buttonEditMealName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMealName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditMealName.Location = new System.Drawing.Point(136, 132);
            this.buttonEditMealName.Name = "buttonEditMealName";
            this.buttonEditMealName.Size = new System.Drawing.Size(115, 26);
            this.buttonEditMealName.TabIndex = 6;
            this.buttonEditMealName.Text = "Edit Name";
            this.buttonEditMealName.UseVisualStyleBackColor = false;
            this.buttonEditMealName.Click += new System.EventHandler(this.buttonEditMealName_Click);
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIngredients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Location = new System.Drawing.Point(840, 164);
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewIngredients.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIngredients.RowTemplate.Height = 24;
            this.dataGridViewIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewIngredients.Size = new System.Drawing.Size(431, 362);
            this.dataGridViewIngredients.TabIndex = 7;
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Location = new System.Drawing.Point(837, 38);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(52, 18);
            this.labelIngredientName.TabIndex = 8;
            this.labelIngredientName.Text = "Name:";
            // 
            // labelKcal
            // 
            this.labelKcal.AutoSize = true;
            this.labelKcal.Location = new System.Drawing.Point(848, 66);
            this.labelKcal.Name = "labelKcal";
            this.labelKcal.Size = new System.Drawing.Size(43, 18);
            this.labelKcal.TabIndex = 9;
            this.labelKcal.Text = "Kcal:";
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Location = new System.Drawing.Point(1102, 96);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(72, 18);
            this.labelProteins.TabIndex = 10;
            this.labelProteins.Text = "Proteins:";
            // 
            // labelFat
            // 
            this.labelFat.AutoSize = true;
            this.labelFat.Location = new System.Drawing.Point(856, 96);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(34, 18);
            this.labelFat.TabIndex = 11;
            this.labelFat.Text = "Fat:";
            // 
            // labelCarbs
            // 
            this.labelCarbs.AutoSize = true;
            this.labelCarbs.Location = new System.Drawing.Point(971, 96);
            this.labelCarbs.Name = "labelCarbs";
            this.labelCarbs.Size = new System.Drawing.Size(54, 18);
            this.labelCarbs.TabIndex = 12;
            this.labelCarbs.Text = "Carbs:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(987, 66);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(61, 18);
            this.labelWeight.TabIndex = 13;
            this.labelWeight.Text = "Weight:";
            // 
            // textBoxIngredientName
            // 
            this.textBoxIngredientName.Location = new System.Drawing.Point(899, 38);
            this.textBoxIngredientName.Name = "textBoxIngredientName";
            this.textBoxIngredientName.Size = new System.Drawing.Size(183, 25);
            this.textBoxIngredientName.TabIndex = 14;
            // 
            // textBoxKcal
            // 
            this.textBoxKcal.Location = new System.Drawing.Point(899, 66);
            this.textBoxKcal.MaxLength = 4;
            this.textBoxKcal.Name = "textBoxKcal";
            this.textBoxKcal.Size = new System.Drawing.Size(80, 25);
            this.textBoxKcal.TabIndex = 15;
            // 
            // textBoxProetins
            // 
            this.textBoxProetins.Location = new System.Drawing.Point(899, 96);
            this.textBoxProetins.MaxLength = 4;
            this.textBoxProetins.Name = "textBoxProetins";
            this.textBoxProetins.Size = new System.Drawing.Size(65, 25);
            this.textBoxProetins.TabIndex = 16;
            // 
            // textBoxFat
            // 
            this.textBoxFat.Location = new System.Drawing.Point(1181, 96);
            this.textBoxFat.MaxLength = 4;
            this.textBoxFat.Name = "textBoxFat";
            this.textBoxFat.Size = new System.Drawing.Size(65, 25);
            this.textBoxFat.TabIndex = 17;
            // 
            // textBoxCarbs
            // 
            this.textBoxCarbs.Location = new System.Drawing.Point(1033, 96);
            this.textBoxCarbs.MaxLength = 4;
            this.textBoxCarbs.Name = "textBoxCarbs";
            this.textBoxCarbs.Size = new System.Drawing.Size(65, 25);
            this.textBoxCarbs.TabIndex = 18;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(1056, 66);
            this.textBoxWeight.MaxLength = 4;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(80, 25);
            this.textBoxWeight.TabIndex = 19;
            // 
            // labelWeightUnit
            // 
            this.labelWeightUnit.AutoSize = true;
            this.labelWeightUnit.Location = new System.Drawing.Point(1145, 66);
            this.labelWeightUnit.Name = "labelWeightUnit";
            this.labelWeightUnit.Size = new System.Drawing.Size(17, 18);
            this.labelWeightUnit.TabIndex = 20;
            this.labelWeightUnit.Text = "g";
            // 
            // labelValueUnit
            // 
            this.labelValueUnit.AutoSize = true;
            this.labelValueUnit.Location = new System.Drawing.Point(1253, 101);
            this.labelValueUnit.Name = "labelValueUnit";
            this.labelValueUnit.Size = new System.Drawing.Size(17, 18);
            this.labelValueUnit.TabIndex = 21;
            this.labelValueUnit.Text = "g";
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.BackColor = System.Drawing.Color.Plum;
            this.buttonAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIngredient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddIngredient.Location = new System.Drawing.Point(840, 132);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(140, 26);
            this.buttonAddIngredient.TabIndex = 22;
            this.buttonAddIngredient.Text = "Add Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = false;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonEditIngredient
            // 
            this.buttonEditIngredient.BackColor = System.Drawing.Color.Plum;
            this.buttonEditIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditIngredient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditIngredient.Location = new System.Drawing.Point(983, 132);
            this.buttonEditIngredient.Name = "buttonEditIngredient";
            this.buttonEditIngredient.Size = new System.Drawing.Size(115, 26);
            this.buttonEditIngredient.TabIndex = 23;
            this.buttonEditIngredient.Text = "Edit Ingredient";
            this.buttonEditIngredient.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteMeal
            // 
            this.buttonDeleteMeal.BackColor = System.Drawing.Color.Plum;
            this.buttonDeleteMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteMeal.Location = new System.Drawing.Point(259, 132);
            this.buttonDeleteMeal.Name = "buttonDeleteMeal";
            this.buttonDeleteMeal.Size = new System.Drawing.Size(99, 26);
            this.buttonDeleteMeal.TabIndex = 24;
            this.buttonDeleteMeal.Text = "Delete";
            this.buttonDeleteMeal.UseVisualStyleBackColor = false;
            this.buttonDeleteMeal.Click += new System.EventHandler(this.buttonDeleteMeal_Click);
            // 
            // buttonDeleteIngredient
            // 
            this.buttonDeleteIngredient.BackColor = System.Drawing.Color.Plum;
            this.buttonDeleteIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteIngredient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteIngredient.Location = new System.Drawing.Point(1105, 132);
            this.buttonDeleteIngredient.Name = "buttonDeleteIngredient";
            this.buttonDeleteIngredient.Size = new System.Drawing.Size(166, 26);
            this.buttonDeleteIngredient.TabIndex = 25;
            this.buttonDeleteIngredient.Text = "Delete";
            this.buttonDeleteIngredient.UseVisualStyleBackColor = false;
            this.buttonDeleteIngredient.Click += new System.EventHandler(this.buttonDeleteIngredient_Click);
            // 
            // dataGridViewIngredientsOfMeal
            // 
            this.dataGridViewIngredientsOfMeal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIngredientsOfMeal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIngredientsOfMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredientsOfMeal.Location = new System.Drawing.Point(364, 164);
            this.dataGridViewIngredientsOfMeal.Name = "dataGridViewIngredientsOfMeal";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewIngredientsOfMeal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewIngredientsOfMeal.RowTemplate.Height = 24;
            this.dataGridViewIngredientsOfMeal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewIngredientsOfMeal.Size = new System.Drawing.Size(243, 362);
            this.dataGridViewIngredientsOfMeal.TabIndex = 26;
            // 
            // buttonAddInredientToMeal
            // 
            this.buttonAddInredientToMeal.BackColor = System.Drawing.Color.Plum;
            this.buttonAddInredientToMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddInredientToMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddInredientToMeal.Location = new System.Drawing.Point(615, 164);
            this.buttonAddInredientToMeal.Name = "buttonAddInredientToMeal";
            this.buttonAddInredientToMeal.Size = new System.Drawing.Size(218, 39);
            this.buttonAddInredientToMeal.TabIndex = 27;
            this.buttonAddInredientToMeal.Text = "Add ingredient to meal";
            this.buttonAddInredientToMeal.UseVisualStyleBackColor = false;
            this.buttonAddInredientToMeal.Click += new System.EventHandler(this.buttonAddInredientToMeal_Click);
            // 
            // labelArrowLeft
            // 
            this.labelArrowLeft.AutoSize = true;
            this.labelArrowLeft.Location = new System.Drawing.Point(706, 207);
            this.labelArrowLeft.Name = "labelArrowLeft";
            this.labelArrowLeft.Size = new System.Drawing.Size(37, 18);
            this.labelArrowLeft.TabIndex = 28;
            this.labelArrowLeft.Text = "<----";
            // 
            // labelTotalKcal
            // 
            this.labelTotalKcal.AutoSize = true;
            this.labelTotalKcal.Location = new System.Drawing.Point(366, 132);
            this.labelTotalKcal.Name = "labelTotalKcal";
            this.labelTotalKcal.Size = new System.Drawing.Size(79, 18);
            this.labelTotalKcal.TabIndex = 29;
            this.labelTotalKcal.Text = "Total kcal:";
            // 
            // labelTotalKcalValue
            // 
            this.labelTotalKcalValue.AutoSize = true;
            this.labelTotalKcalValue.Location = new System.Drawing.Point(454, 132);
            this.labelTotalKcalValue.Name = "labelTotalKcalValue";
            this.labelTotalKcalValue.Size = new System.Drawing.Size(16, 18);
            this.labelTotalKcalValue.TabIndex = 30;
            this.labelTotalKcalValue.Text = "0";
            // 
            // buttonDeleteIngredientFromMeal
            // 
            this.buttonDeleteIngredientFromMeal.BackColor = System.Drawing.Color.Plum;
            this.buttonDeleteIngredientFromMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteIngredientFromMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteIngredientFromMeal.Location = new System.Drawing.Point(614, 230);
            this.buttonDeleteIngredientFromMeal.Name = "buttonDeleteIngredientFromMeal";
            this.buttonDeleteIngredientFromMeal.Size = new System.Drawing.Size(218, 39);
            this.buttonDeleteIngredientFromMeal.TabIndex = 31;
            this.buttonDeleteIngredientFromMeal.Text = "Delete ingredient from meal";
            this.buttonDeleteIngredientFromMeal.UseVisualStyleBackColor = false;
            this.buttonDeleteIngredientFromMeal.Click += new System.EventHandler(this.buttonDeleteIngredientFromMeal_Click);
            // 
            // labelArrowRight
            // 
            this.labelArrowRight.AutoSize = true;
            this.labelArrowRight.Location = new System.Drawing.Point(706, 272);
            this.labelArrowRight.Name = "labelArrowRight";
            this.labelArrowRight.Size = new System.Drawing.Size(37, 18);
            this.labelArrowRight.TabIndex = 32;
            this.labelArrowRight.Text = "---->";
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.Plum;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReload.Location = new System.Drawing.Point(614, 291);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(218, 50);
            this.buttonReload.TabIndex = 33;
            this.buttonReload.Text = "Reload meal table to see kcal values";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 540);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelArrowRight);
            this.Controls.Add(this.buttonDeleteIngredientFromMeal);
            this.Controls.Add(this.labelTotalKcalValue);
            this.Controls.Add(this.labelTotalKcal);
            this.Controls.Add(this.labelArrowLeft);
            this.Controls.Add(this.buttonAddInredientToMeal);
            this.Controls.Add(this.dataGridViewIngredientsOfMeal);
            this.Controls.Add(this.buttonDeleteIngredient);
            this.Controls.Add(this.buttonDeleteMeal);
            this.Controls.Add(this.buttonEditIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.labelValueUnit);
            this.Controls.Add(this.labelWeightUnit);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxCarbs);
            this.Controls.Add(this.textBoxFat);
            this.Controls.Add(this.textBoxProetins);
            this.Controls.Add(this.textBoxKcal);
            this.Controls.Add(this.textBoxIngredientName);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelCarbs);
            this.Controls.Add(this.labelFat);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelKcal);
            this.Controls.Add(this.labelIngredientName);
            this.Controls.Add(this.dataGridViewIngredients);
            this.Controls.Add(this.buttonEditMealName);
            this.Controls.Add(this.buttonAddMeal);
            this.Controls.Add(this.checkBoxVegan);
            this.Controls.Add(this.checkBoxVegetarian);
            this.Controls.Add(this.labelMealName);
            this.Controls.Add(this.textBoxMealName);
            this.Controls.Add(this.dataGridViewMeals);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AddMeal";
            this.Text = "AddMeal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredientsOfMeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.TextBox textBoxMealName;
        private System.Windows.Forms.Label labelMealName;
        private System.Windows.Forms.CheckBox checkBoxVegetarian;
        private System.Windows.Forms.CheckBox checkBoxVegan;
        private System.Windows.Forms.Button buttonAddMeal;
        private System.Windows.Forms.Button buttonEditMealName;
        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.Label labelIngredientName;
        private System.Windows.Forms.Label labelKcal;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelFat;
        private System.Windows.Forms.Label labelCarbs;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxIngredientName;
        private System.Windows.Forms.TextBox textBoxKcal;
        private System.Windows.Forms.TextBox textBoxProetins;
        private System.Windows.Forms.TextBox textBoxFat;
        private System.Windows.Forms.TextBox textBoxCarbs;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeightUnit;
        private System.Windows.Forms.Label labelValueUnit;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button buttonEditIngredient;
        private System.Windows.Forms.Button buttonDeleteMeal;
        private System.Windows.Forms.Button buttonDeleteIngredient;
        private System.Windows.Forms.DataGridView dataGridViewIngredientsOfMeal;
        private System.Windows.Forms.Button buttonAddInredientToMeal;
        private System.Windows.Forms.Label labelArrowLeft;
        private System.Windows.Forms.Label labelTotalKcal;
        private System.Windows.Forms.Label labelTotalKcalValue;
        private System.Windows.Forms.Button buttonDeleteIngredientFromMeal;
        private System.Windows.Forms.Label labelArrowRight;
        private System.Windows.Forms.Button buttonReload;
    }
}