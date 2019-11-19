using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
    }
}
