using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02___Pilares_da_Orientacao_a_Objeto
{
  public class AutomacaoCafe
  {
    // encapsulamento e você não espor os metodos privados do objeto e construir metodos que dentro dele tem outros metodos
    // como se fosse esconder o como prepara o cafe e espondo so o super metodo.
    public void servirCafe()
    {
      var espresso = new CafeteriaEspressa();
      espresso.Ligar();
      espresso.PrepararCafe();
      espresso.Desligar();
    }
  }
}
