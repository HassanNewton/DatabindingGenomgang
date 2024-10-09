using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DatabindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Boundtext
        {
            get { return boundText; }
            set
            {
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            Boundtext = "Text från codeBehind";
        }
    }
}