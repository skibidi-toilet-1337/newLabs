namespace QuadraticSolver
{
    partial class Form1
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
        private void InitializeComponent()
        {
            labelA = new Label();
            inputA = new TextBox();
            inputB = new TextBox();
            labelB = new Label();
            inputC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            output = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 20F);
            labelA.Location = new Point(12, 9);
            labelA.Name = "labelA";
            labelA.Size = new Size(63, 37);
            labelA.TabIndex = 0;
            labelA.Text = "a = ";
            // 
            // inputA
            // 
            inputA.Font = new Font("Segoe UI", 20F);
            inputA.Location = new Point(62, 9);
            inputA.Name = "inputA";
            inputA.Size = new Size(232, 43);
            inputA.TabIndex = 1;
            // 
            // inputB
            // 
            inputB.Font = new Font("Segoe UI", 20F);
            inputB.Location = new Point(62, 72);
            inputB.Name = "inputB";
            inputB.Size = new Size(232, 43);
            inputB.TabIndex = 3;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 20F);
            labelB.Location = new Point(12, 72);
            labelB.Name = "labelB";
            labelB.Size = new Size(65, 37);
            labelB.TabIndex = 2;
            labelB.Text = "b = ";
            // 
            // inputC
            // 
            inputC.Font = new Font("Segoe UI", 20F);
            inputC.Location = new Point(62, 143);
            inputC.Name = "inputC";
            inputC.Size = new Size(232, 43);
            inputC.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(61, 37);
            label1.TabIndex = 4;
            label1.Text = "c = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(364, 9);
            label2.Name = "label2";
            label2.Size = new Size(247, 37);
            label2.TabIndex = 6;
            label2.Text = "Способ решения:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 20F);
            radioButton1.Location = new Point(364, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(270, 41);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "По дискриминанту";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 20F);
            radioButton2.Location = new Point(364, 96);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(258, 41);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "По теореме Виета";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 20F);
            radioButton3.Location = new Point(364, 145);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(194, 41);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Оба способа";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            output.Location = new Point(12, 286);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(622, 401);
            output.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(12, 219);
            button1.Name = "button1";
            button1.Size = new Size(232, 45);
            button1.TabIndex = 11;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 699);
            Controls.Add(button1);
            Controls.Add(output);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(inputC);
            Controls.Add(label1);
            Controls.Add(inputB);
            Controls.Add(labelB);
            Controls.Add(inputA);
            Controls.Add(labelA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelA;
        private TextBox inputA;
        private TextBox inputB;
        private Label labelB;
        private TextBox inputC;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox output;
        private Button button1;
    }
}
