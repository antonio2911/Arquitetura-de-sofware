using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP___solucao
{
 public class Cpf
  {
    public string Numero { get; set; }

    public bool Validar()
    {
      return Numero.Length == 11;
    }
  }
}
