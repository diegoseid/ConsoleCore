﻿using GameTOP.Lib;
using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1("Ronaldo"),
                new Jogador3()
                );
            jogo.IniciarJogo();
        }
    }
    
}
