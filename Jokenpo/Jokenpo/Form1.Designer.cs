
namespace Jokenpo
{
    partial class JokenPo
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
            this.escolha = new System.Windows.Forms.Label();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PCeSC = new System.Windows.Forms.Label();
            this.resultlab = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // escolha
            // 
            this.escolha.BackColor = System.Drawing.Color.Transparent;
            this.escolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escolha.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolha.ForeColor = System.Drawing.Color.Red;
            this.escolha.Location = new System.Drawing.Point(181, 9);
            this.escolha.Name = "escolha";
            this.escolha.Size = new System.Drawing.Size(196, 75);
            this.escolha.TabIndex = 0;
            this.escolha.Text = "ESCOLHA:";
            this.escolha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackColor = System.Drawing.Color.Transparent;
            this.btnTesoura.FlatAppearance.BorderSize = 0;
            this.btnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesoura.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesoura.ForeColor = System.Drawing.Color.Orange;
            this.btnTesoura.Location = new System.Drawing.Point(362, 107);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(163, 59);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.Text = "TESOURA";
            this.btnTesoura.UseVisualStyleBackColor = false;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Transparent;
            this.btnPapel.FlatAppearance.BorderSize = 0;
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPapel.Location = new System.Drawing.Point(198, 107);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(144, 59);
            this.btnPapel.TabIndex = 3;
            this.btnPapel.Text = "PAPEL";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // PCeSC
            // 
            this.PCeSC.BackColor = System.Drawing.Color.Transparent;
            this.PCeSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCeSC.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCeSC.ForeColor = System.Drawing.Color.LimeGreen;
            this.PCeSC.Location = new System.Drawing.Point(28, 169);
            this.PCeSC.Name = "PCeSC";
            this.PCeSC.Size = new System.Drawing.Size(196, 75);
            this.PCeSC.TabIndex = 5;
            this.PCeSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultlab
            // 
            this.resultlab.BackColor = System.Drawing.Color.Transparent;
            this.resultlab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultlab.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlab.ForeColor = System.Drawing.Color.Gold;
            this.resultlab.Location = new System.Drawing.Point(329, 169);
            this.resultlab.Name = "resultlab";
            this.resultlab.Size = new System.Drawing.Size(196, 75);
            this.resultlab.TabIndex = 6;
            this.resultlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPedra
            // 
            this.btnPedra.BackColor = System.Drawing.Color.Transparent;
            this.btnPedra.FlatAppearance.BorderSize = 0;
            this.btnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedra.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedra.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPedra.Location = new System.Drawing.Point(35, 107);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(144, 59);
            this.btnPedra.TabIndex = 1;
            this.btnPedra.Text = "PEDRA";
            this.btnPedra.UseVisualStyleBackColor = false;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Maroon;
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.Color.Red;
            this.restart.Location = new System.Drawing.Point(12, 9);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(76, 28);
            this.restart.TabIndex = 7;
            this.restart.Text = "RESTART";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // JokenPo
            // 
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(553, 270);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.resultlab);
            this.Controls.Add(this.PCeSC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.escolha);
            this.Name = "JokenPo";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label PcChoice;
        private System.Windows.Forms.Button Pedra;
        private System.Windows.Forms.Button Papel;
        private System.Windows.Forms.Button Tesoura;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label escolha;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PCeSC;
        private System.Windows.Forms.Label resultlab;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button restart;
    }
}

