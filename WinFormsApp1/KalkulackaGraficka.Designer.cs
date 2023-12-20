namespace WinFormsApp1
{
    partial class KalkulackaGraficka
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
            Tlacitko7 = new Button();
            Tlaciko8 = new Button();
            Tlacitko9 = new Button();
            Tlacitko4 = new Button();
            Tlacitko5 = new Button();
            Tlacitko6 = new Button();
            Tlacitko1 = new Button();
            TlacitkoDeleni = new Button();
            TlacitkoNasobeni = new Button();
            TlacitkoMinus = new Button();
            Tlacitko3 = new Button();
            Tlacitko2 = new Button();
            Tlacitko0 = new Button();
            TlacitkoSoucet = new Button();
            TlacitkoRovnaSe = new Button();
            TabulkaNaCislaAVysledek = new TextBox();
            TlacitkoSmazat = new Button();
            LabelNaMezivysledek = new Label();
            SuspendLayout();
            // 
            // Tlacitko7
            // 
            Tlacitko7.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko7.Location = new Point(26, 186);
            Tlacitko7.Name = "Tlacitko7";
            Tlacitko7.Size = new Size(88, 67);
            Tlacitko7.TabIndex = 0;
            Tlacitko7.Text = "7";
            Tlacitko7.UseVisualStyleBackColor = true;
            Tlacitko7.Click += Tlacitko_Click;
            // 
            // Tlaciko8
            // 
            Tlaciko8.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlaciko8.Location = new Point(153, 186);
            Tlaciko8.Name = "Tlaciko8";
            Tlaciko8.Size = new Size(90, 67);
            Tlaciko8.TabIndex = 1;
            Tlaciko8.Text = "8";
            Tlaciko8.UseVisualStyleBackColor = true;
            Tlaciko8.Click += Tlacitko_Click;
            // 
            // Tlacitko9
            // 
            Tlacitko9.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko9.Location = new Point(273, 185);
            Tlacitko9.Name = "Tlacitko9";
            Tlacitko9.Size = new Size(88, 68);
            Tlacitko9.TabIndex = 2;
            Tlacitko9.Text = "9";
            Tlacitko9.UseVisualStyleBackColor = true;
            Tlacitko9.Click += Tlacitko_Click;
            // 
            // Tlacitko4
            // 
            Tlacitko4.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko4.Location = new Point(26, 281);
            Tlacitko4.Name = "Tlacitko4";
            Tlacitko4.Size = new Size(86, 70);
            Tlacitko4.TabIndex = 3;
            Tlacitko4.Text = "4";
            Tlacitko4.UseVisualStyleBackColor = true;
            Tlacitko4.Click += Tlacitko_Click;
            // 
            // Tlacitko5
            // 
            Tlacitko5.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko5.Location = new Point(153, 283);
            Tlacitko5.Name = "Tlacitko5";
            Tlacitko5.Size = new Size(90, 72);
            Tlacitko5.TabIndex = 4;
            Tlacitko5.Text = "5";
            Tlacitko5.UseVisualStyleBackColor = true;
            Tlacitko5.Click += Tlacitko_Click;
            // 
            // Tlacitko6
            // 
            Tlacitko6.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko6.Location = new Point(273, 284);
            Tlacitko6.Name = "Tlacitko6";
            Tlacitko6.Size = new Size(88, 71);
            Tlacitko6.TabIndex = 5;
            Tlacitko6.Text = "6";
            Tlacitko6.UseVisualStyleBackColor = true;
            Tlacitko6.Click += Tlacitko_Click;
            // 
            // Tlacitko1
            // 
            Tlacitko1.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko1.Location = new Point(24, 377);
            Tlacitko1.Name = "Tlacitko1";
            Tlacitko1.Size = new Size(90, 75);
            Tlacitko1.TabIndex = 6;
            Tlacitko1.Text = "1";
            Tlacitko1.UseVisualStyleBackColor = true;
            Tlacitko1.Click += Tlacitko_Click;
            // 
            // TlacitkoDeleni
            // 
            TlacitkoDeleni.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TlacitkoDeleni.Location = new Point(415, 186);
            TlacitkoDeleni.Name = "TlacitkoDeleni";
            TlacitkoDeleni.Size = new Size(82, 63);
            TlacitkoDeleni.TabIndex = 7;
            TlacitkoDeleni.Text = "/";
            TlacitkoDeleni.UseVisualStyleBackColor = true;
            TlacitkoDeleni.Click += TlacitkoOperace_Click;
            // 
            // TlacitkoNasobeni
            // 
            TlacitkoNasobeni.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TlacitkoNasobeni.Location = new Point(415, 255);
            TlacitkoNasobeni.Name = "TlacitkoNasobeni";
            TlacitkoNasobeni.Size = new Size(82, 65);
            TlacitkoNasobeni.TabIndex = 8;
            TlacitkoNasobeni.Text = "*";
            TlacitkoNasobeni.UseVisualStyleBackColor = true;
            TlacitkoNasobeni.Click += TlacitkoOperace_Click;
            // 
            // TlacitkoMinus
            // 
            TlacitkoMinus.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TlacitkoMinus.Location = new Point(415, 326);
            TlacitkoMinus.Name = "TlacitkoMinus";
            TlacitkoMinus.Size = new Size(82, 66);
            TlacitkoMinus.TabIndex = 9;
            TlacitkoMinus.Text = "-";
            TlacitkoMinus.UseVisualStyleBackColor = true;
            TlacitkoMinus.Click += TlacitkoOperace_Click;
            // 
            // Tlacitko3
            // 
            Tlacitko3.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko3.Location = new Point(273, 377);
            Tlacitko3.Name = "Tlacitko3";
            Tlacitko3.Size = new Size(88, 75);
            Tlacitko3.TabIndex = 10;
            Tlacitko3.Text = "3";
            Tlacitko3.UseVisualStyleBackColor = true;
            Tlacitko3.Click += Tlacitko_Click;
            // 
            // Tlacitko2
            // 
            Tlacitko2.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko2.Location = new Point(153, 380);
            Tlacitko2.Name = "Tlacitko2";
            Tlacitko2.Size = new Size(90, 72);
            Tlacitko2.TabIndex = 11;
            Tlacitko2.Text = "2";
            Tlacitko2.UseVisualStyleBackColor = true;
            Tlacitko2.Click += Tlacitko_Click;
            // 
            // Tlacitko0
            // 
            Tlacitko0.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tlacitko0.Location = new Point(153, 476);
            Tlacitko0.Name = "Tlacitko0";
            Tlacitko0.Size = new Size(90, 72);
            Tlacitko0.TabIndex = 13;
            Tlacitko0.Text = "0";
            Tlacitko0.UseVisualStyleBackColor = true;
            Tlacitko0.Click += Tlacitko_Click;
            // 
            // TlacitkoSoucet
            // 
            TlacitkoSoucet.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TlacitkoSoucet.Location = new Point(415, 398);
            TlacitkoSoucet.Name = "TlacitkoSoucet";
            TlacitkoSoucet.Size = new Size(82, 62);
            TlacitkoSoucet.TabIndex = 14;
            TlacitkoSoucet.Text = "+";
            TlacitkoSoucet.UseVisualStyleBackColor = true;
            TlacitkoSoucet.Click += TlacitkoOperace_Click;
            // 
            // TlacitkoRovnaSe
            // 
            TlacitkoRovnaSe.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TlacitkoRovnaSe.Location = new Point(415, 466);
            TlacitkoRovnaSe.Name = "TlacitkoRovnaSe";
            TlacitkoRovnaSe.Size = new Size(82, 63);
            TlacitkoRovnaSe.TabIndex = 15;
            TlacitkoRovnaSe.Text = "=";
            TlacitkoRovnaSe.UseVisualStyleBackColor = true;
            TlacitkoRovnaSe.Click += TlacitkoRovnaSe_Click;
            // 
            // TabulkaNaCislaAVysledek
            // 
            TabulkaNaCislaAVysledek.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TabulkaNaCislaAVysledek.Location = new Point(24, 67);
            TabulkaNaCislaAVysledek.Name = "TabulkaNaCislaAVysledek";
            TabulkaNaCislaAVysledek.ReadOnly = true;
            TabulkaNaCislaAVysledek.RightToLeft = RightToLeft.Yes;
            TabulkaNaCislaAVysledek.Size = new Size(473, 53);
            TabulkaNaCislaAVysledek.TabIndex = 16;
            TabulkaNaCislaAVysledek.Text = "0";
            // 
            // TlacitkoSmazat
            // 
            TlacitkoSmazat.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TlacitkoSmazat.Location = new Point(273, 476);
            TlacitkoSmazat.Name = "TlacitkoSmazat";
            TlacitkoSmazat.Size = new Size(88, 72);
            TlacitkoSmazat.TabIndex = 17;
            TlacitkoSmazat.Text = "C";
            TlacitkoSmazat.UseVisualStyleBackColor = true;
            TlacitkoSmazat.Click += TlacitkoSmazat_Click;
            // 
            // LabelNaMezivysledek
            // 
            LabelNaMezivysledek.AutoSize = true;
            LabelNaMezivysledek.BackColor = SystemColors.Control;
            LabelNaMezivysledek.Location = new Point(26, 39);
            LabelNaMezivysledek.Name = "LabelNaMezivysledek";
            LabelNaMezivysledek.RightToLeft = RightToLeft.No;
            LabelNaMezivysledek.Size = new Size(0, 25);
            LabelNaMezivysledek.TabIndex = 18;
            // 
            // KalkulackaGraficka
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(525, 560);
            Controls.Add(LabelNaMezivysledek);
            Controls.Add(TlacitkoSmazat);
            Controls.Add(TabulkaNaCislaAVysledek);
            Controls.Add(TlacitkoRovnaSe);
            Controls.Add(TlacitkoSoucet);
            Controls.Add(Tlacitko0);
            Controls.Add(Tlacitko2);
            Controls.Add(Tlacitko3);
            Controls.Add(TlacitkoMinus);
            Controls.Add(TlacitkoNasobeni);
            Controls.Add(TlacitkoDeleni);
            Controls.Add(Tlacitko1);
            Controls.Add(Tlacitko6);
            Controls.Add(Tlacitko5);
            Controls.Add(Tlacitko4);
            Controls.Add(Tlacitko9);
            Controls.Add(Tlaciko8);
            Controls.Add(Tlacitko7);
            Name = "KalkulackaGraficka";
            Text = "Kalkulacka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Tlacitko7;
        private Button Tlaciko8;
        private Button Tlacitko9;
        private Button Tlacitko4;
        private Button Tlacitko5;
        private Button Tlacitko6;
        private Button Tlacitko1;
        private Button TlacitkoDeleni;
        private Button TlacitkoNasobeni;
        private Button TlacitkoMinus;
        private Button Tlacitko3;
        private Button Tlacitko2;
        private Button Tlacitko0;
        private Button TlacitkoSoucet;
        private Button TlacitkoRovnaSe;
        private TextBox TabulkaNaCislaAVysledek;
        private Button TlacitkoSmazat;
        private Label LabelNaMezivysledek;
    }
}
