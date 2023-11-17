using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Classes
{

    [Serializable]
    public class Usuario : IComparable<Usuario>
    {
        public string Nome { get; set; }    
        public string Login  { get; set; }
        public string Password { get; set; }
        public int id { get; private set; }

        public char Perfil { get; set; }

        public static int germeID = 0;

        public Usuario(int id)
        {
            this.id = id;
        }

        public Usuario(string nome, string login, string senha, char perfil)
        {
            Nome = nome;
            Login = login;  
            Password = senha;
            id = ++germeID;
            Perfil = perfil;
        }

        public int CompareTo(Usuario u)
        {
            return id.CompareTo(u.id);
        }

        public override string ToString()
        {
            return String.Concat("Código: ", id, ", Nome:", Nome, ", Login: ", Login, ", Perfil: ", Perfil);
        }


    }

    [Serializable]
    public class Contatos : IComparable<Contatos>
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public int id { get; private set; }

        public static int germeID=0;

        public Contatos(int codigo)
        {
            this.id = codigo;
        }
        public Contatos(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            id = ++germeID;
        }

        public int CompareTo(Contatos c)
        {
            return id.CompareTo(c.id);
        }

        public override string ToString()
        {
            return String.Concat(id,", ", Nome,", " , Telefone,", " , Email);
        }

        
    }
}