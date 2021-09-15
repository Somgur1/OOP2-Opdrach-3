﻿using System;


namespace Personen
{
    public class Persoon
    {
        public Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            GeboorteDatum = DateTime.Now;

        }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime GeboorteDatum { get; private set; }
        public string Geslacht { get; set; }
       
       

        private double _Gewicht = 1.5;

        public double Gewicht
        {
            get
            {
                return _Gewicht;
            }
            set
            {
                if (value > 1.5 && value < 321.6)
                {
                    _Gewicht = value;
                }
            }
        }

         public virtual string WieBenIk()
        {
            return (Voornaam + Achternaam + GeboorteDatum);

        }

        private int _lengte = 30;
        public int Lengte
        {
            get
            {
                return _lengte;
            }
            set
            {
                if (value > 20)
                {
                    _lengte = value;
                }
            }
        }
    }
}
