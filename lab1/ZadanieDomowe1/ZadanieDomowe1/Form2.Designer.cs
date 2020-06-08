namespace ZadanieDomowe1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxFarmName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonConfirmName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFarmName
            // 
            this.textBoxFarmName.Location = new System.Drawing.Point(48, 49);
            this.textBoxFarmName.MaxLength = 20;
            this.textBoxFarmName.Name = "textBoxFarmName";
            this.textBoxFarmName.Size = new System.Drawing.Size(193, 22);
            this.textBoxFarmName.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(71, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Type your farm name:";
            // 
            // buttonConfirmName
            // 
            this.buttonConfirmName.Location = new System.Drawing.Point(107, 78);
            this.buttonConfirmName.Name = "buttonConfirmName";
            this.buttonConfirmName.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmName.TabIndex = 2;
            this.buttonConfirmName.Text = "Save";
            this.buttonConfirmName.UseVisualStyleBackColor = true;
            this.buttonConfirmName.Click += new System.EventHandler(this.buttonConfirmName_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(282, 124);
            this.Controls.Add(this.buttonConfirmName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxFarmName);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFarmName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonConfirmName;
    }
}