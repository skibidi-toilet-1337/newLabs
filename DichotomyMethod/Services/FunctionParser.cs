using NCalc;
using System.Globalization;

namespace DichotomyMethod.Services {
  public static class FunctionParser {
    public static Func<double, double> Parse(string formula) {
      if (string.IsNullOrWhiteSpace(formula))
        throw new ArgumentException(
            "Формула функции не может быть пустой.");

      // Приводим привычные математические функции
      // к названиям, которые понимает NCalc.
      formula = NormalizeFormula(formula);

      // Проверяем синтаксис формулы.
      Validate(formula);

      return x =>
      {
        var expression = new Expression(formula);

        expression.Parameters["x"] = x;

        object result = expression.Evaluate();

        if (result == null)
          throw new ArgumentException(
              "Не удалось вычислить функцию.");

        double value = Convert.ToDouble(
            result,
            CultureInfo.InvariantCulture);

        if (double.IsNaN(value) || double.IsInfinity(value)) {
          throw new ArgumentException(
              $"Функция не определена при x = {x}.");
        }

        return value;
      };
    }

    private static string NormalizeFormula(string formula) {
      formula = formula
          .Replace("asin", "Asin", StringComparison.OrdinalIgnoreCase)
          .Replace("acos", "Acos", StringComparison.OrdinalIgnoreCase)
          .Replace("atan", "Atan", StringComparison.OrdinalIgnoreCase)
          .Replace("sqrt", "Sqrt", StringComparison.OrdinalIgnoreCase)
          .Replace("sin", "Sin", StringComparison.OrdinalIgnoreCase)
          .Replace("cos", "Cos", StringComparison.OrdinalIgnoreCase)
          .Replace("tan", "Tan", StringComparison.OrdinalIgnoreCase)
          .Replace("sinh", "Sinh", StringComparison.OrdinalIgnoreCase)
          .Replace("cosh", "Cosh", StringComparison.OrdinalIgnoreCase)
          .Replace("tanh", "Tanh", StringComparison.OrdinalIgnoreCase)
          .Replace("abs", "Abs", StringComparison.OrdinalIgnoreCase)
          .Replace("exp", "Exp", StringComparison.OrdinalIgnoreCase)
          .Replace("log10", "Log10", StringComparison.OrdinalIgnoreCase)
          .Replace("log", "Log", StringComparison.OrdinalIgnoreCase)
          .Replace("pow", "Pow", StringComparison.OrdinalIgnoreCase)
          .Replace("floor", "Floor", StringComparison.OrdinalIgnoreCase)
          .Replace("ceil", "Ceiling", StringComparison.OrdinalIgnoreCase);

      return formula;
    }

    private static void Validate(string formula) {
      try {
        var expression = new Expression(formula);

        expression.Parameters["x"] = 1.0;

        object result = expression.Evaluate();

        if (result == null)
          throw new ArgumentException(
              "Формула вернула пустой результат.");
      }
      catch {
        throw new ArgumentException(
            "Некорректная формула f(x). " +
            "Проверьте синтаксис выражения.");
      }
    }
  }
}