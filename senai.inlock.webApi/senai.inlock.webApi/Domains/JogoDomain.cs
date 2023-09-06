using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }

        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "É necessário uma descrição para o jogo.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "É necessário inserir a data de lançamento do jogo.")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O valor do jogo é obrigatório!")]
        public float Valor { get; set; }

        public int IdEstudio { get; set; }
    }
}
