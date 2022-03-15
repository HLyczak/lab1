using System;
using System.Linq;

namespace lab1
{
    ///<summary> Class <c>Ulamek</c> operates on fractions</summary>
    public class Ulamek : IComparable<Ulamek>, IEquatable<Ulamek>
    {
        public int Licznik { get; private set; }
        public int Mianownik { get; private set; }

        public double ToDouble()
        {
            return ((double)this.Licznik / (double)this.Mianownik);
        }

        public decimal ToDecimal()
        {
            return Math.Ceiling((decimal)this.Licznik / (decimal)this.Mianownik);
        }

        ///<summary> Method <c> operator +</c> adding fractions</summary>
        public static Ulamek operator +(Ulamek a, Ulamek b)
        {
            if (a.Licznik == 0)
            {
                return new Ulamek(b.Licznik, b.Mianownik);
            }

            if (b.Licznik == 0)
            {
                return new Ulamek(a.Licznik, a.Mianownik);
            }
            if (a.Licznik < 0 && a.Mianownik < 0 || b.Licznik < 0 && b.Mianownik < 0)
            {
                return new Ulamek(((b.Mianownik * a.Licznik) + (a.Mianownik * b.Licznik)) * -1, ((a.Mianownik * b.Mianownik) * -1));
            }

            return new Ulamek((b.Mianownik * a.Licznik) + (a.Mianownik * b.Licznik), a.Mianownik * b.Mianownik);
        }

        ///<summary> Method <c> operator - </c> subtraction of fractions </summary>
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            if (a.Licznik == 0)
            {
                return new Ulamek(-b.Licznik, -b.Mianownik);
            }

            if (b.Licznik == 0)
            {
                return new Ulamek(a.Licznik, a.Mianownik);
            }

            if (a.Licznik < 0)
            {
                return new Ulamek(((-b.Mianownik * a.Licznik) + (a.Mianownik * b.Licznik)) * -1, a.Mianownik * b.Mianownik);
            }

            if (a.Licznik < 0 && a.Mianownik < 0)
            {
                return new Ulamek(((b.Mianownik * a.Licznik) + (a.Mianownik * b.Licznik)), (a.Mianownik * b.Mianownik));
            }

            if (b.Licznik < 0 && b.Mianownik < 0)
            {
                return new Ulamek(((b.Mianownik * a.Licznik) - (a.Mianownik * b.Licznik)) * -1, (a.Mianownik * b.Mianownik) * -1);
            }

            if (a.Licznik == a.Mianownik && b.Licznik == b.Mianownik)
            {
                return new Ulamek(a.Licznik - b.Licznik, a.Mianownik - b.Mianownik);
            }
            else
                return new Ulamek((b.Mianownik * a.Licznik) - (a.Mianownik * b.Licznik), a.Mianownik * b.Mianownik);
        }

        ///<summary> Method <c> operator * </c> subtraction of fractions </summary>

        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.Licznik * b.Licznik, a.Mianownik * b.Mianownik);
        }

        ///<summary> Method <c> operator / </c> multiplication of fractions </summary>
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.Licznik * b.Mianownik, a.Mianownik * b.Licznik);
        }

        public Ulamek()
        {
            this.Licznik = 1;
            this.Mianownik = 1;
        }

        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0)
            {
                throw new ArgumentException("Mianownik nie może  być zerem");
            }

            this.Licznik = licznik;
            this.Mianownik = mianownik;
        }

        public Ulamek(Ulamek kopia)
        {
            this.Licznik = kopia.Licznik;
            this.Mianownik = kopia.Mianownik;
        }

        public override string ToString() => $"Licznik{Licznik}, Mianownik{Mianownik}";

        public int CompareTo(Ulamek ulamek)
        {
            if (this.Equals(ulamek))
            {
                return 0;
            }
            if ((double)this.Licznik / this.Mianownik < (double)ulamek.Licznik / ulamek.Mianownik)
            {
                return 1;
            }

            return -1;
        }

        public bool Equals(Ulamek other)
        {
            return ((double)this.Licznik / this.Mianownik == (double)other.Licznik / other.Mianownik);
        }
    }
}