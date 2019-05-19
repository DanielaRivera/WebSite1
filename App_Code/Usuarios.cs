using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuarios
/// </summary>
public class Usuarios
{
    private String user, pass,msg;
    private List<String> data = new List<String>();
    public Usuarios()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Pass
    {
        get
        {
            return pass;
        }

        set
        {
            pass = value;
        }
    }

    public string User
    {
        get
        {
            return user;
        }

        set
        {
            user = value;
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

    public string Msg
    {
        get
        {
            return msg;
        }

        set
        {
            msg = value;
        }
    }

    public void validar()
    {
        CrudUser user = new CrudUser();
        data = user.validarLogin(this.user,this.pass);
        if(user.Msg1.Equals(true))
        {
            this.msg = "Bienvenido"; 
          
        }
        else
        {
            this.msg = "No esta registrado";
        }


    }

}