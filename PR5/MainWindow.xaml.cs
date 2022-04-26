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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace PR5
{

    //Код для кнопки добавить
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DGridClass.ItemsSource = Gura_PR5Entities.Get_context().@class.ToList();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e) //Что будет происходить при нажатии на эту кнопку
        {
            AddEditPage addEditPage = new AddEditPage();
            addEditPage.Show();
            this.Close(); 
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {                                                                                              // Reload повторно загружает сущность из базы данных, перезаписывая все значения свойств значениями из базы данных.
                Gura_PR5Entities.Get_context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());  //ToList принудительно выполняет вычисление запроса и возвращает List<T> значение, содержащее результаты запроса. 
                DGridClass.ItemsSource = Gura_PR5Entities.Get_context().@class.ToList(); //ItemsSource указывает на коллекцию, содержащую все объекты, которые будут показаны в списке
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
