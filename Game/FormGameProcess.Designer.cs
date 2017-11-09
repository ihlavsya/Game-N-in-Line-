namespace Game
{
    partial class FormGameProcess
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
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGameArea
            // 
            this.panelGameArea.AutoSize = true;
            this.panelGameArea.BackColor = System.Drawing.Color.White;
            this.panelGameArea.Location = new System.Drawing.Point(13, 13);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(450, 378);
            this.panelGameArea.TabIndex = 0;
            this.panelGameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGameArea_Paint);
            this.panelGameArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGameArea_MouseClick);
            // 
            // FormGameProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 403);
            this.Controls.Add(this.panelGameArea);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 442);
            this.Name = "FormGameProcess";
            this.Text = "FormGameProcess";
            this.Load += new System.EventHandler(this.FormGameProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGameArea;
    }
}