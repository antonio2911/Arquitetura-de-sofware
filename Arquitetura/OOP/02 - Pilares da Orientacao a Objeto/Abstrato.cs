using OOP._01___Classe_X_Objeto;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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


  //resumo
//  Uma classe abstrata é uma classe que não pode ser instanciada, isto é, não é possível criar objetos diretamente a partir dela.
//  Ela é utilizada como uma classe base para outras classes que a estendem, fornecendo um conjunto de métodos e atributos comuns
//  que as subclasses podem utilizar e implementar.
//  Um método abstrato é um método declarado na classe abstrata que não possui implementação na classe base, isto é, é declarado sem corpo.
//  Ele é utilizado para definir um contrato que as subclasses devem seguir, ou seja, todas as subclasses que estenderem a classe abstrata
//  devem implementar esse método de acordo com a sua própria lógica.

//Para definir uma classe abstrata em Java, utiliza-se a palavra-chave "abstract" antes da palavra "class".
//Para definir um método abstrato, utiliza-se a palavra-chave "abstract" antes da palavra-chave do método e não se coloca o corpo do método
//.Exemplo:
}
