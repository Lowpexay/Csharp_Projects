using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"{Nome} - R${Preco:F2}";
    }
}

class CatalogoProdutos
{
    private List<Produto> produtos;

    public CatalogoProdutos()
    {
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(string nome, double preco)
    {
        Produto novoProduto = new Produto(nome, preco);
        produtos.Add(novoProduto);
        Console.WriteLine($"Produto '{nome}' adicionado com sucesso.");
    }

    public void ListarProdutos()
    {
        Console.WriteLine("Catálogo de Produtos:");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
}

class Program
{
    static void Main()
    {
        CatalogoProdutos catalogo = new CatalogoProdutos();

        catalogo.AdicionarProduto("Notebook", 2500.99);
        catalogo.AdicionarProduto("Smartphone", 1200.50);
        catalogo.AdicionarProduto("SmartWatch", 500.50);

        catalogo.ListarProdutos();
    }
}
