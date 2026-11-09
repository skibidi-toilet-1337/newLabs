namespace myFirstWindowsFormsApp {
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
      this.txtInnerRadius = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.txtLength = new System.Windows.Forms.TextBox();
      this.txtOuterRadius = new System.Windows.Forms.TextBox();
      this.txtDensity = new System.Windows.Forms.TextBox();
      this.txtVolume = new System.Windows.Forms.TextBox();
      this.txtMass = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtInnerRadius
      // 
      this.txtInnerRadius.Location = new System.Drawing.Point(117, 91);
      this.txtInnerRadius.Name = "txtInnerRadius";
      this.txtInnerRadius.Size = new System.Drawing.Size(117, 20);
      this.txtInnerRadius.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(117, 219);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(117, 36);
      this.button1.TabIndex = 1;
      this.button1.Text = "Рассчитать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtLength
      // 
      this.txtLength.Location = new System.Drawing.Point(117, 49);
      this.txtLength.Name = "txtLength";
      this.txtLength.Size = new System.Drawing.Size(117, 20);
      this.txtLength.TabIndex = 2;
      // 
      // txtOuterRadius
      // 
      this.txtOuterRadius.Location = new System.Drawing.Point(117, 135);
      this.txtOuterRadius.Name = "txtOuterRadius";
      this.txtOuterRadius.Size = new System.Drawing.Size(117, 20);
      this.txtOuterRadius.TabIndex = 3;
      // 
      // txtDensity
      // 
      this.txtDensity.Location = new System.Drawing.Point(117, 173);
      this.txtDensity.Name = "txtDensity";
      this.txtDensity.Size = new System.Drawing.Size(117, 20);
      this.txtDensity.TabIndex = 4;
      // 
      // txtVolume
      // 
      this.txtVolume.Location = new System.Drawing.Point(117, 280);
      this.txtVolume.Name = "txtVolume";
      this.txtVolume.Size = new System.Drawing.Size(117, 20);
      this.txtVolume.TabIndex = 5;
      // 
      // txtMass
      // 
      this.txtMass.Location = new System.Drawing.Point(117, 306);
      this.txtMass.Name = "txtMass";
      this.txtMass.Size = new System.Drawing.Size(117, 20);
      this.txtMass.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label1.Location = new System.Drawing.Point(15, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 19);
      this.label1.TabIndex = 6;
      this.label1.Text = "Длина l:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label2.Location = new System.Drawing.Point(15, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 38);
      this.label2.TabIndex = 7;
      this.label2.Text = "Внутренний\r\nрадиус r:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label3.Location = new System.Drawing.Point(15, 117);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 38);
      this.label3.TabIndex = 8;
      this.label3.Text = "Внешний\r\nрадиус R:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Cursor = System.Windows.Forms.Cursors.Default;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(15, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(111, 22);
      this.label4.TabIndex = 9;
      this.label4.Text = "Задание 1.4";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label5.Location = new System.Drawing.Point(15, 172);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(96, 19);
      this.label5.TabIndex = 10;
      this.label5.Text = "Плотность p:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label6.Location = new System.Drawing.Point(13, 279);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(71, 19);
      this.label6.TabIndex = 11;
      this.label6.Text = "Объем V:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
      this.label7.Location = new System.Drawing.Point(15, 305);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(69, 19);
      this.label7.TabIndex = 12;
      this.label7.Text = "Масса m:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
      this.label8.Location = new System.Drawing.Point(15, 251);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(59, 19);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ответ:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(576, 450);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMass);
      this.Controls.Add(this.txtVolume);
      this.Controls.Add(this.txtDensity);
      this.Controls.Add(this.txtOuterRadius);
      this.Controls.Add(this.txtLength);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtInnerRadius);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInnerRadius;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtLength;
    private System.Windows.Forms.TextBox txtOuterRadius;
    private System.Windows.Forms.TextBox txtDensity;
    private System.Windows.Forms.TextBox txtVolume;
    private System.Windows.Forms.TextBox txtMass;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
  }
}

