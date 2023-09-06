using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {

        //Autenticação com o SQL Server
        private string stringConexao = "Data Source = DESKTOP-2KJISQH\\SENAI; Initial Catalog = inlock_games_manha; User id = sa; pwd = Senai@134; TrustServerCertificate = true";


        /// <summary>
        /// Cadastrar um novo Estudio
        /// </summary>
        /// <param name="novoEstudio">objeto(estudio) com as informações que serão cadastradas</param>
        public void Cadastrar(EstudioDomain novoEstudio)
        {
            //Declara a SqlConnection passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //Declara a instrução a ser executada
                string queryInsert = "INSERT INTO Estudio(Nome) VALUES (@Nome)";


                //Declara o SqlCommand passando a query que será executada e a conexão com o banco de dados
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    //Passa o valor do parametro 
                    cmd.Parameters.AddWithValue("@Nome", novoEstudio.Nome);

                    //Abre a conexão com o banco de dados
                    con.Open();

                    //Executa a query (queryInsert)
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Deletar(int IdEstudio)
        {
            throw new NotImplementedException();
        }

        public List<EstudioDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
