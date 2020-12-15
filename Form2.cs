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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            int filmID = Form1.filmID;
            int filmIndex = filmID - 1;
            pbFilmChoice.Image = Image.FromFile(Application.StartupPath + "//images//films//" + films[filmIndex]);
            pbFilmChoice.Show();
        }

        public static int developerID;

        public static string[] films = new string[6] { "fomapan.jpg", "acros.jpg", "hp5.jpg",
            "shanghai100.jpg", "delta100.jpg", "triX.jpg" };
        public static string[] developers = new string[5] { "rodinal.png", "d76.jpeg", "dektol.jpg",
            "diafine.jpg", "id11.jpg" };

        private void btnDeveloperChoice_Click(object sender, EventArgs e)
        {
            Button developerSelectionButton = sender as Button;
            developerID = Convert.ToInt32(developerSelectionButton.Tag);
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnDeveloperChoice_Hover(object sender, EventArgs e)
        {
            Button hoverDeveloper = sender as Button;
            developerID = Convert.ToInt32(hoverDeveloper.Tag);
            int developerIndex = developerID - 1;
            pboDeveloperChoice.Image = Image.FromFile(Application.StartupPath + "//images//developers//" + developers[developerIndex]);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
