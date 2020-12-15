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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int filmID;

        private void filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmDevCombinationsDataSet.film' table. You can move, or remove it, as needed.

        }

        private void btnFilmChoice_Click(object sender, EventArgs e)
        {
            Button filmSelectionButton = sender as Button;
            filmID = Convert.ToInt32(filmSelectionButton.Tag);
            Form2 f2 = new Form2();
            f2.Show();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
