using System;

namespace lab1
{
    class Program
    {
        public interface IEquatable 
        { 
        
        }
        public interface IComparable
        {

        }
        public static void Main(string [] args)
        {
            Ulamek a = new Ulamek();
            Ulamek b = new Ulamek(1,2);
            Ulamek c = new Ulamek(b);
            
 
            Console.WriteLine(b);
            Console.WriteLine(b.ToString());
        
        }
    }
      
        public class Ulamek
    {
            private int licznik;
            private int mianownik;


            public Ulamek()
            {
            this.licznik = 1;
            this.mianownik = 1;

            }
             public Ulamek (int mianownik, int licznik)
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }
            public Ulamek(Ulamek kopia )
            {
            //int a =licznik;
            //int b = mianownik;

            this.licznik = kopia.licznik;
            this.mianownik = kopia.mianownik;
                       
            }


           
        public override string ToString() => $"Licznik{licznik}, Mianownik{mianownik}"; 
            


        

    }
}

