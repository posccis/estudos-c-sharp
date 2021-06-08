using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    class jogo
    {
        public enum Resultado
        {
            Ganhou, Perdeu, Empatou
        }

        public Resultado Jogada(int jogador)
        {
            

            if (PcChoice() == 0 && jogador == 1 || PcChoice() == 1 && jogador == 2 || PcChoice() == 2 && jogador == 0)
            {
                return Resultado.Ganhou;

            }
            else if(PcChoice() == jogador)
            {
                return Resultado.Empatou;
            }
            else
            {
                return Resultado.Perdeu;
            }

        }
        public int PcChoice()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
