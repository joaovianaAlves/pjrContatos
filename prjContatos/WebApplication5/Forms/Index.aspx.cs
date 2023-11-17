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
    public partial class Index : System.Web.UI.Page
    {
        protected static List<Contatos> contatos = new List<Contatos>();

        protected static Contatos contatoBusca = null;
        protected List<Contatos> GetContatos()
        {
            return contatos;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (contatos.Count == 0)
            {
                contatos = Serializa.loadContato();
                if (contatos == null)
                {
                    contatos = new List<Contatos>();
                }
                
            }
            txtRelatorio.Text = relatorio();
            lbMensagem.Text = String.Empty;

            btAlterar.Enabled =
            btDeletar.Enabled = contatoBusca != null;

        }
        private String relatorio()
        {
            StringBuilder str = new StringBuilder();

            foreach(Contatos c in contatos)
            {
                str.AppendLine(c.ToString());
            }
            return str.ToString();
        }

        protected bool validaEntrada()
        {
            if (txtNome.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "Digite o nome do contato";
                return false;
            }
            if (txtTelefone.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "Digite o telefone do contato";
                return false;
            }
            if (txtEmail.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "Digite o e-mail do contato";
                return false;
            }

            if (txtEmail.Text.IndexOf('@') < 0) // Não tem @ no email
            {
                lbMensagem.Text = "O e-mail do contato é inválido";
                return false;
            }

            return true;
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            if (!validaEntrada())
            {
                return;
            }

            Contatos contato = new Contatos(
                txtNome.Text,
                txtTelefone.Text,
                txtEmail.Text);

            contatos.Add(contato);
            txtRelatorio.Text = relatorio();
            Serializa.saveContatos(contatos);

        }

        protected void btLimpar_Click(object sender, EventArgs e)
        {
            contatoBusca = null;

            txtCodigo.Text = 
            txtNome.Text =
            txtEmail.Text =
            txtTelefone.Text =
            lbMensagem.Text = String.Empty;

            btAlterar.Enabled =  
            btDeletar.Enabled = false;
        }

        protected void btSair_Click(object sender, EventArgs e)
        {
            btLimpar_Click(sender, e);
            Session.Abandon();
            Session.Clear();   
            txtRelatorio.Text = String.Empty;
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            int codigo;

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                lbMensagem.Text = "Código Digitado inválido";
                return;
            }

            Contatos fajuto = new Contatos(codigo);

            int indice = contatos.BinarySearch(fajuto);

            if (indice < 0)
            {
                btLimpar_Click(sender, e);
                lbMensagem.Text = String.Concat("Código " , codigo , " não encontrado!");                
                return;
            }

            contatoBusca = contatos[indice];

            txtNome.Text = contatoBusca.Nome;
            txtTelefone.Text = contatoBusca.Telefone;
            txtEmail.Text = contatoBusca.Email;
            txtCodigo.Text = contatoBusca.id.ToString("D6");

            btAlterar.Enabled =
            btDeletar.Enabled = true;


        }

        protected void btDeletar_Click(object sender, EventArgs e)
        {
            if (contatoBusca == null)
            {
                lbMensagem.Text = "Erro inesperado, nenhum contato selecionado!";
                return;
            }

            contatos.Remove(contatoBusca);
            btLimpar_Click(sender, e);

            txtRelatorio.Text = relatorio();
            Serializa.saveContatos(contatos);

            

        }

        protected void btAlterar_Click(object sender, EventArgs e)
        {
            if (contatoBusca == null)
            {
                lbMensagem.Text = "Erro inesperado, nenhum contato selecionado!";
                return;
            }

            if (!validaEntrada())
            {
                return;
            }
            contatoBusca.Nome = txtNome.Text;
            contatoBusca.Telefone = txtTelefone.Text;
            contatoBusca.Email = txtEmail.Text;

            txtRelatorio.Text = relatorio();
            Serializa.saveContatos(contatos);

            btLimpar_Click(sender, e);

        }
    }
}