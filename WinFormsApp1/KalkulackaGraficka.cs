using GrafickaKalkulacka;

namespace WinFormsApp1
{
    public partial class KalkulackaGraficka : Form
    {
        KalkulackaPocty kalkulacka = new KalkulackaPocty();
        bool zadavamDalsiCislo = false;

        public KalkulackaGraficka()
        {
            InitializeComponent();
        }

        private void Tlacitko_Click(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;
            if (TabulkaNaCislaAVysledek.Text == "0" || TabulkaNaCislaAVysledek.Text == kalkulacka.ZiskejVysledek().ToString() || zadavamDalsiCislo)
            {
                TabulkaNaCislaAVysledek.Text = tlacitko.Text.ToString();
                zadavamDalsiCislo = false;
            }

            else
            {

                TabulkaNaCislaAVysledek.Text += tlacitko.Text.ToString();

            }

        }

        private void TlacitkoOperace_Click(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;

            double cislo = Convert.ToDouble(TabulkaNaCislaAVysledek.Text);
            string operatorZnak = tlacitko.Text;
            kalkulacka.Operace(cislo, operatorZnak);
            zadavamDalsiCislo = true;
            AktualizujMezivysledek();

        }


        private void TlacitkoRovnaSe_Click(object sender, EventArgs e)
        {
            double cislo = Convert.ToDouble(TabulkaNaCislaAVysledek.Text);
            kalkulacka.RovnaSe(cislo);
            TabulkaNaCislaAVysledek.Text = kalkulacka.ZiskejVysledek().ToString();
            AktualizujMezivysledek();

        }
        private void TlacitkoSmazat_Click(object sender, EventArgs e)
        {
            TabulkaNaCislaAVysledek.Clear();
            LabelNaMezivysledek.Text = string.Empty;
            kalkulacka.Reset();
            AktualizujMezivysledek();
        }

        private void AktualizujMezivysledek()
        {
            LabelNaMezivysledek.Text = kalkulacka.ZiskejHistorii();
        }
    }
}

