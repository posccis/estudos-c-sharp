using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class JokenPo : Form
    {
        public JokenPo()
        {
            InitializeComponent();
        }

        public void StartGame(int opt)
        {


            jogo Jogo = new jogo();

            if (Jogo.PcChoice() == 0)
            {
                PCeSC.Text = "PEDRA";
            }
            else if(Jogo.PcChoice() == 1)
            {
                PCeSC.Text = "PAPEL";
            }
            else
            {
                PCeSC.Text = "TESOURA";
            }
            switch (Jogo.Jogada(opt))
            {
                case jogo.Resultado.Ganhou:
                    
                    resultlab.Text = "VOCÊ GANHOU!";
                    break;
                case jogo.Resultado.Perdeu:
                    resultlab.Text = "VOCÊ PERDEU!";
                    break;
                case jogo.Resultado.Empatou:
                    resultlab.Text = "EMPATE!";
                    break;
                default:
                    break;
            }

        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void restart_Click(object sender, EventArgs e)
        {
            resultlab.Text = "";
            PCeSC.Text = "";
        }
    }
}
