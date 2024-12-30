using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace passagens
{
    public partial class LoginIHM : Form
    {
        Login login = new Login();

        public LoginIHM()
        {
            InitializeComponent();
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            login.Email = tbEmail.Text;
            login.Senha = tbSenha.Text;

            Claim userRole = await LoginBLL.validarLogin(login);
            if (Erro.GetErro())
            {
                MessageBox.Show(Erro.GetMensagemErro());
                return;
            }

            if (userRole.ToString().ToLower() == "role: admin")
            {
                DashboardIHM dashboardForm = new DashboardIHM();
                dashboardForm.Show();
                await Task.Delay(500);
                this.Hide();
            }
            else if (userRole.ToString().ToLower() == "role: cliente")
            {
                HomeIHM homeForm = new HomeIHM();
                homeForm.Show();
                await Task.Delay(500);
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
        }

        private async void btnIrCadastro_Click(object sender, EventArgs e)
        {
            CadastroIHM cadastroForm = new CadastroIHM();
            cadastroForm.Show();
            await Task.Delay(500);
            this.Hide();
        }
    }
}
