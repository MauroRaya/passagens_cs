using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passagens
{
    public class Erro
    {
        public static bool ExisteErro;
        public static string MensagemErro;

        public static bool GetErro() { return ExisteErro; }
        public static string GetMensagemErro() { return MensagemErro; }

        public static void SetErro(bool _erro) { ExisteErro = _erro; }
        public static void SetErro(string _mensagemErro) { ExisteErro = true; MensagemErro = _mensagemErro; }
    }
}
