namespace filmDeveloperCombinations
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
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFomapan = new System.Windows.Forms.Button();
            this.btnAcros = new System.Windows.Forms.Button();
            this.btnHp5 = new System.Windows.Forms.Button();
            this.btnShanghai = new System.Windows.Forms.Button();
            this.btnDelta = new System.Windows.Forms.Button();
            this.btnTrix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrompts = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl11 = new filmDeveloperCombinations.userControls.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
           
            // btnFomapan
            // 
            this.btnFomapan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFomapan.BackgroundImage")));
            this.btnFomapan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFomapan.FlatAppearance.BorderSize = 0;
            this.btnFomapan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFomapan.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFomapan.Location = new System.Drawing.Point(3, -16);
            this.btnFomapan.Name = "btnFomapan";
            this.btnFomapan.Size = new System.Drawing.Size(105, 153);
            this.btnFomapan.TabIndex = 0;
            this.btnFomapan.Tag = "1";
            this.btnFomapan.Text = "Fomapan";
            this.btnFomapan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFomapan.UseVisualStyleBackColor = true;
            this.btnFomapan.Click += new System.EventHandler(this.btnFilmChoice_Click);
            // 
            // btnAcros
            // 
            this.btnAcros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcros.BackgroundImage")));
            this.btnAcros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcros.FlatAppearance.BorderSize = 0;
            this.btnAcros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcros.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAcros.Location = new System.Drawing.Point(108, -16);
            this.btnAcros.Name = "btnAcros";
            this.btnAcros.Size = new System.Drawing.Size(105, 153);
            this.btnAcros.TabIndex = 1;
            this.btnAcros.Tag = "2";
            this.btnAcros.Text = "Acros";
            this.btnAcros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcros.UseVisualStyleBackColor = true;
            this.btnAcros.Click += new System.EventHandler(this.btnFilmChoice_Click);
            // 
            // btnHp5
            // 
            this.btnHp5.BackColor = System.Drawing.Color.Transparent;
            this.btnHp5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHp5.BackgroundImage")));
            this.btnHp5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHp5.FlatAppearance.BorderSize = 0;
            this.btnHp5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHp5.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHp5.Location = new System.Drawing.Point(213, -16);
            this.btnHp5.Name = "btnHp5";
            this.btnHp5.Size = new System.Drawing.Size(125, 153);
            this.btnHp5.TabIndex = 2;
            this.btnHp5.Tag = "3";
            this.btnHp5.Text = "HP5+";
            this.btnHp5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHp5.UseVisualStyleBackColor = false;
            this.btnHp5.Click += new System.EventHandler(this.btnFilmChoice_Click);
            // 
            // btnShanghai
            // 
            this.btnShanghai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShanghai.BackgroundImage")));
            this.btnShanghai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShanghai.FlatAppearance.BorderSize = 0;
            this.btnShanghai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShanghai.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShanghai.Location = new System.Drawing.Point(338, -16);
            this.btnShanghai.Name = "btnShanghai";
            this.btnShanghai.Size = new System.Drawing.Size(145, 153);
            this.btnShanghai.TabIndex = 3;
            this.btnShanghai.Tag = "4";
            this.btnShanghai.Text = "Shanghai GP3";
            this.btnShanghai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShanghai.UseVisualStyleBackColor = true;
            this.btnShanghai.Click += new System.EventHandler(this.btnFilmChoice_Click);
            // 
            // btnDelta
            // 
            this.btnDelta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelta.BackgroundImage")));
            this.btnDelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelta.FlatAppearance.BorderSize = 0;
            this.btnDelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelta.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelta.Location = new System.Drawing.Point(483, -16);
            this.btnDelta.Name = "btnDelta";
            this.btnDelta.Size = new System.Drawing.Size(99, 153);
            this.btnDelta.TabIndex = 4;
            this.btnDelta.Tag = "5";
            this.btnDelta.Text = "Delta 100";
            this.btnDelta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelta.UseVisualStyleBackColor = true;
            this.btnDelta.Click += new System.EventHandler(this.btnFilmChoice_Click);
            // 
            // btnTrix
            // 
            this.btnTrix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrix.BackgroundImage")));
            this.btnTrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrix.FlatAppearance.BorderSize = 0;
            this.btnTrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrix.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTrix.Location = new System.Drawing.Point(582, -16);
            this.btnTrix.Name = "btnTrix";
            this.btnTrix.Size = new System.Drawing.Size(108, 153);
            this.btnTrix.TabIndex = 5;
            this.btnTrix.Tag = "6";
            this.btnTrix.Text = "Tri-X";
            this.btnTrix.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrix.UseVisualStyleBackColor = true;
            this.btnTrix.Click += new System.EventHandler(this.btnFilmChoice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(661, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 22);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnFomapan);
            this.panel2.Controls.Add(this.btnAcros);
            this.panel2.Controls.Add(this.btnHp5);
            this.panel2.Controls.Add(this.btnTrix);
            this.panel2.Controls.Add(this.btnShanghai);
            this.panel2.Controls.Add(this.btnDelta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 136);
            this.panel2.TabIndex = 8;
            // 
            // lblPrompts
            // 
            this.lblPrompts.AutoSize = true;
            this.lblPrompts.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompts.Location = new System.Drawing.Point(12, 10);
            this.lblPrompts.Name = "lblPrompts";
            this.lblPrompts.Size = new System.Drawing.Size(220, 28);
            this.lblPrompts.TabIndex = 7;
            this.lblPrompts.Text = "First, Choose Your Film";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPrompts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 40);
            this.panel3.TabIndex = 9;
            // 
            // userControl11
            // 
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Font = new System.Drawing.Font("Romantic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.userControl11.Location = new System.Drawing.Point(0, 22);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(693, 164);
            this.userControl11.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(693, 362);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Film Development Guide";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrompts;
        private System.Windows.Forms.Panel panel3;
        private userControls.UserControl1 userControl11;
        public System.Windows.Forms.Button btnFomapan;
        public System.Windows.Forms.Button btnAcros;
        public System.Windows.Forms.Button btnHp5;
        public System.Windows.Forms.Button btnShanghai;
        public System.Windows.Forms.Button btnDelta;
        public System.Windows.Forms.Button btnTrix;
    }
}

