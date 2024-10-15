using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;


namespace DataGridExempel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //Viktigt!!!!!
            DataContext = this;
            Products = new ObservableCollection<Product>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ProductPriceBox.Text, out double price))
            {
                Products.Add(new Product
                {
                    Name = ProductNameBox.Text,
                    Price = price
                });
            }
            else
            {
                MessageBox.Show("Fel inmatning");
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    //Steg 1 Binding till något property i XAML
    //Steg 2 Implementera INotifyPropertyChanged sätta DATACONTEXT
    //Steg 3 Implementera OnPropoertyChanged()
    //Steg 4 Skapa properties mha propfull
    //Steg 5 Anropa onpropretychanged() i set metoden för vårt bundna property
}