using LivroCaixa2023.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Classes;

namespace WebApplication5.Forms
{
    public partial class CadUser : System.Web.UI.Page
    {
        private static List<Usuario> listaUsers = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (listaUsers.Count == 0)
            {
                listaUsers = Serializa.loadUsuario();
                if (listaUsers == null)
                {
                    listaUsers = new List<Usuario>();
                }
            }
            txtRelatorio.Text = relatorio();
            lbMensagem.Text = String.Empty;
        }

        private string relatorio()
        {
            StringBuilder str = new StringBuilder();

            foreach (Usuario usario in listaUsers)
            {
                str.AppendLine(usario.ToString());
            }
            return str.ToString();
        }


        protected void btSalvar_Click(object sender, EventArgs e)
        {
            if (txNome.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "Digite o nome do usuário";
                return;
            }
            if (txLogin.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "Digite o login do usuário";
                return;
            }

            if (!rbAdm.Checked && !rbUsr.Checked)
            {
                lbMensagem.Text = "Selecione o perfil do usuário!";
                return;
            }


            if (Session["usuario"] != null) // EDITANDO O USER
            {
                Usuario usuario = (Usuario)Session["usuario"];
                usuario.Nome = txNome.Text;
                usuario.Login = txLogin.Text; 
                usuario.Perfil = rbAdm.Checked ? 'A' : 'U';
                Session["usuario"] = null;
                btExcluir.Enabled = false;
                Serializa.saveUsuario(listaUsers);
                txtRelatorio.Text = relatorio();
                txId.Text =
                txNome.Text =
                txLogin.Text = "";

                rbUsr.Checked = false;
                rbAdm.Checked = false;

                return;

            }

            if (txSenhaInicial.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "Digite a senha inicial do usuário";
                return;
            }           

            // CADASTRANDO O USER
            Usuario u = 
            new Usuario(txNome.Text, txLogin.Text, txSenhaInicial.Text, 
                                    rbAdm.Checked ? 'A':'U');

            listaUsers.Add(u);

            Serializa.saveUsuario(listaUsers);

            txtRelatorio.Text = relatorio();

            Session["usuario"] = null;
            Response.Redirect("~/Forms/login.aspx", true);
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Forms/login.aspx", true);
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;

            btExcluir.Enabled = false;

            int id;

            if (!int.TryParse(txId.Text, out id))
            {
                lbMensagem.Text = "Id digitado inválido";
                return ;
            }
            listaUsers.Sort();
            Usuario u = new Usuario(id);
            int indice = listaUsers.BinarySearch(u);
            if (indice > -1)
            {
                u = listaUsers[indice];
                Session["usuario"] = u;
                btExcluir.Enabled = true;
                txNome.Text = u.Nome;
                txLogin.Text = u.Login;
                txId.Text = u.id.ToString("D6"); 
                if (u.Perfil == 'A')
                {
                    rbAdm.Checked = true;

                } else
                {
                    rbUsr.Checked = true;
                }
            } 
            else
            {
                lbMensagem.Text = "Nenhum usuário com o id " + id;
                txId.Text =
                txNome.Text =
                txLogin.Text = "";
                rbUsr.Checked = false;
                rbAdm.Checked = false;
            }
        }

        protected void btExcluir_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
               lbMensagem.Text = "Erro inesperado nenhum usuário selecionado.";
                return;
            }

            listaUsers.Remove((Usuario)Session["usuario"]);
            Serializa.saveUsuario(listaUsers);

            txtRelatorio.Text = relatorio();

            Session["usuario"] = null;

            rbUsr.Checked = false;
            rbAdm.Checked = false;

            txId.Text = 
            txNome.Text =
            txLogin.Text = "";

        }
    }
}