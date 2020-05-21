using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    public class Excecao : ApplicationException
    {
        public Excecao() : base("Erro")
        {

        }

        public Excecao(string e) : base(e) 
        { 
        }

        public Excecao(string s, Exception e)
        {
            throw new Excecao("Erro: " + s + " " + e.Message);
        }
    }
}
