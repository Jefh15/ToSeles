using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService1.Clases;

namespace WcfService1.Clases
{
    public class Consulta_Film_Text
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<film_text> getfilm_textsSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from film_text", cadena);
            adapte.Fill(tabla);

            IList<film_text> retorno = new List<film_text>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                film_text item = new film_text()
                {
                    film_id = int.Parse(tabla.Rows[i]["film_id"] + ""),
                    title = tabla.Rows[i]["title"] + "",
                    description = tabla.Rows[i]["description"] + "",
                    
                };
                retorno.Add(item);
            }
            return retorno;
        }

    }
}