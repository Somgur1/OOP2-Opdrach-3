using System;
using System.Collections.Generic;
using System.Text;
using Personen;


namespace Personen
{
    public class Manager : Medenwerker
    {
        public Manager(string voornaam, string achternaam, string rol, string afdeling) : base(voornaam, achternaam, rol)
        {
            Afdeling = afdeling;

        }

        public string Afdeling { get; set; }

        public override string WieBenIk()
        {
            var WieBenIk = base.WieBenIk();
            return $"{WieBenIk} Mijn afdeling is {Afdeling}";
        }

    }
}

