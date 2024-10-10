using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DatabindingExample
{
    /// <summary>
    /// Interaction logic for Exempel5.xaml
    /// </summary>
    public partial class Exempel5 : Window, INotifyPropertyChanged
    {
        //ObservableCollection
        public ObservableCollection<string> Categories { get; set; }

        public ObservableCollection<string> Items { get; set; }

        public Exempel5()
        {
            InitializeComponent();
            DataContext = this;
            Categories = new ObservableCollection<string>
            { "Frukter", "Grönsaker"};

            Items = new ObservableCollection<string>();

        }

        private void UpdateItems()
        {
            Items.Clear();

            if (SelectedCategory == "Frukter")
            {
                Items.Add("Banan");
                Items.Add("Vattenmelon");
                Items.Add("Mango");
            }
            else if (SelectedCategory == "Grönsaker")
            {
                Items.Add("Tomat");
                Items.Add("Gurka");
                Items.Add("Spenat");
            }
        }


        private string _selectedCategory;

        public string SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged();
                UpdateItems();
            }
        }





        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
