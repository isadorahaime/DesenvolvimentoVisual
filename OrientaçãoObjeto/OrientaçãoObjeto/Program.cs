using Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente c1 = new ContaCorrente();
        Cliente cliente1 = new Cliente();
        Console.WriteLine("Digite o nome do cliente:");
        cliente1.nome = Console.ReadLine();
        c1.titular = cliente1;
        Console.WriteLine("Digite o saldo da conta: ");
        c1.saldo = double.Parse(Console.ReadLine());

        ContaCorrente c2 = new ContaCorrente();
        Cliente cliente2 = new Cliente();
        Console.WriteLine("Digite o nome do cliente:");
        cliente1.nome = Console.ReadLine();
        c1.titular = cliente2;
        Console.WriteLine("Digite o saldo da conta: ");
        c1.saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor que será transferido " + 
            "do cliente" + c1.titular.nome);
        double valor = double.Parse(Console.ReadLine());

        if(c1.Pix(valor, c2))
        {
            Console.WriteLine("Pix realizado com sucesso!");
        }
        Console.ReadLine();
    }
}
