namespace Play_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playGameButton = new System.Windows.Forms.Button();
            this.startingGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playGameButton.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.ForeColor = System.Drawing.Color.White;
            this.playGameButton.Location = new System.Drawing.Point(122, 72);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(218, 93);
            this.playGameButton.TabIndex = 0;
            this.playGameButton.Text = "Press To Play Game";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // startingGameLabel
            // 
            this.startingGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.startingGameLabel.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingGameLabel.Location = new System.Drawing.Point(122, 178);
            this.startingGameLabel.Name = "startingGameLabel";
            this.startingGameLabel.Size = new System.Drawing.Size(218, 51);
            this.startingGameLabel.TabIndex = 1;
            this.startingGameLabel.Text = "Starting in 3...";
            this.startingGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(475, 391);
            this.Controls.Add(this.startingGameLabel);
            this.Controls.Add(this.playGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Play Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Label startingGameLabel;
    }
}

