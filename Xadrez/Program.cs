using xadrez;
using Xadrez.tabuleiro;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Rei(tab, Cor.Amarela), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Amarela), new Posicao(1, 3));
            tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(2, 1));
            tab.colocarPeca(new Rei(tab, Cor.Azul), new Posicao(3, 2));
            Tela.imprimirTabuleiro(tab);
        }
    }
}