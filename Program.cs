using System;
/*
 * Consegna: Nel progetto csharp-geometria creare le seguenti classi
1.  Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
    Aggiungere un opportuno costruttore con parametri. Aggiungere due metodi: calcolaArea e 
    calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
2.  Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori
    di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, stampate a video il perimetro e l’area.
3.  Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo)
    e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo
ad esempio cosi:
—— Rettangolo1 —— 
base: 20 cm 
altezza: 10 cm 
Perimetro: 60 cm 
Area: 200 cm2
BONUS Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni,
ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
 */
namespace csharp_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRIMO RETTANGOLO
            Rettangolo rettangolo = new Rettangolo(0,0);
            Console.WriteLine("INSERISCI LA BASE DEL RETTANGOLO");
            rettangolo.baseRettangolo= int.Parse(Console.ReadLine());
            Console.WriteLine("INSERISCI L' ALTEZZA DEL RETTANGOLO");
            rettangolo.altezzaRettangolo= int.Parse(Console.ReadLine());
            Console.WriteLine("AREA DEL RETTANGOLO: {0}",rettangolo.CalcolaArea());
            Console.WriteLine("PERIMETRO DEL RETTANGOLO: {0}",rettangolo.CalcolaPerimetro());
            //DISEGNA
            rettangolo.Disegna();
            //SECONDO RETTANGOLO
            Rettangolo rettangolo2 = new Rettangolo(0,0);
            Console.WriteLine("INSERISCI LA BASE DEL SECONDO RETTANGOLO");
            rettangolo2.baseRettangolo= int.Parse(Console.ReadLine());
            Console.WriteLine("INSERISCI L' ALTEZZA DEL SECONDO RETTANGOLO");
            rettangolo2.altezzaRettangolo= int.Parse(Console.ReadLine());
            Console.WriteLine("AREA DEL RETTANGOLO: {0}",rettangolo.CalcolaArea());
            Console.WriteLine("PERIMETRO DEL RETTANGOLO: {0}",rettangolo.CalcolaPerimetro());




        }
    }
}