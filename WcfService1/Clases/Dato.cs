using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WcfService1
{
    public class Dato
    {
        //aqui nos conectariasmos a l SQL
        //private string cadena = "Data Source = SERVIDOR; Initial Catalog = Base de datos; Persist Security Info=True";
        //OJO NOTA: EN DATA SOURCE VA SU Server name: de SQL SERVER, en Initial Catalog = va el nombre de la tabla.
        private static string cadena = "Data Source = DESKTOP-Q0HH8K0; Initial Catalog = sakila; Integrated Security = True";
        public static IList<city> getCitiesSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from city", cadena);
            adapte.Fill(tabla);

            IList<city> retorno = new List<city>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                city item = new city()
                {

                    city_ID = int.Parse(tabla.Rows[i]["city_ID"]+""),
                    City = tabla.Rows[i]["City"] + "",
                    country_ID = tabla.Rows[i]["country_ID"] + "",
                    last_update = tabla.Rows[i]["last_update"] + "",
                };
                retorno.Add(item);
            }
            return retorno;
        }
    }
}