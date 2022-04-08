namespace P1_OOP
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblValorDescritivo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.btnIniciarCompra = new System.Windows.Forms.Button();
            this.pnlLogado = new System.Windows.Forms.Panel();
            this.lstCarrinho = new System.Windows.Forms.ListBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.pnlGerente = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.pnlInicio.SuspendLayout();
            this.pnlLogado.SuspendLayout();
            this.pnlGerente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(251, 201);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(12, 28);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(35, 13);
            this.lblGreetings.TabIndex = 3;
            this.lblGreetings.Text = "label1";
            // 
            // lblValorDescritivo
            // 
            this.lblValorDescritivo.AutoSize = true;
            this.lblValorDescritivo.Location = new System.Drawing.Point(374, 367);
            this.lblValorDescritivo.Name = "lblValorDescritivo";
            this.lblValorDescritivo.Size = new System.Drawing.Size(34, 13);
            this.lblValorDescritivo.TabIndex = 4;
            this.lblValorDescritivo.Text = "Valor:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(415, 367);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(27, 13);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "R$0";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(241, 165);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(264, 134);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.btnIniciarCompra);
            this.pnlInicio.Location = new System.Drawing.Point(15, 71);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(598, 396);
            this.pnlInicio.TabIndex = 8;
            // 
            // btnIniciarCompra
            // 
            this.btnIniciarCompra.Location = new System.Drawing.Point(236, 188);
            this.btnIniciarCompra.Name = "btnIniciarCompra";
            this.btnIniciarCompra.Size = new System.Drawing.Size(102, 23);
            this.btnIniciarCompra.TabIndex = 0;
            this.btnIniciarCompra.Text = "Nova compra";
            this.btnIniciarCompra.UseVisualStyleBackColor = true;
            this.btnIniciarCompra.Click += new System.EventHandler(this.btnIniciarCompra_Click);
            // 
            // pnlLogado
            // 
            this.pnlLogado.Controls.Add(this.btnPagamento);
            this.pnlLogado.Controls.Add(this.lstCarrinho);
            this.pnlLogado.Controls.Add(this.lstProdutos);
            this.pnlLogado.Controls.Add(this.btnAdicionar);
            this.pnlLogado.Controls.Add(this.lblValorDescritivo);
            this.pnlLogado.Controls.Add(this.lblValor);
            this.pnlLogado.Controls.Add(this.txtQuantidade);
            this.pnlLogado.Controls.Add(this.lblQuantidade);
            this.pnlLogado.Location = new System.Drawing.Point(12, 68);
            this.pnlLogado.Name = "pnlLogado";
            this.pnlLogado.Size = new System.Drawing.Size(600, 434);
            this.pnlLogado.TabIndex = 9;
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.FormattingEnabled = true;
            this.lstCarrinho.Location = new System.Drawing.Point(377, 27);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(153, 316);
            this.lstCarrinho.TabIndex = 9;
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(15, 27);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(172, 316);
            this.lstProdutos.TabIndex = 8;
            // 
            // pnlGerente
            // 
            this.pnlGerente.Controls.Add(this.btnRemover);
            this.pnlGerente.Location = new System.Drawing.Point(240, 300);
            this.pnlGerente.Name = "pnlGerente";
            this.pnlGerente.Size = new System.Drawing.Size(129, 63);
            this.pnlGerente.TabIndex = 10;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(27, 19);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(377, 394);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(75, 23);
            this.btnPagamento.TabIndex = 10;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 577);
            this.Controls.Add(this.pnlLogado);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlGerente);
            this.Controls.Add(this.lblGreetings);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnlInicio.ResumeLayout(false);
            this.pnlLogado.ResumeLayout(false);
            this.pnlLogado.PerformLayout();
            this.pnlGerente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblValorDescritivo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Button btnIniciarCompra;
        private System.Windows.Forms.Panel pnlLogado;
        private System.Windows.Forms.ListBox lstCarrinho;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Panel pnlGerente;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPagamento;
    }
}

