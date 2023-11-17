<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication5.Forms.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="frmLogin" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="font-size: larger; text-align: center">
                        <asp:Label ID="lbTilulo" runat="server" Text="Login" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbUsuario" runat="server" Text="Usuário" />
                    </td>
                    <td>
                        <asp:TextBox ID="txUsuario" runat="server" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbSenha" runat="server" Text="Senha" />
                    </td>
                    <td>
                        <asp:TextBox ID="txSenha" runat="server"
                            Width="100px" TextMode="Password" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="btOk" runat="server"
                            Text="OK" Width="50px" OnClick="btOk_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" >
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center">
                        <asp:Button ID="btCadUser" runat="server" Text="Usuário" Visible="false" 
                            OnClick="btCadUser_Click" />
                        <a href="cadUser.aspx" 
                            runat="server" id="aUsuario" visible="false" > Usuário</a>
                    </td>
                    <td style="text-align:center" >
                        <asp:Button ID="btCadContatos" runat="server" Text="Contato" Visible="false" 
                            OnClick="btCadContatos_Click"/>
                         <a href="index.aspx"  runat="server" id="aContato" visible="false" > Contato</a>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;
                    </td>
                </tr>               
            </table>
            <p></p>
            <p></p>
            <p></p>
            <p></p>
            <asp:Label ID="lbMensagem" runat="server" 
                style="font-size:x-large; color:brown;"/> 
        </div>
    </form>
</body>
</html>
