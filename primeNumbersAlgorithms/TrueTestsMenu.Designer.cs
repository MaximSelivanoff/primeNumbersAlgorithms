
namespace primeNumbersAlgorithms
{
    partial class TrueTestsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AtkinButton = new System.Windows.Forms.Button();
            this.EratosphenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AtkinButton
            // 
            this.AtkinButton.Location = new System.Drawing.Point(12, 12);
            this.AtkinButton.Name = "AtkinButton";
            this.AtkinButton.Size = new System.Drawing.Size(249, 57);
            this.AtkinButton.TabIndex = 0;
            this.AtkinButton.Text = "Решето Аткина";
            this.AtkinButton.UseVisualStyleBackColor = true;
            this.AtkinButton.Click += new System.EventHandler(this.AtkinButton_Click);
            // 
            // EratosphenButton
            // 
            this.EratosphenButton.Location = new System.Drawing.Point(12, 75);
            this.EratosphenButton.Name = "EratosphenButton";
            this.EratosphenButton.Size = new System.Drawing.Size(249, 57);
            this.EratosphenButton.TabIndex = 1;
            this.EratosphenButton.Text = "Решето Эратосфена";
            this.EratosphenButton.UseVisualStyleBackColor = true;
            this.EratosphenButton.Click += new System.EventHandler(this.EratosphenButton_Click);
            // 
            // TrueTestsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 146);
            this.Controls.Add(this.EratosphenButton);
            this.Controls.Add(this.AtkinButton);
            this.Name = "TrueTestsMenu";
            this.Text = "TrueTests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AtkinButton;
        private System.Windows.Forms.Button EratosphenButton;
    }
}