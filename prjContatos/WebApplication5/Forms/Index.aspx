<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication5.Forms.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:650px;">
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="3"  style="text-align:center">
                        <asp:Label ID="lbTitulo" runat="server" Text="Cadastro De Contatos"  Font-Size="XX-Large" Font-Bold="True" ForeColor="#CC3300" /> 
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbNome" runat="server" Text="Nome" /> 
                    </td>
                    <td style="text-align:center">
                        <asp:Label ID="lbCodigo" runat="server" Text="Código Busca" /> 
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:TextBox ID="txtNome" Width="250px" runat="server" /> 
                    </td>
                    <td style="text-align:center" >
                        <asp:Button ID="btOk" runat="server" Text="Ok" OnClick="btOk_Click" width="100"/>
                    </td>
                    <td  style="text-align:center">
                         <asp:TextBox ID="txtCodigo" Width="50px" runat="server" /> 
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lbTelefone" runat="server" Text="Telefone" /> 
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtTelefone" Width="250px" runat="server" /> 
                    </td>
                    <td style="text-align:center">
                        <asp:Button ID="btLimpar" runat="server" Text="Limpar" OnClick="btLimpar_Click" width="100" />
                    </td>
                    <td style="text-align:center">
                        <asp:Button ID="btBuscar" runat="server" Text="Buscar" width="100" OnClick="btBuscar_Click" />
                    </td>

                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbEmail" runat="server" Text="E-Mail" /> 
                    </td>
                    <td style="text-align:center">
                        <asp:Button ID="btAlterar" runat="server" Text="Alterar" width="100" OnClick="btAlterar_Click"  />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtEmail" Width="250px" runat="server" /> 
                    </td>
                    <td style="text-align:center">
                        <asp:Button ID="btSair" runat="server" Text="Sair" OnClick="btSair_Click" width="100"/>
                    </td>
                    <td style="text-align:center">
                        <asp:Button ID="btDeletar" runat="server" Text="Deletar" width="100" OnClick="btDeletar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                 <tr>
                    <td colspan="3">
                        <asp:TextBox ID="txtRelatorio" runat="server" TextMode="MultiLine" Height="298px" ReadOnly="True" Width="650px" /> 
                    </td>
                </tr>
                 <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lbMensagem" runat="server" style="font-size:x-large; color:brown;" /> 
                    </td>
                </tr>
                 <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
