namespace Hangman
{
    partial class foWisielec
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buLosuj = new System.Windows.Forms.Button();
            this.buNastępne = new System.Windows.Forms.Button();
            this.laSłowo = new System.Windows.Forms.Label();
            this.buWczytaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nuIlePomyłek = new System.Windows.Forms.NumericUpDown();
            this.laNumerPróby = new System.Windows.Forms.Label();
            this.laOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuIlePomyłek)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Zestawy|*.zst";
            // 
            // buLosuj
            // 
            this.buLosuj.Enabled = false;
            this.buLosuj.Location = new System.Drawing.Point(13, 35);
            this.buLosuj.Name = "buLosuj";
            this.buLosuj.Size = new System.Drawing.Size(75, 23);
            this.buLosuj.TabIndex = 0;
            this.buLosuj.Text = "Losuj";
            this.buLosuj.UseVisualStyleBackColor = true;
            this.buLosuj.Click += new System.EventHandler(this.buLosuj_Click);
            // 
            // buNastępne
            // 
            this.buNastępne.Enabled = false;
            this.buNastępne.Location = new System.Drawing.Point(109, 35);
            this.buNastępne.Name = "buNastępne";
            this.buNastępne.Size = new System.Drawing.Size(75, 23);
            this.buNastępne.TabIndex = 1;
            this.buNastępne.Text = "Następny";
            this.buNastępne.UseVisualStyleBackColor = true;
            this.buNastępne.Click += new System.EventHandler(this.buNastępne_Click);
            // 
            // laSłowo
            // 
            this.laSłowo.AutoSize = true;
            this.laSłowo.Font = new System.Drawing.Font("Shruti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laSłowo.ForeColor = System.Drawing.Color.Blue;
            this.laSłowo.Location = new System.Drawing.Point(19, 124);
            this.laSłowo.MaximumSize = new System.Drawing.Size(700, 0);
            this.laSłowo.Name = "laSłowo";
            this.laSłowo.Size = new System.Drawing.Size(0, 45);
            this.laSłowo.TabIndex = 2;
            // 
            // buWczytaj
            // 
            this.buWczytaj.Location = new System.Drawing.Point(215, 35);
            this.buWczytaj.Name = "buWczytaj";
            this.buWczytaj.Size = new System.Drawing.Size(75, 23);
            this.buWczytaj.TabIndex = 3;
            this.buWczytaj.Text = "Wczytaj";
            this.buWczytaj.UseVisualStyleBackColor = true;
            this.buWczytaj.Click += new System.EventHandler(this.buWczytaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ile pomyłek:";
            // 
            // nuIlePomyłek
            // 
            this.nuIlePomyłek.Location = new System.Drawing.Point(92, 2);
            this.nuIlePomyłek.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuIlePomyłek.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nuIlePomyłek.Name = "nuIlePomyłek";
            this.nuIlePomyłek.Size = new System.Drawing.Size(57, 20);
            this.nuIlePomyłek.TabIndex = 5;
            this.nuIlePomyłek.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nuIlePomyłek.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // laNumerPróby
            // 
            this.laNumerPróby.AutoSize = true;
            this.laNumerPróby.Location = new System.Drawing.Point(167, 9);
            this.laNumerPróby.Name = "laNumerPróby";
            this.laNumerPróby.Size = new System.Drawing.Size(89, 13);
            this.laNumerPróby.TabIndex = 6;
            this.laNumerPróby.Text = "Liczba błędów: 0";
            // 
            // laOpis
            // 
            this.laOpis.AutoSize = true;
            this.laOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laOpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.laOpis.Location = new System.Drawing.Point(19, 75);
            this.laOpis.MaximumSize = new System.Drawing.Size(700, 0);
            this.laOpis.Name = "laOpis";
            this.laOpis.Size = new System.Drawing.Size(0, 20);
            this.laOpis.TabIndex = 7;
            // 
            // foWisielec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 300);
            this.Controls.Add(this.laOpis);
            this.Controls.Add(this.laNumerPróby);
            this.Controls.Add(this.nuIlePomyłek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buWczytaj);
            this.Controls.Add(this.laSłowo);
            this.Controls.Add(this.buNastępne);
            this.Controls.Add(this.buLosuj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "foWisielec";
            this.Text = "Wisielec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.foWisielec_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nuIlePomyłek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buLosuj;
        private System.Windows.Forms.Button buNastępne;
        private System.Windows.Forms.Label laSłowo;
        private System.Windows.Forms.Button buWczytaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuIlePomyłek;
        private System.Windows.Forms.Label laNumerPróby;
        private System.Windows.Forms.Label laOpis;
    }
}

