using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.LoginDeUsuarios.ModelsClass.Models
{
    public class LoginUser
    {
        public string? UserNameAtivos {get; set;}
        public string? UserSenhasAtivas {get; set;}
        public string[]? Name {get; set;}
        public int Admin {get; set;}
        public void UserExiste(string? name, string? senha)
        {
            for (int index = 0; index < 4; index++)
            {
                Console.WriteLine($"{Name?[index]}");
            }
        }
    }
}
