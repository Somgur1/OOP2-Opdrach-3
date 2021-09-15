using System;
using Personen;
using System.Collections;
using static System.Console;
using System.Collections.Generic;

namespace Opdracht_2
{
    class Program
    {
        public static List<Persoon> personen;
        

        


        public static void Invullen()
        {
            Console.WriteLine("Vul uw voornaam in");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Vul uw achternaam in");
            string achternaam = Console.ReadLine();
            Persoon Persoon = new Persoon(voornaam, achternaam);
            personen.Add(Persoon);
            var rol = "Manager";
            Medenwerker Medenwerker = new Medenwerker(voornaam, achternaam, rol);
            personen.Add(Medenwerker);
            var afdeling = "Directie";
            Manager Manager = new Manager(voornaam, achternaam, rol, afdeling);
            personen.Add(Manager);
            //Medenwerker();

        }
       
        public static void LatenZien()
        {
            foreach (var persoon in personen)
            {
                Console.WriteLine(persoon.WieBenIk());
                
                
            }

        }

        static void Main(string[] args)
        {
            personen = new List<Persoon>();
            Invullen();
            LatenZien();
        }
    }
}
