using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeNumbersAlgorithms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void TrueAlgsButton_Click(object sender, EventArgs e)
        {
            var TrueTestsMenu = new TrueTestsMenu();
            TrueTestsMenu.Show();
        }

        private void ProbAlgsButton_Click(object sender, EventArgs e)
        {
            var probTests = new TestFerma.ProbTests();
            probTests.Show();
        }
    }
}
