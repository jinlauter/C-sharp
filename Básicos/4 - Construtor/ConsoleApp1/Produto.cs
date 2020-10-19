using System;
using System.Globalization;
namespace _1___ExerProduto
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto ()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int Quantidade) : this(nome, preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + " Quantidade em estoque: " + Quantidade + " Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }


}
