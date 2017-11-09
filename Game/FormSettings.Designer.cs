namespace Game
{
    partial class FormSettings
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
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.labelN = new System.Windows.Forms.Label();
            this.colorDialogUser = new System.Windows.Forms.ColorDialog();
            this.buttonUserChoose = new System.Windows.Forms.Button();
            this.buttonBotChoose = new System.Windows.Forms.Button();
            this.colorDialogBot = new System.Windows.Forms.ColorDialog();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarN
            // 
            this.trackBarN.Location = new System.Drawing.Point(75, 80);
            this.trackBarN.Maximum = 7;
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(137, 45);
            this.trackBarN.TabIndex = 0;
            this.trackBarN.ValueChanged += new System.EventHandler(this.trackBarN_ValueChanged);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(93, 52);
            this.labelN.MaximumSize = new System.Drawing.Size(100, 13);
            this.labelN.MinimumSize = new System.Drawing.Size(100, 13);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(100, 13);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "Choose N in line";
            // 
            // colorDialogUser
            // 
            this.colorDialogUser.AnyColor = true;
            this.colorDialogUser.FullOpen = true;
            this.colorDialogUser.SolidColorOnly = true;
            // 
            // buttonUserChoose
            // 
            this.buttonUserChoose.Location = new System.Drawing.Point(75, 131);
            this.buttonUserChoose.Name = "buttonUserChoose";
            this.buttonUserChoose.Size = new System.Drawing.Size(126, 23);
            this.buttonUserChoose.TabIndex = 2;
            this.buttonUserChoose.Text = "Choose color for you";
            this.buttonUserChoose.UseVisualStyleBackColor = true;
            this.buttonUserChoose.Click += new System.EventHandler(this.buttonUserSubmit_Click);
            // 
            // buttonBotChoose
            // 
            this.buttonBotChoose.Location = new System.Drawing.Point(75, 175);
            this.buttonBotChoose.Name = "buttonBotChoose";
            this.buttonBotChoose.Size = new System.Drawing.Size(126, 23);
            this.buttonBotChoose.TabIndex = 3;
            this.buttonBotChoose.Text = "Choose color for bot";
            this.buttonBotChoose.UseVisualStyleBackColor = true;
            this.buttonBotChoose.Click += new System.EventHandler(this.buttonBotChoose_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(75, 226);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(126, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonBotChoose);
            this.Controls.Add(this.buttonUserChoose);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.trackBarN);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.ColorDialog colorDialogUser;
        private System.Windows.Forms.Button buttonUserChoose;
        private System.Windows.Forms.Button buttonBotChoose;
        private System.Windows.Forms.ColorDialog colorDialogBot;
        private System.Windows.Forms.Button buttonSubmit;
    }
}