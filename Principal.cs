using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_OOP
{
    public partial class Principal : Form
    {
        Funcionário FuncionarioAtual { get; set; }
        List<Funcionário> listaDeFuncionarios = new List<Funcionário>();
        List<Produto> produtos = new List<Produto>();
        List<Produto> carrinho = new List<Produto>();

        public Principal()
        {
            InitializeComponent();
            
            Atendente atendente1 = new Atendente(1, "joao", 123);
            Atendente atendente2 = new Atendente(2, "rodrigo", 123);
            Gerente gerente1 = new Gerente(3, "marcelo", 123);
            listaDeFuncionarios.Add(atendente1);
            listaDeFuncionarios.Add(gerente1);

            Produto maca = new Produto(1, "maca", 5);
            Produto banana = new Produto(2, "banana", 6);
            Produto chocolate = new Produto(3, "chocolate", 8);
            produtos.Add(maca);
            produtos.Add(banana);
            produtos.Add(chocolate);
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            if (FuncionarioAtual == null)
            {
                Login login = new Login();
                login.ShowDialog();
                while (FuncionarioAtual == null)
                {
                    foreach (Funcionário funcionário in listaDeFuncionarios)
                    {
                        if (funcionário.id == login.id && funcionário.Login(login.senha))
                        {
                            FuncionarioAtual = funcionário;
                            this.AtualizarTela();
                            break;
                        }
                    }
                }
            }

            foreach (Produto produto in produtos)
            {
                lstProdutos.Items.Add(produto.id + ", " + produto.nome + "\n");
            }
        }

        private void btnIniciarCompra_Click(object sender, EventArgs e)
        {
            FuncionarioAtual.AbrirCompra(1);
            pnlLogado.BringToFront();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int control = 0;
            while (control != Int32.Parse(txtQuantidade.Text))
            {
                lstCarrinho.Items.Add(lstProdutos.SelectedItem);
                foreach (Produto produto in produtos)
                {
                    if (lstProdutos.SelectedItem.ToString().StartsWith(produto.id.ToString()))
                    {
                        carrinho.Add(produto);
                    }
                }
                control++;
            }
            UpdateValor();
        }

        public void UpdateValor()
        {
            float soma = 0;
            foreach(Produto produto in carrinho)
            {
                soma += produto.preço;
            }
            lblValor.Text = "R$" + soma.ToString();
        }
        public void AtualizarTela()
        {
            lblGreetings.Text = "Bem vindo, " + FuncionarioAtual.nome + ".";
            if(FuncionarioAtual is Gerente)
            {
                pnlGerente.BringToFront();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lstCarrinho.Items.Remove(lstCarrinho.SelectedItem);
            foreach (Produto produto in produtos)
            {
                if (lstCarrinho.SelectedItem.ToString().StartsWith(produto.id.ToString()))
                {
                    carrinho.Remove(produto);
                }
            }
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.ShowDialog();

            int valor = pagamento.valor;
            int valorAtual = Int32.Parse((lblValor.Text).Replace("R$", ""));

            lblValor.Text = (valorAtual - valor).ToString();

            if (valorAtual == 0)
            {
                MessageBox.Show("Compra finalizada!");
                this.Close();
            }
        }
    }
}
