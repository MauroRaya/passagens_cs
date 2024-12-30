using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passagens
{
    public class PassagemDB
    {
        public int Id { get; set; }
        public string Origem { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public float Preco { get; set; }
        public string CompanhiaAerea { get; set; } = string.Empty;
        public string StatusReservada { get; set; } = string.Empty;
    }

    public class PassagemFORM
    {
        public string Id { get; set; }
        public string Origem { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public string DataPartida { get; set; }
        public string DataChegada { get; set; }
        public string Preco { get; set; }
        public string CompanhiaAerea { get; set; } = string.Empty;
        public string StatusReservada { get; set; } = string.Empty;
    }

    public class GetPassagemResponse
    {
        public string Count { get; set; }
        public string Page { get; set; }
        public string PageSize { get; set; }
        public List<PassagemFORM> Passagens { get; set; }
    }
}
