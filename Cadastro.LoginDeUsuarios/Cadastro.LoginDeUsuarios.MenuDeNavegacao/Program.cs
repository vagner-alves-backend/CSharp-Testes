string? nome = "Null";
string? senha = "Null";
string? checkedUser = "Sim";

string[] nomes = (["Vágner", "Lucas", "Fernanda", "Laura"]);
string[] senhas = (["123", "123", "123", "123"]);

do
{
    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    Console.WriteLine($"Olá {nome}, qual é sua senha: ");
    senha = Console.ReadLine();

    for (int index = 0; index < 4; index++)
    {
        if (nomes[index] == nome && senhas[index] == senha)
        {
            Console.WriteLine($"Olá {nome}, seu login foi liberado.");
            break;
        } else if (index == 3)
        {
            Console.WriteLine("Acesso negado.");
        }
    }

    Console.WriteLine("Deseja checar mais algum usuario? [Sim/Não]");
    checkedUser = Console.ReadLine();
} while (checkedUser != "Não");

