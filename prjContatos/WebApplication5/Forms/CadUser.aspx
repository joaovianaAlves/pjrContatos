<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadUser.aspx.cs" Inherits="WebApplication5.Forms.CadUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro De Usuários</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 500px">
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td  colspan="3" style="text-align: center">
                        <asp:Label ID="lbTitulo" runat="server" Text="Cadastro de Usuários" Font-Size="XX-Large" ForeColor="Brown" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbNome" runat="server" Text="Nome" /></td>
                    <td>
                        <asp:Label ID="lbId" runat="server" Text="ID" /></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txNome" runat="server" Width="200px" /></td>
                    <td>
                        <asp:TextBox ID="txId" runat="server" Width="60px" /></td>
                    <td>
                        <asp:Button ID="btBuscar" runat="server" Text="Buscar"  Width="60px" OnClick="btBuscar_Click" />
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbLogin" runat="server" Text="Login" /></td>
                    <td><asp:Label ID="lbPerfil" runat="server" Text="Perfil" /></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txLogin" runat="server" Width="200px" /></td>
                    <td> 
                        <asp:Label ID="lbAdm" runat="server" Text="Adm"  />
                        <asp:RadioButton ID="rbAdm" runat="server" GroupName="tipo" />&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lbUsr" runat="server" Text="Usr" />
                        <asp:RadioButton ID="rbUsr" runat="server" GroupName="tipo" />
                    </td>
                    <td>&nbsp;
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lbSenhaInicial" runat="server" Text="Senha Inicial" /></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>
                        <asp:TextBox ID="txSenhaInicial" runat="server" Width="200px" /></td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btExcluir" runat="server" Text="Excluir" Width="60px"  Enabled="false" OnClick="btExcluir_Click" />
                    </td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btSalvar" runat="server" Text="Salvar" Width="60px" OnClick="btSalvar_Click"/>
                    </td>
                </tr>


                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lbMensagem" runat="server" Text="Mensagem" Font-Size="Large" ForeColor="Brown" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>

                <tr>
                    <td colspan="3">
                            <asp:TextBox ID="txtRelatorio" runat="server" TextMode="MultiLine" Height="200px" ReadOnly="True" Width="500px" /> 
                            <asp:Button ID="btnVoltar" runat="server" Text="Voltar para Login" OnClick="btnVoltar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
