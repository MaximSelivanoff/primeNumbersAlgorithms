
namespace primeNumbersAlgorithms
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuLabel = new System.Windows.Forms.Label();
            this.TrueAlgsButton = new System.Windows.Forms.Button();
            this.ProbAlgsButton = new System.Windows.Forms.Button();
            this.TrueAlgsLabel = new System.Windows.Forms.Label();
            this.ProbAlgsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLabel.Location = new System.Drawing.Point(13, 22);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(398, 37);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "Алгоритмы для простых чисел:";
            // 
            // TrueAlgsButton
            // 
            this.TrueAlgsButton.Location = new System.Drawing.Point(13, 89);
            this.TrueAlgsButton.Name = "TrueAlgsButton";
            this.TrueAlgsButton.Size = new System.Drawing.Size(135, 81);
            this.TrueAlgsButton.TabIndex = 1;
            this.TrueAlgsButton.Text = "Истинные";
            this.TrueAlgsButton.UseVisualStyleBackColor = true;
            this.TrueAlgsButton.Click += new System.EventHandler(this.TrueAlgsButton_Click);
            // 
            // ProbAlgsButton
            // 
            this.ProbAlgsButton.Location = new System.Drawing.Point(12, 176);
            this.ProbAlgsButton.Name = "ProbAlgsButton";
            this.ProbAlgsButton.Size = new System.Drawing.Size(135, 81);
            this.ProbAlgsButton.TabIndex = 2;
            this.ProbAlgsButton.Text = "Вероятностные";
            this.ProbAlgsButton.UseVisualStyleBackColor = true;
            this.ProbAlgsButton.Click += new System.EventHandler(this.ProbAlgsButton_Click);
            // 
            // TrueAlgsLabel
            // 
            this.TrueAlgsLabel.AutoSize = true;
            this.TrueAlgsLabel.Location = new System.Drawing.Point(167, 119);
            this.TrueAlgsLabel.Name = "TrueAlgsLabel";
            this.TrueAlgsLabel.Size = new System.Drawing.Size(279, 20);
            this.TrueAlgsLabel.TabIndex = 3;
            this.TrueAlgsLabel.Text = "- Решето Эратосфена и решето Аткина";
            // 
            // ProbAlgsLabel
            // 
            this.ProbAlgsLabel.AutoSize = true;
            this.ProbAlgsLabel.Location = new System.Drawing.Point(167, 206);
            this.ProbAlgsLabel.Name = "ProbAlgsLabel";
            this.ProbAlgsLabel.Size = new System.Drawing.Size(442, 20);
            this.ProbAlgsLabel.TabIndex = 4;
            this.ProbAlgsLabel.Text = "- Тест Ферма, Тест Миллера-Рабина, тест Соловея-Штрассена ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 272);
            this.Controls.Add(this.ProbAlgsLabel);
            this.Controls.Add(this.TrueAlgsLabel);
            this.Controls.Add(this.ProbAlgsButton);
            this.Controls.Add(this.TrueAlgsButton);
            this.Controls.Add(this.MenuLabel);
            this.Name = "MainMenu";
            this.Text = "Prime numbers Algorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button TrueAlgsButton;
        private System.Windows.Forms.Button ProbAlgsButton;
        private System.Windows.Forms.Label TrueAlgsLabel;
        private System.Windows.Forms.Label ProbAlgsLabel;
    }
}

