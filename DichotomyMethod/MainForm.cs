using DichotomyMethod.Services;

namespace DichotomyMethod {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();

      /*try {
        var function = FunctionParser.Parse("sin(x)");

        GraphService.DrawFunction(chartFunc, function, -10, 10);
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }*/
    }

    private void Calculate() {
      try {
        // 1. Получаем формулу
        string formula = txtFunc.Text.Trim();

        if (string.IsNullOrWhiteSpace(formula)) {
          throw new ArgumentException(
              "Введите формулу функции f(x).");
        }

        // 2. Получаем числа
        if (!Double.TryParse(txtA.Text, out double a)) {
          throw new ArgumentException(
              "Некорректно введено значение a.");
        }

        if (!Double.TryParse(txtB.Text, out double b)) {
          throw new ArgumentException(
              "Некорректно введено значение b.");
        }

        if (!Double.TryParse(txtE.Text, out double e)) {
          throw new ArgumentException(
              "Некорректно введена точность e.");
        }

        // 3. Проверяем интервал
        if (a >= b) {
          throw new ArgumentException(
              "Должно выполняться условие a < b.");
        }

        // 4. Проверяем точность
        if (e <= 0) {
          throw new ArgumentException(
              "Точность e должна быть больше нуля.");
        }

        if (double.IsInfinity(a) ||
            double.IsInfinity(b) ||
            double.IsInfinity(e)) {
          throw new ArgumentException(
              "Значения не должны быть бесконечными.");
        }

        // 5. Создаём функцию
        Func<double, double> function =
            FunctionParser.Parse(formula);

        // 6. Сначала строим график
        GraphService.DrawFunction(
            chartFunc,
            function,
            a,
            b);

        // Проверяем интервал на возможные разрывы
        FunctionValidator.ValidateInterval(
            function,
            a,
            b,
            e);

        // 7. Запускаем метод дихотомии
        var result = BisectionMethod.FindRoot(function, a, b, e);

        GraphService.DrawRoot(chartFunc, result.Root, function);

        // 8. Выводим результат
        txtRoot.Text =
            $"Корень: {result.Root:F10}";

        txtFunc2.Text =
            $"f(x): {result.FunctionValue:F10}";

        txtIters.Text =
            $"Итераций: {result.Iterations}";

        lblStatus.Text = "Расчёт успешно выполнен.";
      }
      catch (Exception ex) {
        lblStatus.Text = "Ошибка.";

        MessageBox.Show(
            ex.Message,
            "Ошибка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
      }
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e) {
      Calculate();
    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void ClearAllTextBoxes(Control controlContainer) {
      foreach (Control c in controlContainer.Controls) {
        if (c is TextBox textBox) {
          textBox.Clear(); // Очищает текст через метод TextBoxBase.Clear()
        } else if (c.HasChildren) {
          ClearAllTextBoxes(c); // Рекурсивно заходим в контейнеры (Panel, GroupBox, TabControl и т.д.)
        }
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) {
      ClearAllTextBoxes(this);
      chartFunc.Series.Clear();
    }

    private void видToolStripMenuItem_Click(object sender, EventArgs e) {
      if (chartFunc.Visible == true) {
      chartFunc.Hide();
      chartFunc.Visible = false;
      } else {
        chartFunc.Show();
        chartFunc.Visible = true;
      }


    }
  }
}