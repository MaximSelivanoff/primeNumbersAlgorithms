using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFerma
{
    public partial class ProbTests : Form
    {
        Random rnd;
        BigInteger number;
        int generation_size;
        public ProbTests()
        {
            InitializeComponent();
            rnd = new Random();
            listBox1.SetSelected(0, true);
            generation_size = int.Parse(listBox1.SelectedItem.ToString());

        }
        BigInteger GenerateBigInt(int size = 512)
        {
            BigInteger Decimalvalue = 0;
            while (Decimalvalue < 1)
            {
                int lenght = size;
                List<string> raw = Enumerable.Repeat("0", lenght / 2).ToList();
                raw.AddRange(Enumerable.Repeat("1", lenght - raw.Count));

                string result = "";
                for (int i = raw.Count; i > 0; --i)
                {
                    int index = rnd.Next(0, raw.Count);
                    result += raw[index];
                    raw.RemoveAt(index);
                }
                Decimalvalue = 0;
                foreach (char c in result)
                {
                    Decimalvalue <<= 1;
                    Decimalvalue += c == '1' ? 1 : 0;
                }
            }
            return Decimalvalue;
        }
        public bool TestFerma(BigInteger number, int bitNumber)
        {
            if (number == 2 || number == 3)
                return true;
            if (number < 2 || number % 2 == 0)
                return false;
            bool result = true;
            if (bitNumber == 0) 
                bitNumber = CountBits(number);
            for (BigInteger i = 0; i <= bitNumber; ++i)
            {
                BigInteger a;
                do
                    a = GenerateBigInt(CountBits(number)) % number;
                while (a < 2 || a > number - 1); 
                if (BigInteger.GreatestCommonDivisor(a, number) != 1) 
                    continue;
                if (ModPow(a, number - 1, number) != 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public bool MillerRabinTest(BigInteger n, int k)
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            // представим n − 1 в виде (2^s)·t
            BigInteger t = n - 1;
            int s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }
            for (int i = 0; i < k; i++) 
            {
                byte[] _a = new byte[n.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    rnd.NextBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);
                BigInteger x = ModPow(a, t, n);
                if (x == 1 || x == n - 1)
                    continue;
                for (int r = 1; r < s; r++)
                {
                    x = ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }
                if (x != n - 1)
                    return false;
            }
            return true;
        }
        public int Jacobian(BigInteger a, BigInteger b)
        {
            if (BigInteger.GreatestCommonDivisor(a, b) != 1)
                return 0;
            int r = 1;
            if (a < 0)
            {
                a = -a;
                if (b % 4 == 3)
                    r = -r;
            }
            while (a != 0)
            {
                int t = 0;
                while (a % 2 == 0)
                {
                    t++;
                    a = a / 2;
                }
                if (t % 2 == 1 && (b % 8 == 3 || b % 8 == 5))
                    r = -r;
                if (a % 4 == b % 4 && a % 4 == 3)
                    r = -r;
                BigInteger c = a;
                a = b % c;
                b = c;
            }
            return r;
            }
        public bool SolovayStrassenTest(BigInteger n, int k)
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            for (int i = 1; i < k; i++)
            {
                BigInteger a;
                do
                    a = GenerateBigInt(CountBits(n)) % n;
                while (a < 2 || a > n - 1);
                if (BigInteger.GreatestCommonDivisor(a, n) != 1)
                    return false;
                if (ModPow(a, (n - 1) / 2, n) != (Jacobian(a, n) + n) % n)
                    return false;
            }
            return true;
        }

        public string ToBinaryString(BigInteger bigint)
        {
            var bytes = bigint.ToByteArray();
            var idx = bytes.Length - 1;
            var base2 = new StringBuilder(bytes.Length * 8);
            var binary = Convert.ToString(bytes[idx], 2);
            if (binary[0] != '0' && bigint.Sign == 1)
            {
                base2.Append('0');
            }
            base2.Append(binary);
            for (idx--; idx >= 0; idx--)
            {
                base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));
            }

            return base2.ToString();
        }
        public int CountBits(BigInteger number)
        {
            int count = 0;
            while (number != 0)
            {
                number >>= 1;
                count++;
            }
            return count;
        }
        private BigInteger ModPow(BigInteger number, BigInteger exponent, BigInteger modulus)
        {
            BigInteger B, D;
            B = number;
            B %= modulus;
            D = 1;
            if ((exponent & 1) == 1)
            {
                D = B;
            }
            while (exponent > 1)
            {
                exponent >>= 1;
                B = (B * B) % modulus;
                if ((exponent & 1) == 1)
                {
                    D = (D * B) % modulus;
                }
            }
            return D;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (Bits_Text_Box.Text != "")
            {
                generation_size = int.Parse(Bits_Text_Box.Text);
                if (generation_size < 5)
                    generation_size = 5;
                Bits_Text_Box.Text = generation_size.ToString();
            }
            do
            {
                number = GenerateBigInt(generation_size);
            }
            while (!SolovayStrassenTest(number, (int)BigInteger.Log(number, 2)));
            Ferma_TextBox.Text = number.ToString();
            Miller_TextBox.Text = number.ToString();
            Solovay_TextBox.Text = number.ToString();
        }
        private void check_Click(object sender, EventArgs e)
        {
            if (Ferma_TextBox.Text == "" || Ferma_TextBox.Text == "1")
                return;
            BigInteger n = BigInteger.Parse(Ferma_TextBox.Text);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //bool prime = FermaTest(n, (int)BigInteger.Log(n, 2));
            bool prime = TestFerma(n, CountBits(n));
            
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            label6.Text = elapsedTime;

            if (prime)
            {
                label1.Text = "The number is \nprobably prime";
                label8.Text = Math.Pow(0.5, CountBits(n)).ToString();
            }
            else
            {
                label1.Text = "The number is \nprobably not prime";
                label8.Text = "";
            }
        }
        private void Miller_check(object sender, EventArgs e)
        {
            if (Miller_TextBox.Text == "" || Miller_TextBox.Text == "1")
                return;
            BigInteger n = BigInteger.Parse(Miller_TextBox.Text);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //bool prime = FermaTest(n, (int)BigInteger.Log(n, 2));
            bool prime = MillerRabinTest(n, CountBits(n));

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label7.Text = elapsedTime;

            if (prime)
            {
                label5.Text = "The number is \nprobably prime";
                label9.Text = Math.Pow(0.25, CountBits(n)).ToString();
            }
            else
            {
                label5.Text = "The number is \nprobably not prime";
                label9.Text = "";
            }
        }
        private void Solovay_Check(object sender, EventArgs e)
        {
            if (Solovay_TextBox.Text == "" || Solovay_TextBox.Text == "1")
                return;
            BigInteger n = BigInteger.Parse(Solovay_TextBox.Text);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //bool prime = FermaTest(n, (int)BigInteger.Log(n, 2));
            bool prime = SolovayStrassenTest(n, CountBits(n));

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label11.Text = elapsedTime;

            if (prime)
            {
                label12.Text = "The number is \nprobably prime";
                label10.Text = Math.Pow(0.5, CountBits(n)).ToString();
            }
            else
            {
                label12.Text = "The number is \nprobably not prime";
                label10.Text = "";
            }
        }

        private void Ferma_TextBox_TextChanged(object sender, EventArgs e)
        {
            int start = Ferma_TextBox.SelectionStart;
            string n_string = "";
            foreach (char c in Ferma_TextBox.Text)
                if (c <= '9' && c >= '0')
                    n_string += c;
            Ferma_TextBox.Text = n_string;
            if (n_string != "")
                if (BigInteger.Parse(n_string) < 3)
                    n_string = 3.ToString();
            Ferma_TextBox.SelectionStart = start;
        }
        private void Miller_TextChanged(object sender, EventArgs e)
        {
            int start = Miller_TextBox.SelectionStart;
            string n_string = "";
            foreach (char c in Miller_TextBox.Text)
                if (c <= '9' && c >= '0')
                    n_string += c;
            Miller_TextBox.Text = n_string;
            Miller_TextBox.SelectionStart = start;
        }

        private void Enter_Bits_For_Generation(object sender, EventArgs e)
        {
            int cursor_start = Bits_Text_Box .SelectionStart;
            string result_numb = "";
            foreach (char symbol in Bits_Text_Box.Text)
            {
                if (symbol <= '9' && symbol >= '0')
                    result_numb += symbol;
            }
            if (result_numb.Length > 8)
                Bits_Text_Box.Text = result_numb.Substring(0, 8);
            else
                Bits_Text_Box.Text = result_numb;
            Bits_Text_Box.SelectionStart = cursor_start;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            generation_size = int.Parse(listBox1.SelectedItem.ToString());
        }

    }
}
