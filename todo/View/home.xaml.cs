using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using todo.ViewModel;

namespace todo.View
{
    public partial class home : Window
    {
        public home()
        {
            InitializeComponent();
            async void time()
            {
                Clock.Text = DateTime.Now.ToString();
                await Task.Delay(1000);
                time();
            }
            time();
        }

        private void Home_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Add_ToDo(object sender, RoutedEventArgs e)
        {
            ToDoListViewModel.AddItem(ToDoName.Text);    
            ToDoName.Text = "";
        }
    }
}