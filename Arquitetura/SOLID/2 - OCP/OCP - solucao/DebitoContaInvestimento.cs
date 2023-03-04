﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP___solucao
{
  public class DebitoContaInvestimento : DebitoConta
  {
    public override string Debitar(decimal valor, string conta)
    {
      // Debita Conta Investimento
      // Isentar Taxas
      return FormatarTransacao();
    }
  }
}
