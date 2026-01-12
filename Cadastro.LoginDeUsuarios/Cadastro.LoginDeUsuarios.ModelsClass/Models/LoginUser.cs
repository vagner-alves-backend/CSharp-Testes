using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.LoginDeUsuarios.ModelsClass.Models
{
    public class LoginUser
    {
        public string[] UserName = (["Vágner", "Gustavo", "Laura", "Renata"]);
        public string[] UserPassword = (["123", "123", "123", "123"]);

        public void LoginChecked(string? name, string? password)
        {
            for (int index = 0; index < 4; index++)
            {
                if (UserName[index] == name && UserPassword[index] == password)
                {
                    Console.WriteLine($"Olá {name}, seu login foi concluido com sucesso..");
                    break;
                } else if (index == 3)
                {
                    Console.WriteLine($"Olá {name}, seu login não foi encontrado...");
                }
            } 
        }
    }
}

