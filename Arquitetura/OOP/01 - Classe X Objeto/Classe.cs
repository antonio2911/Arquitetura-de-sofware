using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._01___Classe_X_Objeto
{
  public class Classe
  {
    // Propriedades
    public double Tamanho { get; set; }
    public int NumeroDeVagas { get; set; }
    public int Andares { get; set; }
    public double Valor { get; set; }

    //Construtores
    public Classe()
    {

    }

    public Classe(double tamanho,int numeroDeVagas, int andares,double valorDoImovel)
    {
      Tamanho = tamanho;
      NumeroDeVagas= numeroDeVagas;
      Andares = andares;
      Valor = valorDoImovel;

    }
    
    //Metodos

    public double MetrosQuadrados(double tamanho)
    {
      return Math.Pow(tamanho,2);
    }

    public double ValorParcela()
    {
      return Valor / 420;
    }

    }
  }
}
