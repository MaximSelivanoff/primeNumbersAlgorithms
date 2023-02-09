using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;


namespace Sieve_of_Atkin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class AtkinSieve
        {
            public static BitArray GetPrimesUpTo(int number)
            {
                BitArray sieve = new BitArray(number + 1);
                //просеивание
                for (long x2 = 1, dx2 = 3; x2 < number; x2 += dx2, dx2 += 2)
                    for (long y2 = 1, dy2 = 3, n; y2 < number; y2 += dy2, dy2 += 2)
                    {
                        n = (x2 << 2) + y2;
                        if (n <= number && (n % 12 == 1 || n % 12 == 5))
                            sieve[(int)n] ^= true;
                        n -= x2;
                        if (n <= number && n % 12 == 7)
                            sieve[(int)n] ^= true;
                        // n = 3x² - y²
                        if (x2 > y2)
                        {
                            n -= y2 << 1;
                            if (n <= number && n % 12 == 11)
                                sieve[(int)n] ^= true;
                        }
                    }
                // Все числа, кратные квадратам, помечаются как составные
                int r = 5;
                for (long r2 = r * r, dr2 = (r << 1) + 1; r2 < number; ++r, r2 += dr2, dr2 += 2)
                    if (sieve[r])
                        for (long mr2 = r2; mr2 < number; mr2 += r2)
                            sieve[(int)mr2] = false;
                // Числа 2 и 3 — заведомо простые
                if (number > 2)
                    sieve[2] = true;
                if (number > 3)
                    sieve[3] = true;
                return sieve;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox1.Text);
            var primes = AtkinSieve.GetPrimesUpTo(limit);
            StreamWriter file_in = new StreamWriter("Text.txt");
            for (int i = 2; i < limit; i++)
            {
                if (primes[i])
                    file_in.Write(i + " ");
            }
            file_in.Close();
            StreamReader file_from = new StreamReader("Text.txt");
            textBox2.Text = file_from.ReadToEnd();
            file_from.Close();
        }
    }
}
