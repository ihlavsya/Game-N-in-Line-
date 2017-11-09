namespace Game
{
    partial class FormGame
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
            this.buttonStartNewGame = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartNewGame
            // 
            this.buttonStartNewGame.Location = new System.Drawing.Point(85, 72);
            this.buttonStartNewGame.Name = "buttonStartNewGame";
            this.buttonStartNewGame.Size = new System.Drawing.Size(105, 23);
            this.buttonStartNewGame.TabIndex = 0;
            this.buttonStartNewGame.Text = "Start new game";
            this.buttonStartNewGame.UseVisualStyleBackColor = true;
            this.buttonStartNewGame.Click += new System.EventHandler(this.buttonStartNewGame_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(85, 133);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(105, 23);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStartNewGame);
            this.Name = "FormGame";
            this.Text = "N in line";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartNewGame;
        private System.Windows.Forms.Button buttonSettings;
    }
}

