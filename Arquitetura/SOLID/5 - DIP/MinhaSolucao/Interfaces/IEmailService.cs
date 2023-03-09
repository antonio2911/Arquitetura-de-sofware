using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___DIP.MinhaSolucao.Interfaces
{
 public interface IEmailService
  {
    void Enviar(string de, string para, string assunto, string mensagem);
  }
}
