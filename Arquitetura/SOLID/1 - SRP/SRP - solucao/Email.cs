using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP___solucao
{
 public class Email
  {
    public string TheEmail { get; set; }

    public bool Validar()
    {
      return TheEmail.Contains("@");
    }

  }
}
