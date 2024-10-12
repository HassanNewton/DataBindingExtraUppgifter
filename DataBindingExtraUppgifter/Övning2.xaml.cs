using System.ComponentModel;
using System.Windows;

namespace DataBindingExtraUppgifter
{
    /// <summary>
    /// Interaction logic for Övning2.xaml
    /// </summary>
    public partial class Övning2 : Window, INotifyPropertyChanged
    {
        private string _streetAddress;
        private string _zipCode;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set
            {
                _streetAddress = value;
                OnPropertyChanged(nameof(StreetAddress));
                OnPropertyChanged(nameof(FullAddress));
            }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                _zipCode = value;
                OnPropertyChanged(nameof(ZipCode));
                OnPropertyChanged(nameof(FullAddress));
            }
        }

        public string FullAddress => $"{StreetAddress}, {ZipCode}";
        //Kan även skrivas som följande 
        // public string FullAddress { get { return $"{StreetAddress}, {ZipCode}"; } }


        public Övning2()
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
