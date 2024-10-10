using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DatabindingExample
{
    /// <summary>
    /// Interaction logic for Exempel4.xaml
    /// </summary>
    public partial class Exempel4 : Window, INotifyPropertyChanged
    {
        public Exempel4()
        {
            InitializeComponent();
            //Sätt datacontext till this
            DataContext = this;
        }

        private double sliderValue;
        public double SliderValue
        {
            get { return sliderValue; }
            set
            {
                sliderValue = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
