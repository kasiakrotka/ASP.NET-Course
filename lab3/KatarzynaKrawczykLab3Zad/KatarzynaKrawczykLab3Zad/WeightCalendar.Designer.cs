namespace KatarzynaKrawczykLab3Zad
{
    partial class WeightCalendar
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeightUnit = new System.Windows.Forms.Label();
            this.buttonAddWeight = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewWeight = new System.Windows.Forms.DataGridView();
            this.buttonTodayDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(89, 91);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(216, 27);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.Value = new System.DateTime(2018, 4, 22, 15, 19, 14, 0);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 93);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 22);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(16, 132);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(63, 22);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(89, 130);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxWeight.MaxLength = 5;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(112, 27);
            this.textBoxWeight.TabIndex = 3;
            // 
            // labelWeightUnit
            // 
            this.labelWeightUnit.AutoSize = true;
            this.labelWeightUnit.ForeColor = System.Drawing.Color.Black;
            this.labelWeightUnit.Location = new System.Drawing.Point(211, 132);
            this.labelWeightUnit.Name = "labelWeightUnit";
            this.labelWeightUnit.Size = new System.Drawing.Size(27, 22);
            this.labelWeightUnit.TabIndex = 4;
            this.labelWeightUnit.Text = "kg";
            // 
            // buttonAddWeight
            // 
            this.buttonAddWeight.BackColor = System.Drawing.Color.Gold;
            this.buttonAddWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWeight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddWeight.Location = new System.Drawing.Point(244, 212);
            this.buttonAddWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddWeight.Name = "buttonAddWeight";
            this.buttonAddWeight.Size = new System.Drawing.Size(84, 27);
            this.buttonAddWeight.TabIndex = 5;
            this.buttonAddWeight.Text = "Add";
            this.buttonAddWeight.UseVisualStyleBackColor = false;
            this.buttonAddWeight.Click += new System.EventHandler(this.buttonAddWeight_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Gold;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(244, 259);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 27);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Gold;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(244, 306);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 27);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewWeight
            // 
            this.dataGridViewWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWeight.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeight.Location = new System.Drawing.Point(12, 169);
            this.dataGridViewWeight.Name = "dataGridViewWeight";
            this.dataGridViewWeight.RowTemplate.Height = 24;
            this.dataGridViewWeight.Size = new System.Drawing.Size(226, 304);
            this.dataGridViewWeight.TabIndex = 8;
            // 
            // buttonTodayDate
            // 
            this.buttonTodayDate.BackColor = System.Drawing.Color.Gold;
            this.buttonTodayDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTodayDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTodayDate.Location = new System.Drawing.Point(244, 169);
            this.buttonTodayDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTodayDate.Name = "buttonTodayDate";
            this.buttonTodayDate.Size = new System.Drawing.Size(84, 27);
            this.buttonTodayDate.TabIndex = 9;
            this.buttonTodayDate.Text = "Today";
            this.buttonTodayDate.UseVisualStyleBackColor = false;
            this.buttonTodayDate.Click += new System.EventHandler(this.buttonTodayDate_Click);
            // 
            // WeightCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 485);
            this.Controls.Add(this.buttonTodayDate);
            this.Controls.Add(this.dataGridViewWeight);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddWeight);
            this.Controls.Add(this.labelWeightUnit);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WeightCalendar";
            this.Text = "WeightCalendar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeightUnit;
        private System.Windows.Forms.Button buttonAddWeight;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewWeight;
        private System.Windows.Forms.Button buttonTodayDate;
    }
}