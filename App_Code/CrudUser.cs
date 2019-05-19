using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CrudUser
/// </summary>
public class CrudUser
{
    Conexion conex = new Conexion();
    private SqlConnection con;
    /*para validar el login*/
    private SqlDataReader leer;
    private SqlCommand cmd;
    private String sql = "";
    private List<String> data = new List<String>();
    private DataTable dt;
    private SqlDataAdapter da;
    private Boolean Msg;

    public bool Msg1
    {
        get
        {
            return Msg;
        }

        set
        {
            Msg = value;
        }
    }

    public List<string> Data
    {
        get
        {
            return data;
        }

        set
        {
            data = value;
        }
    }

    public CrudUser()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /*metodo para validar user */
    public List<String> validarLogin(String user, String passs)
    {

        con = new SqlConnection(conex.Cadena);
        /*procedimiento almacenado*/
        sql = "execute inicioSeccion " + user + "," + passs + "";
        cmd = new SqlCommand(sql, con);
        cmd.CommandType = System.Data.CommandType.Text;
        
        try
        {
            con.Open();
            leer = cmd.ExecuteReader();
            if (leer != null)
            {
                if (leer.Read())
                {
                    if (user.Equals(leer[1].ToString()) || passs.Equals(leer[2].ToString()))
                    {
                        Data.Add(leer[0].ToString());
                        Data.Add(leer[3].ToString());
                        Data.Add(leer[4].ToString());
                         
                        Msg1 = true;
                    }
                    else
                    {

                        Msg1 = false;
                    }
                }

            }
            else
            {
                Msg1 = false;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Msg1 = false;
        }
        finally
        {
            con.Close();
        }

        return Data;
    }


}