using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProEventos.Domain;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int  Id {get; set; }
        public string Local {get; set; }
        public  string DataEvento {get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio."),
        //MinLength(3, ErrorMessage ="{0} deve ter no mínimo quatro cacteres"),
        //MaxLength(50, ErrorMessage ="{0} deve ter no máximo 50 cacteres")
        StringLength(50, MinimumLength = 3, ErrorMessage ="O {0} deve ter no mínimo 3 caracteres e no máximo 50 caracteres.")]
        public string Tema {get; set; }

        [Display(Name="Quantidade de Pessoas"),
        Range(1, 120000, ErrorMessage ="{0} não pode ser menor do que 1 e maior do que 120000.")]
        public int QtdPessoas {get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="Não é uma imagem valida. (gif, jpg, jpeg, bmp ou png).")]
        public string ImagemUrl {get; set; }
        
        [Required(ErrorMessage ="O Campo {0} é obrigatório"),
        Phone(ErrorMessage ="O campo {0} está com número invalido")]
        public string Telefone {get; set; }
        [Display(Name = "E-mail"),
        Required(ErrorMessage ="o campo {0} é obrigatório."),
        EmailAddress(ErrorMessage ="O {0} precisa ser valido.")]
        public string Email { get; set; }    

        public  IEnumerable<LoteDto> Lotes { get; set; }

        public  IEnumerable<RedeSocialDto> RedesSociais { get; set; }

        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}