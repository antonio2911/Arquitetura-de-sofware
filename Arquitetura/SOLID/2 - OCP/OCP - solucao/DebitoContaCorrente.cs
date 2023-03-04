using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP___solucao
{
  public class DebitoContaCorrente : DebitoConta
  {
    // metodos Abstratos passa pelo polimofismo 
    public override string Debitar(decimal valor, string conta)
    {
      return FormatarTransacao();
    }
  }
}
