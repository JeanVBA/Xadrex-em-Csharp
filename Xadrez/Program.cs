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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Posicao de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Posicao de destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.executarMovimento(origem, destino);

                }


            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}