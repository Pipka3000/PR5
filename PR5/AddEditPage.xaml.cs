using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PR5
{

    //Код для кнопки сохранить
    
    public partial class AddEditPage : Window
    {
        private @class _currentClass = new @class();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentClass;

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e) //Метод для сохранения данных
        {
            StringBuilder errors = new StringBuilder(); //StringBuilder выделяет какую-то часть памяти
            if (string.IsNullOrWhiteSpace(_currentClass.name_class.ToString())) // Метод IsNullOrWhiteSpace проверяет текст на null или текст состоит только из пробелов.
                errors.AppendLine("Нужно указать ID"); // Добавляет знак завершения строки по умолчанию в конец текущего объекта StringBuilder
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            {
                Gura_PR5Entities.Get_context().@class.Add(_currentClass);


                try
                {
                    Gura_PR5.Get_context().SaveChanges(); //Используется для сохранения изменений даннных в таблице
                    MessageBox.Show("Информация сохранена"); //Если условие не выполняется, то выходит окно с этим сообщением
                    MainWindow mainWindow = new MainWindow(); //Объявление метода "Show"
                    mainWindow.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message.ToString()); //Выполняется в том случае, если не выполнился thy
                }
            }
        }

    }
}
