using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Activities.Expressions;


    partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Usuarios user = new Usuarios();
        user.User = usu.Text;
        user.Pass = pass.Text;
        user.validar();
        if(user.Msg.Equals("Bienvenido"))
        {
            Lb.Text = user.Msg;
        }
        else
        {
            Lb.Text = user.Msg;
        }




    }

}
            
