using passagens.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passagens
{
    public partial class EditarPassagemIHM : Form
    {
        PassagemFORM passagem = new PassagemFORM();

        public EditarPassagemIHM(PassagemControlADM novaPassagem)
        {
            InitializeComponent();

            tbId.Text = novaPassagem.Id;
            tbOrigem.Text = novaPassagem.Origem;
            tbDestino.Text = novaPassagem.Destino;
            mtbDataPartida.Text = Convert.ToDateTime(novaPassagem.DataPartida).ToString("yyyy-MM-ddTHH:mm:ss");
            mtbDataChegada.Text = Convert.ToDateTime(novaPassagem.DataChegada).ToString("yyyy-MM-ddTHH:mm:ss");
            tbPreco.Text = novaPassagem.Preco;
            tbCompanhiaAerea.Text = novaPassagem.CompanhiaAerea;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdicionarPassagem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemoverPassagem_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnPassagens_Click(object sender, EventArgs e)
        {
            DashboardIHM dashboardForm = new DashboardIHM();
            dashboardForm.Show();
            await Task.Delay(500);
            this.Hide();
        }

        private async void btnPutPassagem_Click(object sender, EventArgs e)
        {
            passagem.Id = tbId.Text;
            passagem.Origem = tbOrigem.Text;
            passagem.Destino = tbDestino.Text;
            passagem.DataPartida = Convert.ToDateTime(mtbDataPartida.Text).ToString("yyyy-MM-ddTHH:mm:ss");
            passagem.DataChegada = Convert.ToDateTime(mtbDataChegada.Text).ToString("yyyy-MM-ddTHH:mm:ss");
            passagem.Preco = tbPreco.Text;
            passagem.CompanhiaAerea = tbCompanhiaAerea.Text;

            await EditarPassagensBLL.validarPutPassagens(passagem, passagem.Id);
            if (Erro.GetErro())
            {
                MessageBox.Show(Erro.GetMensagemErro());
                return;
            }

            DashboardIHM dashboardForm = new DashboardIHM();
            dashboardForm.Show();
            await Task.Delay(500);
            this.Hide();
        }
    }
}
