namespace passagens
{
    partial class PassagemControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbDataPartida = new System.Windows.Forms.Label();
            this.lbDataChegada = new System.Windows.Forms.Label();
            this.lbCompanhiaAerea = new System.Windows.Forms.Label();
            this.lbOrigem = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbPreco.Location = new System.Drawing.Point(1136, 15);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(111, 30);
            this.lbPreco.TabIndex = 0;
            this.lbPreco.Text = "R$ 100,00";
            // 
            // lbDataPartida
            // 
            this.lbDataPartida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPartida.ForeColor = System.Drawing.Color.Black;
            this.lbDataPartida.Location = new System.Drawing.Point(296, 15);
            this.lbDataPartida.Name = "lbDataPartida";
            this.lbDataPartida.Size = new System.Drawing.Size(221, 30);
            this.lbDataPartida.TabIndex = 1;
            this.lbDataPartida.Text = "2024-11-01T08:30:00";
            // 
            // lbDataChegada
            // 
            this.lbDataChegada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataChegada.ForeColor = System.Drawing.Color.Black;
            this.lbDataChegada.Location = new System.Drawing.Point(729, 15);
            this.lbDataChegada.Name = "lbDataChegada";
            this.lbDataChegada.Size = new System.Drawing.Size(221, 30);
            this.lbDataChegada.TabIndex = 3;
            this.lbDataChegada.Text = "2024-11-01T09:30:00";
            // 
            // lbCompanhiaAerea
            // 
            this.lbCompanhiaAerea.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanhiaAerea.ForeColor = System.Drawing.Color.Black;
            this.lbCompanhiaAerea.Location = new System.Drawing.Point(80, 15);
            this.lbCompanhiaAerea.Name = "lbCompanhiaAerea";
            this.lbCompanhiaAerea.Size = new System.Drawing.Size(87, 30);
            this.lbCompanhiaAerea.TabIndex = 4;
            this.lbCompanhiaAerea.Text = "GOL";
            // 
            // lbOrigem
            // 
            this.lbOrigem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigem.ForeColor = System.Drawing.Color.Black;
            this.lbOrigem.Location = new System.Drawing.Point(521, 15);
            this.lbOrigem.Name = "lbOrigem";
            this.lbOrigem.Size = new System.Drawing.Size(181, 30);
            this.lbOrigem.TabIndex = 5;
            this.lbOrigem.Text = "Recife";
            // 
            // lbDestino
            // 
            this.lbDestino.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.ForeColor = System.Drawing.Color.Black;
            this.lbDestino.Location = new System.Drawing.Point(954, 15);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(157, 30);
            this.lbDestino.TabIndex = 6;
            this.lbDestino.Text = "Fortaleza";
            // 
            // lbId
            // 
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbId.Location = new System.Drawing.Point(2, 3);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(49, 55);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "1";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 66);
            this.panel1.TabIndex = 8;
            // 
            // PassagemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.lbOrigem);
            this.Controls.Add(this.lbCompanhiaAerea);
            this.Controls.Add(this.lbDataChegada);
            this.Controls.Add(this.lbDataPartida);
            this.Controls.Add(this.lbPreco);
            this.Name = "PassagemControl";
            this.Size = new System.Drawing.Size(1264, 66);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDataPartida;
        private System.Windows.Forms.Label lbDataChegada;
        private System.Windows.Forms.Label lbCompanhiaAerea;
        private System.Windows.Forms.Label lbOrigem;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel1;
    }
}
