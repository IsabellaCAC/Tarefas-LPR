using System;

// definicao da struct Produto
struct Produto
{
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
    
    // metodo para calcular valor total do produto
    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        // array para armazenar os 3 produtos
        Produto[] produtos = new Produto[3];
        double valorTotalEstoque = 0;
        
        Console.WriteLine("--- controle de estoque ---");
        Console.WriteLine("digite os dados de 3 produtos:");
        Console.WriteLine();
        
        // entrada de dados dos produtos
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"produto {i + 1}:");
            
            Console.Write("nome: ");
            produtos[i].Nome = Console.ReadLine();
            
            Console.Write("codigo: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());
            
            Console.Write("preco: R$ ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
            
            Console.Write("quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("-------------------");
        }
        
        Console.WriteLine();
        Console.WriteLine("--- relatorio de estoque ---");
        Console.WriteLine();
        
        // exibir dados dos produtos e calcular valor total
        for(int i = 0; i < 3; i++)
        {
            double valorProduto = produtos[i].ValorTotal();
            valorTotalEstoque += valorProduto;
            
            Console.WriteLine($"produto {i + 1}:");
            Console.WriteLine($"  nome: {produtos[i].Nome}");
            Console.WriteLine($"  codigo: {produtos[i].Codigo}");
            Console.WriteLine($"  preco unitario: R$ {produtos[i].Preco:F2}");
            Console.WriteLine($"  quantidade: {produtos[i].Quantidade}");
            Console.WriteLine($"  valor total: R$ {valorProduto:F2}");
            Console.WriteLine();
        }
        
        // exibir valor total do estoque
        Console.WriteLine("==================================================");
        Console.WriteLine($"valor total em estoque: R$ {valorTotalEstoque:F2}");
        Console.WriteLine("==================================================");
        
        Console.WriteLine();
        Console.WriteLine("pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}