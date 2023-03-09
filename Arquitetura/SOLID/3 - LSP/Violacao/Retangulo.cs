using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP
{
  // LSP - Liskov Substitution Principle (Princípio da substituição de Liskov)
  //O Princípio de Substituição de Liskov diz que objetos podem ser substituídos por seus subtipos
  //  sem que isso afete a execução correta do programa.
  public class Retangulo
  {
    //quem Hedar um atributo ou metodo virtual pode substituir sua funcionalidade com override.
    public virtual double Altura { get; set; }
    public virtual double Largura { get; set; }
    public double Area { get { return Altura * Largura; } }
  }
}
