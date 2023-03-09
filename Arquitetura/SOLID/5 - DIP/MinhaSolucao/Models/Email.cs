using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___DIP.MinhaSolucao.Models
{
 public class Email
  {
    public string Endereco { get; set; }

    public bool Validar()
    {
      return Endereco.Contains("@");
    }
  }
}
