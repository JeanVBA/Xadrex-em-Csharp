﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get;protected set; }

        public Peca(Posicao pos, Tabuleiro tab, Cor cor)
        {
            this.posicao = pos;
            this.cor = cor;
            this.tabuleiro = tab;
            this.qtdMovimentos = 0;
        }

    }
   
}