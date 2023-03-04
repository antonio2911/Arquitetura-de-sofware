using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP._01___Violacao
{
  public class DebitoConta
  {
    // nesse exemplo para cada conta vamos criar um if

    public void Debitar(decimal valor, string conta, TipoConta tipoConta)
    {
      if(tipoConta == TipoConta.Poupanca)
      {
        // implementação conta poupança
      }

      if(tipoConta == TipoConta.Corrente)
      {
        // implementação conta corrente
      }

      // dessa forma fere o principio do aberto fechado aberto para extensão
      // fechado para modificação

    }
  }
}
