namespace PingTest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdressLabel = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Minimum = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.Maximum = new System.Windows.Forms.Label();
            this.Loss = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.BWPing = new System.ComponentModel.BackgroundWorker();
            this.Box = new System.Windows.Forms.ListBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(12, 14);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(42, 13);
            this.AdressLabel.TabIndex = 0;
            this.AdressLabel.Text = "Adress:";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(12, 30);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(257, 20);
            this.Adress.TabIndex = 1;
            this.Adress.Text = "google.com";
            // 
            // Minimum
            // 
            this.Minimum.AutoSize = true;
            this.Minimum.Location = new System.Drawing.Point(12, 69);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(51, 13);
            this.Minimum.TabIndex = 2;
            this.Minimum.Text = "Minimum:";
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(148, 69);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(50, 13);
            this.Average.TabIndex = 3;
            this.Average.Text = "Average:";
            // 
            // Maximum
            // 
            this.Maximum.AutoSize = true;
            this.Maximum.Location = new System.Drawing.Point(12, 93);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(54, 13);
            this.Maximum.TabIndex = 4;
            this.Maximum.Text = "Maximum:";
            // 
            // Loss
            // 
            this.Loss.AutoSize = true;
            this.Loss.Location = new System.Drawing.Point(148, 93);
            this.Loss.Name = "Loss";
            this.Loss.Size = new System.Drawing.Size(32, 13);
            this.Loss.TabIndex = 5;
            this.Loss.Text = "Loss:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(194, 129);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // BWPing
            // 
            this.BWPing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWPing_DoWork);
            this.BWPing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWPing_RunWorkerCompleted);
            // 
            // Box
            // 
            this.Box.FormattingEnabled = true;
            this.Box.Location = new System.Drawing.Point(218, 7);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(51, 17);
            this.Box.TabIndex = 7;
            this.Box.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(15, 129);
            this.ProgressBar.Maximum = 10;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(165, 23);
            this.ProgressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 164);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Loss);
            this.Controls.Add(this.Maximum);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.AdressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label Minimum;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label Maximum;
        private System.Windows.Forms.Label Loss;
        private System.Windows.Forms.Button Start;
        private System.ComponentModel.BackgroundWorker BWPing;
        private System.Windows.Forms.ListBox Box;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

