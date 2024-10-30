using System;
using System.Windows.Forms;

namespace ГеометрическиеФигуры
{
    public partial class ГлавнаяФорма : Form
    {
        public ГлавнаяФорма()
        {
            InitializeComponent();
        }

        private void btnРассчитать_Click(object sender, EventArgs e)
        {
            IФигура фигура = null;

            // Проверка выбранной радиокнопки и создание объекта фигуры
            if (rbКруг.Checked)
            {
                double радиус = double.Parse(txtРадиус.Text);
                фигура = new Круг(радиус);
            }
            else if (rbПрямоугольник.Checked)
            {
                double ширина = double.Parse(txtШирина.Text);
                double высота = double.Parse(txtВысота.Text);
                фигура = new Прямоугольник(ширина, высота);
            }
            else if (rbТреугольник.Checked)
            {
                double сторонаA = double.Parse(txtСторонаA.Text);
                double сторонаB = double.Parse(txtСторонаB.Text);
                double сторонаC = double.Parse(txtСторонаC.Text);
                фигура = new Треугольник(сторонаA, сторонаB, сторонаC);
            }

            // Если фигура выбрана, выполняем расчет
            if (фигура != null)
            {
                lblРезультатПлощади.Text = $"Площадь: {фигура.ВычислитьПлощадь():F2}";
                lblРезультатПериметра.Text = $"Периметр: {фигура.ВычислитьПериметр():F2}";
            }
        }
    }

    // Интерфейс фигуры
    public interface IФигура
    {
        double ВычислитьПлощадь();      // Метод для вычисления площади
        double ВычислитьПериметр();     // Метод для вычисления периметра
    }

    // Класс Круг
    public class Круг : IФигура
    {
        public double Радиус { get; set; }

        public Круг(double радиус)
        {
            Радиус = радиус;
        }

        public double ВычислитьПлощадь()
        {
            return Math.PI * Радиус * Радиус;
        }

        public double ВычислитьПериметр()
        {
            return 2 * Math.PI * Радиус;
        }
    }

    // Класс Прямоугольник
    public class Прямоугольник : IФигура
    {
        public double Ширина { get; set; }
        public double Высота { get; set; }

        public Прямоугольник(double ширина, double высота)
        {
            Ширина = ширина;
            Высота = высота;
        }

        public double ВычислитьПлощадь()
        {
            return Ширина * Высота;
        }

        public double ВычислитьПериметр()
        {
            return 2 * (Ширина + Высота);
        }
    }

    // Класс Треугольник
    public class Треугольник : IФигура
    {
        public double СторонаA { get; set; }
        public double СторонаB { get; set; }
        public double СторонаC { get; set; }

        public Треугольник(double сторонаA, double сторонаB, double сторонаC)
        {
            СторонаA = сторонаA;
            СторонаB = сторонаB;
            СторонаC = сторонаC;
        }

        public double ВычислитьПлощадь()
        {
            double полупериметр = (СторонаA + СторонаB + СторонаC) / 2;
            return Math.Sqrt(полупериметр * (полупериметр - СторонаA) * (полупериметр - СторонаB) * (полупериметр - СторонаC));
        }

        public double ВычислитьПериметр()
        {
            return СторонаA + СторонаB + СторонаC;
        }
    }
}
