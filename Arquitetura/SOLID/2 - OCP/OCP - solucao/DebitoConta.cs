using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP___solucao
{
  // abstract = so pode ser herdada nunca instanciada com new DebitoConta()
  public abstract class DebitoConta
  {
    public string NumeroTransacao { get; set; }
    public abstract string Debitar(decimal valor, string conta);

    public string FormatarTransacao()
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      var random = new Random();
      NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
        .Select(s => s[random.Next(s.Length)]).ToArray());

      // Numero de transacao formatado
      return NumeroTransacao;
    }
  }
}
