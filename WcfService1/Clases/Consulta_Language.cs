using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService1.Clases;

namespace WcfService1.Clases
{
    public class Consulta_Language
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<language> getLanguagesSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from language", cadena);
            adapte.Fill(tabla);

            IList<language> retorno = new List<language>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                language item = new language()
                {
                    language_id = int.Parse(tabla.Rows[i]["language_id"] + ""),
                    name = tabla.Rows[i]["name"] + "",
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")
                };
                retorno.Add(item);
            }
            return retorno;
        }
    }
}