using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1.Clases
{
    public class Consulta_Film_Category
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<film_category> getFilm_CategorysSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from film_category", cadena);
            adapte.Fill(tabla);

            IList<film_category> retorno = new List<film_category>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                film_category item = new film_category()
                {
                    film_id = int.Parse(tabla.Rows[i]["film_id"] + ""),
                    category_id = Convert.ToInt32(tabla.Rows[i]["category_id"] + ""),
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")
                };
                retorno.Add(item);
            }
            return retorno;
        }
    }
}