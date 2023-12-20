namespace GrafickaKalkulacka
{
    internal class KalkulackaPocty
    {

        private double _vysledek = double.NaN;
        private string _znamenko = "";
        private string _historie = "";

        public void Operace(double cislo, string operatorZnak)
        {
            if (!string.IsNullOrWhiteSpace(_znamenko))
            {
                Vypocti(cislo);
                _historie += $" {_znamenko} {cislo}";
            }
            else
            {
                _vysledek = cislo;
                _historie = cislo.ToString();

            }
            _znamenko = operatorZnak;
        }

        public void RovnaSe(double cislo)
        {
            Vypocti(cislo);
            _historie += $" {_znamenko} {cislo}";
            _znamenko = "";

        }

        public void Reset()
        {
            _znamenko = "";
            _vysledek = double.NaN;
            _historie = "";
        }

        private void Vypocti(double cislo)
        {
            switch (_znamenko)
            {
                case "+":
                    _vysledek = Secti(_vysledek, cislo);
                    break;
                case "-":
                    _vysledek = Rozdil(_vysledek, cislo);
                    break;
                case "*":
                    _vysledek = Soucin(_vysledek, cislo);
                    break;
                case "/":
                    _vysledek = Podil(_vysledek, cislo);
                    break;
            }
        }

        public double ZiskejVysledek()
        {
            return _vysledek;
        }

        public string ZiskejHistorii()
        {
            return $"{_historie} = {_vysledek}";
        }

        private double Secti(double cislo1, double cislo2)
        {
            return cislo1 + cislo2;
        }

        private double Rozdil(double cislo1, double cislo2)
        {
            return cislo1 - cislo2;
        }

        private double Soucin(double cislo1, double cislo2)
        {
            return cislo1 * cislo2;
        }

        private double Podil(double cislo1, double cislo2)
        {
            if (cislo2 != 0)
            {
                return cislo1 / cislo2;
            }
            else
            {
                return double.NaN;
            }
        }
    }
}


