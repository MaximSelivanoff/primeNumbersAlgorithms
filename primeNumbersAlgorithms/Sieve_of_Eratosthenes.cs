using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Sieve_of_Eratosthenes
{
    public partial class Sieve_of_Eratosthenes : Form
    {
        public Sieve_of_Eratosthenes()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cursor_start = textBox1.SelectionStart;
            string result_numb = "";
            foreach (char symbol in textBox1.Text)
            {
                if (symbol <= '9' && symbol >= '0')
                    result_numb += symbol;
            }
            if (result_numb.Length > 8)
                textBox1.Text = result_numb.Substring(0, 8);
            else
                textBox1.Text = result_numb;
            textBox1.SelectionStart = cursor_start;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            /*int[] siege = new int[number];
            for (int i = 2; i < number + 1; i++)
                siege[i-2] = i;
            for (int i = 0; i < number-2; i++)
            {
                for (int j = i + 1; j < number-1; j++)
                {
                    if (siege[i] == 0)
                        break;
                    if (siege[j] == 0)
                        continue;
                    if ((siege[j] % siege[i]) == 0)
                        siege[j] = 0;
                }
            }
          */
            int n = int.Parse(textBox1.Text);
            List<bool> numbers = new List<bool>();
            for (int i = 0; i < number; i++)
                numbers.Add(true);
            numbers[0] = numbers[1] = false;
            for (int i = 2; i < n; i++)
            {
                if (numbers[i])
                {
                    ulong ii= (ulong)(i * i);
                    if (ii <= (ulong)n)
                        for (int j = i * i; j < n; j += i)
                            numbers[j] = false;
                }
            }
            StreamWriter file_in = new StreamWriter("Text.txt");
            for (int i = 2; i < n; i++)
            {
                if (numbers[i] == true)
                    file_in.Write(i + " ");
            }
            file_in.Close();
            StreamReader file_from = new StreamReader("Text.txt");
            textBox2.Text = file_from.ReadToEnd();
            file_from.Close();
            /*
                    string result = "";
                        foreach (int i in siege)
                            if(i != 0)
                                result += i + " ";
                        textBox2.Text = result;
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
