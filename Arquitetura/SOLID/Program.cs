using SOLID._2___OCP.OCP___Solucao_extension_Method;
using SOLID._3___LSP._02___Solucao;
using System;

namespace SOLID
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Escolha uma opção");
      Console.WriteLine("1 - OCP");
      Console.WriteLine("2 - LSP");

      var opcao = Console.ReadKey();

      switch(opcao.KeyChar)
      {
        case '1':
          CaixaEletronico.Operacoes();
          break;
        case '2':
          ObterArea.Calcular();
          break;

      }
    }
  }
}
