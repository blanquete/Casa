using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            connectionBBDD.ObtenerConexion();
            Cliente c = new Cliente();

            c.ID = 1;
            c.nombre = "Raul";

            int resultado = c.Agregar(c);


            Console.ReadKey();
        }
    }

}
