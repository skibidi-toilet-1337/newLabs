namespace QuadraticSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool TryReadCoefficient(string text, string name, out double value)
        {
            string normalized = text.Trim().Replace(',', '.');

            if (!double.TryParse(normalized,
                                 System.Globalization.NumberStyles.Float,
                                 System.Globalization.CultureInfo.InvariantCulture,
                                 out value))
            {
                ShowError($"Не удалось прочитать коэффициент '{name}'. Введите число.");
                return false;
            }
            return true;
        }

        private string SolveByDiscriminant(double a, double b, double c)
        {
            //D = b^2 - 4*a*c
            double discriminant = b * b - 4 * a * c;

            string result = $"a = {a}, b = {b}, c = {c}\r\n";
            result += $"Дискриминант D = {discriminant:F4}\r\n";

            if (discriminant > 0)
            {
                double sqrtD = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                result += $"D > 0 следовательно два корня:\r\n  x1 = {x1:F4}\r\n  x2 = {x2:F4}";
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                result += $"D = 0 следовательно один корень:\r\n  x = {x:F4}";
            }
            else
            {
                result += "D < 0 следовательно действительных корней нет.";
            }

            return result;
        }

        private string SolveByVieta(double a, double b, double c)
        {
            //x1 + x2 = -b
            //x1 * x2 = c
            double reducedB = b / a;
            double reducedC = c / a;

            double discriminant = reducedB * reducedB - 4 * reducedC;

            if (discriminant < 0)
            {
                throw new InvalidOperationException(
                    "По теореме Виета нельзя найти действительные корни, потому что дискриминант отрицательный.");
            }

            double sum = -reducedB;    //x1 + x2
            double product = reducedC; //x1 * x2

            double sqrtD = Math.Sqrt(discriminant);

            string result = $"Приведённое уравнение: x^2 + ({reducedB:F4})x + ({reducedC:F4}) = 0\r\n";
            result += $"По Виету: x1 + x2 = {sum:F4}, x1 * x2 = {product:F4}\r\n";

            if (discriminant == 0)
            {
                double x = sum / 2;
                result += $"Корни совпадают: x1 = x2 = {x:F4}";
            }
            else
            {
                double x1 = (sum + sqrtD) / 2;
                double x2 = (sum - sqrtD) / 2;
                result += $"Корни:\r\n  x1 = {x1:F4}\r\n  x2 = {x2:F4}";
            }

            return result;
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            output.Clear();

            if (!TryReadCoefficient(inputA.Text, "a", out double a)) return;
            if (!TryReadCoefficient(inputB.Text, "b", out double b)) return;
            if (!TryReadCoefficient(inputC.Text, "c", out double c)) return;

            if (a == 0)
            {
                ShowError("Коэффициент a не может быть равен 0, потому что это не квадратное уравнение.");
                return;
            }

            try
            {
                if (radioButton1.Checked)
                {
                    string text = SolveByDiscriminant(a, b, c);
                    output.Text = text;
                }
                else if (radioButton2.Checked)
                {
                    string text = SolveByVieta(a, b, c);
                    output.Text = text;
                }
                else
                {
                    string textDiscriminant = SolveByDiscriminant(a, b, c);
                    string textVieta = SolveByVieta(a, b, c);

                    output.Text =
                        "Через дискриминант\r\n" + textDiscriminant +
                        "\r\n\r\nЧерез теорему Виета\r\n" + textVieta;
                }
            }
            catch (Exception ex)
            {
                ShowError("Произошла непредвиденная ошибка:\r\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Clear();

            if (!TryReadCoefficient(inputA.Text, "a", out double a)) return;
            if (!TryReadCoefficient(inputB.Text, "b", out double b)) return;
            if (!TryReadCoefficient(inputC.Text, "c", out double c)) return;

            if (a == 0)
            {
                ShowError("Коэффициент 'a' не может быть равен 0 — это не квадратное уравнение.");
                return;
            }

            try
            {
                if (radioButton1.Checked)
                {
                    string text = SolveByDiscriminant(a, b, c);
                    output.Text = text;
                }
                else if (radioButton2.Checked)
                {
                    string text = SolveByVieta(a, b, c);
                    output.Text = text;
                }
                else
                {
                    string textDiscriminant = SolveByDiscriminant(a, b, c);
                    string textVieta = SolveByVieta(a, b, c);

                    output.Text =
                        "Через дискриминант\r\n" + textDiscriminant +
                        "\r\n\r\nЧерез теорему Виета\r\n" + textVieta;
                }
            }
            catch (Exception ex)
            {
                ShowError("Произошла непредвиденная ошибка:\r\n" + ex.Message);
            }
        }
    }
}
