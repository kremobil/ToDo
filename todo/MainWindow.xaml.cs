using System;
using System.Threading.Tasks;

namespace todo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
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
    }
}