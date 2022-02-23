using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Titular
    {
        int id;
        string nome;
        string cpf;

        public Titular()
        {

        }
        public Titular(int id, string nome, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }
    }
}
