using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichotomyMethod.Models {
  public class CalculationResult {
    public double Root { get; set; }

    public double FunctionValue { get; set; }

    public int Iterations { get; set; }
  }
}