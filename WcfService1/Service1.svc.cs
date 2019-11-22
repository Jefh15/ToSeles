using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Clases;

namespace WcfService1
{
    public class Service1 : IService1
    {

        public string GetData()
        {
            return "METODO WCF";
        }

        public Cliente getCliente()
        {
            return new Cliente()
            {
                codigo = "001",
                name = "Jesus Fonseca",
                ruc = "116190799"
            };
        }

        public IList<Cliente> getClientes()
        {
            IList<Cliente> retorno = new List<Cliente>();
            for (int i = 0; i < 100; i++)
            {
                retorno.Add(new Cliente()
                {
                    codigo = "00" + i,
                    name = "Cliente #" + i,
                    ruc = "i" + i
                });
            }
            return retorno;
        }


        //meotod que llamada mi ciudades de SQL
        public IList<city> getCitiesSQL()
        {
            return Dato.getCitiesSQL();
        }

        public IList<category> getCategoriesSQL()
        {
            return Consulta_Category.getCategoriesSQL();
        }

        public IList<inventory> getInventorySQL()
        {
            return Consulta_Inventario.getInventorySQL();
        }

        public IList<actor> getActorsSQL()
        {
            return Consulta_Actores.getActorsSQL();
        }

        public IList<film_actor> getFilm_actorsSQL()
        {
            return Consulta_film_film_actor.getFilm_actorsSQL();
        }

        public IList<film_text> getfilm_textsSQL()
        {
            return Consulta_Film_Text.getfilm_textsSQL();
        }

        public IList<language> getLanguagesSQL()
        {
            return Consulta_Language.getLanguagesSQL();
        }

        public IList<film_category> getFilm_CategorysSQL()
        {
            return Consulta_Film_Category.getFilm_CategorysSQL();
        }

        public IList<film> getFilmsSQL()
        {
            return Consulta_Film.getFilmsSQL();
        }
    }
}
