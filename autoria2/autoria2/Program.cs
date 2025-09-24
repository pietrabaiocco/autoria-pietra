// See https://aka.ms/new-console-template for more information

double saldo = 1000.00;
int opcao;
while (true)
{
    Console.WriteLine("\n=== MENU DO CAIXA ELETRÔNICO ===");
    Console.WriteLine("1 - Ver saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    if (int.TryParse(Console.ReadLine(), out opcao))
    {
        if (opcao == 1)
        {
            Console.WriteLine($"Seu saldo atual é R$ {saldo:F2}");
        }
        else if (opcao == 2)
        {
            Console.Write("Digite o valor para depositar: ");
            if (double.TryParse(Console.ReadLine(), out double deposito) && deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine("Depósito realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
        else if (opcao == 3)
        {
            Console.Write("Digite o valor para sacar: ");
            if (double.TryParse(Console.ReadLine(), out double saque) && saque > 0)
            {
                if (saque <= saldo)
                {
                    saldo -= saque;
                    Console.WriteLine("Saque realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
        else if (opcao == 4)
        {
            Console.WriteLine("Obrigado por usar o caixa eletrônico. Até mais!");
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite um número.");
    }
}

