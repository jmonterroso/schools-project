using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Capa.Logica
{
    public class UsuarioLN
    {
        public void Guardar(Usuario usu)
        {
            if (usu.Identificacion.Length == 0)
                throw new ApplicationException("Debe digitar su identificacion");

            UsuarioDatos datos = new UsuarioDatos();
            if (datos.SeleccionarPorId(usu.Identificacion) == null)
            {
                usu.Password = Cifrar(usu.Password);
                datos.Insertar(usu);
            }
            else
                datos.Actualizar(usu);
        }
        public Usuario Login(Usuario usu)
        {
            if (usu.Identificacion.Length == 0)
                throw new ApplicationException("Debe digitar su identificacion");

            UsuarioDatos datos = new UsuarioDatos();
            Usuario us = new Usuario();
            us = datos.SeleccionarPorId(usu.Identificacion);
            if ( us == null)
            {
                return null;
            }
            else
            {
                if(Decifrar(us.Password) == usu.Password){
                    return us;
                }
                else
                {
                    throw new ApplicationException("Los passwords son diferentes");
                }
            }
                

           
        }

        public List<Usuario> SeleccionarTodos()
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(Usuario usu)
        {
            UsuarioDatos datos = new UsuarioDatos();

            if (datos.SeleccionarPorId(usu.Identificacion) == null)
                throw new ApplicationException("El usuario no existe");

            datos.Eliminar(usu);
        }
        public static string Cifrar(string encryptString)
        {
            string EncryptionKey = "ProyectoProgramacion";      
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public static string Decifrar(string cipherText)
        {
            string EncryptionKey = "ProyectoProgramacion";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    
}
}

    

