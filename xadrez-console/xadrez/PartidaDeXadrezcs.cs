using System;
using tabuleiro;

namespace xadrez
{
	class PartidaDeXadrez
	{
		public Tabuleiro tab { get; private set; }
		private int turno;
		private Cor jogadorAtual;

		public PartidaDeXadrez()
		{
			tab = new Tabuleiro(8, 8);
			turno = 1;
			jogadorAtual = Cor.Branca;
			colocarPecas();
		}

		public void ExecutaMovimento(Posicao origem, Posicao destino)
		{
			Peca p = tab.RetirarPeca(origem);
			p.incrementarQteMovimentos();
			Peca pecaCapturada = tab.RetirarPeca(destino);
			tab.ColocarPeca(p, destino);
		}

		private void colocarPecas()
		{
			tab.ColocarPeca(new Rei(Cor.Preta, tab), new PosicaoXadrez('c',1).toPosicao());
			tab.ColocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('b', 5).toPosicao());
			tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('h', 3).toPosicao());
			tab.ColocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('a', 7).toPosicao());
			tab.ColocarPeca(new Rei(Cor.Preta, tab), new PosicaoXadrez('d', 6).toPosicao());
			tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaoXadrez('f', 8).toPosicao());

		}


	}
}
