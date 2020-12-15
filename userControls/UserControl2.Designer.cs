
namespace filmDeveloperCombinations.userControls
{
    partial class developerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(developerUserControl));
            this.lblDevChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDevChoice
            // 
            this.lblDevChoice.AutoSize = true;
            this.lblDevChoice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDevChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDevChoice.Font = new System.Drawing.Font("Romantic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblDevChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDevChoice.Location = new System.Drawing.Point(557, 53);
            this.lblDevChoice.Name = "lblDevChoice";
            this.lblDevChoice.Size = new System.Drawing.Size(73, 16);
            this.lblDevChoice.TabIndex = 2;
            this.lblDevChoice.Text = "Developer";
            // 
            // developerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lblDevChoice);
            this.Name = "developerUserControl";
            this.Size = new System.Drawing.Size(667, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDevChoice;
    }
}
