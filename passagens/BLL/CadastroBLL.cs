using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace passagens
{
    public class CadastroBLL
    {
        public static async Task<Claim> validarCadastro(Cadastro cadastro)
        {
            Erro.SetErro(false);

            if (string.IsNullOrWhiteSpace(cadastro.Nome))
            {
                Erro.SetErro("Nome é de preenchimento obrigatório");
                return null;
            }

            if (string.IsNullOrWhiteSpace(cadastro.Email))
            {
                Erro.SetErro("Email é de preenchimento obrigatório");
                return null;
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(cadastro.Email);

                if (!match.Success)
                {
                    Erro.SetErro("Email precisa ter formatação válida");
                    return null;
                }
            }

            if (string.IsNullOrWhiteSpace(cadastro.Senha))
            {
                Erro.SetErro("Senha é de preenchimento obrigatório");
                return null;
            }
            if (cadastro.Senha.Trim().Length < 6)
            {
                Erro.SetErro("Senha deve ter no mínimo 6 caracteres");
                return null;
            }

            return await CadastroDAL.CadastrarUsuarioAPI(cadastro);
        }
    }
}
