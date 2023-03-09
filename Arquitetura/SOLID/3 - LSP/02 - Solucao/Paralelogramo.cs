using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP._02___Solucao
{
  public abstract class Paralelogramo
  {
    public double Altura { get;  private set; }
    public double Largura { get; private set; }
    public double Area { get { return Altura * Largura; } }
    protected Paralelogramo(int altura,int largura)
    {
      Altura= altura;
      Largura= largura;

    }
  }
}
