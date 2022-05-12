namespace csharp_geometria
{
    public class Rettangolo
    {
         public int baseRettangolo;
         public int altezzaRettangolo;
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }
        public int CalcolaArea()
        {
            int area= baseRettangolo*altezzaRettangolo;
            return area;
        }public int CalcolaPerimetro()
        {
            int perimetro= baseRettangolo*2 + altezzaRettangolo*2;
            return perimetro;
        }
        public void Disegna()
        {
            Console.Write("+");
            for (int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("-");
                if(i==baseRettangolo-1) Console.Write("+");


            }
            Console.WriteLine("");
            for(int j = 0; j < altezzaRettangolo; j++)
            {
                Console.WriteLine("|");
            }
            Console.Write("+");
            for (int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("-");
                if (i == baseRettangolo - 1) Console.Write("+");


            }
        }
    }
}