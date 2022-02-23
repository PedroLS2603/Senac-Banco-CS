using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
     
namespace Banco
{    
    class Program
    {
        static void Main(string[] args)
        {
            string nomeTitular, cpfTitular;
            int idTitular, idConta, opcao;
            bool fim = false, login = false;
            Conta[] contas = new Conta[5];
            Conta contaAtual = null;


            Titular titular = new Titular(1, "padrao1", "123");
            Conta conta = new Conta(1, 200, 1, titular);
            contas.Append(conta);

            titular = new Titular(2, "padrao2", "456");
            conta = new Conta(2, 200, 1, titular);
            contas.Append(conta);

            titular = new Titular(3, "padrao3", "789");
            conta = new Conta(3, 200, 1, titular);
            contas.Append(conta);

            titular = new Titular(4, "padrao4", "100");
            conta = new Conta(4, 200, 1, titular);
            contas.Append(conta);

            titular = new Titular(5, "padrao5", "110");
            conta = new Conta(5, 200, 1, titular);
            contas.Append(conta);

            do {
                Console.Write("Digite o número da conta: ");
                idConta = Int32.Parse(Console.ReadLine());

                Console.Write("Digite o CPF do titular: ");
                cpfTitular = Console.ReadLine();

                while(!login)
                {
                    foreach (Conta registro in contas)
                    {
                        if (cpfTitular == registro.getTitular().getCpf() && idConta == registro.getId())
                        {
                            login = true;
                            contaAtual = registro;
                        }
                      
                    }
                    
                }

                Util.printMenu();

                opcao = Int32.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Digite um valor para saque:");
                        double valor = Double.Parse(Console.ReadLine());

                        contaAtual.saque(valor);
                        break;

                    case 2:
                        Console.WriteLine("Digite um valor para depositar:");
                        valor = Double.Parse(Console.ReadLine());

                        contaAtual.depositar(valor);
                        break;
                    
                    case 3:
                        Console.WriteLine("Digite o numero da conta: ");
                        idConta = Int32.Parse(Console.ReadLine());
                        Conta destinatario = null;


                        foreach (Conta registro in contas)
                        {
                            if (idConta == registro.getId())
                            {
                                destinatario = registro;
                                break;
                            }

                        }

                        if (destinatario.getId() > 0) {
                            Console.WriteLine("Digite o valor da transferencia: ");
                            valor = Double.Parse(Console.ReadLine());

                            contaAtual.transferir(destinatario, valor);
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada");
                        }
 
                        
                        break;
                
                    case 0:
                        Console.Write("Deslogando");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Console.WriteLine("\n");
                        Thread.Sleep(2000);
                        login = false;
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
             

            }
            while (!fim);
            

            Console.WriteLine("Assistente de inicialização de conta\n");
            Thread.Sleep(1000);
            Console.Write("Iniciando");
            for(int i = 0;i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("\n");
            Thread.Sleep(2000);


            Console.Write("Digite o id do titular: ");
            idTitular = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o nome do titular: ");
            nomeTitular = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite o cpf do titular: ");
            cpfTitular = Console.ReadLine();

            titular = new Titular(idTitular, nomeTitular, cpfTitular);
            Conta conta1 = new Conta(1, 200, 1, titular);


     

        }
    }
}
