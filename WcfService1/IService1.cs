using javax.management.openmbean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract, WebGet(UriTemplate = "GetData", ResponseFormat = WebMessageFormat.Json)]
        string GetData();

        [OperationContract, WebGet(UriTemplate = "getCliente", ResponseFormat = WebMessageFormat.Json)]
        Cliente getCliente();


        [OperationContract, WebGet(UriTemplate = "getClientes", ResponseFormat = WebMessageFormat.Json)]
        IList<Cliente> getClientes();


        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getCitiesSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<city> getCitiesSQL();


    }

    
}
