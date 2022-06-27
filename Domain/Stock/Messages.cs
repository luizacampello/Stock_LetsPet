using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
	public static class Messages
	{
		public const string CategorySelectionMenu = @"Selecione a categoria de produto 
1 - Shampoo
2 - Condicionador
3 - Perfume";

		public const string UsageSelectionMenu = @"Qual o tipo de uso do produto: 
1 - Comum
2 - Especial";

		public const string formatError = "Entrada invalida, tente novamente";

		public const string inputName = "Qual o nome do produto?";

		public const string inputBrand = "Qual a marca do produto?";

		public const string inputPrice = "Qual o preço do produto?";

		public const string inputTotalVolume = "Quantos ml o produto possúi?";

		public const string inputExpirationDate = "Qual a data de validade do produto?";

		public const string SpecieSelectionMenu = @"Para qual tipo de espécie o produto é indicado:
1 - Cachorro
2 - Gato";
	}
}
