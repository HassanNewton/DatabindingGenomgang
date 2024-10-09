using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace DatabindingExample
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window, INotifyPropertyChanged
    {
        public ObservableCollection<string> Tasks { get; set; }

        public Window3()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<string>();
            DataContext = this;
        }

        private string selectedTask;

        public string SelectedTask
        {
            get { return selectedTask; }
            set
            {
                selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }


        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            Tasks.Add(txtBoxInput.Text);
            txtBoxInput.Clear();

        }

        private void RemoveTask_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedTask != null)
            {
                Tasks.Remove(SelectedTask);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
