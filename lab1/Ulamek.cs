using System;
using System.Linq;

namespace lab1
{
    public class Ulamek : IComparable<Ulamek>, IEquatable<Ulamek>
    {
        public int licznik { get; private set; }
        public int mianownik { get; private set; }

        public double toDouble()
        {
            return ((double)this.licznik / (double)this.mianownik);
        }

        public decimal toDecimal()
        {
            return Math.Ceiling((decimal)this.licznik / (decimal)this.mianownik);
        }

        public static Ulamek operator +(Ulamek a, Ulamek b)
        {
            if (a.licznik == 0)
            {
                return new Ulamek(b.licznik, b.mianownik);
            }

            if (b.licznik == 0)
            {
                return new Ulamek(a.licznik, a.mianownik);
            }
            if (a.licznik < 0 && a.mianownik < 0 || b.licznik < 0 && b.mianownik < 0)
            {
                return new Ulamek(((b.mianownik * a.licznik) + (a.mianownik * b.licznik)) * -1, ((a.mianownik * b.mianownik) * -1));
            }

            return new Ulamek((b.mianownik * a.licznik) + (a.mianownik * b.licznik), a.mianownik * b.mianownik);
        }

        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            if (a.licznik == 0)
            {
                return new Ulamek(-b.licznik, -b.mianownik);
            }

            if (b.licznik == 0)
            {
                return new Ulamek(a.licznik, a.mianownik);
            }

            if (a.licznik < 0)
            {
                return new Ulamek(((-b.mianownik * a.licznik) + (a.mianownik * b.licznik)) * -1, a.mianownik * b.mianownik);
            }
            if (a.licznik < 0 && a.mianownik < 0 || b.licznik < 0 && b.mianownik < 0)
            {
                return new Ulamek(((b.mianownik * a.licznik) - (a.mianownik * b.licznik)) * -1, (a.mianownik * b.mianownik) * -1);
            }

            if (a.licznik == a.mianownik && b.licznik == b.mianownik)
            {
                return new Ulamek(a.licznik - b.licznik, a.mianownik - b.mianownik);
            }
            else
                return new Ulamek((b.mianownik * a.licznik) - (a.mianownik * b.licznik), a.mianownik * b.mianownik);
        }

        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            if (a.licznik == 0 || b.licznik == 0)
            {
                return new Ulamek(0, 0);
            }

            return new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        }

        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (a.licznik == 0 || b.licznik == 0)
            {
                return new Ulamek(0, 0);
            }
            return new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);
        }

        public Ulamek()
        {
            this.licznik = 1;
            this.mianownik = 1;
        }

        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0)
            {
                throw new ArgumentException("Mianownik nie może  być zerem");
            }

            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public Ulamek(Ulamek kopia)
        {
            this.licznik = kopia.licznik;
            this.mianownik = kopia.mianownik;
        }

        public override string ToString() => $"Licznik{licznik}, Mianownik{mianownik}";

        public int CompareTo(Ulamek ulamek)
        {
            if (this.Equals(ulamek))
            {
                return 0;
            }
            if ((double)this.licznik / this.mianownik < (double)ulamek.licznik / ulamek.mianownik)
            {
                return 1;
            }

            return -1;
        }

        public bool Equals(Ulamek other)
        {
            return ((double)this.licznik / this.mianownik == (double)other.licznik / other.mianownik);
        }
    }
}