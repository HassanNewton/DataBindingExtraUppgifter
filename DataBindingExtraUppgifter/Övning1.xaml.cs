using System.ComponentModel;
using System.Windows;

namespace DataBindingExtraUppgifter
{
    /// <summary>
    /// Interaction logic for Övning1.xaml
    /// </summary>
    public partial class Övning1 : Window, INotifyPropertyChanged
    {
        private int _age = 25;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public Övning1()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
