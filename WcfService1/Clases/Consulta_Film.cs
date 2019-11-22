using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using WcfService1.Clases;

namespace WcfService1.Clases
{
    public class Consulta_Film
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<film> getFilmsSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from film", cadena);
            adapte.Fill(tabla);

            byte original = 0;
            IList <film> retorno = new List<film>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                film item = new film()
                {
                    film_id = int.Parse(tabla.Rows[i]["film_id"] + ""),
                    title = tabla.Rows[i]["title"] + "",
                    description = tabla.Rows[i]["description"] + "",
                    release_year = tabla.Rows[i]["release_year"] + "",
                    language_id = int.Parse(tabla.Rows[i]["language_id"] + ""),
                    original_language_id = Convert.ToByte(tabla.Rows[i]["original_language_id"] + ""),
                    rental_duration = int.Parse(tabla.Rows[i]["rental_duration"] + ""),
                    rental_rate = decimal.Parse(tabla.Rows[i]["rental_rate"] + ""),
                    length = int.Parse(tabla.Rows[i]["length"] + ""),
                    replacement_cost = Convert.ToDecimal(tabla.Rows[i]["replacement_cost"] + ""),
                    rating = tabla.Rows[i]["rating"] + "",
                    special_features = tabla.Rows[i]["special_features"] + "",
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")
                    
                };
                
                retorno.Add(item);

            }
            return retorno;
            
        }
    }
}