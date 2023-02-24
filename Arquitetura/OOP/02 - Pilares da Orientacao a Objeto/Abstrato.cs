using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02___Pilares_da_Orientacao_a_Objeto
{
  // classe abstrata pode ser Herdada mas não pode ser instanciada com um new.
  public abstract class Eletrodomestico
  {
    private readonly string _nome;
    private readonly int _voltagem;


    //contrutor
    //protected segue a hierarquia de Herança somente as filha pode ter acesso
    // sem Herança não tem como instanciar a propriedade o metodo

    protected Eletrodomestico(string nome, int voltagem)
    {
      _nome = nome;
      _voltagem = voltagem;
    }

    public abstract void Ligar();
    public abstract void Desligar();

    // pode estanciar mas não e permitido sobrescrever o metodo
    // você so pode utilizar o que tem dentro do pai
    public void testeEquipamento()
    {
      //testando
    }

    // para poder sobrescrever utilizar o virtual
    public virtual void Teste()
    {
      // pode sobrescrever
    }
  }
}
