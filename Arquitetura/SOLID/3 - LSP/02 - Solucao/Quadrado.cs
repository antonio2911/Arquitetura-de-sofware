using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP._02___Solucao
{
  public class Quadrado : Paralelogramo
  {
    public Quadrado(int altura, int largura) : base(altura, largura)
    {
      if(altura != largura)
      {
        throw new ArgumentException("Os dois lados tem que ser iguais");
      }
    }
  }
}
