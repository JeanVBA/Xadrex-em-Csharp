using tabuleiro;
using xadrez;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada) {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        Console.WriteLine();
                        Console.Write("Posicao de origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Posicao de destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                        partida.realizaJogada(origem, destino);
                    }catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }


            }
            catch (TabuleiroException e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}