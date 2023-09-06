using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }

        [Required(ErrorMessage = "O nome do jogo é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "É necessário uma descrição para o jogo")]
        public string? Descricao { get; set; }


        public int IdGenero { get; set; }

        public GeneroDomain? Genero { get; set; }
    }
}
