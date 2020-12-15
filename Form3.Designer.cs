
namespace filmDeveloperCombinations
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label devIDLabel;
            System.Windows.Forms.Label filmIDLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label developerLabel;
            System.Windows.Forms.Label filmNameLabel;
            System.Windows.Forms.Label isoLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label standardDilutionLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pbFilmChoice = new System.Windows.Forms.PictureBox();
            this.pbDeveloperChoice = new System.Windows.Forms.PictureBox();
            this.filmDevCombinationsDataSet1 = new filmDeveloperCombinations.filmDevCombinationsDataSet1();
            this.combinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinationsTableAdapter = new filmDeveloperCombinations.filmDevCombinationsDataSet1TableAdapters.combinationsTableAdapter();
            this.tableAdapterManager = new filmDeveloperCombinations.filmDevCombinationsDataSet1TableAdapters.TableAdapterManager();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new filmDeveloperCombinations.filmDevCombinationsDataSet1TableAdapters.developerTableAdapter();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new filmDeveloperCombinations.filmDevCombinationsDataSet1TableAdapters.filmTableAdapter();
            this.devIDLabel1 = new System.Windows.Forms.Label();
            this.filmIDLabel1 = new System.Windows.Forms.Label();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.developerLabel1 = new System.Windows.Forms.Label();
            this.filmNameLabel1 = new System.Windows.Forms.Label();
            this.isoLabel1 = new System.Windows.Forms.Label();
            this.notesLabel1 = new System.Windows.Forms.Label();
            this.standardDilutionLabel1 = new System.Windows.Forms.Label();
            devIDLabel = new System.Windows.Forms.Label();
            filmIDLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            developerLabel = new System.Windows.Forms.Label();
            filmNameLabel = new System.Windows.Forms.Label();
            isoLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            standardDilutionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeveloperChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmDevCombinationsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(630, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 22);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 22);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(650, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 22);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbFilmChoice
            // 
            this.pbFilmChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFilmChoice.Location = new System.Drawing.Point(12, 45);
            this.pbFilmChoice.Name = "pbFilmChoice";
            this.pbFilmChoice.Size = new System.Drawing.Size(143, 100);
            this.pbFilmChoice.TabIndex = 13;
            this.pbFilmChoice.TabStop = false;
            // 
            // pbDeveloperChoice
            // 
            this.pbDeveloperChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDeveloperChoice.Location = new System.Drawing.Point(12, 184);
            this.pbDeveloperChoice.Name = "pbDeveloperChoice";
            this.pbDeveloperChoice.Size = new System.Drawing.Size(143, 100);
            this.pbDeveloperChoice.TabIndex = 14;
            this.pbDeveloperChoice.TabStop = false;
            // 
            // filmDevCombinationsDataSet1
            // 
            this.filmDevCombinationsDataSet1.DataSetName = "filmDevCombinationsDataSet1";
            this.filmDevCombinationsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combinationsBindingSource
            // 
            this.combinationsBindingSource.DataMember = "combinations";
            this.combinationsBindingSource.DataSource = this.filmDevCombinationsDataSet1;
            // 
            // combinationsTableAdapter
            // 
            this.combinationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.combinationsTableAdapter = this.combinationsTableAdapter;
            this.tableAdapterManager.developerTableAdapter = this.developerTableAdapter;
            this.tableAdapterManager.filmTableAdapter = this.filmTableAdapter;
            this.tableAdapterManager.UpdateOrder = filmDeveloperCombinations.filmDevCombinationsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "developer";
            this.developerBindingSource.DataSource = this.filmDevCombinationsDataSet1;
            // 
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            this.filmBindingSource.DataSource = this.filmDevCombinationsDataSet1;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // devIDLabel
            // 
            devIDLabel.AutoSize = true;
            devIDLabel.Location = new System.Drawing.Point(290, 66);
            devIDLabel.Name = "devIDLabel";
            devIDLabel.Size = new System.Drawing.Size(42, 13);
            devIDLabel.TabIndex = 14;
            devIDLabel.Text = "dev ID:";
            // 
            // devIDLabel1
            // 
            this.devIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinationsBindingSource, "devID", true));
            this.devIDLabel1.Location = new System.Drawing.Point(338, 66);
            this.devIDLabel1.Name = "devIDLabel1";
            this.devIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.devIDLabel1.TabIndex = 15;
            this.devIDLabel1.Text = "label1";
            // 
            // filmIDLabel
            // 
            filmIDLabel.AutoSize = true;
            filmIDLabel.Location = new System.Drawing.Point(290, 102);
            filmIDLabel.Name = "filmIDLabel";
            filmIDLabel.Size = new System.Drawing.Size(39, 13);
            filmIDLabel.TabIndex = 15;
            filmIDLabel.Text = "film ID:";
            // 
            // filmIDLabel1
            // 
            this.filmIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinationsBindingSource, "filmID", true));
            this.filmIDLabel1.Location = new System.Drawing.Point(335, 102);
            this.filmIDLabel1.Name = "filmIDLabel1";
            this.filmIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.filmIDLabel1.TabIndex = 16;
            this.filmIDLabel1.Text = "label1";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(290, 132);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(29, 13);
            timeLabel.TabIndex = 16;
            timeLabel.Text = "time:";
            // 
            // timeLabel1
            // 
            this.timeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinationsBindingSource, "time", true));
            this.timeLabel1.Location = new System.Drawing.Point(325, 132);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(100, 23);
            this.timeLabel1.TabIndex = 17;
            this.timeLabel1.Text = "label1";
            // 
            // developerLabel
            // 
            developerLabel.AutoSize = true;
            developerLabel.Location = new System.Drawing.Point(30, 301);
            developerLabel.Name = "developerLabel";
            developerLabel.Size = new System.Drawing.Size(57, 13);
            developerLabel.TabIndex = 18;
            developerLabel.Text = "developer:";
            // 
            // developerLabel1
            // 
            this.developerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "developer", true));
            this.developerLabel1.Location = new System.Drawing.Point(93, 301);
            this.developerLabel1.Name = "developerLabel1";
            this.developerLabel1.Size = new System.Drawing.Size(100, 23);
            this.developerLabel1.TabIndex = 19;
            this.developerLabel1.Text = "label1";
            // 
            // filmNameLabel
            // 
            filmNameLabel.AutoSize = true;
            filmNameLabel.Location = new System.Drawing.Point(22, 154);
            filmNameLabel.Name = "filmNameLabel";
            filmNameLabel.Size = new System.Drawing.Size(56, 13);
            filmNameLabel.TabIndex = 20;
            filmNameLabel.Text = "film Name:";
            // 
            // filmNameLabel1
            // 
            this.filmNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "filmName", true));
            this.filmNameLabel1.Location = new System.Drawing.Point(84, 154);
            this.filmNameLabel1.Name = "filmNameLabel1";
            this.filmNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.filmNameLabel1.TabIndex = 21;
            this.filmNameLabel1.Text = "label1";
            // 
            // isoLabel
            // 
            isoLabel.AutoSize = true;
            isoLabel.Location = new System.Drawing.Point(291, 204);
            isoLabel.Name = "isoLabel";
            isoLabel.Size = new System.Drawing.Size(23, 13);
            isoLabel.TabIndex = 21;
            isoLabel.Text = "iso:";
            // 
            // isoLabel1
            // 
            this.isoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "iso", true));
            this.isoLabel1.Location = new System.Drawing.Point(320, 204);
            this.isoLabel1.Name = "isoLabel1";
            this.isoLabel1.Size = new System.Drawing.Size(100, 23);
            this.isoLabel1.TabIndex = 22;
            this.isoLabel1.Text = "label1";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(294, 246);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(36, 13);
            notesLabel.TabIndex = 22;
            notesLabel.Text = "notes:";
            // 
            // notesLabel1
            // 
            this.notesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "notes", true));
            this.notesLabel1.Location = new System.Drawing.Point(336, 246);
            this.notesLabel1.Name = "notesLabel1";
            this.notesLabel1.Size = new System.Drawing.Size(100, 23);
            this.notesLabel1.TabIndex = 23;
            this.notesLabel1.Text = "label1";
            // 
            // standardDilutionLabel
            // 
            standardDilutionLabel.AutoSize = true;
            standardDilutionLabel.Location = new System.Drawing.Point(240, 165);
            standardDilutionLabel.Name = "standardDilutionLabel";
            standardDilutionLabel.Size = new System.Drawing.Size(89, 13);
            standardDilutionLabel.TabIndex = 23;
            standardDilutionLabel.Text = "standard Dilution:";
            // 
            // standardDilutionLabel1
            // 
            this.standardDilutionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "standardDilution", true));
            this.standardDilutionLabel1.Location = new System.Drawing.Point(393, 165);
            this.standardDilutionLabel1.Name = "standardDilutionLabel1";
            this.standardDilutionLabel1.Size = new System.Drawing.Size(100, 23);
            this.standardDilutionLabel1.TabIndex = 24;
            this.standardDilutionLabel1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 344);
            this.Controls.Add(standardDilutionLabel);
            this.Controls.Add(this.standardDilutionLabel1);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesLabel1);
            this.Controls.Add(isoLabel);
            this.Controls.Add(this.isoLabel1);
            this.Controls.Add(filmNameLabel);
            this.Controls.Add(this.filmNameLabel1);
            this.Controls.Add(developerLabel);
            this.Controls.Add(this.developerLabel1);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeLabel1);
            this.Controls.Add(filmIDLabel);
            this.Controls.Add(this.filmIDLabel1);
            this.Controls.Add(devIDLabel);
            this.Controls.Add(this.devIDLabel1);
            this.Controls.Add(this.pbDeveloperChoice);
            this.Controls.Add(this.pbFilmChoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeveloperChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmDevCombinationsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbFilmChoice;
        private System.Windows.Forms.PictureBox pbDeveloperChoice;
        private filmDevCombinationsDataSet1 filmDevCombinationsDataSet1;
        private System.Windows.Forms.BindingSource combinationsBindingSource;
        private filmDevCombinationsDataSet1TableAdapters.combinationsTableAdapter combinationsTableAdapter;
        private filmDevCombinationsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private filmDevCombinationsDataSet1TableAdapters.developerTableAdapter developerTableAdapter;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private filmDevCombinationsDataSet1TableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.Label devIDLabel1;
        private System.Windows.Forms.Label filmIDLabel1;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Label developerLabel1;
        private System.Windows.Forms.Label filmNameLabel1;
        private System.Windows.Forms.Label isoLabel1;
        private System.Windows.Forms.Label notesLabel1;
        private System.Windows.Forms.Label standardDilutionLabel1;
    }
}