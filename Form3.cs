using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmDeveloperCombinations
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string filmID = Convert.ToString(Form1.filmID);
            string developerID = Convert.ToString(Form2.developerID);
            int combinationTableKey = Convert.ToInt32(filmID + developerID);
            pbFilmChoice.Image = Image.FromFile(Application.StartupPath + "//images//developers//" + Form2.developers[(Form2.developerID - 1)]);
            pbDeveloperChoice.Image = Image.FromFile(Application.StartupPath + "//images//developers//" + Form2.developers[(Form2.developerID - 1)]);

            string selectStatment = "SELECT time "
                + "FROM combinations";
         
        }

        private void combinationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.combinationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.filmDevCombinationsDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmDevCombinationsDataSet1.film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.filmDevCombinationsDataSet1.film);
            // TODO: This line of code loads data into the 'filmDevCombinationsDataSet1.developer' table. You can move, or remove it, as needed.
            this.developerTableAdapter.Fill(this.filmDevCombinationsDataSet1.developer);
            // TODO: This line of code loads data into the 'filmDevCombinationsDataSet1.combinations' table. You can move, or remove it, as needed.
            this.combinationsTableAdapter.Fill(this.filmDevCombinationsDataSet1.combinations);
            MessageBox.Show(combinationsTableAdapter.ToString());
        }
    }
}
