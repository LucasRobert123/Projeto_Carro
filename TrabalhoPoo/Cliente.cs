using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    class Cliente:Pessoa
    {
        private string telefone;
        private string email;
        private string cidade;

        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public override string MostraDados()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Nome: " + nome);
            str.AppendLine("CPF: " + cpf);
            str.AppendLine("Telefone: " + Telefone);
            str.AppendLine("E-mail: " + Email);
            str.AppendLine("Cidade: " + Cidade);

            return str.ToString();
        }
    }
}
