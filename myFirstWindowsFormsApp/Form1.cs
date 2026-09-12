using System;
using System.Windows.Forms;

namespace myFirstWindowsFormsApp {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    
    private void button1_Click(object sender, EventArgs e) {
      double l;
      double r;
      double R;
      double rho;

      if (!double.TryParse(txtLength.Text, out l) || l <= 0) {
        MessageBox.Show("Введите положительную длину l");
        return;
      }

      if (!double.TryParse(txtInnerRadius.Text, out r) || r <= 0) {
        MessageBox.Show("Введите положительный внутренний радиус r");
        return;
      }

      if (!double.TryParse(txtOuterRadius.Text, out R) || R <= 0) {
        MessageBox.Show("Введите положительный внешний радиус R");
        return;
      }

      if (!double.TryParse(txtDensity.Text, out rho) || rho <= 0) {
        MessageBox.Show("Введите положительную плотность p");
        return;
      }

      if (r >= R) {
        MessageBox.Show("Должно выполняться условие r < R");
        return;
      }

      double V = l * Math.PI * (R * R - r * r);
      double m = rho * V;

      txtVolume.Text = V.ToString();
      txtMass.Text = m.ToString();
    }

  
  }
}
