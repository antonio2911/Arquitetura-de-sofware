using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP___Solucao_extension_Method
{
  public static class DebitoContaInvestimento
  {
    public static string DebitarContaInvestimento(this DebitoConta debitoConta)
    {
      // Logica de negócio para debito em conta corrente.
      return debitoConta.FormatarTransacao();
    }
  }
}
