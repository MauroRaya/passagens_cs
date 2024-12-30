using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passagens
{
    public partial class PassagemControl : UserControl
    {
        public string Id { get; set; }
        public string Origem { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public string DataPartida { get; set; }
        public string DataChegada { get; set; }
        public string Preco { get; set; }
        public string CompanhiaAerea { get; set; } = string.Empty;
        public string StatusReservada { get; set; } = string.Empty;

        public PassagemControl()
        {
            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            lbId.Text = Id;
            lbCompanhiaAerea.Text = CompanhiaAerea;
            lbDataPartida.Text = DataPartida;
            lbDataChegada.Text = DataChegada;
            lbOrigem.Text = Origem;
            lbDestino.Text = Destino;
            lbPreco.Text = Preco;
        }
    }
}
