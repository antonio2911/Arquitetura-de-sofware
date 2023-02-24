using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._03___Interfaces_vs_implementacao
{
  //sempre utilizar interface no lugar de uma implementação pura
public interface IRepositorio
  {
    void Adicionar();
  }

  public class Repositorio : IRepositorio
  {
    public void Adicionar()
    {
      // add item
    }
  }

  public class UsoImplementacao
  {
    public void Processo()
    {
      // principio do acoplamento
      // se na classe principal recebe um construtor ou sobre alguma modificação implica em todos os objetos utilizados.
      var repositorio = new Repositorio();
      repositorio.Adicionar();
    }
  }

  public class UsoDeAbstracao
  {
    private readonly IRepositorio _repositorio;

    //contrutor
    // passar o contrato pela injeção de dependencia evita quebra o codigo caso a classe completa por exemplo utiliza um construtor
    public UsoDeAbstracao(IRepositorio repositorio)
    {
      _repositorio = repositorio;
    }

    public void Processo()
    {
      _repositorio.Adicionar();
    }
  }

  public class TesteInterfaceImplementacao
  {
    public TesteInterfaceImplementacao()
    {
      var repositorioUsoImplementacao = new UsoImplementacao();
      repositorioUsoImplementacao.Processo();

      var repositorioAbstracao = new UsoDeAbstracao(new Repositorio());
      repositorioAbstracao.Processo();
    }
  }
}
