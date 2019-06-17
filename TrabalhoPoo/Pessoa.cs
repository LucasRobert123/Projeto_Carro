using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    abstract class Pessoa
    {
        protected string nome;
        protected string cpf;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        abstract public string MostraDados();
        
    }
}
