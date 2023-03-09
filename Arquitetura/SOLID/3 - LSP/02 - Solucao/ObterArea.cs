using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP._02___Solucao
{
  public class ObterArea
  {
    private static void ObterAreaParalelogramo(Paralelogramo ret)
    {
      Console.Clear();
      Console.WriteLine("Calculo da area do retangulo");
      Console.WriteLine();
      Console.WriteLine(ret.Altura + " * " + ret.Largura);
      Console.WriteLine();
      Console.WriteLine(ret.Area);
      Console.ReadKey();
    }

    public static void Calcular()
    {
      var quadrado = new Quadrado(10,5);
      var retangulo = new Retangulo(10, 5);

      ObterAreaParalelogramo(quadrado);
      ObterAreaParalelogramo(retangulo);
    }
  }
}
