namespace ГеометрическиеФигуры
{
    partial class ГлавнаяФорма
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            rbКруг = new RadioButton();
            rbПрямоугольник = new RadioButton();
            rbТреугольник = new RadioButton();
            txtРадиус = new TextBox();
            txtШирина = new TextBox();
            txtВысота = new TextBox();
            txtСторонаA = new TextBox();
            txtСторонаB = new TextBox();
            txtСторонаC = new TextBox();
            btnРассчитать = new Button();
            lblРезультатПлощади = new Label();
            lblРезультатПериметра = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // rbКруг
            // 
            rbКруг.AutoSize = true;
            rbКруг.Location = new Point(12, 12);
            rbКруг.Name = "rbКруг";
            rbКруг.Size = new Size(50, 19);
            rbКруг.TabIndex = 0;
            rbКруг.TabStop = true;
            rbКруг.Text = "Круг";
            rbКруг.UseVisualStyleBackColor = true;
            // 
            // rbПрямоугольник
            // 
            rbПрямоугольник.AutoSize = true;
            rbПрямоугольник.Location = new Point(12, 59);
            rbПрямоугольник.Name = "rbПрямоугольник";
            rbПрямоугольник.Size = new Size(114, 19);
            rbПрямоугольник.TabIndex = 1;
            rbПрямоугольник.TabStop = true;
            rbПрямоугольник.Text = "Прямоугольник";
            rbПрямоугольник.UseVisualStyleBackColor = true;
            // 
            // rbТреугольник
            // 
            rbТреугольник.AutoSize = true;
            rbТреугольник.Location = new Point(12, 128);
            rbТреугольник.Name = "rbТреугольник";
            rbТреугольник.Size = new Size(95, 19);
            rbТреугольник.TabIndex = 2;
            rbТреугольник.TabStop = true;
            rbТреугольник.Text = "Треугольник";
            rbТреугольник.UseVisualStyleBackColor = true;
            // 
            // txtРадиус
            // 
            txtРадиус.Location = new Point(150, 12);
            txtРадиус.Name = "txtРадиус";
            txtРадиус.Size = new Size(100, 23);
            txtРадиус.TabIndex = 3;
            // 
            // txtШирина
            // 
            txtШирина.Location = new Point(150, 41);
            txtШирина.Name = "txtШирина";
            txtШирина.Size = new Size(100, 23);
            txtШирина.TabIndex = 4;
            // 
            // txtВысота
            // 
            txtВысота.Location = new Point(150, 70);
            txtВысота.Name = "txtВысота";
            txtВысота.Size = new Size(100, 23);
            txtВысота.TabIndex = 5;
            // 
            // txtСторонаA
            // 
            txtСторонаA.Location = new Point(150, 99);
            txtСторонаA.Name = "txtСторонаA";
            txtСторонаA.Size = new Size(100, 23);
            txtСторонаA.TabIndex = 6;
            // 
            // txtСторонаB
            // 
            txtСторонаB.Location = new Point(150, 128);
            txtСторонаB.Name = "txtСторонаB";
            txtСторонаB.Size = new Size(100, 23);
            txtСторонаB.TabIndex = 7;
            // 
            // txtСторонаC
            // 
            txtСторонаC.Location = new Point(150, 157);
            txtСторонаC.Name = "txtСторонаC";
            txtСторонаC.Size = new Size(100, 23);
            txtСторонаC.TabIndex = 8;
            // 
            // btnРассчитать
            // 
            btnРассчитать.Location = new Point(12, 186);
            btnРассчитать.Name = "btnРассчитать";
            btnРассчитать.Size = new Size(238, 23);
            btnРассчитать.TabIndex = 9;
            btnРассчитать.Text = "Рассчитать";
            btnРассчитать.UseVisualStyleBackColor = true;
            btnРассчитать.Click += btnРассчитать_Click;
            // 
            // lblРезультатПлощади
            // 
            lblРезультатПлощади.AutoSize = true;
            lblРезультатПлощади.Location = new Point(12, 212);
            lblРезультатПлощади.Name = "lblРезультатПлощади";
            lblРезультатПлощади.Size = new Size(59, 15);
            lblРезультатПлощади.TabIndex = 10;
            lblРезультатПлощади.Text = "Площадь";
            // 
            // lblРезультатПериметра
            // 
            lblРезультатПериметра.AutoSize = true;
            lblРезультатПериметра.Location = new Point(12, 237);
            lblРезультатПериметра.Name = "lblРезультатПериметра";
            lblРезультатПериметра.Size = new Size(63, 15);
            lblРезультатПериметра.TabIndex = 11;
            lblРезультатПериметра.Text = "Периметр";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 12;
            label1.Text = "Радиус";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 44);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 13;
            label2.Text = "Ширина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 73);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 14;
            label3.Text = "Высота";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 102);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 15;
            label4.Text = "СторонаА";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 132);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 16;
            label5.Text = "СторонаВ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 160);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 17;
            label6.Text = "СторонаС";
            // 
            // ГлавнаяФорма
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 395);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblРезультатПериметра);
            Controls.Add(lblРезультатПлощади);
            Controls.Add(btnРассчитать);
            Controls.Add(txtСторонаC);
            Controls.Add(txtСторонаB);
            Controls.Add(txtСторонаA);
            Controls.Add(txtВысота);
            Controls.Add(txtШирина);
            Controls.Add(txtРадиус);
            Controls.Add(rbТреугольник);
            Controls.Add(rbПрямоугольник);
            Controls.Add(rbКруг);
            Name = "ГлавнаяФорма";
            Text = "Геометрические Фигуры";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.RadioButton rbКруг;
        private System.Windows.Forms.RadioButton rbПрямоугольник;
        private System.Windows.Forms.RadioButton rbТреугольник;
        private System.Windows.Forms.TextBox txtРадиус;
        private System.Windows.Forms.TextBox txtШирина;
        private System.Windows.Forms.TextBox txtВысота;
        private System.Windows.Forms.TextBox txtСторонаA;
        private System.Windows.Forms.TextBox txtСторонаB;
        private System.Windows.Forms.TextBox txtСторонаC;
        private System.Windows.Forms.Button btnРассчитать;
        private System.Windows.Forms.Label lblРезультатПлощади;
        private System.Windows.Forms.Label lblРезультатПериметра;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
