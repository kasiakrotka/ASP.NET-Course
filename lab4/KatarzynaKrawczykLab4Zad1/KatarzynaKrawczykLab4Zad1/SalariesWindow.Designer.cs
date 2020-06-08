namespace KatarzynaKrawczykLab4Zad1
{
    partial class SalariesWindow
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
            this.dataGridViewSalaries = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalaries
            // 
            this.dataGridViewSalaries.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSalaries.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalaries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.dataGridViewSalaries.Location = new System.Drawing.Point(404, 114);
            this.dataGridViewSalaries.Name = "dataGridViewSalaries";
            this.dataGridViewSalaries.RowTemplate.Height = 24;
            this.dataGridViewSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalaries.Size = new System.Drawing.Size(424, 280);
            this.dataGridViewSalaries.TabIndex = 0;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(28, 34);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(241, 22);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.dataGridViewEmployees.Location = new System.Drawing.Point(28, 114);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(370, 280);
            this.dataGridViewEmployees.TabIndex = 2;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(145, 71);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(124, 22);
            this.textBoxValue.TabIndex = 3;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(28, 71);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(111, 17);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Wynagrodzenie:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(275, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(275, 67);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // SalariesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 406);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dataGridViewSalaries);
            this.Name = "SalariesWindow";
            this.Text = "SalariesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalaries;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}