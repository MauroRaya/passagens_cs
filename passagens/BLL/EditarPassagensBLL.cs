using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passagens.BLL
{
    public static class EditarPassagensBLL
    {
        public static async Task validarPutPassagens(PassagemFORM passagem, string id)
        {
            PassagemDB passagemDB = new PassagemDB();

            if (!int.TryParse(id, out int _id))
            {
                Erro.SetErro("ID inválido. Insira um número inteiro.");
                return;
            }
            passagemDB.Id = _id;

            if (string.IsNullOrWhiteSpace(passagem.Origem))
            {
                Erro.SetErro("Origem é de preenchimento obrigatório");
                return;
            }
            passagemDB.Origem = passagem.Origem;

            if (string.IsNullOrWhiteSpace(passagem.Destino))
            {
                Erro.SetErro("Destino é de preenchimento obrigatório");
                return;
            }
            passagemDB.Destino = passagem.Destino;

            if (!DateTime.TryParseExact(passagem.DataPartida, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataPartida))
            {
                Erro.SetErro("Data de partida inválida. Use o formato: yyyy-MM-ddTHH:mm:ss");
                return;
            }
            passagemDB.DataPartida = dataPartida;

            if (!DateTime.TryParseExact(passagem.DataChegada, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataChegada))
            {
                Erro.SetErro("Data de chegada inválida. Use o formato: yyyy-MM-ddTHH:mm:ss");
                return;
            }
            passagemDB.DataChegada = dataChegada;

            if (!float.TryParse(passagem.Preco.Replace("R$", ""), out float preco))
            {
                Erro.SetErro("Preço inválido. Insira um valor numérico.");
                return;
            }
            passagemDB.Preco = preco;

            if (string.IsNullOrWhiteSpace(passagem.CompanhiaAerea))
            {
                Erro.SetErro("Companhia Area é de preenchimento obrigatório");
                return;
            }
            passagemDB.CompanhiaAerea = passagem.CompanhiaAerea;

            await PassagensDAL.PutPassagem(passagemDB, _id);
        }
    }
}
