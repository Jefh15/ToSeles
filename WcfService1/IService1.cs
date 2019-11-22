using javax.management.openmbean;
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

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getCategoriesSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<category> getCategoriesSQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getInventorySQL", ResponseFormat = WebMessageFormat.Json)]
        IList<inventory> getInventorySQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getActorsSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<actor> getActorsSQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getFilm_actorsSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<film_actor> getFilm_actorsSQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getfilm_textsSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<film_text> getfilm_textsSQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getLanguagesSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<language> getLanguagesSQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getFilm_CategorysSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<film_category> getFilm_CategorysSQL();

        //ESTE ES EL QUE FUNCIONA CON SQL AGARREN DE ESTE
        [OperationContract, WebGet(UriTemplate = "getFilmsSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<film> getFilmsSQL();
       

    }

    
}
