/*
 * Created by SharpDevelop.
 * User: ALUMNOS
 * Date: 04/12/2014
 * Time: 06:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
namespace practicabd
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL()
		{
	
		}
		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=agenda;" +
	          	"User ID=root;" +
	          	"Password=;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}				
		
		
	}
}

