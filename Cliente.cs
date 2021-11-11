using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        
        public Cliente() { }

        public Cliente(int pId, string pNombre)
        {
            this.ID = pId;
            this.nombre = pNombre;
        }
        public  int Agregar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into  persona(ID, nombre) values('{0}','{1}')", pCliente.ID, pCliente.nombre), connectionBBDD.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }
    }
}
