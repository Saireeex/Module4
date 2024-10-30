using System;
using System.Windows.Forms;

namespace LibraryApp
{
    // ��������� �����
    public interface IBook
    {
        bool IsAvailable { get; }
        void IssueBook();
        string GetBookInfo(); // �������������� ����� ��� ��������� ���������� � �����
    }

    // ����� �������������� �����
    public class FictionBook : IBook
    {
        private bool isAvailable;
        private string title;

        public FictionBook(string title, bool available)
        {
            this.title = title;
            this.isAvailable = available;
        }

        public bool IsAvailable => isAvailable;

        public void IssueBook()
        {
            if (isAvailable)
            {
                MessageBox.Show($"{title} ������.");
                isAvailable = false;
            }
            else
            {
                MessageBox.Show($"{title} ���������� ��� ������.");
            }
        }

        public string GetBookInfo()
        {
            return $"�������������� �����: {title}";
        }
    }

    // ����� ������� �����
    public class ScienceBook : IBook
    {
        private bool isAvailable;
        private string title;

        public ScienceBook(string title, bool available)
        {
            this.title = title;
            this.isAvailable = available;
        }

        public bool IsAvailable => isAvailable;

        public void IssueBook()
        {
            if (isAvailable)
            {
                MessageBox.Show($"{title} ������.");
                isAvailable = false;
            }
            else
            {
                MessageBox.Show($"{title} ���������� ��� ������.");
            }
        }

        public string GetBookInfo()
        {
            return $"������� �����: {title}";
        }
    }

    // ����� ������������
    public class EncyclopediaBook : IBook
    {
        private bool isAvailable;
        private string title;

        public EncyclopediaBook(string title, bool available)
        {
            this.title = title;
            this.isAvailable = available;
        }

        public bool IsAvailable => isAvailable;

        public void IssueBook()
        {
            if (isAvailable)
            {
                MessageBox.Show($"{title} ������.");
                isAvailable = false;
            }
            else
            {
                MessageBox.Show($"{title} ���������� ��� ������.");
            }
        }

        public string GetBookInfo()
        {
            return $"������������: {title}";
        }
    }

    public partial class MainForm : Form
    {
        private IBook currentBook;

        public MainForm()
        {
            InitializeComponent();
        }

        // ���������� ������� ������ "������� �����"
        private void SelectBookButton_Click(object sender, EventArgs e)
        {
            // ������ �������� ������ ����� ����
            string selectedType = comboBoxBookType.SelectedItem?.ToString();

            switch (selectedType)
            {
                case "�������������� �����":
                    currentBook = new FictionBook("����� � ���", true);
                    break;
                case "������� �����":
                    currentBook = new ScienceBook("��������� ������", true);
                    break;
                case "������������":
                    currentBook = new EncyclopediaBook("������������ ��������", true);
                    break;
                default:
                    MessageBox.Show("�������� ��� �����.");
                    return;
            }

            MessageBox.Show(currentBook.GetBookInfo());
        }

        // ���������� ������� ������ "��������� �����������"
        private void CheckAvailabilityButton_Click(object sender, EventArgs e)
        {
            if (currentBook != null)
            {
                if (currentBook.IsAvailable)
                {
                    MessageBox.Show("����� ��������.");
                }
                else
                {
                    MessageBox.Show("����� ����������.");
                }
            }
            else
            {
                MessageBox.Show("������� �������� �����.");
            }
        }

        // ���������� ������� ������ "������ �����"
        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            if (currentBook != null)
            {
                currentBook.IssueBook();
            }
            else
            {
                MessageBox.Show("������� �������� �����.");
            }
        }
    }
}
