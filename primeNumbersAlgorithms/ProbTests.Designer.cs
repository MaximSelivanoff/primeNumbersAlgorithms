namespace TestFerma
{
    partial class ProbTests
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ferma_TextBox = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.miller_check = new System.Windows.Forms.Button();
            this.Miller_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Solovay_TextBox = new System.Windows.Forms.TextBox();
            this.Bits_Text_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ferma_TextBox
            // 
            this.Ferma_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ferma_TextBox.Location = new System.Drawing.Point(221, 88);
            this.Ferma_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ferma_TextBox.Multiline = true;
            this.Ferma_TextBox.Name = "Ferma_TextBox";
            this.Ferma_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ferma_TextBox.Size = new System.Drawing.Size(215, 378);
            this.Ferma_TextBox.TabIndex = 0;
            this.Ferma_TextBox.TextChanged += new System.EventHandler(this.Ferma_TextBox_TextChanged);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generate.Location = new System.Drawing.Point(12, 138);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(170, 48);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate Prime";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check.Location = new System.Drawing.Point(221, 474);
            this.check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(215, 48);
            this.check.TabIndex = 3;
            this.check.Text = "Check Prime";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size of number \n(bits)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024"});
            this.listBox1.Location = new System.Drawing.Point(12, 192);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 178);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ferma:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(530, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Miller-Rabin:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miller_check
            // 
            this.miller_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miller_check.Location = new System.Drawing.Point(535, 474);
            this.miller_check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.miller_check.Name = "miller_check";
            this.miller_check.Size = new System.Drawing.Size(215, 48);
            this.miller_check.TabIndex = 12;
            this.miller_check.Text = "Check Prime";
            this.miller_check.UseVisualStyleBackColor = true;
            this.miller_check.Click += new System.EventHandler(this.Miller_check);
            // 
            // Miller_TextBox
            // 
            this.Miller_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Miller_TextBox.Location = new System.Drawing.Point(535, 88);
            this.Miller_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Miller_TextBox.Multiline = true;
            this.Miller_TextBox.Name = "Miller_TextBox";
            this.Miller_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Miller_TextBox.Size = new System.Drawing.Size(215, 378);
            this.Miller_TextBox.TabIndex = 9;
            this.Miller_TextBox.TextChanged += new System.EventHandler(this.Miller_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(530, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(226, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(530, 652);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(226, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(530, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(849, 616);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(849, 652);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(849, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Result";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(849, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "Solovay–Strassen:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(854, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Check Prime";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Solovay_Check);
            // 
            // Solovay_TextBox
            // 
            this.Solovay_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Solovay_TextBox.Location = new System.Drawing.Point(854, 88);
            this.Solovay_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Solovay_TextBox.Multiline = true;
            this.Solovay_TextBox.Name = "Solovay_TextBox";
            this.Solovay_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Solovay_TextBox.Size = new System.Drawing.Size(215, 378);
            this.Solovay_TextBox.TabIndex = 19;
            // 
            // Bits_Text_Box
            // 
            this.Bits_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bits_Text_Box.Location = new System.Drawing.Point(12, 88);
            this.Bits_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bits_Text_Box.Name = "Bits_Text_Box";
            this.Bits_Text_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Bits_Text_Box.Size = new System.Drawing.Size(175, 34);
            this.Bits_Text_Box.TabIndex = 27;
            this.Bits_Text_Box.TextChanged += new System.EventHandler(this.Enter_Bits_For_Generation);
            // 
            // ProbTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 776);
            this.Controls.Add(this.Bits_Text_Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Solovay_TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.miller_check);
            this.Controls.Add(this.Miller_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.Ferma_TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProbTests";
            this.Text = "Probably tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ferma_TextBox;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button miller_check;
        private System.Windows.Forms.TextBox Miller_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Solovay_TextBox;
        private System.Windows.Forms.TextBox Bits_Text_Box;
    }
}

