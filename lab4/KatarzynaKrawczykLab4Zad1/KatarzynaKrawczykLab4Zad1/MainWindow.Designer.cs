namespace KatarzynaKrawczykLab4Zad1
{
    partial class MainWindow
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
            this.buttonEmployeesList = new System.Windows.Forms.Button();
            this.buttonSalariesList = new System.Windows.Forms.Button();
            this.buttonWorkPeriodList = new System.Windows.Forms.Button();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEmployeesList
            // 
            this.buttonEmployeesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEmployeesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeesList.ForeColor = System.Drawing.Color.White;
            this.buttonEmployeesList.Location = new System.Drawing.Point(153, 121);
            this.buttonEmployeesList.Name = "buttonEmployeesList";
            this.buttonEmployeesList.Size = new System.Drawing.Size(134, 47);
            this.buttonEmployeesList.TabIndex = 0;
            this.buttonEmployeesList.Text = "Spis pracowników";
            this.buttonEmployeesList.UseVisualStyleBackColor = false;
            this.buttonEmployeesList.Click += new System.EventHandler(this.buttonEmployeesList_Click);
            // 
            // buttonSalariesList
            // 
            this.buttonSalariesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonSalariesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalariesList.ForeColor = System.Drawing.Color.White;
            this.buttonSalariesList.Location = new System.Drawing.Point(153, 168);
            this.buttonSalariesList.Name = "buttonSalariesList";
            this.buttonSalariesList.Size = new System.Drawing.Size(134, 47);
            this.buttonSalariesList.TabIndex = 1;
            this.buttonSalariesList.Text = "Spis płac";
            this.buttonSalariesList.UseVisualStyleBackColor = false;
            this.buttonSalariesList.Click += new System.EventHandler(this.buttonSalariesList_Click);
            // 
            // buttonWorkPeriodList
            // 
            this.buttonWorkPeriodList.BackColor = System.Drawing.Color.IndianRed;
            this.buttonWorkPeriodList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkPeriodList.ForeColor = System.Drawing.Color.White;
            this.buttonWorkPeriodList.Location = new System.Drawing.Point(153, 215);
            this.buttonWorkPeriodList.Name = "buttonWorkPeriodList";
            this.buttonWorkPeriodList.Size = new System.Drawing.Size(134, 47);
            this.buttonWorkPeriodList.TabIndex = 2;
            this.buttonWorkPeriodList.Text = "Okres zatrudnienia";
            this.buttonWorkPeriodList.UseVisualStyleBackColor = false;
            this.buttonWorkPeriodList.Click += new System.EventHandler(this.buttonWorkPeriodList_Click);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.textBoxCompanyName.Location = new System.Drawing.Point(78, 39);
            this.textBoxCompanyName.Multiline = true;
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.ReadOnly = true;
            this.textBoxCompanyName.Size = new System.Drawing.Size(276, 76);
            this.textBoxCompanyName.TabIndex = 4;
            this.textBoxCompanyName.Text = "Flat Design \r\nCompany";
            this.textBoxCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(433, 299);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.buttonWorkPeriodList);
            this.Controls.Add(this.buttonSalariesList);
            this.Controls.Add(this.buttonEmployeesList);
            this.Name = "MainWindow";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEmployeesList;
        private System.Windows.Forms.Button buttonSalariesList;
        private System.Windows.Forms.Button buttonWorkPeriodList;
        private System.Windows.Forms.TextBox textBoxCompanyName;
    }
}

