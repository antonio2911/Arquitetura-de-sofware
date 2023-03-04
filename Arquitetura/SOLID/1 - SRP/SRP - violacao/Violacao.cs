using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP___violacao
{
  // Single Responsiblity Principle (Princípio da responsabilidade única)
  public class Cliente
  {
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime DataCadastro { get; set; }

    public string AdicionarCliente()
    {
      if (Email.Contains("@"))
      {
        return "cliente com e-mail invalido";
      }
      
      if(Cpf.Length != 11)
      {
        return "Cliente com cpf invalido";
      }

      using(var cn = new SqlConection())
      {
        var cmd = new SqlCommand();

        cn.connectionString = "Minha Conta";
      }
    }
  }
}
