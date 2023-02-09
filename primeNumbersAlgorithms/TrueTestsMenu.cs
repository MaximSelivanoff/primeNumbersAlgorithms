using System;
using System.Windows.Forms;

namespace primeNumbersAlgorithms
{
    public partial class TrueTestsMenu : Form
    {
        public TrueTestsMenu()
        {
            InitializeComponent();
        }

        private void AtkinButton_Click(object sender, EventArgs e)
        {
            var AtkinForm = new Sieve_of_Atkin.Form1();
            AtkinForm.Show();
        }

        private void EratosphenButton_Click(object sender, EventArgs e)
        {
            var EratosphForm = new Sieve_of_Eratosthenes.Sieve_of_Eratosthenes();
            EratosphForm.Show();
        }
    }
}
