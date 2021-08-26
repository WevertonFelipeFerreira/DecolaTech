using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength (100,MinimumLength = 3,ErrorMessage = "O nome do jogo deve conter entre 3 a 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 a 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range (1.00,1000, ErrorMessage = "O jogo deve custar no minimo 1 real e no maximo 1000!")]
        public double Preco { get; set; }
    }
}
