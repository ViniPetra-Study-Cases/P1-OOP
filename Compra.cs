using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_OOP
{
    public class Compra
    {
        public Compra(int id, char status)
        {
            this.id = id;
            this.status = status;
            this.produtos = new List<Produto>();
            this.log = new List<string>();
        }

        public int id { get; private set; }
        public char status { get; private set; }
        public List<Produto> produtos { get; private set; }
        public List<string> log { get; private set; }

        public void Log(string registro)
        {
            this.log.Add(registro);
        }
        
        public void AdicionarProduto(Produto produto)
        {
            if(this.status == 'A')
            {
                this.produtos.Add(produto);
                this.Log("Produto " + produto.nome+" adicionado");
            }
        }

        public void RemoverProduto(Produto produto)
        {
            if (this.status == 'A')
            {
                this.produtos.Remove(produto);
                this.Log("Produto " + produto.nome + " removido");
            }
        }

        public void FecharCompra()
        {
            this.status = 'F';
            this.Log("Compra fechada");
        }

    }
}
