using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP.Violacao
{
  public class ObterArea
  {
    private static void ObterAreaRetangulo(Retangulo ret)
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
      var quadrado = new Quadrado() 
      { Altura = 15, Largura = 5 };

      ObterAreaRetangulo(quadrado);
    }
  }
}
