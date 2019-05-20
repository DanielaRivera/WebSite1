<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    
    <style type="text/css">
        .auto-style3 {
            text-align: left;
            color: #FFFFFF;
        }
        .auto-style4 {
            width: 79px;
            text-align: left;
        }
        .auto-style5 {
            width: 118px;
            text-align: left;
            height: 29px;
        }
        .auto-style7 {
            width: 493px;
            text-align: left;
        }
        .auto-style9 {
            width: 100%;
            height: 147px;
        }
        .auto-style12 {
            width: 118px;
            height: 29px;
        }
        .auto-style18 {
            width: 493px;
            height: 29px;
        }
        .auto-style19 {
            width: 79px;
            height: 29px;
        }
        .auto-style20 {
            text-align: left;
            color: #FFFFFF;
            height: 29px;
        }
        .auto-style21 {
            text-align: left;
            color: #FFFFFF;
            width: 493px;
            height: 30px;
        }
        .auto-style22 {
            text-align: left;
            color: #FFFFFF;
            height: 30px;
        }
        .auto-style23 {
            height: 30px;
        }
        .auto-style24 {
            width: 118px;
        }
        .auto-style25 {
            width: 143px;
            height: 21px;
        }
        .auto-style26 {
            background-color: #000000;
        }
        .auto-style27 {
            text-align: center;
        }
    </style>
</head>
<body style="background-color: #000000">
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <table class="auto-style9">
            <h2 style="color: #FFFFFF; background-color: #000000" class="auto-style27">
        Login</h2>
            <h2 style="color: #FFFFFF; background-color: #000000" class="auto-style27">
        &nbsp;<asp:Image ID="Image1" runat="server" CssClass="auto-style26" Height="115px" ImageUrl="~/Imagen/user.png" Width="129px" />
            </h2>
            <tr>
                <td class="auto-style18">
                    &nbsp;</td>
                <td class="auto-style19">
                    <h3 class="auto-style3">Usuario:</h3>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="usu" runat="server" style="font-weight: 700" Width="139px"></asp:TextBox>
                </td>
                <td class="auto-style20">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">
                    &nbsp;</td>
                <td class="auto-style19">
                    <h3 class="auto-style3">Password:</h3>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="pass" runat="server" TextMode="Password" style="font-weight: 700" Width="137px">****</asp:TextBox>
                </td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style4"></td>
                <td class="auto-style24">
                    <h4 class="auto-style25">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" Width="81px" style="font-weight: 700" />
                    </h4>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style21" >&nbsp;</td>
                <td class="auto-style22" >&nbsp;</td>
                <td class="auto-style23" ></td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21" >&nbsp;</td>
                <td class="auto-style22" >&nbsp;</td>
                <td class="auto-style23" >
                    <h5 class="auto-style3">
                    <asp:Label ID="Lb" runat="server"></asp:Label>
                    </h5>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>



    



</body>
</html>
