using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_OOP
{
    public class Produto
    {
        public Produto()
        {

        }

        public Produto(int id, string nome, float preço)
        {
            this.id = id;
            this.nome = nome;
            this.preço = preço;
        }

        public int id { get; private set; }
        public string nome { get; private set; }
        public float preço { get; private set; }
    }
}
