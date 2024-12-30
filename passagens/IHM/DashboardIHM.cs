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
    public partial class DashboardIHM : Form
    {
        int page = 0;
        int pageSize = 6;
        int count = 0;

        bool aplicarSort = false;

        public DashboardIHM()
        {
            InitializeComponent();
            DisplayPassagens(null, null);
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void ValidarBotoes()
        {
            if (page == 0)
            {
                btnVoltar.Enabled = false;
                btnVoltar.BackColor = Color.Silver;
                lbVoltar.ForeColor = Color.Silver;
            }
            else
            {
                btnVoltar.Enabled = true;
                btnVoltar.BackColor = System.Drawing.ColorTranslator.FromHtml("#5a1ceb");
                lbVoltar.ForeColor = Color.Black;
            }

            if ((page + 1) * pageSize >= count)
            {
                btnAvancar.Enabled = false;
                btnAvancar.BackColor = Color.Silver;
                lbAvancar.ForeColor = Color.Silver;
            }
            else
            {
                btnAvancar.Enabled = true;
                btnAvancar.BackColor = System.Drawing.ColorTranslator.FromHtml("#5a1ceb");
                lbAvancar.ForeColor = Color.Black;
            }
        }
        
        private void DisplayInfoRegistros()
        {
            int comecoRegistro = (page * pageSize) + 1;
            int fimRegistro = (page + 1) * pageSize;

            lbPagina.Text = $"Página {page + 1}";
            lbRegistros.Text = $"{comecoRegistro}-{fimRegistro}/{count}";
        }

        private void IterarPassagens(List<PassagemFORM> passagens)
        {
            foreach (var passagem in passagens)
            {
                var novaPassagem = new PassagemControlADM
                {
                    Id = passagem.Id.ToString(),
                    CompanhiaAerea = passagem.CompanhiaAerea,
                    DataPartida = passagem.DataPartida.ToString(),
                    DataChegada = passagem.DataChegada.ToString(),
                    Origem = passagem.Origem,
                    Destino = passagem.Destino,
                    Preco = $"R${passagem.Preco}",
                    StatusReservada = passagem.StatusReservada
                };

                novaPassagem.UpdateDisplay();

                flowLayoutPanel1.Controls.Add(novaPassagem);
            }
        }

        private async void DisplayPassagens(object sender, EventArgs e)
        {
            string sort = "...";

            if (aplicarSort == true) { page = 0; aplicarSort = false; }

            if (cbOrdenarPreco.Text == "Crescente")   sort = "ASC";
            if (cbOrdenarPreco.Text == "Decrescente") sort = "DESC";

            GetPassagemResponse data;
            List<PassagemFORM> passagens;

            flowLayoutPanel1.Controls.Clear();

            if (!string.IsNullOrWhiteSpace(tbPesquisar.Text))
            {
                page = 0;

                // Count calculado baseado na pesquisa das passagens filtradas
                data = await PassagensDAL.GetPassagens(page, int.MaxValue, sort);

                passagens = data.Passagens;
                var passagensFiltradas = passagens.FindAll(p => p.Destino.ToLower().Contains(tbPesquisar.Text.ToLower()));
                count = passagensFiltradas.Count();

                IterarPassagens(passagensFiltradas.Skip(page * pageSize).Take(pageSize).ToList());
            }
            else
            {
                // Count total de todos os registros, vindo da API
                data = await PassagensDAL.GetPassagens(page, pageSize, sort);
                passagens = data.Passagens;
                int.TryParse(data.Count, out count);

                IterarPassagens(passagens);
            }

            DisplayInfoRegistros();
            ValidarBotoes();
        }

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (page == 0) return;
            page--;
            DisplayPassagens(null, null);
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if ((page + 1) * pageSize >= count) return;
            page++;
            DisplayPassagens(null, null);
        }

        private void MudarSortAPI(object sender, EventArgs e)
        {
            aplicarSort = true;
            DisplayPassagens(null, null);
        }

        private void btnAdicionarPassagem_Click(object sender, EventArgs e)
        {

        }

        private async void btnEditarPassagem_Click(object sender, EventArgs e)
        {
            DashboardIHM dashboardForm = new DashboardIHM();
            dashboardForm.Show();
            await Task.Delay(500);
            this.Hide();
        }

        private void btnRemoverPassagem_Click(object sender, EventArgs e)
        {

        }
    }
}
