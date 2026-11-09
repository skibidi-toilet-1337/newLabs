using System.Windows.Forms.DataVisualization.Charting;

namespace DichotomyMethod.Services {
  public static class GraphService {
    public static void DrawFunction(
        Chart chart,
        Func<double, double> function,
        double a,
        double b) {
      chart.Series.Clear();
      chart.ChartAreas.Clear();

      ChartArea area = new ChartArea("MainArea");

      area.AxisX.Title = "X";
      area.AxisY.Title = "f(x)";

      area.AxisX.MajorGrid.Enabled = true;
      area.AxisY.MajorGrid.Enabled = true;

      // Нормальный вид подписей
      area.AxisX.LabelStyle.Format = "0.##";
      area.AxisY.LabelStyle.Format = "0.##";

      chart.ChartAreas.Add(area);

      const int pointsCount = 2000;
      const double maxY = 50;

      double step = (b - a) / (pointsCount - 1);

      Series currentSeries = CreateFunctionSeries(chart);

      double? previousX = null;
      double? previousY = null;

      for (int i = 0; i < pointsCount; i++) {
        double x = a + i * step;

        try {
          double y = function(x);

          // Точка недопустима
          if (double.IsNaN(y) ||
              double.IsInfinity(y) ||
              Math.Abs(y) > maxY) {
            currentSeries =
                CreateFunctionSeries(chart);

            previousX = null;
            previousY = null;

            continue;
          }

          // Проверяем скачок между соседними точками
          if (previousY.HasValue) {
            double difference =
                Math.Abs(y - previousY.Value);

            if (difference > 10) {
              currentSeries =
                  CreateFunctionSeries(chart);

              previousX = null;
              previousY = null;
            }
          }

          currentSeries.Points.AddXY(x, y);

          previousX = x;
          previousY = y;
        }
        catch {
          currentSeries =
              CreateFunctionSeries(chart);

          previousX = null;
          previousY = null;
        }
      }
    }

    private static Series CreateFunctionSeries(
        Chart chart) {
      string name =
          $"f(x)_{chart.Series.Count + 1}";

      Series series = new Series(name);

      series.ChartType = SeriesChartType.Line;
      series.BorderWidth = 2;

      chart.Series.Add(series);

      return series;
    }

    public static void DrawRoot(
        Chart chart,
        double root,
        Func<double, double> function) {
      Series rootSeries = new Series("Корень");

      rootSeries.ChartType =
          SeriesChartType.Point;

      rootSeries.MarkerStyle =
          MarkerStyle.Circle;

      rootSeries.MarkerSize = 10;

      double y = function(root);

      if (!double.IsNaN(y) &&
          !double.IsInfinity(y)) {
        rootSeries.Points.AddXY(root, y);
      }

      chart.Series.Add(rootSeries);
    }
  }
}