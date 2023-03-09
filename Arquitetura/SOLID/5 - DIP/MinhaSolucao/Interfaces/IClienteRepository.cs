using SOLID._5___DIP.MinhaSolucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___DIP.MinhaSolucao.Interfaces
{
 public interface IClienteRepository
  {
    void AdicionarCliente(Cliente cliente);
  }
}
