using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._04___Heranca_e_Composicao
{
  #region Case 1
  public class Pessoa
  {
    public int Cpf { get; set; }
    public int Rg { get; set; }

  }

  // exemplo de Herança 
  // relação e um.

  public class PessoaFisica : Pessoa
  {
    public string Nome { get; set; }
  }

    // composição de objeto
    // 

  public class PessoaFisica2
  {
    public Pessoa Pessoa { get; set; }

    public string Nome { get; set; }
  }

  public class TesteHerancaEComposicao
  {
    public TesteHerancaEComposicao()
    {
      var pessoaHeranca = new PessoaFisica
      {
        Cpf = 123654789,
        Nome = "Toni Marques",
        Rg = 1254684,
      };

      var pessoaComposicao = new PessoaFisica2
      {
        Nome = "João Pedro Cinqueira",
        Pessoa = new Pessoa
        {
          Rg = 123654,
          Cpf = 126578
        }
      };

      var RgHeranca = pessoaHeranca.Rg;
      var RgComposicao = pessoaComposicao.Pessoa.Rg;
    }
  }
  #endregion

  #region Case 2
  //Repositorio Generico
  public interface IRepositorio<T>
  {
    // T pode ser qualquer obj generico.
    void Adicionar(T obj);
    void Excluir(T obj);

  }
  //Repositorio especializado
  public interface IRepositorioPessoa
  {
    void Adicionar(Pessoa obj);
  }

  public class Repositorio<T> : IRepositorio<T>
  {
    public void Adicionar(T obj)
    {
      throw new NotImplementedException();
    }

    public void Excluir(T obj)
    {
      throw new NotImplementedException();
    }
  }

  public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
  {

  }

  public class RepositorioComposicao : IRepositorioPessoa
  {
    private readonly IRepositorio<Pessoa> _repositorioPessoa;

    public RepositorioComposicao(IRepositorio<Pessoa> repositorioPessoa)
    {
      _repositorioPessoa = repositorioPessoa;
    }

    public void Adicionar(Pessoa obj)
    {
      _repositorioPessoa.Adicionar(obj);
    }
  }

  public class TestesHerancaComposicao2
  {
    public TestesHerancaComposicao2()
    {
      var repoH = new RepositorioHerancaPessoa();
      repoH.Adicionar(new Pessoa());
      repoH.Excluir(new Pessoa());

      var repoC = new RepositorioComposicao(new Repositorio<Pessoa>());
      repoC.Adicionar(new Pessoa());

    }
  }
  #endregion
}
