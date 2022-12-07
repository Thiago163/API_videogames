using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_videogames.DAO
{
	public class ConnectionFactory
	{
		public static MySqlConnection Build()
		{
			return new MySqlConnection("Server=localhost;Database=VideoGames;Uid=root;Pwd=root;");
		}
	}
}
