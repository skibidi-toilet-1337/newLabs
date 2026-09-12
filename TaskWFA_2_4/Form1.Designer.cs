namespace TaskWFA_2_4 {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.buttonFind = new System.Windows.Forms.Button();
      this.textCity = new System.Windows.Forms.TextBox();
      this.textResult = new System.Windows.Forms.TextBox();
      this.textAverageAge = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
      this.buttonGenerate.Location = new System.Drawing.Point(149, 36);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(131, 73);
      this.buttonGenerate.TabIndex = 0;
      this.buttonGenerate.Text = "Сгенерировать\r\nданные";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click_1);
      // 
      // buttonFind
      // 
      this.buttonFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
      this.buttonFind.Location = new System.Drawing.Point(149, 142);
      this.buttonFind.Name = "buttonFind";
      this.buttonFind.Size = new System.Drawing.Size(131, 37);
      this.buttonFind.TabIndex = 1;
      this.buttonFind.Text = "Найти";
      this.buttonFind.UseVisualStyleBackColor = true;
      this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click_1);
      // 
      // textCity
      // 
      this.textCity.Location = new System.Drawing.Point(149, 115);
      this.textCity.Name = "textCity";
      this.textCity.Size = new System.Drawing.Size(424, 20);
      this.textCity.TabIndex = 2;
      // 
      // textResult
      // 
      this.textResult.Location = new System.Drawing.Point(149, 185);
      this.textResult.Multiline = true;
      this.textResult.Name = "textResult";
      this.textResult.ReadOnly = true;
      this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textResult.Size = new System.Drawing.Size(530, 193);
      this.textResult.TabIndex = 3;
      // 
      // textAverageAge
      // 
      this.textAverageAge.Location = new System.Drawing.Point(149, 399);
      this.textAverageAge.Name = "textAverageAge";
      this.textAverageAge.Size = new System.Drawing.Size(131, 20);
      this.textAverageAge.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(32, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(111, 22);
      this.label1.TabIndex = 5;
      this.label1.Text = "Задание 2.4";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label2.Location = new System.Drawing.Point(91, 115);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 19);
      this.label2.TabIndex = 6;
      this.label2.Text = "Город:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label3.Location = new System.Drawing.Point(57, 184);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 19);
      this.label3.TabIndex = 7;
      this.label3.Text = "Результаты:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label4.Location = new System.Drawing.Point(15, 397);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(128, 19);
      this.label4.TabIndex = 8;
      this.label4.Text = "Средний возраст:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textAverageAge);
      this.Controls.Add(this.textResult);
      this.Controls.Add(this.textCity);
      this.Controls.Add(this.buttonFind);
      this.Controls.Add(this.buttonGenerate);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.Button buttonFind;
    private System.Windows.Forms.TextBox textCity;
    private System.Windows.Forms.TextBox textResult;
    private System.Windows.Forms.TextBox textAverageAge;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

