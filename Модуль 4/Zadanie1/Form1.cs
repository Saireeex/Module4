using System;
using System.Windows.Forms;

namespace ��������������������
{
    public partial class ������������ : Form
    {
        public ������������()
        {
            InitializeComponent();
        }

        private void btn����������_Click(object sender, EventArgs e)
        {
            I������ ������ = null;

            // �������� ��������� ����������� � �������� ������� ������
            if (rb����.Checked)
            {
                double ������ = double.Parse(txt������.Text);
                ������ = new ����(������);
            }
            else if (rb�������������.Checked)
            {
                double ������ = double.Parse(txt������.Text);
                double ������ = double.Parse(txt������.Text);
                ������ = new �������������(������, ������);
            }
            else if (rb�����������.Checked)
            {
                double �������A = double.Parse(txt�������A.Text);
                double �������B = double.Parse(txt�������B.Text);
                double �������C = double.Parse(txt�������C.Text);
                ������ = new �����������(�������A, �������B, �������C);
            }

            // ���� ������ �������, ��������� ������
            if (������ != null)
            {
                lbl����������������.Text = $"�������: {������.����������������():F2}";
                lbl������������������.Text = $"��������: {������.�����������������():F2}";
            }
        }
    }

    // ��������� ������
    public interface I������
    {
        double ����������������();      // ����� ��� ���������� �������
        double �����������������();     // ����� ��� ���������� ���������
    }

    // ����� ����
    public class ���� : I������
    {
        public double ������ { get; set; }

        public ����(double ������)
        {
            ������ = ������;
        }

        public double ����������������()
        {
            return Math.PI * ������ * ������;
        }

        public double �����������������()
        {
            return 2 * Math.PI * ������;
        }
    }

    // ����� �������������
    public class ������������� : I������
    {
        public double ������ { get; set; }
        public double ������ { get; set; }

        public �������������(double ������, double ������)
        {
            ������ = ������;
            ������ = ������;
        }

        public double ����������������()
        {
            return ������ * ������;
        }

        public double �����������������()
        {
            return 2 * (������ + ������);
        }
    }

    // ����� �����������
    public class ����������� : I������
    {
        public double �������A { get; set; }
        public double �������B { get; set; }
        public double �������C { get; set; }

        public �����������(double �������A, double �������B, double �������C)
        {
            �������A = �������A;
            �������B = �������B;
            �������C = �������C;
        }

        public double ����������������()
        {
            double ������������ = (�������A + �������B + �������C) / 2;
            return Math.Sqrt(������������ * (������������ - �������A) * (������������ - �������B) * (������������ - �������C));
        }

        public double �����������������()
        {
            return �������A + �������B + �������C;
        }
    }
}
