using Api_videogames.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_videogames.DAO
{
    public class VideogameDAO
    {

        public List<VideogameDTO> Listar()
		{
			var conexao = ConnectionFactory.Build();
			conexao.Open();

			var query = "SELECT*FROM JOGOS";

			var comando = new MySqlCommand(query, conexao);
			var dataReader = comando.ExecuteReader();

			var videogames = new List<VideogameDTO>();

			while (dataReader.Read())
			{
				var videogame = new VideogameDTO();
				videogame.ID = int.Parse(dataReader["ID"].ToString());
				videogame.Titulo = dataReader["Titulo"].ToString();
				videogame.Plataforma = dataReader["Plataforma"].ToString();
				videogame.Genero = dataReader["Genero"].ToString();
				videogame.Premios = dataReader["Premios"].ToString();
				videogame.DataLancamento = Convert.ToDateTime(dataReader["DataLancamento"]);
				videogames.Add(videogame);
			}
			conexao.Close();

			return videogames;
		}

		public void Cadastrar(VideogameDTO videogame)
		{
			var conexao = ConnectionFactory.Build();
			conexao.Open();

			var query = @"INSERT INTO JOGOS (Titulo, Plataforma, Genero, Premios, DataLancamento) VALUES
						(@titulo,@plataforma,@genero,@premios,@dataLancamento)";

			var comando = new MySqlCommand(query, conexao);
			comando.Parameters.AddWithValue("@titulo", videogame.Titulo);
			comando.Parameters.AddWithValue("@plataforma", videogame.Plataforma);
			comando.Parameters.AddWithValue("@genero", videogame.Genero);
			comando.Parameters.AddWithValue("@premios", videogame.Premios);
			comando.Parameters.AddWithValue("@dataLancamento", videogame.DataLancamento);

			comando.ExecuteNonQuery();
			conexao.Close();
		}

		public void Remover(int id)
		{
			var conexao = ConnectionFactory.Build();
			conexao.Open();

			var query = @"Delete from JOGOS where id=@id";

			var comando = new MySqlCommand(query, conexao);
			comando.Parameters.AddWithValue("@id", id);

			comando.ExecuteNonQuery();
			conexao.Close();

		}

		public void Alterar(VideogameDTO videogame)
		{
			var conexao = ConnectionFactory.Build();
			conexao.Open();

			var query = @"UPDATE JOGOS SET Titulo = @titulo,
                        Plataforma = @plataforma,
                        Genero = @genero,
                        Premios = @premios,
                        DataLancamento = @dataLancamento
                        where ID = @id";

			var comando = new MySqlCommand(query, conexao);
			comando.Parameters.AddWithValue("@id", videogame.ID);
			comando.Parameters.AddWithValue("@titulo", videogame.Titulo);
			comando.Parameters.AddWithValue("@plataforma", videogame.Plataforma);
			comando.Parameters.AddWithValue("@genero", videogame.Genero);
			comando.Parameters.AddWithValue("@premios", videogame.Premios);
			comando.Parameters.AddWithValue("@dataLancamento", videogame.DataLancamento);

			comando.ExecuteNonQuery();
			conexao.Close();
		}
	}
}
