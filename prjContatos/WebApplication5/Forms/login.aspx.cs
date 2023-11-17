using LivroCaixa2023.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Classes;

namespace WebApplication5.Forms
{
    public partial class login : System.Web.UI.Page
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
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            Usuario logado = null;

            foreach (Usuario u in listaUsers)
            {
                if (u.Login.Trim().ToLower() == txUsuario.Text.Trim().ToLower() &&
                    u.Password.Trim() == txSenha.Text.Trim())
                {
                    logado = u;
                    break;
                }
            }

            if (logado == null)
            {
                lbMensagem.Text = "Usuário não cadastrado!";
                return;
            }

            // Armazenar na sessão que o usuário está autenticado
            Session["UsuarioAutenticado"] = true;
            Session["UsuarioID"] = logado.id;

            if (logado.Perfil == 'A')
            {
                aContato.Visible =
                aUsuario.Visible =
                btCadContatos.Visible =
                    btCadUser.Visible = true;
            }
            else
            {
                Response.Redirect("index.aspx", true);
            }
        }

        protected void btCadUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadUser.aspx", true);
        }

        protected void btCadContatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx", true);
        }
    }
}
