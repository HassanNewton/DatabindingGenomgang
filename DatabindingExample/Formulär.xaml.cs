using System.ComponentModel;
using System.Windows;

namespace DatabindingExample
{
    /// <summary>
    /// Interaction logic for Formulär.xaml
    /// </summary>
    public partial class Formulär : Window, INotifyPropertyChanged
    {
        public Formulär()
        {
            InitializeComponent();
            DataContext = this;
        }


        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(firstName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(lastName));
                OnPropertyChanged("FullName");
            }
        }

        private string fullName;

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
















        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
