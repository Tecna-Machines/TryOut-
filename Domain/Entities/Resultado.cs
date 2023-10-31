namespace Domain.Entities
{
    public class Resultado
    {
        public Guid IdResultado { get; set; }
        public int CantMalas { get; set; }
        public int CantBuenas { get; set; }
        public int CantScrap { get; set; }
        public int CantBuenasEnCajaMalas { get; set; }
        public int CantMalasEnCajaBuenas { get; set; }
        public int Numprueba { get; set; }
        public Prueba? Prueba { get; set; }
    }
}
