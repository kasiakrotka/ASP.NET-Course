namespace KatarzynaKrawczykLab4Zad1
{
    partial class WorkPeriodWindow
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkPeriod = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerDateStart = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBoxPeriodInMonths = new System.Windows.Forms.TextBox();
            this.labelPeriodInMonths = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkPeriod)).BeginInit();
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
            this.dataGridViewEmployees.Location = new System.Drawing.Point(19, 114);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(241, 280);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // dataGridViewWorkPeriod
            // 
            this.dataGridViewWorkPeriod.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewWorkPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWorkPeriod.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWorkPeriod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.dataGridViewWorkPeriod.Location = new System.Drawing.Point(266, 114);
            this.dataGridViewWorkPeriod.Name = "dataGridViewWorkPeriod";
            this.dataGridViewWorkPeriod.ReadOnly = true;
            this.dataGridViewWorkPeriod.RowTemplate.Height = 24;
            this.dataGridViewWorkPeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWorkPeriod.Size = new System.Drawing.Size(463, 280);
            this.dataGridViewWorkPeriod.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(587, 30);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(506, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerDateStart
            // 
            this.dateTimePickerDateStart.Location = new System.Drawing.Point(266, 32);
            this.dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            this.dateTimePickerDateStart.Size = new System.Drawing.Size(234, 22);
            this.dateTimePickerDateStart.TabIndex = 7;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Arial", 9F);
            this.labelStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.labelStart.Location = new System.Drawing.Point(16, 37);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(208, 17);
            this.labelStart.TabIndex = 13;
            this.labelStart.Text = "Początek okresu zatrudnienia: ";
            // 
            // textBoxPeriodInMonths
            // 
            this.textBoxPeriodInMonths.Location = new System.Drawing.Point(266, 60);
            this.textBoxPeriodInMonths.MaxLength = 10;
            this.textBoxPeriodInMonths.Name = "textBoxPeriodInMonths";
            this.textBoxPeriodInMonths.Size = new System.Drawing.Size(99, 22);
            this.textBoxPeriodInMonths.TabIndex = 14;
            // 
            // labelPeriodInMonths
            // 
            this.labelPeriodInMonths.AutoSize = true;
            this.labelPeriodInMonths.Font = new System.Drawing.Font("Arial", 9F);
            this.labelPeriodInMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.labelPeriodInMonths.Location = new System.Drawing.Point(16, 64);
            this.labelPeriodInMonths.Name = "labelPeriodInMonths";
            this.labelPeriodInMonths.Size = new System.Drawing.Size(208, 17);
            this.labelPeriodInMonths.TabIndex = 15;
            this.labelPeriodInMonths.Text = "Czas zatrudnienia w miesiąch:";
            // 
            // WorkPeriodWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(741, 406);
            this.Controls.Add(this.labelPeriodInMonths);
            this.Controls.Add(this.textBoxPeriodInMonths);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerDateStart);
            this.Controls.Add(this.dataGridViewWorkPeriod);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "WorkPeriodWindow";
            this.Text = "WorkPeriodWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridView dataGridViewWorkPeriod;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxPeriodInMonths;
        private System.Windows.Forms.Label labelPeriodInMonths;
    }
}