using System;
using System.Windows.Forms;

namespace LibraryApp
{
    // Интерфейс книги
    public interface IBook
    {
        bool IsAvailable { get; }
        void IssueBook();
        string GetBookInfo(); // Дополнительный метод для получения информации о книге
    }

    // Класс художественной книги
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
                MessageBox.Show($"{title} выдана.");
                isAvailable = false;
            }
            else
            {
                MessageBox.Show($"{title} недоступна для выдачи.");
            }
        }

        public string GetBookInfo()
        {
            return $"Художественная книга: {title}";
        }
    }

    // Класс научной книги
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
                MessageBox.Show($"{title} выдана.");
                isAvailable = false;
            }
            else
            {
                MessageBox.Show($"{title} недоступна для выдачи.");
            }
        }

        public string GetBookInfo()
        {
            return $"Научная книга: {title}";
        }
    }

    // Класс энциклопедии
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
                MessageBox.Show($"{title} выдана.");
                isAvailable = false;
            }
            else
            {
                MessageBox.Show($"{title} недоступна для выдачи.");
            }
        }

        public string GetBookInfo()
        {
            return $"Энциклопедия: {title}";
        }
    }

    public partial class MainForm : Form
    {
        private IBook currentBook;

        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки "Выбрать книгу"
        private void SelectBookButton_Click(object sender, EventArgs e)
        {
            // Пример создания разных типов книг
            string selectedType = comboBoxBookType.SelectedItem?.ToString();

            switch (selectedType)
            {
                case "Художественная книга":
                    currentBook = new FictionBook("Война и мир", true);
                    break;
                case "Научная книга":
                    currentBook = new ScienceBook("Квантовая физика", true);
                    break;
                case "Энциклопедия":
                    currentBook = new EncyclopediaBook("Энциклопедия животных", true);
                    break;
                default:
                    MessageBox.Show("Выберите тип книги.");
                    return;
            }

            MessageBox.Show(currentBook.GetBookInfo());
        }

        // Обработчик нажатия кнопки "Проверить доступность"
        private void CheckAvailabilityButton_Click(object sender, EventArgs e)
        {
            if (currentBook != null)
            {
                if (currentBook.IsAvailable)
                {
                    MessageBox.Show("Книга доступна.");
                }
                else
                {
                    MessageBox.Show("Книга недоступна.");
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите книгу.");
            }
        }

        // Обработчик нажатия кнопки "Выдать книгу"
        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            if (currentBook != null)
            {
                currentBook.IssueBook();
            }
            else
            {
                MessageBox.Show("Сначала выберите книгу.");
            }
        }
    }
}
