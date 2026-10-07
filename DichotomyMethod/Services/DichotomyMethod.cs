using DichotomyMethod.Models;

namespace DichotomyMethod.Services {
  public static class BisectionMethod {
    public static CalculationResult FindRoot(Func<double, double> function, double a, double b, double e) {
      double fa = function(a);
      double fb = function(b);

      // Проверяем, что функция определена в концах интервала
      if (double.IsNaN(fa) || double.IsInfinity(fa))
        throw new ArgumentException(
            "Функция не определена в точке a.");

      if (double.IsNaN(fb) || double.IsInfinity(fb))
        throw new ArgumentException(
            "Функция не определена в точке b.");

      // Если корень уже находится на границе
      if (Math.Abs(fa) < e) {
        return new CalculationResult {
          Root = a,
          FunctionValue = fa,
          Iterations = 0
        };
      }

      if (Math.Abs(fb) < e) {
        return new CalculationResult {
          Root = b,
          FunctionValue = fb,
          Iterations = 0
        };
      }

      // Для метода дихотомии знаки должны различаться
      if (fa * fb > 0) {
        throw new ArgumentException(
            "На концах интервала функция имеет одинаковые знаки. " +
            "Метод половинного деления неприменим.");
      }

      int iterations = 0;

      // Защита от бесконечного цикла
      const int maxIterations = 10000;

      while (Math.Abs(b - a) > e) {
        if (iterations >= maxIterations) {
          throw new InvalidOperationException(
              "Превышено максимальное количество итераций.");
        }

        double c = (a + b) / 2.0;
        double fc = function(c);

        // Функция внезапно стала неопределённой
        if (double.IsNaN(fc) || double.IsInfinity(fc)) {
          throw new ArgumentException(
              $"Функция не определена в точке x = {c}.");
        }

        iterations++;

        // Нашли корень с заданной точностью
        if (Math.Abs(fc) < e) {
          return new CalculationResult {
            Root = c,
            FunctionValue = fc,
            Iterations = iterations
          };
        }

        // Выбираем половину, где сохраняется смена знака
        if (fa * fc < 0) {
          b = c;
          fb = fc;
        } else {
          a = c;
          fa = fc;
        }
      }

      // Берём середину последнего интервала
      double root = (a + b) / 2.0;
      double functionValue = function(root);

      return new CalculationResult {
        Root = root,
        FunctionValue = functionValue,
        Iterations = iterations
      };
    }
  }
}