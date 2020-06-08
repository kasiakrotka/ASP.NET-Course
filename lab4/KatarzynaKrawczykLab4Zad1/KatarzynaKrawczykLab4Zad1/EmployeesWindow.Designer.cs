namespace KatarzynaKrawczykLab4Zad1
{
    partial class EmployeesWindow
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonGenerateDocument = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNip = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.checkBoxIndefinitePeriod = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelNip = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonGetDataToTextBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.dataGridViewEmployees.Location = new System.Drawing.Point(35, 107);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(588, 283);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonGenerateDocument
            // 
            this.buttonGenerateDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.buttonGenerateDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateDocument.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerateDocument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGenerateDocument.Location = new System.Drawing.Point(640, 107);
            this.buttonGenerateDocument.Name = "buttonGenerateDocument";
            this.buttonGenerateDocument.Size = new System.Drawing.Size(145, 85);
            this.buttonGenerateDocument.TabIndex = 1;
            this.buttonGenerateDocument.Text = "Wygeneruj zaświadczenie o zatrudnieniu i zarobkach";
            this.buttonGenerateDocument.UseVisualStyleBackColor = false;
            this.buttonGenerateDocument.Click += new System.EventHandler(this.buttonGenerateDocument_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(644, 258);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 62);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Usuń pracownika";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(643, 198);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 57);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj pracownika";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Location = new System.Drawing.Point(643, 326);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(142, 57);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Aktualizuj dane pracownika";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(374, 39);
            this.textBoxSurname.MaxLength = 30;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(191, 22);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 39);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxNip
            // 
            this.textBoxNip.Location = new System.Drawing.Point(78, 67);
            this.textBoxNip.MaxLength = 13;
            this.textBoxNip.Name = "textBoxNip";
            this.textBoxNip.Size = new System.Drawing.Size(191, 22);
            this.textBoxNip.TabIndex = 7;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(374, 67);
            this.textBoxPosition.MaxLength = 30;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(191, 22);
            this.textBoxPosition.TabIndex = 8;
            // 
            // checkBoxIndefinitePeriod
            // 
            this.checkBoxIndefinitePeriod.AutoSize = true;
            this.checkBoxIndefinitePeriod.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxIndefinitePeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.checkBoxIndefinitePeriod.Location = new System.Drawing.Point(576, 39);
            this.checkBoxIndefinitePeriod.Name = "checkBoxIndefinitePeriod";
            this.checkBoxIndefinitePeriod.Size = new System.Drawing.Size(216, 24);
            this.checkBoxIndefinitePeriod.TabIndex = 9;
            this.checkBoxIndefinitePeriod.Text = "Czas zatrudnienia określony";
            this.checkBoxIndefinitePeriod.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.labelName.Location = new System.Drawing.Point(35, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 20);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Imię:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.labelSurname.Location = new System.Drawing.Point(280, 40);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 20);
            this.labelSurname.TabIndex = 11;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // labelNip
            // 
            this.labelNip.AutoSize = true;
            this.labelNip.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.labelNip.Location = new System.Drawing.Point(38, 72);
            this.labelNip.Name = "labelNip";
            this.labelNip.Size = new System.Drawing.Size(37, 20);
            this.labelNip.TabIndex = 12;
            this.labelNip.Text = "NIP:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.labelPosition.Location = new System.Drawing.Point(280, 71);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(89, 20);
            this.labelPosition.TabIndex = 13;
            this.labelPosition.Text = "Stanowisko:";
            // 
            // buttonGetDataToTextBoxes
            // 
            this.buttonGetDataToTextBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.buttonGetDataToTextBoxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetDataToTextBoxes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetDataToTextBoxes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGetDataToTextBoxes.Location = new System.Drawing.Point(576, 62);
            this.buttonGetDataToTextBoxes.Name = "buttonGetDataToTextBoxes";
            this.buttonGetDataToTextBoxes.Size = new System.Drawing.Size(208, 34);
            this.buttonGetDataToTextBoxes.TabIndex = 14;
            this.buttonGetDataToTextBoxes.Text = "pobierz dane pracownika";
            this.buttonGetDataToTextBoxes.UseVisualStyleBackColor = false;
            this.buttonGetDataToTextBoxes.Click += new System.EventHandler(this.buttonGetDataToTextBoxes_Click);
            // 
            // EmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(797, 413);
            this.Controls.Add(this.buttonGetDataToTextBoxes);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelNip);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBoxIndefinitePeriod);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxNip);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonGenerateDocument);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeesWindow";
            this.Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonGenerateDocument;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNip;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.CheckBox checkBoxIndefinitePeriod;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelNip;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonGetDataToTextBoxes;
    }
}