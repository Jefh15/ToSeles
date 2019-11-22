using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService1.Clases;

namespace WcfService1.Clases
{
    public class Consulta_Inventario
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<inventory> getInventorySQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from inventory", cadena);
            adapte.Fill(tabla);

            IList<inventory> retorno = new List<inventory>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                inventory item = new inventory()
                {
                    inventory_id = int.Parse(tabla.Rows[i]["inventory_id"] + ""),
                    film_id = Convert.ToInt32(tabla.Rows[i]["film_id"] + ""),
                    store_id = Convert.ToInt32(tabla.Rows[i]["store_id"] + ""),
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")
                };
                retorno.Add(item);
            }
            return retorno;
        }
    }
}