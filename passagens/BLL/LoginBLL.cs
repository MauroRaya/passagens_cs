using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace passagens
{
    public class LoginBLL
    {
        public static async Task<Claim> validarLogin(Login login)
        {
            Erro.SetErro(false);

            if (string.IsNullOrWhiteSpace(login.Email))
            {
                Erro.SetErro("Email é de preenchimento obrigatório");
                return null;
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(login.Email);

                if (!match.Success)
                {
                    Erro.SetErro("Email precisa ter formatação válida");
                    return null;
                }
            }

            if (string.IsNullOrWhiteSpace(login.Senha))
            {
                Erro.SetErro("Senha é de preenchimento obrigatório");
                return null;
            }
            if (login.Senha.Trim().Length < 6)
            {
                Erro.SetErro("Senha deve ter no mínimo 6 caracteres");
                return null;
            }

            return await LoginDAL.LogarUsuarioAPI(login);
        }
    }
}
