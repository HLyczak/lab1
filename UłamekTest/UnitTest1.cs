using lab1;
using NUnit.Framework;

namespace UlamekTest
{
    public class Tests
    {
        [Test]
        public void ulamekNieZostajeUtworzony()
        {
            Assert.Throws<System.ArgumentException>(() => new Ulamek(1, 0));
        }

        [Test]
        public void utworzenieUlamkaLicznikzerowy()
        {
            Ulamek a = new Ulamek(0, 20);
            Assert.AreEqual(0, a.licznik);
            Assert.AreEqual(20, a.mianownik);
        }

        [Test]
        public void utworzenieUlamkaLicznikNieZerowy()
        {
            Ulamek b = new Ulamek(1, 20);
            Assert.AreEqual(1, b.licznik);
            Assert.AreEqual(20, b.mianownik);
        }

        [Test]
        public void DodajDodatnieTenSamMianownik()
        {
            Ulamek a = new Ulamek(1, 20);
            Ulamek b = new Ulamek(1, 20);

            Ulamek c = a + b;

            Assert.AreEqual(40, c.licznik);
            Assert.AreEqual(400, c.mianownik);
        }

        [Test]
        public void DodajDodatnieTenRoznyMianownik()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(4, 4);

            Ulamek c = a + b;

            Assert.AreEqual(12, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]
        public void DodajZeroLicznikAzerowy()
        {
            Ulamek a = new Ulamek(0, 2);
            Ulamek b = new Ulamek(4, 4);

            Ulamek c = a + b;

            Assert.AreEqual(4, c.licznik);
            Assert.AreEqual(4, c.mianownik);
        }

        [Test]
        public void DodajZeroLicznikBzerowy()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(0, 4);

            Ulamek c = a + b;

            Assert.AreEqual(1, c.licznik);
            Assert.AreEqual(2, c.mianownik);
        }

        [Test]
        public void DodajUjemneLicznikImianownikA()
        {
            Ulamek a = new Ulamek(-1, -2);
            Ulamek b = new Ulamek(1, 4);

            Ulamek c = a + b;

            Assert.AreEqual(6, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]
        public void DodajUjemneLicznikImianownikB()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(-1, -4);

            Ulamek c = a + b;

            Assert.AreEqual(6, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        //1
        [Test]
        public void OdejmijDodatnieTenSamMianownik()
        {
            Ulamek a = new Ulamek(1, 20);
            Ulamek b = new Ulamek(1, 20);

            Ulamek c = a - b;

            Assert.AreEqual(0, c.licznik);
            Assert.AreEqual(400, c.mianownik);
        }

        //2
        [Test]
        public void OdejmijDodatnieTenRoznyMianownik()
        {
            Ulamek a = new Ulamek(1, 4);
            Ulamek b = new Ulamek(4, 4);

            Ulamek c = a - b;

            Assert.AreEqual(-12, c.licznik);
            Assert.AreEqual(16, c.mianownik);
        }

        //3

        [Test]
        public void OdejmijZeroLicznikAzerowy()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(0, 4);

            Ulamek c = a - b;

            Assert.AreEqual(1, c.licznik);
            Assert.AreEqual(2, c.mianownik);
        }

        //4
        [Test]
        public void OdejmijZeroLicznikBzerowy()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(0, 4);

            Ulamek c = a - b;

            Assert.AreEqual(1, c.licznik);
            Assert.AreEqual(2, c.mianownik);
        }

        //5

        [Test]
        public void OdejmijUjemneLicznikA()
        {
            Ulamek a = new Ulamek(-1, 2);
            Ulamek b = new Ulamek(1, 4);

            Ulamek c = a - b;

            Assert.AreEqual(-6, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        //6
        [Test]
        public void OdejmijUjemneLicznikImianownikB()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(-1, -4);

            Ulamek c = a - b;

            Assert.AreEqual(2, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]
        public void PomnozDodatnie()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(1, 4);

            Ulamek c = a * b;

            Assert.AreEqual(1, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]
        public void PomnozUjemne()
        {
            Ulamek a = new Ulamek(-1, -2);
            Ulamek b = new Ulamek(-1, -4);

            Ulamek c = a * b;

            Assert.AreEqual(1, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]
        public void PomnozZzerem()
        {
            Ulamek a = new Ulamek(1, -2);
            Ulamek b = new Ulamek(0, -4);

            Ulamek c = a * b;

            Assert.AreEqual(0, c.licznik);
            Assert.AreEqual(8, c.mianownik);
        }

        [Test]
        public void PodzielDodatnie()
        {
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(1, 4);

            Ulamek c = a / b;

            Assert.AreEqual(4, c.licznik);
            Assert.AreEqual(2, c.mianownik);
        }

        [Test]
        public void PodzielUjemne()
        {
            Ulamek a = new Ulamek(-1, -2);
            Ulamek b = new Ulamek(-1, -4);

            Ulamek c = a / b;

            Assert.AreEqual(4, c.licznik);
            Assert.AreEqual(2, c.mianownik);
        }

        [Test]
        public void PodzielzZerem()
        {
            Ulamek a = new Ulamek(0, 2);
            Ulamek b = new Ulamek(1, 4);

            Ulamek c = a / b;

            Assert.AreEqual(0, c.licznik);
            Assert.AreEqual(2, c.mianownik);
        }
    }
}