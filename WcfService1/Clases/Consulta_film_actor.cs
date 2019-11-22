using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService1.Clases;

namespace WcfService1.Clases
{
    public class Consulta_film_film_actor
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<film_actor> getFilm_actorsSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from film_actor", cadena);
            adapte.Fill(tabla);

            IList<film_actor> retorno = new List<film_actor>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                film_actor item = new film_actor()
                {
                    actor_id = int.Parse(tabla.Rows[i]["actor_id"] + ""),
                    film_id = int.Parse(tabla.Rows[i]["film_id"] + ""),
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")
                };
                retorno.Add(item);
            }
            return retorno;
        }
    }
}