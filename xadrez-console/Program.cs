using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Tabuleiro tab = new Tabuleiro(8, 8);

				tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(5, 6));
				tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(2, 1));
				tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 3));

				Tela.imprimirTabuleiro(tab);
			}
			catch(TabuleiroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
