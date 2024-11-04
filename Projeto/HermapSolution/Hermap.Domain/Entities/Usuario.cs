using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Hermap.Domain.Entities
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        private byte[] senhaHash;
        private byte[] senhaSalt;

        public void DefinirSenha(string senha)
        {
            // Gera um salt aleatório para a senha
            using(var hmac = new HMACSHA512())
            {
                senhaSalt = hmac.Key;
                senhaHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(senha));
            }
        }

        public bool VerificarSenha(string senha)
        {
            using (var hmac = new HMACSHA512())
            {
                var computeHasg = hmac.ComputeHash (Encoding.UTF8.GetBytes(senha));
                for (int i = 0; i < computeHasg.Length; i++)
                {
                    if (computeHasg[i] != senhaHash[i]) return false;
                }
            }
            return true;
        }
        public void CadastrarUsuario()
        {

        }
    }

}
