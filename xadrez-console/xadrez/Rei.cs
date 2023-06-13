using System;
using tabuleiro;
using xadrez;

namespace xadrez
{
	class Rei : Peca
	{
		public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
		{
		}

		public override string ToString()
		{
			return "R";
		}

		private bool podeMover(Posicao pos)
		{
			Peca p = tab.peca(pos);
			return p == null || p.cor != cor;
		}
		public override bool[,] movimentosPossiveis()
		{
			bool[,] mat = new bool[tab.linhas, tab.colunas];

		}
	}
}
}
