namespace passagens
{
    partial class EditarPassagemIHM
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPassagens = new System.Windows.Forms.Button();
            this.btnAdicionarPassagem = new System.Windows.Forms.Button();
            this.btnNada = new System.Windows.Forms.Button();
            this.btnRemoverPassagem = new System.Windows.Forms.Button();
            this.btnPutPassagem = new System.Windows.Forms.Button();
            this.tbOrigem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCompanhiaAerea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.mtbDataPartida = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(962, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flightly";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.btnPassagens);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAdicionarPassagem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNada);
            this.panel1.Controls.Add(this.btnRemoverPassagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btnPassagens
            // 
            this.btnPassagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.btnPassagens.FlatAppearance.BorderSize = 0;
            this.btnPassagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassagens.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassagens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPassagens.Location = new System.Drawing.Point(167, 0);
            this.btnPassagens.Name = "btnPassagens";
            this.btnPassagens.Size = new System.Drawing.Size(147, 41);
            this.btnPassagens.TabIndex = 21;
            this.btnPassagens.Text = "Ver passagens";
            this.btnPassagens.UseVisualStyleBackColor = false;
            this.btnPassagens.Click += new System.EventHandler(this.btnPassagens_Click);
            // 
            // btnAdicionarPassagem
            // 
            this.btnAdicionarPassagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.btnAdicionarPassagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarPassagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPassagem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPassagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarPassagem.Location = new System.Drawing.Point(320, 0);
            this.btnAdicionarPassagem.Name = "btnAdicionarPassagem";
            this.btnAdicionarPassagem.Size = new System.Drawing.Size(195, 41);
            this.btnAdicionarPassagem.TabIndex = 20;
            this.btnAdicionarPassagem.Text = "Adicionar passagem";
            this.btnAdicionarPassagem.UseVisualStyleBackColor = false;
            this.btnAdicionarPassagem.Click += new System.EventHandler(this.btnAdicionarPassagem_Click);
            // 
            // btnNada
            // 
            this.btnNada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(255)))));
            this.btnNada.FlatAppearance.BorderSize = 0;
            this.btnNada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNada.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNada.Location = new System.Drawing.Point(521, 0);
            this.btnNada.Name = "btnNada";
            this.btnNada.Size = new System.Drawing.Size(187, 41);
            this.btnNada.TabIndex = 22;
            this.btnNada.Text = "Editar passagem";
            this.btnNada.UseVisualStyleBackColor = false;
            // 
            // btnRemoverPassagem
            // 
            this.btnRemoverPassagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.btnRemoverPassagem.FlatAppearance.BorderSize = 0;
            this.btnRemoverPassagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPassagem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverPassagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoverPassagem.Location = new System.Drawing.Point(714, 0);
            this.btnRemoverPassagem.Name = "btnRemoverPassagem";
            this.btnRemoverPassagem.Size = new System.Drawing.Size(195, 41);
            this.btnRemoverPassagem.TabIndex = 23;
            this.btnRemoverPassagem.Text = "Remover passagens";
            this.btnRemoverPassagem.UseVisualStyleBackColor = false;
            this.btnRemoverPassagem.Click += new System.EventHandler(this.btnRemoverPassagem_Click);
            // 
            // btnPutPassagem
            // 
            this.btnPutPassagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.btnPutPassagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPutPassagem.FlatAppearance.BorderSize = 0;
            this.btnPutPassagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPutPassagem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPutPassagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPutPassagem.Location = new System.Drawing.Point(369, 309);
            this.btnPutPassagem.Name = "btnPutPassagem";
            this.btnPutPassagem.Size = new System.Drawing.Size(548, 35);
            this.btnPutPassagem.TabIndex = 2;
            this.btnPutPassagem.Text = "Editar passagem";
            this.btnPutPassagem.UseVisualStyleBackColor = false;
            this.btnPutPassagem.Click += new System.EventHandler(this.btnPutPassagem_Click);
            // 
            // tbOrigem
            // 
            this.tbOrigem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigem.Location = new System.Drawing.Point(67, 204);
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.Size = new System.Drawing.Size(246, 35);
            this.tbOrigem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(62, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(62, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Destino";
            // 
            // tbDestino
            // 
            this.tbDestino.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestino.Location = new System.Drawing.Point(67, 309);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(246, 35);
            this.tbDestino.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(681, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Companhia Aérea";
            // 
            // tbCompanhiaAerea
            // 
            this.tbCompanhiaAerea.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompanhiaAerea.Location = new System.Drawing.Point(686, 203);
            this.tbCompanhiaAerea.Name = "tbCompanhiaAerea";
            this.tbCompanhiaAerea.Size = new System.Drawing.Size(231, 35);
            this.tbCompanhiaAerea.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(364, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data de partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(364, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data de chegada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(681, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Preco";
            // 
            // tbPreco
            // 
            this.tbPreco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreco.Location = new System.Drawing.Point(686, 103);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(231, 35);
            this.tbPreco.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(28)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(62, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(67, 103);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(127, 35);
            this.tbId.TabIndex = 20;
            // 
            // mtbDataPartida
            // 
            this.mtbDataPartida.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.mtbDataPartida.Location = new System.Drawing.Point(369, 103);
            this.mtbDataPartida.Mask = "0000-00-00T00:00:00";
            this.mtbDataPartida.Name = "mtbDataPartida";
            this.mtbDataPartida.Size = new System.Drawing.Size(210, 35);
            this.mtbDataPartida.TabIndex = 22;
            // 
            // mtbDataChegada
            // 
            this.mtbDataChegada.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.mtbDataChegada.Location = new System.Drawing.Point(369, 208);
            this.mtbDataChegada.Mask = "0000-00-00T00:00:00";
            this.mtbDataChegada.Name = "mtbDataChegada";
            this.mtbDataChegada.Size = new System.Drawing.Size(210, 35);
            this.mtbDataChegada.TabIndex = 23;
            // 
            // EditarPassagemIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(996, 404);
            this.Controls.Add(this.mtbDataChegada);
            this.Controls.Add(this.mtbDataPartida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCompanhiaAerea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrigem);
            this.Controls.Add(this.btnPutPassagem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPassagemIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionarPassagem;
        private System.Windows.Forms.Button btnPassagens;
        private System.Windows.Forms.Button btnNada;
        private System.Windows.Forms.Button btnRemoverPassagem;
        private System.Windows.Forms.Button btnPutPassagem;
        private System.Windows.Forms.TextBox tbOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCompanhiaAerea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.MaskedTextBox mtbDataPartida;
        private System.Windows.Forms.MaskedTextBox mtbDataChegada;
    }
}

