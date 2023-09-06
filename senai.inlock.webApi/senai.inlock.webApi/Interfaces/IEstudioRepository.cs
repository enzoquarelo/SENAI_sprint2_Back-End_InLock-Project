using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório EstudioRepository
    /// Definir os métodos que serão implementados pelo EstudioRepository
    /// </summary>
    public interface IEstudioRepository
    {
        /// <summary>
        /// Cadastrar um novo estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto que será cadastrado</param>
        void Cadastrar(EstudioDomain novoEstudio);

        /// <summary>
        /// Listar todos os objetos(estudios) cadastrados
        /// </summary>
        /// <returns>Lista com os objetos(estudios)</returns>
        List<EstudioDomain> ListarTodos();

        /// <summary>
        /// deleta um objeto
        /// </summary>
        /// <param name="IdEstudio">objeto(estudio) que sera deletado</param>
        void Deletar(int IdEstudio);
    }
}
