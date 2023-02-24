using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02___Pilares_da_Orientacao_a_Objeto
{
  public class CafeteriaEspressa : Eletrodomestico
  {
    public CafeteriaEspressa() : base("Padrão", 220)
    {
    }

    // pelo construtor
    public CafeteriaEspressa(string nome,int voltagem) : base(nome, voltagem) { }


    //olha que legal statico com polimofismo

    private static void AquecerAAgua() { }

    private static void MoerGraos() { }

    public void PrepararCafe()
    {
      testeEquipamento();
      AquecerAAgua();
      MoerGraos();
    }
    public override void Desligar()
    {
      // desligar tudo
    }

    public override void Ligar()
    {
      PrepararCafe();

    }
    public override void Teste()
    {
      // teste cafeteira
    }

  }
}
