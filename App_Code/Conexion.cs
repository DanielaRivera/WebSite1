using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Conexion
/// </summary>
public class Conexion
{
    private String namedb = "ModuloVentas";//nombre de la db 
    private String usersql = "LAPTOP-RIVERA\\SQLExpress";//asi deve de ir el nombre del usuario
    private String cadena = "";
    public SqlConnection conecdb = new SqlConnection();

    public string Cadena
    {
        get
        {
            return cadena;
        }

        set
        {
            cadena = value;
        }
    }

    public Conexion()
    {
        Cadena = "Data Source=LAPTOP-RIVERA\\SQLExpress;Initial Catalog=ModuloVentas; Integrated Security=True";
    }
}