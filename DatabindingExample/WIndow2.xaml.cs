using System.ComponentModel;
using System.Windows;

namespace DatabindingExample
{
    /// <summary>
    /// Interaction logic for WIndow2.xaml
    /// </summary>
    public partial class WIndow2 : Window, INotifyPropertyChanged
    {
        public List<string> Countries { get; set; }

        public WIndow2()
        {
            InitializeComponent();
            Countries = new List<string> { "Sverige", "Danmark", "Norge" };
            DataContext = this;
        }


        private string selectedCountry;

        public string SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                selectedCountry = value;
                OnPropertyChanged(nameof(SelectedCountry));
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
