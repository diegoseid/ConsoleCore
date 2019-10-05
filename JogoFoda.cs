using GameTop.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(_JogadorA.Corre());
            Console.WriteLine(_JogadorA.Chuta());
            Console.WriteLine(_JogadorA.Passe());

            Console.Write("\n PRÓXIMO JOGADOR \n");

            Console.WriteLine(_JogadorB.Corre());
            Console.WriteLine(_JogadorB.Chuta());
            Console.WriteLine(_JogadorB.Passe());
        }
    }
}
