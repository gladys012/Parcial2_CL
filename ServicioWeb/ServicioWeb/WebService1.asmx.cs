using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        
        [WebMethod]
        public DataSet articulos(string nom)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Username=postgres; Password=123456; Host=localhost; port=5432; database=sis_compras_ventas";
            NpgsqlDataAdapter ada = new NpgsqlDataAdapter();
            ada.SelectCommand = new NpgsqlCommand();
            ada.SelectCommand.Connection = conexion;
            ada.SelectCommand.CommandText = "select*from articulos where articulos.nombre='"+nom+"'";
            ada.SelectCommand.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            ada.Fill(ds);
            conexion.Close();
            return ds;
        }
    }
}
