using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP___solucao
{
 public class Cliente
  {
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public Email Email { get; set; }
    public Cpf Cpf { get; set; }
    public DateTime DataCadastro { get; set; }

    //se a classe ela mesma se define ela mesmo se valida
    public bool Validar()
    {
      return Email.Validar() && Cpf.Validar();
    }
  }
}
