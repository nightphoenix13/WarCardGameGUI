namespace WarCardGameGUI
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.handButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel3 = new System.Windows.Forms.Label();
            this.outputLabel4 = new System.Windows.Forms.Label();
            this.outputLabel5 = new System.Windows.Forms.Label();
            this.outputLabel6 = new System.Windows.Forms.Label();
            this.outputLabel7 = new System.Windows.Forms.Label();
            this.outputLabel8 = new System.Windows.Forms.Label();
            this.outputLabel9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(233, 22);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(94, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Click to start game";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(137, 17);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // handButton
            // 
            this.handButton.Location = new System.Drawing.Point(345, 17);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(75, 23);
            this.handButton.TabIndex = 2;
            this.handButton.Text = "Play hand";
            this.handButton.UseVisualStyleBackColor = true;
            this.handButton.Visible = false;
            this.handButton.Click += new System.EventHandler(this.handButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(80, 90);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(308, 13);
            this.outputLabel1.TabIndex = 3;
            this.outputLabel1.Text = "Deal ##   Computer has name of card   Player has name of card";
            this.outputLabel1.Visible = false;
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(105, 105);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(185, 13);
            this.outputLabel2.TabIndex = 4;
            this.outputLabel2.Text = "Computer score is #  Player score is #";
            this.outputLabel2.Visible = false;
            // 
            // outputLabel3
            // 
            this.outputLabel3.AutoSize = true;
            this.outputLabel3.Location = new System.Drawing.Point(80, 120);
            this.outputLabel3.Name = "outputLabel3";
            this.outputLabel3.Size = new System.Drawing.Size(308, 13);
            this.outputLabel3.TabIndex = 5;
            this.outputLabel3.Text = "Deal ##   Computer has name of card   Player has name of card";
            this.outputLabel3.Visible = false;
            // 
            // outputLabel4
            // 
            this.outputLabel4.AutoSize = true;
            this.outputLabel4.Location = new System.Drawing.Point(105, 135);
            this.outputLabel4.Name = "outputLabel4";
            this.outputLabel4.Size = new System.Drawing.Size(185, 13);
            this.outputLabel4.TabIndex = 6;
            this.outputLabel4.Text = "Computer score is #  Player score is #";
            this.outputLabel4.Visible = false;
            // 
            // outputLabel5
            // 
            this.outputLabel5.AutoSize = true;
            this.outputLabel5.Location = new System.Drawing.Point(80, 150);
            this.outputLabel5.Name = "outputLabel5";
            this.outputLabel5.Size = new System.Drawing.Size(308, 13);
            this.outputLabel5.TabIndex = 7;
            this.outputLabel5.Text = "Deal ##   Computer has name of card   Player has name of card";
            this.outputLabel5.Visible = false;
            // 
            // outputLabel6
            // 
            this.outputLabel6.AutoSize = true;
            this.outputLabel6.Location = new System.Drawing.Point(105, 165);
            this.outputLabel6.Name = "outputLabel6";
            this.outputLabel6.Size = new System.Drawing.Size(185, 13);
            this.outputLabel6.TabIndex = 8;
            this.outputLabel6.Text = "Computer score is #  Player score is #";
            this.outputLabel6.Visible = false;
            // 
            // outputLabel7
            // 
            this.outputLabel7.AutoSize = true;
            this.outputLabel7.Location = new System.Drawing.Point(80, 180);
            this.outputLabel7.Name = "outputLabel7";
            this.outputLabel7.Size = new System.Drawing.Size(308, 13);
            this.outputLabel7.TabIndex = 9;
            this.outputLabel7.Text = "Deal ##   Computer has name of card   Player has name of card";
            this.outputLabel7.Visible = false;
            // 
            // outputLabel8
            // 
            this.outputLabel8.AutoSize = true;
            this.outputLabel8.Location = new System.Drawing.Point(105, 195);
            this.outputLabel8.Name = "outputLabel8";
            this.outputLabel8.Size = new System.Drawing.Size(185, 13);
            this.outputLabel8.TabIndex = 10;
            this.outputLabel8.Text = "Computer score is #  Player score is #";
            this.outputLabel8.Visible = false;
            // 
            // outputLabel9
            // 
            this.outputLabel9.AutoSize = true;
            this.outputLabel9.Location = new System.Drawing.Point(187, 230);
            this.outputLabel9.Name = "outputLabel9";
            this.outputLabel9.Size = new System.Drawing.Size(220, 13);
            this.outputLabel9.TabIndex = 11;
            this.outputLabel9.Text = "Computer: ##   Player: ##   Winner displayed";
            this.outputLabel9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 281);
            this.Controls.Add(this.outputLabel9);
            this.Controls.Add(this.outputLabel8);
            this.Controls.Add(this.outputLabel7);
            this.Controls.Add(this.outputLabel6);
            this.Controls.Add(this.outputLabel5);
            this.Controls.Add(this.outputLabel4);
            this.Controls.Add(this.outputLabel3);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.handButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "War Card Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button handButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputLabel3;
        private System.Windows.Forms.Label outputLabel4;
        private System.Windows.Forms.Label outputLabel5;
        private System.Windows.Forms.Label outputLabel6;
        private System.Windows.Forms.Label outputLabel7;
        private System.Windows.Forms.Label outputLabel8;
        private System.Windows.Forms.Label outputLabel9;
    }
}

