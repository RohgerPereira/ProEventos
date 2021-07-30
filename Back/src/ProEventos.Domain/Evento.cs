using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain

{
   // [Table("sis.Eventos")]
    public class Evento
    {
        //[Key]
        public int  Id {get; set; }
        public string Local {get; set; }
        public  DateTime? DataEvento {get; set; }

        // [NotMapped]
        // public int ContagemDias {get; set;}
        
        [Required]
        public string Tema {get; set; }

        public int QtdPessoas {get; set; }

        public string ImagemUrl {get; set; }

        public String Telefone {get; set; }

        public String Email { get; set; }    

        public  IEnumerable<Lote> Lotes { get; set; }

        public  IEnumerable<RedeSocial> RedesSociais { get; set; }

        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }

    }
}