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

		public const string formatError = @"
Entrada invalida, tente novamente";

		public const string inputName = "Qual o nome do produto?";

		public const string inputBrand = "Qual a marca do produto?";

		public const string inputPrice = "Qual o preço do produto?";

		public const string inputTotalVolume = "Qual o tamanho do produto em ml?";

		public const string inputExpirationDate = "Qual a data de validade do produto?";

		public const string SpecieSelectionMenu = @"Para qual tipo de espécie o produto é indicado:
1 - Cachorro
2 - Gato";

		public const string invalidNullInput = @"
Não é possível inserir um valor em branco. Tente Novamente.";
		
		public const string ReportSelectionMenu = @"Selecione sua alternativa:
1 - Relatório por nome de produto
2 - Relatório por tipo de produto
3 - Relatório por marca

Ou pressione ENTER para o relatório com todos os produtos.";

		public const string ReportTypeMenu = @"Selecione sua alternativa:
1 - Shampoo
2 - Condicionador
3 - Perfume
4 - Todas as categorias";

		public const string NoResults = "Sua busca não retornou resultados.";
		
		public const string ReportNameMenu = "Digite o nome do produto desejado:";

		public const string ReportBrandMenu = "Digite a marca dos produtos desejados:";

		public const string NullInput = "Input não pode ser vazio.";

		public const string InvalidOption = "Opção inválida.";
		public const string MenuProductTest = @"
1 - Novo Produto
2 - Ver estoque 
3 - Retirar Produto ";

		public const string returnEntryKey = "Digite qualquer tecla para retornar ao menu inicial ";
	}
}
