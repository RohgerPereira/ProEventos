using ProEventos.Domain;

namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public string nome { get; set; }

        public string URL { get; set; }

        public int? EventoId { get; set; }

        public Evento Evento { get; set; }

        public int? PalestranteID { get; set; }

        public Palestrante Palestrante { get; set; }
    }
}