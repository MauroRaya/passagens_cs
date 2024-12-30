using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace passagens
{
    public class PassagensDAL
    {
        private static HttpClient client = new HttpClient();

        public static async Task<GetPassagemResponse> GetPassagens(int page, int pageSize, string sort)
        {
            Erro.SetErro(false);

            try
            {
                if (string.IsNullOrEmpty(Token.JwtToken))
                {
                    Erro.SetErro("JWT Token é obrigatório");
                    Debug.WriteLine("JWT Token é obrigatório");
                    return null;
                }
                Debug.WriteLine("Token: " + Token.JwtToken);

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:7217/api/passagens?page={page}&pageSize={pageSize}&sort={sort}");
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token.JwtToken);
                Debug.WriteLine("Request message: " + requestMessage);

                var response = await client.SendAsync(requestMessage);
                Debug.WriteLine("Response API Call: " + response.ToString());

                if (!response.IsSuccessStatusCode)
                {
                    string mensagemErro = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("API Error Message: " + mensagemErro);
                    Erro.SetErro(mensagemErro);
                    return null;
                }

                var responseJson = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("Response JSON: " + responseJson);

                var result = JsonConvert.DeserializeObject<GetPassagemResponse>(responseJson);
                Debug.WriteLine("Resultado: " + result);

                return result;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                Erro.SetErro(ex.Message);
                return null;
            }
        }

        public static async Task PutPassagem(PassagemDB passagem, int id)
        {
            Erro.SetErro(false);

            try
            {
                if (string.IsNullOrEmpty(Token.JwtToken))
                {
                    Erro.SetErro("JWT Token é obrigatório");
                    Debug.WriteLine("JWT Token é obrigatório");
                    return;
                }
                Debug.WriteLine("Token: " + Token.JwtToken);

                var jsonContent = JsonConvert.SerializeObject(passagem);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                Debug.WriteLine("ID: " + id);

                var requestMessage = new HttpRequestMessage(HttpMethod.Put, $"https://localhost:7217/api/passagens/{id}")
                {
                    Content = httpContent
                };
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token.JwtToken);
                Debug.WriteLine("Request message: " + requestMessage);

                var response = await client.SendAsync(requestMessage);
                Debug.WriteLine("Response API Call: " + response);

                if (!response.IsSuccessStatusCode)
                {
                    string mensagemErro = await response.Content.ReadAsStringAsync();
                    Erro.SetErro(mensagemErro);
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                Erro.SetErro(ex.Message);
                return;
            }
        }
    }
}
