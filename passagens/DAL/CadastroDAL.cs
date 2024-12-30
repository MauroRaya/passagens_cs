using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace passagens
{
    public class CadastroDAL
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<Claim> CadastrarUsuarioAPI(Cadastro cadastro)
        {
            Erro.SetErro(false);

            var jsonContent = JsonConvert.SerializeObject(cadastro);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient
                    .PostAsync(@"https://localhost:7217/api/account/login", httpContent);

                Debug.WriteLine("Response LOGIN: " + response);

                if (!response.IsSuccessStatusCode)
                {
                    string mensagemErro = await response.Content.ReadAsStringAsync();
                    Erro.SetErro(mensagemErro);
                    return null;
                }

                var responseJson = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<LoginAndCadastroResponse>(responseJson);

                Token.JwtToken = result.Token;
                var token = result.Token;

                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);

                var userRoleClaim = jwtToken.Claims
                    .FirstOrDefault(c => c.Value.ToLower() == "cliente" || c.Value.ToLower() == "admin");

                if (userRoleClaim is null)
                {
                    Erro.SetErro("Erro ao validar usuario");
                    return null;
                }

                return userRoleClaim;
            }
            catch (Exception ex)
            {
                Erro.SetErro(ex.Message);
                return null;
            }
        }
    }
}
