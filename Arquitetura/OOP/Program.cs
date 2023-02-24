using OOP._01___Classe_X_Objeto;
using System;

namespace OOP
{
  internal class Program
  {
  public  static void Main(string[] args)
    {

      //formas de preencher um objeto

      //contrutor
      Classe casaDois = new Classe(32, 3, 2, 360000);

      // pelo corpo
      Classe casa = new Classe()
      {
        Andares = 2,
        Valor = 260000,
        NumeroDeVagas = 1,
        Tamanho = 52
      };
      casa.MetrosQuadrados(10);
    }
  }
}
