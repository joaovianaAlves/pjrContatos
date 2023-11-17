using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 
using WebApplication5.Classes;

namespace LivroCaixa2023.Classes
{ 
    [Serializable]
    public class Serializa
    {
        private static String fileContato = "contatos.bin";
        private static String fileUsuario = "usuarios.bin";

        public static void saveUsuario(List<Usuario> lista)
        {
            try
            {
                lista.Sort();
                FileStream fs = new FileStream(fileUsuario, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fs, lista);
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void saveContatos(List<Contatos> lista)
        {
            try
            {
                lista.Sort();
                FileStream fs = new FileStream(fileContato, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fs, lista);
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> loadUsuario()
        {

            try
            {
                if (!File.Exists(fileUsuario)) return null;

                FileStream fs = new FileStream(fileUsuario, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                List<Usuario> lista = (List<Usuario>)formatter.Deserialize(fs);
                fs.Close();

                Usuario.germeID = 0;

                foreach (Usuario c in lista)
                {
                    if (c.id > Usuario.germeID)
                    {
                        Usuario.germeID = c.id;
                    }
                }

                return lista;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Contatos> loadContato()
        {
            
            try
            {
                if (!File.Exists(fileContato)) return null;

                FileStream fs = new FileStream(fileContato,             FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                List<Contatos> lista = (List<Contatos>)formatter.Deserialize(fs);
                fs.Close();

                Contatos.germeID = 0;

                foreach (Contatos c in lista)
                {
                    if (c.id > Contatos.germeID)
                    {
                        Contatos.germeID = c.id;
                    }
                }

                return lista;
             
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}