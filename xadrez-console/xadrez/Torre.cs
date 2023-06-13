using System;
using tabuleiro;

namespace xadrez
{
	class Torre : Peca
	{
		public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
		{
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

		public override string ToString()
		{
			return "T";
		}
	}
}
