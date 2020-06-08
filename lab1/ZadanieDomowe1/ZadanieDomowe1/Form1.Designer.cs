namespace ZadanieDomowe1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelSheeps = new System.Windows.Forms.Label();
            this.labelWool = new System.Windows.Forms.Label();
            this.timerWool = new System.Windows.Forms.Timer(this.components);
            this.buttonCut = new System.Windows.Forms.Button();
            this.labelMoneyVal = new System.Windows.Forms.Label();
            this.labelSheepsVal = new System.Windows.Forms.Label();
            this.labelWoolVal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxShopItem1 = new System.Windows.Forms.PictureBox();
            this.buttonBuyScissors = new System.Windows.Forms.Button();
            this.labelScissorsPrice = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelShopItemName1 = new System.Windows.Forms.Label();
            this.labelShopItemName2 = new System.Windows.Forms.Label();
            this.labelSheepPrice = new System.Windows.Forms.Label();
            this.buttonBuySheep = new System.Windows.Forms.Button();
            this.labelShopItemName3 = new System.Windows.Forms.Label();
            this.labelMagicScissorsPrice = new System.Windows.Forms.Label();
            this.buttonBuyMagicScissors = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerMagicPower = new System.Windows.Forms.Timer(this.components);
            this.labelShopItemName4 = new System.Windows.Forms.Label();
            this.labelVitaminsPrice = new System.Windows.Forms.Label();
            this.buttonBuyVitamins = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonChangeFarmName = new System.Windows.Forms.Button();
            this.textBoxFarmName = new System.Windows.Forms.TextBox();
            this.labelScissors = new System.Windows.Forms.Label();
            this.labelMagicScissors = new System.Windows.Forms.Label();
            this.labelWoolPrice = new System.Windows.Forms.Label();
            this.labelScissorsCount = new System.Windows.Forms.Label();
            this.labelMagicScissorsCount = new System.Windows.Forms.Label();
            this.labelWoolPriceVal = new System.Windows.Forms.Label();
            this.labelAchievements = new System.Windows.Forms.Label();
            this.labelAchievBusinessman = new System.Windows.Forms.Label();
            this.labelAchievShepard = new System.Windows.Forms.Label();
            this.labelAchievNurse = new System.Windows.Forms.Label();
            this.labelAchievWitch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(13, 9);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(54, 17);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Money:";
            // 
            // labelSheeps
            // 
            this.labelSheeps.AutoSize = true;
            this.labelSheeps.Location = new System.Drawing.Point(13, 30);
            this.labelSheeps.Name = "labelSheeps";
            this.labelSheeps.Size = new System.Drawing.Size(60, 17);
            this.labelSheeps.TabIndex = 1;
            this.labelSheeps.Text = "Sheeps:";
            // 
            // labelWool
            // 
            this.labelWool.AutoSize = true;
            this.labelWool.Location = new System.Drawing.Point(13, 51);
            this.labelWool.Name = "labelWool";
            this.labelWool.Size = new System.Drawing.Size(44, 17);
            this.labelWool.TabIndex = 2;
            this.labelWool.Text = "Wool:";
            // 
            // timerWool
            // 
            this.timerWool.Interval = 500;
            this.timerWool.Tick += new System.EventHandler(this.timerWool_Tick);
            // 
            // buttonCut
            // 
            this.buttonCut.Location = new System.Drawing.Point(234, 136);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(131, 37);
            this.buttonCut.TabIndex = 3;
            this.buttonCut.Text = "Cut the wool ";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // labelMoneyVal
            // 
            this.labelMoneyVal.AutoSize = true;
            this.labelMoneyVal.Location = new System.Drawing.Point(74, 10);
            this.labelMoneyVal.Name = "labelMoneyVal";
            this.labelMoneyVal.Size = new System.Drawing.Size(16, 17);
            this.labelMoneyVal.TabIndex = 4;
            this.labelMoneyVal.Text = "0";
            // 
            // labelSheepsVal
            // 
            this.labelSheepsVal.AutoSize = true;
            this.labelSheepsVal.Location = new System.Drawing.Point(79, 30);
            this.labelSheepsVal.Name = "labelSheepsVal";
            this.labelSheepsVal.Size = new System.Drawing.Size(16, 17);
            this.labelSheepsVal.TabIndex = 5;
            this.labelSheepsVal.Text = "0";
            // 
            // labelWoolVal
            // 
            this.labelWoolVal.AutoSize = true;
            this.labelWoolVal.Location = new System.Drawing.Point(63, 51);
            this.labelWoolVal.Name = "labelWoolVal";
            this.labelWoolVal.Size = new System.Drawing.Size(16, 17);
            this.labelWoolVal.TabIndex = 6;
            this.labelWoolVal.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(547, 9);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(45, 17);
            this.labelShop.TabIndex = 8;
            this.labelShop.Text = "Shop:";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pictureBoxShopItem1
            // 
            this.pictureBoxShopItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShopItem1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShopItem1.Image")));
            this.pictureBoxShopItem1.Location = new System.Drawing.Point(571, 30);
            this.pictureBoxShopItem1.Name = "pictureBoxShopItem1";
            this.pictureBoxShopItem1.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxShopItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShopItem1.TabIndex = 9;
            this.pictureBoxShopItem1.TabStop = false;
            // 
            // buttonBuyScissors
            // 
            this.buttonBuyScissors.Location = new System.Drawing.Point(490, 67);
            this.buttonBuyScissors.Name = "buttonBuyScissors";
            this.buttonBuyScissors.Size = new System.Drawing.Size(75, 27);
            this.buttonBuyScissors.TabIndex = 10;
            this.buttonBuyScissors.Text = "Buy";
            this.buttonBuyScissors.UseVisualStyleBackColor = true;
            this.buttonBuyScissors.Click += new System.EventHandler(this.buttonBuyScissors_Click);
            // 
            // labelScissorsPrice
            // 
            this.labelScissorsPrice.AutoSize = true;
            this.labelScissorsPrice.Location = new System.Drawing.Point(521, 47);
            this.labelScissorsPrice.Name = "labelScissorsPrice";
            this.labelScissorsPrice.Size = new System.Drawing.Size(44, 17);
            this.labelScissorsPrice.TabIndex = 11;
            this.labelScissorsPrice.Text = "150 $";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(571, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // labelShopItemName1
            // 
            this.labelShopItemName1.AutoSize = true;
            this.labelShopItemName1.Location = new System.Drawing.Point(466, 30);
            this.labelShopItemName1.Name = "labelShopItemName1";
            this.labelShopItemName1.Size = new System.Drawing.Size(99, 17);
            this.labelShopItemName1.TabIndex = 13;
            this.labelShopItemName1.Text = "Beter Scissors";
            // 
            // labelShopItemName2
            // 
            this.labelShopItemName2.AutoSize = true;
            this.labelShopItemName2.Location = new System.Drawing.Point(480, 100);
            this.labelShopItemName2.Name = "labelShopItemName2";
            this.labelShopItemName2.Size = new System.Drawing.Size(85, 17);
            this.labelShopItemName2.TabIndex = 14;
            this.labelShopItemName2.Text = "Extra Sheep";
            // 
            // labelSheepPrice
            // 
            this.labelSheepPrice.AutoSize = true;
            this.labelSheepPrice.Location = new System.Drawing.Point(521, 117);
            this.labelSheepPrice.Name = "labelSheepPrice";
            this.labelSheepPrice.Size = new System.Drawing.Size(44, 17);
            this.labelSheepPrice.TabIndex = 15;
            this.labelSheepPrice.Text = "150 $";
            // 
            // buttonBuySheep
            // 
            this.buttonBuySheep.Location = new System.Drawing.Point(490, 136);
            this.buttonBuySheep.Name = "buttonBuySheep";
            this.buttonBuySheep.Size = new System.Drawing.Size(75, 27);
            this.buttonBuySheep.TabIndex = 16;
            this.buttonBuySheep.Text = "Buy";
            this.buttonBuySheep.UseVisualStyleBackColor = true;
            this.buttonBuySheep.Click += new System.EventHandler(this.buttonBuySheep_Click);
            // 
            // labelShopItemName3
            // 
            this.labelShopItemName3.AutoSize = true;
            this.labelShopItemName3.Location = new System.Drawing.Point(463, 170);
            this.labelShopItemName3.Name = "labelShopItemName3";
            this.labelShopItemName3.Size = new System.Drawing.Size(102, 17);
            this.labelShopItemName3.TabIndex = 17;
            this.labelShopItemName3.Text = "Magic Scissors";
            // 
            // labelMagicScissorsPrice
            // 
            this.labelMagicScissorsPrice.AutoSize = true;
            this.labelMagicScissorsPrice.Location = new System.Drawing.Point(521, 187);
            this.labelMagicScissorsPrice.Name = "labelMagicScissorsPrice";
            this.labelMagicScissorsPrice.Size = new System.Drawing.Size(44, 17);
            this.labelMagicScissorsPrice.TabIndex = 18;
            this.labelMagicScissorsPrice.Text = "300 $";
            // 
            // buttonBuyMagicScissors
            // 
            this.buttonBuyMagicScissors.Location = new System.Drawing.Point(490, 207);
            this.buttonBuyMagicScissors.Name = "buttonBuyMagicScissors";
            this.buttonBuyMagicScissors.Size = new System.Drawing.Size(75, 27);
            this.buttonBuyMagicScissors.TabIndex = 19;
            this.buttonBuyMagicScissors.Text = "Buy";
            this.buttonBuyMagicScissors.UseVisualStyleBackColor = true;
            this.buttonBuyMagicScissors.Click += new System.EventHandler(this.buttonBuyMagicScissors_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(571, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // timerMagicPower
            // 
            this.timerMagicPower.Interval = 1000;
            this.timerMagicPower.Tick += new System.EventHandler(this.timerMagicPower_Tick);
            // 
            // labelShopItemName4
            // 
            this.labelShopItemName4.AutoSize = true;
            this.labelShopItemName4.Location = new System.Drawing.Point(504, 240);
            this.labelShopItemName4.Name = "labelShopItemName4";
            this.labelShopItemName4.Size = new System.Drawing.Size(61, 17);
            this.labelShopItemName4.TabIndex = 21;
            this.labelShopItemName4.Text = "Vitamins";
            // 
            // labelVitaminsPrice
            // 
            this.labelVitaminsPrice.AutoSize = true;
            this.labelVitaminsPrice.Location = new System.Drawing.Point(521, 257);
            this.labelVitaminsPrice.Name = "labelVitaminsPrice";
            this.labelVitaminsPrice.Size = new System.Drawing.Size(44, 17);
            this.labelVitaminsPrice.TabIndex = 22;
            this.labelVitaminsPrice.Text = "250 $";
            // 
            // buttonBuyVitamins
            // 
            this.buttonBuyVitamins.Location = new System.Drawing.Point(490, 277);
            this.buttonBuyVitamins.Name = "buttonBuyVitamins";
            this.buttonBuyVitamins.Size = new System.Drawing.Size(75, 27);
            this.buttonBuyVitamins.TabIndex = 23;
            this.buttonBuyVitamins.Text = "Buy";
            this.buttonBuyVitamins.UseVisualStyleBackColor = true;
            this.buttonBuyVitamins.Click += new System.EventHandler(this.buttonBuyVitamins_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(571, 240);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // buttonChangeFarmName
            // 
            this.buttonChangeFarmName.Location = new System.Drawing.Point(12, 75);
            this.buttonChangeFarmName.Name = "buttonChangeFarmName";
            this.buttonChangeFarmName.Size = new System.Drawing.Size(147, 27);
            this.buttonChangeFarmName.TabIndex = 26;
            this.buttonChangeFarmName.Text = "Change Farm Name";
            this.buttonChangeFarmName.UseVisualStyleBackColor = true;
            this.buttonChangeFarmName.Click += new System.EventHandler(this.buttonChangeFarmName_Click);
            // 
            // textBoxFarmName
            // 
            this.textBoxFarmName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFarmName.Location = new System.Drawing.Point(203, 30);
            this.textBoxFarmName.Name = "textBoxFarmName";
            this.textBoxFarmName.ReadOnly = true;
            this.textBoxFarmName.Size = new System.Drawing.Size(193, 22);
            this.textBoxFarmName.TabIndex = 27;
            this.textBoxFarmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelScissors
            // 
            this.labelScissors.AutoSize = true;
            this.labelScissors.Location = new System.Drawing.Point(14, 105);
            this.labelScissors.Name = "labelScissors";
            this.labelScissors.Size = new System.Drawing.Size(65, 17);
            this.labelScissors.TabIndex = 28;
            this.labelScissors.Text = "Scissors:";
            // 
            // labelMagicScissors
            // 
            this.labelMagicScissors.AutoSize = true;
            this.labelMagicScissors.Location = new System.Drawing.Point(14, 127);
            this.labelMagicScissors.Name = "labelMagicScissors";
            this.labelMagicScissors.Size = new System.Drawing.Size(106, 17);
            this.labelMagicScissors.TabIndex = 29;
            this.labelMagicScissors.Text = "Magic Scissors:";
            // 
            // labelWoolPrice
            // 
            this.labelWoolPrice.AutoSize = true;
            this.labelWoolPrice.Location = new System.Drawing.Point(13, 148);
            this.labelWoolPrice.Name = "labelWoolPrice";
            this.labelWoolPrice.Size = new System.Drawing.Size(76, 17);
            this.labelWoolPrice.TabIndex = 30;
            this.labelWoolPrice.Text = "WoolPrice:";
            // 
            // labelScissorsCount
            // 
            this.labelScissorsCount.AutoSize = true;
            this.labelScissorsCount.Location = new System.Drawing.Point(85, 105);
            this.labelScissorsCount.Name = "labelScissorsCount";
            this.labelScissorsCount.Size = new System.Drawing.Size(16, 17);
            this.labelScissorsCount.TabIndex = 31;
            this.labelScissorsCount.Text = "0";
            // 
            // labelMagicScissorsCount
            // 
            this.labelMagicScissorsCount.AutoSize = true;
            this.labelMagicScissorsCount.Location = new System.Drawing.Point(127, 127);
            this.labelMagicScissorsCount.Name = "labelMagicScissorsCount";
            this.labelMagicScissorsCount.Size = new System.Drawing.Size(16, 17);
            this.labelMagicScissorsCount.TabIndex = 32;
            this.labelMagicScissorsCount.Text = "0";
            // 
            // labelWoolPriceVal
            // 
            this.labelWoolPriceVal.AutoSize = true;
            this.labelWoolPriceVal.Location = new System.Drawing.Point(96, 148);
            this.labelWoolPriceVal.Name = "labelWoolPriceVal";
            this.labelWoolPriceVal.Size = new System.Drawing.Size(28, 17);
            this.labelWoolPriceVal.TabIndex = 33;
            this.labelWoolPriceVal.Text = "0 $";
            // 
            // labelAchievements
            // 
            this.labelAchievements.AutoSize = true;
            this.labelAchievements.Location = new System.Drawing.Point(13, 187);
            this.labelAchievements.Name = "labelAchievements";
            this.labelAchievements.Size = new System.Drawing.Size(100, 17);
            this.labelAchievements.TabIndex = 34;
            this.labelAchievements.Text = "Achievements:";
            // 
            // labelAchievBusinessman
            // 
            this.labelAchievBusinessman.AutoSize = true;
            this.labelAchievBusinessman.Location = new System.Drawing.Point(13, 205);
            this.labelAchievBusinessman.Name = "labelAchievBusinessman";
            this.labelAchievBusinessman.Size = new System.Drawing.Size(349, 17);
            this.labelAchievBusinessman.TabIndex = 35;
            this.labelAchievBusinessman.Text = "*Businessman ( first 1000$) - not too bad for a layman";
            // 
            // labelAchievShepard
            // 
            this.labelAchievShepard.AutoSize = true;
            this.labelAchievShepard.Location = new System.Drawing.Point(13, 223);
            this.labelAchievShepard.Name = "labelAchievShepard";
            this.labelAchievShepard.Size = new System.Drawing.Size(364, 17);
            this.labelAchievShepard.TabIndex = 36;
            this.labelAchievShepard.Text = "*Shepard ( 15 sheeps ) - better get a fence for this herd ";
            // 
            // labelAchievNurse
            // 
            this.labelAchievNurse.AutoSize = true;
            this.labelAchievNurse.Location = new System.Drawing.Point(13, 241);
            this.labelAchievNurse.Name = "labelAchievNurse";
            this.labelAchievNurse.Size = new System.Drawing.Size(313, 17);
            this.labelAchievNurse.TabIndex = 37;
            this.labelAchievNurse.Text = "*Nurse ( 10 vitamins ) - more like clinic than farm";
            // 
            // labelAchievWitch
            // 
            this.labelAchievWitch.AutoSize = true;
            this.labelAchievWitch.Location = new System.Drawing.Point(12, 259);
            this.labelAchievWitch.Name = "labelAchievWitch";
            this.labelAchievWitch.Size = new System.Drawing.Size(398, 17);
            this.labelAchievWitch.TabIndex = 38;
            this.labelAchievWitch.Text = "*Witch (5 Magic Scissors) - The Force will be with you. Always.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 337);
            this.Controls.Add(this.labelAchievWitch);
            this.Controls.Add(this.labelAchievNurse);
            this.Controls.Add(this.labelAchievShepard);
            this.Controls.Add(this.labelAchievBusinessman);
            this.Controls.Add(this.labelAchievements);
            this.Controls.Add(this.labelWoolPriceVal);
            this.Controls.Add(this.labelMagicScissorsCount);
            this.Controls.Add(this.labelScissorsCount);
            this.Controls.Add(this.labelWoolPrice);
            this.Controls.Add(this.labelMagicScissors);
            this.Controls.Add(this.labelScissors);
            this.Controls.Add(this.textBoxFarmName);
            this.Controls.Add(this.buttonChangeFarmName);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonBuyVitamins);
            this.Controls.Add(this.labelVitaminsPrice);
            this.Controls.Add(this.labelShopItemName4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonBuyMagicScissors);
            this.Controls.Add(this.labelMagicScissorsPrice);
            this.Controls.Add(this.labelShopItemName3);
            this.Controls.Add(this.buttonBuySheep);
            this.Controls.Add(this.labelSheepPrice);
            this.Controls.Add(this.labelShopItemName2);
            this.Controls.Add(this.labelShopItemName1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelScissorsPrice);
            this.Controls.Add(this.buttonBuyScissors);
            this.Controls.Add(this.pictureBoxShopItem1);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWoolVal);
            this.Controls.Add(this.labelSheepsVal);
            this.Controls.Add(this.labelMoneyVal);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.labelWool);
            this.Controls.Add(this.labelSheeps);
            this.Controls.Add(this.labelMoney);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelSheeps;
        private System.Windows.Forms.Label labelWool;
        private System.Windows.Forms.Timer timerWool;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Label labelMoneyVal;
        private System.Windows.Forms.Label labelSheepsVal;
        private System.Windows.Forms.Label labelWoolVal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.PictureBox pictureBoxShopItem1;
        private System.Windows.Forms.Button buttonBuyScissors;
        private System.Windows.Forms.Label labelScissorsPrice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelShopItemName1;
        private System.Windows.Forms.Label labelShopItemName2;
        private System.Windows.Forms.Label labelSheepPrice;
        private System.Windows.Forms.Button buttonBuySheep;
        private System.Windows.Forms.Label labelShopItemName3;
        private System.Windows.Forms.Label labelMagicScissorsPrice;
        private System.Windows.Forms.Button buttonBuyMagicScissors;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerMagicPower;
        private System.Windows.Forms.Label labelShopItemName4;
        private System.Windows.Forms.Label labelVitaminsPrice;
        private System.Windows.Forms.Button buttonBuyVitamins;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonChangeFarmName;
        private System.Windows.Forms.TextBox textBoxFarmName;
        private System.Windows.Forms.Label labelScissors;
        private System.Windows.Forms.Label labelMagicScissors;
        private System.Windows.Forms.Label labelWoolPrice;
        private System.Windows.Forms.Label labelScissorsCount;
        private System.Windows.Forms.Label labelMagicScissorsCount;
        private System.Windows.Forms.Label labelWoolPriceVal;
        private System.Windows.Forms.Label labelAchievements;
        private System.Windows.Forms.Label labelAchievBusinessman;
        private System.Windows.Forms.Label labelAchievShepard;
        private System.Windows.Forms.Label labelAchievNurse;
        private System.Windows.Forms.Label labelAchievWitch;
    }
}

