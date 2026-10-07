namespace DichotomyMethod.Services {
  public static class FunctionValidator {
    private const int InitialParts = 100;
    private const int MaxDepth = 20;

    public static void ValidateInterval(
        Func<double, double> function,
        double a,
        double b,
        double e) {
      double step = (b - a) / InitialParts;

      double x1 = a;
      double y1 = Evaluate(function, x1);

      for (int i = 1; i <= InitialParts; i++) {
        double x2 = a + i * step;
        double y2 = Evaluate(function, x2);

        if (HasSignChange(y1, y2)) {
          CheckSignChange(
              function,
              x1,
              y1,
              x2,
              y2,
              e,
              0);
        }

        x1 = x2;
        y1 = y2;
      }
    }

    private static void CheckSignChange(
        Func<double, double> function,
        double x1,
        double y1,
        double x2,
        double y2,
        double e,
        int depth) {
      double xm = (x1 + x2) / 2.0;
      double ym = Evaluate(function, xm);

      /*
       * Если в середине уже получили значение,
       * очень близкое к нулю — это нормальный корень.
       */
      if (Math.Abs(ym) < e)
        return;

      /*
       * Если на одной из половин снова есть
       * смена знака — продолжаем исследование.
       */
      bool leftChange = HasSignChange(y1, ym);
      bool rightChange = HasSignChange(ym, y2);

      /*
       * Главный критерий подозрения:
       *
       * у настоящего корня при приближении
       * к нему мы должны видеть уменьшение |f(x)|.
       *
       * У асимптоты наоборот:
       *
       * |f(x)| становится огромным.
       */
      double minEndpoint =
          Math.Min(
              Math.Abs(y1),
              Math.Abs(y2));

      double middle =
          Math.Abs(ym);

      bool middleIsHuge =
          middle > minEndpoint * 10.0;

      /*
       * Если середина огромная относительно концов,
       * очень похоже на разрыв.
       */
      if (middleIsHuge) {
        throw new ArgumentException(
            $"Обнаружен возможный разрыв функции " +
            $"около x = {xm:F10}.");
      }

      /*
       * Если смена знака сохраняется,
       * продолжаем дробить.
       */
      if (leftChange || rightChange) {
        if (depth >= MaxDepth) {
          /*
           * На последнем уровне:
           * если мы так и не нашли значение,
           * близкое к нулю, это подозрительно.
           */
          throw new ArgumentException(
              "Обнаружен возможный разрыв функции " +
              "на заданном интервале.");
        }

        if (leftChange) {
          CheckSignChange(
              function,
              x1,
              y1,
              xm,
              ym,
              e,
              depth + 1);
        }

        if (rightChange) {
          CheckSignChange(
              function,
              xm,
              ym,
              x2,
              y2,
              e,
              depth + 1);
        }
      }
    }

    private static double Evaluate(
        Func<double, double> function,
        double x) {
      try {
        double y = function(x);

        if (double.IsNaN(y) ||
            double.IsInfinity(y)) {
          throw new ArgumentException(
              $"Функция не определена при x = {x:F10}.");
        }

        return y;
      }
      catch (ArgumentException) {
        throw;
      }
      catch {
        throw new ArgumentException(
            $"Не удалось вычислить функцию при x = {x:F10}.");
      }
    }

    private static bool HasSignChange(
        double y1,
        double y2) {
      return
          (y1 < 0 && y2 > 0) ||
          (y1 > 0 && y2 < 0);
    }
  }
}