
namespace Praticas
{
    partial class Form1
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
            this.lista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hashSet = new System.Windows.Forms.Button();
            this.dicionaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(63, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(159, 251);
            this.lista.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hashSet
            // 
            this.hashSet.Location = new System.Drawing.Point(63, 322);
            this.hashSet.Name = "hashSet";
            this.hashSet.Size = new System.Drawing.Size(159, 47);
            this.hashSet.TabIndex = 2;
            this.hashSet.Text = "button2";
            this.hashSet.UseVisualStyleBackColor = true;
            this.hashSet.Click += new System.EventHandler(this.hashSet_Click);
            // 
            // dicionaro
            // 
            this.dicionaro.Location = new System.Drawing.Point(63, 375);
            this.dicionaro.Name = "dicionaro";
            this.dicionaro.Size = new System.Drawing.Size(159, 47);
            this.dicionaro.TabIndex = 3;
            this.dicionaro.Text = "button2";
            this.dicionaro.UseVisualStyleBackColor = true;
            this.dicionaro.Click += new System.EventHandler(this.dicionaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.dicionaro);
            this.Controls.Add(this.hashSet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hashSet;
        private System.Windows.Forms.Button dicionaro;
    }
}

