
namespace filmDeveloperCombinations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblPrompts = new System.Windows.Forms.Label();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRodinal = new System.Windows.Forms.Button();
            this.btnD76 = new System.Windows.Forms.Button();
            this.btnDektol = new System.Windows.Forms.Button();
            this.btnDiafine = new System.Windows.Forms.Button();
            this.btnID11 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFilmChoice = new System.Windows.Forms.PictureBox();
            this.developerUserControl1 = new filmDeveloperCombinations.userControls.developerUserControl();
            this.pboDeveloperChoice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDeveloperChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompts
            // 
            this.lblPrompts.AutoSize = true;
            this.lblPrompts.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompts.Location = new System.Drawing.Point(12, 10);
            this.lblPrompts.Name = "lblPrompts";
            this.lblPrompts.Size = new System.Drawing.Size(269, 28);
            this.lblPrompts.TabIndex = 7;
            this.lblPrompts.Text = "Next, Choose Your Developer";
            // 
            // filmDevCombinationsDataSet
            // 
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            // 
            // filmTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
          
            // btnRodinal
            // 
            this.btnRodinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRodinal.BackgroundImage")));
            this.btnRodinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRodinal.FlatAppearance.BorderSize = 0;
            this.btnRodinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRodinal.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRodinal.Location = new System.Drawing.Point(0, -33);
            this.btnRodinal.Name = "btnRodinal";
            this.btnRodinal.Size = new System.Drawing.Size(117, 169);
            this.btnRodinal.TabIndex = 0;
            this.btnRodinal.Tag = "1";
            this.btnRodinal.Text = "Rodinal";
            this.btnRodinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRodinal.UseVisualStyleBackColor = true;
            this.btnRodinal.Click += new System.EventHandler(this.btnDeveloperChoice_Click);
            this.btnRodinal.MouseHover += new System.EventHandler(this.btnDeveloperChoice_Hover);
            // 
            // btnD76
            // 
            this.btnD76.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnD76.BackgroundImage")));
            this.btnD76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD76.FlatAppearance.BorderSize = 0;
            this.btnD76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD76.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnD76.Location = new System.Drawing.Point(123, -30);
            this.btnD76.Name = "btnD76";
            this.btnD76.Size = new System.Drawing.Size(129, 166);
            this.btnD76.TabIndex = 1;
            this.btnD76.Tag = "2";
            this.btnD76.Text = "D-76";
            this.btnD76.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnD76.UseVisualStyleBackColor = true;
            this.btnD76.Click += new System.EventHandler(this.btnDeveloperChoice_Click);
            this.btnD76.MouseHover += new System.EventHandler(this.btnDeveloperChoice_Hover);
            // 
            // btnDektol
            // 
            this.btnDektol.BackColor = System.Drawing.Color.Transparent;
            this.btnDektol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDektol.BackgroundImage")));
            this.btnDektol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDektol.FlatAppearance.BorderSize = 0;
            this.btnDektol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDektol.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDektol.Location = new System.Drawing.Point(258, -33);
            this.btnDektol.Name = "btnDektol";
            this.btnDektol.Size = new System.Drawing.Size(137, 169);
            this.btnDektol.TabIndex = 2;
            this.btnDektol.Tag = "3";
            this.btnDektol.Text = "Dektol";
            this.btnDektol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDektol.UseVisualStyleBackColor = false;
            this.btnDektol.Click += new System.EventHandler(this.btnDeveloperChoice_Click);
            this.btnDektol.MouseHover += new System.EventHandler(this.btnDeveloperChoice_Hover);
            // 
            // btnDiafine
            // 
            this.btnDiafine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiafine.BackgroundImage")));
            this.btnDiafine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiafine.FlatAppearance.BorderSize = 0;
            this.btnDiafine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiafine.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDiafine.Location = new System.Drawing.Point(401, -17);
            this.btnDiafine.Name = "btnDiafine";
            this.btnDiafine.Size = new System.Drawing.Size(145, 153);
            this.btnDiafine.TabIndex = 3;
            this.btnDiafine.Tag = "4";
            this.btnDiafine.Text = "Diafine";
            this.btnDiafine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiafine.UseVisualStyleBackColor = true;
            this.btnDiafine.Click += new System.EventHandler(this.btnDeveloperChoice_Click);
            this.btnDiafine.MouseHover += new System.EventHandler(this.btnDeveloperChoice_Hover);
            // 
            // btnID11
            // 
            this.btnID11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnID11.BackgroundImage")));
            this.btnID11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnID11.FlatAppearance.BorderSize = 0;
            this.btnID11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnID11.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnID11.Location = new System.Drawing.Point(552, -17);
            this.btnID11.Name = "btnID11";
            this.btnID11.Size = new System.Drawing.Size(125, 153);
            this.btnID11.TabIndex = 4;
            this.btnID11.Tag = "5";
            this.btnID11.Text = "ID-11";
            this.btnID11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnID11.UseVisualStyleBackColor = true;
            this.btnID11.Click += new System.EventHandler(this.btnDeveloperChoice_Click);
            this.btnID11.MouseHover += new System.EventHandler(this.btnDeveloperChoice_Hover);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(645, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPrompts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 40);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnRodinal);
            this.panel2.Controls.Add(this.btnD76);
            this.panel2.Controls.Add(this.btnDektol);
            this.panel2.Controls.Add(this.btnDiafine);
            this.panel2.Controls.Add(this.btnID11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 136);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 22);
            this.panel1.TabIndex = 11;
            // 
            // pbFilmChoice
            // 
            this.pbFilmChoice.BackColor = System.Drawing.Color.Transparent;
            this.pbFilmChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbFilmChoice.InitialImage = null;
            this.pbFilmChoice.Location = new System.Drawing.Point(0, 22);
            this.pbFilmChoice.Name = "pbFilmChoice";
            this.pbFilmChoice.Size = new System.Drawing.Size(141, 125);
            this.pbFilmChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilmChoice.TabIndex = 8;
            this.pbFilmChoice.TabStop = false;
            this.pbFilmChoice.WaitOnLoad = true;
            // 
            // developerUserControl1
            // 
            this.developerUserControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.developerUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("developerUserControl1.BackgroundImage")));
            this.developerUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.developerUserControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.developerUserControl1.Location = new System.Drawing.Point(0, 22);
            this.developerUserControl1.Name = "developerUserControl1";
            this.developerUserControl1.Size = new System.Drawing.Size(677, 125);
            this.developerUserControl1.TabIndex = 14;
            // 
            // pboDeveloperChoice
            // 
            this.pboDeveloperChoice.BackColor = System.Drawing.Color.Transparent;
            this.pboDeveloperChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pboDeveloperChoice.InitialImage = null;
            this.pboDeveloperChoice.Location = new System.Drawing.Point(536, 22);
            this.pboDeveloperChoice.Name = "pboDeveloperChoice";
            this.pboDeveloperChoice.Size = new System.Drawing.Size(141, 125);
            this.pboDeveloperChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboDeveloperChoice.TabIndex = 15;
            this.pboDeveloperChoice.TabStop = false;
            this.pboDeveloperChoice.WaitOnLoad = true;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.pboDeveloperChoice);
            this.Controls.Add(this.pbFilmChoice);
            this.Controls.Add(this.developerUserControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Choose Developer";
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDeveloperChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrompts;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.Button btnRodinal;
        private System.Windows.Forms.Button btnD76;
        private System.Windows.Forms.Button btnDektol;
        private System.Windows.Forms.Button btnDiafine;
        private System.Windows.Forms.Button btnID11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private userControls.developerUserControl developerUserControl1;
        private System.Windows.Forms.PictureBox pbFilmChoice;
        private System.Windows.Forms.PictureBox pboDeveloperChoice;
    }
}