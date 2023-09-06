using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class TipoDeUsuario
    {
        public int IdTipoDeUsuario { get; set; }

        [Required(ErrorMessage = "O campo titulo é obrigatório!")]
        public string Titulo { get; set; }

    }
}
