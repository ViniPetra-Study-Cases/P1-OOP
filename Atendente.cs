using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_OOP
{
    public class Atendente : Funcionário
    {
        public Atendente()
        {

        }

        public Atendente(int id, string nome, int senha) : base (id, nome, senha)
        {

        }
    }
}
