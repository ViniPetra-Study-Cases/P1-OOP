using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_OOP
{
    public class Funcionário
    {
        public Funcionário(int id, string nome, int senha)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
        }

        public Funcionário()
        {

        }

        public int id { get; private set; }
        public int senha { get; private set; }
        public string nome { get; private set; }

        public void LancarProdutoFixo(Produto produto, int quantidade, Compra compra)
        {
            int control = 0;
            while(control != quantidade)
            {
                compra.AdicionarProduto(produto);
                control++;
            }
        }
        
        public void FecharCompra(Compra compra)
        {
            compra.FecharCompra();
        }

        public Compra AbrirCompra(int id)
        {
            Compra compra = new Compra(id, 'A');
            compra.Log("Compra aberta");
            return compra;
        }

        public bool Login(int senha)
        {
            if (senha == this.senha)
            {
                return true;
            } else return false;
        }
    }
}
