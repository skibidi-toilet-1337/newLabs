namespace DichotomyMethod
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      menuStrip1 = new MenuStrip();
      рассчётToolStripMenuItem = new ToolStripMenuItem();
      рассчитатьToolStripMenuItem = new ToolStripMenuItem();
      очиститьToolStripMenuItem = new ToolStripMenuItem();
      видToolStripMenuItem = new ToolStripMenuItem();
      выходToolStripMenuItem = new ToolStripMenuItem();
      grpInput = new GroupBox();
      txtE = new TextBox();
      label4 = new Label();
      txtB = new TextBox();
      label3 = new Label();
      txtA = new TextBox();
      label2 = new Label();
      txtFunc = new TextBox();
      label1 = new Label();
      groupBox1 = new GroupBox();
      chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
      groupBox2 = new GroupBox();
      txtIters = new TextBox();
      lblStatus = new Label();
      label6 = new Label();
      txtFunc2 = new TextBox();
      label7 = new Label();
      txtRoot = new TextBox();
      label8 = new Label();
      menuStrip1.SuspendLayout();
      grpInput.SuspendLayout();
      groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
      groupBox2.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { рассчётToolStripMenuItem, видToolStripMenuItem, выходToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1158, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // рассчётToolStripMenuItem
      // 
      рассчётToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { рассчитатьToolStripMenuItem, очиститьToolStripMenuItem });
      рассчётToolStripMenuItem.Name = "рассчётToolStripMenuItem";
      рассчётToolStripMenuItem.Size = new Size(56, 20);
      рассчётToolStripMenuItem.Text = "Расчёт";
      // 
      // рассчитатьToolStripMenuItem
      // 
      рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      рассчитатьToolStripMenuItem.Size = new Size(135, 22);
      рассчитатьToolStripMenuItem.Text = "Рассчитать";
      рассчитатьToolStripMenuItem.Click += рассчитатьToolStripMenuItem_Click;
      // 
      // очиститьToolStripMenuItem
      // 
      очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      очиститьToolStripMenuItem.Size = new Size(135, 22);
      очиститьToolStripMenuItem.Text = "Очистить";
      очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
      // 
      // видToolStripMenuItem
      // 
      видToolStripMenuItem.Name = "видToolStripMenuItem";
      видToolStripMenuItem.Size = new Size(39, 20);
      видToolStripMenuItem.Text = "Вид";
      видToolStripMenuItem.Click += видToolStripMenuItem_Click;
      // 
      // выходToolStripMenuItem
      // 
      выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      выходToolStripMenuItem.Size = new Size(54, 20);
      выходToolStripMenuItem.Text = "Выход";
      выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
      // 
      // grpInput
      // 
      grpInput.Controls.Add(txtE);
      grpInput.Controls.Add(label4);
      grpInput.Controls.Add(txtB);
      grpInput.Controls.Add(label3);
      grpInput.Controls.Add(txtA);
      grpInput.Controls.Add(label2);
      grpInput.Controls.Add(txtFunc);
      grpInput.Controls.Add(label1);
      grpInput.Location = new Point(12, 27);
      grpInput.Name = "grpInput";
      grpInput.Size = new Size(242, 264);
      grpInput.TabIndex = 1;
      grpInput.TabStop = false;
      grpInput.Text = "Входные данные";
      // 
      // txtE
      // 
      txtE.Location = new Point(6, 222);
      txtE.Name = "txtE";
      txtE.Size = new Size(220, 23);
      txtE.TabIndex = 7;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label4.Location = new Point(6, 198);
      label4.Name = "label4";
      label4.Size = new Size(23, 21);
      label4.TabIndex = 6;
      label4.Text = "e:";
      // 
      // txtB
      // 
      txtB.Location = new Point(6, 162);
      txtB.Name = "txtB";
      txtB.Size = new Size(220, 23);
      txtB.TabIndex = 5;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label3.Location = new Point(6, 138);
      label3.Name = "label3";
      label3.Size = new Size(24, 21);
      label3.TabIndex = 4;
      label3.Text = "b:";
      // 
      // txtA
      // 
      txtA.Location = new Point(6, 100);
      txtA.Name = "txtA";
      txtA.Size = new Size(220, 23);
      txtA.TabIndex = 3;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label2.Location = new Point(6, 76);
      label2.Name = "label2";
      label2.Size = new Size(23, 21);
      label2.TabIndex = 2;
      label2.Text = "a:";
      // 
      // txtFunc
      // 
      txtFunc.Location = new Point(6, 43);
      txtFunc.Name = "txtFunc";
      txtFunc.Size = new Size(220, 23);
      txtFunc.TabIndex = 1;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label1.Location = new Point(6, 19);
      label1.Name = "label1";
      label1.Size = new Size(41, 21);
      label1.TabIndex = 0;
      label1.Text = "f(x):";
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(chartFunc);
      groupBox1.Location = new Point(260, 27);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(500, 500);
      groupBox1.TabIndex = 2;
      groupBox1.TabStop = false;
      groupBox1.Text = "График функции";
      // 
      // chartFunc
      // 
      chartArea1.Name = "ChartArea1";
      chartFunc.ChartAreas.Add(chartArea1);
      chartFunc.Dock = DockStyle.Fill;
      chartFunc.Location = new Point(3, 19);
      chartFunc.Name = "chartFunc";
      series1.ChartArea = "ChartArea1";
      series1.Name = "Series1";
      chartFunc.Series.Add(series1);
      chartFunc.Size = new Size(494, 478);
      chartFunc.TabIndex = 0;
      chartFunc.Text = "chart1";
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(txtIters);
      groupBox2.Controls.Add(lblStatus);
      groupBox2.Controls.Add(label6);
      groupBox2.Controls.Add(txtFunc2);
      groupBox2.Controls.Add(label7);
      groupBox2.Controls.Add(txtRoot);
      groupBox2.Controls.Add(label8);
      groupBox2.Location = new Point(12, 297);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(242, 264);
      groupBox2.TabIndex = 8;
      groupBox2.TabStop = false;
      groupBox2.Text = "Результат";
      // 
      // txtIters
      // 
      txtIters.Location = new Point(6, 162);
      txtIters.Name = "txtIters";
      txtIters.Size = new Size(220, 23);
      txtIters.TabIndex = 7;
      // 
      // lblStatus
      // 
      lblStatus.AutoSize = true;
      lblStatus.Font = new Font("Segoe UI", 12F);
      lblStatus.Location = new Point(6, 206);
      lblStatus.Name = "lblStatus";
      lblStatus.Size = new Size(60, 21);
      lblStatus.TabIndex = 6;
      lblStatus.Text = "Статус:";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label6.Location = new Point(6, 138);
      label6.Name = "label6";
      label6.Size = new Size(92, 21);
      label6.TabIndex = 4;
      label6.Text = "Итераций:";
      // 
      // txtFunc2
      // 
      txtFunc2.Location = new Point(6, 100);
      txtFunc2.Name = "txtFunc2";
      txtFunc2.Size = new Size(220, 23);
      txtFunc2.TabIndex = 3;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label7.Location = new Point(6, 76);
      label7.Name = "label7";
      label7.Size = new Size(121, 21);
      label7.TabIndex = 2;
      label7.Text = "Значение f(x):";
      // 
      // txtRoot
      // 
      txtRoot.Location = new Point(6, 43);
      txtRoot.Name = "txtRoot";
      txtRoot.Size = new Size(220, 23);
      txtRoot.TabIndex = 1;
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label8.Location = new Point(6, 19);
      label8.Name = "label8";
      label8.Size = new Size(72, 21);
      label8.TabIndex = 0;
      label8.Text = "Корень:";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1158, 616);
      Controls.Add(groupBox2);
      Controls.Add(groupBox1);
      Controls.Add(grpInput);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Метод дихотомии";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      grpInput.ResumeLayout(false);
      grpInput.PerformLayout();
      groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem рассчётToolStripMenuItem;
    private ToolStripMenuItem видToolStripMenuItem;
    private ToolStripMenuItem выходToolStripMenuItem;
    private GroupBox grpInput;
    private Label label1;
    private TextBox txtFunc;
    private TextBox txtE;
    private Label label4;
    private TextBox txtB;
    private Label label3;
    private TextBox txtA;
    private Label label2;
    private GroupBox groupBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
    private GroupBox groupBox2;
    private TextBox textBox1;
    private Label label5;
    private TextBox textBox2;
    private Label label6;
    private TextBox txtFunc2;
    private Label label7;
    private TextBox txtRoot;
    private Label label8;
    private Label lblStatus;
    private ToolStripMenuItem рассчитатьToolStripMenuItem;
    private ToolStripMenuItem очиститьToolStripMenuItem;
    private TextBox txtIters;
  }
}
