namespace KatarzynaKrawczykLab2ZadDom
{
    partial class LevelUpWindow
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
            this.radioButtonMaxDamage = new System.Windows.Forms.RadioButton();
            this.radioButtonCritical = new System.Windows.Forms.RadioButton();
            this.radioButtonDodge = new System.Windows.Forms.RadioButton();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonMaxDamage
            // 
            this.radioButtonMaxDamage.AutoSize = true;
            this.radioButtonMaxDamage.Location = new System.Drawing.Point(12, 35);
            this.radioButtonMaxDamage.Name = "radioButtonMaxDamage";
            this.radioButtonMaxDamage.Size = new System.Drawing.Size(87, 21);
            this.radioButtonMaxDamage.TabIndex = 0;
            this.radioButtonMaxDamage.TabStop = true;
            this.radioButtonMaxDamage.Text = "Max Dmg";
            this.radioButtonMaxDamage.UseVisualStyleBackColor = true;
            // 
            // radioButtonCritical
            // 
            this.radioButtonCritical.AutoSize = true;
            this.radioButtonCritical.Location = new System.Drawing.Point(12, 65);
            this.radioButtonCritical.Name = "radioButtonCritical";
            this.radioButtonCritical.Size = new System.Drawing.Size(102, 21);
            this.radioButtonCritical.TabIndex = 1;
            this.radioButtonCritical.TabStop = true;
            this.radioButtonCritical.Text = "Crit Chance";
            this.radioButtonCritical.UseVisualStyleBackColor = true;
            // 
            // radioButtonDodge
            // 
            this.radioButtonDodge.AutoSize = true;
            this.radioButtonDodge.Location = new System.Drawing.Point(12, 95);
            this.radioButtonDodge.Name = "radioButtonDodge";
            this.radioButtonDodge.Size = new System.Drawing.Size(123, 21);
            this.radioButtonDodge.TabIndex = 2;
            this.radioButtonDodge.TabStop = true;
            this.radioButtonDodge.Text = "Dodge Chance";
            this.radioButtonDodge.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(195, 108);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDescription.Location = new System.Drawing.Point(12, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(204, 17);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Choose what you want to boost";
            // 
            // LevelUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 143);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.radioButtonDodge);
            this.Controls.Add(this.radioButtonCritical);
            this.Controls.Add(this.radioButtonMaxDamage);
            this.Name = "LevelUpWindow";
            this.Text = "Level UP!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMaxDamage;
        private System.Windows.Forms.RadioButton radioButtonCritical;
        private System.Windows.Forms.RadioButton radioButtonDodge;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelDescription;
    }
}