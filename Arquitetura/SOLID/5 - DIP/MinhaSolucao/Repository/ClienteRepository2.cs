using SOLID._5___DIP.MinhaSolucao.Interfaces;
using SOLID._5___DIP.MinhaSolucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___DIP.MinhaSolucao.Repository
{
  public class ClienteRepository2 : IClienteRepository
  {
    public void AdicionarCliente(Cliente cliente)
    {
      // imagina que insere em outra tabela do banco e muda algumas informações
    }
  }
}
