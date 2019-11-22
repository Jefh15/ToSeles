using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1.Clases
{
    public class Consulta_Category
    {
        //aqui nos conectariasmos a la SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<category> getCategoriesSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from category", cadena);
            adapte.Fill(tabla);

            IList<category> retorno = new List<category>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                category item = new category()
                {
                    category_id = int.Parse(tabla.Rows[i]["category_id"] + ""),
                    name = tabla.Rows[i]["name"] + "",
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")                    
                };
                retorno.Add(item);
            }
            return retorno;
        }

    }
}