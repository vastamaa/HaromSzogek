using System;

namespace Haromszogek
{
    class DHaromszog
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        private bool _EllDerekszogu { get { return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2); } }
        private bool _EllMegszerkesztheto { get { return A + B > C; } }
        private bool _EllNovekvoSorrend { get { return A < B && B < C; } }
        public double Kerulet { get { return A + B + C; } }
        public int SorSzama { get; set; }
        public double Terulet { get { return (A * B) / 2; } }

        public DHaromszog(string sor, int sorSzama)
        {
            SorSzama = sorSzama;
            string[] darabok = sor.Split(' ');

            double a = Convert.ToDouble(darabok[0]);
            double b = Convert.ToDouble(darabok[1]);
            double c = Convert.ToDouble(darabok[2]);

            if (a <= 0) throw new Exception("A(z) 'a' oldal nem lehet nulla vagy negatív!");
            else A = a;
            if (b <= 0) throw new Exception("A(z) 'b' oldal nem lehet nulla vagy negatív!");
            else B = b;
            if (c <= 0) throw new Exception("A(z) 'c' oldal nem lehet nulla vagy negatív!");
            else C = c;

            if (!_EllNovekvoSorrend) throw new Exception("Az adatok nincsenek növekvő sorrendben!");
            if (!_EllMegszerkesztheto) throw new Exception("A háromszög nem megszerkeszthető!");
            if (!_EllDerekszogu) throw new Exception("A háromszög nem derékszögű!");
        }
    }
}
