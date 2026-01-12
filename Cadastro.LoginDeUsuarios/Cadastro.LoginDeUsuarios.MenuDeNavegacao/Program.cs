using Cadastro.LoginDeUsuarios.ModelsClass.Models;

LoginUser login = new();

string? nome = "Null";
string? senha = "Null";
string? checkedUser = "Sim";

login.UserName[0] = "Pedro";

do
{
    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    Console.WriteLine($"Olá {nome}, qual é sua senha: ");
    senha = Console.ReadLine();

    login.LoginChecked(nome, senha);

    Console.WriteLine("Deseja checar mais algum usuario? [Sim/Não]");
    checkedUser = Console.ReadLine();
} while (checkedUser != "Não");
