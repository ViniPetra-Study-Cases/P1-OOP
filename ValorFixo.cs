using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_OOP
{
    public class ProdutoValorFixo : Produto
    {
        public ProdutoValorFixo()
        {

        }

        public ProdutoValorFixo(int id, string nome, float valor) : base(id, nome, valor)
        {

        }
    }
}
