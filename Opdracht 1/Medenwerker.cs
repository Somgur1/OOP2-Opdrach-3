using Personen;



namespace Personen
{
    public class Medenwerker : Persoon
    {


        public Medenwerker(string voornaam, string achternaam, string rol) : base(voornaam, achternaam)
        {
            Rol = rol;

        }

        public string Rol { get; set; }

        public override string WieBenIk()
        {
            var WieBenIk = base.WieBenIk();
            return $"{WieBenIk} Mijn rol is {Rol}";
        }



    }
}
