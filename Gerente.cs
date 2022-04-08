using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_OOP
{
    public class Gerente : Funcionário
    {
        public Gerente()
        {

        }

        public Gerente(int id, string nome, int senha) : base(id, nome, senha)
        {

        }

        public void RemoverItem(Produto produto, int quantidade, Compra compra)
        {
            int control = 0;
            while (control != quantidade)
            {
                compra.RemoverProduto(produto);
                control++;
            }
        }
    }
}
