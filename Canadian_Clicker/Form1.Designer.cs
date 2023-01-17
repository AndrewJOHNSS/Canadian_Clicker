namespace Canadian_Clicker
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.powerup2Xlabel = new System.Windows.Forms.Label();
            this.powerupIglooLabel = new System.Windows.Forms.Label();
            this.timsMilkAndSugar2X = new System.Windows.Forms.Label();
            this.hockeypowerupLabel = new System.Windows.Forms.Label();
            this.floridianMooseRider10x = new System.Windows.Forms.Label();
            this.buyiglooButton = new System.Windows.Forms.Button();
            this.buysnowplowButton = new System.Windows.Forms.Button();
            this.buytimsButton = new System.Windows.Forms.Button();
            this.buyhockeyplayerButton = new System.Windows.Forms.Button();
            this.buymooseriderButton = new System.Windows.Forms.Button();
            this.numberofiglooLabel = new System.Windows.Forms.Label();
            this.numberofsnowplowLabel = new System.Windows.Forms.Label();
            this.numberoftimsLabel = new System.Windows.Forms.Label();
            this.numberofhockeyLabel = new System.Windows.Forms.Label();
            this.numberofmooseLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mapleLeafImage = new System.Windows.Forms.Label();
            this.clickpowerLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.winButton = new System.Windows.Forms.Button();
            this.costtowinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(51, 178);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(67, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "eh? Amount:";
            // 
            // powerup2Xlabel
            // 
            this.powerup2Xlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.powerup2Xlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.powerup2Xlabel.Location = new System.Drawing.Point(395, 41);
            this.powerup2Xlabel.Name = "powerup2Xlabel";
            this.powerup2Xlabel.Size = new System.Drawing.Size(106, 29);
            this.powerup2Xlabel.TabIndex = 2;
            this.powerup2Xlabel.Text = "2x CLICK POWER: 1,000eh?\'s";
            this.powerup2Xlabel.Click += new System.EventHandler(this.powerup2Xlabel_Click);
            // 
            // powerupIglooLabel
            // 
            this.powerupIglooLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.powerupIglooLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.powerupIglooLabel.Location = new System.Drawing.Point(395, 86);
            this.powerupIglooLabel.Name = "powerupIglooLabel";
            this.powerupIglooLabel.Size = new System.Drawing.Size(106, 38);
            this.powerupIglooLabel.TabIndex = 3;
            this.powerupIglooLabel.Text = "2x IGLOO POWER 10,000 eh?\'s";
            this.powerupIglooLabel.Click += new System.EventHandler(this.powerupIglooLabel_Click);
            // 
            // timsMilkAndSugar2X
            // 
            this.timsMilkAndSugar2X.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timsMilkAndSugar2X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timsMilkAndSugar2X.Location = new System.Drawing.Point(395, 139);
            this.timsMilkAndSugar2X.Name = "timsMilkAndSugar2X";
            this.timsMilkAndSugar2X.Size = new System.Drawing.Size(106, 52);
            this.timsMilkAndSugar2X.TabIndex = 4;
            this.timsMilkAndSugar2X.Text = "Tim\'s 2x: Milk and Sugar               20,000 eh?\'s";
            this.timsMilkAndSugar2X.Click += new System.EventHandler(this.timsMilkAndSugar2X_Click);
            // 
            // hockeypowerupLabel
            // 
            this.hockeypowerupLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hockeypowerupLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hockeypowerupLabel.Location = new System.Drawing.Point(395, 204);
            this.hockeypowerupLabel.Name = "hockeypowerupLabel";
            this.hockeypowerupLabel.Size = new System.Drawing.Size(106, 45);
            this.hockeypowerupLabel.TabIndex = 5;
            this.hockeypowerupLabel.Text = "Better Hockey Players: 3x            50,000 eh?\'s";
            this.hockeypowerupLabel.Click += new System.EventHandler(this.hockeypowerupLabel_Click);
            // 
            // floridianMooseRider10x
            // 
            this.floridianMooseRider10x.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.floridianMooseRider10x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floridianMooseRider10x.Location = new System.Drawing.Point(395, 261);
            this.floridianMooseRider10x.Name = "floridianMooseRider10x";
            this.floridianMooseRider10x.Size = new System.Drawing.Size(106, 47);
            this.floridianMooseRider10x.TabIndex = 6;
            this.floridianMooseRider10x.Text = "Floridian Moose Rider: 10x            100,000 eh?\'s";
            this.floridianMooseRider10x.Click += new System.EventHandler(this.floridianMooseRider10x_Click);
            // 
            // buyiglooButton
            // 
            this.buyiglooButton.Location = new System.Drawing.Point(12, 415);
            this.buyiglooButton.Name = "buyiglooButton";
            this.buyiglooButton.Size = new System.Drawing.Size(75, 23);
            this.buyiglooButton.TabIndex = 7;
            this.buyiglooButton.Text = "Buy Igloo";
            this.buyiglooButton.UseVisualStyleBackColor = true;
            this.buyiglooButton.Click += new System.EventHandler(this.buyiglooButton_Click);
            // 
            // buysnowplowButton
            // 
            this.buysnowplowButton.Location = new System.Drawing.Point(93, 415);
            this.buysnowplowButton.Name = "buysnowplowButton";
            this.buysnowplowButton.Size = new System.Drawing.Size(86, 23);
            this.buysnowplowButton.TabIndex = 8;
            this.buysnowplowButton.Text = "Buy SnowPlow";
            this.buysnowplowButton.UseVisualStyleBackColor = true;
            this.buysnowplowButton.Click += new System.EventHandler(this.buysnowplowButton_Click);
            // 
            // buytimsButton
            // 
            this.buytimsButton.Location = new System.Drawing.Point(185, 415);
            this.buytimsButton.Name = "buytimsButton";
            this.buytimsButton.Size = new System.Drawing.Size(75, 23);
            this.buytimsButton.TabIndex = 9;
            this.buytimsButton.Text = "Buy Tim\'s";
            this.buytimsButton.UseVisualStyleBackColor = true;
            this.buytimsButton.Click += new System.EventHandler(this.buytimsButton_Click);
            // 
            // buyhockeyplayerButton
            // 
            this.buyhockeyplayerButton.Location = new System.Drawing.Point(266, 415);
            this.buyhockeyplayerButton.Name = "buyhockeyplayerButton";
            this.buyhockeyplayerButton.Size = new System.Drawing.Size(114, 23);
            this.buyhockeyplayerButton.TabIndex = 10;
            this.buyhockeyplayerButton.Text = "Buy Hockey Player";
            this.buyhockeyplayerButton.UseVisualStyleBackColor = true;
            this.buyhockeyplayerButton.Click += new System.EventHandler(this.buyhockeyplayerButton_Click);
            // 
            // buymooseriderButton
            // 
            this.buymooseriderButton.Location = new System.Drawing.Point(386, 415);
            this.buymooseriderButton.Name = "buymooseriderButton";
            this.buymooseriderButton.Size = new System.Drawing.Size(99, 23);
            this.buymooseriderButton.TabIndex = 11;
            this.buymooseriderButton.Text = "Buy Moose Rider";
            this.buymooseriderButton.UseVisualStyleBackColor = true;
            this.buymooseriderButton.Click += new System.EventHandler(this.buymooseriderButton_Click);
            // 
            // numberofiglooLabel
            // 
            this.numberofiglooLabel.Location = new System.Drawing.Point(12, 380);
            this.numberofiglooLabel.Name = "numberofiglooLabel";
            this.numberofiglooLabel.Size = new System.Drawing.Size(87, 32);
            this.numberofiglooLabel.TabIndex = 12;
            this.numberofiglooLabel.Text = "0";
            this.numberofiglooLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberofsnowplowLabel
            // 
            this.numberofsnowplowLabel.Location = new System.Drawing.Point(93, 380);
            this.numberofsnowplowLabel.Name = "numberofsnowplowLabel";
            this.numberofsnowplowLabel.Size = new System.Drawing.Size(96, 32);
            this.numberofsnowplowLabel.TabIndex = 13;
            this.numberofsnowplowLabel.Text = "0";
            this.numberofsnowplowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberoftimsLabel
            // 
            this.numberoftimsLabel.Location = new System.Drawing.Point(185, 380);
            this.numberoftimsLabel.Name = "numberoftimsLabel";
            this.numberoftimsLabel.Size = new System.Drawing.Size(85, 32);
            this.numberoftimsLabel.TabIndex = 14;
            this.numberoftimsLabel.Text = "0";
            this.numberoftimsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberofhockeyLabel
            // 
            this.numberofhockeyLabel.Location = new System.Drawing.Point(266, 380);
            this.numberofhockeyLabel.Name = "numberofhockeyLabel";
            this.numberofhockeyLabel.Size = new System.Drawing.Size(127, 32);
            this.numberofhockeyLabel.TabIndex = 15;
            this.numberofhockeyLabel.Text = "0";
            this.numberofhockeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberofmooseLabel
            // 
            this.numberofmooseLabel.Location = new System.Drawing.Point(386, 380);
            this.numberofmooseLabel.Name = "numberofmooseLabel";
            this.numberofmooseLabel.Size = new System.Drawing.Size(109, 32);
            this.numberofmooseLabel.TabIndex = 16;
            this.numberofmooseLabel.Text = "0";
            this.numberofmooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mapleLeafImage
            // 
            this.mapleLeafImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapleLeafImage.Image = global::Canadian_Clicker.Properties.Resources.Maple_leaf_transparent;
            this.mapleLeafImage.Location = new System.Drawing.Point(168, 124);
            this.mapleLeafImage.Name = "mapleLeafImage";
            this.mapleLeafImage.Size = new System.Drawing.Size(165, 193);
            this.mapleLeafImage.TabIndex = 0;
            this.mapleLeafImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mapleLeafImage.Click += new System.EventHandler(this.mapleLeafImage_Click);
            // 
            // clickpowerLabel
            // 
            this.clickpowerLabel.AutoSize = true;
            this.clickpowerLabel.Location = new System.Drawing.Point(51, 223);
            this.clickpowerLabel.Name = "clickpowerLabel";
            this.clickpowerLabel.Size = new System.Drawing.Size(84, 13);
            this.clickpowerLabel.TabIndex = 17;
            this.clickpowerLabel.Text = "clickpowerLabel";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // winButton
            // 
            this.winButton.Location = new System.Drawing.Point(210, 36);
            this.winButton.Name = "winButton";
            this.winButton.Size = new System.Drawing.Size(75, 23);
            this.winButton.TabIndex = 19;
            this.winButton.Text = "Win Button";
            this.winButton.UseVisualStyleBackColor = true;
            this.winButton.Click += new System.EventHandler(this.winButton_Click);
            // 
            // costtowinLabel
            // 
            this.costtowinLabel.Location = new System.Drawing.Point(126, 9);
            this.costtowinLabel.Name = "costtowinLabel";
            this.costtowinLabel.Size = new System.Drawing.Size(240, 29);
            this.costtowinLabel.TabIndex = 20;
            this.costtowinLabel.Text = "Power: 512 and 100,000,000 extra eh?\'s to truly be Canadian";
            this.costtowinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.costtowinLabel);
            this.Controls.Add(this.winButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.clickpowerLabel);
            this.Controls.Add(this.numberofmooseLabel);
            this.Controls.Add(this.numberofhockeyLabel);
            this.Controls.Add(this.numberoftimsLabel);
            this.Controls.Add(this.numberofsnowplowLabel);
            this.Controls.Add(this.numberofiglooLabel);
            this.Controls.Add(this.buymooseriderButton);
            this.Controls.Add(this.buyhockeyplayerButton);
            this.Controls.Add(this.buytimsButton);
            this.Controls.Add(this.buysnowplowButton);
            this.Controls.Add(this.buyiglooButton);
            this.Controls.Add(this.floridianMooseRider10x);
            this.Controls.Add(this.hockeypowerupLabel);
            this.Controls.Add(this.timsMilkAndSugar2X);
            this.Controls.Add(this.powerupIglooLabel);
            this.Controls.Add(this.powerup2Xlabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.mapleLeafImage);
            this.Name = "Form1";
            this.Text = "Canadian Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mapleLeafImage;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label powerup2Xlabel;
        private System.Windows.Forms.Label powerupIglooLabel;
        private System.Windows.Forms.Label timsMilkAndSugar2X;
        private System.Windows.Forms.Label hockeypowerupLabel;
        private System.Windows.Forms.Label floridianMooseRider10x;
        private System.Windows.Forms.Button buyiglooButton;
        private System.Windows.Forms.Button buysnowplowButton;
        private System.Windows.Forms.Button buytimsButton;
        private System.Windows.Forms.Button buyhockeyplayerButton;
        private System.Windows.Forms.Button buymooseriderButton;
        private System.Windows.Forms.Label numberofiglooLabel;
        private System.Windows.Forms.Label numberofsnowplowLabel;
        private System.Windows.Forms.Label numberoftimsLabel;
        private System.Windows.Forms.Label numberofhockeyLabel;
        private System.Windows.Forms.Label numberofmooseLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clickpowerLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button winButton;
        private System.Windows.Forms.Label costtowinLabel;
    }
}

